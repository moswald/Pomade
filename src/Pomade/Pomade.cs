namespace Pomade
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Threading.Tasks;
    using Dapper;

    // ReSharper disable once ClassWithVirtualMembersNeverInherited.Global - these virtuals are meant to be overridden in tests
    public class Pomade : IDisposable
    {
        readonly IDbConnection _dbConnection;

        // empty constructor required for some mocking frameworks
        public Pomade()
        {
        }

        public Pomade(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public IDbConnection DbConnection => _dbConnection;

        public virtual Task<IEnumerable<dynamic>> QueryAsync(string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null) => _dbConnection.QueryAsync(sql, param, transaction, commandTimeout, commandType);
        public virtual Task<IEnumerable<dynamic>> QueryAsync(CommandDefinition command) => _dbConnection.QueryAsync(command);
        public virtual Task<dynamic> QueryFirstAsync(CommandDefinition command) => _dbConnection.QueryFirstAsync(command);
        public virtual Task<dynamic> QueryFirstOrDefaultAsync(CommandDefinition command) => _dbConnection.QueryFirstOrDefaultAsync(command);
        public virtual Task<dynamic> QuerySingleAsync(CommandDefinition command) => _dbConnection.QuerySingleAsync(command);
        public virtual Task<dynamic> QuerySingleOrDefaultAsync(CommandDefinition command) => _dbConnection.QuerySingleOrDefaultAsync(command);
        public virtual Task<IEnumerable<T>> QueryAsync<T>(string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null) => _dbConnection.QueryAsync<T>(sql, param, transaction, commandTimeout, commandType);
        public virtual Task<T> QueryFirstAsync<T>(string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null) => _dbConnection.QueryFirstAsync<T>(sql, param, transaction, commandTimeout, commandType);
        public virtual Task<T> QueryFirstOrDefaultAsync<T>(string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null) => _dbConnection.QueryFirstOrDefaultAsync<T>(sql, param, transaction, commandTimeout, commandType);
        public virtual Task<T> QuerySingleAsync<T>(string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null) => _dbConnection.QuerySingleAsync<T>(sql, param, transaction, commandTimeout, commandType);
        public virtual Task<T> QuerySingleOrDefaultAsync<T>(string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null) => _dbConnection.QuerySingleOrDefaultAsync<T>(sql, param, transaction, commandTimeout, commandType);
        public virtual Task<IEnumerable<object>> QueryAsync(Type type, string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null) => _dbConnection.QueryAsync(type, sql, param, transaction, commandTimeout, commandType);
        public virtual Task<object> QueryFirstAsync(Type type, string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null) => _dbConnection.QueryFirstAsync(type, sql, param, transaction, commandTimeout, commandType);
        public virtual Task<object> QueryFirstOrDefaultAsync(Type type, string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null) => _dbConnection.QueryFirstOrDefaultAsync(type, sql, param, transaction, commandTimeout, commandType);
        public virtual Task<object> QuerySingleAsync(Type type, string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null) => _dbConnection.QuerySingleAsync(type, sql, param, transaction, commandTimeout, commandType);
        public virtual Task<object> QuerySingleOrDefaultAsync(Type type, string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null) => _dbConnection.QuerySingleOrDefaultAsync(type, sql, param, transaction, commandTimeout, commandType);
        public virtual Task<IEnumerable<T>> QueryAsync<T>(CommandDefinition command) => _dbConnection.QueryAsync<T>(command);
        public virtual Task<IEnumerable<object>> QueryAsync(Type type, CommandDefinition command) => _dbConnection.QueryAsync(type, command);
        public virtual Task<object> QueryFirstAsync(Type type, CommandDefinition command) => _dbConnection.QueryFirstAsync(type, command);
        public virtual Task<object> QueryFirstOrDefaultAsync(Type type, CommandDefinition command) => _dbConnection.QueryFirstOrDefaultAsync(type, command);
        public virtual Task<object> QuerySingleAsync(Type type, CommandDefinition command) => _dbConnection.QuerySingleAsync(type, command);
        public virtual Task<object> QuerySingleOrDefaultAsync(Type type, CommandDefinition command) => _dbConnection.QuerySingleOrDefaultAsync(type, command);
        public virtual Task<int> ExecuteAsync(string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null) => _dbConnection.ExecuteAsync(sql, param, transaction, commandTimeout, commandType);
        public virtual Task<int> ExecuteAsync(CommandDefinition command) => _dbConnection.ExecuteAsync(command);
        public virtual Task<IEnumerable<TReturn>> QueryAsync<TFirst, TSecond, TReturn>(string sql, Func<TFirst, TSecond, TReturn> map, object param = null, IDbTransaction transaction = null, bool buffered = true, string splitOn = "Id", int? commandTimeout = null, CommandType? commandType = null) => _dbConnection.QueryAsync(sql, map, param, transaction, buffered, splitOn, commandTimeout, commandType);
        public virtual Task<IEnumerable<TReturn>> QueryAsync<TFirst, TSecond, TReturn>(CommandDefinition command, Func<TFirst, TSecond, TReturn> map, string splitOn = "Id") => _dbConnection.QueryAsync(command, map, splitOn);
        public virtual Task<IEnumerable<TReturn>> QueryAsync<TFirst, TSecond, TThird, TReturn>(string sql, Func<TFirst, TSecond, TThird, TReturn> map, object param = null, IDbTransaction transaction = null, bool buffered = true, string splitOn = "Id", int? commandTimeout = null, CommandType? commandType = null) => _dbConnection.QueryAsync(sql, map, param, transaction, buffered, splitOn, commandTimeout, commandType);
        public virtual Task<IEnumerable<TReturn>> QueryAsync<TFirst, TSecond, TThird, TReturn>(CommandDefinition command, Func<TFirst, TSecond, TThird, TReturn> map, string splitOn = "Id") => _dbConnection.QueryAsync(command, map, splitOn);
        public virtual Task<IEnumerable<TReturn>> QueryAsync<TFirst, TSecond, TThird, TFourth, TReturn>(string sql, Func<TFirst, TSecond, TThird, TFourth, TReturn> map, object param = null, IDbTransaction transaction = null, bool buffered = true, string splitOn = "Id", int? commandTimeout = null, CommandType? commandType = null) => _dbConnection.QueryAsync(sql, map, param, transaction, buffered, splitOn, commandTimeout, commandType);
        public virtual Task<IEnumerable<TReturn>> QueryAsync<TFirst, TSecond, TThird, TFourth, TReturn>(CommandDefinition command, Func<TFirst, TSecond, TThird, TFourth, TReturn> map, string splitOn = "Id") => _dbConnection.QueryAsync(command, map, splitOn);
        public virtual Task<IEnumerable<TReturn>> QueryAsync<TFirst, TSecond, TThird, TFourth, TFifth, TReturn>(string sql, Func<TFirst, TSecond, TThird, TFourth, TFifth, TReturn> map, object param = null, IDbTransaction transaction = null, bool buffered = true, string splitOn = "Id", int? commandTimeout = null, CommandType? commandType = null) => _dbConnection.QueryAsync(sql, map, param, transaction, buffered, splitOn, commandTimeout, commandType);
        public virtual Task<IEnumerable<TReturn>> QueryAsync<TFirst, TSecond, TThird, TFourth, TFifth, TReturn>(CommandDefinition command, Func<TFirst, TSecond, TThird, TFourth, TFifth, TReturn> map, string splitOn = "Id") => _dbConnection.QueryAsync(command, map, splitOn);
        public virtual Task<IEnumerable<TReturn>> QueryAsync<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TReturn>(string sql, Func<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TReturn> map, object param = null, IDbTransaction transaction = null, bool buffered = true, string splitOn = "Id", int? commandTimeout = null, CommandType? commandType = null) => _dbConnection.QueryAsync(sql, map, param, transaction, buffered, splitOn, commandTimeout, commandType);
        public virtual Task<IEnumerable<TReturn>> QueryAsync<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TReturn>(CommandDefinition command, Func<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TReturn> map, string splitOn = "Id") => _dbConnection.QueryAsync(command, map, splitOn);
        public virtual Task<IEnumerable<TReturn>> QueryAsync<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TSeventh, TReturn>(string sql, Func<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TSeventh, TReturn> map, object param = null, IDbTransaction transaction = null, bool buffered = true, string splitOn = "Id", int? commandTimeout = null, CommandType? commandType = null) => _dbConnection.QueryAsync(sql, map, param, transaction, buffered, splitOn, commandTimeout, commandType);
        public virtual Task<IEnumerable<TReturn>> QueryAsync<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TSeventh, TReturn>(CommandDefinition command, Func<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TSeventh, TReturn> map, string splitOn = "Id") => _dbConnection.QueryAsync(command, map, splitOn);
        public virtual Task<IEnumerable<TReturn>> QueryAsync<TReturn>(string sql, Type[] types, Func<object[], TReturn> map, object param = null, IDbTransaction transaction = null, bool buffered = true, string splitOn = "Id", int? commandTimeout = null, CommandType? commandType = null) => _dbConnection.QueryAsync(sql, types, map, param, transaction, buffered, splitOn, commandTimeout, commandType);
        public virtual Task<IDataReader> ExecuteReaderAsync(string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null) => _dbConnection.ExecuteReaderAsync(sql, param, transaction, commandTimeout, commandType);
        public virtual Task<IDataReader> ExecuteReaderAsync(CommandDefinition command) => _dbConnection.ExecuteReaderAsync(command);
        public virtual Task<object> ExecuteScalarAsync(string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null) => _dbConnection.ExecuteScalarAsync(sql, param, transaction, commandTimeout, commandType);
        public virtual Task<T> ExecuteScalarAsync<T>(string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null) => _dbConnection.ExecuteScalarAsync<T>(sql, param, transaction, commandTimeout, commandType);
        public virtual Task<object> ExecuteScalarAsync(CommandDefinition command) => _dbConnection.ExecuteScalarAsync(command);
        public virtual Task<T> ExecuteScalarAsync<T>(CommandDefinition command) => _dbConnection.ExecuteScalarAsync<T>(command);

        public virtual async Task<AsyncGridReader> QueryMultipleAsync(string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null) => new AsyncGridReader(await _dbConnection.QueryMultipleAsync(sql, param, transaction, commandTimeout, commandType));
        public virtual async Task<AsyncGridReader> QueryMultipleAsync(CommandDefinition command) => new AsyncGridReader(await _dbConnection.QueryMultipleAsync(command));

        public virtual void Dispose() => _dbConnection?.Dispose();

        public class AsyncGridReader : IDisposable
        {
            readonly SqlMapper.GridReader _gridReader;

            // empty constructor required for some mocking frameworks
            public AsyncGridReader()
            {
            }

            public AsyncGridReader(SqlMapper.GridReader gridReader)
            {
                _gridReader = gridReader;
            }

            public virtual Task<IEnumerable<object>> ReadAsync(bool buffered = true) => _gridReader.ReadAsync(buffered);
            public virtual Task<object> ReadFirstAsync() => _gridReader.ReadFirstAsync();
            public virtual Task<object> ReadFirstOrDefaultAsync() => _gridReader.ReadFirstOrDefaultAsync();
            public virtual Task<object> ReadSingleAsync() => _gridReader.ReadSingleAsync();
            public virtual Task<object> ReadSingleOrDefaultAsync() => _gridReader.ReadSingleOrDefaultAsync();
            public virtual Task<IEnumerable<object>> ReadAsync(Type type, bool buffered = true) => _gridReader.ReadAsync(type, buffered);
            public virtual Task<object> ReadFirstAsync(Type type) => _gridReader.ReadFirstAsync(type);
            public virtual Task<object> ReadFirstOrDefaultAsync(Type type) => _gridReader.ReadFirstOrDefaultAsync(type);
            public virtual Task<object> ReadSingleAsync(Type type) => _gridReader.ReadSingleAsync(type);
            public virtual Task<object> ReadSingleOrDefaultAsync(Type type) => _gridReader.ReadSingleOrDefaultAsync(type);
            public virtual Task<IEnumerable<T>> ReadAsync<T>(bool buffered = true) => _gridReader.ReadAsync<T>(buffered);
            public virtual Task<T> ReadFirstAsync<T>() => _gridReader.ReadFirstAsync<T>();
            public virtual Task<T> ReadFirstOrDefaultAsync<T>() => _gridReader.ReadFirstOrDefaultAsync<T>();
            public virtual Task<T> ReadSingleAsync<T>() => _gridReader.ReadSingleAsync<T>();
            public virtual Task<T> ReadSingleOrDefaultAsync<T>() => _gridReader.ReadSingleOrDefaultAsync<T>();

            public virtual void Dispose() => _gridReader?.Dispose();
        }
    }
}
