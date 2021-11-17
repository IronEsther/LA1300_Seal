# Einführung

Meine Gruppe (Seal) hat das Projekt gewählt, einen Vokabel-Trainer zu programmieren. 
In dieser Gruppenarbeit mussten wir ein Vokabelabfrageystem in `C#` programmieren, der den Benutzer die schon programmierten Vokabeln abfragt.


#Ziele

  1. Der Leser weiss, wofür `while` nützlich ist und wie man es einsetzt
  2. Der Leser weiss, wie man mit der `while`-Schleife den Benutzer dazu bringt, eine richtige Eingabe zu schreiben (und ihn auch vielleicht damit nerven zu können).

Vorteil von `while`:

Mit `do``while` wiederholt sich das Programm immer wieder, bis der Benutzer die richtige Eingabe eingegeben hat.

Für was benutzt man `while`?

Mit `while`...
  - ...wird das Programm so viel mal wiederholt, bis irgendetwas (wie z.B. die Benutzereingabe) es endet.

Ein Beispiel für die `while`-Schleife zeige ich Ihnen hier:

```csharp

Console.Write("Bitte geben Sie eine Zahl zwischen 1 und 5 ein: ");

int input = 6
//mit der Variable 'input' setze ich die Schleife so, dass es erst dann abbricht, wenn der Benutzer eine gültige Eingabe eingegeben hat.

while (input = 6)
  {
      userInput = Convert.ToInt32(Console.ReadLine());
      if (userInput < 1 & userInput > 5)
      //hier wird mit `if``else` kontrolliert, ob die Eingabe richtig ist
      {
          Console.WriteLine("Bitte geben sie eine gültige Zahl ein.");
      }
      else
      {
          input = 0;
      }
  }
  
```

Nun zeige ich ihnen ein Ausschnitt vom Code, in dem ich die `while`-Schleife benutzt habe.

```csharp
while (language == -1)
    {
       try
       {
           userInput = Convert.ToInt32(Console.ReadLine());
           if (userInput != 1 && userInput != 2)
           {
               throw new Exception();
           }
           else if (userInput == 1)
           {
               language = 1;
           }
           else
           {
               language = 2;
           }
       }
       catch
       {
           Console.WriteLine("Wrong input!-_-");
       }
    }
Clear();
```

#Verifikation

Ziel 1: Beim Block 'Vorteil' und 'wie benutzt man es' wird gezeigt, für was es nützlich ist.
Ziel 2: Beim ersten Code-Block wird ein Beispiel gezeigt, wie man es einsetzt.

#Reflektion

Grundsätzlich fand ich die Gruppenarbeit gut, jedoch konnte ich mich manchmal nicht gut konzentrieren. 
Grund dafür war, dass ein paar Mitschüler mich ständig fragten, wie der Code geht oder was sie machen mussten. 
Ich wusste dazu zuerst nicht, wie wir mit dem Projekt anfangen sollten. Jedoch konnte der Gruppenleiter das regeln und wir konnten dann die Aufgaben aufteilen.

Verbesserungsvorschlag:
   - Das nächste Mal sollten die Gruppenmitglieder sich zuerst absprechen, wer was macht, bis wann man es gemacht haben sollte und wie man es dann dem Gruppenleiter zuschicken sollte. 
   - Ich sollte das nächste Mal meinen Mitschüler mitteilen, wann ich 'verfügbar' bin und wann ich mich vollständig auf das Projekt konzentrieren will.
