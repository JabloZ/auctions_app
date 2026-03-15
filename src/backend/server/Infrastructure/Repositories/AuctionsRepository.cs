namespace Auctions.Infrastructure.Repositories{
    using Npgsql;
    class AuctionsRepository{
        public DatabaseConn cur=new DatabaseConn();
        public async Task GetAuctionsList(){
            using (var conn=await cur.DbConnect()){
                await using(var req=new NpgsqlCommand("SELECT * FROM users", conn))
                await using(var reader=await req.ExecuteReaderAsync()){
                    while (await reader.ReadAsync()){
                        Console.WriteLine(reader.GetInt32(0));
                    }
                }
            }
        }
    }
}