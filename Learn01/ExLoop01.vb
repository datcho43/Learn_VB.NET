Module ExLoop01
	Sub main()
		Dim count As Integer = 1
		Dim random As New System.Random()
		
		Do While True
			If random.Next(6) + 1 = 6
				Exit Do
			End If
			count += 1
		Loop
		Console.WriteLine(count & "回目で6が出ました")
		
	End Sub
End Module