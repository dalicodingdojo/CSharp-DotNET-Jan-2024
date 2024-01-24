public abstract class Monster 
{
    // Properties
    public string Name { get; set; } 
    public double Power { get; set; }
    public bool IsImmortal { get; set; }
    public string PowerType { get; set; }

    // Constructors
    public Monster(string name, double power, bool isImmortal, string powerType)
    {
        Name = name;
        Power = power;
        IsImmortal = isImmortal;
        PowerType = powerType;
    }

    // Methods
    public void Transform() 
    {
        Power += Power *2;
        System.Console.WriteLine($"[TRANSFORM] {Name} has activated Monster Mode.\nPlease run and never look back.");
    }
}