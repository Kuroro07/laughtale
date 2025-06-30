<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form6))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.dgv_notifs = New System.Windows.Forms.DataGridView()
        Me.id_notif = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TitreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MessageDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateNotifDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatutDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NotificationsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LAUGH_TALEDataSet7 = New LaughTale.LAUGH_TALEDataSet7()
        Me.NotificationsTableAdapter = New LaughTale.LAUGH_TALEDataSet7TableAdapters.NotificationsTableAdapter()
        Me.btn_supprimer = New System.Windows.Forms.Button()
        Me.btn_read = New System.Windows.Forms.Button()
        Me.btn_refresh = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.dgv_notifs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NotificationsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LAUGH_TALEDataSet7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.MediumPurple
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(766, 61)
        Me.Panel1.TabIndex = 37
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(304, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(181, 32)
        Me.Label2.TabIndex = 36
        Me.Label2.Tag = ""
        Me.Label2.Text = "Notifications"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.MediumPurple
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 61)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(230, 425)
        Me.Panel2.TabIndex = 39
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.LaughTale.My.Resources.Resources.vecteezy_ai_generated_children_engaging_with_colorful_toys_43993044_removebg_preview
        Me.PictureBox1.Location = New System.Drawing.Point(-2, 246)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(264, 199)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.dgv_notifs)
        Me.Panel3.Location = New System.Drawing.Point(230, 61)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(536, 347)
        Me.Panel3.TabIndex = 40
        '
        'dgv_notifs
        '
        Me.dgv_notifs.AutoGenerateColumns = False
        Me.dgv_notifs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_notifs.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_notif, Me.TitreDataGridViewTextBoxColumn, Me.MessageDataGridViewTextBoxColumn, Me.DateNotifDataGridViewTextBoxColumn, Me.StatutDataGridViewTextBoxColumn})
        Me.dgv_notifs.DataSource = Me.NotificationsBindingSource
        Me.dgv_notifs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_notifs.Location = New System.Drawing.Point(0, 0)
        Me.dgv_notifs.Name = "dgv_notifs"
        Me.dgv_notifs.Size = New System.Drawing.Size(536, 347)
        Me.dgv_notifs.TabIndex = 0
        '
        'id_notif
        '
        Me.id_notif.DataPropertyName = "id_notif"
        Me.id_notif.HeaderText = "N°"
        Me.id_notif.Name = "id_notif"
        Me.id_notif.ReadOnly = True
        '
        'TitreDataGridViewTextBoxColumn
        '
        Me.TitreDataGridViewTextBoxColumn.DataPropertyName = "titre"
        Me.TitreDataGridViewTextBoxColumn.HeaderText = "Titre"
        Me.TitreDataGridViewTextBoxColumn.Name = "TitreDataGridViewTextBoxColumn"
        '
        'MessageDataGridViewTextBoxColumn
        '
        Me.MessageDataGridViewTextBoxColumn.DataPropertyName = "message"
        Me.MessageDataGridViewTextBoxColumn.HeaderText = "Message"
        Me.MessageDataGridViewTextBoxColumn.Name = "MessageDataGridViewTextBoxColumn"
        '
        'DateNotifDataGridViewTextBoxColumn
        '
        Me.DateNotifDataGridViewTextBoxColumn.DataPropertyName = "dateNotif"
        Me.DateNotifDataGridViewTextBoxColumn.HeaderText = "Date"
        Me.DateNotifDataGridViewTextBoxColumn.Name = "DateNotifDataGridViewTextBoxColumn"
        '
        'StatutDataGridViewTextBoxColumn
        '
        Me.StatutDataGridViewTextBoxColumn.DataPropertyName = "statut"
        Me.StatutDataGridViewTextBoxColumn.HeaderText = "Statut"
        Me.StatutDataGridViewTextBoxColumn.Name = "StatutDataGridViewTextBoxColumn"
        '
        'NotificationsBindingSource
        '
        Me.NotificationsBindingSource.DataMember = "Notifications"
        Me.NotificationsBindingSource.DataSource = Me.LAUGH_TALEDataSet7
        '
        'LAUGH_TALEDataSet7
        '
        Me.LAUGH_TALEDataSet7.DataSetName = "LAUGH_TALEDataSet7"
        Me.LAUGH_TALEDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'NotificationsTableAdapter
        '
        Me.NotificationsTableAdapter.ClearBeforeFill = True
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
        Me.btn_supprimer.Location = New System.Drawing.Point(646, 438)
        Me.btn_supprimer.Name = "btn_supprimer"
        Me.btn_supprimer.Size = New System.Drawing.Size(108, 41)
        Me.btn_supprimer.TabIndex = 90
        Me.btn_supprimer.Text = "          Supprimer"
        Me.btn_supprimer.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_supprimer.UseVisualStyleBackColor = False
        '
        'btn_read
        '
        Me.btn_read.BackColor = System.Drawing.Color.White
        Me.btn_read.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_read.FlatAppearance.BorderColor = System.Drawing.Color.Turquoise
        Me.btn_read.FlatAppearance.BorderSize = 3
        Me.btn_read.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_read.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_read.ForeColor = System.Drawing.Color.Black
        Me.btn_read.Image = Global.LaughTale.My.Resources.Resources.pPicture1
        Me.btn_read.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_read.Location = New System.Drawing.Point(239, 430)
        Me.btn_read.Name = "btn_read"
        Me.btn_read.Size = New System.Drawing.Size(111, 56)
        Me.btn_read.TabIndex = 68
        Me.btn_read.Text = "           Marquer " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "          comme lu"
        Me.btn_read.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_read.UseVisualStyleBackColor = False
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
        Me.btn_refresh.Location = New System.Drawing.Point(444, 438)
        Me.btn_refresh.Name = "btn_refresh"
        Me.btn_refresh.Size = New System.Drawing.Size(108, 41)
        Me.btn_refresh.TabIndex = 67
        Me.btn_refresh.Text = "          Actualiser"
        Me.btn_refresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_refresh.UseVisualStyleBackColor = False
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(766, 486)
        Me.Controls.Add(Me.btn_supprimer)
        Me.Controls.Add(Me.btn_read)
        Me.Controls.Add(Me.btn_refresh)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form6"
        Me.Text = "NOTIFICATIONS"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        CType(Me.dgv_notifs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NotificationsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LAUGH_TALEDataSet7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel3 As Panel
    Private WithEvents btn_refresh As Button
    Private WithEvents btn_read As Button
    Friend WithEvents dgv_notifs As DataGridView
    Private WithEvents btn_supprimer As Button
    Friend WithEvents LAUGH_TALEDataSet7 As LAUGH_TALEDataSet7
    Friend WithEvents NotificationsBindingSource As BindingSource
    Friend WithEvents NotificationsTableAdapter As LAUGH_TALEDataSet7TableAdapters.NotificationsTableAdapter
    Friend WithEvents id_notif As DataGridViewTextBoxColumn
    Friend WithEvents TitreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MessageDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateNotifDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StatutDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
