namespace HRBR_V300.utils
{
    public static class Patient
    {
        public static string name { get; set; }
        public static string age { get; set; }
        public static string id { get; set; }
        public static string height { get; set; }
        public static string weight { get; set; }
        static Patient()
        {
            name = "N/A";
            age = "N/A";
            id = "N/A";
            height = "N/A";
            weight = "N/A";
        }
    }
}
