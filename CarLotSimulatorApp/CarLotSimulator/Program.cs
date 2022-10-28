using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property

            Car myFirstCar = new Car();
           // my Dot Notation
            myFirstCar.Make = "Nissan";
            myFirstCar.Model = "Sentra SR";
            myFirstCar.Year = "2014";
            myFirstCar.EngineNoise = "beeeeeeep";
            myFirstCar.IsDrivable = true;

            

            myFirstCar.TurnOnEngine(myFirstCar.EngineNoise);
            myFirstCar.CarBeep(myFirstCar.CarHorn);

            // notes Object Innitializer Syntax
            var mySecondCar = new Car() 
            {   Year  = "1994",
                Make = "Toyota",
                Model = "Corola",
                IsDrivable = true 
            };

            

            mySecondCar.TurnOnEngine("Vrrrrooom");
            mySecondCar.CarBeep(mySecondCar.CarHorn);

            var myThirdCar = new Car("2008", "Nissan", "240SX", "spurrrrt", "honk honk", false);

            myThirdCar.TurnOnEngine(myThirdCar.EngineNoise);
            myThirdCar.CarBeep(myThirdCar.CarHorn);

            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

            

        }
    }
}
