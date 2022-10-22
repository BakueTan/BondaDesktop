Public Class clsDbConn

    Public ReadOnly Property CnnString() As String
        Get
            Dim connection As String = ""
            '  connection = "Data Source= 192.168.1.2\SQLEXPRESS;Initial Catalog=RevoEduBonda;User ID=sa;Password=$0thwe11"
            '   connection = "Data Source= .\SQLEXPRESS;Initial Catalog=RevoEduBonda;User ID=sa;Password=$0thwe11"
            connection = "Data Source=  192.64.87.14\SQLEXPRESS;Initial Catalog=RevoEduBonda;User ID=sa;Password=$0thwe11"
            Return connection
        End Get


    End Property

End Class
