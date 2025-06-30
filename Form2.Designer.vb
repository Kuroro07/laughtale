<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmb_sexe = New System.Windows.Forms.ComboBox()
        Me.cmb_role = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.btn_inscription = New System.Windows.Forms.Button()
        Me.tbx_pseudo = New System.Windows.Forms.TextBox()
        Me.tbx_firstname = New System.Windows.Forms.TextBox()
        Me.tbx_lastname = New System.Windows.Forms.TextBox()
        Me.tbx_password2 = New System.Windows.Forms.TextBox()
        Me.tbx_password3 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.AutoSize = True
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.cmb_sexe)
        Me.GroupBox1.Controls.Add(Me.cmb_role)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.LinkLabel1)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.MaskedTextBox1)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.btn_inscription)
        Me.GroupBox1.Controls.Add(Me.tbx_pseudo)
        Me.GroupBox1.Controls.Add(Me.tbx_firstname)
        Me.GroupBox1.Controls.Add(Me.tbx_lastname)
        Me.GroupBox1.Controls.Add(Me.tbx_password2)
        Me.GroupBox1.Controls.Add(Me.tbx_password3)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(401, -1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(458, 592)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'cmb_sexe
        '
        Me.cmb_sexe.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_sexe.FormattingEnabled = True
        Me.cmb_sexe.Items.AddRange(New Object() {"Masculin", "Féminin"})
        Me.cmb_sexe.Location = New System.Drawing.Point(122, 328)
        Me.cmb_sexe.Name = "cmb_sexe"
        Me.cmb_sexe.Size = New System.Drawing.Size(121, 21)
        Me.cmb_sexe.TabIndex = 28
        '
        'cmb_role
        '
        Me.cmb_role.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_role.FormattingEnabled = True
        Me.cmb_role.Items.AddRange(New Object() {"Administrateur", "Employé"})
        Me.cmb_role.Location = New System.Drawing.Point(122, 414)
        Me.cmb_role.Name = "cmb_role"
        Me.cmb_role.Size = New System.Drawing.Size(121, 21)
        Me.cmb_role.TabIndex = 27
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.MediumPurple
        Me.Label13.Location = New System.Drawing.Point(36, 414)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(54, 16)
        Me.Label13.TabIndex = 26
        Me.Label13.Text = "Role* :"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(271, 531)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(84, 13)
        Me.LinkLabel1.TabIndex = 25
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Connectez-vous"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(100, 531)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(164, 13)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "Vous avez déjà un compte?"
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MaskedTextBox1.Location = New System.Drawing.Point(236, 366)
        Me.MaskedTextBox1.Mask = "+000 000 000 000"
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(181, 20)
        Me.MaskedTextBox1.TabIndex = 23
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(204, 162)
        Me.DateTimePicker1.MaxDate = New Date(2007, 12, 31, 0, 0, 0, 0)
        Me.DateTimePicker1.MinDate = New Date(1950, 1, 1, 0, 0, 0, 0)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(202, 20)
        Me.DateTimePicker1.TabIndex = 19
        Me.DateTimePicker1.Value = New Date(2007, 12, 31, 0, 0, 0, 0)
        '
        'btn_inscription
        '
        Me.btn_inscription.BackColor = System.Drawing.Color.MediumPurple
        Me.btn_inscription.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_inscription.ForeColor = System.Drawing.Color.GhostWhite
        Me.btn_inscription.Location = New System.Drawing.Point(163, 473)
        Me.btn_inscription.Name = "btn_inscription"
        Me.btn_inscription.Size = New System.Drawing.Size(139, 42)
        Me.btn_inscription.TabIndex = 18
        Me.btn_inscription.Text = "S'inscrire"
        Me.btn_inscription.UseVisualStyleBackColor = False
        '
        'tbx_pseudo
        '
        Me.tbx_pseudo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbx_pseudo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_pseudo.Location = New System.Drawing.Point(130, 213)
        Me.tbx_pseudo.Name = "tbx_pseudo"
        Me.tbx_pseudo.Size = New System.Drawing.Size(313, 13)
        Me.tbx_pseudo.TabIndex = 17
        '
        'tbx_firstname
        '
        Me.tbx_firstname.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbx_firstname.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_firstname.Location = New System.Drawing.Point(103, 81)
        Me.tbx_firstname.Name = "tbx_firstname"
        Me.tbx_firstname.Size = New System.Drawing.Size(340, 13)
        Me.tbx_firstname.TabIndex = 16
        '
        'tbx_lastname
        '
        Me.tbx_lastname.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbx_lastname.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_lastname.Location = New System.Drawing.Point(105, 125)
        Me.tbx_lastname.Name = "tbx_lastname"
        Me.tbx_lastname.Size = New System.Drawing.Size(338, 13)
        Me.tbx_lastname.TabIndex = 15
        '
        'tbx_password2
        '
        Me.tbx_password2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbx_password2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_password2.Location = New System.Drawing.Point(168, 246)
        Me.tbx_password2.Name = "tbx_password2"
        Me.tbx_password2.Size = New System.Drawing.Size(275, 13)
        Me.tbx_password2.TabIndex = 13
        Me.tbx_password2.UseSystemPasswordChar = True
        '
        'tbx_password3
        '
        Me.tbx_password3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbx_password3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_password3.Location = New System.Drawing.Point(242, 285)
        Me.tbx_password3.Name = "tbx_password3"
        Me.tbx_password3.Size = New System.Drawing.Size(201, 13)
        Me.tbx_password3.TabIndex = 12
        Me.tbx_password3.UseSystemPasswordChar = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.MediumPurple
        Me.Label10.Location = New System.Drawing.Point(34, 122)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(74, 16)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Prénom: *"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.MediumPurple
        Me.Label9.Location = New System.Drawing.Point(34, 370)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(176, 16)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Numéro de Téléphone: *"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.MediumPurple
        Me.Label7.Location = New System.Drawing.Point(34, 211)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 16)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Pseudo: *"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.MediumPurple
        Me.Label6.Location = New System.Drawing.Point(34, 333)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 16)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Sexe: *"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.MediumPurple
        Me.Label5.Location = New System.Drawing.Point(34, 285)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(199, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Confirmer le Mot dePasse: *"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.MediumPurple
        Me.Label4.Location = New System.Drawing.Point(34, 162)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(154, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Date de Naissance: *"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.MediumPurple
        Me.Label3.Location = New System.Drawing.Point(34, 246)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Mot de Passe: *"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.MediumPurple
        Me.Label2.Location = New System.Drawing.Point(34, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nom: *"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MediumPurple
        Me.Label1.Location = New System.Drawing.Point(125, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(214, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Créer un Compte"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Impact", 15.75!)
        Me.Label11.ForeColor = System.Drawing.Color.Transparent
        Me.Label11.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label11.Location = New System.Drawing.Point(68, -1)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(104, 26)
        Me.Label11.TabIndex = 42
        Me.Label11.Text = "Laugh Tale"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.LaughTale.My.Resources.Resources.two_african_girls_hug_and_laugh_ai_generated_photo_removebg_preview
        Me.PictureBox1.Location = New System.Drawing.Point(-1, 236)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(401, 336)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 43
        Me.PictureBox1.TabStop = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label12.Location = New System.Drawing.Point(3, 108)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(261, 66)
        Me.Label12.TabIndex = 44
        Me.Label12.Text = "Rejoignez l'équipe " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "de Laugh Tale !"
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox4.Location = New System.Drawing.Point(0, -1)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(71, 67)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 45
        Me.PictureBox4.TabStop = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.LaughTale.My.Resources.Resources.vecteezy_minimal_background_purple_color_with_two_overlapping_waves_12847554
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(856, 571)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form2"
        Me.Text = "Création de Compte"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tbx_pseudo As TextBox
    Friend WithEvents tbx_firstname As TextBox
    Friend WithEvents tbx_lastname As TextBox
    Friend WithEvents tbx_password2 As TextBox
    Friend WithEvents tbx_password3 As TextBox
    Friend WithEvents btn_inscription As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents MaskedTextBox1 As MaskedTextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label11 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label12 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents cmb_role As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents cmb_sexe As ComboBox
End Class
