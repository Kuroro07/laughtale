<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btn_notif = New System.Windows.Forms.Button()
        Me.btndeconnexion = New System.Windows.Forms.Button()
        Me.btninformations = New System.Windows.Forms.Button()
        Me.btnadmissions = New System.Windows.Forms.Button()
        Me.btnaccueil = New System.Windows.Forms.Button()
        Me.dgvEnfants = New System.Windows.Forms.DataGridView()
        Me.id_enfant = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomenfantDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrenomenfantDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DatenaissanceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SexeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomparentDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.adresse = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelparentDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Numeroparent2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhotoDataGridViewImageColumn = New System.Windows.Forms.DataGridViewImageColumn()
        Me.HeurearriveeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HeuredepartDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EnfantsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.LAUGH_TALEDataSet5 = New LaughTale.LAUGH_TALEDataSet5()
        Me.EnfantsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LAUGH_TALEDataSet2 = New LaughTale.LAUGH_TALEDataSet2()
        Me.LAUGHTALEDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LAUGH_TALEDataSet = New LaughTale.LAUGH_TALEDataSet()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.EnfantsTableAdapter = New LaughTale.LAUGH_TALEDataSet2TableAdapters.EnfantsTableAdapter()
        Me.btn_supprimer = New System.Windows.Forms.Button()
        Me.EnfantsTableAdapter1 = New LaughTale.LAUGH_TALEDataSet5TableAdapters.EnfantsTableAdapter()
        Me.btn_refresh = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvEnfants, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EnfantsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LAUGH_TALEDataSet5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EnfantsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LAUGH_TALEDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LAUGHTALEDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LAUGH_TALEDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.PictureBox4)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel1.Controls.Add(Me.btn_notif)
        Me.Panel1.Controls.Add(Me.btndeconnexion)
        Me.Panel1.Controls.Add(Me.btninformations)
        Me.Panel1.Controls.Add(Me.btnadmissions)
        Me.Panel1.Controls.Add(Me.btnaccueil)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(244, 524)
        Me.Panel1.TabIndex = 43
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox4.Location = New System.Drawing.Point(0, -2)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(71, 67)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 53
        Me.PictureBox4.TabStop = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Impact", 15.75!)
        Me.Label11.ForeColor = System.Drawing.Color.MediumPurple
        Me.Label11.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label11.Location = New System.Drawing.Point(68, -2)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(104, 26)
        Me.Label11.TabIndex = 52
        Me.Label11.Text = "Laugh Tale"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 8
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 65.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(241, 169)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(599, 353)
        Me.TableLayoutPanel1.TabIndex = 45
        '
        'btn_notif
        '
        Me.btn_notif.BackColor = System.Drawing.Color.MediumPurple
        Me.btn_notif.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_notif.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_notif.FlatAppearance.BorderSize = 3
        Me.btn_notif.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_notif.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_notif.ForeColor = System.Drawing.SystemColors.Window
        Me.btn_notif.Image = Global.LaughTale.My.Resources.Resources.Picture81
        Me.btn_notif.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_notif.Location = New System.Drawing.Point(1, 336)
        Me.btn_notif.Name = "btn_notif"
        Me.btn_notif.Size = New System.Drawing.Size(163, 61)
        Me.btn_notif.TabIndex = 48
        Me.btn_notif.Text = "            Notifications"
        Me.btn_notif.UseVisualStyleBackColor = False
        '
        'btndeconnexion
        '
        Me.btndeconnexion.BackColor = System.Drawing.Color.MediumPurple
        Me.btndeconnexion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btndeconnexion.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.btndeconnexion.FlatAppearance.BorderSize = 3
        Me.btndeconnexion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndeconnexion.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndeconnexion.ForeColor = System.Drawing.SystemColors.Window
        Me.btndeconnexion.Image = Global.LaughTale.My.Resources.Resources.Pic4ture2
        Me.btndeconnexion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btndeconnexion.Location = New System.Drawing.Point(1, 419)
        Me.btndeconnexion.Name = "btndeconnexion"
        Me.btndeconnexion.Size = New System.Drawing.Size(163, 61)
        Me.btndeconnexion.TabIndex = 51
        Me.btndeconnexion.Text = "          Déconnexion"
        Me.btndeconnexion.UseVisualStyleBackColor = False
        '
        'btninformations
        '
        Me.btninformations.BackColor = System.Drawing.Color.MediumPurple
        Me.btninformations.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btninformations.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.btninformations.FlatAppearance.BorderSize = 3
        Me.btninformations.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btninformations.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btninformations.ForeColor = System.Drawing.SystemColors.Window
        Me.btninformations.Image = Global.LaughTale.My.Resources.Resources.Picturez5
        Me.btninformations.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btninformations.Location = New System.Drawing.Point(1, 250)
        Me.btninformations.Name = "btninformations"
        Me.btninformations.Size = New System.Drawing.Size(163, 61)
        Me.btninformations.TabIndex = 49
        Me.btninformations.Text = "            Facturation"
        Me.btninformations.UseVisualStyleBackColor = False
        '
        'btnadmissions
        '
        Me.btnadmissions.BackColor = System.Drawing.Color.MediumPurple
        Me.btnadmissions.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnadmissions.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnadmissions.FlatAppearance.BorderSize = 3
        Me.btnadmissions.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnadmissions.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnadmissions.ForeColor = System.Drawing.SystemColors.Window
        Me.btnadmissions.Image = Global.LaughTale.My.Resources.Resources.Pdicture3
        Me.btnadmissions.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnadmissions.Location = New System.Drawing.Point(1, 165)
        Me.btnadmissions.Name = "btnadmissions"
        Me.btnadmissions.Size = New System.Drawing.Size(163, 61)
        Me.btnadmissions.TabIndex = 50
        Me.btnadmissions.Text = "         Admissions"
        Me.btnadmissions.UseVisualStyleBackColor = False
        '
        'btnaccueil
        '
        Me.btnaccueil.BackColor = System.Drawing.Color.MediumPurple
        Me.btnaccueil.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnaccueil.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnaccueil.FlatAppearance.BorderSize = 3
        Me.btnaccueil.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnaccueil.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnaccueil.ForeColor = System.Drawing.SystemColors.Window
        Me.btnaccueil.Image = Global.LaughTale.My.Resources.Resources.Picture1
        Me.btnaccueil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnaccueil.Location = New System.Drawing.Point(1, 78)
        Me.btnaccueil.Name = "btnaccueil"
        Me.btnaccueil.Size = New System.Drawing.Size(163, 61)
        Me.btnaccueil.TabIndex = 46
        Me.btnaccueil.Text = "    Accueil"
        Me.btnaccueil.UseVisualStyleBackColor = False
        '
        'dgvEnfants
        '
        Me.dgvEnfants.AutoGenerateColumns = False
        Me.dgvEnfants.BackgroundColor = System.Drawing.Color.Indigo
        Me.dgvEnfants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEnfants.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_enfant, Me.NomenfantDataGridViewTextBoxColumn, Me.PrenomenfantDataGridViewTextBoxColumn, Me.DatenaissanceDataGridViewTextBoxColumn, Me.SexeDataGridViewTextBoxColumn, Me.NomparentDataGridViewTextBoxColumn, Me.adresse, Me.TelparentDataGridViewTextBoxColumn, Me.Numeroparent2DataGridViewTextBoxColumn, Me.PhotoDataGridViewImageColumn, Me.HeurearriveeDataGridViewTextBoxColumn, Me.HeuredepartDataGridViewTextBoxColumn})
        Me.dgvEnfants.DataSource = Me.EnfantsBindingSource1
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MediumPurple
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvEnfants.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvEnfants.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgvEnfants.GridColor = System.Drawing.Color.MediumPurple
        Me.dgvEnfants.Location = New System.Drawing.Point(0, -2)
        Me.dgvEnfants.Margin = New System.Windows.Forms.Padding(8)
        Me.dgvEnfants.Name = "dgvEnfants"
        Me.dgvEnfants.Size = New System.Drawing.Size(1005, 307)
        Me.dgvEnfants.TabIndex = 0
        '
        'id_enfant
        '
        Me.id_enfant.DataPropertyName = "id_enfant"
        Me.id_enfant.HeaderText = "ID"
        Me.id_enfant.Name = "id_enfant"
        Me.id_enfant.ReadOnly = True
        '
        'NomenfantDataGridViewTextBoxColumn
        '
        Me.NomenfantDataGridViewTextBoxColumn.DataPropertyName = "nom_enfant"
        Me.NomenfantDataGridViewTextBoxColumn.HeaderText = "Nom de l'Enfant"
        Me.NomenfantDataGridViewTextBoxColumn.Name = "NomenfantDataGridViewTextBoxColumn"
        '
        'PrenomenfantDataGridViewTextBoxColumn
        '
        Me.PrenomenfantDataGridViewTextBoxColumn.DataPropertyName = "prenom_enfant"
        Me.PrenomenfantDataGridViewTextBoxColumn.HeaderText = "Prénom de l'enfant"
        Me.PrenomenfantDataGridViewTextBoxColumn.Name = "PrenomenfantDataGridViewTextBoxColumn"
        '
        'DatenaissanceDataGridViewTextBoxColumn
        '
        Me.DatenaissanceDataGridViewTextBoxColumn.DataPropertyName = "date_naissance"
        Me.DatenaissanceDataGridViewTextBoxColumn.HeaderText = "Date de Naissance"
        Me.DatenaissanceDataGridViewTextBoxColumn.Name = "DatenaissanceDataGridViewTextBoxColumn"
        '
        'SexeDataGridViewTextBoxColumn
        '
        Me.SexeDataGridViewTextBoxColumn.DataPropertyName = "sexe"
        Me.SexeDataGridViewTextBoxColumn.HeaderText = "Sexe"
        Me.SexeDataGridViewTextBoxColumn.Name = "SexeDataGridViewTextBoxColumn"
        '
        'NomparentDataGridViewTextBoxColumn
        '
        Me.NomparentDataGridViewTextBoxColumn.DataPropertyName = "nom_parent"
        Me.NomparentDataGridViewTextBoxColumn.HeaderText = "Nom du Parent"
        Me.NomparentDataGridViewTextBoxColumn.Name = "NomparentDataGridViewTextBoxColumn"
        '
        'adresse
        '
        Me.adresse.DataPropertyName = "adresse"
        Me.adresse.HeaderText = "Domicile"
        Me.adresse.Name = "adresse"
        '
        'TelparentDataGridViewTextBoxColumn
        '
        Me.TelparentDataGridViewTextBoxColumn.DataPropertyName = "tel_parent"
        Me.TelparentDataGridViewTextBoxColumn.HeaderText = "Numero du Parent (1)"
        Me.TelparentDataGridViewTextBoxColumn.Name = "TelparentDataGridViewTextBoxColumn"
        '
        'Numeroparent2DataGridViewTextBoxColumn
        '
        Me.Numeroparent2DataGridViewTextBoxColumn.DataPropertyName = "numero_parent2"
        Me.Numeroparent2DataGridViewTextBoxColumn.HeaderText = "Numéro du Parent (2)"
        Me.Numeroparent2DataGridViewTextBoxColumn.Name = "Numeroparent2DataGridViewTextBoxColumn"
        '
        'PhotoDataGridViewImageColumn
        '
        Me.PhotoDataGridViewImageColumn.DataPropertyName = "photo"
        Me.PhotoDataGridViewImageColumn.HeaderText = "Photo"
        Me.PhotoDataGridViewImageColumn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.PhotoDataGridViewImageColumn.Name = "PhotoDataGridViewImageColumn"
        '
        'HeurearriveeDataGridViewTextBoxColumn
        '
        Me.HeurearriveeDataGridViewTextBoxColumn.DataPropertyName = "heure_arrivee"
        Me.HeurearriveeDataGridViewTextBoxColumn.HeaderText = "Heure d'arrivée"
        Me.HeurearriveeDataGridViewTextBoxColumn.Name = "HeurearriveeDataGridViewTextBoxColumn"
        '
        'HeuredepartDataGridViewTextBoxColumn
        '
        Me.HeuredepartDataGridViewTextBoxColumn.DataPropertyName = "heure_depart"
        Me.HeuredepartDataGridViewTextBoxColumn.HeaderText = "Heure de départ"
        Me.HeuredepartDataGridViewTextBoxColumn.Name = "HeuredepartDataGridViewTextBoxColumn"
        '
        'EnfantsBindingSource1
        '
        Me.EnfantsBindingSource1.DataMember = "Enfants"
        Me.EnfantsBindingSource1.DataSource = Me.LAUGH_TALEDataSet5
        '
        'LAUGH_TALEDataSet5
        '
        Me.LAUGH_TALEDataSet5.DataSetName = "LAUGH_TALEDataSet5"
        Me.LAUGH_TALEDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EnfantsBindingSource
        '
        Me.EnfantsBindingSource.DataMember = "Enfants"
        Me.EnfantsBindingSource.DataSource = Me.LAUGH_TALEDataSet2
        '
        'LAUGH_TALEDataSet2
        '
        Me.LAUGH_TALEDataSet2.DataSetName = "LAUGH_TALEDataSet2"
        Me.LAUGH_TALEDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LAUGHTALEDataSetBindingSource
        '
        Me.LAUGHTALEDataSetBindingSource.DataSource = Me.LAUGH_TALEDataSet
        Me.LAUGHTALEDataSetBindingSource.Position = 0
        '
        'LAUGH_TALEDataSet
        '
        Me.LAUGH_TALEDataSet.DataSetName = "LAUGH_TALEDataSet"
        Me.LAUGH_TALEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.dgvEnfants)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(244, 219)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1005, 305)
        Me.Panel2.TabIndex = 44
        '
        'EnfantsTableAdapter
        '
        Me.EnfantsTableAdapter.ClearBeforeFill = True
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
        Me.btn_supprimer.Location = New System.Drawing.Point(245, 174)
        Me.btn_supprimer.Name = "btn_supprimer"
        Me.btn_supprimer.Size = New System.Drawing.Size(108, 41)
        Me.btn_supprimer.TabIndex = 65
        Me.btn_supprimer.Text = "          Supprimer"
        Me.btn_supprimer.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_supprimer.UseVisualStyleBackColor = False
        '
        'EnfantsTableAdapter1
        '
        Me.EnfantsTableAdapter1.ClearBeforeFill = True
        '
        'btn_refresh
        '
        Me.btn_refresh.BackColor = System.Drawing.Color.White
        Me.btn_refresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_refresh.FlatAppearance.BorderColor = System.Drawing.Color.Turquoise
        Me.btn_refresh.FlatAppearance.BorderSize = 3
        Me.btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_refresh.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_refresh.ForeColor = System.Drawing.Color.DodgerBlue
        Me.btn_refresh.Image = Global.LaughTale.My.Resources.Resources._2Picture1
        Me.btn_refresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_refresh.Location = New System.Drawing.Point(752, 0)
        Me.btn_refresh.Name = "btn_refresh"
        Me.btn_refresh.Size = New System.Drawing.Size(108, 41)
        Me.btn_refresh.TabIndex = 66
        Me.btn_refresh.Text = "          Actualiser"
        Me.btn_refresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_refresh.UseVisualStyleBackColor = False
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.LaughTale.My.Resources.Resources.vecteezy_minimal_background_purple_color_with_two_overlapping_waves_12847554
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1249, 524)
        Me.Controls.Add(Me.btn_refresh)
        Me.Controls.Add(Me.btn_supprimer)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form3"
        Me.Text = "ACCUEIL"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvEnfants, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EnfantsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LAUGH_TALEDataSet5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EnfantsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LAUGH_TALEDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LAUGHTALEDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LAUGH_TALEDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Private WithEvents btn_notif As Button
    Private WithEvents btndeconnexion As Button
    Private WithEvents btninformations As Button
    Private WithEvents btnadmissions As Button
    Private WithEvents btnaccueil As Button
    Friend WithEvents Tuteur As DataGridViewTextBoxColumn
    Friend WithEvents Label11 As Label
    Friend WithEvents dgvEnfants As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents LAUGHTALEDataSetBindingSource As BindingSource
    Friend WithEvents LAUGH_TALEDataSet As LAUGH_TALEDataSet
    Friend WithEvents LAUGH_TALEDataSet2 As LAUGH_TALEDataSet2
    Friend WithEvents EnfantsBindingSource As BindingSource
    Friend WithEvents EnfantsTableAdapter As LAUGH_TALEDataSet2TableAdapters.EnfantsTableAdapter
    Private WithEvents btn_supprimer As Button
    Friend WithEvents LAUGH_TALEDataSet5 As LAUGH_TALEDataSet5
    Friend WithEvents EnfantsBindingSource1 As BindingSource
    Friend WithEvents EnfantsTableAdapter1 As LAUGH_TALEDataSet5TableAdapters.EnfantsTableAdapter
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents id_enfant As DataGridViewTextBoxColumn
    Friend WithEvents NomenfantDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrenomenfantDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DatenaissanceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SexeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NomparentDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents adresse As DataGridViewTextBoxColumn
    Friend WithEvents TelparentDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Numeroparent2DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PhotoDataGridViewImageColumn As DataGridViewImageColumn
    Friend WithEvents HeurearriveeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HeuredepartDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Private WithEvents btn_refresh As Button
End Class
