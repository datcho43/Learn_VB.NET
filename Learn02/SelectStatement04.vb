Module SelectStatement04
	Sub Main()
		Dim answer As Integer =6
		
		Select Case answer
			Case 1,2
				Console.WriteLine("1か2")
			Case 3
				Console.WriteLine("3")
			Case 4,5,6
				Console.WriteLine("4か5か6")
			Case Else
				Console.WriteLine("それ以外")
		End Select
		
	End Sub
End Module