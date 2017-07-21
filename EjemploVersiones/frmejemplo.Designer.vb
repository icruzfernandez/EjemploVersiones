<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmejemplo
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtmensaje = New System.Windows.Forms.TextBox()
        Me.btnmensaje = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(107, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Hola"
        '
        'txtmensaje
        '
        Me.txtmensaje.Location = New System.Drawing.Point(90, 107)
        Me.txtmensaje.Name = "txtmensaje"
        Me.txtmensaje.Size = New System.Drawing.Size(135, 20)
        Me.txtmensaje.TabIndex = 1
        '
        'btnmensaje
        '
        Me.btnmensaje.Location = New System.Drawing.Point(85, 163)
        Me.btnmensaje.Name = "btnmensaje"
        Me.btnmensaje.Size = New System.Drawing.Size(149, 44)
        Me.btnmensaje.TabIndex = 2
        Me.btnmensaje.Text = "Mostrar Mensaje"
        Me.btnmensaje.UseVisualStyleBackColor = True
        '
        'frmejemplo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.btnmensaje)
        Me.Controls.Add(Me.txtmensaje)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmejemplo"
        Me.Text = "frmejemplo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtmensaje As TextBox
    Friend WithEvents btnmensaje As Button
End Class
