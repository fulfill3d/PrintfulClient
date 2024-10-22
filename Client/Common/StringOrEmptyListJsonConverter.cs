using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Client.Common
{
    public class StringOrEmptyListJsonConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(Dictionary<string, string>);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            JToken token = JToken.Load(reader);
            switch (token.Type)
            {
                case JTokenType.String:
                    return token.ToString();
                case JTokenType.Array:
                    return string.Empty;
                case JTokenType.Boolean:
                    return token.ToString();
                case JTokenType.None:
                case JTokenType.Null:
                    return null;
                default:
                    throw new JsonSerializationException($"Unexpected token type {token.Type} encountered when StringOrEmptyListJsonConverter.");
            }
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            serializer.Serialize(writer, value);
        }
    }
}