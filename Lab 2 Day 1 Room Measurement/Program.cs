using System;

namespace Lab_2_Day_1_Room_Measurement
{
    class Program
    {
        static void Main(string[] args)
        {

            string choice; 
            
            do
            {
                //get dimensions
                Console.WriteLine("Enter Width");
                double width = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter Length");
                double length = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter Height");
                double height = double.Parse(Console.ReadLine());
                double area = length * width;
                double perimeter = (length * 2) + (width * 2);
                double volume = length * width * height;

                //calculate supplies needed
                double paint = perimeter / 5;
                double carpet = area / 5;



                //display dimensions
                Console.WriteLine($"Width: {width}");
                Console.WriteLine($"Length: {length}");
                Console.WriteLine($"Height: {height}");
                Console.WriteLine($"Area: {area}");
                Console.WriteLine($"Perimiter: {perimeter}");
                Console.WriteLine($"Paint: {paint}");
                Console.WriteLine($"Carpet: {carpet}");
                Console.WriteLine($"Volume: {volume}");
                Console.WriteLine("Would you like to calculate another room y/n?");
                choice = Console.ReadLine();
                
            } while (choice == "y");
        }
    }
}
