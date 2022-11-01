Module Module1

    Sub Main()
        Dim Marks(6) As Integer
        Dim Total As Integer
        Dim Counter As Integer
        Dim Percentage As Decimal
        Dim SubNames(6) As String
        Dim NumSub As Integer
        Dim Subjects As Integer

        NumSub = 0
        Total = 0
        Subjects = 0

        ' Total Number of subjects being entered
        Console.Write("Enter total number of subjects:  ")
            NumSub = Console.ReadLine
            Subjects = Subjects + NumSub

        'User Asked to enter names of subjects
            Console.WriteLine("Enter names of subject: ")
        For Counter = 0 To Subjects - 1
            Console.Write("> ")
            SubNames(Counter) = Console.ReadLine
        Next

        ' Marks entered with subject name
            Console.WriteLine("Enter your marks for subject: ")
        For Counter = 0 To Subjects - 1
            Console.Write("> " & SubNames(Counter) & ": ")
            Marks(Counter) = Console.ReadLine
        Next

        ' The items in arrays being added into and total value is found
        For Counter = 0 To Subjects - 1
            Total = Total + Marks(Counter)
        Next

        Console.WriteLine("Total Marks = " & Total)
        ' Assuming Every Subject has Total Marks = 100
        Percentage = Total / (Subjects * 100) * 100
        Console.WriteLine("Percentage = " & Percentage)
        Console.ReadKey()
    End Sub

End Module
