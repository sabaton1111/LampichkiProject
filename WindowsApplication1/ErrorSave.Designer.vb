<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ErrorSave
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.NoButton = New System.Windows.Forms.Button()
        Me.ExitTextLabel = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.Error1
        Me.PictureBox1.Location = New System.Drawing.Point(32, 26)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(50, 51)
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'NoButton
        '
        Me.NoButton.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.ButtonTexture
        Me.NoButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NoButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.NoButton.Location = New System.Drawing.Point(415, 85)
        Me.NoButton.Name = "NoButton"
        Me.NoButton.Size = New System.Drawing.Size(198, 42)
        Me.NoButton.TabIndex = 7
        Me.NoButton.Text = "ОК"
        Me.NoButton.UseVisualStyleBackColor = True
        '
        'ExitTextLabel
        '
        Me.ExitTextLabel.AutoSize = True
        Me.ExitTextLabel.BackColor = System.Drawing.Color.Transparent
        Me.ExitTextLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ExitTextLabel.Location = New System.Drawing.Point(101, 32)
        Me.ExitTextLabel.Name = "ExitTextLabel"
        Me.ExitTextLabel.Size = New System.Drawing.Size(443, 36)
        Me.ExitTextLabel.TabIndex = 8
        Me.ExitTextLabel.Text = "Грешка! Моля проверете дали сте въвели Вашето име," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Вашето презиме и Вашата фамил" & _
    "ия!"
        '
        'ErrorSave
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.MsgBoxBackground
        Me.ClientSize = New System.Drawing.Size(625, 139)
        Me.Controls.Add(Me.ExitTextLabel)
        Me.Controls.Add(Me.NoButton)
        Me.Controls.Add(Me.PictureBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ErrorSave"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Грешка"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents NoButton As System.Windows.Forms.Button
    Friend WithEvents ExitTextLabel As System.Windows.Forms.Label
End Class
