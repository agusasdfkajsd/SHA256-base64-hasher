<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.encript = New System.Windows.Forms.Button()
        Me.input = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.output = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.info = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'encript
        '
        Me.encript.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.encript.Location = New System.Drawing.Point(441, 90)
        Me.encript.Name = "encript"
        Me.encript.Size = New System.Drawing.Size(75, 23)
        Me.encript.TabIndex = 0
        Me.encript.Text = "Encriptar"
        Me.encript.UseVisualStyleBackColor = True
        '
        'input
        '
        Me.input.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.input.Location = New System.Drawing.Point(89, 9)
        Me.input.Name = "input"
        Me.input.Size = New System.Drawing.Size(427, 20)
        Me.input.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Texto:"
        '
        'output
        '
        Me.output.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.output.Location = New System.Drawing.Point(89, 35)
        Me.output.Name = "output"
        Me.output.ReadOnly = True
        Me.output.Size = New System.Drawing.Size(427, 20)
        Me.output.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Resultado: "
        '
        'info
        '
        Me.info.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.info.AutoSize = True
        Me.info.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.info.ForeColor = System.Drawing.Color.Navy
        Me.info.Location = New System.Drawing.Point(12, 94)
        Me.info.Name = "info"
        Me.info.Size = New System.Drawing.Size(194, 15)
        Me.info.TabIndex = 5
        Me.info.Text = "SHA256, b64 hasher - Agustín Perez"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(528, 118)
        Me.Controls.Add(Me.info)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.output)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.input)
        Me.Controls.Add(Me.encript)
        Me.MaximumSize = New System.Drawing.Size(1920, 157)
        Me.MinimumSize = New System.Drawing.Size(544, 157)
        Me.Name = "Form1"
        Me.Text = "Hasher"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents encript As Button
    Friend WithEvents input As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents output As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents info As Label
End Class
