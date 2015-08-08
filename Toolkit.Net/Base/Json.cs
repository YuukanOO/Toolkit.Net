using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;

namespace Toolkit.Net
{
    /// <summary>
    /// Helper static class to serialize and deserialize objects using .Net DataContractJsonSerializer
    /// 
    /// External reference(s) needed:
    ///     - System.Runtime.Serialization
    /// </summary>
    public static class Json
    {
        public static string Serialize<T>(T obj, bool useDictionary = false)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                DataContractJsonSerializerSettings settings = new DataContractJsonSerializerSettings();

                settings.UseSimpleDictionaryFormat = useDictionary;

                DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(T), settings);

                // Write the generated JSON
                serializer.WriteObject(ms, obj);

                return Encoding.UTF8.GetString(ms.ToArray());
            }
        }

        public static T Deserialize<T>(string json, bool useDictionary = false)
        {
            using (MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(json)))
            {
                DataContractJsonSerializerSettings settings = new DataContractJsonSerializerSettings();

                settings.UseSimpleDictionaryFormat = useDictionary;

                DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(T), settings);

                // Convert the string representation to the desired object
                return (T)serializer.ReadObject(ms);
            }
        }
    }
}