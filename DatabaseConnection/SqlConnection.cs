namespace DatabaseConnection
{
    public class SqlConnection : DbConnection
    {
        public SqlConnection(string connectionString) 
            : base(connectionString)
        {
        }
        public override void Open()
        {
            // Implementation to open SQL connection
            Console.WriteLine("Opened the connection to SQL Database.");
            
        }
        public override void Close()
        {
            // Implementation to close SQL connection
            Console.WriteLine("Closed the connection to SQL Database.");
        }

    }
}