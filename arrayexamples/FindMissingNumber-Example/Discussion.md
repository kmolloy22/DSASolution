# Find Missing Number: Sum Formula

## Problem
An array holds the numbers 1 to n in any order with exactly one number missing. Find the missing number.

## Examples
- `[1,2,4,5]` -> 3
- `[2,3,1,5]` -> 4
- `[1,2,3,4]` -> 5 (the largest is missing)
- `[2,3,4,5]` -> 1 (the smallest is missing)
- `[1]` -> 2

## Assumptions
- The numbers are 1 to n with exactly one missing, and no duplicates.
- Order does not matter, so the array does not need to be sorted.
- The sum trick breaks if the input does not follow these rules (for example `[1,2,2,5]`).

## Approach
1. `n = nums.Length + 1`, because one number is missing.
2. `x` = sum of 1 to n, using `n * (n + 1) / 2` (pair the ends: each pair adds to n + 1, there are n pairs, counted twice so divide by 2).
3. `y` = sum of the numbers in the array (one loop).
4. Return `x - y`. Whatever is left over is the missing number.

## Complexity
- **Time:** O(n). The formula is O(1) but the loop over the array is O(n).
- **Space:** O(1). Only a few number variables.

## Other approaches
| Approach | Time | Space |
|---|---|---|
| Sort, then find the gap | O(n log n) | O(1) |
| HashSet of numbers seen | O(n) | O(n) |
| Sum formula (this solution) | O(n) | O(1) |

## Lessons
- `n` is `length + 1`, not the largest value in the array (it fails when the largest number is the missing one).
- Test strange inputs: smallest array, missing largest, missing smallest.
- `n * (n + 1)` overflows `int` at about n = 46,341. Using `long` fixes it.
