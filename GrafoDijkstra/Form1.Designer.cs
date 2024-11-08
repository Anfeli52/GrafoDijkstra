namespace GrafoDijkstra
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
            this.txtTamano = new System.Windows.Forms.TextBox();
            this.btnGenerarMatriz = new System.Windows.Forms.Button();
            this.lblInicio = new System.Windows.Forms.Label();
            this.txtInicio = new System.Windows.Forms.TextBox();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.lblDestino = new System.Windows.Forms.Label();
            this.btnCalcularCamino = new System.Windows.Forms.Button();
            this.panelMatriz = new System.Windows.Forms.Panel();
            this.rtbResultado = new System.Windows.Forms.RichTextBox();
            this.lblTamano = new System.Windows.Forms.Label();
            this.btnDibujadorGrafo_Click = new System.Windows.Forms.Button();
            this.panelDibujo = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // txtTamano
            // 
            this.txtTamano.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTamano.Location = new System.Drawing.Point(31, 36);
            this.txtTamano.Name = "txtTamano";
            this.txtTamano.Size = new System.Drawing.Size(205, 33);
            this.txtTamano.TabIndex = 1;
            // 
            // btnGenerarMatriz
            // 
            this.btnGenerarMatriz.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarMatriz.Location = new System.Drawing.Point(30, 75);
            this.btnGenerarMatriz.Name = "btnGenerarMatriz";
            this.btnGenerarMatriz.Size = new System.Drawing.Size(206, 68);
            this.btnGenerarMatriz.TabIndex = 2;
            this.btnGenerarMatriz.Text = "Generar Matríz";
            this.btnGenerarMatriz.UseVisualStyleBackColor = true;
            this.btnGenerarMatriz.Click += new System.EventHandler(this.btnGenerarMatriz_Click_1);
            // 
            // lblInicio
            // 
            this.lblInicio.AutoSize = true;
            this.lblInicio.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInicio.Location = new System.Drawing.Point(27, 199);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(114, 21);
            this.lblInicio.TabIndex = 3;
            this.lblInicio.Text = "Nodo de Inicio";
            // 
            // txtInicio
            // 
            this.txtInicio.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInicio.Location = new System.Drawing.Point(30, 223);
            this.txtInicio.Name = "txtInicio";
            this.txtInicio.Size = new System.Drawing.Size(206, 33);
            this.txtInicio.TabIndex = 4;
            // 
            // txtDestino
            // 
            this.txtDestino.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDestino.Location = new System.Drawing.Point(31, 293);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(204, 29);
            this.txtDestino.TabIndex = 5;
            // 
            // lblDestino
            // 
            this.lblDestino.AutoSize = true;
            this.lblDestino.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestino.Location = new System.Drawing.Point(27, 269);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(134, 21);
            this.lblDestino.TabIndex = 6;
            this.lblDestino.Text = "Nodo de Destino:";
            // 
            // btnCalcularCamino
            // 
            this.btnCalcularCamino.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularCamino.Location = new System.Drawing.Point(31, 328);
            this.btnCalcularCamino.Name = "btnCalcularCamino";
            this.btnCalcularCamino.Size = new System.Drawing.Size(206, 68);
            this.btnCalcularCamino.TabIndex = 7;
            this.btnCalcularCamino.Text = "Calcular Camino Más Corto";
            this.btnCalcularCamino.UseVisualStyleBackColor = true;
            this.btnCalcularCamino.Click += new System.EventHandler(this.btnCalcularCamino_Click_1);
            // 
            // panelMatriz
            // 
            this.panelMatriz.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelMatriz.Location = new System.Drawing.Point(269, 12);
            this.panelMatriz.Name = "panelMatriz";
            this.panelMatriz.Size = new System.Drawing.Size(600, 600);
            this.panelMatriz.TabIndex = 8;
            // 
            // rtbResultado
            // 
            this.rtbResultado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbResultado.Location = new System.Drawing.Point(31, 402);
            this.rtbResultado.Name = "rtbResultado";
            this.rtbResultado.Size = new System.Drawing.Size(204, 80);
            this.rtbResultado.TabIndex = 9;
            this.rtbResultado.Text = "";
            // 
            // lblTamano
            // 
            this.lblTamano.AutoSize = true;
            this.lblTamano.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTamano.Location = new System.Drawing.Point(27, 12);
            this.lblTamano.Name = "lblTamano";
            this.lblTamano.Size = new System.Drawing.Size(212, 21);
            this.lblTamano.TabIndex = 0;
            this.lblTamano.Text = "Ingrese el Número de Nodos";
            // 
            // btnDibujadorGrafo_Click
            // 
            this.btnDibujadorGrafo_Click.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDibujadorGrafo_Click.Location = new System.Drawing.Point(31, 546);
            this.btnDibujadorGrafo_Click.Name = "btnDibujadorGrafo_Click";
            this.btnDibujadorGrafo_Click.Size = new System.Drawing.Size(204, 66);
            this.btnDibujadorGrafo_Click.TabIndex = 10;
            this.btnDibujadorGrafo_Click.Text = "Dibujar Grafo";
            this.btnDibujadorGrafo_Click.UseVisualStyleBackColor = true;
            this.btnDibujadorGrafo_Click.Click += new System.EventHandler(this.btnDibujadorGrafo_Click_Click);
            // 
            // panelDibujo
            // 
            this.panelDibujo.BackColor = System.Drawing.SystemColors.Control;
            this.panelDibujo.Location = new System.Drawing.Point(875, 12);
            this.panelDibujo.Name = "panelDibujo";
            this.panelDibujo.Size = new System.Drawing.Size(600, 600);
            this.panelDibujo.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1496, 628);
            this.Controls.Add(this.panelDibujo);
            this.Controls.Add(this.btnDibujadorGrafo_Click);
            this.Controls.Add(this.rtbResultado);
            this.Controls.Add(this.panelMatriz);
            this.Controls.Add(this.btnCalcularCamino);
            this.Controls.Add(this.lblDestino);
            this.Controls.Add(this.txtDestino);
            this.Controls.Add(this.txtInicio);
            this.Controls.Add(this.lblInicio);
            this.Controls.Add(this.btnGenerarMatriz);
            this.Controls.Add(this.txtTamano);
            this.Controls.Add(this.lblTamano);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtTamano;
        private System.Windows.Forms.Button btnGenerarMatriz;
        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.TextBox txtInicio;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.Label lblDestino;
        private System.Windows.Forms.Button btnCalcularCamino;
        private System.Windows.Forms.Panel panelMatriz;
        private System.Windows.Forms.RichTextBox rtbResultado;
        private System.Windows.Forms.Label lblTamano;
        private System.Windows.Forms.Button btnDibujadorGrafo_Click;
        private System.Windows.Forms.Panel panelDibujo;
    }
}

