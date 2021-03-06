
namespace KPv6
{
    partial class FormViewProcessing
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonStart = new System.Windows.Forms.Button();
            this.listBoxLog = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonStopProc = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxTime = new System.Windows.Forms.ListBox();
            this.listBoxState = new System.Windows.Forms.ListBox();
            this.buttonOpenManager = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.labelQuantum = new System.Windows.Forms.Label();
            this.listBoxProcesses = new System.Windows.Forms.MyListBox();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStart.Location = new System.Drawing.Point(1009, 2);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(2);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(147, 25);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.Text = "Запустить";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // listBoxLog
            // 
            this.listBoxLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(191)))));
            this.listBoxLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxLog.FormattingEnabled = true;
            this.listBoxLog.ItemHeight = 16;
            this.listBoxLog.Location = new System.Drawing.Point(578, 29);
            this.listBoxLog.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxLog.Name = "listBoxLog";
            this.listBoxLog.Size = new System.Drawing.Size(657, 466);
            this.listBoxLog.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(5, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Все процессы";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(578, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Журнал событий";
            // 
            // buttonStopProc
            // 
            this.buttonStopProc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonStopProc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStopProc.Location = new System.Drawing.Point(123, 4);
            this.buttonStopProc.Name = "buttonStopProc";
            this.buttonStopProc.Size = new System.Drawing.Size(287, 25);
            this.buttonStopProc.TabIndex = 5;
            this.buttonStopProc.Text = "Заблокировать/разблокировать процесс";
            this.buttonStopProc.UseVisualStyleBackColor = true;
            this.buttonStopProc.Click += new System.EventHandler(this.buttonStopProc_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(976, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(28, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "11";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(925, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Квант";
            // 
            // listBoxTime
            // 
            this.listBoxTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(191)))));
            this.listBoxTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxTime.FormattingEnabled = true;
            this.listBoxTime.ItemHeight = 16;
            this.listBoxTime.Location = new System.Drawing.Point(535, 29);
            this.listBoxTime.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxTime.Name = "listBoxTime";
            this.listBoxTime.Size = new System.Drawing.Size(39, 466);
            this.listBoxTime.TabIndex = 8;
            this.listBoxTime.SelectedIndexChanged += new System.EventHandler(this.listBoxStateAndTime_SelectedIndexChanged);
            // 
            // listBoxState
            // 
            this.listBoxState.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(191)))));
            this.listBoxState.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxState.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxState.FormattingEnabled = true;
            this.listBoxState.ItemHeight = 16;
            this.listBoxState.Location = new System.Drawing.Point(411, 29);
            this.listBoxState.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxState.Name = "listBoxState";
            this.listBoxState.Size = new System.Drawing.Size(123, 466);
            this.listBoxState.TabIndex = 9;
            this.listBoxState.SelectedIndexChanged += new System.EventHandler(this.listBoxStateAndTime_SelectedIndexChanged);
            // 
            // buttonOpenManager
            // 
            this.buttonOpenManager.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonOpenManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpenManager.Location = new System.Drawing.Point(705, 2);
            this.buttonOpenManager.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOpenManager.Name = "buttonOpenManager";
            this.buttonOpenManager.Size = new System.Drawing.Size(215, 25);
            this.buttonOpenManager.TabIndex = 10;
            this.buttonOpenManager.Text = "Открыть редактор процессов";
            this.buttonOpenManager.UseVisualStyleBackColor = true;
            this.buttonOpenManager.Click += new System.EventHandler(this.buttonOpenManager_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonReset.Location = new System.Drawing.Point(1160, 2);
            this.buttonReset.Margin = new System.Windows.Forms.Padding(2);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(67, 25);
            this.buttonReset.TabIndex = 11;
            this.buttonReset.Text = "Сброс";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // labelQuantum
            // 
            this.labelQuantum.AutoSize = true;
            this.labelQuantum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelQuantum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelQuantum.Location = new System.Drawing.Point(411, 8);
            this.labelQuantum.Name = "labelQuantum";
            this.labelQuantum.Size = new System.Drawing.Size(154, 19);
            this.labelQuantum.TabIndex = 12;
            this.labelQuantum.Text = "Доп время кванта = 0";
            // 
            // listBoxProcesses
            // 
            this.listBoxProcesses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(191)))));
            this.listBoxProcesses.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxProcesses.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.listBoxProcesses.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxProcesses.FormattingEnabled = true;
            this.listBoxProcesses.ItemHeight = 16;
            this.listBoxProcesses.Location = new System.Drawing.Point(5, 29);
            this.listBoxProcesses.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxProcesses.Name = "listBoxProcesses";
            this.listBoxProcesses.Size = new System.Drawing.Size(405, 466);
            this.listBoxProcesses.TabIndex = 0;
            this.listBoxProcesses.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listBoxProcesses_DrawItem);
            this.listBoxProcesses.SelectedIndexChanged += new System.EventHandler(this.listBoxProcesses_SelectedIndexChanged);
            // 
            // FormViewProcessing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(216)))), ((int)(((byte)(146)))));
            this.ClientSize = new System.Drawing.Size(1238, 505);
            this.Controls.Add(this.labelQuantum);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonOpenManager);
            this.Controls.Add(this.listBoxState);
            this.Controls.Add(this.listBoxTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonStopProc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxLog);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.listBoxProcesses);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormViewProcessing";
            this.Text = "View";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormViewProcessing_FormClosing);
            this.Load += new System.EventHandler(this.FormViewProcessing_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MyListBox listBoxProcesses;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.ListBox listBoxLog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonStopProc;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBoxTime;
        private System.Windows.Forms.ListBox listBoxState;
        private System.Windows.Forms.Button buttonOpenManager;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Label labelQuantum;
    }
}

