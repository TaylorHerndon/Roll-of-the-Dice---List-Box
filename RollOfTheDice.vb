Option Strict On
Option Explicit On

'Taylor Herndon
'RCET0265
'Roll of the Dice - List Box
'Spring 2021
'https://github.com/TaylorHerndon/Roll-of-the-Dice---List-Box


Public Class RollOfTheDice

    Sub RollButtonPress() Handles ButtonRoll.Click

        Randomize()
        Dim rollCount(12) As Integer

        'Roll two six sided dice 1000 times and incriment the coresponding result
        For i = 1 To 1000

            rollCount(CInt(Math.Ceiling(VBMath.Rnd * 6 + VBMath.Rnd * 6))) += 1

        Next

        'Clear the list box
        ListBoxResults.Items.Clear()

        'Write out the header and results
        ListBoxResults.Items.Add("                                          ROLL OF THE DICE                                          ")
        ListBoxResults.Items.Add("----------------------------------------------------------------------------------------------------")
        ListBoxResults.Items.Add("|    2    |   3   |   4    |   5    |   6    |   7    |   8    |   9    |  10   |  11   |   12   |")
        ListBoxResults.Items.Add("----------------------------------------------------------------------------------------------------")

        'Concatanate all roll counts with |s in between 
        Dim rollCountString As String = ""

        For i = 2 To 12

            rollCountString = rollCountString & " |" & rollCount(i).ToString.PadLeft(6)

        Next

        rollCountString = rollCountString & "  |"

        'Write out the concatanated string
        ListBoxResults.Items.Add(rollCountString)

        'Finish header
        ListBoxResults.Items.Add("----------------------------------------------------------------------------------------------------")

    End Sub

    Sub ClearButtonPress() Handles ButtonClear.Click

        'Clear the list box
        ListBoxResults.Items.Clear()

    End Sub

    Sub ExitButtonPress() Handles ButtonExit.Click

        'End the program
        End

    End Sub

End Class
