Imports System

Module MagicDate

    Sub Main()
        Dim day, month, two_digit_year As Integer
        Console.Write("Enter the value of day: ")
        day = Integer.Parse(Console.ReadLine())
        Console.Write("Enter the value of month: ")
        month = Integer.Parse(Console.ReadLine())
        Console.Write("Enter the value of two digit year: ")
        two_digit_year = Integer.Parse(Console.ReadLine())

        If day * month = two_digit_year Then
            Console.WriteLine("This date is magic!")
        Else
            Console.WriteLine("This date is not magic.")
        End If
        Console.WriteLine()
        Main()

    End Sub
End Module
