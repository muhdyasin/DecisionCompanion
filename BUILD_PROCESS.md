# Build Process

## Initial Approach

I started by thinking about building a web-based decision tool.

After evaluating the scope, I decided to focus on building a clean and well-structured core evaluation engine first.

The goal became clarity and correctness rather than feature count.

---

## Model Selection

I explored different approaches such as:
- Machine learning-based ranking
- Constraint-based filtering
- More advanced multi-criteria models

I chose the weighted sum model because:
- It is simple and transparent
- It is deterministic
- It is easy to explain
- It fits the assignment requirements

---

## Understanding the Mathematics

While implementing the model, I spent time understanding:
- Weight normalization
- Why normalization matters
- Compensatory trade-offs
- How extreme weights affect outcomes

This helped shape:
- The normalization step
- Tie handling logic
- Explanation design

---

## Architectural Decisions

Initially, I considered putting explanation logic inside the evaluator.

I refactored it into a separate ExplanationService to:
- Maintain single responsibility
- Keep calculation logic pure
- Improve clarity and testability

I also decided that Program.cs should only orchestrate calls and not contain business logic.

---

## Validation Strategy

I chose strict validation:
- Missing scores cause an error
- Zero total weight causes an error

This avoids silent distortions in scoring.

---

## Tie Handling

If two options receive the same final score, they are marked as tied.

The explanation compares their criterion-level contributions to show how different trade-offs resulted in equal scores.

---

## Trade-offs

I intentionally did not implement:
- Hard constraints
- Persistence
- UI layer
- Advanced MCDM methods

The focus was a clean and explainable MVP.