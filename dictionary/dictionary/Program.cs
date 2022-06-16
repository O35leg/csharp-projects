//using System;
//using System.Collections.Generic;

//namespace dictionary
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.Title = "M1A1 Барсук Евгений";
//            Console.ForegroundColor = ConsoleColor.Blue;
//            Console.OutputEncoding = System.Text.Encoding.Unicode;
//            for (; ; )
//            {

//                //а = 0;б = 1;в = 2;г = 3;д = 4;е = 5;ё =6 ;ж = 7;з =8 ;и =9 ;й = 10;к = 11;л = 12;м = 13 ;н = 14;\nо = 15;п = 16;р = 17;с = 18;т = 19;у = 20;ф = 21;х = 22;ц = 23;ч = 24;ш = 25;щ = 26;ь = 27;ъ = 28;э = 29;ю = 30;я = 31;
//                Console.WriteLine("This is Барсук Евгений translator.");
//                Console.WriteLine("Input '0' to translate words from words English to Russian. Input '1' for Russian to English.\n Go on:");
//                int chooselanguge = Int32.Parse(Console.ReadLine());
//                int varible = 0;
//                if (chooselanguge == 0)
//                {
//                    EnglishtoRussian();
//                }

//                if (chooselanguge == 1)
//                {
//                    RussiantoEnglish();
//                }



//            }

//        }

//        static void EnglishtoRussian()
//        {
//            Console.WriteLine("Please input a word to translate. u can choose from 'Russia' 'Red' 'USA'. \n Capitals only.");
//            Console.WriteLine("");
//            string choose = Console.ReadLine();

//            var translation = new Dictionary<string, string>(){
//               {"Red","красный"},
//               {"USA","США"},
//               {"Russia","Россия"}
//               };
//            Console.WriteLine("The translation is " + translation[choose]);

//            if (choose != translation[choose])
//            {
//                Console.WriteLine("No!!! There's no in the dictionary.");
//            }
//        }

//        static void RussiantoEnglish()
//        {
//            Console.WriteLine("Please input a word to translate. u can choose from 'Россия' 'красный' 'США'. \n Capitals only.");
//            Console.WriteLine("");
//            string choose = Console.ReadLine();

//            var translation = new Dictionary<string, string>(){
//               {"красный","Red"},
//               {"США","USA"},
//               {"Россия","РоссияRussia"}
//               };
//            Console.WriteLine("The translation is " + translation[choose]);

//            if (choose != translation[choose])
//            {
//                Console.WriteLine("No!!! There's no in the dictionary.");
//            }
//        }
//    }
//}


//using System;
//using System.Collections.Generic;

//namespace dictionary
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.Title = "M1A1 Барсук Евгений";
//            Console.ForegroundColor = ConsoleColor.Blue;
//            Console.OutputEncoding = System.Text.Encoding.Unicode;
//            for (; ; )
//            {

//                string[] russiadurashawords = { "красный", "США", "Россия" };
//                string[] americaamericadushiukraineu = { "Red", "USA", "Russia" };
//                string[] italinopizzamamamia = { "Rosso", "Stati Uniti d'America", "Russia" };

//                foreach (string Russianwords in russiadurashawords)
//                {
//                    foreach (string Americanwords in americaamericadushiukraineu)
//                    {
//                        foreach (string ItailianWords in italinopizzamamamia)
//                        {

//                            var translation = new Dictionary<string, string>(){
//                            {"Red","красный"},
//                            {"Russia","Россия"},
//                            {"USA","США"},             
//                            };

//                            var translationit = new Dictionary<string, string>(){
//                            {"Rosso","красный"},
//                            {"Russia","Россия"},
//                            {"Stati Uniti d'America","США"},
//                            };

//                            foreach (var translationRuIT in translationit)
//                                Console.WriteLine("Select a starting languge. 'It' stands for italy. 'Ru'' stands for Russia. 'US' stands for USA.");
//                            string chooselan = Console.ReadLine();

//                            if (chooselan == "It")
//                            {
//                                Console.WriteLine("Great. Choose a different languge(it would be the languge it would translate to).");
//                                string chooseLangfromIt = Console.ReadLine();

//                                if (chooseLangfromIt == "Ru")
//                                {
//                                    Console.WriteLine("Choose a word. Type numbers from 'Rossa', 'Russia', 'Stati Uniti d'America' .");
//                                    string numberIT = Console.ReadLine();
//                                    Console.WriteLine(translationit[numberIT]);
//                                }
//                            }
//                        }
//                    }



//                }


//а = 0;б = 1;в = 2;г = 3;д = 4;е = 5;ё =6 ;ж = 7;з =8 ;и =9 ;й = 10;к = 11;л = 12;м = 13 ;н = 14;\nо = 15;п = 16;р = 17;с = 18;т = 19;у = 20;ф = 21;х = 22;ц = 23;ч = 24;ш = 25;щ = 26;ь = 27;ъ = 28;э = 29;ю = 30;я = 31;







//static void EnglishtoRussian()
//{
//    Console.WriteLine("Please input a word to translate. u can choose from 'Russia' 'Red' 'USA'. \n Capitals only.");
//    Console.WriteLine("");
//    string choose = Console.ReadLine();

//    var translation = new Dictionary<string, string>(){
//       {"Red","красный"},
//       {"USA","США"},
//       {"Russia","Россия"}
//       };
//    Console.WriteLine("The translation is " + translation[choose]);

//    if (choose != translation[choose])
//    {
//        Console.WriteLine("No!!! There's no in the dictionary.");
//    }
//}

//static void RussiantoEnglish()
//{
//    Console.WriteLine("Please input a word to translate. u can choose from 'Россия' 'красный' 'США'. \n Capitals only.");
//    Console.WriteLine("");
//    string choose = Console.ReadLine();

//    var translation = new Dictionary<string, string>(){
//       {"красный","Red"},
//       {"США","USA"},
//       {"Россия","Россия"}
//       };
//    Console.WriteLine("The translation is " + translation[choose]);

//    if (choose != translation[choose])
//    {
//        Console.WriteLine("No!!! There's no in the dictionary.");
//    }
//}
//using System;
//using System.Collections.Generic;

//namespace dictionary
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.Title = "M1A1 Барсук Евгений";
//            Console.ForegroundColor = ConsoleColor.Blue;
//            Console.OutputEncoding = System.Text.Encoding.Unicode;
//            for (; ; )
//            {

//                //а = 0;б = 1;в = 2;г = 3;д = 4;е = 5;ё =6 ;ж = 7;з =8 ;и =9 ;й = 10;к = 11;л = 12;м = 13 ;н = 14;\nо = 15;п = 16;р = 17;с = 18;т = 19;у = 20;ф = 21;х = 22;ц = 23;ч = 24;ш = 25;щ = 26;ь = 27;ъ = 28;э = 29;ю = 30;я = 31;
//                Console.WriteLine("This is Барсук Евгений translator.");
//                Console.WriteLine("Input '0' to translate words from words English to Russian. Input '1' for Russian to English.\n Go on:");
//                int chooselanguge = Int32.Parse(Console.ReadLine());
//                int varible = 0;
//                if (chooselanguge == 0)
//                {
//                    EnglishtoRussian();
//                }

//                if (chooselanguge == 1)
//                {
//                    RussiantoEnglish();
//                }



//            }

//        }

//        static void EnglishtoRussian()
//        {
//            Console.WriteLine("Please input a word to translate. u can choose from 'Russia' 'Red' 'USA'. \n Capitals only.");
//            Console.WriteLine("");
//            string choose = Console.ReadLine();

//            var translation = new Dictionary<string, string>(){
//               {"Red","красный"},
//               {"USA","США"},
//               {"Russia","Россия"}
//               };
//            Console.WriteLine("The translation is " + translation[choose]);

//            if (choose != translation[choose])
//            {
//                Console.WriteLine("No!!! There's no in the dictionary.");
//            }
//        }

//        static void RussiantoEnglish()
//        {
//            Console.WriteLine("Please input a word to translate. u can choose from 'Россия' 'красный' 'США'. \n Capitals only.");
//            Console.WriteLine("");
//            string choose = Console.ReadLine();

//            var translation = new Dictionary<string, string>(){
//               {"красный","Red"},
//               {"США","USA"},
//               {"Россия","РоссияRussia"}
//               };
//            Console.WriteLine("The translation is " + translation[choose]);

//            if (choose != translation[choose])
//            {
//                Console.WriteLine("No!!! There's no in the dictionary.");
//            }
//        }
//    }
//}
//-------------------------------------------------------------------------------------------------------------------------------------------------------------------
//if (chooselan == "Ru" && chooseLangfrom == "It")
//{
//    var translationit = new Dictionary<string, string>(){
//    {"красный","Rosso"},
//    {"Россия","Russia"},
//    {"США","Stati Uniti d'America"},
//    };
//    Console.WriteLine("Now, enter a word in Russian. U can choose from 'красный', 'Россия', 'США'.");

//    chooseWord = Console.ReadLine();

//    Console.WriteLine("The translation is [{0}]", translationit[chooseWord]);


//}

//var translation = new Dictionary<string, string>(){
//{"Red","красный"},
//{"Russia","Россия"},
//{"USA","США"},
//};

//var translationit = new Dictionary<string, string>(){
//{"Rosso","красный"},
//{"Russia","Россия"},
//{"Stati Uniti d'America","США"},
//};


using System;
using System.Collections.Generic;

namespace dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "M1B1 Барсук Евгений";
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            for (; ; )
            {

                string[] russiadurashawords = { "красный", "США", "Россия" };
                string[] americaamericadushiukraineu = { "Red", "USA", "Russia" };
                string[] italinopizzamamamia = { "Rosso", "Stati Uniti d'America", "Russia" };

                foreach (string Russianwords in russiadurashawords)
                {
                    foreach (string Americanwords in americaamericadushiukraineu)
                    {
                        foreach (string ItailianWords in italinopizzamamamia)
                        {
                            string chooseWord;

                           

                            //foreach (var translationRuIT in translationit)
                                Console.WriteLine("Select a starting languge. 'It' stands for italy. 'Gr' stands for Germany. 'US' stands for USA.");
                            string chooselan = Console.ReadLine();
                            Console.WriteLine("Now enter the languge you want to translate to.");    
                            string chooseLangfrom = Console.ReadLine();
                            
                            //italian code block
                            if (chooselan == "It" && chooseLangfrom == "US")
                            {
                                var translationit = new Dictionary<string, string>(){
                                {"Rosso","Red"},
                                {"Russia","Russia"},
                                {"Stati Uniti d'America","USA"},
                                {"TV", "T.V" }
                                };
                                Console.WriteLine("Now, enter a word in italino. U can choose from 'Rosso', 'Russia', 'Stati Uniti d'America' 'TV'.");

                                chooseWord = Console.ReadLine();

                                Console.WriteLine("The translation is [{0}]", translationit[chooseWord]);

                                
                            }

                            if (chooselan == "It" && chooseLangfrom == "Gr")
                            {
                                var translationit = new Dictionary<string, string>(){
                                {"Rosso","rot"},
                                {"Russia","Russland"},
                                {"Stati Uniti d'America","Vereinigte Staaten von Amerika"},
                                {"TV", "FERNSEHER" },

                                };
                                Console.WriteLine("Now, enter a word in italino. U can choose from 'Rosso', 'Russia', 'Stati Uniti d'America', 'TV'.");

                                chooseWord = Console.ReadLine();

                                Console.WriteLine("The translation is [{0}]", translationit[chooseWord]);


                            }

                            //End italian code block
                            //German Code block starts(russia still kinda dosen't work)
                            if (chooselan == "Gr" && chooseLangfrom == "It")
                            {
                                var translationit = new Dictionary<string, string>(){
                                {"rot","Rosso"},
                                {"Russland","Russia"},
                                {"Vereinigte Staaten von Amerika","Stati Uniti d'America"},
                                {"FERNSEHER","TV" },
                                };
                                Console.WriteLine("Now, enter a word in German. U can choose from 'rot', 'Russland', 'Vereinigte Staaten von Amerika', 'FERNSEHER'.");

                                chooseWord = Console.ReadLine();

                                Console.WriteLine("The translation is [{0}]", translationit[chooseWord]);


                            }

                            if (chooselan == "Gr" && chooseLangfrom == "US")
                            {
                                var translationit = new Dictionary<string, string>(){
                                {"rot","Red"},
                                {"Russland","Russia"},
                                {"Vereinigte Staaten von Amerika","USA"},
                                {"FERNSEHER", "T.V" },
                                };
                                Console.WriteLine("Now, enter a word in German. U can choose from 'rot', 'Russland', 'Vereinigte Staaten von Amerika', 'FERNSEHER'.");

                                chooseWord = Console.ReadLine();

                                Console.WriteLine("The translation is [{0}]", translationit[chooseWord]);


                            }
                            //end of German code block.
                            //start of US code block


                            if (chooselan == "US" && chooseLangfrom == "Gr")
                            {
                                var translationit = new Dictionary<string, string>(){
                                {"Red","rot"},
                                {"Russia","Russland"},
                                {"USA","Vereinigte Staaten von Amerika"},
                                {"T.V", "FERNSEHER" },
                                };
                                Console.WriteLine("Now, enter a word in US. U can choose from 'Red', 'Russia', 'USA', 'T.V'.");

                                chooseWord = Console.ReadLine();

                                Console.WriteLine("The translation is [{0}]", translationit[chooseWord]);


                            }

                            if (chooselan == "US" && chooseLangfrom == "It")
                            {
                                var translationit = new Dictionary<string, string>(){
                                {"Red","Rossa"},
                                {"Russia","Russia"},
                                {"USA","Stati Uniti d'America"},
                                {"T.V", "TV" },
                                };
                                Console.WriteLine("Now, enter a word in US. U can choose from 'Red', 'Russia', 'USA', 'T.V'.");

                                chooseWord = Console.ReadLine();

                                Console.WriteLine("The translation is [{0}]", translationit[chooseWord]);


                            }
                        }
                    }

                }
            }
        }
    }
}


