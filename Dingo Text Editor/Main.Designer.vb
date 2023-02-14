<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.menustrip = New System.Windows.Forms.MenuStrip()
        Me.tsFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.toNew = New System.Windows.Forms.ToolStripMenuItem()
        Me.toOpen = New System.Windows.Forms.ToolStripMenuItem()
        Me.toSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.toSaveAs = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.toExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.toUndo = New System.Windows.Forms.ToolStripMenuItem()
        Me.toRedo = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.toCopy = New System.Windows.Forms.ToolStripMenuItem()
        Me.toPaste = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.toCut = New System.Windows.Forms.ToolStripMenuItem()
        Me.toClear = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsFont = New System.Windows.Forms.ToolStripMenuItem()
        Me.toStyle = New System.Windows.Forms.ToolStripMenuItem()
        Me.toColor = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.toHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.toAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtText = New System.Windows.Forms.RichTextBox()
        Me.otSellectAll = New System.Windows.Forms.ToolStripMenuItem()
        Me.menustrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'menustrip
        '
        Me.menustrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsFile, Me.tsEdit, Me.tsFont, Me.tsHelp})
        Me.menustrip.Location = New System.Drawing.Point(0, 0)
        Me.menustrip.Name = "menustrip"
        Me.menustrip.Size = New System.Drawing.Size(624, 24)
        Me.menustrip.TabIndex = 0
        Me.menustrip.Text = "MenuStrip1"
        '
        'tsFile
        '
        Me.tsFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toNew, Me.toOpen, Me.toSave, Me.toSaveAs, Me.ToolStripSeparator1, Me.toExit})
        Me.tsFile.Name = "tsFile"
        Me.tsFile.Size = New System.Drawing.Size(37, 20)
        Me.tsFile.Text = "File"
        '
        'toNew
        '
        Me.toNew.Name = "toNew"
        Me.toNew.Size = New System.Drawing.Size(114, 22)
        Me.toNew.Text = "New"
        '
        'toOpen
        '
        Me.toOpen.Name = "toOpen"
        Me.toOpen.Size = New System.Drawing.Size(114, 22)
        Me.toOpen.Text = "Open"
        '
        'toSave
        '
        Me.toSave.Name = "toSave"
        Me.toSave.Size = New System.Drawing.Size(114, 22)
        Me.toSave.Text = "Save"
        '
        'toSaveAs
        '
        Me.toSaveAs.Name = "toSaveAs"
        Me.toSaveAs.Size = New System.Drawing.Size(114, 22)
        Me.toSaveAs.Text = "Save As"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(111, 6)
        '
        'toExit
        '
        Me.toExit.Name = "toExit"
        Me.toExit.Size = New System.Drawing.Size(114, 22)
        Me.toExit.Text = "Exit"
        '
        'tsEdit
        '
        Me.tsEdit.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toUndo, Me.toRedo, Me.ToolStripSeparator2, Me.toCopy, Me.toPaste, Me.ToolStripSeparator3, Me.toCut, Me.toClear, Me.otSellectAll})
        Me.tsEdit.Name = "tsEdit"
        Me.tsEdit.Size = New System.Drawing.Size(39, 20)
        Me.tsEdit.Text = "Edit"
        '
        'toUndo
        '
        Me.toUndo.Name = "toUndo"
        Me.toUndo.Size = New System.Drawing.Size(152, 22)
        Me.toUndo.Text = "Undo"
        '
        'toRedo
        '
        Me.toRedo.Name = "toRedo"
        Me.toRedo.Size = New System.Drawing.Size(152, 22)
        Me.toRedo.Text = "Redu"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(149, 6)
        '
        'toCopy
        '
        Me.toCopy.Name = "toCopy"
        Me.toCopy.Size = New System.Drawing.Size(152, 22)
        Me.toCopy.Text = "Copy"
        '
        'toPaste
        '
        Me.toPaste.Name = "toPaste"
        Me.toPaste.Size = New System.Drawing.Size(152, 22)
        Me.toPaste.Text = "Paste"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(149, 6)
        '
        'toCut
        '
        Me.toCut.Name = "toCut"
        Me.toCut.Size = New System.Drawing.Size(152, 22)
        Me.toCut.Text = "Cut"
        '
        'toClear
        '
        Me.toClear.Name = "toClear"
        Me.toClear.Size = New System.Drawing.Size(152, 22)
        Me.toClear.Text = "Clear"
        '
        'tsFont
        '
        Me.tsFont.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toStyle, Me.toColor})
        Me.tsFont.Name = "tsFont"
        Me.tsFont.Size = New System.Drawing.Size(43, 20)
        Me.tsFont.Text = "Font"
        '
        'toStyle
        '
        Me.toStyle.Name = "toStyle"
        Me.toStyle.Size = New System.Drawing.Size(152, 22)
        Me.toStyle.Text = "Style"
        '
        'toColor
        '
        Me.toColor.Name = "toColor"
        Me.toColor.Size = New System.Drawing.Size(152, 22)
        Me.toColor.Text = "Color"
        '
        'tsHelp
        '
        Me.tsHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toHelp, Me.toAbout})
        Me.tsHelp.Name = "tsHelp"
        Me.tsHelp.Size = New System.Drawing.Size(44, 20)
        Me.tsHelp.Text = "Help"
        '
        'toHelp
        '
        Me.toHelp.Name = "toHelp"
        Me.toHelp.Size = New System.Drawing.Size(152, 22)
        Me.toHelp.Text = "Help"
        '
        'toAbout
        '
        Me.toAbout.Name = "toAbout"
        Me.toAbout.Size = New System.Drawing.Size(152, 22)
        Me.toAbout.Text = "About"
        '
        'txtText
        '
        Me.txtText.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtText.Location = New System.Drawing.Point(0, 24)
        Me.txtText.Name = "txtText"
        Me.txtText.Size = New System.Drawing.Size(624, 417)
        Me.txtText.TabIndex = 1
        Me.txtText.Text = ""
        '
        'otSellectAll
        '
        Me.otSellectAll.Name = "otSellectAll"
        Me.otSellectAll.Size = New System.Drawing.Size(152, 22)
        Me.otSellectAll.Text = "Select All"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 441)
        Me.Controls.Add(Me.txtText)
        Me.Controls.Add(Me.menustrip)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.menustrip
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dingo Text Editor"
        Me.menustrip.ResumeLayout(False)
        Me.menustrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents menustrip As System.Windows.Forms.MenuStrip
    Friend WithEvents tsFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsHelp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtText As System.Windows.Forms.RichTextBox
    Friend WithEvents tsFont As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toHelp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toAbout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toNew As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toOpen As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toSave As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toSaveAs As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents toExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toUndo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toRedo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents toCopy As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toPaste As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents toClear As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toStyle As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toCut As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents otSellectAll As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents toColor As System.Windows.Forms.ToolStripMenuItem

End Class
