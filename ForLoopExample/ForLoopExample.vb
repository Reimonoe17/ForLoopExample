Option Explicit On
Option Strict On
Module ForLoopExample
    Sub Main()

        ''For i = 1 to 10
        'For index As Integer = 1 To 10 Step 1
        '    Console.WriteLine("Something" & " " & CStr(index))
        'Next

        'Dim total As Integer
        'For i = 1 To 10
        '    'total = total + 2
        '    total += 2
        '    Console.WriteLine("The total is:" & " " & CStr(total))
        'Next

        Dim star As String = ""
        For i = 1 To 10
            star &= "*"
            Console.WriteLine(star)
        Next

        Console.ReadLine()
    End Sub

End Module
