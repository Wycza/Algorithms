const script = require('../src/findmin');

describe('FindMin script', () => {
  it('should return minimal value from array', () => {
    let arr = [1, 3, 5, 8, 10];
    let min = script.FindMin(arr);
    expect(min).toBe(1);
  });

  it('should return null if array is empty', () => {
    let arr = [];
    let max = script.FindMin(arr);
    expect(max).toBe(null);
  });

  it('should return null if argument is not an array', () => {
    let arr = 'test';
    let max = script.FindMin(arr);
    expect(max).toBe(null);
  });
})