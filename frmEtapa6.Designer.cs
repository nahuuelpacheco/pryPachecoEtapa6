
namespace pryPachecoEtapa6
{
    partial class frm
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
            this.components = new System.ComponentModel.Container();
            this.btnCrear = new System.Windows.Forms.Button();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.btnMover = new System.Windows.Forms.Button();
            this.lblContador = new System.Windows.Forms.Label();
            this.timerMov = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(12, 384);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(75, 23);
            this.btnCrear.TabIndex = 1;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(93, 384);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 20);
            this.txtCantidad.TabIndex = 4;
            // 
            // btnMover
            // 
            this.btnMover.Location = new System.Drawing.Point(12, 415);
            this.btnMover.Name = "btnMover";
            this.btnMover.Size = new System.Drawing.Size(75, 23);
            this.btnMover.TabIndex = 5;
            this.btnMover.Text = "Mover";
            this.btnMover.UseVisualStyleBackColor = true;
            this.btnMover.Click += new System.EventHandler(this.btnMover_Click);
            // 
            // lblContador
            // 
            this.lblContador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblContador.Location = new System.Drawing.Point(93, 415);
            this.lblContador.Name = "lblContador";
            this.lblContador.Size = new System.Drawing.Size(100, 23);
            this.lblContador.TabIndex = 6;
            this.lblContador.Text = "Contador : 0";
            this.lblContador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerMov
            // 
            this.timerMov.Interval = 50;
            this.timerMov.Tick += new System.EventHandler(this.timerMov_Tick);
            // 
            // frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblContador);
            this.Controls.Add(this.btnMover);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.btnCrear);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Button btnMover;
        private System.Windows.Forms.Label lblContador;
        private System.Windows.Forms.Timer timerMov;
    }
}

