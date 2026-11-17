# Remove Duplicates: Manual Loop vs LINQ

## Problem
Given an array, return a new array with the duplicate values removed.

## Example
- Input: `[3, 1, 3, 2, 1]` -> Output: `[3, 1, 2]`

## Approach 1: Manual loop (`RemoveDups`)
1. Create an empty `List<object>` named `tempList`.
2. Go through the array one item at a time.
3. If `tempList` does not already contain the item, add it.
4. Convert `tempList` to an array and return it.

- `Contains` scans the list from the start until it finds a match, so each check can look at every item added so far.
- The original order is kept, because items are added in the order they first appear.

## Approach 2: LINQ (`RemoveDupsWithLinq`)
- `items.Distinct().ToArray()` does the same job in one line.
- `Distinct()` keeps a hash-based set of items it has already seen, so each "have I seen this?" check is one step instead of a scan (the same idea as `HashSet` in Has Duplicate).
- In practice it returns items in first-appearance order, but the documentation does not promise an order. If order matters, do not rely on it.

## Complexity
| Approach | Time | Space | Why |
|---|---|---|---|
| Manual loop | O(n²) | O(n) | `Contains` is O(n) and runs once per item |
| LINQ `Distinct()` | O(n) average | O(n) | Hash lookup is about O(1) per item |

- Both need extra space for the result (and for the set in `Distinct()`).
- With n = 1,000 items and few duplicates, the manual version does up to about 500,000 comparisons. `Distinct()` does about 1,000 lookups.

## Which is better, and why?
- **LINQ** for real code: shorter, clearer, and faster on large arrays.
- The **manual loop** is useful for learning what the work actually is, and it is fine for small arrays.
- A faster manual version uses a `HashSet<object>`: `if (seen.Add(item)) result.Add(item);`.

## About `object[]`
- Using `object[]` lets the methods accept any type, but value types such as `int` are boxed (wrapped as objects), which costs time and memory.
- The caller loses type safety and has to cast values back (for example `(int)result[0]`).
- A generic version, `T[] RemoveDups<T>(T[] items)`, avoids both problems.

## Lessons
- Spot repeated work: `Contains` on a list rescans it every time.
- A hash-based lookup turns an O(n²) approach into O(n).
- Check whether an operation promises to keep order before depending on it.
