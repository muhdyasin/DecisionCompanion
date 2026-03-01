# Build Process

## How I Started

At the beginning, I considered building a web-based decision tool with a UI.

After reviewing the assignment requirements more carefully, I realized that the evaluation focuses more on clarity of thinking, system design, and explainability rather than UI complexity.

So I decided to start by building a clean and well-structured core decision engine using a CLI interface. The priority became correctness, transparency, and architecture rather than feature count.

---

## How My Thinking Evolved

Initially, I understood the weighted sum formula only at a surface level.

While implementing it, I realized I needed to deeply understand:

- Why weight normalization is necessary  
- Whether normalization affects ranking  
- What compensatory trade-offs mean  
- How extreme weights influence outcomes  

By testing different inputs, I observed:

- Normalization changes score scale but not ranking  
- Extreme weights cause one criterion to dominate  
- The model allows trade-offs between criteria  

This changed how I viewed the system. I began treating it as a formal decision model rather than just a scoring formula.

---

## Alternative Approaches Considered

I explored several alternative approaches:

1. Machine learning-based ranking  
   Rejected because it introduces opacity and conflicts with the requirement that logic must be explainable.

2. Constraint-based filtering (hard thresholds)  
   Rejected for the MVP because it introduces a non-compensatory decision mechanism and increases complexity.

3. More advanced multi-criteria decision models  
   Rejected due to scope and the goal of keeping the solution focused and explainable.

I chose the weighted sum model because it is deterministic, transparent, and suitable for a minimal but solid implementation.

---

## Refactoring Decisions

Initially, I considered placing explanation logic inside the evaluator.

After reconsidering separation of concerns principles, I refactored the design:

- WeightedDecisionEvaluator handles only scoring logic.
- ExplanationService handles interpretation of results.
- Program.cs handles user input and orchestration only.

This separation improved clarity, maintainability, and testability.

---

## Mistakes and Corrections

1. I initially hard-coded sample input in Program.cs.  
   This violated the requirement that the system must not be static.  
   I corrected this by implementing interactive CLI input.

2. I underestimated the importance of normalization.  
   After testing different weight scales (e.g., 1 & 1 vs 100 & 100), I realized normalization is required to maintain scale invariance.

3. I originally treated tie handling as a simple ranking case.  
   Later, I improved it to display contribution breakdown so ties are properly explained.

---

## What Changed During Development and Why

- Input handling changed from hard-coded values to dynamic CLI input to satisfy the requirement of user-driven decision changes.

- Architecture evolved to clearly separate scoring logic and explanation logic.

- My understanding of compensatory decision behavior improved through testing and iteration.

- Hard constraint handling was intentionally deferred to keep the MVP focused on one consistent decision paradigm.

---

## Final Trade-offs

I intentionally did not implement:

- Hard constraints  
- Persistence  
- UI layer  
- Advanced multi-criteria decision methods  

The focus was on building a clean, explainable, and well-structured MVP that clearly demonstrates decision modeling and architectural clarity.