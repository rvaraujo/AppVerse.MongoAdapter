using System;
using AppVerse.MongoAdapter.Interfaces;
using MongoDB.Bson;

namespace AppVerse.MongoAdapter
{
	public abstract class Document: IDocument
	{
		public ObjectId Id { get; set; }

        public DateTime CreatedAt => Id.CreationTime;
    }
}

