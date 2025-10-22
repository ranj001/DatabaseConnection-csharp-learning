namespace DatabaseConnection
{
    public class DbCommand
    {
        private DbConnection _connection;
        public DbCommand(DbConnection connection)
        {
            if (connection == null)
                throw new ArgumentNullException(nameof(connection), "Connection cannot be null.");
            // Additional initialization code can go here
            _connection = connection;

        }

        public void Execute(string instruction)
        {
            if (string.IsNullOrWhiteSpace(instruction))
                throw new ArgumentException("Command text cannot be null or empty.", nameof(instruction));
            // Implementation for executing the command

            _connection.Open();
            Console.WriteLine($"Executing command: {instruction}");
            _connection.Close();
        }
    }
}