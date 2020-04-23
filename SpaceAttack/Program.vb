Option Explicit On
Imports System

Module Program

    Sub ErzeugeZeile()

        'aktuallisierte Zahlen
        Dim vektor(79) As Char
        Dim AnzahlBl�cke, Startposition, HindernisBreite, j, h As Integer
        'Zufallszahlen
        Dim Zufallszahl1, Zufallszahl2, Zufallszahl3 As Single

        For j = 0 To 79
            vektor(j) = " "

        Next

        'Per Zufall bestimmen, wie viele Hindernisbl�cke erscheinen
        Randomize()
        Zufallszahl1 = VBMath.Rnd()
        'Bilde den Zufallsbereich 0 bis 1 auf 2 bis 7 ab!
        AnzahlBl�cke = 5 * Zufallszahl1 + 2

        'Position und Breite jedes Hindernisblocks bestimmen!
        For j = 1 To AnzahlBl�cke
            Randomize()
            Zufallszahl2 = VBMath.Rnd()
            'Gr��e des Blocks von 1 bis 10
            HindernisBreite = 9 * Zufallszahl2 + 1
            'Startposition des Blocksfestlegen
            Randomize()
            Zufallszahl3 = VBMath.Rnd()
            'Position des Blocks bestimmen!
            Startposition = 79 * Zufallszahl3

            'Der Vektor darf nicht �berlaufen
            If Startposition + HindernisBreite - 1 <= 79 Then

                'F�lle den Vektor mit "X"
                For h = 1 To HindernisBreite
                    vektor(Startposition + h - 1) = "x"
                Next
            Else

            End If
        Next

        'Gib den Vektor aus
        Console.Write(vektor)
        'Halt das Programm an
        Console.ReadLine()

    End Sub

    Sub Main()
        'Lege die Gr��e der Konsole fest!
        Console.SetWindowSize(80, 24)
        'Call ZeilenNachUntenVerschieben()
        Call ErzeugeZeile()

    End Sub
End Module
