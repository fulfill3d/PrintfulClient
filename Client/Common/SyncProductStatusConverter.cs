using Client.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Client.Common
{
    public class SyncProductStatusConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(SyncProductStatus);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            JToken token = JToken.Load(reader);
            if (token.Type == JTokenType.String)
            {
                string enumText = token.ToString();
                switch (enumText.ToLower())
                {
                    case "all":
                        return SyncProductStatus.All;
                    case "synced":
                        return SyncProductStatus.Synced;
                    case "unsynced":
                        return SyncProductStatus.UnSynced;
                    case "ignored":
                        return SyncProductStatus.Ignored;
                    case "imported":
                        return SyncProductStatus.Imported;
                    case "discontinued":
                        return SyncProductStatus.Discontinued;
                    case "out_of_stock":
                        return SyncProductStatus.OutOfStock;
                    default:
                        throw new JsonSerializationException($"Unexpected value {enumText} when parsing SyncProductStatus.");
                }
            }
            throw new JsonSerializationException("Unexpected token type " + token.Type.ToString());
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            SyncProductStatus status = (SyncProductStatus)value;
            writer.WriteValue(status.ToString().ToLower()); // Adjust the case as needed
        }
    }
}
