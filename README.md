# Unexpected behavior when swapping mutable lists in F# 

This repository demonstrates an uncommon bug in F# related to swapping mutable lists. When attempting to swap two mutable lists using a seemingly straightforward approach, the result is not as expected. The second list gets updated correctly, but the first list is also modified to reflect the original value of the second list.

## Bug Description
The provided code shows an example of swapping mutable lists in F#. When the `swapList` function is called, the expectation is that list `a` will contain the original values of list `b`, and vice-versa. However, after the swap, both lists will have the value of list `b`.

## Code Sample
The `bug.fs` file contains the code that reproduces the bug.

## Solution
The `bugSolution.fs` file presents a corrected approach to swapping mutable lists, ensuring the intended behavior is achieved.

## How to Reproduce
1. Clone this repository.
2. Open `bug.fs` in an F# compiler.
3. Run the code. Observe the unexpected output.
4. Open `bugSolution.fs` and observe the corrected implementation.
5. Run the corrected code and observe the expected output.