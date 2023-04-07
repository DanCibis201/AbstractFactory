namespace AbstractFactory.Enemies
{
     abstract class Alien
     {
          public int HealthPoints { get; set; }

          public abstract void Spawn();
     }
}
