Imports System.Data.SqlClient
Module Module1
    'Connectionオブジェクトの生成
    Public cn As New SqlConnection
    'DataAdapterオブジェクトの生成
    Public daEmp As New SqlDataAdapter
    Public daDep As New SqlDataAdapter
    Public daWork As New SqlDataAdapter
    'DataSetオブジェクトの生成
    Public ds As New DataSet
    'DataViewオブジェクトの生成
    Public dv As New DataView

End Module
