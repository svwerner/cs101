## Einfache Datentypen

- int
- double
- float
- char
- bool
- byte

Zu den einfachen Datentypen zählt man unter C# die oben aufgeführten Typen. Hierbei wurden die Varianten der Typen ausgelassen (unsigned etc).
Der Datentyp `string` finded sich hier nicht wieder, da es sich hierbei im weiteren Sinne um einen Klassentypen handelt, der wie eine Variable und Datentyp verwendet werden kann. Hierzu muss aber keine zusätzliche Bibliothek eingebunden werden.

**Deklarieren und Zuweisen**

Eine Variable wird immer nach gleichem Schema deklariert: `typ` - `name`.
Es ist zudem möglich mithilfe des `var` Keywords Variablen anzulegen. Hierbei ergibt sich der Datentyp aus der Zuweisung.
```C#
// Beides vom typ int
int test1 = 0;
var test2 = 0;
```