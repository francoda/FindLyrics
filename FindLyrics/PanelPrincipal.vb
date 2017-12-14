Imports FindLyrics.Models

Public Class PanelPrincipal

    Public Sub New()
        InitializeComponent()
        CancioneroBindingSource.DataSource = Cancionero.values
    End Sub



End Class
