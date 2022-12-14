Imports System.Runtime.Remoting.Channels

Module MainModule
    Sub Main()
        ' The "New" keyword when declaring a class. This creates an instance of 
        'that class in memory with slots for each property to be assigned. 
        Dim prod As New Product
        Dim sellDate As DateTime


        prod.SellStartDate = #5/1/2022#

        sellDate = prod.CalculateSellEndDate(30)

        Console.WriteLine(sellDate)

        Console.ReadKey()

    End Sub

End Module
