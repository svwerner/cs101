# Aufgabe 02
## Modulo-Operator

Der Moduko-Operator liefert den rest einer Integer Division. So ist die Zahl 25 nur mit einem Rest von 4 duch 7 teilbar.

**Beispiel**
```C#
var a  = 25;
var b = 12;
var c;

c = b % a;
```

**Aufgabe**

Es soll eine Methode erstellt werden, in dieser die Zahl 30 (40, 55, 70) durch die selbige Anzahl von Iterationen geteilt werden soll. Z.B 30 / 1 => 30 / 2 usw.
Hierbei sollen nur die Teiler ausgegeben werden, bei denen eine glatte Teilsummme möglich ist. Die Ausgabe könnte wie folgt aussehen:
```bash
1 / 30 kann geteilt werden.
2 / 30 kann geteilt werden.
3 / 30 kann geteilt werden.
5 / 30 kann geteilt werden.
6 / 30 kann geteilt werden.
10 / 30 kann geteilt werden.
15 / 30 kann geteilt werden.
```