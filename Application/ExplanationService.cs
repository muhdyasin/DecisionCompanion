using DecisionCompanion.Domain;

namespace DecisionCompanion.Application;

public class ExplanationService
{
    public string GenerateExplanation(List<EvaluatedOption> rankedOptions)
    {
        if (rankedOptions.Count == 0)
            return "No options evaluated.";

        var result = "";

        for (int i = 0; i < rankedOptions.Count; i++)
        {
            var option = rankedOptions[i];
            result += $"Rank {i + 1}: {option.Name} (Score: {option.FinalScore:F2})\n";

            foreach (var contribution in option.Contributions)
            {
                result += $"  - {contribution.Key}: {contribution.Value:F2}\n";
            }

            result += "\n";
        }

        if (rankedOptions.Count > 1 &&
            rankedOptions[0].FinalScore == rankedOptions[1].FinalScore)
        {
            result += "Top options are tied based on weighted scoring.\n";
        }

        return result;
    }
}