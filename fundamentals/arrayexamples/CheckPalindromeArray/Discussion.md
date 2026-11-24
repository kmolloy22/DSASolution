# Check Palindrome Array: Two Pointers

## Problem
Return `true` if an integer array reads the same forwards and backwards.

## Examples
- `[1,2,3,2,1]` -> true
- `[1,2,2,1]` -> true
- `[1,2,3]` -> false
- `[7]` -> true
- `[]` -> true (no pair can break the rule)

## Approach
1. Put `left` at index 0 and `right` at the last index (`Length - 1`).
2. While `left < right`: if the two values differ, return `false`.
3. Move `left` up by 1 and `right` down by 1.
4. If the loop ends with no mismatch, return `true`.

Stopping rule: `left >= right` (they meet in odd lengths, cross in even lengths).
The empty array works with no special case: `right = -1`, so the loop never runs.

## Complexity
- **Time:** O(n). About n/2 comparisons, and the constant is dropped.
- **Space:** O(1). Only two integer indexes.

## Other approaches
| Approach | Time | Space |
|---|---|---|
| Reverse into a copy and compare | O(n) | O(n) |
| Two pointers (this solution) | O(n) | O(1) |

