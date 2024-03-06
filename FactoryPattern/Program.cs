namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose a car or motorcycle, enter how many wheels you want: ");
            
            int userChoice = 0;
            bool isNumber = false;

            while (!isNumber)
            {
                isNumber = int.TryParse(Console.ReadLine(), out userChoice);

                if (userChoice != 2 && userChoice != 3 && userChoice != 4) 
                {
                    isNumber = false;
                }
                else
                {
                    isNumber = true;
                }

                if (isNumber == false)
                {
                    Console.Clear();
                    Console.WriteLine("Choose a car or motorcycle, enter how many wheels you want: ");
                    Console.WriteLine("Please enter a valid number choice! Choose 2, 3, or 4.");
                }
            }

            var userVehicle = VehicleFactory.GetVehicle(userChoice);

            userVehicle.Drive();
        }
    }
}
