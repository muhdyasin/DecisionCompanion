namespace DecisionCompanion.Domain;

public class EvaluatedOption
{
    public string Name { get; set; }
    public double FinalScore { get; set; }
    public Dictionary<string, double> Contributions { get; set; }

    public EvaluatedOption(string name, double finalScore, Dictionary<string, double> contributions)
    {
        Name = name;
        FinalScore = finalScore;
        Contributions = contributions;
    }
}