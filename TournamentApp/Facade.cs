﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TournamentApp
{
    class Facade
    {
        Operations operations = new Operations();
        SaveToFile saveToFile = new SaveToFile();
        List<Fighter> fighters = new List<Fighter>();

        public void Menu()
        {
            Console.WriteLine("Strona główna aplikacji turniejowej gali TwojStaryZawadiaka, wybierz opcje: \n");
            Console.WriteLine("1 - Rejestracja zawodnika | 2 - Lista Zawodników | 3 - Informacje | 4 - Wyjście");
            int option;



            option = int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    operations.Register(fighters);
                    saveToFile.Save(fighters);
                    Menu();
                    break;
                case 2:
                    operations.FightersList(fighters);
                    Menu();
                    break;
                case 4:
                    Console.WriteLine("Wciśnij dowolny klawisz...");
                    Console.ReadKey();
                    return;

            }

        }
    }
}
    

