function flatten(arr) {
  if (arr.length < 1) {
    return [];
  }

  let newArray = [];
  arr.forEach(el => {
    if (!Array.isArray(el)) {
      newArray.push(el);
    } else {
      newArray = [...newArray, ...flatten(el)];
    }
  });

  return newArray;
}

function flattenLimit(arr, i) {
  if (arr.length < 1) {
    return [];
  }
  if (i <= 0) {
    return arr;
  }

  let newArray = [];
  arr.forEach((el) => {
    if (!Array.isArray(el)) {
      newArray.push(el);
    } else {
      newArray = [...newArray, ...flattenLimit(el, i - 1)];
    }
  })

  return newArray;
}

const arr1 = [1, [2, [3]]];
const arr2 = [1, [2, 3, 4, [5, 6]]];
const arr3 = [1, [2, [3], [4, [], [5, 6]], [], [7, 8]]];
console.log('Flatten an array without limit: ');
console.log(flatten(arr1));
console.log(flatten(arr2));
console.log(flatten(arr3));

const arr4 = [1, [2, [3, [4, [5, [6, [7, [8]]]]]]]];
console.log('\nFlatten an array with limit: ')
console.log('Limit 0:', flattenLimit(arr4, 0));
console.log('Limit 1:', flattenLimit(arr4, 1));
console.log('Limit 2:', flattenLimit(arr4, 2));
console.log('Limit 3:', flattenLimit(arr4, 3));
console.log('Limit 4:', flattenLimit(arr4, 4));
console.log('Limit 5:', flattenLimit(arr4, 5));
console.log('Limit 6:', flattenLimit(arr4, 6));
console.log('Limit 7:', flattenLimit(arr4, 7));


