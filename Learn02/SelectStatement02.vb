Module SelectStatement02
	Sub Main()
		Dim answer as Integer =85
		
		Select Case answer
			Case Is >= 80
				Console.WriteLine("80以上")
			Case Is >= 60
				Console.WriteLine("60以上")
			Case Is >= 40
				Console.WriteLine("40以上")
			Case Else
				Console.WriteLine("40未満")
		End Select
		
	End Sub
End Module