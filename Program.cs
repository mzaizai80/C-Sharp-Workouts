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

            /*
                        //Övning 8

                        for (int i = 0; i < 5; i++)
                        {
                        Console.WriteLine("Enter the number of chocolate eggs gathered");
                        int numOfEggs = Convert.ToInt32(Console.ReadLine());
                        int leftEggs = numOfEggs % 4;
                        int sisterGets= numOfEggs / 4;
                        Console.WriteLine($"The number of chocolate eggs four sisters gets : {sisterGets}");
                        Console.WriteLine($"The number of chocolate eggs Duckbear gets : {leftEggs}");
                        }
            */

            // Övning 9


            /*
                        // Kursmoment 
                        // Ovning 1

                        Console.WriteLine(" Vilken land vann fotbolls-VM för damer år 2015");
                        string svar = Console.ReadLine().ToLower();

                        if (svar == "usa")
                        {
                            Console.WriteLine("Rätt svar!");
                        }
                        if (svar != "usa")
                        {
                            Console.WriteLine("fel svar!");
                        }

                        // Ovning 2

                        Console.WriteLine("Hur gammal är du? Svar i år");
                        int ålder =int.Parse(Console.ReadLine());

                        Console.WriteLine("Hur mycket tjänar du per månad?Svar i kronor.");
                        int inkomst = int.Parse(Console.ReadLine());

                        if (ålder ==39)
                        {
                            Console.WriteLine("Du är lika gammal som medelperson i getoborg");
                        }

                        else if (ålder >39)
                        {
                            Console.WriteLine("Du är äldre..");
                        }
                        else
                        {
                            Console.WriteLine("Du är yngre");
                        }

                        if (inkomst == 36100)
                        {
                            Console.WriteLine("Du är lika mycket pengar i getoborg");
                        }

                        else if (inkomst > 36100)
                        {
                            Console.WriteLine("Du tjänar mer ån medellöne..");
                        }
                        else
                        {
                            Console.WriteLine("Du tjänar mindre ån medellöne");
                        }
            */

            /*// Ovning 3

            Console.WriteLine("Vad heter du?");
            string name = Console.ReadLine().ToLower();
            Console.WriteLine("Hur gammal är du?");
            int ålder = int.Parse(Console.ReadLine());

            if (name=="felicai" || name== "felix")
            {
                Console.WriteLine("Du har namnsdag idag, du får gå ombord först.");
            }
            else if (ålder > 75)
            {
                Console.WriteLine("På grund av din ålder får du gå ombord i grupp två.");
            }
            else if (ålder >18 && ålder <= 25 )
            {
                Console.WriteLine("Unga vuxna får gå ombord i grupp tre");
            }
            else
            {
                Console.WriteLine("Du är velkomma ombord i grup fyra");
            }

            // Ovning 4

            Console.WriteLine("hur gammal är du? svar i år");
            int ålder = int.Parse(Console.ReadLine());

            int x = 0;
            if (65 < ålder || ( ålder <= 18   && ålder >= 10))
            {
                Console.WriteLine("Du kan få extra biligt pris för kaffe!!");
            }
            else
            {
            Console.WriteLine("Du får vanligt priss.. ");
            }

            // Ovning 5


            int n, sum = 0;
            int fact = 1;

            Console.WriteLine("Ange numret som summan görs till ");
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                sum += i;
                fact *= i;
            }

            Console.WriteLine("summan av talen från i till {0} är {1}", n, sum);
            Console.WriteLine($"summan av talen från i till {n} är {sum}");
            Console.WriteLine("Fakultet är " + fact);


            // Ovning 6

            Console.WriteLine("Detta är ett omvandlingsprogram");
            string val = "";

            while (val != "3")
            {
                Console.WriteLine();
                Console.WriteLine("Välj ett av följande alternative");
                Console.WriteLine("1. omvandla meter till kilometer");
                Console.WriteLine("2. omvandla kilometer till meter ");
                Console.WriteLine("3. omvandla avsluta programet");

                val = Console.ReadLine();
                switch (val)
                {
                    case "1":
                        Console.WriteLine("Skriv in en längd i meter");
                        double antalMeter = double.Parse(Console.ReadLine());
                        Console.WriteLine($"längden du skriv in är detsamma som {antalMeter / 1000}km");
                        break;
                    case "2":
                        Console.WriteLine("Skriv in en längd i Km");
                        double antalKiloMeter = double.Parse(Console.ReadLine());
                        Console.WriteLine($"längden du skriv in är detsamma som {antalKiloMeter * 1000}km");
                        break;

                    case "3":
                        Console.WriteLine("Programmet avslutas..");
                        break;

                    default:
                        Console.WriteLine("Du valde inte ett giltigt alternativ!");
                        break;
                }

            }

            // Ovning 7

            double insats, ränta, mål;

            Console.WriteLine("hur stor är insats i banken?");
            insats = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Vad är räntan (i%)");
            ränta = 1 + Convert.ToDouble(Console.ReadLine()) / 100.0;
            
            Console.WriteLine("Vilken insatsvärde vill du nå");
            mål = Convert.ToDouble(Console.ReadLine());

            int år = 0;

            do
            {
                insats *= ränta;
                ++år;

            } while (insats < mål);
            Console.WriteLine("I {0} år insatsvärde kommer att vara {1}.", år, insats);
            Console.ReadKey();


            // Ovning 8


            Console.WriteLine("Vilket är Europas folkrikaste land?");
            Console.WriteLine("Du kan välja genom \n" +
                "\t1. Germany\n" +
                "\t2. Belgium\n" +
                "\t3. Russia\n" +
                "\t4. France\n" +
                "\t5. Italy\n");            

            for (int i = 5; i > 0; --i)
            {
            string val =  Console.ReadLine().ToLower();
            string svar = "russia";

                if (svar == val)
                {
                    Console.WriteLine("Du gissat rätt " + val);
                    break;
                }

                Console.WriteLine($"Det är fel, d u har {i-1} moljghet kvar.");

            }

            
            
            // Ovning 9

            Console.WriteLine("kriv en rectangléls bred .");
            int bredd = int.Parse(Console.ReadLine());
            Console.WriteLine("Skrev rektanglens höjd");
            int höjd = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 0; i < höjd; i++)
            {

                for (int j = 0; j < bredd; j++)
                {
                    if (i == 0 || i == höjd - 1 || j == 0 || j == bredd - 1)
                    {
                        Console.Write("X");
                   }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }

            
            
            // Ovning 10

            string medelande = "Hej! Detta är ett medelande. Tack för att du läste medelande.";
            for (int i = 0; i < medelande.Length; i++)
            {
                Console.Write(medelande[i]);

                if (medelande[i]=='.')
                {
                    Thread.Sleep(1000);
                }
                else
                {
                    Thread.Sleep(100);
                }            
            }

            // Ovning 11

            Console.WriteLine("Hur många sporteer vill du skriva in?");

            int antal = int.Parse(Console.ReadLine());
            string[] sporter = new string[antal];

            for (int i = 0; i < antal; i++)
            {
                Console.WriteLine("Skriv in en sport;");

                sporter[i] = Console.ReadLine();

            }
            Console.WriteLine("Här är de sporter du skrev in");
            for (int i = 0; i < antal; i++)
            {
                Console.WriteLine(sporter[i]);
            }
*/



















        }
    }
}
