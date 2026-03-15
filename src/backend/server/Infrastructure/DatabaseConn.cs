
namespace Auctions.Infrastructure{
    using Npgsql;
    class DatabaseConn{
        public async Task DbConnect(){
            var connString=Environment.GetEnvironmentVariable("CONNECTION_STRING");
            await using var conn=new NpgsqlConnection(connString);
            await conn.OpenAsync();
        }
    }
}