int numOfWays(int n) {
    const int MOD = 1000000007;
    long A = 6, B = 6;

    for (int i = 2; i <= n; i++) {
        long newA = (2 * A + 2 * B) % MOD;
        long newB = (2 * A + 3 * B) % MOD;
        A = newA;
        B = newB;
    }

    return (int)((A + B) % MOD);
}
