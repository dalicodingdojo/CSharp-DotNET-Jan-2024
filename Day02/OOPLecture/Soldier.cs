/*
class  : blueprint or template to cerate objects
class  : 
        constructor :  create new objects
        Attributes/Fields/Properties = What the class can have (Data)
        Methods  : What the class ca do or behave 
Object :  Instance of the class

In Python : 
    class Soldier :
       #Constructor 
        def __init__(self,name):
            #Attributes
            self.name = name
        #Methods
        1- Instance Methods :  no decorator has access to instance attributes and methods
        2- Class Methods : @classmethod default parameter cls has all access
        3- Static Methods : @staticmethod not access at all


In JavaScript : 
    class Soldier {
        constructor(name){
            this.name = name
            this._id = 1
        }
    }
*/

public class Soldier : IUseWeapon
{
    // Properties
    public string Name {get;set;}
    public int Age { get; set; }
    public double Power { get; set; } = 0.2;
    public double Health { get; set; } = 0.2;
    public string Weapon { get; set; }
    public string Type { get; set; }

    // Constructors **
    public Soldier(string name)
    {
        Name = name;
        Age = 18;
    }
    public Soldier(string name, int age)
    {
        Name = name;
        Age = age;
        Power = 0.5;
        Health = 0.5;
    }
    public Soldier(string name, int age, double power, double health)
    {
        Name = name;
        Age = age;
        Power = power;
        Health = health;
    }
    // Methods
    public virtual void ShowInfo() 
    {
        System.Console.WriteLine($"Soldier Name : {Name}\nAge : {Age}\nPower : {Power *100}%\nHealth : {Health*100}%");
    }
    public int IncreaseAge()
    {
        Age+=1;
        return Age;
    }
    public void Attack(Soldier target, double damage)
    {
        target.Health-= Power * damage * 10;
        System.Console.WriteLine($"[ATTACK] Soldier {Name} attacked Soldier {target.Name} by damage Rate equal to {damage} . ");
    }

    public void UseWeapon()
    {
        System.Console.WriteLine("Fire 🔥🔥🔥");
    }
}