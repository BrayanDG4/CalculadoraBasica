
namespace WindowsFormsCalculator
{
    partial class Calculadora
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
            this.btnSuma = new System.Windows.Forms.Button();
            this.btnN7 = new System.Windows.Forms.Button();
            this.btnN1 = new System.Windows.Forms.Button();
            this.btnN4 = new System.Windows.Forms.Button();
            this.btnN2 = new System.Windows.Forms.Button();
            this.btnN5 = new System.Windows.Forms.Button();
            this.btnN8 = new System.Windows.Forms.Button();
            this.btnResta = new System.Windows.Forms.Button();
            this.btnN3 = new System.Windows.Forms.Button();
            this.btnN6 = new System.Windows.Forms.Button();
            this.btnN9 = new System.Windows.Forms.Button();
            this.btnMultiplicacion = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDivision = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.btnPunto = new System.Windows.Forms.Button();
            this.btnN0 = new System.Windows.Forms.Button();
            this.txbScreen = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSuma
            // 
            this.btnSuma.BackColor = System.Drawing.Color.GhostWhite;
            this.btnSuma.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSuma.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuma.Location = new System.Drawing.Point(11, 67);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(50, 45);
            this.btnSuma.TabIndex = 0;
            this.btnSuma.Text = "+";
            this.btnSuma.UseVisualStyleBackColor = false;
            this.btnSuma.Click += new System.EventHandler(this.btnSuma_Click);
            // 
            // btnN7
            // 
            this.btnN7.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnN7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnN7.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnN7.Location = new System.Drawing.Point(11, 118);
            this.btnN7.Name = "btnN7";
            this.btnN7.Size = new System.Drawing.Size(50, 45);
            this.btnN7.TabIndex = 1;
            this.btnN7.Text = "7";
            this.btnN7.UseVisualStyleBackColor = false;
            this.btnN7.Click += new System.EventHandler(this.btnN7_Click);
            // 
            // btnN1
            // 
            this.btnN1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnN1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnN1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnN1.Location = new System.Drawing.Point(11, 220);
            this.btnN1.Name = "btnN1";
            this.btnN1.Size = new System.Drawing.Size(50, 45);
            this.btnN1.TabIndex = 3;
            this.btnN1.Text = "1";
            this.btnN1.UseVisualStyleBackColor = false;
            this.btnN1.Click += new System.EventHandler(this.btnN1_Click);
            // 
            // btnN4
            // 
            this.btnN4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnN4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnN4.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnN4.Location = new System.Drawing.Point(11, 169);
            this.btnN4.Name = "btnN4";
            this.btnN4.Size = new System.Drawing.Size(50, 45);
            this.btnN4.TabIndex = 2;
            this.btnN4.Text = "4";
            this.btnN4.UseVisualStyleBackColor = false;
            this.btnN4.Click += new System.EventHandler(this.btnN4_Click);
            // 
            // btnN2
            // 
            this.btnN2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnN2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnN2.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnN2.Location = new System.Drawing.Point(62, 220);
            this.btnN2.Name = "btnN2";
            this.btnN2.Size = new System.Drawing.Size(50, 45);
            this.btnN2.TabIndex = 7;
            this.btnN2.Text = "2";
            this.btnN2.UseVisualStyleBackColor = false;
            this.btnN2.Click += new System.EventHandler(this.btnN2_Click);
            // 
            // btnN5
            // 
            this.btnN5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnN5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnN5.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnN5.Location = new System.Drawing.Point(62, 169);
            this.btnN5.Name = "btnN5";
            this.btnN5.Size = new System.Drawing.Size(50, 45);
            this.btnN5.TabIndex = 6;
            this.btnN5.Text = "5";
            this.btnN5.UseVisualStyleBackColor = false;
            this.btnN5.Click += new System.EventHandler(this.btnN5_Click);
            // 
            // btnN8
            // 
            this.btnN8.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnN8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnN8.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnN8.Location = new System.Drawing.Point(62, 118);
            this.btnN8.Name = "btnN8";
            this.btnN8.Size = new System.Drawing.Size(50, 45);
            this.btnN8.TabIndex = 5;
            this.btnN8.Text = "8";
            this.btnN8.UseVisualStyleBackColor = false;
            this.btnN8.Click += new System.EventHandler(this.btnN8_Click);
            // 
            // btnResta
            // 
            this.btnResta.BackColor = System.Drawing.Color.GhostWhite;
            this.btnResta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnResta.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResta.Location = new System.Drawing.Point(62, 67);
            this.btnResta.Name = "btnResta";
            this.btnResta.Size = new System.Drawing.Size(50, 45);
            this.btnResta.TabIndex = 4;
            this.btnResta.Text = "-";
            this.btnResta.UseVisualStyleBackColor = false;
            this.btnResta.Click += new System.EventHandler(this.btnResta_Click);
            // 
            // btnN3
            // 
            this.btnN3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnN3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnN3.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnN3.Location = new System.Drawing.Point(113, 220);
            this.btnN3.Name = "btnN3";
            this.btnN3.Size = new System.Drawing.Size(50, 45);
            this.btnN3.TabIndex = 11;
            this.btnN3.Text = "3";
            this.btnN3.UseVisualStyleBackColor = false;
            this.btnN3.Click += new System.EventHandler(this.btnN3_Click);
            // 
            // btnN6
            // 
            this.btnN6.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnN6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnN6.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnN6.Location = new System.Drawing.Point(113, 169);
            this.btnN6.Name = "btnN6";
            this.btnN6.Size = new System.Drawing.Size(50, 45);
            this.btnN6.TabIndex = 10;
            this.btnN6.Text = "6";
            this.btnN6.UseVisualStyleBackColor = false;
            this.btnN6.Click += new System.EventHandler(this.btnN6_Click);
            // 
            // btnN9
            // 
            this.btnN9.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnN9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnN9.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnN9.Location = new System.Drawing.Point(113, 118);
            this.btnN9.Name = "btnN9";
            this.btnN9.Size = new System.Drawing.Size(50, 45);
            this.btnN9.TabIndex = 9;
            this.btnN9.Text = "9";
            this.btnN9.UseVisualStyleBackColor = false;
            this.btnN9.Click += new System.EventHandler(this.btnN9_Click);
            // 
            // btnMultiplicacion
            // 
            this.btnMultiplicacion.BackColor = System.Drawing.Color.GhostWhite;
            this.btnMultiplicacion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMultiplicacion.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiplicacion.Location = new System.Drawing.Point(113, 67);
            this.btnMultiplicacion.Name = "btnMultiplicacion";
            this.btnMultiplicacion.Size = new System.Drawing.Size(50, 45);
            this.btnMultiplicacion.TabIndex = 8;
            this.btnMultiplicacion.Text = "*";
            this.btnMultiplicacion.UseVisualStyleBackColor = false;
            this.btnMultiplicacion.Click += new System.EventHandler(this.btnMultiplicacion_Click);
            // 
            // btnClearAll
            // 
            this.btnClearAll.BackColor = System.Drawing.Color.GhostWhite;
            this.btnClearAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClearAll.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearAll.Location = new System.Drawing.Point(164, 169);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(50, 45);
            this.btnClearAll.TabIndex = 14;
            this.btnClearAll.Text = "AC";
            this.btnClearAll.UseVisualStyleBackColor = false;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.GhostWhite;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(164, 118);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(50, 45);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDivision
            // 
            this.btnDivision.BackColor = System.Drawing.Color.GhostWhite;
            this.btnDivision.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDivision.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivision.Location = new System.Drawing.Point(164, 67);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(50, 45);
            this.btnDivision.TabIndex = 12;
            this.btnDivision.Text = "/";
            this.btnDivision.UseVisualStyleBackColor = false;
            this.btnDivision.Click += new System.EventHandler(this.btnDivision_Click);
            // 
            // btnEqual
            // 
            this.btnEqual.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnEqual.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEqual.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEqual.Location = new System.Drawing.Point(164, 220);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(50, 96);
            this.btnEqual.TabIndex = 19;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = false;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // btnPunto
            // 
            this.btnPunto.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnPunto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPunto.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPunto.Location = new System.Drawing.Point(113, 271);
            this.btnPunto.Name = "btnPunto";
            this.btnPunto.Size = new System.Drawing.Size(50, 45);
            this.btnPunto.TabIndex = 18;
            this.btnPunto.Text = ",";
            this.btnPunto.UseVisualStyleBackColor = false;
            this.btnPunto.Click += new System.EventHandler(this.btnPunto_Click);
            // 
            // btnN0
            // 
            this.btnN0.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnN0.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnN0.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnN0.Location = new System.Drawing.Point(11, 271);
            this.btnN0.Name = "btnN0";
            this.btnN0.Size = new System.Drawing.Size(101, 45);
            this.btnN0.TabIndex = 16;
            this.btnN0.Text = "0";
            this.btnN0.UseVisualStyleBackColor = false;
            this.btnN0.Click += new System.EventHandler(this.btnN0_Click);
            // 
            // txbScreen
            // 
            this.txbScreen.BackColor = System.Drawing.Color.MediumAquamarine;
            this.txbScreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbScreen.Font = new System.Drawing.Font("Verdana", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbScreen.Location = new System.Drawing.Point(11, 8);
            this.txbScreen.Name = "txbScreen";
            this.txbScreen.ReadOnly = true;
            this.txbScreen.Size = new System.Drawing.Size(203, 50);
            this.txbScreen.TabIndex = 20;
            this.txbScreen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 326);
            this.Controls.Add(this.txbScreen);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.btnPunto);
            this.Controls.Add(this.btnN0);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDivision);
            this.Controls.Add(this.btnN3);
            this.Controls.Add(this.btnN6);
            this.Controls.Add(this.btnN9);
            this.Controls.Add(this.btnMultiplicacion);
            this.Controls.Add(this.btnN2);
            this.Controls.Add(this.btnN5);
            this.Controls.Add(this.btnN8);
            this.Controls.Add(this.btnResta);
            this.Controls.Add(this.btnN1);
            this.Controls.Add(this.btnN4);
            this.Controls.Add(this.btnN7);
            this.Controls.Add(this.btnSuma);
            this.MaximizeBox = false;
            this.Name = "Calculadora";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSuma;
        private System.Windows.Forms.Button btnN7;
        private System.Windows.Forms.Button btnN1;
        private System.Windows.Forms.Button btnN4;
        private System.Windows.Forms.Button btnN2;
        private System.Windows.Forms.Button btnN5;
        private System.Windows.Forms.Button btnN8;
        private System.Windows.Forms.Button btnResta;
        private System.Windows.Forms.Button btnN3;
        private System.Windows.Forms.Button btnN6;
        private System.Windows.Forms.Button btnN9;
        private System.Windows.Forms.Button btnMultiplicacion;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDivision;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Button btnPunto;
        private System.Windows.Forms.Button btnN0;
        private System.Windows.Forms.TextBox txbScreen;
    }
}

