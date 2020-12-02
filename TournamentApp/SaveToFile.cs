using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace TournamentApp
{
    class SaveToFile
    {
        Operations _operations = new Operations();
        private string filePath = "zawodnicy.txt";
        public void Save(List<Fighter> fighters)
        {
            File.Delete(filePath);
            foreach (var fighter in fighters)
            {
                var fighterString = fighter.name + " | " + fighter.surname + " | " + "Waga: " + fighter.weight + " kg. | Styl walki: " + _operations.ConvertStyle(fighter.style) + " | " + "Liczba stoczonych walk: " + fighter.fightsCount+"\n";
                File.AppendAllText(filePath, fighterString);

            }
        }


    }
}