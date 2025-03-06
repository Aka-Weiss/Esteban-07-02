using System;

class URI {
    static void Main(string[] args) {
        int valorJ = 7;

        for (int i = 1; i < 10; i += 2) {
            for (int j = valorJ; j > valorJ - 3; --j) {
                Console.WriteLine($"I={i} J={j}");
            }
            valorJ += 2;
        }
    }
}
