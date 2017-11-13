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
        Me.lblGrupoA = New System.Windows.Forms.Label()
        Me.txtGrupoB = New System.Windows.Forms.TextBox()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.txtGrupoA = New System.Windows.Forms.TextBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.lblGrupoB = New System.Windows.Forms.Label()
        Me.grpA = New System.Windows.Forms.GroupBox()
        Me.grpB = New System.Windows.Forms.GroupBox()
        Me.lblNumPerdidos = New System.Windows.Forms.Label()
        Me.txtNumPerdidos = New System.Windows.Forms.TextBox()
        Me.lblMax = New System.Windows.Forms.Label()
        Me.lblMin = New System.Windows.Forms.Label()
        Me.txtMaximo = New System.Windows.Forms.TextBox()
        Me.txtMinimo = New System.Windows.Forms.TextBox()
        Me.grpA.SuspendLayout()
        Me.grpB.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblGrupoA
        '
        Me.lblGrupoA.AutoSize = True
        Me.lblGrupoA.Location = New System.Drawing.Point(7, 38)
        Me.lblGrupoA.Name = "lblGrupoA"
        Me.lblGrupoA.Size = New System.Drawing.Size(46, 13)
        Me.lblGrupoA.TabIndex = 2
        Me.lblGrupoA.Text = "Grupo A"
        '
        'txtGrupoB
        '
        Me.txtGrupoB.Location = New System.Drawing.Point(73, 32)
        Me.txtGrupoB.Name = "txtGrupoB"
        Me.txtGrupoB.Size = New System.Drawing.Size(308, 20)
        Me.txtGrupoB.TabIndex = 0
        Me.txtGrupoB.Text = "203 204 204 205 206 207 205 208 203 206 205 206 204"
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(90, 370)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(75, 23)
        Me.btnNuevo.TabIndex = 11
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'txtGrupoA
        '
        Me.txtGrupoA.Location = New System.Drawing.Point(73, 35)
        Me.txtGrupoA.Name = "txtGrupoA"
        Me.txtGrupoA.Size = New System.Drawing.Size(308, 20)
        Me.txtGrupoA.TabIndex = 0
        Me.txtGrupoA.Text = "203 204 205 206 207 208 203 204 205 206"
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(274, 370)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 8
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(180, 370)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 7
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'lblGrupoB
        '
        Me.lblGrupoB.AutoSize = True
        Me.lblGrupoB.Location = New System.Drawing.Point(7, 35)
        Me.lblGrupoB.Name = "lblGrupoB"
        Me.lblGrupoB.Size = New System.Drawing.Size(46, 13)
        Me.lblGrupoB.TabIndex = 3
        Me.lblGrupoB.Text = "Grupo B"
        '
        'grpA
        '
        Me.grpA.Controls.Add(Me.lblGrupoA)
        Me.grpA.Controls.Add(Me.txtGrupoA)
        Me.grpA.Location = New System.Drawing.Point(24, 24)
        Me.grpA.Name = "grpA"
        Me.grpA.Size = New System.Drawing.Size(426, 105)
        Me.grpA.TabIndex = 9
        Me.grpA.TabStop = False
        Me.grpA.Text = "Grupo A"
        '
        'grpB
        '
        Me.grpB.Controls.Add(Me.lblGrupoB)
        Me.grpB.Controls.Add(Me.txtGrupoB)
        Me.grpB.Location = New System.Drawing.Point(24, 135)
        Me.grpB.Name = "grpB"
        Me.grpB.Size = New System.Drawing.Size(426, 100)
        Me.grpB.TabIndex = 10
        Me.grpB.TabStop = False
        Me.grpB.Text = "Grupo B"
        '
        'lblNumPerdidos
        '
        Me.lblNumPerdidos.AutoSize = True
        Me.lblNumPerdidos.Location = New System.Drawing.Point(31, 253)
        Me.lblNumPerdidos.Name = "lblNumPerdidos"
        Me.lblNumPerdidos.Size = New System.Drawing.Size(92, 13)
        Me.lblNumPerdidos.TabIndex = 12
        Me.lblNumPerdidos.Text = "Números perdidos"
        '
        'txtNumPerdidos
        '
        Me.txtNumPerdidos.Location = New System.Drawing.Point(24, 270)
        Me.txtNumPerdidos.Name = "txtNumPerdidos"
        Me.txtNumPerdidos.Size = New System.Drawing.Size(426, 20)
        Me.txtNumPerdidos.TabIndex = 13
        '
        'lblMax
        '
        Me.lblMax.AutoSize = True
        Me.lblMax.Location = New System.Drawing.Point(21, 297)
        Me.lblMax.Name = "lblMax"
        Me.lblMax.Size = New System.Drawing.Size(71, 13)
        Me.lblMax.TabIndex = 14
        Me.lblMax.Text = "Num. Máximo"
        '
        'lblMin
        '
        Me.lblMin.AutoSize = True
        Me.lblMin.Location = New System.Drawing.Point(177, 297)
        Me.lblMin.Name = "lblMin"
        Me.lblMin.Size = New System.Drawing.Size(68, 13)
        Me.lblMin.TabIndex = 15
        Me.lblMin.Text = "Num. Minimo"
        '
        'txtMaximo
        '
        Me.txtMaximo.Location = New System.Drawing.Point(24, 313)
        Me.txtMaximo.Name = "txtMaximo"
        Me.txtMaximo.Size = New System.Drawing.Size(100, 20)
        Me.txtMaximo.TabIndex = 16
        '
        'txtMinimo
        '
        Me.txtMinimo.Location = New System.Drawing.Point(180, 313)
        Me.txtMinimo.Name = "txtMinimo"
        Me.txtMinimo.Size = New System.Drawing.Size(100, 20)
        Me.txtMinimo.TabIndex = 17
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(481, 443)
        Me.Controls.Add(Me.txtMinimo)
        Me.Controls.Add(Me.txtMaximo)
        Me.Controls.Add(Me.lblMin)
        Me.Controls.Add(Me.lblMax)
        Me.Controls.Add(Me.txtNumPerdidos)
        Me.Controls.Add(Me.lblNumPerdidos)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.grpA)
        Me.Controls.Add(Me.grpB)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.grpA.ResumeLayout(False)
        Me.grpA.PerformLayout()
        Me.grpB.ResumeLayout(False)
        Me.grpB.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblGrupoA As System.Windows.Forms.Label
    Friend WithEvents txtGrupoB As System.Windows.Forms.TextBox
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents txtGrupoA As System.Windows.Forms.TextBox
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents lblGrupoB As System.Windows.Forms.Label
    Friend WithEvents grpA As System.Windows.Forms.GroupBox
    Friend WithEvents grpB As System.Windows.Forms.GroupBox
    Friend WithEvents lblNumPerdidos As System.Windows.Forms.Label
    Friend WithEvents txtNumPerdidos As System.Windows.Forms.TextBox
    Friend WithEvents lblMax As System.Windows.Forms.Label
    Friend WithEvents lblMin As System.Windows.Forms.Label
    Friend WithEvents txtMaximo As System.Windows.Forms.TextBox
    Friend WithEvents txtMinimo As System.Windows.Forms.TextBox
End Class
