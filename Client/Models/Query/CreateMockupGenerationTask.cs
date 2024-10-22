using Newtonsoft.Json;

namespace Client.Models.Query
{
    public class CreateMockupGenerationTask
    {
        // task_key
        // required
        // string
        // Task key retrieved when creating the generation task.
        [JsonProperty("task_key")]
        public string TaskKey { get; set; }

    }
}