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

Imports System.Reflection

Public Class frmResourceExplorer

    Private assembly As System.Reflection.Assembly
    Private types As Dictionary(Of String, Type)

    Public Shared Function GetLoadableTypes(ByVal assembly As System.Reflection.Assembly) As IEnumerable(Of Type)
        Try
            Return assembly.GetTypes
        Catch ex As Reflection.ReflectionTypeLoadException
            Return ex.Types.Where(Function(t) t IsNot Nothing)
        End Try
    End Function
    Private Sub lbResources_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim info As System.Reflection.ManifestResourceInfo = assembly.GetManifestResourceInfo(lbResources.SelectedValue)
        'todo
    End Sub

    Private Sub tsbExecuteMethod_Click(sender As System.Object, e As System.EventArgs) Handles tsbExecuteMethod.Click
        ExecuteSelectedMethod()
    End Sub
    Private Sub DisplayObject(o As Object)
        'todo
    End Sub

    Private Sub tsbOpenAssembly_Click(sender As System.Object, e As System.EventArgs) Handles tsbOpenAssembly.Click
        OpenAssembly()
    End Sub

    Private Sub tsbEntryPoint_Click(sender As System.Object, e As System.EventArgs) Handles tsbEntryPoint.Click
        ExecuteEntryPoint()
    End Sub

    Private Sub tsbConsole_Click(sender As System.Object, e As System.EventArgs) Handles tsbConsole.Click
        OpenConsole()
    End Sub
    Private Sub OpenAssembly()
        Dim dlg As New OpenFileDialog
        If dlg.ShowDialog() = Windows.Forms.DialogResult.OK Then
            OpenAssembly(dlg.FileName)
        End If
    End Sub
    Private Sub OpenAssembly(fileName As String)
        Try
            Dim resources As String()
            Dim loadedTypes As IEnumerable(Of Type)
            Dim typeNames As New List(Of String)
            Dim modules As System.Reflection.Module()
            Dim moduleNames As New List(Of String)
            types = New Dictionary(Of String, Type)
            assembly = System.Reflection.Assembly.LoadFile(fileName)
            txtRuntimeVersion.Text = assembly.ImageRuntimeVersion

            resources = assembly.GetManifestResourceNames()
            Array.Sort(resources)
            lbResources.DataSource = resources

            modules = assembly.GetModules()
            For Each [module] As System.Reflection.Module In modules
                moduleNames.Add([module].Name)
            Next ([module])
            lbModules.DataSource = moduleNames
            loadedTypes = GetLoadableTypes(assembly)
            tvTypes.Nodes.Clear()
            tvTypes.Visible = False
            For Each t As Type In loadedTypes
                types.Add(t.Name, t)
                Dim typeNode As TreeNode = tvTypes.Nodes.Add(t.Name, t.Name)
                typeNode.Tag = "T"
                For Each method As System.Reflection.MethodInfo In t.GetMethods()
                    typeNode.Nodes.Add(method.Name, method.Name).Tag = "M"
                Next
            Next
            tvTypes.Visible = True

        Catch ex As BadImageFormatException
            MessageBox.Show("The file image of the dynamic link library (DLL) or executable program is invalid." + vbCrLf + "Check that you have selected a valid .net assembly.", My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub OpenConsole()
        If Not AttachConsole(ATTACH_PARENT_PROCESS) Then
            AllocConsole()  '
        End If
        Console.WriteLine(String.Format("{0} Console opened.", My.Application.Info.Title))
    End Sub
    Private Sub ExecuteSelectedMethod()
        If tvTypes.SelectedNode IsNot Nothing Then
            If tvTypes.SelectedNode.Tag = "M" Then
                Dim methodName As String = tvTypes.SelectedNode.Text
                Dim typeName As String = tvTypes.SelectedNode.Parent.Text
                Dim t As Type = types(typeName)
                Dim instance As Object
                Try
                    instance = System.Activator.CreateInstance(t)
                Catch ex As MissingMethodException
                    'get constructors. If none, continue to try to call method as static
                    For Each constructor As ConstructorInfo In t.GetConstructors()
                        MessageBox.Show(constructor.GetParameters.Count)
                    Next
                End Try
                Dim methodInfo As System.Reflection.MethodInfo = t.GetMethod(methodName)
                Dim returnValue As Object
                Try
                    returnValue = methodInfo.Invoke(instance, Nothing)
                    If returnValue IsNot Nothing Then
                        If TypeOf returnValue Is Form Then
                            If MessageBox.Show(returnValue.ToString() + vbCrLf + vbCrLf + "Returned type of a form. Do you want to show it?", "Method Result", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                                CType(returnValue, Form).Show()
                            Else
                                'do nothing
                            End If
                        Else
                            MessageBox.Show(returnValue.ToString())
                        End If

                    Else
                        MessageBox.Show("No return value")
                    End If
                Catch ex As System.Reflection.TargetInvocationException
                    If ex.InnerException IsNot Nothing Then
                        MessageBox.Show("Exception Encountered: " + vbCrLf + ex.InnerException.ToString)
                    End If
                Catch ex As System.Reflection.TargetParameterCountException
                    MessageBox.Show("Exception Encountered: TargetParameterCountException.") 'todo: get and provide params
                End Try
            Else
                MessageBox.Show("You have selected a type. Expand the type node to see available methods.")
            End If
        Else
            MessageBox.Show("You must select  method to execute.")
        End If
    End Sub
    Private Sub ExecuteEntryPoint()
        Console.WriteLine("1")
        If assembly Is Nothing Then
            MessageBox.Show("No assembly has been loaded. Can't execute entry point.", My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf assembly.EntryPoint Is Nothing Then
            MessageBox.Show("The loaded assembly has no entry point.", My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Dim methodInfo As System.Reflection.MethodInfo = assembly.EntryPoint

            Dim result As Object
            Dim parameters As Reflection.ParameterInfo() = methodInfo.GetParameters()
            'Dim classInstance As Object = Activator.CreateInstance(t, null)
            Dim args As String() = New String() {} '{"test123"}
            Dim parametersArray As Object = New Object() {args}
            If parameters IsNot Nothing AndAlso parameters.Count > 0 AndAlso parameters(0).Name = "Args" Then
                result = methodInfo.Invoke(methodInfo, parametersArray)
            End If
            result = methodInfo.Invoke(methodInfo, Nothing)
        End If
    End Sub

    Private Sub tsbFind_Click(sender As System.Object, e As System.EventArgs) Handles tsbFind.Click
        Dim searchString As String = InputBox("Search for type/method", "Search", "")
        If Not String.IsNullOrWhiteSpace(searchString) Then
            tvTypes.CollapseAll()
            Dim searchResults As List(Of TreeNode)
            searchResults = FindInNodes(searchString.ToLower(), tvTypes.Nodes)
            MessageBox.Show(String.Format("{0} Results", searchResults.Count))
        End If
    End Sub

    'Recursive search.expands nodes containing searchString in text, returns matching nodes
    Private Function FindInNodes(searchString As String, nodes As TreeNodeCollection) As List(Of TreeNode)
        If nodes Is Nothing Then Return Nothing

        Dim results As New List(Of TreeNode)

        For Each node As TreeNode In nodes
            If node.Text IsNot Nothing AndAlso node.Text.ToLower.Contains(searchString) Then
                results.Add(node)
                node.ForeColor = Color.Red
                node.BackColor = Color.Yellow
                node.EnsureVisible()
            Else
                node.ForeColor = Color.Black
                node.BackColor = Color.White
            End If
            Dim subResults As List(Of TreeNode) = FindInNodes(searchString, node.Nodes)
            If subResults IsNot Nothing Then
                For Each subresult As TreeNode In subResults
                    results.Add(subresult)
                Next
            End If
        Next

        Return results
    End Function
End Class
