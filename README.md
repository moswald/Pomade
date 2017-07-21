# Pomade - making (async) Dapper code testable

[![Build status](https://ci.appveyor.com/api/projects/status/esjyqu9dli0dc7ty?svg=true)](https://ci.appveyor.com/project/moswald/pomade)

## About

[Dapper](https://github.com/StackExchange/Dapper) is a great "mini ORM" library, but it's implemented almost entirely with extension methods which makes calling code very difficult to test. Pomade helps by forwarding calls to Dapper through `virtual` methods.

Also it helps by only implementing the `async` methods. *\*cough\** :innocent:

## Explanation

Dapper extends the `IDbConnection` interface with methods like `QueryAsync`:

```csharp
IDbConnection _connection = new SqlConnection();

public Task<Dog> LookupDog(Guid guid)
    => _connection.QueryAsync<Dog>("select Age = @Age, Id = @Id", new { Age = (int?)null, Id = guid });
```

Unfortunately, this makes `LookupDog()` difficult to test as `_connection` is not easily replaced by most mocking frameworks.

Pomade helps get around this limitation by instead making those extension methods `virtual` members, and thus, mockable. To use, pass your `IDbConnection` reference to the `Pomade` class constructor and use that as your data access layer:

```csharp
Pomade _connection = new Pomade(new SqlConnection());

public Task<Dog> LookupDog(Guid guid)
    => _connection.QueryAsync<Dog>("select Age = @Age, Id = @Id", new { Age = (int?)null, Id = guid });
```

Other than the type of the `_connection` field, the important stuff is exactly the same. The _real_ difference comes in your tests. Since `Pomade.QueryAsync<T>` is a `virtual` method, you can inject `Pomade` instances into your tests and once again enjoy the ability to easily mock the database layer away.

### Test example using [NSubstitute](http://nsubstitute.github.io/):

```csharp
var db = Substitute.ForPartsOf<Pomade>();
db.QueryAsync<Dog>(Arg.Any<string>(), Arg.Any<object>())
    .Returns(new Dog("Fido"));
```

## Performance

"[Dapper is stupid fast](https://github.com/StackExchange/Dapper#performance), aren't you just slowing it down by making all the calls `virtual`?"

Nope.

   Method |     Mean |     Error |    StdDev | Scaled |
--------- |---------:|----------:|----------:|-------:|
   Dapper | 216.1 us | 0.7570 us | 0.5910 us |   1.00 |
   Pomade | 216.6 us | 1.8440 us | 1.5398 us |   1.00 |
