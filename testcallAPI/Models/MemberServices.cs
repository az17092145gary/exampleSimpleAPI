using Microsoft.Extensions.Options;
using MongoDB.Driver;
namespace testcallAPI.Models
 
{
    public class MemberServices
    {
        private readonly IMongoCollection<Member> _memCollection;
        public MemberServices(IOptions<DataAccess> dataAccess) 
        {
            var mongoClient = new MongoClient(
                dataAccess.Value.ConnectionString);
            var mongoDatabase = mongoClient.GetDatabase(
                dataAccess.Value.DatabaseName);
            _memCollection = mongoDatabase.GetCollection<Member>(
                dataAccess.Value.fristMongoCollectionName);
        }
        public async Task<List<Member>> GetMembers() =>
            await _memCollection.Find(x=>true).ToListAsync();
        public async Task CreateMember(Member mem) =>
            await _memCollection.InsertOneAsync(mem);

    }
}
