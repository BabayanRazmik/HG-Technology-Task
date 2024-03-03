# FizzBuzz Service

This service takes a list of numbers as input and returns the same list with corresponding replacements according to specific rules. It is designed and implemented in C#.

## Task 1
- If a number is divisible by 3, replace it with "fizz".
- If a number is divisible by 5, replace it with "buzz".
- If a number is divisible by both 3 and 5, replace it with "fizz-buzz".

Example:
- Input: 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15
- Output: 1, 2, fizz, 4, buzz, fizz, 7, 8, fizz, buzz, 11, fizz, 13, 14, fizz-buzz

## Task 2
Building upon Task 1:
- If a number is divisible by 4, replace it with "muzz".
- If a number is divisible by 7, replace it with "guzz".
- If a number is divisible by both 4 and 7, replace it with "muzz-guzz".
- Apply similar behavior for all combinations of divisibility.

Example:
- Input: 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 60, 105, 420
- Output: 1, 2, fizz, muzz, buzz, fizz, guzz, muzz, fizz, buzz, 11, fizz-muzz, 13, guzz, fizz-buzz, fizz-buzz-muzz, fizz-buzz-guzz, fizz-buzz-muzz-guzz

## Task 3
Modifying behavior for divisibility by 3 and 5:
- If a number is divisible by 3, replace it with "dog".
- If a number is divisible by 5, replace it with "cat".
- If a number is divisible by both 3 and 5, replace it with "good-boy".
- When divisible by 3 and 5, "good-boy" should precede other replacements.

Example:
- Input: 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 60, 105, 420
- Output: 1, 2, dog, muzz, cat, dog, guzz, muzz, dog, cat, 11, fizz-muzz, 13, guzz, good-boy, good-boy-muzz, good-boy-guzz, good-boy-muzz-guzz

## Task 4 (Additional)
Adding user flexibility:
- Allow users to choose the divisor and the replacement word.
- Implement the functionality to replace numbers divisible by the chosen divisor with the chosen word.

Example:
- User chooses divisors 2, 6 and replacement word "even" and "tmp".
- Input: 1, 2, 3, 4, 5, 6, 7, 8, 9, 10
- Output: 1, even, 3, even, 5, even-tmp, 7, even, 9, even
