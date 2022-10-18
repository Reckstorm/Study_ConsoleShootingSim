using Classwork_15._10._2022_2_.Models.Firearms;
using Classwork_15._10._2022_2_.Models.NonFirearms;

do
{
    Console.Clear();
    Console.WriteLine("Choose weapon");
    Console.WriteLine("1 - Pistol");
    Console.WriteLine("2 - Rifle");
    Console.WriteLine("3 - Machine Gun");
    Console.WriteLine("4 - Bow");
    Console.WriteLine("5 - Crossbow");
    Console.WriteLine("6 - Slingshot");
    Console.WriteLine("7 - Exit");

    string str = Console.ReadLine();
    int control = 0;
    bool tryParse = int.TryParse(str, out int result);
    if (tryParse)
    {
        control = int.Parse(str);
    }
    else
    {
        Console.Clear();
        Console.WriteLine("Invalid command");
        Console.ReadKey();
    }
    string path = "file.txt";

    if (control == 1)
    {
        Console.Clear();
        Firearm firearm = new Pistol();
        Console.WriteLine("Weapon is Pistol");
        do
        {
            Console.Clear();
            Console.WriteLine("Enter amount of shots");
            str = Console.ReadLine();
            tryParse = int.TryParse(str, out result);
            if (tryParse)
            {
                control = int.Parse(str);
            }
        } while (!tryParse);
        firearm.Shoot(control);
        str = $"\nShoot from {firearm.Name}";
        File.AppendAllText(path, str);
        Console.WriteLine($"Total shots: {control}");
        Console.WriteLine($"Hits: {firearm.HitCounter}");
        Console.WriteLine($"Misses: {control - firearm.HitCounter}");
        Console.ReadKey();
    }
    else if (control == 2)
    {
        Console.Clear();
        Firearm firearm = new Rifle();
        Console.WriteLine("Weapon is Rifle");
        do
        {
            Console.Clear();
            Console.WriteLine("Enter amount of shots");
            str = Console.ReadLine();
            tryParse = int.TryParse(str, out result);
            if (tryParse)
            {
                control = int.Parse(str);
            }
        } while (!tryParse);
        firearm.Shoot(control);
        str = $"\nShoot from {firearm.Name}";
        File.AppendAllText(path, str);
        Console.WriteLine($"Total shots: {control}");
        Console.WriteLine($"Hits: {firearm.HitCounter}");
        Console.WriteLine($"Misses: {control - firearm.HitCounter}");
        Console.ReadKey();
    }
    else if (control == 3)
    {
        Console.Clear();
        Firearm firearm = new MachineGun();
        Console.WriteLine("Weapon is Rifle");
        do
        {
            Console.Clear();
            Console.WriteLine("Enter amount of shots");
            str = Console.ReadLine();
            tryParse = int.TryParse(str, out result);
            if (tryParse)
            {
                control = int.Parse(str);
            }
        } while (!tryParse);
        firearm.Shoot(control);
        str = $"\nShoot from {firearm.Name}";
        File.AppendAllText(path, str);
        Console.WriteLine($"Total shots: {control}");
        Console.WriteLine($"Hits: {firearm.HitCounter}");
        Console.WriteLine($"Misses: {control - firearm.HitCounter}");
        Console.ReadKey();
    }
    else if (control == 4)
    {
        Console.Clear();
        NonFirearms nonFirearm = new Crossbow();
        Console.WriteLine("Weapon is Crossbow");
        do
        {
            Console.Clear();
            Console.WriteLine("Enter amount of shots");
            str = Console.ReadLine();
            tryParse = int.TryParse(str, out result);
            if (tryParse)
            {
                control = int.Parse(str);
            }
        } while (!tryParse);
        nonFirearm.Shoot(control);
        str = $"\nShoot from {nonFirearm.Name}";
        File.AppendAllText(path, str);
        Console.WriteLine($"Total shots: {control}");
        Console.WriteLine($"Hits: {nonFirearm.HitCounter}");
        Console.WriteLine($"Misses: {control - nonFirearm.HitCounter}");
        Console.ReadKey();
    }
    else if (control == 5)
    {
        Console.Clear();
        NonFirearms nonFirearm = new Bow();
        Console.WriteLine("Weapon is Bow");
        do
        {
            Console.Clear();
            Console.WriteLine("Enter amount of shots");
            str = Console.ReadLine();
            tryParse = int.TryParse(str, out result);
            if (tryParse)
            {
                control = int.Parse(str);
            }
        } while (!tryParse);
        nonFirearm.Shoot(control);
        str = $"\nShoot from {nonFirearm.Name}";
        File.AppendAllText(path, str);
        Console.WriteLine($"Total shots: {control}");
        Console.WriteLine($"Hits: {nonFirearm.HitCounter}");
        Console.WriteLine($"Misses: {control - nonFirearm.HitCounter}");
        Console.ReadKey();
    }
    else if (control == 6)
    {
        Console.Clear();
        NonFirearms nonFirearm = new Slingshot();
        Console.WriteLine("Weapon is Slingshot");
        do
        {
            Console.Clear();
            Console.WriteLine("Enter amount of shots");
            str = Console.ReadLine();
            tryParse = int.TryParse(str, out result);
            if (tryParse)
            {
                control = int.Parse(str);
            }
        } while (!tryParse);
        nonFirearm.Shoot(control);
        str = $"\nShoot from {nonFirearm.Name}";
        File.AppendAllText(path, str);
        Console.WriteLine($"Total shots: {control}");
        Console.WriteLine($"Hits: {nonFirearm.HitCounter}");
        Console.WriteLine($"Misses: {control - nonFirearm.HitCounter}");
        Console.ReadKey();
    }
    else if (control == 7)
    {
        Console.Clear();
        Console.WriteLine("Exiting");
        break;
    }
} while (true);