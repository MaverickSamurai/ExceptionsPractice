using ExceptionsPractice.Exceptions;
using ExceptionsPractice.Models;
using System;
using System.Collections.Generic;

namespace ExceptionsPractice
{
    class Program
    {
       static void Main(string[] args)
       {

            #region HomeWork
            //MyList<int> nums = new MyList<int>();

            //    nums.Add(1);
            //    nums.Add(2);
            //    nums.Add(3);
            //    nums.Add(4);
            //    nums.Add(5);
            //    nums.Add(6);
            //    nums.Add(7);
            //    nums.Add(8);
            //    nums.Add(9);
            //    nums.Add(10);
            //    nums.Add(11);
            //    nums.Add(12);

            //    nums.Clear();
            //    nums.Add(99);
            //    nums.Add(100);
            //    nums.Add(101);
            //    nums.Add(102);



            //    nums.GetAll();

            //    List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };

            //    nums.AddRange(list);

            //    nums.GetAll();



            //MyList<string> names = new MyList<string>();

            //names.Add("Mirsamir");
            //names.Add("Elmir");
            //names.Add("Semi");
            //names.Add("Niyam");
            //names.Add("Lazim");

            //var result = names.Find(m => m == "Mirsamir");

            //Console.WriteLine( result );
            #endregion



            #region Exceptions
            //try
            //{
            //int a = 5;
            //int b = 0;

            //var result = a / b;

            //Console.WriteLine(result);

            //    int[] arr = new int[5];

            //    arr[11] = 9;
            //}
            ////catch (Exception ex)
            ////{

            ////    Console.WriteLine(ex.Message); 
            ////}

            //catch (NullReferenceException ex)
            //{

            //    Console.WriteLine(ex.Message); ;
            //}

            //catch (DivideByZeroException ex)
            //{

            //    Console.WriteLine(ex.Message); ;
            //}
            //finally
            //{
            //    Console.WriteLine("Abi napiyon be ya");
            //}
            #endregion

            //Divide(18, 2);

            List<string> list = new List<string>() { "Mirsamir", "Cavid", "Selim", "Aksin", "Sabir" };
            string searchText = "Cavid";

            FindName(list, searchText);
        }


        public static void FindName(List<string> names, string name)
        {
            try
            {
                var data = names.Find(m => m == name);
                if(data is null) throw new FindNameException("Not found name ");
                //if (!names.Contains(name))
                //{
                //    throw new FindNameException("Not found name ");
                //}
                Console.WriteLine("Ozudurki Var");
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }

        public static void Divide(int num1, int num2)
        {
            try
            {
                if (num2 == 2)
                {
                    throw new DivideExceptions("num2 cant equal 2");
                }

                Console.WriteLine(num1 / num2);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

        }
    }

    
}
