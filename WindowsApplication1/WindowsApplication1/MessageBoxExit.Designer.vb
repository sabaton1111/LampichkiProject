<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MessageBoxExit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MessageBoxExit))
        Me.ExitTextLabel = New System.Windows.Forms.Label()
        Me.YesButton = New System.Windows.Forms.Button()
        Me.NoButton = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ExitTextLabel
        '
        Me.ExitTextLabel.AutoSize = True
        Me.ExitTextLabel.BackColor = System.Drawing.Color.Transparent
        Me.ExitTextLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ExitTextLabel.Location = New System.Drawing.Point(101, 32)
        Me.ExitTextLabel.Name = "ExitTextLabel"
        Me.ExitTextLabel.Size = New System.Drawing.Size(500, 36)
        Me.ExitTextLabel.TabIndex = 0
        Me.ExitTextLabel.Text = "Сигурни ли сте, че искате да излезнете от програмата? " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Ако не сте запазили Вашит" & _
    "е резултати, те ще бъдат изгубени!"
        '
        'YesButton
        '
        Me.YesButton.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.rsz_download
        Me.YesButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.YesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.YesButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.YesButton.Location = New System.Drawing.Point(199, 85)
        Me.YesButton.Name = "YesButton"
        Me.YesButton.Size = New System.Drawing.Size(198, 42)
        Me.YesButton.TabIndex = 1
        Me.YesButton.Text = "Да"
        Me.YesButton.UseVisualStyleBackColor = True
        '
        'NoButton
        '
        Me.NoButton.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.rsz_download
        Me.NoButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NoButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.NoButton.Location = New System.Drawing.Point(403, 85)
        Me.NoButton.Name = "NoButton"
        Me.NoButton.Size = New System.Drawing.Size(198, 42)
        Me.NoButton.TabIndex = 2
        Me.NoButton.Text = "Не"
        Me.NoButton.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.rsz_1warning_sign
        Me.PictureBox1.Location = New System.Drawing.Point(32, 26)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'MessageBoxExit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.rsz_1rsz_gray_blue_background_texture
        Me.ClientSize = New System.Drawing.Size(625, 139)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.NoButton)
        Me.Controls.Add(Me.YesButton)
        Me.Controls.Add(Me.ExitTextLabel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MessageBoxExit"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Изход"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ExitTextLabel As System.Windows.Forms.Label
    Friend WithEvents YesButton As System.Windows.Forms.Button
    Friend WithEvents NoButton As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
