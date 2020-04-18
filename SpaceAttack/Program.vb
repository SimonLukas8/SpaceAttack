Option Explicit On
Imports System

Module Program

    Sub ErzeugeZeile()


        Dim vektor(119) As Char
        Dim AnzahlBl�cke, Startposition, HindernisBreite, j, h As Integer
        'Zufallszahlen
        Dim Zufallszahl1, Zufallszahl2, Zufallszahl3 As Single

        For j = 0 To 119
            vektor(j) = " "

        Next

        'Per Zufall bestimmen, wie viele Hindernisbl�cke erscheinen
        Randomize()
        Zufallszahl1 = VBMath.Rnd()
        'Bilde den Zufallsbereich 0 bis 1 auf 2 bis 15 ab!
        AnzahlBl�cke = 13 * Zufallszahl1 + 2
        'Console.WriteLine(x & " " & AnzahlBl�cke)

        'Position und Breite jedes Hindernisblocks bestimmen!
        For j = 1 To AnzahlBl�cke
            Zufallszahl2 = VBMath.Rnd()
            'Gr��e des Blocks von 1 bis 8
            HindernisBreite = 7 * Zufallszahl2 + 1
            'Startposition des Blocksfestlegen
            Zufallszahl3 = VBMath.Rnd()
            'Position des Blocks bestimmen!
            Startposition = 119 * Zufallszahl3

            'Der Vektor darf nicht �berlaufen
            If Startposition + HindernisBreite - 1 <= 119 Then

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

        Call ErzeugeZeile()


    End Sub
End Module
