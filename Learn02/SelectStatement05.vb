Module SelectStatement05
	Sub main()
		Dim answer As Integer = 6
		
		Select Case True
			Case answer >= 5
				Console.WriteLine("5以上です")
			Case answer >= 3
				Console.WriteLine("3以上です")
			Case Else
				Console.WriteLine("それ以外")
		End Select
	End sub
End Module
