const script = require('../src/findmax');

describe('FindMax script', () => {
  it('should return largest value from an array', () => {
    let arr = [1, 3, 5, 8, 10];
    let max = script.FindMax(arr);
    expect(max).toBe(10);
  });

  it('should return null if array is empty', () => {
    let arr = [];
    let max = script.FindMax(arr);
    expect(max).toBe(null);
  });

  it('should return null if argument is not an array', () => {
    let arr = 'test';
    let max = script.FindMax(arr);
    expect(max).toBe(null);
  });
})
