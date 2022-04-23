namespace library_management_system.forms
{
    partial class adminPage_NewManagerEntr
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
            this.label1 = new System.Windows.Forms.Label();
            this.createButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.idBoxManager = new System.Windows.Forms.TextBox();
            this.passBoxManager = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(183, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "AdminPage: Manager New Entry";
            // 
            // createButton
            // 
            this.createButton.Font = new System.Drawing.Font("Segoe Script", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createButton.Location = new System.Drawing.Point(188, 246);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(242, 28);
            this.createButton.TabIndex = 19;
            this.createButton.Text = "create";
            this.createButton.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Script", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(185, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(185, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Manager id";
            // 
            // idBoxManager
            // 
            this.idBoxManager.Location = new System.Drawing.Point(278, 171);
            this.idBoxManager.Name = "idBoxManager";
            this.idBoxManager.Size = new System.Drawing.Size(164, 20);
            this.idBoxManager.TabIndex = 16;
            // 
            // passBoxManager
            // 
            this.passBoxManager.Location = new System.Drawing.Point(278, 201);
            this.passBoxManager.Name = "passBoxManager";
            this.passBoxManager.PasswordChar = 'x';
            this.passBoxManager.Size = new System.Drawing.Size(164, 20);
            this.passBoxManager.TabIndex = 15;
            // 
            // adminPage_NewManagerEntr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 450);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.idBoxManager);
            this.Controls.Add(this.passBoxManager);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "adminPage_NewManagerEntr";
            this.Text = "adminPage_NewManagerEntr";
            this.Load += new System.EventHandler(this.adminPage_NewManagerEntr_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox idBoxManager;
        private System.Windows.Forms.TextBox passBoxManager;
    }
}