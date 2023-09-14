using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace testcallAPI.Models
{
    public class Member
    {
        //[BsonId]
        //public Object? Id { get; set; }
        
        [BsonElement("name")]
        [BsonRequired]
        public string? MemberName { get; set; }
        [BsonElement("age")]
        [BsonRequired]
        public string? MemberAge { get; set; }
        

    }
}
