Module DoLoop04
	Sub Main()
		Dim count As Integer
		
		count = 0
		Do While count < 10
			count += 1
			If count Mod 2 = 0 Then
				Continue Do
			End If
			Console.WriteLine(count)
		Loop
		Console.WriteLine("ループが終わりました")
	End Sub
End Module
		