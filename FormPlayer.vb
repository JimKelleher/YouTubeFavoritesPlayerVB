Public Class FormPlayer

    Dim youTubeFavorites As YouTubeFavorites.YouTubeFavorites

    Private Sub FormPlayer(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' Instantiate the Favorites :
        youTubeFavorites = New YouTubeFavorites.YouTubeFavorites

        ' Register all of the GUI controls to the Player.  NOTE: These controls will either:
        ' 1) drive on-line processing or 2) be driven by batch processing.

        youTubeFavorites.RegisterFormControls _
            (
              Me, DataGridView1,
              GroupBox1, radioButtonDataSrcYoutubeFavorites, radioButtonDataSrcJimradio, radioButtonDataSrcImportFile,
              GroupBox2, radioButtonSortDateSaved, radioButtonSortTitle, radioButtonSortRandomly,
              TextBoxChannel, textBoxSearchCriteria,
              ButtonRetrieve, ButtonSelectAll, ButtonPlay, ButtonDelete, ButtonExport
            )

        '// NOTE: the About Button requires no run-time modification

        ' Init:
        youTubeFavorites.FormLoadInit()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonRetrieve.Click

        ' Retrieve button:
        youTubeFavorites.Retrieve()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSelectAll.Click

        ' Select All button:
        youTubeFavorites.SelectAll()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonPlay.Click

        ' Play button:
        youTubeFavorites.Play()

    End Sub


    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonDelete.Click

        ' Delete button:
        youTubeFavorites.Delete()

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonExport.Click

        ' Export button:
        youTubeFavorites.ExportAsCsvFile()

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonAbout.Click

        ' Open the About window as a modal dialog:
        Dim FormAbout As FormAbout
        FormAbout = New FormAbout()
        FormAbout.ShowDialog()

    End Sub
End Class
