namespace IEFI_Mascotas_DS
{
    partial class Menu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Animales = new System.Windows.Forms.Button();
            this.btn_Razas = new System.Windows.Forms.Button();
            this.btn_Mascotas = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Animales
            // 
            this.btn_Animales.BackColor = System.Drawing.Color.Yellow;
            this.btn_Animales.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Animales.Location = new System.Drawing.Point(28, 248);
            this.btn_Animales.Name = "btn_Animales";
            this.btn_Animales.Size = new System.Drawing.Size(133, 37);
            this.btn_Animales.TabIndex = 0;
            this.btn_Animales.Text = "Ver Animales";
            this.btn_Animales.UseVisualStyleBackColor = false;
            this.btn_Animales.Click += new System.EventHandler(this.btn_Animales_Click);
            // 
            // btn_Razas
            // 
            this.btn_Razas.BackColor = System.Drawing.Color.Yellow;
            this.btn_Razas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Razas.Location = new System.Drawing.Point(183, 248);
            this.btn_Razas.Name = "btn_Razas";
            this.btn_Razas.Size = new System.Drawing.Size(133, 37);
            this.btn_Razas.TabIndex = 1;
            this.btn_Razas.Text = "Ver Razas";
            this.btn_Razas.UseVisualStyleBackColor = false;
            this.btn_Razas.Click += new System.EventHandler(this.btn_Razas_Click);
            // 
            // btn_Mascotas
            // 
            this.btn_Mascotas.BackColor = System.Drawing.Color.Yellow;
            this.btn_Mascotas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Mascotas.Location = new System.Drawing.Point(338, 248);
            this.btn_Mascotas.Name = "btn_Mascotas";
            this.btn_Mascotas.Size = new System.Drawing.Size(133, 37);
            this.btn_Mascotas.TabIndex = 2;
            this.btn_Mascotas.Text = "Ver Mascotas";
            this.btn_Mascotas.UseVisualStyleBackColor = false;
            this.btn_Mascotas.Click += new System.EventHandler(this.btn_Mascotas_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(106, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Base De Datos Mascotas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Animales";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(222, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Razas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(363, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mascotas";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(504, 341);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Mascotas);
            this.Controls.Add(this.btn_Razas);
            this.Controls.Add(this.btn_Animales);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Animales;
        private System.Windows.Forms.Button btn_Razas;
        private System.Windows.Forms.Button btn_Mascotas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

