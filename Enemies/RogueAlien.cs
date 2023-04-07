namespace AbstractFactory.Enemies
{
     class RogueAlien : Alien
     {
          public RogueAlien()
          {
               HealthPoints = 150;
          }

          public override void Spawn()
          {
               Console.WriteLine($"Rogue Alien spawning with {HealthPoints} HP");
          }
     }
}
