# Research Log

## AI Prompts Used

During development, I used AI as a reasoning assistant and implementation helper.

The following types of prompts were used:

- How to design a weighted decision engine in C#
- Explanation of weight normalization
- Does normalization affect ranking?
- Why normalization is necessary in weighted scoring?
- What is compensatory decision behavior?
- Difference between scoring models and constraint models
- How to architect separation between evaluator and explanation logic?
- How to handle ties in weighted scoring systems?
- How to validate decision input data properly?
- How to structure a clean CLI-based architecture?

AI was used for both conceptual clarification and generating an initial implementation draft, which I then reviewed and refined.

---

## Search Queries (Including External Research)

In addition to AI prompts, I researched:

- "Weighted Sum Model in decision making"
- "Multi-criteria decision analysis weighted sum"
- "Normalization of weights in decision models"
- "Compensatory vs non-compensatory decision models"
- "Single Responsibility Principle examples in C#"
- "Scale invariance in weighted scoring"

These helped validate mathematical correctness and architectural decisions.

---

## References That Influenced the Approach

Conceptual references included:

- Weighted Sum Model (Multi-Criteria Decision Analysis - MCDA)
- Basic normalization techniques
- Compensatory decision theory
- Separation of concerns and SRP (Single Responsibility Principle)

These references influenced the structure of the scoring engine and architectural separation.

---

## What I Accepted from AI

- Use of the weighted sum model for transparency.
- Mandatory weight normalization.
- Clear separation between scoring logic and explanation logic.
- Strict validation of missing scores.
- Contribution-based explanation rather than only final score output.

---

## What I Rejected from AI

- Using machine learning or AI-driven scoring logic.
- Combining explanation and scoring inside one class.
- Defaulting missing scores to zero.
- Mixing constraint logic into the weighted scoring engine.
- Overengineering the architecture for an MVP.

---

## What I Modified

- AI-generated evaluator code was reviewed and structured to align with my layered architecture.
- Explanation design evolved from simple ranking output to contribution-based breakdown.
- Initial hard-coded input was replaced with dynamic CLI input to satisfy the "non-static system" requirement.
- Constraint handling was discussed but intentionally deferred to avoid mixing compensatory and non-compensatory logic.

---

## Responsible Use of AI

AI was used for:

- Clarifying mathematical concepts such as normalization and compensatory behavior.
- Generating an initial implementation draft of the evaluator.
- Validating architectural trade-offs.
- Improving documentation clarity.

The generated code was manually reviewed, tested, and validated.

I ensured I understood:
- Why normalization is required.
- Why ranking remains unchanged after normalization.
- Why the model is compensatory.
- Why hard constraints are not supported in this version.

AI was used as a development assistant, not as a black-box decision system.