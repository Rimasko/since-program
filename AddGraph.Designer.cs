namespace NewSince
{
    partial class AddGraph
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
            this.DownloadFile = new System.Windows.Forms.Button();
            this.textPathFile = new System.Windows.Forms.TextBox();
            this.comboLines = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.LineColorPick = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DownloadFile
            // 
            this.DownloadFile.Location = new System.Drawing.Point(20, 25);
            this.DownloadFile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DownloadFile.Name = "DownloadFile";
            this.DownloadFile.Size = new System.Drawing.Size(89, 19);
            this.DownloadFile.TabIndex = 0;
            this.DownloadFile.Text = "Выбрать файл";
            this.DownloadFile.UseVisualStyleBackColor = true;
            this.DownloadFile.Click += new System.EventHandler(this.DownloadFile_Click);
            // 
            // textPathFile
            // 
            this.textPathFile.Location = new System.Drawing.Point(124, 25);
            this.textPathFile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textPathFile.Name = "textPathFile";
            this.textPathFile.ReadOnly = true;
            this.textPathFile.Size = new System.Drawing.Size(99, 20);
            this.textPathFile.TabIndex = 1;
            // 
            // comboLines
            // 
            this.comboLines.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboLines.FormattingEnabled = true;
            this.comboLines.Items.AddRange(new object[] {
            "Spline",
            "SplineArea"});
            this.comboLines.Location = new System.Drawing.Point(124, 56);
            this.comboLines.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboLines.Name = "comboLines";
            this.comboLines.Size = new System.Drawing.Size(99, 21);
            this.comboLines.TabIndex = 2;
            this.comboLines.SelectedIndexChanged += new System.EventHandler(this.comboLines_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(124, 110);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 19);
            this.button1.TabIndex = 3;
            this.button1.Text = "Создать График";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Выбрать тип линии";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Выбрать цвет";
            // 
            // LineColorPick
            // 
            this.LineColorPick.Location = new System.Drawing.Point(124, 86);
            this.LineColorPick.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LineColorPick.Name = "LineColorPick";
            this.LineColorPick.Size = new System.Drawing.Size(98, 19);
            this.LineColorPick.TabIndex = 6;
            this.LineColorPick.Text = "Палитра";
            this.LineColorPick.UseVisualStyleBackColor = true;
            this.LineColorPick.Click += new System.EventHandler(this.LineColorPick_Click);
            // 
            // AddGraph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 146);
            this.Controls.Add(this.LineColorPick);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboLines);
            this.Controls.Add(this.textPathFile);
            this.Controls.Add(this.DownloadFile);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AddGraph";
            this.Text = "Окно добавления графика";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DownloadFile;
        private System.Windows.Forms.TextBox textPathFile;
        private System.Windows.Forms.ComboBox comboLines;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button LineColorPick;
    }
}