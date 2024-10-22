using Newtonsoft.Json;

namespace Client.Common
{
    public class IntegerEnumConverter: JsonConverter
    {
        
        public override bool CanConvert(Type objectType)
        {
            return objectType.IsEnum;
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Integer)
            {
                int enumValue = Convert.ToInt32(reader.Value);
                if (Enum.IsDefined(objectType, enumValue))
                {
                    return Enum.ToObject(objectType, enumValue);
                }
            }
            throw new ArgumentException($"Invalid enum value: {reader.Value} for enum type: {objectType}");
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteValue((int)value);
        }
    }
}