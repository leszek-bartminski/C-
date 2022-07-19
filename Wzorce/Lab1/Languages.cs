using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    class Languages
    {
        public static Dictionary<string, string> Polish = new Dictionary<string, string>();
        public static Dictionary<string, string> English = new Dictionary<string, string>();

        public static string[] Keys = new string[]
        {
            "wybierz_jedna_z_funkcji",
            "podaj_liczbe_od_1_do_4_Pozostale_znaki_są_niedozwolone",
            "podałes_niewlasciwa_liczbe_Podaj_liczbe_z_zakresu_od_1_do_4",
            "wybrales_funkcje",
            "wybierz_przedzial_calkowania_wciskajac_1_2_lub_3_na_klawiaturze",
            "podaj_liczbe_od_1_do_3_Pozostale_znaki_są_niedozwolone",
            "podałes_niewlasciwa_liczbe_Podaj_liczbe_z_zakresu_od_1_do_3",
            "obliczanie_calki_metoda_trapezow",
            "calka_metoda_trapezow_to",
            "obliczanie_calki_metoda_kwadratow",
            "calka_metoda_kwadratow_to",
            "jesli_chcesz_kontynuowac_wcisnij_y",
            "jesli_chcesz_przerwac_wcisnij_kazdy_inny_klawisz"
        };


        public static void PolishDictionary()
        {
            Polish.Add(Keys[0], "Wybierz jedną z funkcji:");
            Polish.Add(Keys[1], "Podaj liczbę od 1 do 4. \nPozostałe znaki są niedozwolone.");
            Polish.Add(Keys[2], "Podałeś niewłaściwą liczbę. Podaj liczbę z zakresu od 1 do 4:");
            Polish.Add(Keys[3], "Wybrałeś funkcję");
            Polish.Add(Keys[4], "Wybierz przedział całkowania, wciskając 1, 2 lub 3 na klawiaturze:");
            Polish.Add(Keys[5], "Podaj liczbę od 1 do 3. \nPozostałe znaki są niedozwolone.");
            Polish.Add(Keys[6], "Podałeś niewłaściwą liczbę. Podaj liczbę z zakresu od 1 do 3:");
            Polish.Add(Keys[7], "Obliczanie całki metodą trapezów:");
            Polish.Add(Keys[8], "Całka metodą trapezów to:");
            Polish.Add(Keys[9], "Obliczanie całki metodą kwadratów: ");
            Polish.Add(Keys[10], "Całka metodą kwadratów to:");
            Polish.Add(Keys[11], "Jeśli chcesz kontynuować, wciśnij 'Y'. ");
            Polish.Add(Keys[12], "Jeśli chcesz przerwać, wciśnij każdy inny klawisz.");
        }

        public static void EnglishDictionary()
        {
            English.Add(Keys[0], "Choose one function:");
            English.Add(Keys[1], "Enter integer number between 1 and 4. \nOther signs are forbidden.");
            English.Add(Keys[2], "You entered incorrect number. Enter number between 1 and 4:");
            English.Add(Keys[3], "You chose function");
            English.Add(Keys[4], "Choose integral range by pressing 1, 2 or 3 on keyboard:");
            English.Add(Keys[5], "Enter integer number between 1 and 3. \nOther signs are forbidden.");
            English.Add(Keys[6], "You entered incorrect number. Enter number between 1 and 3:");
            English.Add(Keys[7], "Integral calculation by trapezoidal method: ");
            English.Add(Keys[8], "Result by trapezoidal method is:");
            English.Add(Keys[9], "Integral calculation by rectangular method:");
            English.Add(Keys[10], "Result by rectangular method is:");
            English.Add(Keys[11], "To continue, press 'Y'");
            English.Add(Keys[12], "To close program, press any other key.");
        }
    }
}
