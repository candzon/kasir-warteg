Imports System.Data.Odbc
Module Koneksi

    Public Conn As OdbcConnection
    Public Da As OdbcDataAdapter
    Public Ds As DataSet
    Public Cmd As OdbcCommand
    Public Rd As OdbcDataReader
    Public Dt As DataTable
    Public MyDb As String


    Sub KoneksiDb()
        MyDb = "Driver={Mysql ODBC 3.51 Driver}; Database=db_kasir; server=localhost;uid=root"
        Conn = New OdbcConnection(MyDb)
        If Conn.State = ConnectionState.Closed Then Conn.Open()

    End Sub

End Module
