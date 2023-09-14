using MongoDB.Driver.Core.WireProtocol.Messages;

namespace testcallAPI.Models
{
    public class DataAccess
    {
        public string ConnectionString { get; set; } = null!;

        public string DatabaseName { get; set; } = null!;

        public string fristMongoCollectionName { get; set; } = null!;

    }
}
