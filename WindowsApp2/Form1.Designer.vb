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
        Me.registrationButton = New System.Windows.Forms.Button()
        Me.executionButton = New System.Windows.Forms.Button()
        Me.installationButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'registrationButton
        '
        Me.registrationButton.Location = New System.Drawing.Point(41, 69)
        Me.registrationButton.Name = "registrationButton"
        Me.registrationButton.Size = New System.Drawing.Size(147, 23)
        Me.registrationButton.TabIndex = 1
        Me.registrationButton.Text = "Test Registration"
        Me.registrationButton.UseVisualStyleBackColor = True
        '
        'executionButton
        '
        Me.executionButton.Location = New System.Drawing.Point(41, 302)
        Me.executionButton.Name = "executionButton"
        Me.executionButton.Size = New System.Drawing.Size(147, 23)
        Me.executionButton.TabIndex = 2
        Me.executionButton.Text = "Test Execution"
        Me.executionButton.UseVisualStyleBackColor = True
        '
        'installationButton
        '
        Me.installationButton.Location = New System.Drawing.Point(41, 164)
        Me.installationButton.Name = "installationButton"
        Me.installationButton.Size = New System.Drawing.Size(147, 23)
        Me.installationButton.TabIndex = 3
        Me.installationButton.Text = "Test Installation"
        Me.installationButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.installationButton)
        Me.Controls.Add(Me.executionButton)
        Me.Controls.Add(Me.registrationButton)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents registrationButton As Button
    Friend WithEvents executionButton As Button
    Friend WithEvents installationButton As Button
End Class
