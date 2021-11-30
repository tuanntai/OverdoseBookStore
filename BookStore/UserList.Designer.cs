
namespace BookStore
{
    partial class UserList
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
            this.UserListGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.UserListGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // UserListGridView
            // 
            this.UserListGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserListGridView.Location = new System.Drawing.Point(16, 198);
            this.UserListGridView.Margin = new System.Windows.Forms.Padding(4);
            this.UserListGridView.Name = "UserListGridView";
            this.UserListGridView.RowHeadersWidth = 51;
            this.UserListGridView.Size = new System.Drawing.Size(1013, 478);
            this.UserListGridView.TabIndex = 0;
            this.UserListGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UserListGridView_CellContentClick);
            // 
            // UserList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 690);
            this.Controls.Add(this.UserListGridView);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserList";
            this.Text = "UserList";
            this.Load += new System.EventHandler(this.UserList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UserListGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView UserListGridView;
    }
}