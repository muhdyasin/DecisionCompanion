using DecisionCompanion.Domain;
using DecisionCompanion.Application;

var criteria = new List<Criterion>
{
    new Criterion("Performance", 9),
    new Criterion("Battery", 1)
};

var options = new List<Option>
{
    new Option("Laptop A", new Dictionary<string, double>
    {
        { "Performance", 8 },
        { "Battery", 10 }
    }),
    new Option("Laptop B", new Dictionary<string, double>
    {
        { "Performance", 9 },
        { "Battery", 1 }
    })
};

IDecisionEvaluator evaluator = new WeightedDecisionEvaluator();
var rankedResults = evaluator.Evaluate(options, criteria);

var explanationService = new ExplanationService();
var explanation = explanationService.GenerateExplanation(rankedResults);

Console.WriteLine(explanation);