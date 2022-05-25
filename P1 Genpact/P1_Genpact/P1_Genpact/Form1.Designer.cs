namespace P1_Genpact
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
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnNoAplicable = new System.Windows.Forms.Button();
            this.btnProcesado = new System.Windows.Forms.Button();
            this.btnRaiz = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.ForestGreen;
            this.panel1.Controls.Add(this.btnNoAplicable);
            this.panel1.Controls.Add(this.btnProcesado);
            this.panel1.Controls.Add(this.btnRaiz);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 450);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.ForestGreen;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(220, 75);
            this.panel3.TabIndex = 0;
            // 
            // panelContenedor
            // 
            this.panelContenedor.Controls.Add(this.pictureBox1);
            this.panelContenedor.Controls.Add(this.label2);
            this.panelContenedor.Controls.Add(this.label1);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(220, 0);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(580, 450);
            this.panelContenedor.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(135, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(310, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "con un observador de carpetas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(102, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(392, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Herramienta de consolidacion de Excel ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::P1_Genpact.Properties.Resources.LogoExcel;
            this.pictureBox1.Location = new System.Drawing.Point(156, 154);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 188);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnNoAplicable
            // 
            this.btnNoAplicable.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNoAplicable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNoAplicable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNoAplicable.ForeColor = System.Drawing.SystemColors.Control;
            this.btnNoAplicable.Image = global::P1_Genpact.Properties.Resources.LogoCarpetas;
            this.btnNoAplicable.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNoAplicable.Location = new System.Drawing.Point(0, 175);
            this.btnNoAplicable.Name = "btnNoAplicable";
            this.btnNoAplicable.Size = new System.Drawing.Size(220, 50);
            this.btnNoAplicable.TabIndex = 1;
            this.btnNoAplicable.Text = "   Carpeta No Aplicable";
            this.btnNoAplicable.UseVisualStyleBackColor = true;
            this.btnNoAplicable.Click += new System.EventHandler(this.btnNoAplicable_Click);
            // 
            // btnProcesado
            // 
            this.btnProcesado.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProcesado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcesado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcesado.ForeColor = System.Drawing.SystemColors.Control;
            this.btnProcesado.Image = global::P1_Genpact.Properties.Resources.LogoCarpetas;
            this.btnProcesado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProcesado.Location = new System.Drawing.Point(0, 125);
            this.btnProcesado.Name = "btnProcesado";
            this.btnProcesado.Size = new System.Drawing.Size(220, 50);
            this.btnProcesado.TabIndex = 1;
            this.btnProcesado.Text = "Carpeta Procesada";
            this.btnProcesado.UseVisualStyleBackColor = true;
            this.btnProcesado.Click += new System.EventHandler(this.btnProcesado_Click);
            // 
            // btnRaiz
            // 
            this.btnRaiz.BackColor = System.Drawing.Color.ForestGreen;
            this.btnRaiz.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRaiz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRaiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRaiz.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRaiz.Image = global::P1_Genpact.Properties.Resources.LogoCarpetas;
            this.btnRaiz.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRaiz.Location = new System.Drawing.Point(0, 75);
            this.btnRaiz.Name = "btnRaiz";
            this.btnRaiz.Size = new System.Drawing.Size(220, 50);
            this.btnRaiz.TabIndex = 1;
            this.btnRaiz.Text = "Carpeta Raiz";
            this.btnRaiz.UseVisualStyleBackColor = false;
            this.btnRaiz.Click += new System.EventHandler(this.btnRaiz_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Ejercicio de Programacion";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panelContenedor.ResumeLayout(false);
            this.panelContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRaiz;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnNoAplicable;
        private System.Windows.Forms.Button btnProcesado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

