using Dapper; 
using Npgsql;
using Domain.Dto;
public class QuoteService
{
    private string  _connectionString = "Server=127.0.0.1;Port=5432;Database=Dapper_exzam;User Id=postgres;Password=Hakimov9111m;";

   public List<QuoteDto> GetInfoQuotes()
    {
        using (var conn = new NpgsqlConnection(_connectionString))
        {
            var sql = "Select * from Quotes";
            
            return conn.Query<QuoteDto>(sql).ToList();
        }
    }
       public int InsertQuotes(QuoteDto  quotes)
        {
            using (var conn = new NpgsqlConnection(_connectionString))
            {
                var sql =
                    $"insert into Quotes (Autor, QuoteText,Categoryid) VALUES "
                    + $"('{quotes.Author}', "
                    + $"'{quotes.QuoteText}', "
                    + $"'{quotes.Categoryid}')"; 

                var result = conn.Execute(sql);

                return result;
            }
        }

         public int UpdateQuotes(QuoteDto quotes)
        {
            using (var conn = new NpgsqlConnection(_connectionString))
            {
                var sql = 
                    $"UPDATE Quotes SET "
                    + $"Autor = '{quotes.Author}', "
                    + $"QuoteText = '{quotes.QuoteText}', "
                    + $"Categoryid = {quotes.Categoryid} "
                    + $"WHERE id = {quotes.id}";

                var result = conn.Execute(sql);

                return result;
            }
        }

          public int DeleteQuotes(int id)
        {
            using (var conn = new NpgsqlConnection(_connectionString))
            {
                var sql = $"DELETE FROM Quotes WHERE id = {id}";

                var result = conn.Execute(sql);

                return result;
            }
        }
    public List<QuoteDto> GetRandomQuotes()
    {
        using (var conn = new NpgsqlConnection(_connectionString))
        {
            var sql = "select * from Quotes order by random() limit 1";
            
            return conn.Query<QuoteDto>(sql).ToList();
        }
    }
        public List<QuoteDto> GetQuotesByCategory(int id)
    {
       using (var conn = new NpgsqlConnection(_connectionString))
        {
            var sql = 
            $"Select * from quotes where categoryid = {id}";  
            
            return conn.Query<QuoteDto>(sql, new {id}).ToList();
        }
    }

        
}