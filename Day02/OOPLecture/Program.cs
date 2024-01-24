

Soldier alex = new Soldier("Alex");
Soldier sam = new Soldier("Sam", 31);
Soldier max = new Soldier("Max", 28,0.95,1);
Sniper bob = new Sniper("Bob", 44);
// System.Console.WriteLine(alex.Name);
// alex.ShowInfo();
// System.Console.WriteLine("------------------------------------------------");
// sam.ShowInfo();
// System.Console.WriteLine("------------------------------------------------");
// max.ShowInfo();
// max.ShowInfo();
// alex.Attack(max, 0.2);
// max.ShowInfo();
bob.ShowInfo();
List<Soldier> army = new(){alex, max, bob};

foreach(Soldier s in army)
{
    s.ShowInfo();
}

// Monster hulk = new Monster("Hulk", 0.85, false,"Strength");
Centaur kim = new Centaur("Kim", 0.8, 0.75);
Mermaid alice = new Mermaid("Alice");