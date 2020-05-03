Option Explicit On
Imports System
Imports System.Threading

Module Program
    Dim vektor(119) As Char
    Sub ErzeugeZeile()

        'aktuallisierte Zahlen
        'Dim vektor(79) As Char
        Dim AnzahlBlöcke, Startposition, HindernisBreite, j, h As Integer
        'Zufallszahlen
        Dim Zufallszahl1, Zufallszahl2, Zufallszahl3 As Single

        For j = 0 To 119
            vektor(j) = " "

        Next

        'Per Zufall bestimmen, wie viele Hindernisblöcke erscheinen
        Randomize()
        Zufallszahl1 = VBMath.Rnd()
        'Bilde den Zufallsbereich 0 bis 1 auf 2 bis 7 ab!
        AnzahlBlöcke = 5 * Zufallszahl1 + 2

        'Position und Breite jedes Hindernisblocks bestimmen!
        For j = 1 To AnzahlBlöcke
            Randomize()
            Zufallszahl2 = VBMath.Rnd()
            'Größe des Blocks von 1 bis 10
            HindernisBreite = 9 * Zufallszahl2 + 1
            'Startposition des Blocksfestlegen
            Randomize()
            Zufallszahl3 = VBMath.Rnd()
            'Position des Blocks bestimmen!
            Startposition = 119 * Zufallszahl3

            'Der Vektor darf nicht überlaufen
            If Startposition + HindernisBreite - 1 <= 119 Then

                'Fülle den Vektor mit "X"
                For h = 1 To HindernisBreite
                    vektor(Startposition + h - 1) = "x"
                Next
            Else

            End If
        Next

    End Sub

    Sub ZeilenNachUntenVerschieben()

        Dim Zeilenposition, Spaltenposition, lv1 As Integer
        Dim Spielfeld(29, 119) As Char

        Do

            Call ErzeugeZeile()

            'Kopiere jede Zeile eins nach unten mit der Untersten beginnend!

            For Zeilenposition = 29 To 1 Step -1


                For Spaltenposition = 0 To 119
                    Spielfeld(Zeilenposition, Spaltenposition) = Spielfeld(Zeilenposition - 1, Spaltenposition)

                Next

            Next

            'Schreibe die erzeugte zufällige Zeile in die Matrix

            For lv1 = 0 To 119

                Spielfeld(0, lv1) = vektor(lv1)

            Next

            Console.SetCursorPosition(0, 0)

            'Zeig das Spielfeld auf der Console an
            For Zeilenposition = 0 To 29
                For Spaltenposition = 0 To 119
                    Console.Write(Spielfeld(Zeilenposition, Spaltenposition))
                Next

            Next

            Thread.Sleep(500)
        Loop

    End Sub

    Sub Main()
        'Lege die Größe der Konsole fest!
        'Console.SetWindowSize(79, 23)
        Call ZeilenNachUntenVerschieben()
        'Call ErzeugeZeile()

    End Sub
End Module
