using System;
using System.Collections.Generic;

namespace app  {

    public class Driver {

        public string firstname { get; set; }
        public string lastname { get; set; }


        public Driver() { }


        public static List<Driver> ToSampleList(int items) {
            var drivers = new List<Driver>();

            for (var i = 0; i < items; i++) {
                drivers.Add(new Driver() { firstname = "Max", lastname = "Mustermann" });
            }

            return drivers;
        }
    }
}