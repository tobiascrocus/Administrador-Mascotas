namespace IEFI_Mascotas
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
            this.txt_dueño = new System.Windows.Forms.TextBox();
            this.txt_apodo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.combo_idRaza = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabla_mascotas = new System.Windows.Forms.DataGridView();
            this.txt_mascota = new System.Windows.Forms.TextBox();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_actualizar = new System.Windows.Forms.Button();
            this.btn_obtener = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tabla_mascotas)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_dueño
            // 
            this.txt_dueño.Location = new System.Drawing.Point(92, 138);
            this.txt_dueño.Name = "txt_dueño";
            this.txt_dueño.Size = new System.Drawing.Size(122, 20);
            this.txt_dueño.TabIndex = 50;
            // 
            // txt_apodo
            // 
            this.txt_apodo.Location = new System.Drawing.Point(296, 102);
            this.txt_apodo.Name = "txt_apodo";
            this.txt_apodo.Size = new System.Drawing.Size(122, 20);
            this.txt_apodo.TabIndex = 49;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 17);
            this.label5.TabIndex = 48;
            this.label5.Text = "Dueño:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(237, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 47;
            this.label4.Text = "Apodo:";
            // 
            // combo_idRaza
            // 
            this.combo_idRaza.FormattingEnabled = true;
            this.combo_idRaza.Location = new System.Drawing.Point(296, 137);
            this.combo_idRaza.Name = "combo_idRaza";
            this.combo_idRaza.Size = new System.Drawing.Size(121, 21);
            this.combo_idRaza.TabIndex = 46;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(245, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 45;
            this.label3.Text = "Raza:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 44;
            this.label2.Text = "Nombre:";
            // 
            // tabla_mascotas
            // 
            this.tabla_mascotas.AllowUserToAddRows = false;
            this.tabla_mascotas.AllowUserToDeleteRows = false;
            this.tabla_mascotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabla_mascotas.Location = new System.Drawing.Point(113, 189);
            this.tabla_mascotas.Name = "tabla_mascotas";
            this.tabla_mascotas.ReadOnly = true;
            this.tabla_mascotas.Size = new System.Drawing.Size(460, 260);
            this.tabla_mascotas.TabIndex = 43;
            this.tabla_mascotas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabla_mascotas_CellDoubleClick);
            // 
            // txt_mascota
            // 
            this.txt_mascota.Location = new System.Drawing.Point(92, 102);
            this.txt_mascota.Name = "txt_mascota";
            this.txt_mascota.Size = new System.Drawing.Size(122, 20);
            this.txt_mascota.TabIndex = 42;
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(570, 133);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(100, 30);
            this.btn_eliminar.TabIndex = 41;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(464, 133);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(100, 30);
            this.btn_agregar.TabIndex = 40;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // btn_modificar
            // 
            this.btn_modificar.Location = new System.Drawing.Point(570, 90);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(100, 30);
            this.btn_modificar.TabIndex = 39;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.Location = new System.Drawing.Point(572, 12);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(100, 30);
            this.btn_actualizar.TabIndex = 38;
            this.btn_actualizar.Text = "Actualizar";
            this.btn_actualizar.UseVisualStyleBackColor = true;
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click);
            // 
            // btn_obtener
            // 
            this.btn_obtener.Location = new System.Drawing.Point(464, 90);
            this.btn_obtener.Name = "btn_obtener";
            this.btn_obtener.Size = new System.Drawing.Size(100, 30);
            this.btn_obtener.TabIndex = 37;
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
            this.label1.TabIndex = 36;
            this.label1.Text = "Lista De Mascotas";
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
            ((System.ComponentModel.ISupportInitialize)(this.tabla_mascotas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_dueño;
        private System.Windows.Forms.TextBox txt_apodo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
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
    }
}