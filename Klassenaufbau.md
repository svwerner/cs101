## Klassenaufbau
Jede Klasse muss innerhalb eines `namespaces` angelegt werden. Der Namespace bestimmt darüber welche anderen Objekte innerhalt des Projektes zur Verfügung stehen.
Durch das Einbinden von anderen `namespaces` kann auf Klassen-Objekte zugegriffen werden, die außerhalb des `namespaces` liegen.
```C#
using System;
using System.Collections.Generic;
```

<br />

Diese Klasse stellt den exemplarischen Aufbau einer (üblichen) C# Klasse dar.
```C#
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
```

<br />

**Klassenattribute**
<br>
Klassenattribute sind spezielle Eigenschaften die einer Klasse zugewiesen werden können. Diese Attribute sind je nach Schutz-Grad nur innerhalb, außerhalb oder in vererbten Klassen verfügbar.
Der Aufbau erfolg dabei immer nach gleichem Schema: `Zugriffsattribut` - `Typ` - `Name` - `Getter+Setter`.

Der Zugriff kann über folgende Schlüssel gesetzt werden:
- **public**: Es kann von außerhalb auf dieses Attribut zugegriffen werden
- **protected**: Es kann nur innerhalb der Klasse und in vererbten Klassen zugegriffen werden
- **private**: Es kann nur innerhalt der eigenen Klasse zugegriffen werden.
- **static**: Ermöglicht den Zugriff ohne Instanzierung der Klasse

<br>

Es existieren weitere Schlüsselwörter um auch die Lese- und Schreibberechtigungen einzuschränken:
- **readonly**: Attribut darf nur gelesen werden
- **const**: Variable ist eine Konstante und nicht veränderbar

<br>

Klassenattribute können mit hilfe einer Get- und Set-Methode gesetzt und verwendet werden. Die Get- und Set-Methode kann überschrieben werden. Hier einige Beispiele für den automatischen `Getter` und `Setter`.
```C#
public string name { get; set; }
public string color { get; set; } = "red";
public int power { get; set; }
private Driver _driver { get; set; } = null;
```

Klassenattibute können zudem `nullable` sein wenn der Datentyp / Klasse nicht über die Zuweisung von `null` verfügt. Tip: Es lohnt sich immer attribute auf `null` zu überprüfen oder bereits im `Constructor` bzw. bei der `Deklarierung` zuzuweisen.
```C#
public double? acceleration { get; set; } = null;
```

<br>

**Klassenmethoden**

Methoden können ebenfalls Teil einer Klasse sein. Hier gilt ebenfalls das eben erklärte Prinzip der Zugriffsberechtigungen. 
Der Aufbau einer Methode erfolgt nach folgendem Schema: `Zugriffsattribut` - `Rückgabetyp` - `Methodenname` - `ggfs. Übergabeparametern`.
<br>
Hier einige Beispiele für Klassenmethoden:

```C#
public void PrintName() {
    Console.WriteLine($"Car name: {this.name}");
}

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
```

<br>

**Klassen-Constructor**

Der `Constructor` einer Klasse wird jedes Mal aufgerufen, sobald eine neue Instanz dieser Klasse erzeugt wird. Der `Constructor` muss nicht zwingend deklariert werden, es macht aber grundsätzlich Sinn dies zu tun.
Es sind zudem verschiedene `Constructor` Methoden möglich. Hier muss der/(die) Übergabeparameter variieren. 