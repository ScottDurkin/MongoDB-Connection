
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
            this.IDE_PROFILE_PIC_BOX = new System.Windows.Forms.PictureBox();
            this.IDB_SELECT_IMAGE = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.IDE_LOAD_IMAGE = new System.Windows.Forms.Button();
            this.IDB_CLEAR = new System.Windows.Forms.Button();
            this.IDE_LOAD_ID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.IDE_PROFILE_PIC_BOX)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.IDB_SAVE.Location = new System.Drawing.Point(46, 283);
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
            // IDE_PROFILE_PIC_BOX
            // 
            this.IDE_PROFILE_PIC_BOX.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.IDE_PROFILE_PIC_BOX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IDE_PROFILE_PIC_BOX.Location = new System.Drawing.Point(89, 139);
            this.IDE_PROFILE_PIC_BOX.Name = "IDE_PROFILE_PIC_BOX";
            this.IDE_PROFILE_PIC_BOX.Size = new System.Drawing.Size(94, 95);
            this.IDE_PROFILE_PIC_BOX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.IDE_PROFILE_PIC_BOX.TabIndex = 5;
            this.IDE_PROFILE_PIC_BOX.TabStop = false;
            // 
            // IDB_SELECT_IMAGE
            // 
            this.IDB_SELECT_IMAGE.Location = new System.Drawing.Point(75, 240);
            this.IDB_SELECT_IMAGE.Name = "IDB_SELECT_IMAGE";
            this.IDB_SELECT_IMAGE.Size = new System.Drawing.Size(118, 37);
            this.IDB_SELECT_IMAGE.TabIndex = 6;
            this.IDB_SELECT_IMAGE.Text = "Select Image";
            this.IDB_SELECT_IMAGE.UseVisualStyleBackColor = true;
            this.IDB_SELECT_IMAGE.Click += new System.EventHandler(this.IDB_SELECT_IMAGE_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.IDE_LOAD_IMAGE);
            this.groupBox1.Controls.Add(this.IDB_CLEAR);
            this.groupBox1.Controls.Add(this.IDE_LOAD_ID);
            this.groupBox1.Location = new System.Drawing.Point(12, 340);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(265, 153);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Load from Mongo";
            // 
            // IDE_LOAD_IMAGE
            // 
            this.IDE_LOAD_IMAGE.Location = new System.Drawing.Point(34, 57);
            this.IDE_LOAD_IMAGE.Name = "IDE_LOAD_IMAGE";
            this.IDE_LOAD_IMAGE.Size = new System.Drawing.Size(188, 37);
            this.IDE_LOAD_IMAGE.TabIndex = 8;
            this.IDE_LOAD_IMAGE.Text = "Load Image";
            this.IDE_LOAD_IMAGE.UseVisualStyleBackColor = true;
            this.IDE_LOAD_IMAGE.Click += new System.EventHandler(this.IDE_LOAD_IMAGE_Click);
            // 
            // IDB_CLEAR
            // 
            this.IDB_CLEAR.Location = new System.Drawing.Point(100, 100);
            this.IDB_CLEAR.Name = "IDB_CLEAR";
            this.IDB_CLEAR.Size = new System.Drawing.Size(122, 37);
            this.IDB_CLEAR.TabIndex = 9;
            this.IDB_CLEAR.Text = "Clear";
            this.IDB_CLEAR.UseVisualStyleBackColor = true;
            this.IDB_CLEAR.Click += new System.EventHandler(this.IDB_CLEAR_Click);
            // 
            // IDE_LOAD_ID
            // 
            this.IDE_LOAD_ID.Location = new System.Drawing.Point(34, 25);
            this.IDE_LOAD_ID.Name = "IDE_LOAD_ID";
            this.IDE_LOAD_ID.Size = new System.Drawing.Size(188, 26);
            this.IDE_LOAD_ID.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 505);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.IDB_SELECT_IMAGE);
            this.Controls.Add(this.IDE_PROFILE_PIC_BOX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IDB_SAVE);
            this.Controls.Add(this.IDE_NUMBER);
            this.Controls.Add(this.IDE_NAME);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.IDE_PROFILE_PIC_BOX)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox IDE_NAME;
        private System.Windows.Forms.TextBox IDE_NUMBER;
        private System.Windows.Forms.Button IDB_SAVE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox IDE_PROFILE_PIC_BOX;
        private System.Windows.Forms.Button IDB_SELECT_IMAGE;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button IDE_LOAD_IMAGE;
        private System.Windows.Forms.Button IDB_CLEAR;
        private System.Windows.Forms.TextBox IDE_LOAD_ID;
    }
}

