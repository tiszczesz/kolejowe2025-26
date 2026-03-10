export const nwdCalc = (a: number, b: number): number => {
    let temp = b;
    while (b > 0) {
        temp = b;
        b = a % b;
        a = temp;
    }
    return a;
};
//NWD (a,b) -> 