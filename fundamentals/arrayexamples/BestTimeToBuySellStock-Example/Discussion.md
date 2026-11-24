# Best Time to Buy and Sell Stock: Brute Force vs Optimized Approach

## Explanation

You are given an array `prices` where `prices[i]` is the stock price on day `i`.

You want to maximize profit by choosing:

- one day to buy, and
- a different future day to sell.

Return the maximum profit possible. If no profit can be made, return `0`.

## Example 1

- **Input:** `prices = [7,1,5,3,6,4]`
- **Output:** `5`
- **Explanation:** Buy on day 2 (price = 1) and sell on day 5 (price = 6), so profit = `6 - 1 = 5`.

> Buying after selling is not allowed.

## Comparison — Brute Force vs Optimized Approach

| Approach | Core Idea | Time | Space | Notes |
|---|---|---:|---:|---|
| Brute Force | Check every pair `(i, j)` with `j > i` | `O(n^2)` | `O(1)` | Straightforward, but slow for large arrays |
| Optimized (Greedy) | Track minimum price so far and compute profit at each day | `O(n)` | `O(1)` | Best practical solution |

## Brute-Force Idea

This is a common greedy-style array problem.

### Step 1 — Clarify

Confirm:

- Only one transaction is allowed (one buy, one sell).
- You must buy before you sell.

### Step 2 — Brute Force

Check every pair `(i, j)` where `j > i`, and compute `prices[j] - prices[i]`.

- **Time complexity:** `O(n^2)`
- **Space complexity:** `O(1)`
- Not efficient for large input.

### Step 3 — Key Insight

At each day, the best possible profit depends on:

- the minimum price seen so far, and
- the current price as a potential sell price.

So instead of comparing all pairs, track the minimum price while scanning once.

### Step 4 — Optimized Approach

Iterate through the array once:

1. Update the minimum price seen so far.
2. Compute profit if selling today: `currentPrice - minPrice`.
3. Update maximum profit if this is larger.

- **Time complexity:** `O(n)`
- **Space complexity:** `O(1)`

## Pattern Recognition

This problem fits:

- Greedy optimization
- Implicit one-pass state tracking

Common signals:

- “maximize profit”
- “single transaction”
- “one-pass solution”
- “track min/max dynamically”

## Senior-Level Insight

This works because the best sell decision at any index depends only on the minimum earlier price.  
No earlier element needs to be revisited.
```