namespace IEFI_Mascotas
{
    partial class form_Razas
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
            this.combo_idAnimal = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabla_razas = new System.Windows.Forms.DataGridView();
            this.txt_raza = new System.Windows.Forms.TextBox();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_actualizar = new System.Windows.Forms.Button();
            this.btn_obtener = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tabla_razas)).BeginInit();
            this.SuspendLayout();
            // 
            // combo_idAnimal
            // 
            this.combo_idAnimal.FormattingEnabled = true;
            this.combo_idAnimal.Location = new System.Drawing.Point(190, 138);
            this.combo_idAnimal.Name = "combo_idAnimal";
            this.combo_idAnimal.Size = new System.Drawing.Size(121, 21);
            this.combo_idAnimal.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(130, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 30;
            this.label3.Text = "Animal:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(70, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 17);
            this.label2.TabIndex = 29;
            this.label2.Text = "Nombre de raza:";
            // 
            // tabla_razas
            // 
            this.tabla_razas.AllowUserToAddRows = false;
            this.tabla_razas.AllowUserToDeleteRows = false;
            this.tabla_razas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabla_razas.Location = new System.Drawing.Point(151, 189);
            this.tabla_razas.Name = "tabla_razas";
            this.tabla_razas.ReadOnly = true;
            this.tabla_razas.Size = new System.Drawing.Size(260, 260);
            this.tabla_razas.TabIndex = 28;
            this.tabla_razas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabla_razas_CellDoubleClick);
            // 
            // txt_raza
            // 
            this.txt_raza.Location = new System.Drawing.Point(190, 105);
            this.txt_raza.Name = "txt_raza";
            this.txt_raza.Size = new System.Drawing.Size(122, 20);
            this.txt_raza.TabIndex = 27;
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(446, 141);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(100, 30);
            this.btn_eliminar.TabIndex = 26;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(340, 141);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(100, 30);
            this.btn_agregar.TabIndex = 25;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // btn_modificar
            // 
            this.btn_modificar.Location = new System.Drawing.Point(446, 98);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(100, 30);
            this.btn_modificar.TabIndex = 24;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.Location = new System.Drawing.Point(467, 14);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(100, 30);
            this.btn_actualizar.TabIndex = 23;
            this.btn_actualizar.Text = "Actualizar";
            this.btn_actualizar.UseVisualStyleBackColor = true;
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click);
            // 
            // btn_obtener
            // 
            this.btn_obtener.Location = new System.Drawing.Point(340, 98);
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
            this.label1.Location = new System.Drawing.Point(202, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 29);
            this.label1.TabIndex = 21;
            this.label1.Text = "Lista De Razas";
            // 
            // form_Razas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.combo_idAnimal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tabla_razas);
            this.Controls.Add(this.txt_raza);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.btn_actualizar);
            this.Controls.Add(this.btn_obtener);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "form_Razas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Razas";
            ((System.ComponentModel.ISupportInitialize)(this.tabla_razas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox combo_idAnimal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView tabla_razas;
        private System.Windows.Forms.TextBox txt_raza;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_actualizar;
        private System.Windows.Forms.Button btn_obtener;
        private System.Windows.Forms.Label label1;
    }
}