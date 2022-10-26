Module Module1
    'Lukah Youngs
    '10/26/22
    'Using a class for Tic Tac Toes
    Sub Main()
        Console.WriteLine("Tic Tac Toes By Lukah Youngs!") ' EDITED ON GITHUB
        console.writeline("Edited on github, but i don't have to give credit")
        Dim myboard As New TTTboard
        myboard.resetboard()
        Dim gameover As Boolean = False

        Do
            Dim valid As Boolean = False
            Dim usermove As Integer
            Dim input As String
            Do
                printboard(myboard)
                Console.Write("enter the space you want to try")
                input = Console.ReadLine
                If (Integer.TryParse(input, usermove)) Then
                    valid = myboard.usespace(usermove, "X")
                    If Not valid Then
                        Console.WriteLine("Invalid move")
                    End If
                Else
                    Console.WriteLine("Please enter an integer")
                End If
            Loop While Not valid
        Loop While Not gameover
    End Sub


    Sub printboard(theboard As TTTboard)
        Console.WriteLine(theboard.ToString())
        'Console.WriteLine("{0}|{1}|{2}", theboard.board(0), theboard.board(1), theboard.board(2))
        'Console.WriteLine(" -----")
        'Console.WriteLine("{0}|{1}|{2}", theboard.board(3), theboard.board(4), theboard.board(5))
        'Console.WriteLine(" -----")
        'Console.WriteLine("{0}|{1}|{2}", theboard.board(0), theboard.board(1), theboard.board(2))
        'Console.WriteLine(" -----")

    End Sub

End Module
