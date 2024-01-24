public class Sniper : Soldier, IUseWeapon //! Inheritance
{
    // Properties 
    // ! Specific Properties for the Sniper Class = Polymorphism (1)
    public double Precision { get; set; }
    public double EagleEye { get; set; }
    public double HiddenSkills { get; set; }
    public string Weapon { get; set; }
    public string Type { get; set; } = "Fire";
    // Constructors
    public Sniper(string name, int age): base(name, age, 1,1)
    {
        Precision = 0.9;
        EagleEye = 0.7;
        HiddenSkills = 1;
        Weapon = "Sniper";
    }
    // Methods
    // ! override this method that belongs to my parent (base : Soldier) class => Polymorphism (2)
    public override void ShowInfo()
    {
        base.ShowInfo();
        System.Console.WriteLine($"Precision : {Precision}\nEagle Eye : {EagleEye}\nHidden Skills : {HiddenSkills}\nWeapon : {Weapon}");
    }

    public void UseWeapon()
    {
        throw new NotImplementedException();
    }
}