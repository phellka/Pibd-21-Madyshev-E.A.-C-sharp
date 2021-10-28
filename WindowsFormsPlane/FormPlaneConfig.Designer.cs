
namespace WindowsFormsPlane
{
    partial class FormPlaneConfig
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
            this.panelShowPlane = new System.Windows.Forms.Panel();
            this.pictureBoxShowPlane = new System.Windows.Forms.PictureBox();
            this.groupBoxColors = new System.Windows.Forms.GroupBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonAddPlane = new System.Windows.Forms.Button();
            this.panelOrange = new System.Windows.Forms.Panel();
            this.panelWhite = new System.Windows.Forms.Panel();
            this.panelNavy = new System.Windows.Forms.Panel();
            this.panelGreen = new System.Windows.Forms.Panel();
            this.panelPink = new System.Windows.Forms.Panel();
            this.panelBlack = new System.Windows.Forms.Panel();
            this.panelYellow = new System.Windows.Forms.Panel();
            this.panelRed = new System.Windows.Forms.Panel();
            this.labelDopColor = new System.Windows.Forms.Label();
            this.labelMainColor = new System.Windows.Forms.Label();
            this.groupBoxPlaneParametrs = new System.Windows.Forms.GroupBox();
            this.checkBoxEngine = new System.Windows.Forms.CheckBox();
            this.checkBoxRadar = new System.Windows.Forms.CheckBox();
            this.numericUpDownWeight = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMaxSpeed = new System.Windows.Forms.NumericUpDown();
            this.labelPlaneWeight = new System.Windows.Forms.Label();
            this.labelMaxSpeed = new System.Windows.Forms.Label();
            this.groupBoxPlaneType = new System.Windows.Forms.GroupBox();
            this.labelPlaneRadar = new System.Windows.Forms.Label();
            this.labelPlane = new System.Windows.Forms.Label();
            this.panelShowPlane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShowPlane)).BeginInit();
            this.groupBoxColors.SuspendLayout();
            this.groupBoxPlaneParametrs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxSpeed)).BeginInit();
            this.groupBoxPlaneType.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelShowPlane
            // 
            this.panelShowPlane.AllowDrop = true;
            this.panelShowPlane.Controls.Add(this.pictureBoxShowPlane);
            this.panelShowPlane.Location = new System.Drawing.Point(126, 12);
            this.panelShowPlane.Name = "panelShowPlane";
            this.panelShowPlane.Size = new System.Drawing.Size(255, 122);
            this.panelShowPlane.TabIndex = 6;
            this.panelShowPlane.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelShowPlane_DragDrop);
            this.panelShowPlane.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelShowPlane_DragEnter);
            // 
            // pictureBoxShowPlane
            // 
            this.pictureBoxShowPlane.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxShowPlane.Name = "pictureBoxShowPlane";
            this.pictureBoxShowPlane.Size = new System.Drawing.Size(249, 116);
            this.pictureBoxShowPlane.TabIndex = 0;
            this.pictureBoxShowPlane.TabStop = false;
            // 
            // groupBoxColors
            // 
            this.groupBoxColors.Controls.Add(this.buttonCancel);
            this.groupBoxColors.Controls.Add(this.buttonAddPlane);
            this.groupBoxColors.Controls.Add(this.panelOrange);
            this.groupBoxColors.Controls.Add(this.panelWhite);
            this.groupBoxColors.Controls.Add(this.panelNavy);
            this.groupBoxColors.Controls.Add(this.panelGreen);
            this.groupBoxColors.Controls.Add(this.panelPink);
            this.groupBoxColors.Controls.Add(this.panelBlack);
            this.groupBoxColors.Controls.Add(this.panelYellow);
            this.groupBoxColors.Controls.Add(this.panelRed);
            this.groupBoxColors.Controls.Add(this.labelDopColor);
            this.groupBoxColors.Controls.Add(this.labelMainColor);
            this.groupBoxColors.Location = new System.Drawing.Point(387, 12);
            this.groupBoxColors.Name = "groupBoxColors";
            this.groupBoxColors.Size = new System.Drawing.Size(200, 206);
            this.groupBoxColors.TabIndex = 4;
            this.groupBoxColors.TabStop = false;
            this.groupBoxColors.Text = "Цвета";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(119, 176);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 20;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonAddPlane
            // 
            this.buttonAddPlane.Location = new System.Drawing.Point(119, 147);
            this.buttonAddPlane.Name = "buttonAddPlane";
            this.buttonAddPlane.Size = new System.Drawing.Size(75, 23);
            this.buttonAddPlane.TabIndex = 19;
            this.buttonAddPlane.Text = "Добавить";
            this.buttonAddPlane.UseVisualStyleBackColor = true;
            this.buttonAddPlane.Click += new System.EventHandler(this.buttonAddPlane_Click);
            // 
            // panelOrange
            // 
            this.panelOrange.BackColor = System.Drawing.Color.Orange;
            this.panelOrange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelOrange.Location = new System.Drawing.Point(144, 106);
            this.panelOrange.Name = "panelOrange";
            this.panelOrange.Size = new System.Drawing.Size(35, 35);
            this.panelOrange.TabIndex = 16;
            // 
            // panelWhite
            // 
            this.panelWhite.BackColor = System.Drawing.Color.White;
            this.panelWhite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelWhite.Location = new System.Drawing.Point(144, 65);
            this.panelWhite.Name = "panelWhite";
            this.panelWhite.Size = new System.Drawing.Size(35, 35);
            this.panelWhite.TabIndex = 12;
            // 
            // panelNavy
            // 
            this.panelNavy.BackColor = System.Drawing.Color.Navy;
            this.panelNavy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelNavy.Location = new System.Drawing.Point(103, 106);
            this.panelNavy.Name = "panelNavy";
            this.panelNavy.Size = new System.Drawing.Size(35, 35);
            this.panelNavy.TabIndex = 17;
            // 
            // panelGreen
            // 
            this.panelGreen.BackColor = System.Drawing.Color.Green;
            this.panelGreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGreen.Location = new System.Drawing.Point(103, 65);
            this.panelGreen.Name = "panelGreen";
            this.panelGreen.Size = new System.Drawing.Size(35, 35);
            this.panelGreen.TabIndex = 13;
            // 
            // panelPink
            // 
            this.panelPink.BackColor = System.Drawing.Color.Pink;
            this.panelPink.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPink.Location = new System.Drawing.Point(62, 106);
            this.panelPink.Name = "panelPink";
            this.panelPink.Size = new System.Drawing.Size(35, 35);
            this.panelPink.TabIndex = 18;
            // 
            // panelBlack
            // 
            this.panelBlack.BackColor = System.Drawing.Color.Black;
            this.panelBlack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBlack.Location = new System.Drawing.Point(21, 106);
            this.panelBlack.Name = "panelBlack";
            this.panelBlack.Size = new System.Drawing.Size(35, 35);
            this.panelBlack.TabIndex = 15;
            // 
            // panelYellow
            // 
            this.panelYellow.BackColor = System.Drawing.Color.Yellow;
            this.panelYellow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelYellow.Location = new System.Drawing.Point(62, 65);
            this.panelYellow.Name = "panelYellow";
            this.panelYellow.Size = new System.Drawing.Size(35, 35);
            this.panelYellow.TabIndex = 14;
            // 
            // panelRed
            // 
            this.panelRed.BackColor = System.Drawing.Color.Red;
            this.panelRed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRed.Location = new System.Drawing.Point(21, 65);
            this.panelRed.Name = "panelRed";
            this.panelRed.Size = new System.Drawing.Size(35, 35);
            this.panelRed.TabIndex = 11;
            // 
            // labelDopColor
            // 
            this.labelDopColor.AllowDrop = true;
            this.labelDopColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDopColor.Location = new System.Drawing.Point(98, 16);
            this.labelDopColor.Name = "labelDopColor";
            this.labelDopColor.Size = new System.Drawing.Size(86, 37);
            this.labelDopColor.TabIndex = 5;
            this.labelDopColor.Text = "Доп. цвет";
            this.labelDopColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelDopColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelDopColor_DragDrop);
            this.labelDopColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelColor_DragEnter);
            // 
            // labelMainColor
            // 
            this.labelMainColor.AllowDrop = true;
            this.labelMainColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelMainColor.Location = new System.Drawing.Point(6, 16);
            this.labelMainColor.Name = "labelMainColor";
            this.labelMainColor.Size = new System.Drawing.Size(86, 37);
            this.labelMainColor.TabIndex = 4;
            this.labelMainColor.Text = "Основной цвет";
            this.labelMainColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelMainColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelMainColor_DragDrop);
            this.labelMainColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelColor_DragEnter);
            // 
            // groupBoxPlaneParametrs
            // 
            this.groupBoxPlaneParametrs.Controls.Add(this.checkBoxEngine);
            this.groupBoxPlaneParametrs.Controls.Add(this.checkBoxRadar);
            this.groupBoxPlaneParametrs.Controls.Add(this.numericUpDownWeight);
            this.groupBoxPlaneParametrs.Controls.Add(this.numericUpDownMaxSpeed);
            this.groupBoxPlaneParametrs.Controls.Add(this.labelPlaneWeight);
            this.groupBoxPlaneParametrs.Controls.Add(this.labelMaxSpeed);
            this.groupBoxPlaneParametrs.Location = new System.Drawing.Point(12, 140);
            this.groupBoxPlaneParametrs.Name = "groupBoxPlaneParametrs";
            this.groupBoxPlaneParametrs.Size = new System.Drawing.Size(246, 117);
            this.groupBoxPlaneParametrs.TabIndex = 5;
            this.groupBoxPlaneParametrs.TabStop = false;
            this.groupBoxPlaneParametrs.Text = "Параметры";
            // 
            // checkBoxEngine
            // 
            this.checkBoxEngine.AutoSize = true;
            this.checkBoxEngine.Location = new System.Drawing.Point(149, 55);
            this.checkBoxEngine.Name = "checkBoxEngine";
            this.checkBoxEngine.Size = new System.Drawing.Size(81, 17);
            this.checkBoxEngine.TabIndex = 5;
            this.checkBoxEngine.Text = "Двигатель";
            this.checkBoxEngine.UseVisualStyleBackColor = true;
            // 
            // checkBoxRadar
            // 
            this.checkBoxRadar.AutoSize = true;
            this.checkBoxRadar.Location = new System.Drawing.Point(149, 32);
            this.checkBoxRadar.Name = "checkBoxRadar";
            this.checkBoxRadar.Size = new System.Drawing.Size(57, 17);
            this.checkBoxRadar.TabIndex = 2;
            this.checkBoxRadar.Text = "Радар";
            this.checkBoxRadar.UseVisualStyleBackColor = true;
            // 
            // numericUpDownWeight
            // 
            this.numericUpDownWeight.Location = new System.Drawing.Point(9, 81);
            this.numericUpDownWeight.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownWeight.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownWeight.Name = "numericUpDownWeight";
            this.numericUpDownWeight.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownWeight.TabIndex = 4;
            this.numericUpDownWeight.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numericUpDownMaxSpeed
            // 
            this.numericUpDownMaxSpeed.Location = new System.Drawing.Point(9, 32);
            this.numericUpDownMaxSpeed.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownMaxSpeed.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownMaxSpeed.Name = "numericUpDownMaxSpeed";
            this.numericUpDownMaxSpeed.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownMaxSpeed.TabIndex = 2;
            this.numericUpDownMaxSpeed.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // labelPlaneWeight
            // 
            this.labelPlaneWeight.AutoSize = true;
            this.labelPlaneWeight.Location = new System.Drawing.Point(3, 65);
            this.labelPlaneWeight.Name = "labelPlaneWeight";
            this.labelPlaneWeight.Size = new System.Drawing.Size(81, 13);
            this.labelPlaneWeight.TabIndex = 3;
            this.labelPlaneWeight.Text = "Вес самолета:";
            // 
            // labelMaxSpeed
            // 
            this.labelMaxSpeed.AutoSize = true;
            this.labelMaxSpeed.Location = new System.Drawing.Point(6, 16);
            this.labelMaxSpeed.Name = "labelMaxSpeed";
            this.labelMaxSpeed.Size = new System.Drawing.Size(90, 13);
            this.labelMaxSpeed.TabIndex = 2;
            this.labelMaxSpeed.Text = "Макс. скорость:";
            // 
            // groupBoxPlaneType
            // 
            this.groupBoxPlaneType.Controls.Add(this.labelPlaneRadar);
            this.groupBoxPlaneType.Controls.Add(this.labelPlane);
            this.groupBoxPlaneType.Location = new System.Drawing.Point(12, 12);
            this.groupBoxPlaneType.Name = "groupBoxPlaneType";
            this.groupBoxPlaneType.Size = new System.Drawing.Size(108, 122);
            this.groupBoxPlaneType.TabIndex = 3;
            this.groupBoxPlaneType.TabStop = false;
            this.groupBoxPlaneType.Text = "Тип самолета";
            // 
            // labelPlaneRadar
            // 
            this.labelPlaneRadar.AllowDrop = true;
            this.labelPlaneRadar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelPlaneRadar.Location = new System.Drawing.Point(6, 64);
            this.labelPlaneRadar.Name = "labelPlaneRadar";
            this.labelPlaneRadar.Size = new System.Drawing.Size(86, 37);
            this.labelPlaneRadar.TabIndex = 4;
            this.labelPlaneRadar.Text = "Самолет с радаром";
            this.labelPlaneRadar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelPlaneRadar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelPlaneRadar_MouseDown);
            // 
            // labelPlane
            // 
            this.labelPlane.AllowDrop = true;
            this.labelPlane.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelPlane.Location = new System.Drawing.Point(6, 16);
            this.labelPlane.Name = "labelPlane";
            this.labelPlane.Size = new System.Drawing.Size(86, 37);
            this.labelPlane.TabIndex = 3;
            this.labelPlane.Text = "Обычный самолет";
            this.labelPlane.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelPlane.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelPlane_MouseDown);
            // 
            // FormPlaneConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelShowPlane);
            this.Controls.Add(this.groupBoxColors);
            this.Controls.Add(this.groupBoxPlaneParametrs);
            this.Controls.Add(this.groupBoxPlaneType);
            this.Name = "FormPlaneConfig";
            this.Text = "FormPlaneConfig";
            this.panelShowPlane.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShowPlane)).EndInit();
            this.groupBoxColors.ResumeLayout(false);
            this.groupBoxPlaneParametrs.ResumeLayout(false);
            this.groupBoxPlaneParametrs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxSpeed)).EndInit();
            this.groupBoxPlaneType.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelShowPlane;
        private System.Windows.Forms.PictureBox pictureBoxShowPlane;
        private System.Windows.Forms.GroupBox groupBoxColors;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonAddPlane;
        private System.Windows.Forms.Panel panelOrange;
        private System.Windows.Forms.Panel panelWhite;
        private System.Windows.Forms.Panel panelNavy;
        private System.Windows.Forms.Panel panelGreen;
        private System.Windows.Forms.Panel panelPink;
        private System.Windows.Forms.Panel panelBlack;
        private System.Windows.Forms.Panel panelYellow;
        private System.Windows.Forms.Panel panelRed;
        private System.Windows.Forms.Label labelDopColor;
        private System.Windows.Forms.Label labelMainColor;
        private System.Windows.Forms.GroupBox groupBoxPlaneParametrs;
        private System.Windows.Forms.CheckBox checkBoxEngine;
        private System.Windows.Forms.CheckBox checkBoxRadar;
        private System.Windows.Forms.NumericUpDown numericUpDownWeight;
        private System.Windows.Forms.NumericUpDown numericUpDownMaxSpeed;
        private System.Windows.Forms.Label labelPlaneWeight;
        private System.Windows.Forms.Label labelMaxSpeed;
        private System.Windows.Forms.GroupBox groupBoxPlaneType;
        private System.Windows.Forms.Label labelPlaneRadar;
        private System.Windows.Forms.Label labelPlane;
    }
}