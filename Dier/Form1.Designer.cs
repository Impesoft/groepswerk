
namespace Dieren
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Human = new System.Windows.Forms.RadioButton();
            this.Parrot = new System.Windows.Forms.RadioButton();
            this.Cat = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.NaamBox = new System.Windows.Forms.TextBox();
            this.Vraag = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Strelen = new System.Windows.Forms.Button();
            this.Eten = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.ButtonPraten = new System.Windows.Forms.Button();
            this.Create = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Human);
            this.groupBox1.Controls.Add(this.Parrot);
            this.groupBox1.Controls.Add(this.Cat);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dieren";
            // 
            // Human
            // 
            this.Human.AutoSize = true;
            this.Human.Location = new System.Drawing.Point(46, 66);
            this.Human.Name = "Human";
            this.Human.Size = new System.Drawing.Size(54, 19);
            this.Human.TabIndex = 2;
            this.Human.TabStop = true;
            this.Human.Text = "Mens";
            this.Human.UseVisualStyleBackColor = true;
            this.Human.CheckedChanged += new System.EventHandler(this.Human_CheckedChanged);
            // 
            // Parrot
            // 
            this.Parrot.AutoSize = true;
            this.Parrot.Location = new System.Drawing.Point(46, 40);
            this.Parrot.Name = "Parrot";
            this.Parrot.Size = new System.Drawing.Size(73, 19);
            this.Parrot.TabIndex = 1;
            this.Parrot.TabStop = true;
            this.Parrot.Text = "Papegaai";
            this.Parrot.UseVisualStyleBackColor = true;
            this.Parrot.CheckedChanged += new System.EventHandler(this.Parrot_CheckedChanged);
            // 
            // Cat
            // 
            this.Cat.AutoSize = true;
            this.Cat.Location = new System.Drawing.Point(46, 14);
            this.Cat.Name = "Cat";
            this.Cat.Size = new System.Drawing.Size(42, 19);
            this.Cat.TabIndex = 0;
            this.Cat.TabStop = true;
            this.Cat.Text = "Kat";
            this.Cat.UseVisualStyleBackColor = true;
            this.Cat.CheckedChanged += new System.EventHandler(this.Cat_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(240, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Geef je \"dier\" een naam.";
            // 
            // NaamBox
            // 
            this.NaamBox.Location = new System.Drawing.Point(240, 53);
            this.NaamBox.Name = "NaamBox";
            this.NaamBox.Size = new System.Drawing.Size(134, 23);
            this.NaamBox.TabIndex = 2;
            // 
            // Vraag
            // 
            this.Vraag.FormattingEnabled = true;
            this.Vraag.ItemHeight = 15;
            this.Vraag.Items.AddRange(new object[] {
            "Goedendag.",
            "Hey!",
            "Sanka, Are you dead?",
            "Hoe oud bent u?",
            "En? hoe voelen we ons vandaag?",
            "Hoe heet je?",
            "Ook de grappigste thuis zeker?",
            "Vraag 7",
            "Vraag 8",
            "9?"});
            this.Vraag.Location = new System.Drawing.Point(13, 210);
            this.Vraag.Name = "Vraag";
            this.Vraag.Size = new System.Drawing.Size(200, 94);
            this.Vraag.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kies een zin uit om te praten:";
            // 
            // Strelen
            // 
            this.Strelen.Location = new System.Drawing.Point(26, 346);
            this.Strelen.Name = "Strelen";
            this.Strelen.Size = new System.Drawing.Size(139, 75);
            this.Strelen.TabIndex = 5;
            this.Strelen.Text = "Strelen";
            this.Strelen.UseVisualStyleBackColor = true;
            this.Strelen.Click += new System.EventHandler(this.Strelen_Click);
            // 
            // Eten
            // 
            this.Eten.Location = new System.Drawing.Point(252, 346);
            this.Eten.Name = "Eten";
            this.Eten.Size = new System.Drawing.Size(139, 75);
            this.Eten.TabIndex = 6;
            this.Eten.Text = "Eten";
            this.Eten.UseVisualStyleBackColor = true;
            this.Eten.Click += new System.EventHandler(this.Eten_Click);
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(478, 346);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(139, 75);
            this.Close.TabIndex = 7;
            this.Close.Text = "Sluiten";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // ButtonPraten
            // 
            this.ButtonPraten.Location = new System.Drawing.Point(219, 278);
            this.ButtonPraten.Name = "ButtonPraten";
            this.ButtonPraten.Size = new System.Drawing.Size(67, 26);
            this.ButtonPraten.TabIndex = 8;
            this.ButtonPraten.Text = "Praten";
            this.ButtonPraten.UseVisualStyleBackColor = true;
            this.ButtonPraten.Click += new System.EventHandler(this.Praten_Click);
            // 
            // Create
            // 
            this.Create.Location = new System.Drawing.Point(479, 23);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(139, 75);
            this.Create.TabIndex = 9;
            this.Create.Text = "Aanmaken";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 450);
            this.Controls.Add(this.Create);
            this.Controls.Add(this.ButtonPraten);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.Eten);
            this.Controls.Add(this.Strelen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Vraag);
            this.Controls.Add(this.NaamBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Mens;
        private System.Windows.Forms.RadioButton Parrot;
        private System.Windows.Forms.RadioButton Cat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox Vraag;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Strelen;
        private System.Windows.Forms.Button Eten;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Button ButtonPraten;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.TextBox NaamBox;
        private System.Windows.Forms.RadioButton Human;
    }
}

