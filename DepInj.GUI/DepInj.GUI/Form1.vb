Imports System.IO
Imports System.Reflection
Imports Contracts


Public Class Form1

    Dim derMacher As IMachWas = Nothing

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        'Dim filepath = "C:\Users\ar2\source\repos\DepInj.GUI\MachWas.Bernd\bin\Debug\netstandard2.0\MachWas.Bernd.dll"
        Dim filepath = "C:\Users\ar2\source\repos\ppedvAG\20190305_Git_Schulung\DepInj.GUI\MachWas.Bernd\bin\Debug\netstandard2.0\MachWas.Bernd.dll"

        Dim ass = Assembly.LoadFile(filepath)
        Dim target = ass.GetTypes().FirstOrDefault(Function(p) GetType(IMachWas).IsAssignableFrom(p))

        derMacher = CType(Activator.CreateInstance(target), IMachWas)


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        derMacher.MachWas(76)
    End Sub
End Class
