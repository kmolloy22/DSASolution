# Find Missing Number: Brute Force vs Sum Formula

## Problem
An array holds the numbers 1 to n in any order with exactly one number missing. Find the missing number.

## Examples
- `[1,2,4,5]` -> 3
- `[2,3,1,5]` -> 4
- `[1,2,3,4]` -> 5 (the largest is missing)
- `[2,3,4,5]` -> 1 (the smallest is missing)
- `[1]` -> 2
- `[2]` -> 1
- `[]` -> 1 (n is 1, and nothing is in the array)

## Assumptions
- The numbers are 1 to n with exactly one missing, and no duplicates.
- Order does not matter, so the array does not need to be sorted.
- The sum trick breaks if the input does not follow these rules (for example `[1,2,2,5]`).

## Approach 1: Sum formula (`FindMissingNumber`)
1. `n = nums.Length + 1`, because one number is missing.
2. `x` = sum of 1 to n, using `n * (n + 1) / 2` (pair the ends: each pair adds to n + 1, there are n pairs, counted twice so divide by 2).
3. `y` = sum of the numbers in the array (one loop).
4. Return `x - y`. Whatever is left over is the missing number.

## Approach 2: Brute force (`FindMissingNumberBruteForce`)
1. `highestNumber = nums.Length + 1`, because one number is missing.
2. Try each candidate from 1 to `nums.Length`.
3. For each candidate, search the whole array for it (inner loop).
4. If the search reaches the last item without a match, that candidate is missing, so return it.
5. If every candidate from 1 to `nums.Length` was found, only `highestNumber` can be missing, so return it.

- The match check must run **before** the "last item" check, or the last item is never compared.
- Step 5 also handles the empty array: the loops never run, and the answer is 1.
- Time is O(n²): a full search (inner loop) for each candidate (outer loop). Space is O(1).

## Complexity (sum formula)
- **Time:** O(n). The formula is O(1) but the loop over the array is O(n).
- **Space:** O(1). Only a few number variables.

## All approaches compared
| Approach | Idea | Time | Space |
|---|---|---|---|
| Brute force | For each 1 to n, search the array | O(n²) | O(1) |
| Sort | Sort, then find where a number is out of place | O(n log n) | O(1) |
| HashSet | Store all numbers, then check 1 to n for the one not stored | O(n) | O(n) |
| Sum formula | Expected sum - actual sum | O(n) | O(1) |

The sum formula is best in time and space, but only works while the input follows the rules.
Brute force is slow, but it gives a simple correct answer to test the faster version against.

## Lessons
- `n` is `length + 1`, not the largest value in the array (it fails when the largest number is the missing one).
- Test strange inputs: smallest array, missing largest, missing smallest.
- `n * (n + 1)` overflows `int` at about n = 46,341. Using `long` fixes it.
- A fallback `return -1` can hide a bug. The empty array is valid input, yet it reached the `-1`. Ask "when does this line run?" for every fallback.
- Passing tests only prove the cases you thought of. Add the case that caught a bug as a regression test.
- Restructure so an answer always exists (the highest number, by elimination) instead of returning a "not found" value.
- Write a slow, obviously correct version first, then compare the faster one against it.
