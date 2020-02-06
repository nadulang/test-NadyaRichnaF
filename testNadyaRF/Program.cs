using System;
using System.Linq;
using System.Collections.Generic;


namespace testNadyaRF
{
    class Program
    {
        static void Main(string[] args)
        {



            
            /*
             NumberOne.MyName();
             NumberTwo.MyBirthday();
             NumberThree.CountString("Hello World!");
             // We have some word collection ...
             var censoredWords = new List<string>() { "imperdiet", "dolor", "duo" };

             // and a paragraph.
             var paragraph = "Lorem ipsum dolor sit amet, imperdiet vituperata duo in, nonumy.";
             NumberFour.censoringWords(censoredWords, paragraph);

             NumberFive.IsOdd(4);
             NumberFive.IsEven(8);
            
             NumberSix.Grade(90);
             NumberSeven.FahrenheitToKelvin(12);
             NumberEight.IsLeapYear(2020);

             var jakarta = Tuple.Create("Jakarta", 7);
             var bali = Tuple.Create("Bali", 8);
             var london = Tuple.Create("London", 0);
             var cairo = Tuple.Create("Cairo", 2);
             var denver = Tuple.Create("Denver", -6);
             var chicago = Tuple.Create("Chicago", -5);
             NumberNine.TimeZoneDiff(jakarta, london);

             NumberTen.Sum(1, 6);
             NumberEleven.sumInAllArgs();
             NumberTwelve.uppercase("hello world");
             NumberThirteen.CountWords("Hello");
             NumberFourteen.IsPalindrome("malam");
             NumberFifteen.Mirror("--vv");

             string[] fruits = { "Jeruk", "Apel", "Anggur", "Pepaya", "Pisang", "Kiwi", "Markisa" };
             NumberSixteen.IndexFinder(fruits, "Jeruk");

             NumberSeventeen.oneThousandLoop();

             int[] numbers = { 2, 4, 54, 12, -65, 19, 40, 92, 88, 330, -4, 54 };
             NumberEighteen.FindMax(numbers);
             
             NumberNineteen.ArrayNumber();

             NumberTwenty item = new NumberTwenty();
              item.name = "Indomie Goreng";
              item.price = 3500;
              item.onSale = true;
              Console.WriteLine(item.print());

            */







        }
    }

    class NumberOne
    {
        public static void MyName()
        {
            Console.WriteLine("Please insert your name: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello, my name is {name}");

        }
    }

    class NumberTwo
    {
        public static void MyBirthday()
        {
           DateTime myBirthday = new DateTime(1997, 05, 23);
           DateTime today = DateTime.Today;
           DateTime nextYearBirthday = new DateTime(today.Year, myBirthday.Month, myBirthday.Day);

            if (nextYearBirthday < today)
            {
                nextYearBirthday = nextYearBirthday.AddYears(1);
            }
            int days = (nextYearBirthday - today).Days;
            int remaining = days;
            Console.WriteLine($"{remaining} days remaining to my next birthday.");



        }
    }

    class NumberThree
    {
        public static void CountString(string str)
        {
            int panjangString = str.Length;
            Console.WriteLine($" '{str}' have {panjangString} characters");
        }
    }

    class NumberFour
    {
        public static void censoringWords(List<string> censoredWords, string paragraph)
        {

            for (int i =0; i<censoredWords.Count; i++)
            {
                string baru = "";

                for (int m = 0; m < censoredWords[i].Length; m++)
                {
                    baru += "*";
                }
                paragraph = paragraph.Replace(censoredWords[i], baru);
            }
            Console.WriteLine(paragraph);
        }
        
    }

    class NumberFive
    {
        public static void IsEven(int i)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
        }

        public static void IsOdd(int i)
        {
            if (i % 2 != 0)
            {
                Console.WriteLine(true);
            }

            else
            {
                Console.WriteLine(false);
            }
        }

    }

    class NumberSix
    {
        public static void Grade(int yourGrade)
        {

            if (yourGrade >= 90)
            {
                Console.WriteLine("A");
            }
            else if (yourGrade >= 80 && yourGrade <= 89)
            {
                Console.WriteLine("B");
            }
            else if (yourGrade >= 70 && yourGrade <= 79)
            {
                Console.WriteLine("C");
            }
            else if (yourGrade >= 60 && yourGrade <= 69)
            {
                Console.WriteLine("D");
            }
            else if (yourGrade <= 59)
            {
                Console.WriteLine("E");
            }
            else
            {
                Console.WriteLine("Please insert the correct grade.");
            }
        }
    }

    class NumberSeven
    {
        public static void CelciusToFahrenheit(double suhu)
        {
            Console.WriteLine((suhu * 1.8) + 32);
        }
        public static void FahrenheitToCelcius(double suhu)
        {
            Console.WriteLine(Math.Round((suhu - 32) * 0.5556));
        }
        public static void CelciusToKelvin(double suhu)
        {
            Console.WriteLine(suhu + 273.15);
        }
        public static void KelvinToCelcius(double suhu)
        {
            Console.WriteLine(suhu - 273.15);
        }
        public static void KelvinToFahrenheit(double suhu)
        {
            Console.WriteLine((suhu - 273.15) * 1.8 + 32);
        }
        public static void FahrenheitToKelvin(double suhu)
        {
            double result = Math.Round(((suhu - 32) / 1.8 + 273.15), 3);
            Console.WriteLine(result);
        }
    }

    class NumberEight
    {
        public static void IsLeapYear(int year)
        {
            if (DateTime.IsLeapYear(year))
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
        }
    }


    class NumberNine
    {
        public static void TimeZoneDiff(Tuple<string, int>thecity1, Tuple<string, int>thecity2)
        {
            if (thecity1.Item2 > thecity2.Item2)
            {
                var distance = thecity1.Item2 - thecity2.Item2;
                Console.WriteLine($"{thecity1.Item1} {distance} hours ahead of {thecity2.Item1}");
            }
            else if (thecity1.Item2 < thecity2.Item2)
            {
                var distance = thecity2.Item2 - thecity1.Item2;
                Console.WriteLine($"{thecity1.Item1} {distance} hours behind of {thecity2.Item1}");
            }
           
        }
    }

    class NumberTen
    {
        public static void Sum(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public static void Substract(int a, int b)
        {
            Console.WriteLine(a - b);
        }
        public static void Multiply(int a, int b)
        {
            Console.WriteLine(a * b);
        }
        public static void Divide(int a, int b)
        {
            Console.WriteLine(a / b);
        }
    }

    class NumberEleven
    {
        public static void sumInAllArgs()
        {
            int[] satuArray = { 1, 5, 8, 3 };

            int jmlArray = 0;
            foreach (int number in satuArray)
            {
                jmlArray += number;
            }
            Console.WriteLine(jmlArray);
        }
    }

    class NumberTwelve
    {
        public static void uppercase(string kalimat)
        {
            Console.WriteLine(kalimat.ToUpper());
        }

    }

    class NumberThirteen
    {
        public static void CountWords(string word)
        {
            int hitung = 0;
            string[] split = word.Split(' ');
            foreach (string kata in split)
            {
                hitung += 1;
            }
            Console.WriteLine(hitung);
        }
    }

    class NumberFourteen
    {
        public static void IsPalindrome(string word1)
        {


            char[] word2 = word1.ToCharArray();
            Array.Reverse(word2);
            string word3 = new string(word2);
            if (word1 == word3)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
        }

    }


    class NumberFifteen
    {
        public static void Mirror(string mrr)
        {
            char[] mrr2 = mrr.ToCharArray();
            Array.Reverse(mrr2);
            string mrr3 = mrr + new string(mrr2);
            Console.WriteLine(mrr3);
        }
    }

    class NumberSixteen
    {
        public static void IndexFinder(string[] fruits, string item)
        {
            int indeks = Array.IndexOf(fruits, item);
            Console.WriteLine(indeks);
        }
    }


    class NumberSeventeen
    {
        public static void oneThousandLoop()
        {
            for (int i = 1; i < 1000; i++)
            {
                if (i % 100 == 0)
                {
                    Console.WriteLine(i + ". Baz");
                }
                else if (i % 20 == 0)
                {
                    Console.WriteLine(i + ". Bar");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine(i + ". Foo");
                }
                else
                {
                    Console.WriteLine(i);
                }


            }


        }
    }


    class NumberEighteen
    {
        public static void FindMax(int[] numbers)
        {

            Console.WriteLine(numbers.Max());
        }

        public static void FindMin(int[] numbers)
        {
            Console.WriteLine(numbers.Min());
        }

        public static void FindAverage(int[] numbers)
        {
            double jumlah = 0.0;
            for (int i = 0; i < numbers.Length; i++)
            {
                jumlah += numbers[i];
            }
            Console.WriteLine(jumlah / numbers.Length);
        }

    }

    class NumberNineteen
    {
        public static void ArrayNumber()
        {
            int[] points = { 2, 4, 54, 12, -65, 19, 40, 92, 88, 330, -4, 45 };
            Array.Sort(points);

            Console.WriteLine(string.Join(" ", points));


        }


    }

    class NumberTwenty
    {
        public string name;
        public int price;
        public bool onSale;


        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Price
        {
            get { return price; }
            set { price = value; }
        }

        public bool OnSale
        {
            get { return onSale; }
            set { onSale = value; }
        }

        public string print()
        {
            if (onSale == true)
            {
                double newPrice = price - (price * 0.2);
                return $"Indomie Goreng Rp{newPrice}";
            }
            else
            {
                return Convert.ToString(price);
            }
        }
        
    }
      

}






