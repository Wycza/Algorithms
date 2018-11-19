function FizzBuzz(arr) {
  if (arr.length < 1) {
    return;
  }

  arr.forEach(el => {
    if (el % 15 == 0) {
      console.log(`${el} - FizzBuzz`);
    } else if (el % 3 == 0) {
      console.log(`${el} - Fizz`);
    } else if (el % 5 == 0) {
      console.log(`${el} - Buzz`);
    } else {
      console.log(el);
    }
  })
}

FizzBuzz([1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15]);
