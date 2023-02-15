using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            Bird pidgeon = new Bird(true, false, "small", "diurnal");
            pidgeon.Habitat = "urban";
            pidgeon.AnimalCall = "bird purring? you know what I mean";
            pidgeon.MovementStyle = "flight";
            pidgeon.PositionInFoodChain = "low";

            Console.WriteLine($"Bird Specs (Name - Pidgeon):\nHabitat: {pidgeon.Habitat}\nMovement style: {pidgeon.MovementStyle}\nRanking in Food Chain: {pidgeon.PositionInFoodChain}" +
                $"\nSize: {pidgeon.Size}\nSleeping Cycle: {pidgeon.ActiveHours}\n\n");
            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
            Reptile iguana = new Reptile() { DryOrWetClimate = "tropical", Swims = true, Speed = "fast", AnimalCall = "none"};
            iguana.CanCamouflage = false;
            iguana.PositionInFoodChain = "predator and prey";
            iguana.MovementStyle = "legs";

            Console.WriteLine($"Reptile Specs (Name - Ignuana):\nHabitat: {iguana.Habitat}\nMovement Style: {iguana.MovementStyle}\nRanking in Food Chain: {iguana.PositionInFoodChain}" +
                $"\nCan Camouflage: {iguana.CanCamouflage}\nClimate: {iguana.DryOrWetClimate}");
        }
    }
}
