﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TournamentApp
{
    class Operations
    {
        
        public  void Register(List<Fighter> fighters)
        {
            string name;
            string surname;
            int weight;
            int fightsCount;
            int style;


            ConcreteBuilder _builder = new ConcreteBuilder();
            Console.WriteLine("Witaj w systemie rejestracji zawodników!\n");
            Console.WriteLine("Podaj imię: \n");
            name = Console.ReadLine();
            _builder.BuildName(name);
           

            Console.WriteLine("Podaj nazwisko: \n");
            surname = Console.ReadLine();
            _builder.BuildSurname(surname);

            Console.WriteLine("Podaj swoją wagę: \n");
            weight = int.Parse(Console.ReadLine());
            _builder.BuildWeight(weight);

            Console.WriteLine("Podaj liczbę stoczonych walk: \n");
            fightsCount = int.Parse(Console.ReadLine());
            _builder.BuildFightsCount(fightsCount);

            Console.WriteLine("Wybierz styl walki (1 - mma, 2- k1, 3- boks");
            style = int.Parse(Console.ReadLine());
            _builder.BuildStyle(style);

            Console.WriteLine("Pomyślnie zarejestrowałeś się do turnieju! Zostaniesz przeniesiony do menu głównego!\n");

            fighters.Add(_builder.GetFighter());
        }

        public  void FightersList(List<Fighter> fighters)
        {
            
            Console.WriteLine("Lista zawodników: \n");
            foreach (var fighter in fighters)
            {
                Console.WriteLine(fighter.name + " | " + fighter.surname + " | " + "Waga: " + fighter.weight + " kg. | Styl walki: " + ConvertStyle(fighter.style) + " | " + "Liczba stoczonych walk: " + fighter.fightsCount + "\n");
            }

            
        }
        public string ConvertStyle(int style)
        {
            if (style == 1)
            {
                return "MMA";
            }
            else if (style == 2)
            {
                return "K1";
            }
            else
            {
                return "Boks";
            }
        }
    }
}
