using System;

namespace AHBC_Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Human. Welcome to the classroom calcuator!" );
            double rLength = 0, rWidth = 0, rHeight = 0;
            //bool runAgain = false;



            while (true)
            {
                Console.WriteLine("Enter the classrooms length.");
                string numOne = Console.ReadLine();
                rLength = double.Parse(numOne); 

                Console.WriteLine("What is the room's width?");
                string numTwo = Console.ReadLine();
                rWidth = double.Parse(numTwo);

                Console.WriteLine("What is the height of the room?");
                string numThree = Console.ReadLine();
                rHeight = double.Parse(numThree);

                Console.WriteLine($"Length = {rLength}" );
                Console.WriteLine($"Width = {rWidth}");
                Console.WriteLine($"Height = {rHeight}");


                double area = (rWidth * rLength);
                double perimeter = ((2 * rWidth) + (2 * rLength));
                double volume = (rHeight * rLength * rWidth);
                Console.WriteLine($"The area of this room is: {area}");
                Console.WriteLine($"The perimeter of this room is: {perimeter}");
                Console.WriteLine($"The Volume of this room is: {volume}");

                Console.WriteLine("That was fun. Would you to measure any other rooms? [Yes/No]");
                string userInput = Console.ReadLine();
                //runAgain = bool.Parse(userInput);


                
                if (userInput == "yes" || userInput == "Yes")
                {
                    Console.WriteLine("Awesome. Lets do this again!");
                    //runAgain = true;
                }

                else
                {
                    Console.WriteLine("You either said no, or made a typo! Well we are all set. Have a great day!");
                    break;
                }

            }
            Console.WriteLine("bye Bye!");
            Console.ReadLine();
        }
    }
}
