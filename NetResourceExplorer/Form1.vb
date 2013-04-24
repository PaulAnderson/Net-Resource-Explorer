' Paul's .Net Resource Explorer
' Copyright (C) 2013 Paul Anderson
' 
'  This program is free software; you can redistribute it and/or
'  modify it under the terms of the GNU General Public License
'  as published by the Free Software Foundation; either version 2
'  of the License, or (at your option) any later version.
'  
'  This program is distributed in the hope that it will be useful,
'  but WITHOUT ANY WARRANTY; without even the implied warranty of
'  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
'  GNU General Public License for more details.
'  
'  You should have received a copy of the GNU General Public License
'  along with this program; if not, write to the Free Software
'  Foundation, Inc., 59 Temple Place - Suite 330, Boston, MA  02111-1307, USA.

Public Class frmNetResourceExplorer

    Private assembly As System.Reflection.Assembly
    Private Sub btnOpenAssembly_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpenAssembly.Click
        Dim dlg As New OpenFileDialog
        If dlg.ShowDialog() = Windows.Forms.DialogResult.OK Then

            Dim resources As String()
            Dim types As IEnumerable(Of Type)
            Dim typeNames As New List(Of String)
            Dim modules As System.Reflection.Module()
            Dim moduleNames As New List(Of String)
            assembly = System.Reflection.Assembly.LoadFile(dlg.FileName)

            resources = assembly.GetManifestResourceNames()
            Array.Sort(resources)
            lbResources.DataSource = resources

            modules = assembly.GetModules()
            For Each [module] As System.Reflection.Module In modules
                moduleNames.Add([module].Name)
            Next ([module])
            lbModules.DataSource = moduleNames

            types = GetLoadableTypes(assembly)
            For Each t As Type In types
                typeNames.Add(t.Name)
            Next
            lbTypes.DataSource = typeNames

        End If

    End Sub
    Public Shared Function GetLoadableTypes(ByVal assembly As System.Reflection.Assembly) As IEnumerable(Of Type)
        Try
            Return assembly.GetTypes
        Catch ex As Reflection.ReflectionTypeLoadException
            Return ex.Types.Where(Function(t) t IsNot Nothing)
        End Try
    End Function
    Private Sub lbResources_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim info As System.Reflection.ManifestResourceInfo = assembly.GetManifestResourceInfo(lbResources.SelectedValue)

    End Sub

    Private Sub btnEntryPoint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEntryPoint.Click
        Dim methodInfo As System.Reflection.MethodInfo = assembly.EntryPoint

        Dim result As Object
        Dim parameters As Reflection.ParameterInfo() = methodInfo.GetParameters()
        'Dim classInstance As Object = Activator.CreateInstance(t, null)
        Dim args As String() = New String() {"test123"}
        Dim parametersArray As Object = New Object() {args}
        result = methodInfo.Invoke(methodInfo, parametersArray)
    End Sub
End Class
