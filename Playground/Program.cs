using System.Runtime.Serialization;
using Toolkit.Net;
using Toolkit.Net.Extensions;

namespace Playground
{
    [DataContract]
    class Person
    {
        [DataMember]
        public int Age { get; set; }

        [DataMember]
        public string Name { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Json
            var A = new Person() { Age = 26, Name = "Julien" };

            string AJson = A.ToJson();

            var AFromJson = Json.Deserialize<Person>(AJson);
        }
    }
}
