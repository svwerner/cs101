using System;
using System.Collections.Generic;

namespace app {

    public class Car {

        public int id { get; set; }
        public string name { get; set; }
        public string color { get; set; } = "red";
        public int power { get; set; }
        public double? acceleration { get; set; } = null;
        private Driver _driver { get; set; } = null;


        public Car() { }

        public Car(Driver new_driver) {
            // Constructor with comment
            this._driver = new_driver;
        }


        public void PrintName() {
            Console.WriteLine($"Car name: {this.name}");
        }

        public Driver GetDriver() {
            return this._driver != null ? this._driver : new Driver();
        }


        /// <summary>
        /// Generates a list of car items
        /// </summary>
        /// <param name="length">Anzahl der Elemente</param>
        /// <returns>Car[]</returns>        
        public static List<Car> GenerateList(int length) {
            var cars = new List<Car>();

            for (var i = 0; i < length; i++) {

                var driver = new Driver() {
                    firstname = "Max",
                    lastname = "Mustermann"
                };

                cars.Add(new Car(driver) { id = i });
            }

            return cars;
        }
    }
}