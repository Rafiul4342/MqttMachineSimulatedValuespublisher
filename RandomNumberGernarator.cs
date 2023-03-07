using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MqttClientSouthboundSimulatedvalues
{
    public class RandomNumberGernarator
    {
        public double Temperature { get; set; }
        public double Humidity { get; set; }
        public double Speed { get; set; }   
        public double Getrandomvalues(double rangemin, double rangemax)
        {
            Random random = new Random();
            
            Temperature = random.NextDouble()*(rangemax- rangemin) + rangemin;
            return Temperature;  
        }
        public double Getrandomvalueshumidity(double rangemin, double rangemax)
        {
            Random random = new Random();

            Humidity = random.NextDouble() * (rangemax - rangemin) + rangemin;
            return Humidity;
        }

        public double GetSpindlespeed(double rangemin, double rangemax)
        {
            Random random = new Random();

            Speed = random.NextDouble() * (rangemax - rangemin) + rangemin;
            return Speed;
        }


    }
}
