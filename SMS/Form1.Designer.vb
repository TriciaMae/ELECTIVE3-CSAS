<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SMS_Form
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.mob_num = New System.Windows.Forms.TextBox()
        Me.msg = New System.Windows.Forms.TextBox()
        Me.SendBtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.api = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.DarkGray
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.Label2.Location = New System.Drawing.Point(30, 136)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(248, 39)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Mobile Number"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.DarkGray
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.Label3.Location = New System.Drawing.Point(30, 269)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(155, 39)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Message"
        '
        'mob_num
        '
        Me.mob_num.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.mob_num.Location = New System.Drawing.Point(373, 136)
        Me.mob_num.Name = "mob_num"
        Me.mob_num.Size = New System.Drawing.Size(355, 45)
        Me.mob_num.TabIndex = 2
        '
        'msg
        '
        Me.msg.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.msg.Location = New System.Drawing.Point(373, 243)
        Me.msg.Multiline = True
        Me.msg.Name = "msg"
        Me.msg.Size = New System.Drawing.Size(355, 156)
        Me.msg.TabIndex = 3
        '
        'SendBtn
        '
        Me.SendBtn.BackColor = System.Drawing.Color.DimGray
        Me.SendBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.SendBtn.Location = New System.Drawing.Point(317, 429)
        Me.SendBtn.Name = "SendBtn"
        Me.SendBtn.Size = New System.Drawing.Size(94, 40)
        Me.SendBtn.TabIndex = 4
        Me.SendBtn.Text = "Send"
        Me.SendBtn.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.DarkGray
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.Label1.Location = New System.Drawing.Point(30, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 39)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "API Code"
        '
        'api
        '
        Me.api.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.api.Location = New System.Drawing.Point(373, 51)
        Me.api.Name = "api"
        Me.api.Size = New System.Drawing.Size(355, 45)
        Me.api.TabIndex = 6
        '
        'SMS_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(800, 503)
        Me.Controls.Add(Me.api)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SendBtn)
        Me.Controls.Add(Me.msg)
        Me.Controls.Add(Me.mob_num)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Name = "SMS_Form"
        Me.Text = "Send SMS"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents mob_num As TextBox
    Friend WithEvents msg As TextBox
    Friend WithEvents SendBtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents api As TextBox
End Class
