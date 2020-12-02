using System;
using System.Collections.Generic;

namespace TournamentApp
{
    public class ConcreteBuilder:IBuilder
    {
        
        
        private Fighter _fighter = new Fighter();


        public void BuildFightsCount(int fightsCount)
        {
            _fighter.fightsCount = fightsCount;
        }

        public void BuildName(string name)
        {
            _fighter.name = name;
        }

        public void BuildStyle(int style)
        {
            _fighter.style = style;
        }

        public void BuildSurname(string surname)
        {
            _fighter.surname = surname;
        }

        public void BuildWeight(int weight)
        {
            _fighter.weight = weight;
        }

        public ConcreteBuilder()
        {
            this.Reset();
        }

        public void Reset()
        {
            this._fighter = new Fighter();
        }

       

        public Fighter GetFighter()
        {
            Fighter result = this._fighter;

            this.Reset();

            return result;
        }
    }
}
