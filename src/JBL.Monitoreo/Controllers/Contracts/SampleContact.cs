namespace JBL.Monitoreo.Controllers.Contracts
{
    public class SampleContact
    {
        public string device_name { get; set; } = "";

        public DateTime timestamp { get; set; }

        public string object_id { get; set; } = "";

        public string object_name { get; set; } = "";

        public string unit { get; set; } = "";

        public string value { get; set; } = "";
    }
}
