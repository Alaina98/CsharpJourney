namespace EventAss
{
    internal class Program
    {
        static void Main(string[] args)
        {
            weather w = new weather();

            w.OnChange += Weather_OnChange;
            w.WeatherChanges(55);



        }

        private static void Weather_OnChange(weather weath, int temp)
        {
            if (temp < 17)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Rainy and Cold");
            }
            else if (temp > 17 && temp < 25)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Cloudy and No Rain");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Hot and Melt");
            }
        }
    }

    class weather
    {
        public int temperature { get; set; }
        //public string condition { get; set; }
        
        public void WeatherChanges(int temp)
        {
            this.temperature = temp;

            //3. event declaration
            if (OnChange != null)
            {
              
                OnChange(this, temp);


            }

        }
        //1. Delegate
        public delegate void changingWeatherS(weather weath, int temp);
        //2. Event
        public event changingWeatherS OnChange;

    }
}