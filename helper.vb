
Public Module helper
		'simple function to correct a path
	Public Function	pCheck (path As String) As String
		
		If Not path = "" Then
			Trim(path)
			Dim check As String
			check = path(path.Length-1)
			If check IsNot "\" Then
				path = path + "\"
			End If
			Return path	
		End If
		Return "Nothing"
		
	End Function
End Module
