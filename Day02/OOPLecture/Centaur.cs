public class Centaur : Monster, IUseWeapon
{
    public double Speed { get; set; }
    public double  Armor { get; set; }
    public string Weapon { get; set; }
    public string Type { get; set; } = "Iron";

    public Centaur(string name , double speed, double armor ) : base(name, 0.9, false, "Fighting")
    {
        Speed = speed;
        Armor = armor;
        Weapon = "Spear";
    }
    public void UseWeapon()
    {
         System.Console.WriteLine("This Monster is using his weapon.");
    }
}