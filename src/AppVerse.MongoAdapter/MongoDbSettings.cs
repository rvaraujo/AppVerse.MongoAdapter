using System;
using AppVerse.MongoAdapter.Interfaces;

namespace AppVerse.MongoAdapter
{
	public class MongoDbSettings: IMongoDbSettings
    {
        public MongoDbSettings(string databaseName, string connectionString)
        {
            DatabaseName = databaseName;
            ConnectionString = connectionString;
        }

        public string DatabaseName { get; set; }
        public string ConnectionString { get; set; }
    }
}

