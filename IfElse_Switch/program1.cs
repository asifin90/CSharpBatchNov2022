 class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            Console.WriteLine("Hello");
            Console.WriteLine(a);
            int b = 10;
            Console.WriteLine(a + b);

            // If - else program start
            string name = Console.ReadLine(); // reading input/information from console.
            if (name == "John")
            {
                // Code execute when condition becomes true
                // True block
                Console.WriteLine("Login Successfull");
            }
            else
            {
                // Code execute when condition becomes false
                Console.WriteLine("You are not authorized."); // wrting information on console.
            }
            // If - else program end



            // if else ladder  program  start

            int marksObtained = Convert.ToInt32(Console.ReadLine());
            if (marksObtained > 59)
            {
                Console.WriteLine("First Grade");
            }
            else if (marksObtained > 49 && marksObtained< 60)  // && => and operator
            {
                Console.WriteLine("Second Grade");
            }
            else if (marksObtained > 39 && marksObtained< 50)  // && => and operator
            {
                Console.WriteLine("Third Grade");
            }
            else
            {
                Console.WriteLine("Fail");
            }

            // if else ladder  program  end
           
        }
    }
