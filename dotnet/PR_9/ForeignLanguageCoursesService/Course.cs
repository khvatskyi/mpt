using System;
using System.Runtime.Serialization;

namespace ForeignLanguageCoursesService
{
    [DataContract]
    public class Course
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public double Price { get; set; }

        [DataMember]
        public DateTime StartDate { get; set; }
    }
}
