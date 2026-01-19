namespace IEFI_Mascotas_DS
{
    partial class form_Animales
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_obtener = new System.Windows.Forms.Button();
            this.btn_actualizar = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.txt_animal = new System.Windows.Forms.TextBox();
            this.tabla_animales = new System.Windows.Forms.DataGridView();
            this.animalesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iEFI_MascotasDataSet = new IEFI_Mascotas_DS.IEFI_MascotasDataSet();
            this.animalesTableAdapter = new IEFI_Mascotas_DS.IEFI_MascotasDataSetTableAdapters.AnimalesTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.idAnimalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.animalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tabla_animales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iEFI_MascotasDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(196, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lista De Animales";
            // 
            // btn_obtener
            // 
            this.btn_obtener.Location = new System.Drawing.Point(153, 129);
            this.btn_obtener.Name = "btn_obtener";
            this.btn_obtener.Size = new System.Drawing.Size(100, 30);
            this.btn_obtener.TabIndex = 1;
            this.btn_obtener.Text = "Obtener";
            this.btn_obtener.UseVisualStyleBackColor = true;
            this.btn_obtener.Click += new System.EventHandler(this.btn_obtener_Click);
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.Location = new System.Drawing.Point(472, 11);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(100, 30);
            this.btn_actualizar.TabIndex = 2;
            this.btn_actualizar.Text = "Actualizar";
            this.btn_actualizar.UseVisualStyleBackColor = true;
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click);
            // 
            // btn_modificar
            // 
            this.btn_modificar.Location = new System.Drawing.Point(365, 129);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(100, 30);
            this.btn_modificar.TabIndex = 3;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(259, 129);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(100, 30);
            this.btn_agregar.TabIndex = 4;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(471, 129);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(100, 30);
            this.btn_eliminar.TabIndex = 5;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // txt_animal
            // 
            this.txt_animal.Location = new System.Drawing.Point(25, 135);
            this.txt_animal.Name = "txt_animal";
            this.txt_animal.Size = new System.Drawing.Size(122, 20);
            this.txt_animal.TabIndex = 7;
            // 
            // tabla_animales
            // 
            this.tabla_animales.AllowUserToAddRows = false;
            this.tabla_animales.AllowUserToDeleteRows = false;
            this.tabla_animales.AutoGenerateColumns = false;
            this.tabla_animales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabla_animales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idAnimalDataGridViewTextBoxColumn,
            this.animalDataGridViewTextBoxColumn});
            this.tabla_animales.DataSource = this.animalesBindingSource;
            this.tabla_animales.Location = new System.Drawing.Point(215, 189);
            this.tabla_animales.Name = "tabla_animales";
            this.tabla_animales.ReadOnly = true;
            this.tabla_animales.Size = new System.Drawing.Size(160, 260);
            this.tabla_animales.TabIndex = 8;
            this.tabla_animales.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tabla_animales_MouseClick);
            // 
            // animalesBindingSource
            // 
            this.animalesBindingSource.DataMember = "Animales";
            this.animalesBindingSource.DataSource = this.iEFI_MascotasDataSet;
            // 
            // iEFI_MascotasDataSet
            // 
            this.iEFI_MascotasDataSet.DataSetName = "IEFI_MascotasDataSet";
            this.iEFI_MascotasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // animalesTableAdapter
            // 
            this.animalesTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nombre del animal:";
            // 
            // idAnimalDataGridViewTextBoxColumn
            // 
            this.idAnimalDataGridViewTextBoxColumn.DataPropertyName = "Id_Animal";
            this.idAnimalDataGridViewTextBoxColumn.HeaderText = "Id_Animal";
            this.idAnimalDataGridViewTextBoxColumn.Name = "idAnimalDataGridViewTextBoxColumn";
            this.idAnimalDataGridViewTextBoxColumn.ReadOnly = true;
            this.idAnimalDataGridViewTextBoxColumn.Visible = false;
            // 
            // animalDataGridViewTextBoxColumn
            // 
            this.animalDataGridViewTextBoxColumn.DataPropertyName = "Animal";
            this.animalDataGridViewTextBoxColumn.HeaderText = "Animal";
            this.animalDataGridViewTextBoxColumn.Name = "animalDataGridViewTextBoxColumn";
            this.animalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // form_Animales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tabla_animales);
            this.Controls.Add(this.txt_animal);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.btn_actualizar);
            this.Controls.Add(this.btn_obtener);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "form_Animales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Animales";
            this.Load += new System.EventHandler(this.form_Animales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabla_animales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iEFI_MascotasDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_obtener;
        private System.Windows.Forms.Button btn_actualizar;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.TextBox txt_animal;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView tabla_animales;
        private IEFI_MascotasDataSet iEFI_MascotasDataSet;
        private System.Windows.Forms.BindingSource animalesBindingSource;
        private IEFI_MascotasDataSetTableAdapters.AnimalesTableAdapter animalesTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAnimalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn animalDataGridViewTextBoxColumn;
    }
}