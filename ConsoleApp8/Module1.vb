Module Module1

    Sub Main()
        Dim Exam(5, 3) As String
        Console.WriteLine("sname" & vbTab & "quiz one" & vbTab & "quiz two")


        Exam(0, 1) = "Victor Jon"
        Exam(0, 2) = 80
        Exam(0, 3) = 90

        Exam(1, 1) = "Nick"
        Exam(1, 2) = 80
        Exam(1, 3) = 96

        Exam(2, 1) = "Kim"
        Exam(2, 2) = 70
        Exam(2, 3) = 90

        Exam(3, 1) = "Ponny"
        Exam(3, 2) = 80
        Exam(3, 3) = 90

        Exam(4, 1) = "Kido"
        Exam(4, 2) = 56
        Exam(4, 3) = 90

        Console.WriteLine(Exam(0, 1) & vbTab & Exam(0, 2) & vbTab & Exam(0, 3))
        Console.WriteLine(Exam(1, 1) & vbTab & Exam(1, 2) & vbTab & Exam(1, 3))
        Console.WriteLine(Exam(2, 1) & vbTab & Exam(2, 2) & vbTab & Exam(2, 3))
        Console.WriteLine(Exam(3, 1) & vbTab & Exam(3, 2) & vbTab & Exam(3, 3))
        Console.WriteLine(Exam(4, 1) & vbTab & Exam(4, 2) & vbTab & Exam(4, 3))




    End Sub

End Module
