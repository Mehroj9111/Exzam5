using Dapper;
using Npgsql;
using Domain.Dtos;

public class CategoryService
{
    private string  _connectionString = "Server=127.0.0.1;Port=5432;Database=Dapper_exzam;User Id=postgres;Password=Hakimov9111m;";

   public List<CategoryDto> GetInfoCategory()
    {
        using (var conn = new NpgsqlConnection(_connectionString))
        {
            var sql = "Select * from Category";
            
            return conn.Query<CategoryDto>(sql).ToList();
        }
    }
       public int InsertCategory(CategoryDto  category)
        {
            using (var conn = new NpgsqlConnection(_connectionString))
            {
                var sql =
                    $"insert into Category (CategoryName) VALUES " +
                    $"('{category.CategoryName}')"; 

                var result = conn.Execute(sql);

                return result;
            }
        }

         public int UpdateCategory(CategoryDto category)
        {
            using (var conn = new NpgsqlConnection(_connectionString))
            {
                var sql = 
                    $"UPDATE Category SET " +
                    $"id = {category.id}, " +
                    $"Categoryname = '{category.CategoryName}'" +
                    $"WHERE id = {category.id}";

                var result = conn.Execute(sql);

                return result;
            }
        }

          public int DeleteCategory(int id)
        {
            using (var conn = new NpgsqlConnection(_connectionString))
            {
                var sql = $"DELETE FROM Category WHERE id = {id}";

                var result = conn.Execute(sql);

                return result;
            }
        }
        
}