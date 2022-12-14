Public Class Product
    Public Property ProductId As Integer
    Public Property Name As String
    Public Property ProductNumber As String
    Public Property Color As String
    Public Property StandardCost As Decimal
    Public Property ListPrice As Decimal
    Public Property Size As String
    Public Property Weight As Decimal
    Public Property SellStartDate As DateTime
    Public Property SellEndDate As DateTime


    '- ByVal means if you pass a variable to the days parameter,
    'the colling variable is not affected by any changes to the days parameter. 
    Function CalculateSellEndDate(ByVal days As Integer) As DateTime
        SellEndDate = SellEndDate.AddDays(days)

        Return SellEndDate
    End Function




End Class
