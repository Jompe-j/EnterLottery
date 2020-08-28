using System;

namespace EnterLottery {
    internal class Program {
        public static void Main(string[] args) {
            var numbers = GetNumbers();
        
        }
        private static Array GetNumbers() {
            var numbers = new int[36];
            for (int i = 0; i < numbers.Length; i++) {
                numbers[i] = i + 1;
            }

            return numbers;
        }
    }
}