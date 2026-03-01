# Research Log

## AI Prompts Used

- How to design a weighted decision engine
- Explanation of weight normalization
- Why normalization matters
- Understanding compensatory decision models
- Difference between scoring models and constraint models
- How to handle ties in weighted scoring
- How to structure evaluator and explanation services

---

## What I Accepted

- Weighted sum model
- Weight normalization requirement
- Separation between evaluator and explanation logic
- Strict validation policy
- Contribution-based explanation for ties

---

## What I Rejected

- ML-based ranking
- AI-driven scoring
- Defaulting missing scores to zero
- Mixing explanation inside evaluator
- Implementing partial constraint logic

---

## What Was Modified

- Explanation design evolved from simple output to contribution-based explanation.
- Architecture was refined to separate responsibilities more clearly.
- Constraint handling was deferred instead of partially implemented.