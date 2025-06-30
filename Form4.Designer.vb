<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form4
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Me.btninformations = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_enregistrer = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtp_facture = New System.Windows.Forms.DateTimePicker()
        Me.tbx_nomParent = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_facturer = New System.Windows.Forms.Button()
        Me.tbx_montant = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_supprimer = New System.Windows.Forms.Button()
        Me.dgv_factures = New System.Windows.Forms.DataGridView()
        Me.id_facture = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomenfantDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomparentDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MontantDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DatefactureDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ModepaiementDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatutpaiementDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FacturesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LAUGH_TALEDataSet6 = New LaughTale.LAUGH_TALEDataSet6()
        Me.cbx_statut = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cbx_modePaiement = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tbx_id = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tbx_nomEnfant = New System.Windows.Forms.TextBox()
        Me.mtbxTel = New System.Windows.Forms.MaskedTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btn_imprimer = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.EnfantsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btn_retour = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.EnfantsTableAdapter = New LaughTale.LAUGH_TALEDataSet4TableAdapters.EnfantsTableAdapter()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.FacturesTableAdapter = New LaughTale.LAUGH_TALEDataSet6TableAdapters.FacturesTableAdapter()
        Me.btn_refresh2 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.dgv_factures, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FacturesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LAUGH_TALEDataSet6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EnfantsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btninformations
        '
        Me.btninformations.BackColor = System.Drawing.Color.MediumPurple
        Me.btninformations.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btninformations.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.btninformations.FlatAppearance.BorderSize = 3
        Me.btninformations.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btninformations.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btninformations.ForeColor = System.Drawing.SystemColors.Window
        Me.btninformations.Image = Global.LaughTale.My.Resources.Resources.uPicture2
        Me.btninformations.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btninformations.Location = New System.Drawing.Point(737, 2)
        Me.btninformations.Name = "btninformations"
        Me.btninformations.Size = New System.Drawing.Size(92, 41)
        Me.btninformations.TabIndex = 50
        Me.btninformations.Text = "        Imprimer"
        Me.btninformations.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MediumPurple
        Me.Label1.Location = New System.Drawing.Point(257, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 38)
        Me.Label1.TabIndex = 52
        Me.Label1.Text = "Facturier"
        '
        'btn_enregistrer
        '
        Me.btn_enregistrer.BackColor = System.Drawing.Color.MediumPurple
        Me.btn_enregistrer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_enregistrer.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_enregistrer.FlatAppearance.BorderSize = 3
        Me.btn_enregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_enregistrer.Font = New System.Drawing.Font("Century Gothic", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_enregistrer.ForeColor = System.Drawing.SystemColors.Window
        Me.btn_enregistrer.Image = Global.LaughTale.My.Resources.Resources.Picturve4
        Me.btn_enregistrer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_enregistrer.Location = New System.Drawing.Point(236, 367)
        Me.btn_enregistrer.Name = "btn_enregistrer"
        Me.btn_enregistrer.Size = New System.Drawing.Size(101, 41)
        Me.btn_enregistrer.TabIndex = 54
        Me.btn_enregistrer.Text = "          Enregistrer"
        Me.btn_enregistrer.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(545, 84)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 57
        Me.Label4.Text = "Date: "
        '
        'dtp_facture
        '
        Me.dtp_facture.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_facture.Location = New System.Drawing.Point(587, 78)
        Me.dtp_facture.Name = "dtp_facture"
        Me.dtp_facture.Size = New System.Drawing.Size(95, 20)
        Me.dtp_facture.TabIndex = 58
        '
        'tbx_nomParent
        '
        Me.tbx_nomParent.Location = New System.Drawing.Point(235, 122)
        Me.tbx_nomParent.Name = "tbx_nomParent"
        Me.tbx_nomParent.Size = New System.Drawing.Size(355, 20)
        Me.tbx_nomParent.TabIndex = 59
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btn_refresh2)
        Me.Panel1.Controls.Add(Me.btn_facturer)
        Me.Panel1.Controls.Add(Me.tbx_montant)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.btn_supprimer)
        Me.Panel1.Controls.Add(Me.dgv_factures)
        Me.Panel1.Controls.Add(Me.cbx_statut)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.cbx_modePaiement)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.tbx_id)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.tbx_nomEnfant)
        Me.Panel1.Controls.Add(Me.mtbxTel)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.btn_imprimer)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.PictureBox4)
        Me.Panel1.Controls.Add(Me.tbx_nomParent)
        Me.Panel1.Controls.Add(Me.dtp_facture)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.btn_enregistrer)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(316, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(694, 582)
        Me.Panel1.TabIndex = 51
        '
        'btn_facturer
        '
        Me.btn_facturer.BackColor = System.Drawing.Color.MediumPurple
        Me.btn_facturer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_facturer.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_facturer.FlatAppearance.BorderSize = 3
        Me.btn_facturer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_facturer.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_facturer.ForeColor = System.Drawing.SystemColors.Window
        Me.btn_facturer.Image = Global.LaughTale.My.Resources.Resources.Pictu
        Me.btn_facturer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_facturer.Location = New System.Drawing.Point(8, 420)
        Me.btn_facturer.Name = "btn_facturer"
        Me.btn_facturer.Size = New System.Drawing.Size(126, 58)
        Me.btn_facturer.TabIndex = 92
        Me.btn_facturer.Text = "          Générer" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "          La Facture"
        Me.btn_facturer.UseVisualStyleBackColor = False
        '
        'tbx_montant
        '
        Me.tbx_montant.Location = New System.Drawing.Point(236, 258)
        Me.tbx_montant.Name = "tbx_montant"
        Me.tbx_montant.Size = New System.Drawing.Size(355, 20)
        Me.tbx_montant.TabIndex = 91
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.MediumPurple
        Me.Label2.Location = New System.Drawing.Point(18, 259)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 16)
        Me.Label2.TabIndex = 90
        Me.Label2.Text = "Montant* :"
        '
        'btn_supprimer
        '
        Me.btn_supprimer.BackColor = System.Drawing.Color.White
        Me.btn_supprimer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_supprimer.FlatAppearance.BorderColor = System.Drawing.Color.Turquoise
        Me.btn_supprimer.FlatAppearance.BorderSize = 3
        Me.btn_supprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_supprimer.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_supprimer.ForeColor = System.Drawing.Color.MediumPurple
        Me.btn_supprimer.Image = Global.LaughTale.My.Resources.Resources.Picturev2
        Me.btn_supprimer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_supprimer.Location = New System.Drawing.Point(574, 367)
        Me.btn_supprimer.Name = "btn_supprimer"
        Me.btn_supprimer.Size = New System.Drawing.Size(108, 41)
        Me.btn_supprimer.TabIndex = 89
        Me.btn_supprimer.Text = "          Supprimer"
        Me.btn_supprimer.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_supprimer.UseVisualStyleBackColor = False
        '
        'dgv_factures
        '
        Me.dgv_factures.AutoGenerateColumns = False
        Me.dgv_factures.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_factures.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_facture, Me.NomenfantDataGridViewTextBoxColumn, Me.NomparentDataGridViewTextBoxColumn, Me.MontantDataGridViewTextBoxColumn, Me.DatefactureDataGridViewTextBoxColumn, Me.ModepaiementDataGridViewTextBoxColumn, Me.StatutpaiementDataGridViewTextBoxColumn})
        Me.dgv_factures.DataSource = Me.FacturesBindingSource
        Me.dgv_factures.Location = New System.Drawing.Point(140, 420)
        Me.dgv_factures.Name = "dgv_factures"
        Me.dgv_factures.Size = New System.Drawing.Size(542, 150)
        Me.dgv_factures.TabIndex = 88
        '
        'id_facture
        '
        Me.id_facture.DataPropertyName = "id_facture"
        Me.id_facture.HeaderText = "N° FACTURE"
        Me.id_facture.Name = "id_facture"
        Me.id_facture.ReadOnly = True
        '
        'NomenfantDataGridViewTextBoxColumn
        '
        Me.NomenfantDataGridViewTextBoxColumn.DataPropertyName = "nom_enfant"
        Me.NomenfantDataGridViewTextBoxColumn.HeaderText = "Nom de l'enfant"
        Me.NomenfantDataGridViewTextBoxColumn.Name = "NomenfantDataGridViewTextBoxColumn"
        '
        'NomparentDataGridViewTextBoxColumn
        '
        Me.NomparentDataGridViewTextBoxColumn.DataPropertyName = "nom_parent"
        Me.NomparentDataGridViewTextBoxColumn.HeaderText = "Nom du Parent"
        Me.NomparentDataGridViewTextBoxColumn.Name = "NomparentDataGridViewTextBoxColumn"
        '
        'MontantDataGridViewTextBoxColumn
        '
        Me.MontantDataGridViewTextBoxColumn.DataPropertyName = "montant"
        Me.MontantDataGridViewTextBoxColumn.HeaderText = "Montant"
        Me.MontantDataGridViewTextBoxColumn.Name = "MontantDataGridViewTextBoxColumn"
        '
        'DatefactureDataGridViewTextBoxColumn
        '
        Me.DatefactureDataGridViewTextBoxColumn.DataPropertyName = "date_facture"
        Me.DatefactureDataGridViewTextBoxColumn.HeaderText = "Date de Facture"
        Me.DatefactureDataGridViewTextBoxColumn.Name = "DatefactureDataGridViewTextBoxColumn"
        '
        'ModepaiementDataGridViewTextBoxColumn
        '
        Me.ModepaiementDataGridViewTextBoxColumn.DataPropertyName = "mode_paiement"
        Me.ModepaiementDataGridViewTextBoxColumn.HeaderText = "Mode de Paiement"
        Me.ModepaiementDataGridViewTextBoxColumn.Name = "ModepaiementDataGridViewTextBoxColumn"
        '
        'StatutpaiementDataGridViewTextBoxColumn
        '
        Me.StatutpaiementDataGridViewTextBoxColumn.DataPropertyName = "statut_paiement"
        Me.StatutpaiementDataGridViewTextBoxColumn.HeaderText = "Statut"
        Me.StatutpaiementDataGridViewTextBoxColumn.Name = "StatutpaiementDataGridViewTextBoxColumn"
        '
        'FacturesBindingSource
        '
        Me.FacturesBindingSource.DataMember = "Factures"
        Me.FacturesBindingSource.DataSource = Me.LAUGH_TALEDataSet6
        '
        'LAUGH_TALEDataSet6
        '
        Me.LAUGH_TALEDataSet6.DataSetName = "LAUGH_TALEDataSet6"
        Me.LAUGH_TALEDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cbx_statut
        '
        Me.cbx_statut.FormattingEnabled = True
        Me.cbx_statut.Items.AddRange(New Object() {"Payée", "Impayée"})
        Me.cbx_statut.Location = New System.Drawing.Point(236, 326)
        Me.cbx_statut.Name = "cbx_statut"
        Me.cbx_statut.Size = New System.Drawing.Size(121, 21)
        Me.cbx_statut.TabIndex = 87
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.MediumPurple
        Me.Label12.Location = New System.Drawing.Point(16, 326)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(60, 16)
        Me.Label12.TabIndex = 86
        Me.Label12.Text = "Statut*: "
        '
        'cbx_modePaiement
        '
        Me.cbx_modePaiement.FormattingEnabled = True
        Me.cbx_modePaiement.Items.AddRange(New Object() {"Espèce", "Paiement Mobile", "Virement"})
        Me.cbx_modePaiement.Location = New System.Drawing.Point(236, 287)
        Me.cbx_modePaiement.Name = "cbx_modePaiement"
        Me.cbx_modePaiement.Size = New System.Drawing.Size(121, 21)
        Me.cbx_modePaiement.TabIndex = 85
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.MediumPurple
        Me.Label11.Location = New System.Drawing.Point(16, 287)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(155, 16)
        Me.Label11.TabIndex = 84
        Me.Label11.Text = "Mode de Paiement *: "
        '
        'tbx_id
        '
        Me.tbx_id.Location = New System.Drawing.Point(235, 228)
        Me.tbx_id.Name = "tbx_id"
        Me.tbx_id.Size = New System.Drawing.Size(355, 20)
        Me.tbx_id.TabIndex = 83
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.MediumPurple
        Me.Label10.Location = New System.Drawing.Point(15, 228)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(112, 16)
        Me.Label10.TabIndex = 82
        Me.Label10.Text = "ID de l'enfant* :"
        '
        'tbx_nomEnfant
        '
        Me.tbx_nomEnfant.Location = New System.Drawing.Point(235, 159)
        Me.tbx_nomEnfant.Name = "tbx_nomEnfant"
        Me.tbx_nomEnfant.Size = New System.Drawing.Size(355, 20)
        Me.tbx_nomEnfant.TabIndex = 74
        '
        'mtbxTel
        '
        Me.mtbxTel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.mtbxTel.Location = New System.Drawing.Point(235, 191)
        Me.mtbxTel.Mask = "+000 000 000 000"
        Me.mtbxTel.Name = "mtbxTel"
        Me.mtbxTel.Size = New System.Drawing.Size(181, 20)
        Me.mtbxTel.TabIndex = 72
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.MediumPurple
        Me.Label9.Location = New System.Drawing.Point(18, 195)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(170, 16)
        Me.Label9.TabIndex = 71
        Me.Label9.Text = "Numéro de téléphone* :"
        '
        'btn_imprimer
        '
        Me.btn_imprimer.BackColor = System.Drawing.Color.MediumPurple
        Me.btn_imprimer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_imprimer.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_imprimer.FlatAppearance.BorderSize = 3
        Me.btn_imprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_imprimer.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_imprimer.ForeColor = System.Drawing.SystemColors.Window
        Me.btn_imprimer.Image = Global.LaughTale.My.Resources.Resources.uPicture2
        Me.btn_imprimer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_imprimer.Location = New System.Drawing.Point(590, 6)
        Me.btn_imprimer.Name = "btn_imprimer"
        Me.btn_imprimer.Size = New System.Drawing.Size(92, 41)
        Me.btn_imprimer.TabIndex = 64
        Me.btn_imprimer.Text = "        Imprimer"
        Me.btn_imprimer.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.MediumPurple
        Me.Label5.Location = New System.Drawing.Point(18, 159)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(129, 16)
        Me.Label5.TabIndex = 63
        Me.Label5.Text = "Nom de l'enfant* :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Impact", 15.75!)
        Me.Label7.ForeColor = System.Drawing.Color.MediumPurple
        Me.Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label7.Location = New System.Drawing.Point(75, 4)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 26)
        Me.Label7.TabIndex = 61
        Me.Label7.Text = "Laugh Tale"
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox4.Location = New System.Drawing.Point(1, 1)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(71, 67)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 60
        Me.PictureBox4.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.MediumPurple
        Me.Label3.Location = New System.Drawing.Point(18, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(167, 16)
        Me.Label3.TabIndex = 56
        Me.Label3.Text = "Nom du Parent/Client* :"
        '
        'btn_retour
        '
        Me.btn_retour.BackColor = System.Drawing.Color.Transparent
        Me.btn_retour.BackgroundImage = Global.LaughTale.My.Resources.Resources._89032260_retour_flèche_icône_isolé_sur_le_bouton_violet_violet_abstrait_illustration_removebg_preview
        Me.btn_retour.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_retour.Location = New System.Drawing.Point(0, -1)
        Me.btn_retour.Name = "btn_retour"
        Me.btn_retour.Size = New System.Drawing.Size(44, 43)
        Me.btn_retour.TabIndex = 52
        Me.btn_retour.UseVisualStyleBackColor = False
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'EnfantsTableAdapter
        '
        Me.EnfantsTableAdapter.ClearBeforeFill = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.LaughTale.My.Resources.Resources.Pictuure2
        Me.PictureBox1.Location = New System.Drawing.Point(-9, 155)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(320, 428)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 53
        Me.PictureBox1.TabStop = False
        '
        'FacturesTableAdapter
        '
        Me.FacturesTableAdapter.ClearBeforeFill = True
        '
        'btn_refresh2
        '
        Me.btn_refresh2.BackColor = System.Drawing.Color.White
        Me.btn_refresh2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_refresh2.FlatAppearance.BorderColor = System.Drawing.Color.Turquoise
        Me.btn_refresh2.FlatAppearance.BorderSize = 3
        Me.btn_refresh2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_refresh2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_refresh2.ForeColor = System.Drawing.Color.DodgerBlue
        Me.btn_refresh2.Image = Global.LaughTale.My.Resources.Resources._2Picture1
        Me.btn_refresh2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_refresh2.Location = New System.Drawing.Point(421, 366)
        Me.btn_refresh2.Name = "btn_refresh2"
        Me.btn_refresh2.Size = New System.Drawing.Size(108, 41)
        Me.btn_refresh2.TabIndex = 93
        Me.btn_refresh2.Text = "          Actualiser"
        Me.btn_refresh2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_refresh2.UseVisualStyleBackColor = False
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackgroundImage = Global.LaughTale.My.Resources.Resources.vecteezy_minimal_background_purple_color_with_two_overlapping_waves_12847554
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1010, 582)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btn_retour)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btninformations)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
        Me.Text = "Facturation"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgv_factures, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FacturesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LAUGH_TALEDataSet6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EnfantsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents btninformations As Button
    Friend WithEvents Label1 As Label
    Private WithEvents btn_enregistrer As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents dtp_facture As DateTimePicker
    Friend WithEvents tbx_nomParent As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents btn_retour As Button
    Private WithEvents btn_imprimer As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents EnfantsBindingSource As BindingSource
    Friend WithEvents EnfantsTableAdapter As LAUGH_TALEDataSet4TableAdapters.EnfantsTableAdapter
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents mtbxTel As MaskedTextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents tbx_nomEnfant As TextBox
    Friend WithEvents tbx_id As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents cbx_modePaiement As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents cbx_statut As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents dgv_factures As DataGridView
    Private WithEvents btn_supprimer As Button
    Friend WithEvents tbx_montant As TextBox
    Friend WithEvents Label2 As Label
    Private WithEvents btn_facturer As Button
    Friend WithEvents LAUGH_TALEDataSet6 As LAUGH_TALEDataSet6
    Friend WithEvents FacturesBindingSource As BindingSource
    Friend WithEvents FacturesTableAdapter As LAUGH_TALEDataSet6TableAdapters.FacturesTableAdapter
    Friend WithEvents id_facture As DataGridViewTextBoxColumn
    Friend WithEvents NomenfantDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NomparentDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MontantDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DatefactureDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ModepaiementDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StatutpaiementDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Private WithEvents btn_refresh2 As Button
End Class
