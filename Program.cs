namespace C_Sharp_Workouts
{
    internal class Program
    {

        static void Main(string[] args)
        {
            /*
            decimal result;
            Console.WriteLine("Enter base value");
            decimal h = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Enter Height Value");
            decimal b = Convert.ToDecimal(Console.ReadLine());
            result = (b * h) / 2;
            Console.WriteLine(result);
            */


            /*
            //Övning 4

            //Debugga koden under
            for (int i = 0; i < 5; i++)
            {

                Console.Write("Enter a number: ");
                double number = Convert.ToDouble(Console.ReadLine());
                double clampedNumber = Clamp(number, 0, 10);
                Console.WriteLine($"Clamped: {clampedNumber}");
                double Clamp(double value, double min, double max) // Also see Math.Clamp.
                {
                    if (value < min) return min;
                    if (value > max) return max;
                    return value;
                }
            }
            */
            /*
            //Övning 5
            Console.WriteLine("\tStartavgiften för att hyra bilen är 300 kr" +
                "\n\tHur mycket Km ska du köra?");
            double km = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\tHur många dagar ska du rwnta billen?");
            double days = Convert.ToDouble(Console.ReadLine());
            double result = 300 + km + 500 * (days-1);
            Console.WriteLine($"Det kostar {result} Kr. att hyra bilen");
            */

            /*
            //Övning 6
            Console.WriteLine("Skriv in en bräkning t.ex. 3,2*5,8");
            string bereakning =Console.ReadLine();
            int gangerindex = bereakning.IndexOf("*");
            string tal1text = bereakning[..gangerindex];
            string tal2text = bereakning[(gangerindex +1)..];

            double tal1= double.Parse(tal1text);
            double tal2 = double.Parse(tal2text);

            double product = tal1 + tal2;
            Console.WriteLine(bereakning+" = "+product);
            */

            /*
            
            
            //Övning 7
            Console.WriteLine("Skriva in en mening med tre ord," +
                "\nmeningen ska avslutas med en punkt.");

            // Taking a string
            string meaning = Console.ReadLine();
            //string meaning = "asd1 asd sd3.";
            Console.Write('\n');

            char[] meanChar = meaning.ToCharArray();

            char lastChar = meanChar[meanChar.Length - 1];

            meanChar = meanChar.SkipLast(1).ToArray();

            string meaning2 = string.Join("", meanChar);

            Console.WriteLine(meaning2 + '\n');

            char[] spearator = { ' ', '.' };
            //Int32 count = 0;

            // Using the Method   
            String[] meaninglist = meaning2.Split(spearator, StringSplitOptions.None);

            //reversing the order of list(words)
            Array.Reverse(meaninglist);

            for (int i = 0; i < (meaninglist.Length - 1); i++)
            {
                Console.WriteLine(meaninglist[i] + '\n');
            }
            string lastString = meaninglist[meaninglist.Length - 1];
            char[] meaninglistele = lastString.ToArray();

            meaninglistele = meaninglistele.Append(lastChar).ToArray();

            Console.WriteLine(meaninglistele);
            
            */


            //Övning 8

            Console.WriteLine("Enter the number of chocolate eggs gathered");
            int numOfEggs = 13;//Convert.ToInt32(Console.ReadLine());


            int leftEggs = 4 % numOfEggs;


            Console.WriteLine("The number of Duckbear gets");




        }


    }
}