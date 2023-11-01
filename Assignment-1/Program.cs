using System;

namespace ASS1
{
    internal class Program
    {
        void Print_hello()
        {
            //-----1. Display Hello Message-----
            Console.WriteLine("Hello");
        }
        void Operations()
        {
            //-----2. Display result of Addition , subtraction , product , quotient of two numbers-----
            Console.WriteLine("Enter 2 numbers");
            int n1 = Convert.ToInt32(Console.ReadLine());
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($" Addition: {n1 + n2}\n Subtraction: {n1 - n2}\n Product: {n1 * n2}\n Quotient: {n1 / n2}");
        }
        void Operations_with_switch()
        {
            //-----3.Display result of Addition , subtraction , product , quotient of two numbers depending upon choice(using if else / switch)-----
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a choice-\n1. Addition\n2. Subtraction\n3. Product\n4. Quotient");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1: Console.WriteLine($"Addition: {x + y}"); break;

                case 2: Console.WriteLine($"Subtraction: {x - y}"); break;

                case 3: Console.WriteLine($"Product: {x * y}"); break;

                case 4: Console.WriteLine($"Quotient: {x / y}"); break;

                default: Console.WriteLine("INVALID CHOICE"); break;
            }
        }
        void Display_name()
        {
            //-----4.Display your name 10 times-----
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("YUVRAJ SINGH SHISHODIA\n");
            }


        }
        void Display_even()
        {
            //-----5.Display all even numbers by using dowhile, while , for loop-----
            int i;
            for (i = 1; i <= 100; i++)
            {
                if (i % 2 == 0)
                    Console.WriteLine($"{i}\n");
            }
            i = 1;
            while (i <= 100)
            {
                if (i % 2 == 0)
                    Console.WriteLine($"{i}\n");
                i++;
            }
            i = 1;
            do
            {
                if (i % 2 == 0)
                    Console.WriteLine($"{i}\n");
                i++;
            } while (i <= 100);


        }
        void Display_odd_numbers()
        {
            //-----6. Display all odd numbers by using dowhile, while , for loop-----
            int i;
            for (i = 1; i <= 100; i++)
            {
                if (i % 2 != 0)
                    Console.WriteLine($"{i}\n");
            }
            i = 1;
            while (i <= 100)
            {
                if (i % 2 != 0)
                    Console.WriteLine($"{i}\n");
                i++;
            }
            i = 1;
            do
            {
                if (i % 2 != 0)
                    Console.WriteLine($"{i}\n");
                i++;
            } while (i <= 100);


        }
        void Display_table()
        {
            //-----7.Display table of a number using all loops-----

            Console.WriteLine("Enter a number\n");
            int num = Convert.ToInt32(Console.ReadLine());

            int i;
            for (i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{num} * {i} = {num * i}\n");
            }
            Console.WriteLine();
            i = 1;
            while (i <= 10)
            {
                Console.WriteLine($"{num} * {i} = {num * i}\n");
                i++;
            }
            Console.WriteLine();
            i = 1;
            do
            {
                Console.WriteLine($"{num} * {i} = {num * i}\n");
                i++;
            } while (i <= 10);
            Console.WriteLine();


        }
        void Display_in_one_line()
        {
            //-----9.Declare some integer varibales, assign them some values and display them in one line-----
            int a = 1;
            int b = 2;
            int c = 3;
            int d = 4;
            Console.WriteLine($"a= {a}  b= {b}  c= {c}  d= {d}");
        }
        void Display_in_different_line()
        {
            //-----10.Declare some integer varibales, assign them some values and display them separate lines-----
            int a = 1;
            int b = 2;
            int c = 3;
            int d = 4;
            Console.WriteLine($"a= {a}\nb= {b}\nc= {c}\nd= {d}\n");

        }

        static void Main(string[] args )
        {
            Program program = new Program();

            program.Display_even();
            program.Display_in_different_line();
            program.Display_in_one_line();
            program.Print_hello();
            program.Operations_with_switch();
            program.Operations();
            program.Display_name();
            program.Print_hello();
            program.Display_odd_numbers();

        }
    }
}