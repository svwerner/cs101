using System;

namespace app {
    
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Hello World!");
            Aufgabe02();
        }



        private static void Aufgabe02() {

            var a = 30;

            for (var i = 1; i < a; i++) {
                var mod = a % i;

                if (mod == 0) {
                    Console.WriteLine($"{i} / {a} kann geteilt werden.");
                }
            }
        }
    }
}
