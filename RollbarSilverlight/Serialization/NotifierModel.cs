using Newtonsoft.Json;

namespace RollbarSilverlight.Serialization
{
    /// <summary>
    /// Describes the notifier library/code that reported this item i.e. this .NET binding
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class NotifierModel
    {
        /// <summary>
        /// Name of the notifier. RollbarSilverlight in this case.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Version of the notifier. Defaults to the version from the assembly info
        /// </summary>
        [JsonProperty("version")]
        public string Version { get; set; }

        public NotifierModel()
        {
        }

        public NotifierModel(string name, string version)
        {
            Name = name;
            Version = version;
        }
    }
}