namespace Classwork_15._10._2022_2_.Models.Firearms
{
    internal abstract class Firearm : iShoot
    {
        public string Name { get; set; }

        public int HitCounter { get; set; }
        private int Accuracy;
        private int Size;
        private Random Random;

        public Magazine Magazine;
        private Firearm() { }

        public Firearm(int magazine, int accuracy, string name)
        {
            Name = name;
            HitCounter = 0;
            Accuracy = accuracy;
            Size = magazine;
            Random = new Random();
            Magazine = new Magazine(magazine);
        }

        public void Reload()
        {
            Magazine.Size = Size;
        }

        public virtual void Shoot(int x)
        {
            for (int i = 0; i < x; i++)
            {
                if (Target())
                {
                    if (Magazine.Size == 0)
                    {
                        Console.WriteLine($"***{Name} reload***");
                        Reload();
                    }
                    Console.WriteLine($"{Name} hits the target");
                    Magazine.Size--;
                    HitCounter++;
                }
                else
                {
                    if (Magazine.Size == 0)
                    {
                        Console.WriteLine($"***{Name} reload***");
                        Reload();
                    }
                    Console.WriteLine($"{Name} missed the shot");
                    Magazine.Size--;
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
