using AbstractFactory.Enemies;
using AbstractFactory.Planets;

namespace AbstractFactory.Factories
{
     class Level2Factory : ILevelFactory
     {
          public Alien CreateEnemy()
          {
               return new RogueAlien();
          }

          public Planet CreatePlanet()
          {
               return new PlanetXondor();
          }
     }
}