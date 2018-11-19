function FindMin(arr) {
  if (arr.length < 1 || !Array.isArray(arr)) {
    return null
  }
  let min = Number.MAX_VALUE;

  arr.forEach(el => {
    if (el < min) {
      min = el;
    }
  })

  return min;
}

module.exports = {
  FindMin
};