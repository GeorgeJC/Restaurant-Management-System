﻿namespace Restaurent
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.label1 = new System.Windows.Forms.Label();
            this.cust_username = new System.Windows.Forms.TextBox();
            this.cust_pass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cust_name = new System.Windows.Forms.TextBox();
            this.cust_phno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cust_email = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.create = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Harlow Solid Italic", 42F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(270, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 57);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome";
            // 
            // cust_username
            // 
            this.cust_username.Location = new System.Drawing.Point(217, 366);
            this.cust_username.Name = "cust_username";
            this.cust_username.Size = new System.Drawing.Size(365, 20);
            this.cust_username.TabIndex = 12;
            // 
            // cust_pass
            // 
            this.cust_pass.Location = new System.Drawing.Point(217, 433);
            this.cust_pass.Name = "cust_pass";
            this.cust_pass.Size = new System.Drawing.Size(365, 20);
            this.cust_pass.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("HelvLight", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(212, 400);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 30);
            this.label3.TabIndex = 10;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("HelvLight", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(212, 323);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 30);
            this.label2.TabIndex = 9;
            this.label2.Text = "Username";
            // 
            // cust_name
            // 
            this.cust_name.Location = new System.Drawing.Point(217, 152);
            this.cust_name.Name = "cust_name";
            this.cust_name.Size = new System.Drawing.Size(365, 20);
            this.cust_name.TabIndex = 16;
            this.cust_name.TextChanged += new System.EventHandler(this.cust_name_TextChanged);
            // 
            // cust_phno
            // 
            this.cust_phno.Location = new System.Drawing.Point(217, 219);
            this.cust_phno.Name = "cust_phno";
            this.cust_phno.Size = new System.Drawing.Size(365, 20);
            this.cust_phno.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("HelvLight", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(212, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 30);
            this.label4.TabIndex = 14;
            this.label4.Text = "Phone";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("HelvLight", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Yellow;
            this.label5.Location = new System.Drawing.Point(212, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 30);
            this.label5.TabIndex = 13;
            this.label5.Text = "Enter Name";
            // 
            // cust_email
            // 
            this.cust_email.Location = new System.Drawing.Point(217, 287);
            this.cust_email.Name = "cust_email";
            this.cust_email.Size = new System.Drawing.Size(365, 20);
            this.cust_email.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("HelvLight", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Yellow;
            this.label6.Location = new System.Drawing.Point(212, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 30);
            this.label6.TabIndex = 17;
            this.label6.Text = "Email";
            // 
            // create
            // 
            this.create.BackColor = System.Drawing.Color.Yellow;
            this.create.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.create.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.create.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.create.Location = new System.Drawing.Point(349, 484);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(93, 33);
            this.create.TabIndex = 19;
            this.create.Text = "Create";
            this.create.UseVisualStyleBackColor = false;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 570);
            this.Controls.Add(this.create);
            this.Controls.Add(this.cust_email);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cust_name);
            this.Controls.Add(this.cust_phno);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cust_username);
            this.Controls.Add(this.cust_pass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cust_username;
        private System.Windows.Forms.TextBox cust_pass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cust_name;
        private System.Windows.Forms.TextBox cust_phno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox cust_email;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button create;
    }
}