<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LETTER_NI_KRASSIE
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LETTER_NI_KRASSIE))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnMysql = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(45, 130)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(698, 114)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = resources.GetString("Label1.Text")
        '
        'btnMysql
        '
        Me.btnMysql.Location = New System.Drawing.Point(343, 291)
        Me.btnMysql.Name = "btnMysql"
        Me.btnMysql.Size = New System.Drawing.Size(307, 112)
        Me.btnMysql.TabIndex = 1
        Me.btnMysql.Text = "ENTER"
        Me.btnMysql.UseVisualStyleBackColor = True
        '
        'LETTER_NI_KRASSIE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnMysql)
        Me.Controls.Add(Me.Label1)
        Me.Name = "LETTER_NI_KRASSIE"
        Me.Text = "LETTER_NI_KRASSIE"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnMysql As Button
End Class
