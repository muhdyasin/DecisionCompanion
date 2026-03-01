# Decision Companion System

## Overview

This project is a CLI-based Decision Companion System that helps users evaluate multiple options using weighted criteria.

The goal is to provide a transparent and explainable decision-making system without relying on black-box AI logic.

The system:
- Accepts multiple options
- Accepts criteria with weights
- Normalizes weights
- Computes weighted scores
- Ranks options
- Explains the ranking

---

## Problem Understanding

The core requirement is to help users compare options based on multiple criteria where each criterion can have different importance.

The system must:
- Be dynamic (not hard-coded comparisons)
- Be explainable
- Not rely entirely on AI
- Allow different inputs to produce different outcomes

I chose to focus on building a clean and correct core evaluation engine rather than adding UI or persistence.

---

## Design Decisions

### 1. CLI Application

I chose a CLI-based implementation to keep the focus on the decision logic rather than frontend complexity.

The CLI is sufficient to demonstrate:
- Evaluation logic
- Ranking
- Explanation generation

---

### 2. Weighted Sum Model

The system uses a weighted sum model:

FinalScore = Σ (NormalizedWeight × Score)

This model was chosen because:
- It is deterministic
- It is easy to explain
- It supports trade-offs between criteria
- It fits well for an MVP

---

### 3. Weight Normalization

Weights are normalized so that their total equals 1.

This ensures:
- The final score remains within the original scoring scale
- Results are predictable and comparable
- Different numeric weight scales (e.g., 1 & 1 vs 100 & 100) behave consistently

---

### 4. Separation of Responsibilities

The architecture separates concerns into:

- Domain layer (models)
- Application layer (evaluation + explanation)
- Presentation layer (CLI)

The scoring logic and explanation logic are separated to keep the evaluator focused only on calculations.

---

### 5. AI Usage

AI is not used in the decision calculation.

The scoring logic is fully deterministic.

AI may optionally be used to improve explanation wording, but it does not affect rankings.

---

## Assumptions

- Users provide numeric scores for all criteria
- All options contain scores for all criteria
- Criteria are independent
- Trade-offs between criteria are allowed

---

## Limitations

- No hard constraints (e.g., minimum thresholds)
- Linear trade-offs only
- No persistence
- No UI
- No sensitivity analysis

Hard constraints can be added in a future iteration as a preprocessing step.

---

## Edge Cases Handled

- Empty criteria list → validation error
- Empty options list → validation error
- Missing score for a criterion → validation error
- Total weight equals zero → validation error
- Equal final scores → marked as tie with explanation

---

## How to Run

dotnet run

(Adjust command if needed based on project structure.)

---

## Future Improvements

- Add support for hard constraints
- Add sensitivity analysis
- Add a web interface
- Add persistence
- Support alternative decision models