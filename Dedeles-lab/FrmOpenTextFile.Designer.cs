﻿namespace Dedeles_lab
{
    partial class FrmOpenTextFile
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
            this.btnRegister = new System.Windows.Forms.Button();
            this.lvShowText = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnUpload = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(711, 69);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(125, 44);
            this.btnRegister.TabIndex = 0;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // lvShowText
            // 
            this.lvShowText.HideSelection = false;
            this.lvShowText.Location = new System.Drawing.Point(12, 52);
            this.lvShowText.Name = "lvShowText";
            this.lvShowText.Size = new System.Drawing.Size(672, 374);
            this.lvShowText.TabIndex = 1;
            this.lvShowText.UseCompatibleStateImageBehavior = false;
            this.lvShowText.View = System.Windows.Forms.View.List;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "View Record";
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(711, 147);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(125, 44);
            this.btnFind.TabIndex = 3;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(711, 230);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(125, 44);
            this.btnUpload.TabIndex = 4;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FrmOpenTextFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 438);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvShowText);
            this.Controls.Add(this.btnRegister);
            this.Name = "FrmOpenTextFile";
            this.Text = "FrmOpenTextFile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.ListView lvShowText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}