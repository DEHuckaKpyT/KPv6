
namespace KPv6
{
    partial class FormManageProcesses
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
            this.listBoxProcesses = new System.Windows.Forms.ListBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAddProcess = new System.Windows.Forms.Button();
            this.buttonChange = new System.Windows.Forms.Button();
            this.listBoxProcessesExtented = new System.Windows.Forms.ListBox();
            this.buttonUp = new System.Windows.Forms.Button();
            this.buttonDown = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxProcesses
            // 
            this.listBoxProcesses.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxProcesses.FormattingEnabled = true;
            this.listBoxProcesses.ItemHeight = 15;
            this.listBoxProcesses.Location = new System.Drawing.Point(33, 48);
            this.listBoxProcesses.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxProcesses.Name = "listBoxProcesses";
            this.listBoxProcesses.Size = new System.Drawing.Size(344, 409);
            this.listBoxProcesses.TabIndex = 0;
            this.listBoxProcesses.SelectedIndexChanged += new System.EventHandler(this.listBoxProcesses_SelectedIndexChanged);
            this.listBoxProcesses.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxProcesses_MouseDoubleClick);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDelete.Location = new System.Drawing.Point(255, 11);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(118, 26);
            this.buttonDelete.TabIndex = 1;
            this.buttonDelete.Text = "Удалить процесс";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonAddProcess
            // 
            this.buttonAddProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddProcess.Location = new System.Drawing.Point(133, 11);
            this.buttonAddProcess.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAddProcess.Name = "buttonAddProcess";
            this.buttonAddProcess.Size = new System.Drawing.Size(118, 26);
            this.buttonAddProcess.TabIndex = 2;
            this.buttonAddProcess.Text = "Добавить процесс";
            this.buttonAddProcess.UseVisualStyleBackColor = true;
            this.buttonAddProcess.Click += new System.EventHandler(this.buttonAddProcess_Click);
            // 
            // buttonChange
            // 
            this.buttonChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonChange.Location = new System.Drawing.Point(11, 11);
            this.buttonChange.Margin = new System.Windows.Forms.Padding(2);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(118, 26);
            this.buttonChange.TabIndex = 3;
            this.buttonChange.Text = "Изменить процесс";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // listBoxProcessesExtented
            // 
            this.listBoxProcessesExtented.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxProcessesExtented.FormattingEnabled = true;
            this.listBoxProcessesExtented.ItemHeight = 15;
            this.listBoxProcessesExtented.Location = new System.Drawing.Point(377, 48);
            this.listBoxProcessesExtented.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxProcessesExtented.Name = "listBoxProcessesExtented";
            this.listBoxProcessesExtented.Size = new System.Drawing.Size(683, 409);
            this.listBoxProcessesExtented.TabIndex = 4;
            this.listBoxProcessesExtented.SelectedIndexChanged += new System.EventHandler(this.listBoxProcessesExtented_SelectedIndexChanged);
            this.listBoxProcessesExtented.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxProcessesExtented_MouseDoubleClick);
            // 
            // buttonUp
            // 
            this.buttonUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonUp.Location = new System.Drawing.Point(2, 177);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(26, 41);
            this.buttonUp.TabIndex = 5;
            this.buttonUp.Text = "↑";
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.buttonUp_Click);
            // 
            // buttonDown
            // 
            this.buttonDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDown.Location = new System.Drawing.Point(2, 224);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(26, 41);
            this.buttonDown.TabIndex = 6;
            this.buttonDown.Text = "↓";
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Click += new System.EventHandler(this.buttonDown_Click);
            // 
            // FormManageProcesses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 468);
            this.Controls.Add(this.buttonDown);
            this.Controls.Add(this.buttonUp);
            this.Controls.Add(this.listBoxProcessesExtented);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.buttonAddProcess);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.listBoxProcesses);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormManageProcesses";
            this.Text = "ManageProcesses";
            this.Load += new System.EventHandler(this.ManageProcesses_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxProcesses;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonAddProcess;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.ListBox listBoxProcessesExtented;
        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.Button buttonDown;
    }
}