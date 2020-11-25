# C# 101

## Grundlagen
Bei C# handelt es sich um eine **objektorientierte** Programmiersprache.
Der Einstigespunkt einer C# Anwendung ist somit die Klasse Program in `Program.cs`;

```C#
using System;

namespace app {
    
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Hello World!");
        }
    }
}
```

## Was sind Klassen?

Klassen sind komplexe Strukturen / Objekte diese über Attribute und Methoden verfügen. Eine zentrale Funktionsweise bei Klassen ist die Vererbung. Hierbei können Eigenschaften der Basis-Klasse vererbt werden und in der erbenden Klassen verfügbar gemacht werden. Neben Klassen gibt es auch andere Objekttypen, wie `Interface types`, `Arrays types`, oder `Delegate types`.

<br>

**Klasseninstanz erzeugen**

Eine neue Klasseninstanz wird mithilfe des `new` Keywords erzeugt. Bei diesem Prozess wird im Hintergrung Arbeitsspeicher für dieses Objekt reserviert.
Anders als in Programmiersprachen wie `C++` muss sich der Programmierer hier nicht aktiv um das allokieren und disallokieren von Arbeitsspeicher bemühen. Der sogenannte `GarbageCollector` übernimmt diese Augabe und kann bei Bedarf auch manuell gestartet werden. 
```C#
var car1 = new Car();
```