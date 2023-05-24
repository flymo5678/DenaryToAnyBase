Module Module1

    Sub Main()
        Dim number As Integer
        Dim base As Integer
        Dim reverseAnswer As String = ""
        Dim Answer As String = ""
        Dim letters As String() = New String(25) {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"}

        Console.Write("Enter a number: ")
        number = CInt(Console.ReadLine)
        While base < 2 Or base > 36
            Console.Write("Enter a base to convert to (can't be less than 2 or greater than 36): ")
            base = CInt(Console.ReadLine)
        End While

        While number <> 0
            If number Mod base <= 9 Then
                reverseAnswer = reverseAnswer & number Mod base
            ElseIf number Mod base > 9 Then
                reverseAnswer = reverseAnswer & letters((number Mod base - 9) - 1)
            End If
            number = number \ base
        End While
        For i = reverseAnswer.Length - 1 To 0 Step -1
            Answer = Answer & reverseAnswer(i)
        Next
        Console.WriteLine(Answer)
    End Sub

End Module
