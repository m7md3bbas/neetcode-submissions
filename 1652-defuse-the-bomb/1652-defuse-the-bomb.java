class Solution {
    public int[] decrypt(int[] code, int k) {
        int n = code.length;
        int[] result = new int[n];
        if (k == 0)
            return result;

        int left = k > 0 ? 1 : n + k;
        int right = k > 0 ? k : n - 1;

        int windowSum = 0;
        for (int idx = left; idx <= right; idx++) {
            windowSum += code[idx];
        }

        for (int i = 0; i < n; i++) {
            result[i] = windowSum;
            windowSum -= code[left % n];
            left++;
            right++;
            windowSum += code[right % n];
        }

        return result;

    }
}