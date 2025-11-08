using Newtonsoft.Json;

namespace ROSBridge.GeometryMsgs
{

    public struct Quaternion
    {
        [JsonIgnore]
        public static readonly string ROSMessageType = "geometry_msgs/msg/Quaternion";

        [JsonProperty("x")]
        public double X { get; set; }

        [JsonProperty("y")]
        public double Y { get; set; }

        [JsonProperty("z")]
        public double Z { get; set; }

        [JsonProperty("w")]
        public double W { get; set; }
    }

}