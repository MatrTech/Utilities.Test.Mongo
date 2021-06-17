using System;

namespace MatrTech.Utilities.Test.Mongo
{
    public class MongoTestBase
    {
        private readonly DatabaseManager databaseManager;

        public MongoTestBase()
        {
            this.databaseManager = new DatabaseManager();
        }
    }
}
