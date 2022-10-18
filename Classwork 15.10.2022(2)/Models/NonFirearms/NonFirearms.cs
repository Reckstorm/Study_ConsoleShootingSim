using Classwork_15._10._2022_2_.Models.Firearms;

namespace Classwork_15._10._2022_2_.Models.NonFirearms
{
    internal class NonFirearms : iShoot
    {
        public string Name { get; set; }

        public int HitCounter { get; set; }
        private int Accuracy;
        private int Size;
        private Random Random;

        public Quiver Quiver;
        private NonFirearms() { }

        public NonFirearms(int quiver, int accuracy, string name)
        {
            Name = name;
            HitCounter = 0;
            Accuracy = accuracy;
            Size = quiver;
            Random = new Random();
            Quiver = new Quiver(quiver);
        }

        public void Reload()
        {
            Quiver.Size = Size;
        }

        public virtual void Shoot(int x)
        {
            for (int i = 0; i < x; i++)
            {
                if (Target())
                {
                    if (Quiver.Size == 0)
                    {
                        Console.WriteLine($"***{Name} reload***");
                        Reload();
                    }
                    Console.WriteLine($"{Name} hits the target");
                    Quiver.Size--;
                    HitCounter++;
                }
                else
                {
                    if (Quiver.Size == 0)
                    {
                        Console.WriteLine($"***{Name} reload***");
                        Reload();
                    }
                    Console.WriteLine($"{Name} missed the shot");
                    Quiver.Size--;
                }
            }
        }

        public bool Target()
        {
            if (Accuracy > Random.Next(1, 5))
            {
                return true;
            }
            return false;
        }
    }
}
