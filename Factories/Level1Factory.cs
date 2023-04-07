using AbstractFactory.Enemies;
using AbstractFactory.Planets;

namespace AbstractFactory.Factories
{
     class Level1Factory : ILevelFactory
     {
          public Alien CreateEnemy()
          {
               return new DemonAlien();
          }

          public Planet CreatePlanet()
          {
               return new PlanetSolace();
          }
     }
}
