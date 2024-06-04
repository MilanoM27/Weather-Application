public class WeatherData
{
    public Location Location { get; set; }
    public Current Current { get; set; }

    public class Location
    {
        public string Name { get; set; }
        public string Region { get; set; }
        public string Country { get; set; }
    }

    public class Current
    {
        public int Temp_c { get; set; }
        public int Temp_f { get; set; }
        public string Is_day { get; set; }
        public Condition Condition { get; set; }

        public class Condition
        {
            public string Text { get; set; }
            public string Icon { get; set; } // URL for the weather icon
        }
    }
}
