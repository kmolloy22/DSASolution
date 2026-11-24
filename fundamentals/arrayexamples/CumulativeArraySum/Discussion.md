# Cumulative Array Sum: Running Total

## Problem
Given an array of numbers, return a new array where each item is the sum of all the numbers up to and including that position.

## Examples
- `[1, 2, 3]` -> `[1, 3, 6]`
- `[1, -2, 3]` -> `[1, -1, 2]`
- `[]` -> `[]` (nothing to add up)

## Approach
1. Keep one variable, `sum`, starting at 0.
2. Go through the array in order.
3. For each number, add it to `sum`, and put the new `sum` in the result.
4. Return the result.

Key idea: each answer is the **previous answer plus the current number**, so there is no need to add the whole prefix again each time.

## Code idea
`array.Select(num => sum += num).ToArray()`

- `Select` turns each input item into an output item, in order.
- `sum += num` updates the running total and also gives back the new total, so it is both the update and the output.

## Complexity
| Approach | Time | Space | Why |
|---|---|---|---|
| Running total (this solution) | O(n) | O(n) | One pass, one new array |
| Re-add from the start for each position | O(n^2) | O(n) | Repeats work already done |

- The new array is needed because the result is a different array from the input.

## Things to watch
- `Select` with a changing variable works here only because `ToArray()` runs it once. If the sequence were enumerated twice, `sum` would keep growing and the second pass would give wrong totals.
- The values are `double`, so very large sums or many decimals can pick up tiny rounding errors. The tests use whole numbers, which are exact.
- The empty array works with no special case, because the loop never runs.

## Lessons
- Reuse the previous result instead of recalculating (a "running total" or "prefix sum").
- A lambda that changes an outside variable is short, but harder to read and easier to break than a plain `for` loop.
- The tests use `Is.EquivalentTo`, which ignores order. `Is.EqualTo` also checks the order, so it is a stronger check for results like these.
