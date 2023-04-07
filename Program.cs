using AbstractFactory.Enemies;
using AbstractFactory.Factories;
using AbstractFactory.Planets;

namespace AbstractFactory
{
     class Program
     {
          static void Main(string[] args)
          {
               ILevelFactory factory = new Level1Factory();

               Alien alien = factory.CreateEnemy();
               Planet planet = factory.CreatePlanet();

               alien.Spawn();
               planet.Conquer();

               Console.WriteLine(""); 

               ILevelFactory factory2 = new Level2Factory();
               
               Alien alien2 = factory2.CreateEnemy();
               Planet planet2 = factory2.CreatePlanet();

               alien2.Spawn();
               planet2.Conquer();

          }
     }
}
//Pros:
// + Avem interfata pentru a crea obiecte, usuareaza utilizarea fabricii si evitarea erorilor
//Cons:
// - Dificil de implementat
// - Poate duce la crearea diferitor clase suplimentare => complexitate mai mare
