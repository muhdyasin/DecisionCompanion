using DecisionCompanion.Domain;
using DecisionCompanion.Application;

Console.WriteLine("=== Decision Companion System ===");
Console.WriteLine();

var criteria = new List<Criterion>();
var options = new List<Option>();


Console.Write("Enter number of criteria: ");
int criteriaCount = int.Parse(Console.ReadLine()!);

for (int i = 0; i < criteriaCount; i++)
{
    Console.WriteLine($"\nCriterion {i + 1}:");

    Console.Write("Name: ");
    string name = Console.ReadLine()!;

    Console.Write("Weight: ");
    double weight = double.Parse(Console.ReadLine()!);

    criteria.Add(new Criterion(name, weight));
}


Console.Write("\nEnter number of options: ");
int optionCount = int.Parse(Console.ReadLine()!);

for (int i = 0; i < optionCount; i++)
{
    Console.WriteLine($"\nOption {i + 1}:");

    Console.Write("Name: ");
    string optionName = Console.ReadLine()!;

    var scores = new Dictionary<string, double>();

    foreach (var criterion in criteria)
    {
        Console.Write($"Score for {criterion.Name}: ");
        double score = double.Parse(Console.ReadLine()!);
        scores[criterion.Name] = score;
    }

    options.Add(new Option(optionName, scores));
}


try
{
    IDecisionEvaluator evaluator = new WeightedDecisionEvaluator();
    var rankedResults = evaluator.Evaluate(options, criteria);

    var explanationService = new ExplanationService();
    var explanation = explanationService.GenerateExplanation(rankedResults);

    Console.WriteLine("\n=== Ranked Results ===\n");
    Console.WriteLine(explanation);
}
catch (Exception ex)
{
    Console.WriteLine($"\nError: {ex.Message}");
}