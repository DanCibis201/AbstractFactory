using System;
namespace AbstractFactory.Planets
{
     class PlanetSolace : Planet
     {
          public PlanetSolace()
          {
               Name = "Solace";
          }

          public override void Conquer()
          {
               Console.WriteLine($"Conquering Planet Solace...");
          }
     }
}
