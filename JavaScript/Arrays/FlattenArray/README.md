# Flatten an array without limit

This small script flatten array which contains other nested arrays to the new array without any nested arrays inside.

#### How to execute this script

To run this script please run command in your console ```node flatten.js```

#### Examples:

  1.
    - Input: [1, [2, [3]]]
    - Output: [1, 2, 3]

  2.
    - Input: [1, [2, 3, 4, [5, 6]]]
    - Output: [1, 2, 3, 4, 5, 6]

  3.
    - Input: [1, [2, [3], [4, [], [5, 6]], [], [7, 8]]]
    - Output: [1, 2, 3, 4, 5, 6, 7, 8]

#### Algorithm explanation:

  1. We pass an array into the method.
  2. First we check, if the passed array has any elements. If not then we return an empty array.
  3. Inside of the method we create an empty array, where we will be pushing elements of arrays.
  4. We iterate through the passed array. We check, whether each element has type of array.
    - If not, then we push element into array created in previous point.
    - If element is type of array then we use recursion. We repeat points 1-4 until there will be no more elements.
  5. We merge array created in point 2 with array returned by each recursion.
  6. At the end we return flattened array.


  # Flatten an array with limit

This small script flatten array which contains other nested arrays to the new array. User can limit level of flattening.

#### How to execute this script

To run this script please run command in your console ```node flatten.js```

#### Examples:

  1. Limit 0 - returns the same array
    - Input: [1, [2, [3, [4, [5, [6, [7, [8]]]]]]]]
    - Output: [1, [2, [3, [4, [5, [6, [7, [8]]]]]]]]

  2. Limit 1
    - Input: [1, [2, [3, [4, [5, [6, [7, [8]]]]]]]]
    - Output: [1, 2, [3, [4, [5, [6, [7, [8]]]]]]]

  3. Limit 2
    - Input: [1, [2, [3, [4, [5, [6, [7, [8]]]]]]]]
    - Output: [1, 2, 3, [4, [5, [6, [7, [8]]]]]]

  4. Limit 7
    - Input: [1, [2, [3, [4, [5, [6, [7, [8]]]]]]]]
    - Output: [1, 2, 3, 4, 5, 6, 7, 8]

#### Algorithm explanation:

  1. We pass 2 arguments to the method:
    - an array
    - limit of flattening
  2. First we check, if the passed array has any elements. If not then we return an empty array.
  3. Next we check, if we hit the limit of flattening. If so then we return passed array. If not then we continue.
  3. We create an empty array, where we will be pushing elements of arrays.
  4. We iterate through passed array. We check, whether each element is an array type.
    - If not, then we push element into array created in previous point.
    - If element is type of array then we use recursion. We repeat points 1-4 until there will be no more elements. We pass array (foreach element) and limit - 1 to the method.
  5. We merge array created in point 2 with array returned by each recursion.
  6. At the end we return flattened array.