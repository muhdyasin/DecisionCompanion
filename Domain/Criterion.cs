namespace DecisionCompanion.Domain;

public class Criterion
{
    public string Name { get; set; }
    public double Weight { get; set; }

    public Criterion(string name, double weight)
    {
        Name = name;
        Weight = weight;
    }
}