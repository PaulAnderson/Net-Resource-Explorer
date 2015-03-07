<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmResourceExplorer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmResourceExplorer))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlResources = New System.Windows.Forms.Panel()
        Me.lbResources = New System.Windows.Forms.ListBox()
        Me.pnlTypes = New System.Windows.Forms.Panel()
        Me.tvTypes = New System.Windows.Forms.TreeView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pnlModules = New System.Windows.Forms.Panel()
        Me.lbModules = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsbExecuteMethod = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.tsbOpenAssembly = New System.Windows.Forms.ToolStripButton()
        Me.tsbEntryPoint = New System.Windows.Forms.ToolStripButton()
        Me.tsbConsole = New System.Windows.Forms.ToolStripButton()
        Me.tsbFind = New System.Windows.Forms.ToolStripButton()
        Me.pnlResources.SuspendLayout()
        Me.pnlTypes.SuspendLayout()
        Me.pnlModules.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.SuspendLayout()
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
        Me.pnlResources.Controls.Add(Me.lbResources)
        Me.pnlResources.Controls.Add(Me.Label1)
        Me.pnlResources.Location = New System.Drawing.Point(12, 28)
        Me.pnlResources.Name = "pnlResources"
        Me.pnlResources.Size = New System.Drawing.Size(494, 119)
        Me.pnlResources.TabIndex = 3
        '
        'lbResources
        '
        Me.lbResources.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbResources.FormattingEnabled = True
        Me.lbResources.Location = New System.Drawing.Point(0, 16)
        Me.lbResources.Name = "lbResources"
        Me.lbResources.Size = New System.Drawing.Size(494, 103)
        Me.lbResources.TabIndex = 3
        '
        'pnlTypes
        '
        Me.pnlTypes.Controls.Add(Me.tvTypes)
        Me.pnlTypes.Controls.Add(Me.Label2)
        Me.pnlTypes.Location = New System.Drawing.Point(12, 153)
        Me.pnlTypes.Name = "pnlTypes"
        Me.pnlTypes.Size = New System.Drawing.Size(494, 119)
        Me.pnlTypes.TabIndex = 4
        '
        'tvTypes
        '
        Me.tvTypes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tvTypes.Location = New System.Drawing.Point(0, 16)
        Me.tvTypes.Name = "tvTypes"
        Me.tvTypes.Size = New System.Drawing.Size(494, 103)
        Me.tvTypes.TabIndex = 3
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
        Me.Label2.Text = "Types && Methods"
        '
        'pnlModules
        '
        Me.pnlModules.Controls.Add(Me.lbModules)
        Me.pnlModules.Controls.Add(Me.Label3)
        Me.pnlModules.Location = New System.Drawing.Point(12, 278)
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
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ToolStrip1)
        Me.Panel1.Location = New System.Drawing.Point(512, 181)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(65, 119)
        Me.Panel1.TabIndex = 6
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbExecuteMethod, Me.tsbFind})
        Me.ToolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(65, 85)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsbExecuteMethod
        '
        Me.tsbExecuteMethod.Image = CType(resources.GetObject("tsbExecuteMethod.Image"), System.Drawing.Image)
        Me.tsbExecuteMethod.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbExecuteMethod.Name = "tsbExecuteMethod"
        Me.tsbExecuteMethod.Size = New System.Drawing.Size(63, 34)
        Me.tsbExecuteMethod.Text = "Execute"
        Me.tsbExecuteMethod.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbOpenAssembly, Me.tsbEntryPoint, Me.tsbConsole})
        Me.ToolStrip2.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(574, 25)
        Me.ToolStrip2.TabIndex = 7
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'tsbOpenAssembly
        '
        Me.tsbOpenAssembly.Image = CType(resources.GetObject("tsbOpenAssembly.Image"), System.Drawing.Image)
        Me.tsbOpenAssembly.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbOpenAssembly.Name = "tsbOpenAssembly"
        Me.tsbOpenAssembly.Size = New System.Drawing.Size(111, 22)
        Me.tsbOpenAssembly.Text = "Open Assembly"
        '
        'tsbEntryPoint
        '
        Me.tsbEntryPoint.Image = CType(resources.GetObject("tsbEntryPoint.Image"), System.Drawing.Image)
        Me.tsbEntryPoint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbEntryPoint.Name = "tsbEntryPoint"
        Me.tsbEntryPoint.Size = New System.Drawing.Size(88, 22)
        Me.tsbEntryPoint.Text = "Entry Point"
        '
        'tsbConsole
        '
        Me.tsbConsole.Image = CType(resources.GetObject("tsbConsole.Image"), System.Drawing.Image)
        Me.tsbConsole.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbConsole.Name = "tsbConsole"
        Me.tsbConsole.Size = New System.Drawing.Size(69, 22)
        Me.tsbConsole.Text = "Console"
        '
        'tsbFind
        '
        Me.tsbFind.Image = CType(resources.GetObject("tsbFind.Image"), System.Drawing.Image)
        Me.tsbFind.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbFind.Name = "tsbFind"
        Me.tsbFind.Size = New System.Drawing.Size(63, 34)
        Me.tsbFind.Text = "Find"
        Me.tsbFind.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'frmResourceExplorer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(574, 403)
        Me.Controls.Add(Me.ToolStrip2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnlModules)
        Me.Controls.Add(Me.pnlTypes)
        Me.Controls.Add(Me.pnlResources)
        Me.Name = "frmResourceExplorer"
        Me.Text = "Paul's .net Resource Explorer"
        Me.pnlResources.ResumeLayout(False)
        Me.pnlTypes.ResumeLayout(False)
        Me.pnlModules.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents pnlResources As System.Windows.Forms.Panel
    Friend WithEvents pnlTypes As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents pnlModules As System.Windows.Forms.Panel
    Friend WithEvents lbModules As System.Windows.Forms.ListBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lbResources As System.Windows.Forms.ListBox
    Friend WithEvents tvTypes As System.Windows.Forms.TreeView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbExecuteMethod As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbOpenAssembly As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbEntryPoint As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbConsole As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbFind As System.Windows.Forms.ToolStripButton

End Class
