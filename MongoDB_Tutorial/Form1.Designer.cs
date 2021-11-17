
namespace MongoDB_Tutorial
{
    partial class Form1
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
            this.IDE_NAME = new System.Windows.Forms.TextBox();
            this.IDE_NUMBER = new System.Windows.Forms.TextBox();
            this.IDB_SAVE = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // IDE_NAME
            // 
            this.IDE_NAME.Location = new System.Drawing.Point(46, 45);
            this.IDE_NAME.Name = "IDE_NAME";
            this.IDE_NAME.Size = new System.Drawing.Size(188, 26);
            this.IDE_NAME.TabIndex = 0;
            // 
            // IDE_NUMBER
            // 
            this.IDE_NUMBER.Location = new System.Drawing.Point(46, 104);
            this.IDE_NUMBER.Name = "IDE_NUMBER";
            this.IDE_NUMBER.Size = new System.Drawing.Size(188, 26);
            this.IDE_NUMBER.TabIndex = 1;
            // 
            // IDB_SAVE
            // 
            this.IDB_SAVE.Location = new System.Drawing.Point(46, 136);
            this.IDB_SAVE.Name = "IDB_SAVE";
            this.IDB_SAVE.Size = new System.Drawing.Size(188, 37);
            this.IDB_SAVE.TabIndex = 2;
            this.IDB_SAVE.Text = "Save Contact";
            this.IDB_SAVE.UseVisualStyleBackColor = true;
            this.IDB_SAVE.Click += new System.EventHandler(this.IDB_SAVE_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Phone Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IDB_SAVE);
            this.Controls.Add(this.IDE_NUMBER);
            this.Controls.Add(this.IDE_NAME);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox IDE_NAME;
        private System.Windows.Forms.TextBox IDE_NUMBER;
        private System.Windows.Forms.Button IDB_SAVE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

