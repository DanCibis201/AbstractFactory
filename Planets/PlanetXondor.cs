namespace AbstractFactory.Planets
{
    class PlanetXondor : Planet
     {
          public PlanetXondor()
          {
               Name = "Xondor";
          }

          public override void Conquer()
          {
               Console.WriteLine("Conquering Planet Xondor...");
          }
     }
}
