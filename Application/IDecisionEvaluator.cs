using DecisionCompanion.Domain;

namespace DecisionCompanion.Application;

public interface IDecisionEvaluator
{
    List<EvaluatedOption> Evaluate(
        List<Option> options,
        List<Criterion> criteria);
}