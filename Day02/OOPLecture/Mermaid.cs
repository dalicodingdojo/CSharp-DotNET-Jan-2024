public class Mermaid :Monster
{
    
    public double Swim { get; set; }
    public double Seduction { get; set; }

    public Mermaid(string name ) :base(name, 0.7, true, "Magic")
    {
        Swim = 1;
        Seduction = 1;
    }
}