Module LearnVariables05
	Sub Main()
		Dim name1 As String = "田中"
		Dim name2 As String = "中山"
		Dim msg1 As String = name1 + "と" + name2
		Console.WriteLine(msg1)
		Dim msg2 As String = name1 & "と" & name2
		Console.WriteLine(msg2)
	End Sub
End Module