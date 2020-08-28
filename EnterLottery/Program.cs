using System;

namespace EnterLottery {
    internal class Program {
        public static void Main(string[] args) {
            var rnd = new Random();

            ConsoleKey input;
            do {
                Console.WriteLine($"Tryckerenter för en lottorad");

                input = Console.ReadKey().Key;
                if (input == ConsoleKey.Enter) {
                    PrintRow(LotteryRow(rnd));
                }
            } while (input == ConsoleKey.Enter);
        }

        private static void PrintRow(Array lotteryRow) {
            foreach (var i in lotteryRow) {
                Console.Write($"{i}, ");
            }
        }

        private static Array LotteryRow(Random rnd) {
            var row = new int[7];
            var i = 0;
            do {
                var newNumber = rnd.Next(0, 36);
                if (IsNew(row, newNumber)) {
                    row[i] = newNumber;
                    i++;
                }
            } while (i < 7);
            Array.Sort(row);
            return row;
        }

        private static bool IsNew(int[] row, int newNumber) {
            foreach (var i in row) {
                if (i == newNumber) {
                    return false;
                }
            }

            return true;
        }
    }
}