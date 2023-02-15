using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Animal
    {
        public string Habitat;
        public string MovementStyle;
        public string AnimalCall;
        public string PositionInFoodChain;
        //public Animal(string habitat, string movementStyle, string position, string animalCall)     
        //{
        //    Habitat = habitat;
        //    MovementStyle = movementStyle;
        //    PositionInFoodChain = position;
        //    AnimalCall = animalCall;
        //}

        private void Sound()
        {
            Console.WriteLine(AnimalCall);
        }
    }
}
