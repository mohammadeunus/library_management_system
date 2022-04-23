namespace library_management_system.forms
{
    partial class adminPage_ManagerDelete
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
            this.createButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.idBoxManager = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // createButton
            // 
            this.createButton.Font = new System.Drawing.Font("Segoe Script", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createButton.Location = new System.Drawing.Point(188, 246);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(242, 28);
            this.createButton.TabIndex = 25;
            this.createButton.Text = "delete user";
            this.createButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(185, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "Manager id";
            // 
            // idBoxManager
            // 
            this.idBoxManager.Location = new System.Drawing.Point(278, 193);
            this.idBoxManager.Name = "idBoxManager";
            this.idBoxManager.Size = new System.Drawing.Size(164, 20);
            this.idBoxManager.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(183, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 27);
            this.label1.TabIndex = 20;
            this.label1.Text = "AdminPage: Delete a manager ";
            // 
            // adminPage_ManagerDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 450);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.idBoxManager);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "adminPage_ManagerDelete";
            this.Text = "adminPage_ManagerDelete";
            this.Load += new System.EventHandler(this.adminPage_ManagerDelete_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox idBoxManager;
        private System.Windows.Forms.Label label1;
    }
}