using DecisionCompanion.Domain;

namespace DecisionCompanion.Application;

public class WeightedDecisionEvaluator : IDecisionEvaluator
{
    public List<EvaluatedOption> Evaluate(
        List<Option> options,
        List<Criterion> criteria)
    {
        ValidateInput(options, criteria);

        var normalizedCriteria = NormalizeWeights(criteria);

        var evaluatedOptions = new List<EvaluatedOption>();

        foreach (var option in options)
        {
            var contributions = new Dictionary<string, double>();
            double totalScore = 0;

            foreach (var criterion in normalizedCriteria)
            {
                double score = option.Scores[criterion.Name];
                double contribution = score * criterion.Weight;

                contributions[criterion.Name] = contribution;
                totalScore += contribution;
            }

            evaluatedOptions.Add(
                new EvaluatedOption(option.Name, totalScore, contributions)
            );
        }

        return evaluatedOptions
            .OrderByDescending(o => o.FinalScore)
            .ToList();
    }

    private void ValidateInput(List<Option> options, List<Criterion> criteria)
    {
        if (options == null || options.Count == 0)
            throw new ArgumentException("Options cannot be empty.");

        if (criteria == null || criteria.Count == 0)
            throw new ArgumentException("Criteria cannot be empty.");

        double totalWeight = criteria.Sum(c => c.Weight);

        if (totalWeight <= 0)
            throw new ArgumentException("Total weight must be greater than zero.");

        foreach (var option in options)
        {
            foreach (var criterion in criteria)
            {
                if (!option.Scores.ContainsKey(criterion.Name))
                {
                    throw new ArgumentException(
                        $"Option '{option.Name}' is missing score for criterion '{criterion.Name}'."
                    );
                }
            }
        }
    }

    private List<Criterion> NormalizeWeights(List<Criterion> criteria)
    {
        double totalWeight = criteria.Sum(c => c.Weight);

        return criteria
            .Select(c => new Criterion(
                c.Name,
                c.Weight / totalWeight))
            .ToList();
    }
}