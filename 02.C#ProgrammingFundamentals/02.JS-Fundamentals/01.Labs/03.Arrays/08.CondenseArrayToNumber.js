function condenseArrayToNumber(nums) {
    let sum = 0;
    while (true) {
        if (nums.length == 1) {
            console.log(nums[0]);
            break;
        }
        sum = 0;
        let condensed = [];
        for (i = 1; i < nums.length; i++) {
            condensed[i - 1] = nums[i - 1] + nums[i];
        }
        for (i = 0; i < condensed.length; i++) {
            sum += condensed[i];
        }
        nums = condensed;
        if (condensed.length == 1) {
            console.log(sum);
            break;
        }
    }
}
