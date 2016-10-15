Class MainWindow 

    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        Me.Close()
    End Sub


    Private Sub Ellipse_MouseDown(sender As Object, e As MouseButtonEventArgs)
        Me.DragMove()
    End Sub

End Class
