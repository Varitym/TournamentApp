using System;
namespace TournamentApp
{
    public interface IBuilder
    {
        void BuildName(string name);
        void BuildSurname(string surname);
        void BuildWeight(int weight);
        void BuildFightsCount(int fightsCount);
        void BuildStyle(int style);
    }


}
