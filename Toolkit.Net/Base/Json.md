# Json toolkit

The Json class is a static class to serialize and deserialize an object using the built-in network [DataContractJsonSerializer](https://msdn.microsoft.com/en-us/library/system.runtime.serialization.json.datacontractjsonserializer.aspx).

You will have to mark a class with the [DataContract](https://msdn.microsoft.com/en-us/library/system.runtime.serialization.datacontractattribute.aspx) Attribute and properties you want to convert with the [DataMember](https://msdn.microsoft.com/en-us/library/system.runtime.serialization.datamemberattribute.aspx).

And then you can use:

'''csharp
string jsonStr = Json.Serialize(yourObject);

// If you use the JsonExtensions, you can also do
jsonStr = yourObject.ToJson();

yourObject = Json.Deserialize<YourObjectClass>(jsonStr);
'''