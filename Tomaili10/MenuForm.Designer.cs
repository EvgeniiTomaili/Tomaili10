namespace Tomaili10
{
    partial class MenuForm
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
            this.Mall = new System.Windows.Forms.Button();
            this.Tenants = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.Role = new System.Windows.Forms.Label();
            this.Welcome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Mall
            // 
            this.Mall.Location = new System.Drawing.Point(481, 117);
            this.Mall.Name = "Mall";
            this.Mall.Size = new System.Drawing.Size(75, 23);
            this.Mall.TabIndex = 2;
            this.Mall.Text = "авторизоваться";
            this.Mall.UseVisualStyleBackColor = true;
            // 
            // Tenants
            // 
            this.Tenants.Location = new System.Drawing.Point(508, 175);
            this.Tenants.Name = "Tenants";
            this.Tenants.Size = new System.Drawing.Size(75, 23);
            this.Tenants.TabIndex = 3;
            this.Tenants.Text = "войти";
            this.Tenants.UseVisualStyleBackColor = true;
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(481, 238);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 4;
            this.Exit.Text = "выйти";
            this.Exit.UseVisualStyleBackColor = true;
            // 
            // Role
            // 
            this.Role.AutoSize = true;
            this.Role.Location = new System.Drawing.Point(370, 227);
            this.Role.Name = "Role";
            this.Role.Size = new System.Drawing.Size(29, 13);
            this.Role.TabIndex = 1;
            this.Role.Text = "Role";
            // 
            // Welcome
            // 
            this.Welcome.AutoSize = true;
            this.Welcome.Location = new System.Drawing.Point(370, 153);
            this.Welcome.Name = "Welcome";
            this.Welcome.Size = new System.Drawing.Size(49, 13);
            this.Welcome.TabIndex = 0;
            this.Welcome.Text = "welcome";
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Tenants);
            this.Controls.Add(this.Mall);
            this.Controls.Add(this.Role);
            this.Controls.Add(this.Welcome);
            this.Name = "MenuForm";
            this.Text = "MenuForm";
            this.Load += new System.EventHandler(this.MenuForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Mall;
        private System.Windows.Forms.Button Tenants;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label Role;
        private System.Windows.Forms.Label Welcome;
    }
}