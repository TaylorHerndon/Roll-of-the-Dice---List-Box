Option Strict On
Option Explicit On

'Taylor Herndon
'RCET0265
'Roll of the Dice - List Box
'Spring 2021
'https://github.com/TaylorHerndon/Roll-of-the-Dice---List-Box


Public Class RollOfTheDice

    Sub RollButtonPress() Handles RollButton.Click, RollToolStripMenuItem.Click

        Randomize()
        Dim rollCount(12) As Integer
        Dim rollCountString As String = ""

        'Roll two six sided dice 1000 times and incriment the coresponding result
        For i = 1 To 1000

            rollCount(CInt(Math.Ceiling(VBMath.Rnd * 6) + Math.Ceiling(VBMath.Rnd * 6))) += 1

        Next

        'Clear the list box
        ListBoxResults.Items.Clear()

        'Write out the header and results
        ListBoxResults.Items.Add("                                       ROLL OF THE DICE                                  ")
        ListBoxResults.Items.Add(StrDup(89, "-"))
        ListBoxResults.Items.Add("|   2   |   3   |   4   |   5   |   6   |   7   |   8   |   9   |   10  |   11  |   12  |")
        ListBoxResults.Items.Add(StrDup(89, "-"))

        'Concatanate all roll counts with |s in between 
        For i = 2 To 12

            rollCountString = rollCountString & "|" & rollCount(i).ToString.PadLeft(5) & "  "

        Next

        rollCountString = rollCountString & "|"

        'Write out the concatanated string
        ListBoxResults.Items.Add(rollCountString)

        'Finish header
        ListBoxResults.Items.Add(StrDup(89, "-"))

    End Sub

    Sub ClearButtonPress() Handles ClearButton.Click, ClearToolStripMenuItem.Click

        'Clear the list box
        ListBoxResults.Items.Clear()

    End Sub

    Sub ExitButtonPress() Handles ExitButton.Click, ExitToolStripMenuItem.Click

        'End the program
        End

    End Sub

    Sub HelpButtonPress() Handles HelpToolStripMenuItem.Click

        MsgBox("Welcome to Roll Of The Dice - List Box Eddition!" & vbNewLine &
               "To get started press 'Roll', this will roll 1000 sets of 2, 6 sided dice!" & vbNewLine &
               "The results of how many times each result occured will be displayed in the list box.")

    End Sub

End Class
