using System;

namespace ForGit
{
    class CameraSpeed
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many cars do you want analyze the speed (you can analyze 1 until 100)?");
            var carsToAnalyze = Console.ReadLine();

            Console.WriteLine("What is the speed limit?");
            var speedLimit = Console.ReadLine();


            try
            {
                var convertCarsToAnalyze = int.Parse(carsToAnalyze);
                var convertSpeedLimit = int.Parse(speedLimit);

                var auxNumberCar = convertCarsToAnalyze; // The value of convertCarsToAnalyze was copied to auxNumberCar for when enter on the loop while,
                                                         //the auxNumberCar will be decremented until 0, then will go out to the loop while

                while (convertCarsToAnalyze <= 100 && auxNumberCar > 0)
                {
                    auxNumberCar--;

                    Console.WriteLine("What is the car speed? ");
                    var carVelocity = Console.ReadLine();

                    try
                    {
                        var convertCarVelocity = int.Parse(carVelocity);

                        if (convertSpeedLimit >= convertCarVelocity)
                        {
                            Console.WriteLine("The car velocity {0} km/h, is OK.", convertCarVelocity);
                        }
                        else
                        {
                            Console.WriteLine("Wait...");
                            var licensePoints = 0;
                            var auxCarSpeed = convertCarVelocity; //auxCarSpeed is a variable to store carVelocity;
                            var totalDifference = auxCarSpeed - convertSpeedLimit;

                            while (totalDifference >= 5)
                            {
                                licensePoints++;
                                auxCarSpeed -= 5;
                                totalDifference = auxCarSpeed - convertSpeedLimit;
                                //The auxCarSpeed will decreasing until totalDifference is lower than 5, then will exit of while;
                            }
                            if (licensePoints > 12)
                            {
                                Console.WriteLine("The car velocity {0} km/h, License Suspended. Because is above 12 points in the license.", convertCarVelocity);
                            }
                            Console.WriteLine("The license have {0} points.", licensePoints);
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("{0} can't be converted to int", speedLimit);
                        Console.WriteLine("{0} can't be converted to int", carVelocity);
                    }

                }
            }
            catch (Exception)
            {
                Console.WriteLine("{0} can't be converted to int", carsToAnalyze);
            }
        }
    }
}
