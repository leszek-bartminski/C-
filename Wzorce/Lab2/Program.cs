using System;
using System.Collections.Generic;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IFunction> FunctionList = new List<IFunction>();
            List<ICalculator> CalculatorList = new List<ICalculator>();

            FunctionList.Add(new Function1());
            FunctionList.Add(new Function2());
            FunctionList.Add(new Function3());
            //ZADANIE 2 - dodanie nowej funkcji - 2 miejsce zmiany kodu:
            FunctionList.Add(new Function4());

            CalculatorList.Add(new TrapezoidalMethod());
            CalculatorList.Add(new RectangularMethod());

            ChooseFunctionMenu(FunctionList);
        }

        public static void ChooseFunctionMenu(List<IFunction> FunctionList)
        {
            int functionId = 0;
            IFunction function = FunctionList.Find(function => function.Id == functionId);

            bool checkIfIntLanguageChoice;
            int userLanguageChoice;
            int languageId = 0;

            Factory languageFactory = new Factory();

            do
            {
                Console.WriteLine("Wybierz wersję językową, wciskając 1 lub 2: \nChoose language version by pressing 1 or 2:");
                Console.WriteLine("1. - Polski");
                Console.WriteLine("2. - English");


                checkIfIntLanguageChoice = int.TryParse(Console.ReadLine(), out userLanguageChoice);

                if (!checkIfIntLanguageChoice)
                {
                    Console.WriteLine("Wprowadziłeś zły klawisz. Wciśnij 1 lub 2: \nYou pressed wrong key. Press 1 or 2: ");
                }
                else
                {
                    if (1 > userLanguageChoice || userLanguageChoice > 2)
                    {
                        Console.WriteLine("Wprowadziłeś zły klawisz. Wciśnij 1 lub 2: \nYou pressed wrong key. Press 1 or 2: ");
                        checkIfIntLanguageChoice = false;
                    }
                    else
                    {
                        languageId = userLanguageChoice;
                        checkIfIntLanguageChoice = true;

                        ILanguage language = languageFactory.CreateLanguage(languageId);

                        bool checkIfIntFunctionChoice;
                        do
                        {
                            language.WriteLine(Languages.wybierz_jedna_z_funkcji);
                            Console.WriteLine(language.GetTranslation("wybierz_jedna_z_funkcji"));
                            foreach (IFunction functions in FunctionList)
                            {
                                Console.WriteLine($"{functions.Id}.: {functions.Name}");
                            }

                            //3 i 4 miejsce zmiany w kodzie (zmiana menu wyboru z 3 punktowego, w przypadku 3 funkcji na 4 punktowe)
                            checkIfIntFunctionChoice = int.TryParse(Console.ReadLine(), out functionId);
                            if (!checkIfIntFunctionChoice)
                            {
                                Console.WriteLine(language.GetTranslation("podaj_liczbe_od_1_do_4_Pozostale_znaki_są_niedozwolone"));
                            }
                            else if (1 > functionId || functionId > 4)
                            {                               
                                Console.WriteLine(language.GetTranslation("podałes_niewlasciwa_liczbe_Podaj_liczbe_z_zakresu_od_1_do_4"));
                                checkIfIntFunctionChoice = false;
                            }
                        } while (!checkIfIntFunctionChoice);


                        function = FunctionList.Find(function => function.Id == functionId);
                        Console.WriteLine($"{language.GetTranslation("wybrales_funkcje")} {function.Name}");
                        

                        bool checkIfIntRangeChoice;
                        int rangeId;
                        do
                        {
                            Console.WriteLine(language.GetTranslation("wybierz_przedzial_calkowania_wciskajac_1_2_lub_3_na_klawiaturze"));
                            Console.WriteLine("1: -10, 10");
                            Console.WriteLine("2: -5, 20");
                            Console.WriteLine("3: -5, 0");

                            
                            checkIfIntRangeChoice = int.TryParse(Console.ReadLine(), out rangeId);

                            if (!checkIfIntRangeChoice)
                            {
                                Console.WriteLine(language.GetTranslation("podaj_liczbe_od_1_do_3_Pozostale_znaki_są_niedozwolone"));
                            }
                            else if (1 > rangeId || rangeId > 3)
                            {
                                Console.WriteLine(language.GetTranslation("podałes_niewlasciwa_liczbe_Podaj_liczbe_z_zakresu_od_1_do_3"));
                                checkIfIntRangeChoice = false;
                            }
                        } while (!checkIfIntRangeChoice);

                        //Range rangeList = new Range();

                        List<Range> list = Range.CreateRangeList();
                        int i = 0;
                        foreach (var rangeObject in list)
                        {
                            i++;
                            if (i == rangeId)
                            {
                                TrapezoidalMethod TrapCalculatorRange1 = new TrapezoidalMethod();
                                TrapCalculatorRange1.GetIntegralValue(function, rangeObject, language);

                                RectangularMethod RecCalculatorRange1 = new RectangularMethod();
                                RecCalculatorRange1.GetIntegralValue(function, rangeObject, language);
                            }
                        }
                        Console.WriteLine(language.GetTranslation("jesli_chcesz_kontynuowac_wcisnij_y"));
                        language.WriteLine("jesli_chcesz_przerwac_wcisnij_kazdy_inny_klawisz");

                        var continueOrStop = Console.ReadLine();
                        if (continueOrStop == "y" || continueOrStop == "Y")
                        {
                            checkIfIntLanguageChoice = false;
                        }
                    }
                }
            } while (!(checkIfIntLanguageChoice));
        }
    }
}

