## Kontrollstrukturen und Schleifen

<br>
<br>

**If / Else**

Dies ist die Einfachste Kontrollstruktur die anhand eines boolschen Operators über die Ausführung eines Codeabschnittes bestimmt. Der Auszuführende Code steht dabei nach der Kontrollstruktur, oder eingeklammert unterhalb.
```C#
var name = "Max";

if (name == "Max") Console.WriteLine($"Hello: {name}");
else {
    Console.WriteLine($"Name invalid: {name}");
}


if (name != "Max") {
    Console.WriteLine($"Name invalid: {name}");
}
else if (name == "max") {
    Console.WriteLine($"Hello: {name}");
}
else {
    Console.WriteLine($"Hello other name: {name}");
}
```

<br>

**Vergleichsoperatoren**

Mit Hilfe der Vergleichsoperatoren können innerhalb einer Kontrollstruktur Bedingungen überpürft werden. (Oder auch Boolsche Operatoren genannt, da nur True / False)
Alle Vergleichsoperatoren können zudem verkettet werden.
```C#
// Ist gleich ==
// Ist ungleich !=
// Ist nicht (oder negiert) !
// Größer als >
// Kleiner als <
// Größer gleich >=
// Kleiner gleich <=
// Oder ||

if (name == "max" || name == "Max") ...
if (age >= 10 && height == 130) ..
if (!user.isOld()) ..
```

<br>

**Switch**

Über den `switch` können unterschiedliche `cases` abgefragt werden. Die Funktionsweise ist änhlich einer `If/Else` Struktur, jedoch gibt es hier auch eine Durchfall-Logik. Das `break` Keyword bricht die aktive Scheife ab.
```C#
switch (name) {
    case "max":
        ..
        break;

    case "tim":
        ..
        break;

    default:
        ..
        break;
}
```

<br>

**For-Loop**

In einer `for` Schleife wird über eine bestimmte Anzahl iterriert. Mit dem Inkrement-Operator `++` oder `--` kann eine ganzzahlige Variable inkrementiert oder verringert werden. Hierbei kommt es auf die Platzierung des Operators vor oder nach der Variable an, ob diese erst erhöht wird oder erst nachträglich.
```C#
for (var i = 0; i < 100; i++) {
    ..
}
```

<br>

**While-Loop**

Eine `while` - Schleife wird so lange ausgeführt, bis die Bedingung der Schleife erreicht wurde.
```C#
var running = true;

while (running) {
    ..
}

do {
    ..
}
while (running)
```

<br>

**Foreach**

Die `foreach` Schleife erlaubt das Iterieren über eine Liste von Objekten. Die Schleife läuft dabei jedes Element der List / Arrays durch.
```C#
foreach(var item in sample_list) {
    Console.WriteLine($"{item.firstname}");
}
```