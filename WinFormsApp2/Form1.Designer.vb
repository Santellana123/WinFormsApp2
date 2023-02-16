<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NOMBRE1 = New System.Windows.Forms.TextBox()
        Me.NOMBRE2 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(202, 117)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(130, 64)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "GUARDAD"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(240, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "NOMBRE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(240, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "TELEFONO "
        '
        'NOMBRE1
        '
        Me.NOMBRE1.Location = New System.Drawing.Point(171, 25)
        Me.NOMBRE1.Name = "NOMBRE1"
        Me.NOMBRE1.Size = New System.Drawing.Size(201, 23)
        Me.NOMBRE1.TabIndex = 3
        '
        'NOMBRE2
        '
        Me.NOMBRE2.Location = New System.Drawing.Point(171, 88)
        Me.NOMBRE2.Name = "NOMBRE2"
        Me.NOMBRE2.Size = New System.Drawing.Size(201, 23)
        Me.NOMBRE2.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.NOMBRE2)
        Me.Controls.Add(Me.NOMBRE1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents NOMBRE1 As TextBox
    Friend WithEvents NOMBRE2 As TextBox
End Class
