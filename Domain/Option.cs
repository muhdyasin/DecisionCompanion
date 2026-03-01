namespace DecisionCompanion.Domain;

public class Option
{
    public string Name { get; set; }

    public Dictionary<string, double> Scores { get; set; }

    public Option(string name, Dictionary<string, double> scores)
    {
        Name = name;
        Scores = scores;
    }
}