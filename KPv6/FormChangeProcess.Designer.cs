
namespace KPv6
{
    partial class FormChangeProcess
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
            this.buttonSaveChanges = new System.Windows.Forms.Button();
            this.textBoxNameProcess = new System.Windows.Forms.TextBox();
            this.textBoxWorkingTime = new System.Windows.Forms.TextBox();
            this.comboBoxMethodProcess = new System.Windows.Forms.ComboBox();
            this.labelN = new System.Windows.Forms.Label();
            this.labelX = new System.Windows.Forms.Label();
            this.textBoxN = new System.Windows.Forms.TextBox();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxChar = new System.Windows.Forms.TextBox();
            this.labelChar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonSaveChanges
            // 
            this.buttonSaveChanges.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSaveChanges.Location = new System.Drawing.Point(215, 265);
            this.buttonSaveChanges.Name = "buttonSaveChanges";
            this.buttonSaveChanges.Size = new System.Drawing.Size(150, 43);
            this.buttonSaveChanges.TabIndex = 0;
            this.buttonSaveChanges.Text = "Сохранить";
            this.buttonSaveChanges.UseVisualStyleBackColor = true;
            this.buttonSaveChanges.Click += new System.EventHandler(this.buttonSaveChanges_Click);
            // 
            // textBoxNameProcess
            // 
            this.textBoxNameProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxNameProcess.Location = new System.Drawing.Point(27, 37);
            this.textBoxNameProcess.Name = "textBoxNameProcess";
            this.textBoxNameProcess.Size = new System.Drawing.Size(297, 34);
            this.textBoxNameProcess.TabIndex = 1;
            this.textBoxNameProcess.Text = "Новый процесс";
            // 
            // textBoxWorkingTime
            // 
            this.textBoxWorkingTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxWorkingTime.Location = new System.Drawing.Point(27, 89);
            this.textBoxWorkingTime.Name = "textBoxWorkingTime";
            this.textBoxWorkingTime.Size = new System.Drawing.Size(297, 34);
            this.textBoxWorkingTime.TabIndex = 2;
            this.textBoxWorkingTime.Text = "35";
            // 
            // comboBoxMethodProcess
            // 
            this.comboBoxMethodProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxMethodProcess.FormattingEnabled = true;
            this.comboBoxMethodProcess.Location = new System.Drawing.Point(27, 142);
            this.comboBoxMethodProcess.Name = "comboBoxMethodProcess";
            this.comboBoxMethodProcess.Size = new System.Drawing.Size(297, 37);
            this.comboBoxMethodProcess.TabIndex = 3;
            this.comboBoxMethodProcess.SelectedIndexChanged += new System.EventHandler(this.comboBoxMethodProcess_SelectedIndexChanged);
            // 
            // labelN
            // 
            this.labelN.AutoSize = true;
            this.labelN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelN.Location = new System.Drawing.Point(352, 133);
            this.labelN.Name = "labelN";
            this.labelN.Size = new System.Drawing.Size(46, 29);
            this.labelN.TabIndex = 4;
            this.labelN.Text = "n =";
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelX.Location = new System.Drawing.Point(354, 162);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(44, 29);
            this.labelX.TabIndex = 5;
            this.labelX.Text = "x =";
            // 
            // textBoxN
            // 
            this.textBoxN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxN.Location = new System.Drawing.Point(415, 132);
            this.textBoxN.Name = "textBoxN";
            this.textBoxN.Size = new System.Drawing.Size(61, 30);
            this.textBoxN.TabIndex = 6;
            this.textBoxN.Text = "3";
            // 
            // textBoxX
            // 
            this.textBoxX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxX.Location = new System.Drawing.Point(415, 161);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(61, 30);
            this.textBoxX.TabIndex = 7;
            this.textBoxX.Text = "0,5";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCancel.Location = new System.Drawing.Point(371, 265);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(150, 43);
            this.buttonCancel.TabIndex = 8;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Название процесса";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Время работы";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Результат работы";
            // 
            // textBoxChar
            // 
            this.textBoxChar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxChar.Location = new System.Drawing.Point(437, 94);
            this.textBoxChar.Name = "textBoxChar";
            this.textBoxChar.Size = new System.Drawing.Size(61, 30);
            this.textBoxChar.TabIndex = 13;
            this.textBoxChar.Text = "a";
            // 
            // labelChar
            // 
            this.labelChar.AutoSize = true;
            this.labelChar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelChar.Location = new System.Drawing.Point(352, 94);
            this.labelChar.Name = "labelChar";
            this.labelChar.Size = new System.Drawing.Size(79, 29);
            this.labelChar.TabIndex = 12;
            this.labelChar.Text = "char =";
            // 
            // FormChangeProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 331);
            this.Controls.Add(this.textBoxChar);
            this.Controls.Add(this.labelChar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.textBoxX);
            this.Controls.Add(this.textBoxN);
            this.Controls.Add(this.labelX);
            this.Controls.Add(this.labelN);
            this.Controls.Add(this.comboBoxMethodProcess);
            this.Controls.Add(this.textBoxWorkingTime);
            this.Controls.Add(this.textBoxNameProcess);
            this.Controls.Add(this.buttonSaveChanges);
            this.Name = "FormChangeProcess";
            this.Text = "FormChangeProcess";
            this.Load += new System.EventHandler(this.FormChangeProcess_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSaveChanges;
        private System.Windows.Forms.TextBox textBoxNameProcess;
        private System.Windows.Forms.TextBox textBoxWorkingTime;
        private System.Windows.Forms.ComboBox comboBoxMethodProcess;
        private System.Windows.Forms.Label labelN;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.TextBox textBoxN;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxChar;
        private System.Windows.Forms.Label labelChar;
    }
}