namespace DatabaseConnection
{


    class Program
    {
        static void Main(string[] args)
        {
            //var sqlConnection = new SqlConnection("Server=mySQLServer;Database=mySqlDB;User Id=mySQLUser;Password=mySQLPass;");
            //sqlConnection.Open();
            //sqlConnection.Close();

            //var oracleConnection = new OracelConnection("Data Source=myOracleDB;User Id=myOracleUser;Password=myOraclePass;");
            //oracleConnection.Open();   
            //oracleConnection.Close();

            var sqlCommand = new DbCommand(new SqlConnection("Server=mySQLServer;Database=mySqlDB;User Id=mySQLUser;Password=mySQLPass;"));
            sqlCommand.Execute("SELECT * FROM Users");

            var oracleCommand = new DbCommand(new OracelConnection("Data Source=myOracleDB;User Id=myOracleUser;Password=myOraclePass;"));
            oracleCommand.Execute("SELECT * FROM Employees");
        }
    }
}