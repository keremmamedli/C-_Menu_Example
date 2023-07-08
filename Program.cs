namespace DemoApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int option;
            do
            {
                Console.WriteLine("1. For managin hospital");
                Console.WriteLine("2. For managin school");
                Console.WriteLine("0. Exit");
                Console.WriteLine("Select the option, please");

                var input = Console.ReadLine();
                while (!int.TryParse(input, out option))
                {
                    Console.WriteLine("Insert the number, please!");
                    input = Console.ReadLine();
                }
                switch (option)
                {
                    case 1:
                        int option1;
                        do
                        {
                            Console.WriteLine("1. Add Patient");
                            Console.WriteLine("2. Remove Patient");
                            Console.WriteLine("0. Go back");
                            Console.WriteLine("Select the option, please");

                            var input1 = Console.ReadLine();

                            while (!int.TryParse(input1, out option1))
                            {
                                Console.WriteLine("Insert the number, please!");
                                input1 = Console.ReadLine();
                            }

                            switch (option)
                            {
                                case 1:
                                    Console.WriteLine("Added new patient");
                                    break;
                                case 2:
                                    Console.WriteLine("Removed patient");
                                    break;
                                case 0:
                                    Console.WriteLine("Go back...");
                                    break;
                                default:
                                    Console.WriteLine("There is no such option!");
                                    break;
                            }
                        } while (option1 != 0);
                        break;
                    case 2:
                        int option2 ;
                        do
                        {
                            Console.WriteLine("1. Add Student");
                            Console.WriteLine("2. Remove Student");
                            Console.WriteLine("0. Go back...");
                            Console.WriteLine("Select the option, please");

                             var input2 = Console.ReadLine();

                            while (!int.TryParse(input2, out option2))
                            {
                                Console.WriteLine("Insert the number, please!");
                                input2 = Console.ReadLine();
                            }

                            switch (option2)
                            {
                                case 1:
                                    Console.WriteLine("Added new Student");
                                    break;
                                case 2:
                                    Console.WriteLine("Removed Student");
                                    break;
                                case 0:
                                    Console.WriteLine("Go back...");
                                    break;
                                default:
                                    Console.WriteLine("There is no such option!");
                                    break;
                            }
                        } while (option2 != 0);
                        break;
                    case 0:
                        Console.WriteLine("Exiting...");
                        break;
                    default:
                        Console.WriteLine("There is no such option!");
                        break;
                }
            } while (option != 0);




        }
    }
}