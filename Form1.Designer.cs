namespace LaTuerca
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.TextoCarrito = new System.Windows.Forms.Label();
            this.LaTuercaPanel = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.Button();
            this.loginAdmin = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.panel1.Controls.Add(this.TextoCarrito);
            this.panel1.Controls.Add(this.LaTuercaPanel);
            this.panel1.Location = new System.Drawing.Point(-2, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1023, 50);
            this.panel1.TabIndex = 0;
            // 
            // TextoCarrito
            // 
            this.TextoCarrito.AutoSize = true;
            this.TextoCarrito.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextoCarrito.Location = new System.Drawing.Point(749, 11);
            this.TextoCarrito.Name = "TextoCarrito";
            this.TextoCarrito.Size = new System.Drawing.Size(79, 28);
            this.TextoCarrito.TabIndex = 2;
            this.TextoCarrito.Text = "Carrito";
            // 
            // LaTuercaPanel
            // 
            this.LaTuercaPanel.AutoSize = true;
            this.LaTuercaPanel.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LaTuercaPanel.Location = new System.Drawing.Point(168, 11);
            this.LaTuercaPanel.Name = "LaTuercaPanel";
            this.LaTuercaPanel.Size = new System.Drawing.Size(207, 28);
            this.LaTuercaPanel.TabIndex = 1;
            this.LaTuercaPanel.Text = "Chiviteria La Tuerca";
            this.LaTuercaPanel.Click += new System.EventHandler(this.LaTuercaPanel_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.Location = new System.Drawing.Point(38, 48);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(164, 51);
            this.btnMenu.TabIndex = 1;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // loginAdmin
            // 
            this.loginAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.loginAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginAdmin.Location = new System.Drawing.Point(332, 48);
            this.loginAdmin.Name = "loginAdmin";
            this.loginAdmin.Size = new System.Drawing.Size(174, 51);
            this.loginAdmin.TabIndex = 2;
            this.loginAdmin.Text = "Admin";
            this.loginAdmin.UseVisualStyleBackColor = false;
            this.loginAdmin.Click += new System.EventHandler(this.loginAdmin_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.panel2.Location = new System.Drawing.Point(563, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 504);
            this.panel2.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1012, 550);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.loginAdmin);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Chiviteria La Tuerca";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LaTuercaPanel;
        private System.Windows.Forms.Label TextoCarrito;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button loginAdmin;
        private System.Windows.Forms.Panel panel2;
    }
}

