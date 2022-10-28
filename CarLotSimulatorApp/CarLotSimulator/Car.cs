using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    public class Car
    {
        public string Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string CarHorn { get; set; }
        public bool IsDrivable { get; set; }

        // My default constructor
        public Car()
        {

        }

        // My customer Constructor
        public Car( string year, string make, string model, string engineNoise, string carHorn, bool isDrivable)
        {
            Year = year;
            Make = make;
            Model = model;
            EngineNoise = engineNoise;
            CarHorn = carHorn;
            IsDrivable = isDrivable;

        }

        // Methods
        public void TurnOnEngine(string engineNoise)
        {
            Console.WriteLine($"Engine geos {EngineNoise}");
        }

        public void CarBeep(string carHorn)
        {
            Console.WriteLine($"Car horn beeps {CarHorn}");
        }

    }
   
}
