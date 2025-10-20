namespace DatabaseConnection
{
    public class OracelConnection : DbConnection
    {
        public OracelConnection(string connectionString) : base(connectionString)
        {
        }
        public override void Open()
        {
            // Implementation for opening Oracle database connection
            Console.WriteLine("Opened the connection to Oracle Database.");
        }
        public override void Close()
        {
            // Implementation for closing Oracle database connection
            Console.WriteLine("Closed the connection to Oracle Database.");
        }
    }
}