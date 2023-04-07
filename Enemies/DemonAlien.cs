namespace AbstractFactory.Enemies
{
     class DemonAlien : Alien
     {
          public DemonAlien()
          {
               HealthPoints = 100;
          }

          public override void Spawn()
          {
               Console.WriteLine($"Demon Alien spawning with {HealthPoints} HP");
          }
     }
}
