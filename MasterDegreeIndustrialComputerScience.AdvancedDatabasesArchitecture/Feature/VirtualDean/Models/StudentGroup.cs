using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace MasterDegreeIndustrialComputerScience.AdvancedDatabasesArchitecture.Feature.VirtualDean.Models
{
    public class StudentGroup
    {
        [BsonId]
        public string StudentGroupId { get; set; }
        [BsonId]
        public string GroupSubjectId { get; set; }
    }
}
