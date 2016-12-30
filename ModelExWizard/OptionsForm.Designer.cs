namespace ModelExWizard
{
    partial class OptionsForm
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
            this.CoreProject = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ModelsProject = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BusinessProject = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DataProject = new System.Windows.Forms.ComboBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CoreProject
            // 
            this.CoreProject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CoreProject.FormattingEnabled = true;
            this.CoreProject.Location = new System.Drawing.Point(114, 17);
            this.CoreProject.Name = "CoreProject";
            this.CoreProject.Size = new System.Drawing.Size(121, 21);
            this.CoreProject.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "\"Core\" project";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "\"Models\" project";
            // 
            // ModelsProject
            // 
            this.ModelsProject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ModelsProject.FormattingEnabled = true;
            this.ModelsProject.Location = new System.Drawing.Point(114, 71);
            this.ModelsProject.Name = "ModelsProject";
            this.ModelsProject.Size = new System.Drawing.Size(121, 21);
            this.ModelsProject.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "\"Services\" project";
            // 
            // BusinessProject
            // 
            this.BusinessProject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BusinessProject.FormattingEnabled = true;
            this.BusinessProject.Location = new System.Drawing.Point(114, 98);
            this.BusinessProject.Name = "BusinessProject";
            this.BusinessProject.Size = new System.Drawing.Size(121, 21);
            this.BusinessProject.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "\"Data\" project";
            // 
            // DataProject
            // 
            this.DataProject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DataProject.FormattingEnabled = true;
            this.DataProject.Location = new System.Drawing.Point(114, 44);
            this.DataProject.Name = "DataProject";
            this.DataProject.Size = new System.Drawing.Size(121, 21);
            this.DataProject.TabIndex = 6;
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(394, 131);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Create";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(241, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "where interfaces will be created";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(241, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(228, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "where repository implementation will be created";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(241, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(175, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "where domain model will be created";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(241, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(217, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "where service implementation will be created";
            // 
            // OptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(476, 166);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DataProject);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BusinessProject);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ModelsProject);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CoreProject);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OptionsForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select files locations";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CoreProject;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ModelsProject;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox BusinessProject;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox DataProject;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}