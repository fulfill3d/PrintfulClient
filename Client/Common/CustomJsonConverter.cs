using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Client.Common
{
    public class CustomJsonConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(Dictionary<string, string>);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            // Load the JToken from the reader to check its type
            JToken token = JToken.Load(reader);
            switch (token.Type)
            {
                case JTokenType.Object:
                    // Directly deserialize and return if the token is an object
                    return token.ToObject<Dictionary<string, string>>();
                case JTokenType.Array:
                    return new Dictionary<string, string>();
                case JTokenType.None:
                case JTokenType.Null:
                    // Return null or a new dictionary if the field is missing or explicitly null
                    return null; // or null, based on your preference
                default:
                    // Throw an exception for any other unexpected token type
                    throw new JsonSerializationException($"Unexpected token type {token.Type} encountered when CustomJsonConverter");
            }
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            // If you need to serialize back to JSON, implement this method.
            // Otherwise, you can simply throw a NotImplementedException if serialization is not required.
            serializer.Serialize(writer, value);
        }
    }
}