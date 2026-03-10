export const nwdColc = (a: number, b: number): number => {
    let temp = a;
    while (b > 0) {
        temp = a;
        a = a % b;
        b = temp;
    }
    return a;
};