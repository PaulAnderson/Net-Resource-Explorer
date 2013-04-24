<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNetResourceExplorer
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnOpenAssembly = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlResources = New System.Windows.Forms.Panel()
        Me.pnlTypes = New System.Windows.Forms.Panel()
        Me.lbTypes = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pnlModules = New System.Windows.Forms.Panel()
        Me.lbModules = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.btnEntryPoint = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.Name = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Type = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.pnlResources.SuspendLayout()
        Me.pnlTypes.SuspendLayout()
        Me.pnlModules.SuspendLayout()
        Me.pnlTop.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnOpenAssembly
        '
        Me.btnOpenAssembly.Location = New System.Drawing.Point(15, 12)
        Me.btnOpenAssembly.Name = "btnOpenAssembly"
        Me.btnOpenAssembly.Size = New System.Drawing.Size(107, 23)
        Me.btnOpenAssembly.TabIndex = 0
        Me.btnOpenAssembly.Text = "Open Assembly"
        Me.btnOpenAssembly.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(494, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Resources"
        '
        'pnlResources
        '
        Me.pnlResources.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlResources.Controls.Add(Me.ListView1)
        Me.pnlResources.Controls.Add(Me.Label1)
        Me.pnlResources.Location = New System.Drawing.Point(12, 56)
        Me.pnlResources.Name = "pnlResources"
        Me.pnlResources.Size = New System.Drawing.Size(494, 119)
        Me.pnlResources.TabIndex = 3
        '
        'pnlTypes
        '
        Me.pnlTypes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlTypes.Controls.Add(Me.lbTypes)
        Me.pnlTypes.Controls.Add(Me.Label2)
        Me.pnlTypes.Location = New System.Drawing.Point(12, 181)
        Me.pnlTypes.Name = "pnlTypes"
        Me.pnlTypes.Size = New System.Drawing.Size(494, 119)
        Me.pnlTypes.TabIndex = 4
        '
        'lbTypes
        '
        Me.lbTypes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbTypes.FormattingEnabled = True
        Me.lbTypes.Location = New System.Drawing.Point(0, 16)
        Me.lbTypes.Name = "lbTypes"
        Me.lbTypes.Size = New System.Drawing.Size(494, 103)
        Me.lbTypes.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(494, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Types"
        '
        'pnlModules
        '
        Me.pnlModules.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlModules.Controls.Add(Me.lbModules)
        Me.pnlModules.Controls.Add(Me.Label3)
        Me.pnlModules.Location = New System.Drawing.Point(12, 306)
        Me.pnlModules.Name = "pnlModules"
        Me.pnlModules.Size = New System.Drawing.Size(494, 119)
        Me.pnlModules.TabIndex = 4
        '
        'lbModules
        '
        Me.lbModules.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbModules.FormattingEnabled = True
        Me.lbModules.Location = New System.Drawing.Point(0, 16)
        Me.lbModules.Name = "lbModules"
        Me.lbModules.Size = New System.Drawing.Size(494, 103)
        Me.lbModules.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(494, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Modules"
        '
        'pnlTop
        '
        Me.pnlTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.pnlTop.Controls.Add(Me.btnEntryPoint)
        Me.pnlTop.Controls.Add(Me.btnOpenAssembly)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(518, 50)
        Me.pnlTop.TabIndex = 5
        '
        'btnEntryPoint
        '
        Me.btnEntryPoint.Location = New System.Drawing.Point(365, 12)
        Me.btnEntryPoint.Name = "btnEntryPoint"
        Me.btnEntryPoint.Size = New System.Drawing.Size(141, 23)
        Me.btnEntryPoint.TabIndex = 0
        Me.btnEntryPoint.Text = "Execute Entry Point"
        Me.btnEntryPoint.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Name, Me.Type})
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView1.Location = New System.Drawing.Point(0, 16)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(494, 103)
        Me.ListView1.TabIndex = 3
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'frmNetResourceExplorer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(518, 439)
        Me.Controls.Add(Me.pnlTop)
        Me.Controls.Add(Me.pnlModules)
        Me.Controls.Add(Me.pnlTypes)
        Me.Controls.Add(Me.pnlResources)
        Me.Name = "frmNetResourceExplorer"
        Me.Text = "Paul's .net Resource Explorer"
        Me.pnlResources.ResumeLayout(False)
        Me.pnlTypes.ResumeLayout(False)
        Me.pnlModules.ResumeLayout(False)
        Me.pnlTop.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnOpenAssembly As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents pnlResources As System.Windows.Forms.Panel
    Friend WithEvents pnlTypes As System.Windows.Forms.Panel
    Friend WithEvents lbTypes As System.Windows.Forms.ListBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents pnlModules As System.Windows.Forms.Panel
    Friend WithEvents lbModules As System.Windows.Forms.ListBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents pnlTop As System.Windows.Forms.Panel
    Friend WithEvents btnEntryPoint As System.Windows.Forms.Button
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents Name As System.Windows.Forms.ColumnHeader
    Friend WithEvents Type As System.Windows.Forms.ColumnHeader

End Class
