<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.AxActUtlType1 = New AxActUtlTypeLib.AxActUtlType()
        Me.cmdOpen = New System.Windows.Forms.Button()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.cmdOn = New System.Windows.Forms.Button()
        Me.cmdOff = New System.Windows.Forms.Button()
        CType(Me.AxActUtlType1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AxActUtlType1
        '
        Me.AxActUtlType1.Enabled = True
        Me.AxActUtlType1.Location = New System.Drawing.Point(240, 12)
        Me.AxActUtlType1.Name = "AxActUtlType1"
        Me.AxActUtlType1.OcxState = CType(resources.GetObject("AxActUtlType1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxActUtlType1.Size = New System.Drawing.Size(32, 32)
        Me.AxActUtlType1.TabIndex = 0
        '
        'cmdOpen
        '
        Me.cmdOpen.Location = New System.Drawing.Point(23, 73)
        Me.cmdOpen.Name = "cmdOpen"
        Me.cmdOpen.Size = New System.Drawing.Size(75, 23)
        Me.cmdOpen.TabIndex = 1
        Me.cmdOpen.Text = "Open"
        Me.cmdOpen.UseVisualStyleBackColor = True
        '
        'cmdClose
        '
        Me.cmdClose.Location = New System.Drawing.Point(128, 73)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(75, 23)
        Me.cmdClose.TabIndex = 2
        Me.cmdClose.Text = "Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'cmdOn
        '
        Me.cmdOn.Location = New System.Drawing.Point(23, 126)
        Me.cmdOn.Name = "cmdOn"
        Me.cmdOn.Size = New System.Drawing.Size(75, 23)
        Me.cmdOn.TabIndex = 3
        Me.cmdOn.Text = "Y0 ON"
        Me.cmdOn.UseVisualStyleBackColor = True
        '
        'cmdOff
        '
        Me.cmdOff.Location = New System.Drawing.Point(128, 125)
        Me.cmdOff.Name = "cmdOff"
        Me.cmdOff.Size = New System.Drawing.Size(75, 23)
        Me.cmdOff.TabIndex = 4
        Me.cmdOff.Text = "Y0 OFF"
        Me.cmdOff.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.cmdOff)
        Me.Controls.Add(Me.cmdOn)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdOpen)
        Me.Controls.Add(Me.AxActUtlType1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.AxActUtlType1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents AxActUtlType1 As AxActUtlTypeLib.AxActUtlType
    Friend WithEvents cmdOpen As Button
    Friend WithEvents cmdClose As Button
    Friend WithEvents cmdOn As Button
    Friend WithEvents cmdOff As Button
End Class
