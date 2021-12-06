
namespace BookStore
{
    partial class SeachForm
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
            this.inputField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bookRadio = new System.Windows.Forms.RadioButton();
            this.authorRadio = new System.Windows.Forms.RadioButton();
            this.publisherRadio = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // inputField
            // 
            this.inputField.Location = new System.Drawing.Point(142, 31);
            this.inputField.Name = "inputField";
            this.inputField.Size = new System.Drawing.Size(357, 22);
            this.inputField.TabIndex = 0;
            this.inputField.KeyUp += new System.Windows.Forms.KeyEventHandler(this.inputField_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name :";
            // 
            // bookRadio
            // 
            this.bookRadio.AutoSize = true;
            this.bookRadio.Location = new System.Drawing.Point(526, 32);
            this.bookRadio.Name = "bookRadio";
            this.bookRadio.Size = new System.Drawing.Size(61, 21);
            this.bookRadio.TabIndex = 2;
            this.bookRadio.TabStop = true;
            this.bookRadio.Text = "Book";
            this.bookRadio.UseVisualStyleBackColor = true;
            // 
            // authorRadio
            // 
            this.authorRadio.AutoSize = true;
            this.authorRadio.Location = new System.Drawing.Point(663, 32);
            this.authorRadio.Name = "authorRadio";
            this.authorRadio.Size = new System.Drawing.Size(71, 21);
            this.authorRadio.TabIndex = 3;
            this.authorRadio.TabStop = true;
            this.authorRadio.Text = "Author";
            this.authorRadio.UseVisualStyleBackColor = true;
            // 
            // publisherRadio
            // 
            this.publisherRadio.AutoSize = true;
            this.publisherRadio.Location = new System.Drawing.Point(800, 32);
            this.publisherRadio.Name = "publisherRadio";
            this.publisherRadio.Size = new System.Drawing.Size(88, 21);
            this.publisherRadio.TabIndex = 4;
            this.publisherRadio.TabStop = true;
            this.publisherRadio.Text = "Publisher";
            this.publisherRadio.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(33, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(921, 517);
            this.dataGridView1.TabIndex = 5;
            // 
            // SeachForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.publisherRadio);
            this.Controls.Add(this.authorRadio);
            this.Controls.Add(this.bookRadio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputField);
            this.Name = "SeachForm";
            this.Text = "SeachForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton bookRadio;
        private System.Windows.Forms.RadioButton authorRadio;
        private System.Windows.Forms.RadioButton publisherRadio;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}