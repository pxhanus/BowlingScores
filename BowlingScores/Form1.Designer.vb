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
        Me.lblDisplay = New System.Windows.Forms.Label()
        Me.btnEnterScores = New System.Windows.Forms.Button()
        Me.btnStatistics = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblDisplay
        '
        Me.lblDisplay.Location = New System.Drawing.Point(12, 30)
        Me.lblDisplay.Name = "lblDisplay"
        Me.lblDisplay.Size = New System.Drawing.Size(268, 44)
        Me.lblDisplay.TabIndex = 0
        '
        'btnEnterScores
        '
        Me.btnEnterScores.Location = New System.Drawing.Point(47, 77)
        Me.btnEnterScores.Name = "btnEnterScores"
        Me.btnEnterScores.Size = New System.Drawing.Size(80, 25)
        Me.btnEnterScores.TabIndex = 1
        Me.btnEnterScores.Text = "Enter Scores"
        Me.btnEnterScores.UseVisualStyleBackColor = True
        '
        'btnStatistics
        '
        Me.btnStatistics.Location = New System.Drawing.Point(165, 77)
        Me.btnStatistics.Name = "btnStatistics"
        Me.btnStatistics.Size = New System.Drawing.Size(80, 25)
        Me.btnStatistics.TabIndex = 2
        Me.btnStatistics.Text = "Statistics"
        Me.btnStatistics.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 113)
        Me.Controls.Add(Me.btnStatistics)
        Me.Controls.Add(Me.btnEnterScores)
        Me.Controls.Add(Me.lblDisplay)
        Me.Name = "Form1"
        Me.Text = "Bowling Scores"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblDisplay As Label
    Friend WithEvents btnEnterScores As Button
    Friend WithEvents btnStatistics As Button
End Class
