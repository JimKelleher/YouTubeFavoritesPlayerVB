<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPlayer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPlayer))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.radioButtonDataSrcYoutubeFavorites = New System.Windows.Forms.RadioButton()
        Me.radioButtonDataSrcJimradio = New System.Windows.Forms.RadioButton()
        Me.radioButtonDataSrcImportFile = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxChannel = New System.Windows.Forms.TextBox()
        Me.radioButtonSortDateSaved = New System.Windows.Forms.RadioButton()
        Me.radioButtonSortTitle = New System.Windows.Forms.RadioButton()
        Me.radioButtonSortRandomly = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.textBoxSearchCriteria = New System.Windows.Forms.TextBox()
        Me.ButtonRetrieve = New System.Windows.Forms.Button()
        Me.ButtonSelectAll = New System.Windows.Forms.Button()
        Me.ButtonPlay = New System.Windows.Forms.Button()
        Me.ButtonExport = New System.Windows.Forms.Button()
        Me.ButtonAbout = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ButtonDelete = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(16, 25)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(39, 33)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(289, 19)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(76, 20)
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(523, 10)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(26, 36)
        Me.PictureBox3.TabIndex = 2
        Me.PictureBox3.TabStop = False
        '
        'radioButtonDataSrcYoutubeFavorites
        '
        Me.radioButtonDataSrcYoutubeFavorites.AutoSize = True
        Me.radioButtonDataSrcYoutubeFavorites.Location = New System.Drawing.Point(64, 19)
        Me.radioButtonDataSrcYoutubeFavorites.Name = "radioButtonDataSrcYoutubeFavorites"
        Me.radioButtonDataSrcYoutubeFavorites.Size = New System.Drawing.Size(115, 17)
        Me.radioButtonDataSrcYoutubeFavorites.TabIndex = 0
        Me.radioButtonDataSrcYoutubeFavorites.TabStop = True
        Me.radioButtonDataSrcYoutubeFavorites.Text = "YouTube Favorites"
        Me.radioButtonDataSrcYoutubeFavorites.UseVisualStyleBackColor = True
        '
        'radioButtonDataSrcJimradio
        '
        Me.radioButtonDataSrcJimradio.AutoSize = True
        Me.radioButtonDataSrcJimradio.Location = New System.Drawing.Point(374, 19)
        Me.radioButtonDataSrcJimradio.Name = "radioButtonDataSrcJimradio"
        Me.radioButtonDataSrcJimradio.Size = New System.Drawing.Size(133, 17)
        Me.radioButtonDataSrcJimradio.TabIndex = 3
        Me.radioButtonDataSrcJimradio.TabStop = True
        Me.radioButtonDataSrcJimradio.Text = "JimRadio (hosted SQL)"
        Me.radioButtonDataSrcJimradio.UseVisualStyleBackColor = True
        '
        'radioButtonDataSrcImportFile
        '
        Me.radioButtonDataSrcImportFile.AutoSize = True
        Me.radioButtonDataSrcImportFile.Location = New System.Drawing.Point(561, 19)
        Me.radioButtonDataSrcImportFile.Name = "radioButtonDataSrcImportFile"
        Me.radioButtonDataSrcImportFile.Size = New System.Drawing.Size(73, 17)
        Me.radioButtonDataSrcImportFile.TabIndex = 4
        Me.radioButtonDataSrcImportFile.TabStop = True
        Me.radioButtonDataSrcImportFile.Text = "Import File"
        Me.radioButtonDataSrcImportFile.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TextBoxChannel)
        Me.GroupBox1.Controls.Add(Me.radioButtonDataSrcYoutubeFavorites)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.PictureBox2)
        Me.GroupBox1.Controls.Add(Me.PictureBox3)
        Me.GroupBox1.Controls.Add(Me.radioButtonDataSrcImportFile)
        Me.GroupBox1.Controls.Add(Me.radioButtonDataSrcJimradio)
        Me.GroupBox1.Location = New System.Drawing.Point(5, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(645, 70)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data Source"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(79, 44)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Channel:"
        '
        'TextBoxChannel
        '
        Me.TextBoxChannel.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxChannel.Location = New System.Drawing.Point(134, 41)
        Me.TextBoxChannel.Name = "TextBoxChannel"
        Me.TextBoxChannel.Size = New System.Drawing.Size(135, 18)
        Me.TextBoxChannel.TabIndex = 2
        '
        'radioButtonSortDateSaved
        '
        Me.radioButtonSortDateSaved.AutoSize = True
        Me.radioButtonSortDateSaved.Location = New System.Drawing.Point(12, 19)
        Me.radioButtonSortDateSaved.Name = "radioButtonSortDateSaved"
        Me.radioButtonSortDateSaved.Size = New System.Drawing.Size(92, 17)
        Me.radioButtonSortDateSaved.TabIndex = 0
        Me.radioButtonSortDateSaved.TabStop = True
        Me.radioButtonSortDateSaved.Text = "by date saved"
        Me.radioButtonSortDateSaved.UseVisualStyleBackColor = True
        '
        'radioButtonSortTitle
        '
        Me.radioButtonSortTitle.AutoSize = True
        Me.radioButtonSortTitle.Location = New System.Drawing.Point(123, 19)
        Me.radioButtonSortTitle.Name = "radioButtonSortTitle"
        Me.radioButtonSortTitle.Size = New System.Drawing.Size(55, 17)
        Me.radioButtonSortTitle.TabIndex = 1
        Me.radioButtonSortTitle.TabStop = True
        Me.radioButtonSortTitle.Text = "by title"
        Me.radioButtonSortTitle.UseVisualStyleBackColor = True
        '
        'radioButtonSortRandomly
        '
        Me.radioButtonSortRandomly.AutoSize = True
        Me.radioButtonSortRandomly.Location = New System.Drawing.Point(199, 19)
        Me.radioButtonSortRandomly.Name = "radioButtonSortRandomly"
        Me.radioButtonSortRandomly.Size = New System.Drawing.Size(67, 17)
        Me.radioButtonSortRandomly.TabIndex = 2
        Me.radioButtonSortRandomly.TabStop = True
        Me.radioButtonSortRandomly.Text = "randomly"
        Me.radioButtonSortRandomly.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.radioButtonSortRandomly)
        Me.GroupBox2.Controls.Add(Me.radioButtonSortTitle)
        Me.GroupBox2.Controls.Add(Me.radioButtonSortDateSaved)
        Me.GroupBox2.Location = New System.Drawing.Point(7, 81)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(286, 52)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Sort"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(308, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(210, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Enter search criteria separated by commas:"
        '
        'textBoxSearchCriteria
        '
        Me.textBoxSearchCriteria.Location = New System.Drawing.Point(312, 99)
        Me.textBoxSearchCriteria.Multiline = True
        Me.textBoxSearchCriteria.Name = "textBoxSearchCriteria"
        Me.textBoxSearchCriteria.Size = New System.Drawing.Size(337, 33)
        Me.textBoxSearchCriteria.TabIndex = 3
        '
        'ButtonRetrieve
        '
        Me.ButtonRetrieve.Location = New System.Drawing.Point(8, 143)
        Me.ButtonRetrieve.Name = "ButtonRetrieve"
        Me.ButtonRetrieve.Size = New System.Drawing.Size(56, 23)
        Me.ButtonRetrieve.TabIndex = 4
        Me.ButtonRetrieve.Text = "Retrieve"
        Me.ButtonRetrieve.UseVisualStyleBackColor = True
        '
        'ButtonSelectAll
        '
        Me.ButtonSelectAll.Location = New System.Drawing.Point(70, 143)
        Me.ButtonSelectAll.Name = "ButtonSelectAll"
        Me.ButtonSelectAll.Size = New System.Drawing.Size(60, 23)
        Me.ButtonSelectAll.TabIndex = 5
        Me.ButtonSelectAll.Text = "Select All"
        Me.ButtonSelectAll.UseVisualStyleBackColor = True
        '
        'ButtonPlay
        '
        Me.ButtonPlay.Location = New System.Drawing.Point(135, 143)
        Me.ButtonPlay.Name = "ButtonPlay"
        Me.ButtonPlay.Size = New System.Drawing.Size(36, 23)
        Me.ButtonPlay.TabIndex = 6
        Me.ButtonPlay.Text = "Play"
        Me.ButtonPlay.UseVisualStyleBackColor = True
        '
        'ButtonExport
        '
        Me.ButtonExport.Location = New System.Drawing.Point(231, 143)
        Me.ButtonExport.Name = "ButtonExport"
        Me.ButtonExport.Size = New System.Drawing.Size(45, 23)
        Me.ButtonExport.TabIndex = 8
        Me.ButtonExport.Text = "Export"
        Me.ButtonExport.UseVisualStyleBackColor = True
        '
        'ButtonAbout
        '
        Me.ButtonAbout.Location = New System.Drawing.Point(283, 143)
        Me.ButtonAbout.Name = "ButtonAbout"
        Me.ButtonAbout.Size = New System.Drawing.Size(44, 23)
        Me.ButtonAbout.TabIndex = 9
        Me.ButtonAbout.Text = "About"
        Me.ButtonAbout.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(6, 174)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DataGridView1.Size = New System.Drawing.Size(324, 509)
        Me.DataGridView1.TabIndex = 10
        '
        'ButtonDelete
        '
        Me.ButtonDelete.Location = New System.Drawing.Point(177, 143)
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.Size = New System.Drawing.Size(47, 23)
        Me.ButtonDelete.TabIndex = 7
        Me.ButtonDelete.Text = "Delete"
        Me.ButtonDelete.UseVisualStyleBackColor = True
        '
        'FormPlayer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(656, 702)
        Me.Controls.Add(Me.ButtonDelete)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ButtonAbout)
        Me.Controls.Add(Me.ButtonExport)
        Me.Controls.Add(Me.ButtonPlay)
        Me.Controls.Add(Me.ButtonSelectAll)
        Me.Controls.Add(Me.ButtonRetrieve)
        Me.Controls.Add(Me.textBoxSearchCriteria)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormPlayer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents radioButtonDataSrcYoutubeFavorites As System.Windows.Forms.RadioButton
    Friend WithEvents radioButtonDataSrcJimradio As System.Windows.Forms.RadioButton
    Friend WithEvents radioButtonDataSrcImportFile As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents radioButtonSortDateSaved As System.Windows.Forms.RadioButton
    Friend WithEvents radioButtonSortTitle As System.Windows.Forms.RadioButton
    Friend WithEvents radioButtonSortRandomly As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents textBoxSearchCriteria As System.Windows.Forms.TextBox
    Friend WithEvents ButtonRetrieve As System.Windows.Forms.Button
    Friend WithEvents ButtonSelectAll As System.Windows.Forms.Button
    Friend WithEvents ButtonPlay As System.Windows.Forms.Button
    Friend WithEvents ButtonExport As System.Windows.Forms.Button
    Friend WithEvents ButtonAbout As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBoxChannel As TextBox
    Friend WithEvents ButtonDelete As Button
End Class
