using Client.Common;
using Client.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;

namespace Client.Models
{
    public class GenerationTask
    {
        // task_key	
        // string
        // Task identifier you will use to retrieve generated mockups.
        [JsonProperty("task_key")]
        public string TaskKey { get; set; }

        // status	
        // string
        // Enum: "pending" "completed" "failed"
        // Status of the generation task.
        [JsonProperty("status")]
        [JsonConverter(typeof(DescriptionEnumConverter))]
        public MockupTaskStatus Status { get; set; }

        // error	
        // string
        // If task has failed, reason will be provided here.
        [JsonProperty("error")]
        public string Error { get; set; }

        // mockups	
        // Array of objects (GenerationTaskMockup)
        // If task is completed, list of mockups will be provided here.
        [JsonProperty("mockups")]
        public List<GenerationTaskMockup> Mockups { get; set; }

        // printfiles	
        // Array of objects (GenerationTaskTemplateFile)
        // If task is completed, list of printfiles will be provided here.
        [JsonProperty("printfiles")]
        public List<GenerationTaskTemplateFile> Printfiles { get; set; }
    }
}