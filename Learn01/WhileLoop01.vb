Module WhileLoop01
	Sub main()
		Dim count As Integer = 0
		
		While count < 3
			Console.WriteLine(count)
			count = count + 1
		End While
		Console.WriteLine("ループが終わりました")
		
	End Sub
End Module
