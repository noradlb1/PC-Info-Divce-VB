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
        Me.hddspace = New System.Windows.Forms.Label()
        Me.processor = New System.Windows.Forms.Label()
        Me.admin = New System.Windows.Forms.Label()
        Me.ram = New System.Windows.Forms.Label()
        Me.os = New System.Windows.Forms.Label()
        Me.pcname = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'hddspace
        '
        Me.hddspace.AutoSize = True
        Me.hddspace.Location = New System.Drawing.Point(12, 124)
        Me.hddspace.Name = "hddspace"
        Me.hddspace.Size = New System.Drawing.Size(89, 13)
        Me.hddspace.TabIndex = 17
        Me.hddspace.Text = "Harddisk Space: "
        '
        'processor
        '
        Me.processor.AutoSize = True
        Me.processor.Location = New System.Drawing.Point(12, 98)
        Me.processor.Name = "processor"
        Me.processor.Size = New System.Drawing.Size(16, 13)
        Me.processor.TabIndex = 16
        Me.processor.Text = "..."
        '
        'admin
        '
        Me.admin.AutoSize = True
        Me.admin.Location = New System.Drawing.Point(12, 75)
        Me.admin.Name = "admin"
        Me.admin.Size = New System.Drawing.Size(73, 13)
        Me.admin.TabIndex = 15
        Me.admin.Text = "Administrator: "
        '
        'ram
        '
        Me.ram.AutoSize = True
        Me.ram.Location = New System.Drawing.Point(12, 53)
        Me.ram.Name = "ram"
        Me.ram.Size = New System.Drawing.Size(37, 13)
        Me.ram.TabIndex = 14
        Me.ram.Text = "RAM: "
        '
        'os
        '
        Me.os.AutoSize = True
        Me.os.Location = New System.Drawing.Point(12, 31)
        Me.os.Name = "os"
        Me.os.Size = New System.Drawing.Size(28, 13)
        Me.os.TabIndex = 13
        Me.os.Text = "OS: "
        '
        'pcname
        '
        Me.pcname.AutoSize = True
        Me.pcname.Location = New System.Drawing.Point(12, 9)
        Me.pcname.Name = "pcname"
        Me.pcname.Size = New System.Drawing.Size(58, 13)
        Me.pcname.TabIndex = 12
        Me.pcname.Text = "PC Name: "
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(288, 146)
        Me.Controls.Add(Me.hddspace)
        Me.Controls.Add(Me.processor)
        Me.Controls.Add(Me.admin)
        Me.Controls.Add(Me.ram)
        Me.Controls.Add(Me.os)
        Me.Controls.Add(Me.pcname)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents hddspace As Label
    Friend WithEvents processor As Label
    Friend WithEvents admin As Label
    Friend WithEvents ram As Label
    Friend WithEvents os As Label
    Friend WithEvents pcname As Label
End Class
