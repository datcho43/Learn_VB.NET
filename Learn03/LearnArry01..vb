Module LearnArry01
	Sub Main()
		Dim numbers(3) As Integer
		numbers(0) = 10
		numbers(1) = 20
		numbers(2) = 30
		numbers(3) = 40
		
		Console.WriteLine("numbersの0番目の数字は" & numbers(0))
		Console.WriteLine("numbersの1番目の数字は" & numbers(1))
		Console.WriteLine("numbersの2番目の数字は" & numbers(2))
		Console.WriteLine("numbersの3番目の数字は" & numbers(3))
		
		Dim length As Integer = numbers.Length
		Console.WriteLine("numbersの要素数は" & length)
	End Sub
End Module