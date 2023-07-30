Imports System.IO
Imports System.Security.Cryptography


Public Class frmMain

    Inherits System.Windows.Forms.Form


    'declaration des variables des coordonnées
    'declaration de nexpoint qui est de type point pour recevoir les val de coordonnées
    Dim x, y As Integer
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents picMax As PictureBox
    Dim newpoint As New Point

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents pg_statut As System.Windows.Forms.ProgressBar
    Friend WithEvents OpenFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_destination As System.Windows.Forms.Button
    Friend WithEvents txt_destination As System.Windows.Forms.TextBox
    Friend WithEvents btn_action As System.Windows.Forms.Button
    Friend WithEvents txt_password As System.Windows.Forms.TextBox
    Friend WithEvents btn_charger As System.Windows.Forms.Button
    Friend WithEvents txt_file As System.Windows.Forms.TextBox
    Friend WithEvents chkb_suppr As System.Windows.Forms.CheckBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents chkb_shutdown As System.Windows.Forms.CheckBox
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents pnlHaut As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents picClose As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents FolderBrowserDialog As System.Windows.Forms.FolderBrowserDialog
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.pg_statut = New System.Windows.Forms.ProgressBar()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.FolderBrowserDialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_destination = New System.Windows.Forms.Button()
        Me.txt_destination = New System.Windows.Forms.TextBox()
        Me.txt_password = New System.Windows.Forms.TextBox()
        Me.btn_charger = New System.Windows.Forms.Button()
        Me.txt_file = New System.Windows.Forms.TextBox()
        Me.chkb_suppr = New System.Windows.Forms.CheckBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.chkb_shutdown = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_action = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.pnlHaut = New System.Windows.Forms.Panel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.picMax = New System.Windows.Forms.PictureBox()
        Me.picClose = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.pnlHaut.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pg_statut
        '
        Me.pg_statut.Location = New System.Drawing.Point(167, 16)
        Me.pg_statut.Name = "pg_statut"
        Me.pg_statut.Size = New System.Drawing.Size(438, 19)
        Me.pg_statut.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 13)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Mot de passe :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 13)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Chemin destination :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Chemin actuel :"
        '
        'btn_destination
        '
        Me.btn_destination.BackColor = System.Drawing.Color.Gray
        Me.btn_destination.Enabled = False
        Me.btn_destination.FlatAppearance.BorderSize = 0
        Me.btn_destination.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_destination.Location = New System.Drawing.Point(507, 49)
        Me.btn_destination.Name = "btn_destination"
        Me.btn_destination.Size = New System.Drawing.Size(87, 25)
        Me.btn_destination.TabIndex = 20
        Me.btn_destination.Text = "Changer"
        Me.btn_destination.UseVisualStyleBackColor = False
        '
        'txt_destination
        '
        Me.txt_destination.Location = New System.Drawing.Point(110, 47)
        Me.txt_destination.Name = "txt_destination"
        Me.txt_destination.ReadOnly = True
        Me.txt_destination.Size = New System.Drawing.Size(390, 19)
        Me.txt_destination.TabIndex = 19
        '
        'txt_password
        '
        Me.txt_password.Location = New System.Drawing.Point(109, 73)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.Size = New System.Drawing.Size(391, 19)
        Me.txt_password.TabIndex = 17
        Me.txt_password.UseSystemPasswordChar = True
        '
        'btn_charger
        '
        Me.btn_charger.BackColor = System.Drawing.Color.Gray
        Me.btn_charger.FlatAppearance.BorderSize = 0
        Me.btn_charger.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_charger.Location = New System.Drawing.Point(507, 21)
        Me.btn_charger.Name = "btn_charger"
        Me.btn_charger.Size = New System.Drawing.Size(87, 22)
        Me.btn_charger.TabIndex = 15
        Me.btn_charger.Text = "..."
        Me.btn_charger.UseVisualStyleBackColor = False
        '
        'txt_file
        '
        Me.txt_file.Location = New System.Drawing.Point(110, 22)
        Me.txt_file.Name = "txt_file"
        Me.txt_file.ReadOnly = True
        Me.txt_file.Size = New System.Drawing.Size(390, 19)
        Me.txt_file.TabIndex = 16
        Me.txt_file.Text = "Inserez votre fichier text ici..."
        '
        'chkb_suppr
        '
        Me.chkb_suppr.AutoSize = True
        Me.chkb_suppr.Checked = True
        Me.chkb_suppr.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkb_suppr.Location = New System.Drawing.Point(12, 21)
        Me.chkb_suppr.Name = "chkb_suppr"
        Me.chkb_suppr.Size = New System.Drawing.Size(230, 17)
        Me.chkb_suppr.TabIndex = 24
        Me.chkb_suppr.Text = "Supprimer le fichier source après l'opération"
        Me.chkb_suppr.UseVisualStyleBackColor = True
        '
        'chkb_shutdown
        '
        Me.chkb_shutdown.AutoSize = True
        Me.chkb_shutdown.Location = New System.Drawing.Point(12, 42)
        Me.chkb_shutdown.Name = "chkb_shutdown"
        Me.chkb_shutdown.Size = New System.Drawing.Size(253, 17)
        Me.chkb_shutdown.TabIndex = 25
        Me.chkb_shutdown.Text = "Eteindre l'ordinateur une fois l'opération terminée"
        Me.chkb_shutdown.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(130, 13)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Progression crypt/Decrypt"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_action)
        Me.GroupBox1.Controls.Add(Me.chkb_suppr)
        Me.GroupBox1.Controls.Add(Me.chkb_shutdown)
        Me.GroupBox1.Location = New System.Drawing.Point(25, 178)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(609, 74)
        Me.GroupBox1.TabIndex = 27
        Me.GroupBox1.TabStop = False
        '
        'btn_action
        '
        Me.btn_action.BackColor = System.Drawing.Color.Gray
        Me.btn_action.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_action.Enabled = False
        Me.btn_action.FlatAppearance.BorderSize = 0
        Me.btn_action.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_action.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_action.Image = Global.Cryptal.My.Resources.Resources.key3
        Me.btn_action.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btn_action.Location = New System.Drawing.Point(299, 18)
        Me.btn_action.Name = "btn_action"
        Me.btn_action.Size = New System.Drawing.Size(304, 41)
        Me.btn_action.TabIndex = 18
        Me.btn_action.Text = "  Crypter / Décrypter"
        Me.btn_action.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_action.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_action.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txt_file)
        Me.GroupBox2.Controls.Add(Me.btn_charger)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txt_password)
        Me.GroupBox2.Controls.Add(Me.txt_destination)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.btn_destination)
        Me.GroupBox2.Location = New System.Drawing.Point(23, 45)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(609, 112)
        Me.GroupBox2.TabIndex = 26
        Me.GroupBox2.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.pg_statut)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Location = New System.Drawing.Point(23, 258)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(611, 45)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        '
        'pnlHaut
        '
        Me.pnlHaut.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnlHaut.Controls.Add(Me.LinkLabel1)
        Me.pnlHaut.Controls.Add(Me.PictureBox1)
        Me.pnlHaut.Controls.Add(Me.Label5)
        Me.pnlHaut.Controls.Add(Me.picMax)
        Me.pnlHaut.Controls.Add(Me.picClose)
        Me.pnlHaut.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHaut.Location = New System.Drawing.Point(0, 0)
        Me.pnlHaut.Name = "pnlHaut"
        Me.pnlHaut.Size = New System.Drawing.Size(644, 27)
        Me.pnlHaut.TabIndex = 28
        '
        'LinkLabel1
        '
        Me.LinkLabel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LinkLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LinkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabel1.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LinkLabel1.Location = New System.Drawing.Point(490, 7)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(101, 13)
        Me.LinkLabel1.TabIndex = 20
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Apropos du logiciel"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.Cryptal.My.Resources.Resources.Security
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(3, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(36, 27)
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.Control
        Me.Label5.Location = New System.Drawing.Point(43, 7)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "fileCrypt"
        '
        'picMax
        '
        Me.picMax.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picMax.BackgroundImage = Global.Cryptal.My.Resources.Resources.icon_minus_06
        Me.picMax.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picMax.Location = New System.Drawing.Point(599, 5)
        Me.picMax.Name = "picMax"
        Me.picMax.Size = New System.Drawing.Size(18, 18)
        Me.picMax.TabIndex = 16
        Me.picMax.TabStop = False
        '
        'picClose
        '
        Me.picClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picClose.BackgroundImage = Global.Cryptal.My.Resources.Resources.icon_close
        Me.picClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picClose.Location = New System.Drawing.Point(621, 5)
        Me.picClose.Name = "picClose"
        Me.picClose.Size = New System.Drawing.Size(18, 18)
        Me.picClose.TabIndex = 15
        Me.picClose.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 312)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(644, 4)
        Me.Panel1.TabIndex = 29
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 27)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(4, 285)
        Me.Panel2.TabIndex = 30
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(640, 27)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(4, 285)
        Me.Panel3.TabIndex = 31
        '
        'frm_Main
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 12)
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(644, 316)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnlHaut)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.714285!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frm_Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cryptal"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.pnlHaut.ResumeLayout(False)
        Me.pnlHaut.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region " Dim "

    Dim strFileToEncrypt As String
    Dim strFileToDecrypt As String
    Dim strOutputEncrypt As String
    Dim strOutputDecrypt As String
    Dim fsInput As System.IO.FileStream
    Dim fsOutput As System.IO.FileStream
    Dim TempsDepart As New Date
    Dim TempsFin As New Date
    Dim Direction As CryptoAction
    Dim ProgressValue As Integer

#End Region

#Region " Create A Key "

    Private Function CreateKey(ByVal strPassword As String) As Byte()
        'Convert strPassword to an array and store in chrData.
        Dim chrData() As Char = strPassword.ToCharArray
        'Use intLength to get strPassword size.
        Dim intLength As Integer = chrData.GetUpperBound(0)
        'Declare bytDataToHash and make it the same size as chrData.
        Dim bytDataToHash(intLength) As Byte

        'Use For Next to convert and store chrData into bytDataToHash.
        For i As Integer = 0 To chrData.GetUpperBound(0)
            bytDataToHash(i) = CByte(Asc(chrData(i)))
        Next

        'Declare what hash to use.
        Dim SHA512 As New System.Security.Cryptography.SHA512Managed
        'Declare bytResult, Hash bytDataToHash and store it in bytResult.
        Dim bytResult As Byte() = SHA512.ComputeHash(bytDataToHash)
        'Declare bytKey(31).  It will hold 256 bits.
        Dim bytKey(31) As Byte

        'Use For Next to put a specific size (256 bits) of 
        'bytResult into bytKey. The 0 To 31 will put the first 256 bits
        'of 512 bits into bytKey.
        For i As Integer = 0 To 31
            bytKey(i) = bytResult(i)
        Next

        Return bytKey 'Return the key.
    End Function

#End Region

#Region " Create An IV "

    Private Function CreateIV(ByVal strPassword As String) As Byte()
        'Convert strPassword to an array and store in chrData.
        Dim chrData() As Char = strPassword.ToCharArray
        'Use intLength to get strPassword size.
        Dim intLength As Integer = chrData.GetUpperBound(0)
        'Declare bytDataToHash and make it the same size as chrData.
        Dim bytDataToHash(intLength) As Byte

        'Use For Next to convert and store chrData into bytDataToHash.
        For i As Integer = 0 To chrData.GetUpperBound(0)
            bytDataToHash(i) = CByte(Asc(chrData(i)))
        Next

        'Declare what hash to use.
        Dim SHA512 As New System.Security.Cryptography.SHA512Managed
        'Declare bytResult, Hash bytDataToHash and store it in bytResult.
        Dim bytResult As Byte() = SHA512.ComputeHash(bytDataToHash)
        'Declare bytIV(15).  It will hold 128 bits.
        Dim bytIV(15) As Byte

        'Use For Next to put a specific size (128 bits) of 
        'bytResult into bytIV. The 0 To 30 for bytKey used the first 256 bits.
        'of the hashed password. The 32 To 47 will put the next 128 bits into bytIV.
        For i As Integer = 32 To 47
            bytIV(i - 32) = bytResult(i)
        Next

        Return bytIV 'return the IV
    End Function

#End Region

#Region " Encrypt / Decrypt "

    Private Sub btn_action_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_action.Click

        chkb_suppr.Focus()
        btn_charger.Enabled = False
        btn_destination.Enabled = False
        btn_action.Enabled = False

        If New System.IO.FileInfo(txt_file.Text).Extension = ".Vsecure" Then
            Direction = CryptoAction.ActionDecrypt ' decryptage
        Else
            Direction = CryptoAction.ActionEncrypt ' encryptage
        End If

        Dim tthread As New Threading.Thread(AddressOf EncryptOrDecryptFile)
        tthread.Start() ' demrrage du thread

    End Sub

    Private Enum CryptoAction
        'Define l'enumeration pour CryptoAction.
        ActionEncrypt = 1
        ActionDecrypt = 2
    End Enum

    Dim csCryptoStream As CryptoStream

    Sub EncryptOrDecryptFile()
        Try

            TempsDepart = Now ' calcul du temps de l'operation 

            'Setup file streams to handle input and output.
            fsInput = New System.IO.FileStream(txt_file.Text, FileMode.Open, FileAccess.Read)
            fsOutput = New System.IO.FileStream(txt_destination.Text, FileMode.OpenOrCreate, FileAccess.Write)
            fsOutput.SetLength(0) 'make sure fsOutput is empty

            'Declare variables for encrypt/decrypt process.
            Dim bytBuffer(4096) As Byte 'holds a block of bytes for processing
            Dim lngBytesProcessed As Long = 0 'running count of bytes processed
            Dim lngFileLength As Long = fsInput.Length 'the input file's length
            Dim intBytesInCurrentBlock As Integer 'current bytes being processed

            'Declare your CryptoServiceProvider.
            Dim cspRijndael As New System.Security.Cryptography.RijndaelManaged

            Dim bytKey As Byte()
            Dim bytIV As Byte()
            'Send the password to the CreateKey function.
            bytKey = CreateKey(txt_password.Text)
            'Send the password to the CreateIV function.
            bytIV = CreateIV(txt_password.Text)

            'Determine if ecryption or decryption and setup CryptoStream.
            Select Case Direction
                Case CryptoAction.ActionEncrypt
                    csCryptoStream = New CryptoStream(fsOutput, cspRijndael.CreateEncryptor(bytKey, bytIV), CryptoStreamMode.Write)

                Case CryptoAction.ActionDecrypt
                    csCryptoStream = New CryptoStream(fsOutput, cspRijndael.CreateDecryptor(bytKey, bytIV), CryptoStreamMode.Write)
            End Select

            'Use While to loop until all of the file is processed.
            While lngBytesProcessed < lngFileLength
                'Read file with the input filestream.
                intBytesInCurrentBlock = fsInput.Read(bytBuffer, 0, 4096)
                'Write output file with the cryptostream.
                csCryptoStream.Write(bytBuffer, 0, intBytesInCurrentBlock)
                'Update lngBytesProcessed
                lngBytesProcessed = lngBytesProcessed + CLng(intBytesInCurrentBlock)
                'Update Progress Bar
                ProgressValue = CInt((lngBytesProcessed / lngFileLength) * 100)
                Me.Invoke(New ProgressRefresh(AddressOf Progress))
            End While

            'Close FileStreams and CryptoStream.
            csCryptoStream.Close()
            fsInput.Close()
            fsOutput.Close()

            If chkb_suppr.Checked = True Then
                'If encrypting then delete the original unencrypted file.
                If Direction = CryptoAction.ActionEncrypt Then
                    Dim fileOriginal As New FileInfo(strFileToEncrypt)
                    fileOriginal.Delete()
                End If

                'If decrypting then delete the encrypted file.
                If Direction = CryptoAction.ActionDecrypt Then
                    Dim fileEncrypted As New FileInfo(strFileToDecrypt)
                    fileEncrypted.Delete()
                End If
            End If

            If chkb_shutdown.Checked = True Then
                System.Diagnostics.Process.Start("shutdown", "-s -f -t 100") 'Shutdown the computer
                Application.Exit() ' exit programme
            Else

                ' stop the counting
                TempsFin = Now
                'Update the user when the file is done.
                If Direction = CryptoAction.ActionEncrypt Then
                    MessageBox.Show("Cryptage du fichier terminé !" + vbCrLf + vbCrLf + "Nombre d'octets traités : " + lngBytesProcessed.ToString & vbCrLf &
                                    "Temps de l'opération : " & (TempsFin - TempsDepart).ToString, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    'Update the user when the file is done.
                    MessageBox.Show("Décryptage du fichier terminé !" + vbCrLf + vbCrLf + "Nombre d'octets traités : " + lngBytesProcessed.ToString & vbCrLf &
                                      "Temps de l'opération : " & (TempsFin - TempsDepart).ToString, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            End If

            'Catch file not found error.
        Catch When Err.Number = 53
            MessageBox.Show("Le fichier est introuvable.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)

            'Catch all other errors. And delete partial files.
        Catch
            fsInput.Close()
            fsOutput.Close()

            If Direction = CryptoAction.ActionDecrypt Then
                Dim fileDelete As New FileInfo(txt_destination.Text)
                fileDelete.Delete()
                MessageBox.Show("Le mot de passe est eronné.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim fileDelete As New FileInfo(txt_destination.Text)
                fileDelete.Delete()
                MessageBox.Show("Le fichier ne peut pas être traité.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Finally
            Me.Invoke(New OperationDone(AddressOf Done)) ' Thread is done
        End Try
    End Sub

    Private Delegate Sub ProgressRefresh()

    Sub Progress()
        pg_statut.Value = ProgressValue
    End Sub

    Private Delegate Sub OperationDone()

    Sub Done()
        'Update when Thread is done
        pg_statut.Value = 0
        txt_file.Text = "Chargez ici un fichier à traiter..."
        txt_password.Clear()
        txt_destination.Clear()
        btn_charger.Enabled = True
        btn_charger.Focus()
    End Sub

#End Region

#Region " Browse / Change Button "

    Private Sub btn_charger_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_charger.Click

        'le code ci-dessous nous dit de chargé le nom du fichier choisit dans la var charge si bien sur on & choisit 
        'quelque chose
        If OpenFileDialog.ShowDialog = DialogResult.OK Then
            charge(OpenFileDialog.FileName)
        End If
    End Sub

    Private Sub charge(ByVal fi As String)

        If System.IO.Path.GetExtension(fi) = ".Vsecure" Then
            strFileToDecrypt = fi
            txt_file.Text = strFileToDecrypt

            Dim iPosition As Integer = 0
            Dim i As Integer = 0

            While strFileToDecrypt.IndexOf("\"c, i) <> -1
                iPosition = strFileToDecrypt.IndexOf("\"c, i)
                i = iPosition + 1
            End While

            strOutputDecrypt = strFileToDecrypt.Substring(0, strFileToDecrypt.Length - 8)
            Dim S As String = strFileToDecrypt.Substring(0, iPosition + 1)
            strOutputDecrypt = strOutputDecrypt.Substring((iPosition + 1))
            txt_destination.Text = S + strOutputDecrypt.Replace("_"c, "."c)
            btn_action.Enabled = True
            btn_destination.Enabled = True
            txt_password.Focus()
        Else
            strFileToEncrypt = fi
            txt_file.Text = strFileToEncrypt

            Dim iPosition As Integer = 0
            Dim i As Integer = 0

            While strFileToEncrypt.IndexOf("\"c, i) <> -1
                iPosition = strFileToEncrypt.IndexOf("\"c, i)
                i = iPosition + 1
            End While

            strOutputEncrypt = strFileToEncrypt.Substring(iPosition + 1)
            Dim S As String = strFileToEncrypt.Substring(0, iPosition + 1)
            strOutputEncrypt = strOutputEncrypt.Replace("."c, "_"c)
            txt_destination.Text = S + strOutputEncrypt + ".Vsecure"
            btn_action.Enabled = True
            btn_destination.Enabled = True
            txt_password.Focus()
        End If

    End Sub

    Private Sub btn_destination_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_destination.Click
        If System.IO.Path.GetExtension(OpenFileDialog.FileName) = ".Vsecure" Then
            FolderBrowserDialog.Description = "Sélectionnez le dossier dans lequel placer le fichier à décrypter."
            If FolderBrowserDialog.ShowDialog = DialogResult.OK Then
                txt_destination.Text = FolderBrowserDialog.SelectedPath + "\" + strOutputDecrypt.Replace("_"c, "."c)
            End If
        Else
            FolderBrowserDialog.Description = "Sélectionnez le dossier dans lequel placer le fichier à crypter."
            If FolderBrowserDialog.ShowDialog = DialogResult.OK Then
                txt_destination.Text = FolderBrowserDialog.SelectedPath + "\" + strOutputEncrypt + ".Vsecure"
            End If
        End If
    End Sub

#End Region

#Region " Shown "

    Private Declare Function IsNTAdmin Lib "advpack.dll" (ByVal dwReserved As Integer, ByRef lpdwReserved As Integer) As Integer

    Private Sub frm_Main_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown

        For x As Double = 0 To 1 Step 0.1
            Me.Opacity = x
            System.Threading.Thread.Sleep(50) ' pour retarder un peu l'app lors du changement d'opacité
            Application.DoEvents()
        Next

        If (My.Application.CommandLineArgs.Count > 0) Then ' the encrypted file open the programme
            charge(My.Application.CommandLineArgs(0)) ' get his path
        End If

        Dim keyExist As Microsoft.Win32.RegistryKey = My.Computer.Registry.ClassesRoot.OpenSubKey(".secure", False)
        If keyExist Is Nothing Then ' key doesn't exist
            If IsNTAdmin(0&, 0&) <> 0 Then ' right Admin
                My.Computer.Registry.ClassesRoot.CreateSubKey(".Vsecure").SetValue("", ".Vsecure", Microsoft.Win32.RegistryValueKind.String)
                My.Computer.Registry.ClassesRoot.CreateSubKey("Vsecure" & "\shell\open\command").SetValue("", Application.ExecutablePath & " ""%l"" ",
                                                                          Microsoft.Win32.RegistryValueKind.String) ' combine the ext with the programme
            Else
                Me.Text = "Veuillez démarrer ce programme en tant qu'administrateur"
            End If
        End If

    End Sub

    Private Sub frm_Main_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.Control = True And e.KeyCode = Keys.D Then
            If MessageBox.Show("Vous avez appuyé sur CTRL + D, voulez-vous supprimer les clés du registre créés par ce programme ?" & vbCrLf & "L'extension .secure ne sera plus attribuée à ce programme.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If IsNTAdmin(0&, 0&) <> 0 Then
                    Try
                        My.Computer.Registry.ClassesRoot.DeleteSubKey(".Vsecure") 'delete the keys of registry for ".secure"
                        My.Computer.Registry.ClassesRoot.DeleteSubKey("Vsecure" & "\shell\open\command")
                    Catch ' keys doesn't exist ...
                    End Try
                Else ' right required
                    MessageBox.Show("Pour effectuer cette action veuillez démarrer ce programme en tant qu'administrateur.", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            End If
        End If
    End Sub

    Private Sub picMax_Click(sender As Object, e As EventArgs) Handles picMax.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub picClose_Click(sender As Object, e As EventArgs) Handles picClose.Click
        Me.Close()
    End Sub



    'fonction 
    Sub toucherglisser()
        ' mise dans l'evenement MouseDown
        ' code nous permettant de remplir les variables x et y de la position actuelle du control
        x = Control.MousePosition.X - Me.Location.X
        y = Control.MousePosition.Y - Me.Location.Y
    End Sub

    Private Sub PictureBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseDown
        toucherglisser()
    End Sub

    Private Sub Label5_MouseDown(sender As Object, e As MouseEventArgs) Handles Label5.MouseDown
        toucherglisser()
    End Sub



    Private Sub Label5_MouseMove(sender As Object, e As MouseEventArgs) Handles Label5.MouseMove
        'mise dans l'evenement MouseMove
        If e.Button = MouseButtons.Left Then
            newpoint = Control.MousePosition
            newpoint.X -= x
            newpoint.Y -= y
            Me.Location = newpoint
            Application.DoEvents()
        End If
    End Sub

    Private Sub PictureBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseMove

    End Sub

    Private Sub pnlHaut_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlHaut.MouseDown
        toucherglisser()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Opacity = 0.3
        FrmAbout.ShowDialog()
    End Sub

    Private Sub pnlHaut_MouseMove(sender As Object, e As MouseEventArgs) Handles pnlHaut.MouseMove
        'mise dans l'evenement MouseMove
        If e.Button = MouseButtons.Left Then
            newpoint = Control.MousePosition
            newpoint.X -= x
            newpoint.Y -= y
            Me.Location = newpoint
            Application.DoEvents()
        End If
    End Sub

#End Region

End Class
