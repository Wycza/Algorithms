function FindMax(arr) {
  if (arr.length < 1 || !Array.isArray(arr)) {
    return null;
  }

  let max = Number.MIN_VALUE;

  arr.forEach(el => {
    if (el > max) {
      max = el;
    }
  })

  return max;
}

module.exports = {
  FindMax
};