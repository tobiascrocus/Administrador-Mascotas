namespace IEFI_Mascotas_DS
{
    partial class form_Mascotas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.combo_idRaza = new System.Windows.Forms.ComboBox();
            this.razasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iEFI_MascotasDataSet = new IEFI_Mascotas_DS.IEFI_MascotasDataSet();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabla_mascotas = new System.Windows.Forms.DataGridView();
            this.mascotasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txt_mascota = new System.Windows.Forms.TextBox();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_actualizar = new System.Windows.Forms.Button();
            this.btn_obtener = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_apodo = new System.Windows.Forms.TextBox();
            this.txt_dueño = new System.Windows.Forms.TextBox();
            this.mascotasTableAdapter = new IEFI_Mascotas_DS.IEFI_MascotasDataSetTableAdapters.MascotasTableAdapter();
            this.razasTableAdapter = new IEFI_Mascotas_DS.IEFI_MascotasDataSetTableAdapters.RazasTableAdapter();
            this.idMascotaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apodoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDueñoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_Raza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.razasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iEFI_MascotasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabla_mascotas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mascotasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // combo_idRaza
            // 
            this.combo_idRaza.DataSource = this.razasBindingSource;
            this.combo_idRaza.DisplayMember = "NombreRaza";
            this.combo_idRaza.FormattingEnabled = true;
            this.combo_idRaza.Location = new System.Drawing.Point(296, 137);
            this.combo_idRaza.Name = "combo_idRaza";
            this.combo_idRaza.Size = new System.Drawing.Size(121, 21);
            this.combo_idRaza.TabIndex = 31;
            this.combo_idRaza.ValueMember = "Id_Raza";
            // 
            // razasBindingSource
            // 
            this.razasBindingSource.DataMember = "Razas";
            this.razasBindingSource.DataSource = this.iEFI_MascotasDataSet;
            // 
            // iEFI_MascotasDataSet
            // 
            this.iEFI_MascotasDataSet.DataSetName = "IEFI_MascotasDataSet";
            this.iEFI_MascotasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(245, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 30;
            this.label3.Text = "Raza:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 29;
            this.label2.Text = "Nombre:";
            // 
            // tabla_mascotas
            // 
            this.tabla_mascotas.AllowUserToAddRows = false;
            this.tabla_mascotas.AllowUserToDeleteRows = false;
            this.tabla_mascotas.AutoGenerateColumns = false;
            this.tabla_mascotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabla_mascotas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idMascotaDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.apodoDataGridViewTextBoxColumn,
            this.nombreDueñoDataGridViewTextBoxColumn,
            this.id_Raza,
            this.razaDataGridViewTextBoxColumn});
            this.tabla_mascotas.DataSource = this.mascotasBindingSource;
            this.tabla_mascotas.Location = new System.Drawing.Point(113, 189);
            this.tabla_mascotas.Name = "tabla_mascotas";
            this.tabla_mascotas.ReadOnly = true;
            this.tabla_mascotas.Size = new System.Drawing.Size(460, 260);
            this.tabla_mascotas.TabIndex = 28;
            this.tabla_mascotas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tabla_mascotas_MouseClick);
            // 
            // mascotasBindingSource
            // 
            this.mascotasBindingSource.DataMember = "Mascotas";
            this.mascotasBindingSource.DataSource = this.iEFI_MascotasDataSet;
            // 
            // txt_mascota
            // 
            this.txt_mascota.Location = new System.Drawing.Point(92, 102);
            this.txt_mascota.Name = "txt_mascota";
            this.txt_mascota.Size = new System.Drawing.Size(122, 20);
            this.txt_mascota.TabIndex = 27;
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(570, 133);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(100, 30);
            this.btn_eliminar.TabIndex = 26;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(464, 133);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(100, 30);
            this.btn_agregar.TabIndex = 25;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // btn_modificar
            // 
            this.btn_modificar.Location = new System.Drawing.Point(570, 90);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(100, 30);
            this.btn_modificar.TabIndex = 24;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.Location = new System.Drawing.Point(572, 12);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(100, 30);
            this.btn_actualizar.TabIndex = 23;
            this.btn_actualizar.Text = "Actualizar";
            this.btn_actualizar.UseVisualStyleBackColor = true;
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click);
            // 
            // btn_obtener
            // 
            this.btn_obtener.Location = new System.Drawing.Point(464, 90);
            this.btn_obtener.Name = "btn_obtener";
            this.btn_obtener.Size = new System.Drawing.Size(100, 30);
            this.btn_obtener.TabIndex = 22;
            this.btn_obtener.Text = "Obtener";
            this.btn_obtener.UseVisualStyleBackColor = true;
            this.btn_obtener.Click += new System.EventHandler(this.btn_obtener_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(235, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 29);
            this.label1.TabIndex = 21;
            this.label1.Text = "Lista De Mascotas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(237, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 32;
            this.label4.Text = "Apodo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 17);
            this.label5.TabIndex = 33;
            this.label5.Text = "Dueño:";
            // 
            // txt_apodo
            // 
            this.txt_apodo.Location = new System.Drawing.Point(296, 102);
            this.txt_apodo.Name = "txt_apodo";
            this.txt_apodo.Size = new System.Drawing.Size(122, 20);
            this.txt_apodo.TabIndex = 34;
            // 
            // txt_dueño
            // 
            this.txt_dueño.Location = new System.Drawing.Point(92, 138);
            this.txt_dueño.Name = "txt_dueño";
            this.txt_dueño.Size = new System.Drawing.Size(122, 20);
            this.txt_dueño.TabIndex = 35;
            // 
            // mascotasTableAdapter
            // 
            this.mascotasTableAdapter.ClearBeforeFill = true;
            // 
            // razasTableAdapter
            // 
            this.razasTableAdapter.ClearBeforeFill = true;
            // 
            // idMascotaDataGridViewTextBoxColumn
            // 
            this.idMascotaDataGridViewTextBoxColumn.DataPropertyName = "Id_Mascota";
            this.idMascotaDataGridViewTextBoxColumn.HeaderText = "Id_Mascota";
            this.idMascotaDataGridViewTextBoxColumn.Name = "idMascotaDataGridViewTextBoxColumn";
            this.idMascotaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idMascotaDataGridViewTextBoxColumn.Visible = false;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apodoDataGridViewTextBoxColumn
            // 
            this.apodoDataGridViewTextBoxColumn.DataPropertyName = "Apodo";
            this.apodoDataGridViewTextBoxColumn.HeaderText = "Apodo";
            this.apodoDataGridViewTextBoxColumn.Name = "apodoDataGridViewTextBoxColumn";
            this.apodoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDueñoDataGridViewTextBoxColumn
            // 
            this.nombreDueñoDataGridViewTextBoxColumn.DataPropertyName = "NombreDueño";
            this.nombreDueñoDataGridViewTextBoxColumn.HeaderText = "Dueño";
            this.nombreDueñoDataGridViewTextBoxColumn.Name = "nombreDueñoDataGridViewTextBoxColumn";
            this.nombreDueñoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // id_Raza
            // 
            this.id_Raza.DataPropertyName = "id_Raza";
            this.id_Raza.HeaderText = "id_Raza";
            this.id_Raza.Name = "id_Raza";
            this.id_Raza.ReadOnly = true;
            this.id_Raza.Visible = false;
            // 
            // razaDataGridViewTextBoxColumn
            // 
            this.razaDataGridViewTextBoxColumn.DataPropertyName = "Raza";
            this.razaDataGridViewTextBoxColumn.HeaderText = "Raza";
            this.razaDataGridViewTextBoxColumn.Name = "razaDataGridViewTextBoxColumn";
            this.razaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // form_Mascotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.txt_dueño);
            this.Controls.Add(this.txt_apodo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.combo_idRaza);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tabla_mascotas);
            this.Controls.Add(this.txt_mascota);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.btn_actualizar);
            this.Controls.Add(this.btn_obtener);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "form_Mascotas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mascotas";
            this.Load += new System.EventHandler(this.form_Mascotas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.razasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iEFI_MascotasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabla_mascotas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mascotasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox combo_idRaza;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView tabla_mascotas;
        private System.Windows.Forms.TextBox txt_mascota;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_actualizar;
        private System.Windows.Forms.Button btn_obtener;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_apodo;
        private System.Windows.Forms.TextBox txt_dueño;
        private System.Windows.Forms.BindingSource mascotasBindingSource;
        private IEFI_MascotasDataSet iEFI_MascotasDataSet;
        private IEFI_MascotasDataSetTableAdapters.MascotasTableAdapter mascotasTableAdapter;
        private System.Windows.Forms.BindingSource razasBindingSource;
        private IEFI_MascotasDataSetTableAdapters.RazasTableAdapter razasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMascotaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apodoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDueñoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_Raza;
        private System.Windows.Forms.DataGridViewTextBoxColumn razaDataGridViewTextBoxColumn;
    }
}