namespace JanelasMDI
{
    partial class frm_visualizarUsers
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
            this.dtgVisuUsers = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVisuUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgVisuUsers
            // 
            this.dtgVisuUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgVisuUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgVisuUsers.Location = new System.Drawing.Point(0, 0);
            this.dtgVisuUsers.Name = "dtgVisuUsers";
            this.dtgVisuUsers.Size = new System.Drawing.Size(800, 450);
            this.dtgVisuUsers.TabIndex = 0;
            // 
            // frm_visualizarUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtgVisuUsers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_visualizarUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visualizar Usuários";
            this.Load += new System.EventHandler(this.frm_visualizarUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgVisuUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgVisuUsers;
    }
}