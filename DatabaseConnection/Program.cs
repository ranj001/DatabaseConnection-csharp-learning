namespace DatabaseConnection
{
    class Program
    {
        static void Main(string[] args)
        {
            var sqlConnection = new SqlConnection("Server=myServer;Database=mySqlDB;User Id=myUser;Password=myPass;");
            sqlConnection.Open();
            sqlConnection.Close();

        }
    }
}