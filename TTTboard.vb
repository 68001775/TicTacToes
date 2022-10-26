Public Class TTTboard
    'Public boardsize As Integer = 9
    Private Const boardsize As Integer = 9
    Private board(boardsize - 1) As String

    Public Sub New()

        resetboard()

    End Sub

    ''' <summary>
    ''' resets the board so that all spaces hold their numeric place (no Xs or Os)
    ''' </summary>
    Public Sub resetboard()

        For i As Integer = 0 To boardsize - 1

            board(i) = i.ToString


        Next

    End Sub


    Public Overrides Function ToString() As String
        Return board(0) & "|" & board(1) & "|" & board(2) & "|" & vbNewLine &
            "-----" & vbNewLine &
        board(3) & "|" & board(4) & "|" & board(5) & "|" & vbNewLine &
        "-----" & vbNewLine &
        board(6) & "|" & board(7) & "|" & board(8) & "|" & vbNewLine
    End Function
    ''' <summary>
    ''' accepts an index on the board, verifies it is open and the if "X" or "O" is passed in, makes the move
    ''' </summary>
    ''' <param name="spaceindex"></param>
    ''' <param name="XorO"></param>
    ''' <returns>true if successfully placed, false if otherwise</returns> 
    Public Function usespace(spaceindex As Integer, XorO As String)
        XorO = XorO.ToUpper.Trim
        If XorO <> "X" AndAlso XorO <> "O" Then
            Return False
        End If

        If spaceindex < 0 OrElse spaceindex >= board.Length Then
            Return False
        End If

        If board(spaceindex) <> spaceindex.ToString Then
            Return False
        End If

        board(spaceindex) = XorO
        Return True

    End Function
End Class
