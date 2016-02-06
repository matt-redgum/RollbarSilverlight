﻿using System.Collections.Generic;
using Newtonsoft.Json;

namespace RollbarSilverlight.Serialization
{
    /// <summary>
    /// Model for a text only report. The message ends up as the 'body' key
    /// in the message model and all custom data fields are merged in.
    /// </summary>
    /// <example>
    /// {
    ///   message: {
    ///     body: "my message text,
    ///     custom_field: "my custom data"
    ///   }
    /// }
    /// </example>
    [JsonObject(MemberSerialization.OptIn)]
    public class MessageBodyModel : BodyModel
    {
        public string Message { get; set; }

        public IDictionary<string, object> CustomData { get; set; }

        [JsonProperty("message")]
        internal IDictionary<string, object> Serialized
        {
            get
            {
                var result = new Dictionary<string, object>(CustomData);
                result["body"] = Message;
                return result;
            }
        }

        public MessageBodyModel(string message, IDictionary<string, object> customData = null)
        {
            Message = message;
            CustomData = customData ?? new Dictionary<string, object>();
        }
    }
}