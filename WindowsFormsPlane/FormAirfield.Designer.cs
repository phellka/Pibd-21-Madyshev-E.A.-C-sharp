
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
            this.buttonAddPlane = new System.Windows.Forms.Button();
            this.groupBoxDelPlane = new System.Windows.Forms.GroupBox();
            this.buttonDelPlane = new System.Windows.Forms.Button();
            this.maskedTextBoxDelPlane = new System.Windows.Forms.MaskedTextBox();
            this.labelDelPlane = new System.Windows.Forms.Label();
            this.listBoxAirfields = new System.Windows.Forms.ListBox();
            this.buttonDelAirfield = new System.Windows.Forms.Button();
            this.buttonAddAirfield = new System.Windows.Forms.Button();
            this.textBoxNewAirfield = new System.Windows.Forms.TextBox();
            this.labelAirfield = new System.Windows.Forms.Label();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAirfield)).BeginInit();
            this.groupBoxDelPlane.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxAirfield
            // 
            this.pictureBoxAirfield.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxAirfield.Location = new System.Drawing.Point(0, 24);
            this.pictureBoxAirfield.Name = "pictureBoxAirfield";
            this.pictureBoxAirfield.Size = new System.Drawing.Size(672, 437);
            this.pictureBoxAirfield.TabIndex = 0;
            this.pictureBoxAirfield.TabStop = false;
            // 
            // buttonAddPlane
            // 
            this.buttonAddPlane.Location = new System.Drawing.Point(676, 248);
            this.buttonAddPlane.Name = "buttonAddPlane";
            this.buttonAddPlane.Size = new System.Drawing.Size(121, 38);
            this.buttonAddPlane.TabIndex = 1;
            this.buttonAddPlane.Text = "Припарковать самолет";
            this.buttonAddPlane.UseVisualStyleBackColor = true;
            this.buttonAddPlane.Click += new System.EventHandler(this.buttonAddPlane_Click);
            // 
            // groupBoxDelPlane
            // 
            this.groupBoxDelPlane.Controls.Add(this.buttonDelPlane);
            this.groupBoxDelPlane.Controls.Add(this.maskedTextBoxDelPlane);
            this.groupBoxDelPlane.Controls.Add(this.labelDelPlane);
            this.groupBoxDelPlane.Location = new System.Drawing.Point(678, 366);
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
            // listBoxAirfields
            // 
            this.listBoxAirfields.FormattingEnabled = true;
            this.listBoxAirfields.Location = new System.Drawing.Point(676, 80);
            this.listBoxAirfields.Name = "listBoxAirfields";
            this.listBoxAirfields.Size = new System.Drawing.Size(121, 95);
            this.listBoxAirfields.TabIndex = 13;
            this.listBoxAirfields.SelectedIndexChanged += new System.EventHandler(this.listBoxAirfields_SelectedIndexChanged);
            // 
            // buttonDelAirfield
            // 
            this.buttonDelAirfield.Location = new System.Drawing.Point(676, 181);
            this.buttonDelAirfield.Name = "buttonDelAirfield";
            this.buttonDelAirfield.Size = new System.Drawing.Size(121, 23);
            this.buttonDelAirfield.TabIndex = 12;
            this.buttonDelAirfield.Text = "Удалить аэродром";
            this.buttonDelAirfield.UseVisualStyleBackColor = true;
            this.buttonDelAirfield.Click += new System.EventHandler(this.buttonDelAirfield_Click);
            // 
            // buttonAddAirfield
            // 
            this.buttonAddAirfield.Location = new System.Drawing.Point(676, 51);
            this.buttonAddAirfield.Name = "buttonAddAirfield";
            this.buttonAddAirfield.Size = new System.Drawing.Size(121, 23);
            this.buttonAddAirfield.TabIndex = 11;
            this.buttonAddAirfield.Text = "Добавить аэродром";
            this.buttonAddAirfield.UseVisualStyleBackColor = true;
            this.buttonAddAirfield.Click += new System.EventHandler(this.buttonAddAirfield_Click);
            // 
            // textBoxNewAirfield
            // 
            this.textBoxNewAirfield.Location = new System.Drawing.Point(676, 25);
            this.textBoxNewAirfield.Name = "textBoxNewAirfield";
            this.textBoxNewAirfield.Size = new System.Drawing.Size(121, 20);
            this.textBoxNewAirfield.TabIndex = 10;
            // 
            // labelAirfield
            // 
            this.labelAirfield.AutoSize = true;
            this.labelAirfield.Location = new System.Drawing.Point(707, 9);
            this.labelAirfield.Name = "labelAirfield";
            this.labelAirfield.Size = new System.Drawing.Size(69, 13);
            this.labelAirfield.TabIndex = 9;
            this.labelAirfield.Text = "Аэродромы:";
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 24);
            this.menuStrip.TabIndex = 14;
            this.menuStrip.Text = "menuStrip";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.FileToolStripMenuItem.Text = "Файл";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Сохранить";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loadToolStripMenuItem.Text = "Загрузить";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.Filter = "txt file | *.txt";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "txt file | *.txt";
            // 
            // FormAirfield
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 461);
            this.Controls.Add(this.listBoxAirfields);
            this.Controls.Add(this.buttonDelAirfield);
            this.Controls.Add(this.buttonAddAirfield);
            this.Controls.Add(this.textBoxNewAirfield);
            this.Controls.Add(this.labelAirfield);
            this.Controls.Add(this.groupBoxDelPlane);
            this.Controls.Add(this.buttonAddPlane);
            this.Controls.Add(this.pictureBoxAirfield);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FormAirfield";
            this.Text = "Аэродром";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAirfield)).EndInit();
            this.groupBoxDelPlane.ResumeLayout(false);
            this.groupBoxDelPlane.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAirfield;
        private System.Windows.Forms.Button buttonAddPlane;
        private System.Windows.Forms.GroupBox groupBoxDelPlane;
        private System.Windows.Forms.Button buttonDelPlane;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDelPlane;
        private System.Windows.Forms.Label labelDelPlane;
        private System.Windows.Forms.ListBox listBoxAirfields;
        private System.Windows.Forms.Button buttonDelAirfield;
        private System.Windows.Forms.Button buttonAddAirfield;
        private System.Windows.Forms.TextBox textBoxNewAirfield;
        private System.Windows.Forms.Label labelAirfield;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}