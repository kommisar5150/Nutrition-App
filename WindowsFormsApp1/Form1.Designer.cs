namespace WindowsFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.recipeList = new System.Windows.Forms.ListBox();
            this.nutrientList = new System.Windows.Forms.ListBox();
            this.addRecipe = new System.Windows.Forms.Button();
            this.grainText = new System.Windows.Forms.Label();
            this.vegText = new System.Windows.Forms.Label();
            this.dairyText = new System.Windows.Forms.Label();
            this.proteinText = new System.Windows.Forms.Label();
            this.gtotal = new System.Windows.Forms.Label();
            this.vtotal = new System.Windows.Forms.Label();
            this.dtotal = new System.Windows.Forms.Label();
            this.ptotal = new System.Windows.Forms.Label();
            this.removeRecipe = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // recipeList
            // 
            this.recipeList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.recipeList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.recipeList.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recipeList.ForeColor = System.Drawing.Color.Gold;
            this.recipeList.FormattingEnabled = true;
            this.recipeList.ItemHeight = 25;
            this.recipeList.Location = new System.Drawing.Point(6, 48);
            this.recipeList.Name = "recipeList";
            this.recipeList.Size = new System.Drawing.Size(276, 152);
            this.recipeList.TabIndex = 0;
            // 
            // nutrientList
            // 
            this.nutrientList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.nutrientList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nutrientList.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nutrientList.ForeColor = System.Drawing.Color.Gold;
            this.nutrientList.FormattingEnabled = true;
            this.nutrientList.ItemHeight = 25;
            this.nutrientList.Location = new System.Drawing.Point(289, 48);
            this.nutrientList.Name = "nutrientList";
            this.nutrientList.Size = new System.Drawing.Size(271, 152);
            this.nutrientList.TabIndex = 2;
            // 
            // addRecipe
            // 
            this.addRecipe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.addRecipe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addRecipe.ForeColor = System.Drawing.Color.White;
            this.addRecipe.Image = ((System.Drawing.Image)(resources.GetObject("addRecipe.Image")));
            this.addRecipe.Location = new System.Drawing.Point(0, 143);
            this.addRecipe.Name = "addRecipe";
            this.addRecipe.Size = new System.Drawing.Size(200, 93);
            this.addRecipe.TabIndex = 3;
            this.addRecipe.Text = "Add Recipe";
            this.addRecipe.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.addRecipe.UseVisualStyleBackColor = true;
            this.addRecipe.Click += new System.EventHandler(this.addRecipe_Click);
            // 
            // grainText
            // 
            this.grainText.AutoSize = true;
            this.grainText.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grainText.ForeColor = System.Drawing.Color.White;
            this.grainText.Location = new System.Drawing.Point(277, 205);
            this.grainText.Name = "grainText";
            this.grainText.Size = new System.Drawing.Size(78, 25);
            this.grainText.TabIndex = 4;
            this.grainText.Text = "Grains";
            // 
            // vegText
            // 
            this.vegText.AutoSize = true;
            this.vegText.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vegText.ForeColor = System.Drawing.Color.White;
            this.vegText.Location = new System.Drawing.Point(277, 244);
            this.vegText.Name = "vegText";
            this.vegText.Size = new System.Drawing.Size(128, 25);
            this.vegText.TabIndex = 5;
            this.vegText.Text = "Vegetables";
            // 
            // dairyText
            // 
            this.dairyText.AutoSize = true;
            this.dairyText.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dairyText.ForeColor = System.Drawing.Color.White;
            this.dairyText.Location = new System.Drawing.Point(277, 284);
            this.dairyText.Name = "dairyText";
            this.dairyText.Size = new System.Drawing.Size(65, 25);
            this.dairyText.TabIndex = 6;
            this.dairyText.Text = "Dairy";
            // 
            // proteinText
            // 
            this.proteinText.AutoSize = true;
            this.proteinText.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proteinText.ForeColor = System.Drawing.Color.White;
            this.proteinText.Location = new System.Drawing.Point(277, 325);
            this.proteinText.Name = "proteinText";
            this.proteinText.Size = new System.Drawing.Size(81, 25);
            this.proteinText.TabIndex = 7;
            this.proteinText.Text = "Protein";
            // 
            // gtotal
            // 
            this.gtotal.AutoSize = true;
            this.gtotal.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gtotal.ForeColor = System.Drawing.Color.Red;
            this.gtotal.Location = new System.Drawing.Point(484, 205);
            this.gtotal.Name = "gtotal";
            this.gtotal.Size = new System.Drawing.Size(24, 25);
            this.gtotal.TabIndex = 8;
            this.gtotal.Text = "0";
            // 
            // vtotal
            // 
            this.vtotal.AutoSize = true;
            this.vtotal.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vtotal.ForeColor = System.Drawing.Color.Red;
            this.vtotal.Location = new System.Drawing.Point(484, 244);
            this.vtotal.Name = "vtotal";
            this.vtotal.Size = new System.Drawing.Size(24, 25);
            this.vtotal.TabIndex = 9;
            this.vtotal.Text = "0";
            // 
            // dtotal
            // 
            this.dtotal.AutoSize = true;
            this.dtotal.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtotal.ForeColor = System.Drawing.Color.Red;
            this.dtotal.Location = new System.Drawing.Point(484, 284);
            this.dtotal.Name = "dtotal";
            this.dtotal.Size = new System.Drawing.Size(24, 25);
            this.dtotal.TabIndex = 10;
            this.dtotal.Text = "0";
            // 
            // ptotal
            // 
            this.ptotal.AutoSize = true;
            this.ptotal.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ptotal.ForeColor = System.Drawing.Color.Red;
            this.ptotal.Location = new System.Drawing.Point(484, 325);
            this.ptotal.Name = "ptotal";
            this.ptotal.Size = new System.Drawing.Size(24, 25);
            this.ptotal.TabIndex = 11;
            this.ptotal.Text = "0";
            // 
            // removeRecipe
            // 
            this.removeRecipe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeRecipe.ForeColor = System.Drawing.Color.White;
            this.removeRecipe.Image = ((System.Drawing.Image)(resources.GetObject("removeRecipe.Image")));
            this.removeRecipe.Location = new System.Drawing.Point(0, 242);
            this.removeRecipe.Name = "removeRecipe";
            this.removeRecipe.Size = new System.Drawing.Size(200, 85);
            this.removeRecipe.TabIndex = 12;
            this.removeRecipe.Text = "Remove";
            this.removeRecipe.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.removeRecipe.UseVisualStyleBackColor = true;
            this.removeRecipe.Click += new System.EventHandler(this.removeRecipe_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.addRecipe);
            this.panel1.Controls.Add(this.removeRecipe);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 631);
            this.panel1.TabIndex = 15;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(197, 134);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(0, 332);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 93);
            this.button1.TabIndex = 13;
            this.button1.Text = "New Recipe";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(636, 325);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(636, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(636, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "8";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(636, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 25);
            this.label4.TabIndex = 16;
            this.label4.Text = "8";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(321, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 25);
            this.label5.TabIndex = 20;
            this.label5.Text = "Daily Nutrients";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(559, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 25);
            this.label6.TabIndex = 21;
            this.label6.Text = "Recommended";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(200, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(578, 59);
            this.panel3.TabIndex = 22;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(500, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(66, 44);
            this.button2.TabIndex = 24;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(106, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(291, 44);
            this.label7.TabIndex = 23;
            this.label7.Text = "Nutrition Tracker";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(88, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 25);
            this.label8.TabIndex = 23;
            this.label8.Text = "Recipe List";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(346, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(168, 25);
            this.label9.TabIndex = 24;
            this.label9.Text = "Recipes Added";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.recipeList);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.nutrientList);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(200, 431);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(578, 200);
            this.panel2.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(778, 631);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ptotal);
            this.Controls.Add(this.dtotal);
            this.Controls.Add(this.vtotal);
            this.Controls.Add(this.gtotal);
            this.Controls.Add(this.proteinText);
            this.Controls.Add(this.dairyText);
            this.Controls.Add(this.vegText);
            this.Controls.Add(this.grainText);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Super App";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox recipeList;
        private System.Windows.Forms.ListBox nutrientList;
        private System.Windows.Forms.Button addRecipe;
        private System.Windows.Forms.Label grainText;
        private System.Windows.Forms.Label vegText;
        private System.Windows.Forms.Label dairyText;
        private System.Windows.Forms.Label proteinText;
        private System.Windows.Forms.Label gtotal;
        private System.Windows.Forms.Label vtotal;
        private System.Windows.Forms.Label dtotal;
        private System.Windows.Forms.Label ptotal;
        private System.Windows.Forms.Button removeRecipe;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
    }
}

