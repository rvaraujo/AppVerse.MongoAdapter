using System;
namespace AppVerse.MongoAdapter.Interfaces
{
	public interface IMongoDbSettings
	{
        string DatabaseName { get; set; }
        string ConnectionString { get; set; }
    }
}

