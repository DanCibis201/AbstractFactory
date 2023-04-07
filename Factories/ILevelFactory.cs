using AbstractFactory.Enemies;
using AbstractFactory.Planets;

namespace AbstractFactory.Factories
{
     interface ILevelFactory
     {
          Planet CreatePlanet();
          Alien CreateEnemy();
     }
}
