<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PanelPrincipal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PanelPrincipal))
        Me.iconoDesk = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.CancioneroBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.CancioneroBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'iconoDesk
        '
        Me.iconoDesk.BalloonTipTitle = "FindLyrics"
        Me.iconoDesk.Icon = CType(resources.GetObject("iconoDesk.Icon"), System.Drawing.Icon)
        Me.iconoDesk.Text = "icono"
        Me.iconoDesk.Visible = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CancioneroBindingSource, "values", True))
        Me.RichTextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBox1.Location = New System.Drawing.Point(0, 0)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(284, 261)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = ""
        '
        'CancioneroBindingSource
        '
        Me.CancioneroBindingSource.DataSource = GetType(FindLyrics.Models.Cancionero)
        '
        'PanelPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "PanelPrincipal"
        Me.ShowInTaskbar = False
        Me.Text = "FindLyrics"
        CType(Me.CancioneroBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents iconoDesk As NotifyIcon
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents CancioneroBindingSource As BindingSource
End Class
