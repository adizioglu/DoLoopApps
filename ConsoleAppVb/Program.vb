Imports System

Module Program
    Sub Main()
        Dim isValidAge As Boolean
        Dim age As Integer
        'Dim testNumber As Integer = 0

        'Do
        '    Console.WriteLine(testNumber)
        '    testNumber += 3
        'Loop While testNumber < 10

        Do
            Console.Write("What is your age: ")
            Dim ageText As String = Console.ReadLine()

            isValidAge = Integer.TryParse(ageText, age)

            If isValidAge = False Then
                Console.WriteLine("That was an invalid age.")
            End If
        Loop While isValidAge = False

        Console.WriteLine($"Your age is {age}")

        'Do
        '    ' Run the code at least once
        'Loop While True

        'While True
        '    ' Runs the code 0 or more times
        'End While
    End Sub
End Module

