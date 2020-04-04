using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MasterDegreeIndustrialComputerScience.AdvancedDatabasesArchitecture.Feature.VirtualDean.Models
{
    public class Classroom
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string ClassroomId { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
    }
}
