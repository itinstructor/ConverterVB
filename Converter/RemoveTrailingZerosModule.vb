' Remove trailing zeros in the number display
Module RemoveTrailingZerosModule
    Friend Function RemoveTrailingZeros(ByVal str As String) As String
        ' str is the string with the trailing zeros coming into the function
        ' The first (inner) Replace command will replace all zeroes with spaces.
        ' The RTrim command will remove all spaces on the left of the value.
        ' The second Replace command will replace all spaces back with the zeroes
        ' The result is original value without leading zeroes.
        Dim strNewString As String

        ' Remove trailing zeros
        strNewString = Replace(RTrim(Replace(str, "0", " ")), " ", "0")

        ' Remove trailing .
        Return Replace(RTrim(Replace(strNewString, ".", " ")), " ", ".")
    End Function
End Module
