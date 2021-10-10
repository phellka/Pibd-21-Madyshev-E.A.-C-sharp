
namespace WindowsFormsPlane
{
    partial class FormAirfield
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.pictureBoxAirfield = new System.Windows.Forms.PictureBox();
            this.buttonParkPlane = new System.Windows.Forms.Button();
            this.buttonParkPlaneRadar = new System.Windows.Forms.Button();
            this.groupBoxDelPlane = new System.Windows.Forms.GroupBox();
            this.buttonDelPlane = new System.Windows.Forms.Button();
            this.maskedTextBoxDelPlane = new System.Windows.Forms.MaskedTextBox();
            this.labelDelPlane = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAirfield)).BeginInit();
            this.groupBoxDelPlane.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxAirfield
            // 
            this.pictureBoxAirfield.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxAirfield.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxAirfield.Name = "pictureBoxAirfield";
            this.pictureBoxAirfield.Size = new System.Drawing.Size(672, 461);
            this.pictureBoxAirfield.TabIndex = 0;
            this.pictureBoxAirfield.TabStop = false;
            // 
            // buttonParkPlane
            // 
            this.buttonParkPlane.Location = new System.Drawing.Point(687, 12);
            this.buttonParkPlane.Name = "buttonParkPlane";
            this.buttonParkPlane.Size = new System.Drawing.Size(89, 38);
            this.buttonParkPlane.TabIndex = 1;
            this.buttonParkPlane.Text = "Припарковать самолет";
            this.buttonParkPlane.UseVisualStyleBackColor = true;
            this.buttonParkPlane.Click += new System.EventHandler(this.buttonSetPlane_Click);
            // 
            // buttonParkPlaneRadar
            // 
            this.buttonParkPlaneRadar.Location = new System.Drawing.Point(687, 56);
            this.buttonParkPlaneRadar.Name = "buttonParkPlaneRadar";
            this.buttonParkPlaneRadar.Size = new System.Drawing.Size(89, 48);
            this.buttonParkPlaneRadar.TabIndex = 2;
            this.buttonParkPlaneRadar.Text = "Припарковать самолет с радаром";
            this.buttonParkPlaneRadar.UseVisualStyleBackColor = true;
            this.buttonParkPlaneRadar.Click += new System.EventHandler(this.buttonSetPlaneRadar_Click);
            // 
            // groupBoxDelPlane
            // 
            this.groupBoxDelPlane.Controls.Add(this.buttonDelPlane);
            this.groupBoxDelPlane.Controls.Add(this.maskedTextBoxDelPlane);
            this.groupBoxDelPlane.Controls.Add(this.labelDelPlane);
            this.groupBoxDelPlane.Location = new System.Drawing.Point(678, 110);
            this.groupBoxDelPlane.Name = "groupBoxDelPlane";
            this.groupBoxDelPlane.Size = new System.Drawing.Size(110, 83);
            this.groupBoxDelPlane.TabIndex = 3;
            this.groupBoxDelPlane.TabStop = false;
            this.groupBoxDelPlane.Text = "Забрать самолет";
            // 
            // buttonDelPlane
            // 
            this.buttonDelPlane.Location = new System.Drawing.Point(9, 49);
            this.buttonDelPlane.Name = "buttonDelPlane";
            this.buttonDelPlane.Size = new System.Drawing.Size(75, 23);
            this.buttonDelPlane.TabIndex = 2;
            this.buttonDelPlane.Text = "Забрать";
            this.buttonDelPlane.UseVisualStyleBackColor = true;
            this.buttonDelPlane.Click += new System.EventHandler(this.buttonTakePlane_Click);
            // 
            // maskedTextBoxDelPlane
            // 
            this.maskedTextBoxDelPlane.Location = new System.Drawing.Point(54, 23);
            this.maskedTextBoxDelPlane.Mask = "00";
            this.maskedTextBoxDelPlane.Name = "maskedTextBoxDelPlane";
            this.maskedTextBoxDelPlane.Size = new System.Drawing.Size(27, 20);
            this.maskedTextBoxDelPlane.TabIndex = 1;
            // 
            // labelDelPlane
            // 
            this.labelDelPlane.AutoSize = true;
            this.labelDelPlane.Location = new System.Drawing.Point(6, 26);
            this.labelDelPlane.Name = "labelDelPlane";
            this.labelDelPlane.Size = new System.Drawing.Size(42, 13);
            this.labelDelPlane.TabIndex = 0;
            this.labelDelPlane.Text = "Место:";
            // 
            // FormAirfield
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 461);
            this.Controls.Add(this.groupBoxDelPlane);
            this.Controls.Add(this.buttonParkPlaneRadar);
            this.Controls.Add(this.buttonParkPlane);
            this.Controls.Add(this.pictureBoxAirfield);
            this.Name = "FormAirfield";
            this.Text = "Аэродром";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAirfield)).EndInit();
            this.groupBoxDelPlane.ResumeLayout(false);
            this.groupBoxDelPlane.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAirfield;
        private System.Windows.Forms.Button buttonParkPlane;
        private System.Windows.Forms.Button buttonParkPlaneRadar;
        private System.Windows.Forms.GroupBox groupBoxDelPlane;
        private System.Windows.Forms.Button buttonDelPlane;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDelPlane;
        private System.Windows.Forms.Label labelDelPlane;
    }
}