# Aufgabe 01
## Erstes Programm

Dieses Projekt verfügt über einen ganz einfachen Programmaufbau, der erweitert werden soll. Zunächst muss überprüft werden, ob die Anwendung gestartet werden kann. Dazu kann in VS-Code unter dem `Debug`-Reiter die Anwendung gestartet werden. Alternativ kann in der Console ( CMD + J ) `dotnet run` eingegeben werden. In der Console sollte folgendes zu sehen sein:
```bash
Hello World!
Das Programm "[10434] app.dll" wurde mit dem Code 0 (0x0) beendet.

```

## Ein- und Ausgabe

In diesem "mini" Projekt erfolgt die Aus- und Eingabe nur über die Konsole.
Leider funktioniert die Eingabe in der Debug-Console von VS-Code nicht besonders gut, daher fokussieren sich die Aufgaben primär auf die Ausgabe.
Mit Hilfe der Klasse `Console` kann in der Console geschrieben werden. Die Methode `Console.WriteLine()` schreibt dabei den übergebenden Wert in die Console.
```C#
Console.WriteLine("Test 123");
```

**Aufgabe**

Es soll eine neue statische Methode innerhalb der Klasse Program erstellt werden.
In einer Consolenausgabe sollen folgende Information über Sie/Dich angegeben werden:
- Vorname
- Nachname
- Alter
- Aktuelles Datum

Die Methode soll anschließend in der `Main` Methode aufgerufen werden.

Beispiel:
```bash
Vorname: Max
Nachname: Mustermann
Alter: 23 Jahre
Datum: 20.11.2020
```

## Escape-Sequenzen

Escape Sequenzen sind Zeichenfolgen, die einem String übergeben werden können, um auf diese Weise die Konsolenausgabe zu formatieren. Folgende Sequenzen können benutzt werden: (Weitere sind ebenfalls möglich)
- \n Zeilenumbruch
- \t Tab-Stop (horizontal)
- \v Tab-Stop (vertikal)
- \"\ Sonderzeichen einfügen

**Beispiel**
```C#
var fullname = $"Max \tMustermann";
var fullname = $"{firstname} \t{lastname}";
```

<br>

**Aufgabe**

Die Klasse `Program` soll um eine weitere statische Methode erweitert werden. Der Methode soll eine Liste von `Driver` übergeben werden. Ziel ist es, die liste formattiert auszugeben. Zum Erzugen der Daten für die Liste kann die statische Methode `ToSampleList()` der Klasse `Driver` verwendet werden.

Ausgabe:
```bash
Max 	Mustermann
Max 	Mustermann
Max 	Mustermann
Max 	Mustermann
...
```