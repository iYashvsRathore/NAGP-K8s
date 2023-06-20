namespace NAGPK8s.Utilities
{
	public static class DataUtil
	{

		public const string CONNECTION_STRING_KEY = "DefaultConnection";

		public static string ResolveDbConnectionString(IConfiguration Configuration, string connectionStringKey = CONNECTION_STRING_KEY)
		{
			var connectionString = Configuration.GetConnectionString(connectionStringKey);
			
			if(!string.IsNullOrEmpty(connectionString))
            {
				var hostName = Environment.GetEnvironmentVariable("SQL_HOST");
				hostName = string.IsNullOrWhiteSpace(Environment.GetEnvironmentVariable("SQL_HOST_PORT")) ? hostName : hostName + "," + Environment.GetEnvironmentVariable("SQL_HOST_PORT");
				var databaseName = Environment.GetEnvironmentVariable("SQL_DATABASE");
				var userName = Environment.GetEnvironmentVariable("SQL_USERNAME");
				var password = Environment.GetEnvironmentVariable("SQL_PASSWORD");

				connectionString = string.Format(connectionString, hostName, databaseName, userName, password);
			}
			
			return connectionString;
		}
	}
}
