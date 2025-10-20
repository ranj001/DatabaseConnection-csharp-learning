namespace DatabaseConnection
{
    public abstract class DbConnection
    { 
        private string _connectionString;

        public DbConnection(string connectionString)
        {
            if (string.IsNullOrWhiteSpace(connectionString))
                throw new ArgumentException("Connection string cannot be null or empty.", nameof(connectionString));

            _connectionString = connectionString;

        }
        public abstract void Open();
        public abstract void Close();


    }
}