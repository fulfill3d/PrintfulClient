using System.ComponentModel;
using System.Reflection;
using Newtonsoft.Json;

namespace Client.Common
{
    public class DescriptionEnumConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType.IsEnum;
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.String)
            {
                string enumText = reader.Value.ToString();
                foreach (FieldInfo fi in objectType.GetFields())
                {
                    DescriptionAttribute[] attributes = (DescriptionAttribute[])fi.GetCustomAttributes(typeof(DescriptionAttribute), false);
                    if (attributes.Length > 0 && attributes[0].Description == enumText)
                        return Enum.Parse(objectType, fi.Name);
                }
            }

            throw new ArgumentException("Unable to parse enum.");
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            Type type = value.GetType();
            FieldInfo fi = type.GetField(value.ToString());
            DescriptionAttribute[] attributes = (DescriptionAttribute[])fi.GetCustomAttributes(typeof(DescriptionAttribute), false);

            if (attributes != null && attributes.Length > 0)
            {
                writer.WriteValue(attributes[0].Description);
            }
            else
            {
                writer.WriteValue(value.ToString());
            }
        }
    }
}