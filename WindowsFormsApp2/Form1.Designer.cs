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
            this.button5 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.addNewRecipe = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.sundayButton = new System.Windows.Forms.Button();
            this.mondayButton = new System.Windows.Forms.Button();
            this.saturdayButton = new System.Windows.Forms.Button();
            this.tuesdayButton = new System.Windows.Forms.Button();
            this.fridayButton = new System.Windows.Forms.Button();
            this.wednesdayButton = new System.Windows.Forms.Button();
            this.thursdayButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.sheetsButton = new System.Windows.Forms.Button();
            this.addGroceryToList = new System.Windows.Forms.Button();
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
            this.recipeList.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recipeList.ForeColor = System.Drawing.Color.White;
            this.recipeList.FormattingEnabled = true;
            this.recipeList.ItemHeight = 21;
            this.recipeList.Location = new System.Drawing.Point(18, 57);
            this.recipeList.Name = "recipeList";
            this.recipeList.Size = new System.Drawing.Size(299, 212);
            this.recipeList.TabIndex = 0;
            // 
            // nutrientList
            // 
            this.nutrientList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.nutrientList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nutrientList.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nutrientList.ForeColor = System.Drawing.Color.White;
            this.nutrientList.FormattingEnabled = true;
            this.nutrientList.ItemHeight = 21;
            this.nutrientList.Location = new System.Drawing.Point(336, 57);
            this.nutrientList.Name = "nutrientList";
            this.nutrientList.Size = new System.Drawing.Size(301, 212);
            this.nutrientList.TabIndex = 2;
            // 
            // addRecipe
            // 
            this.addRecipe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.addRecipe.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addRecipe.ForeColor = System.Drawing.Color.White;
            this.addRecipe.Image = ((System.Drawing.Image)(resources.GetObject("addRecipe.Image")));
            this.addRecipe.Location = new System.Drawing.Point(3, 5);
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
            this.grainText.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grainText.ForeColor = System.Drawing.Color.White;
            this.grainText.Location = new System.Drawing.Point(355, 238);
            this.grainText.Name = "grainText";
            this.grainText.Size = new System.Drawing.Size(72, 24);
            this.grainText.TabIndex = 4;
            this.grainText.Text = "Grains";
            // 
            // vegText
            // 
            this.vegText.AutoSize = true;
            this.vegText.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vegText.ForeColor = System.Drawing.Color.White;
            this.vegText.Location = new System.Drawing.Point(355, 277);
            this.vegText.Name = "vegText";
            this.vegText.Size = new System.Drawing.Size(129, 24);
            this.vegText.TabIndex = 5;
            this.vegText.Text = "Vegetables";
            // 
            // dairyText
            // 
            this.dairyText.AutoSize = true;
            this.dairyText.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dairyText.ForeColor = System.Drawing.Color.White;
            this.dairyText.Location = new System.Drawing.Point(355, 317);
            this.dairyText.Name = "dairyText";
            this.dairyText.Size = new System.Drawing.Size(60, 24);
            this.dairyText.TabIndex = 6;
            this.dairyText.Text = "Dairy";
            // 
            // proteinText
            // 
            this.proteinText.AutoSize = true;
            this.proteinText.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proteinText.ForeColor = System.Drawing.Color.White;
            this.proteinText.Location = new System.Drawing.Point(355, 358);
            this.proteinText.Name = "proteinText";
            this.proteinText.Size = new System.Drawing.Size(79, 24);
            this.proteinText.TabIndex = 7;
            this.proteinText.Text = "Protein";
            // 
            // gtotal
            // 
            this.gtotal.AutoSize = true;
            this.gtotal.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gtotal.ForeColor = System.Drawing.Color.Red;
            this.gtotal.Location = new System.Drawing.Point(562, 238);
            this.gtotal.Name = "gtotal";
            this.gtotal.Size = new System.Drawing.Size(22, 24);
            this.gtotal.TabIndex = 8;
            this.gtotal.Text = "0";
            // 
            // vtotal
            // 
            this.vtotal.AutoSize = true;
            this.vtotal.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vtotal.ForeColor = System.Drawing.Color.Red;
            this.vtotal.Location = new System.Drawing.Point(562, 277);
            this.vtotal.Name = "vtotal";
            this.vtotal.Size = new System.Drawing.Size(22, 24);
            this.vtotal.TabIndex = 9;
            this.vtotal.Text = "0";
            // 
            // dtotal
            // 
            this.dtotal.AutoSize = true;
            this.dtotal.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtotal.ForeColor = System.Drawing.Color.Red;
            this.dtotal.Location = new System.Drawing.Point(562, 317);
            this.dtotal.Name = "dtotal";
            this.dtotal.Size = new System.Drawing.Size(22, 24);
            this.dtotal.TabIndex = 10;
            this.dtotal.Text = "0";
            // 
            // ptotal
            // 
            this.ptotal.AutoSize = true;
            this.ptotal.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ptotal.ForeColor = System.Drawing.Color.Red;
            this.ptotal.Location = new System.Drawing.Point(562, 358);
            this.ptotal.Name = "ptotal";
            this.ptotal.Size = new System.Drawing.Size(22, 24);
            this.ptotal.TabIndex = 11;
            this.ptotal.Text = "0";
            // 
            // removeRecipe
            // 
            this.removeRecipe.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.removeRecipe.ForeColor = System.Drawing.Color.White;
            this.removeRecipe.Image = ((System.Drawing.Image)(resources.GetObject("removeRecipe.Image")));
            this.removeRecipe.Location = new System.Drawing.Point(3, 104);
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
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button11);
            this.panel1.Controls.Add(this.button10);
            this.panel1.Controls.Add(this.addNewRecipe);
            this.panel1.Controls.Add(this.addRecipe);
            this.panel1.Controls.Add(this.removeRecipe);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 137);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(209, 592);
            this.panel1.TabIndex = 15;
            // 
            // button5
            // 
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(3, 294);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(200, 93);
            this.button5.TabIndex = 17;
            this.button5.Text = "Delete Recipe";
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button11
            // 
            this.button11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button11.ForeColor = System.Drawing.Color.Red;
            this.button11.Image = ((System.Drawing.Image)(resources.GetObject("button11.Image")));
            this.button11.Location = new System.Drawing.Point(3, 492);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(200, 93);
            this.button11.TabIndex = 16;
            this.button11.Text = "Clear Weekly Info";
            this.button11.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button10
            // 
            this.button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button10.ForeColor = System.Drawing.Color.Red;
            this.button10.Image = ((System.Drawing.Image)(resources.GetObject("button10.Image")));
            this.button10.Location = new System.Drawing.Point(3, 393);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(200, 93);
            this.button10.TabIndex = 15;
            this.button10.Text = "Clear Daily Info";
            this.button10.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // addNewRecipe
            // 
            this.addNewRecipe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.addNewRecipe.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addNewRecipe.ForeColor = System.Drawing.Color.White;
            this.addNewRecipe.Image = ((System.Drawing.Image)(resources.GetObject("addNewRecipe.Image")));
            this.addNewRecipe.Location = new System.Drawing.Point(3, 195);
            this.addNewRecipe.Name = "addNewRecipe";
            this.addNewRecipe.Size = new System.Drawing.Size(200, 93);
            this.addNewRecipe.TabIndex = 13;
            this.addNewRecipe.Text = "New Recipe";
            this.addNewRecipe.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.addNewRecipe.UseVisualStyleBackColor = true;
            this.addNewRecipe.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(209, 137);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(714, 358);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 24);
            this.label1.TabIndex = 19;
            this.label1.Text = "3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(714, 317);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 24);
            this.label2.TabIndex = 18;
            this.label2.Text = "2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(714, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 24);
            this.label3.TabIndex = 17;
            this.label3.Text = "8";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(714, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 24);
            this.label4.TabIndex = 16;
            this.label4.Text = "8";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(399, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 24);
            this.label5.TabIndex = 20;
            this.label5.Text = "Daily Nutrients";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(637, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 24);
            this.label6.TabIndex = 21;
            this.label6.Text = "Recommended";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.sundayButton);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.mondayButton);
            this.panel3.Controls.Add(this.saturdayButton);
            this.panel3.Controls.Add(this.tuesdayButton);
            this.panel3.Controls.Add(this.fridayButton);
            this.panel3.Controls.Add(this.wednesdayButton);
            this.panel3.Controls.Add(this.thursdayButton);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(987, 137);
            this.panel3.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.label7.Font = new System.Drawing.Font("Century Gothic", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(321, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(532, 39);
            this.label7.TabIndex = 23;
            this.label7.Text = "Canadian Food Guide Calculator";
            // 
            // sundayButton
            // 
            this.sundayButton.BackColor = System.Drawing.Color.Black;
            this.sundayButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.sundayButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sundayButton.ForeColor = System.Drawing.Color.White;
            this.sundayButton.Location = new System.Drawing.Point(799, 91);
            this.sundayButton.Name = "sundayButton";
            this.sundayButton.Size = new System.Drawing.Size(75, 23);
            this.sundayButton.TabIndex = 32;
            this.sundayButton.Text = "Sunday";
            this.sundayButton.UseVisualStyleBackColor = false;
            this.sundayButton.Click += new System.EventHandler(this.sundayButton_Click);
            // 
            // mondayButton
            // 
            this.mondayButton.BackColor = System.Drawing.Color.Black;
            this.mondayButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.mondayButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mondayButton.ForeColor = System.Drawing.Color.White;
            this.mondayButton.Location = new System.Drawing.Point(307, 91);
            this.mondayButton.Name = "mondayButton";
            this.mondayButton.Size = new System.Drawing.Size(75, 23);
            this.mondayButton.TabIndex = 26;
            this.mondayButton.Text = "Monday";
            this.mondayButton.UseVisualStyleBackColor = false;
            this.mondayButton.Click += new System.EventHandler(this.mondayButton_Click);
            // 
            // saturdayButton
            // 
            this.saturdayButton.BackColor = System.Drawing.Color.Black;
            this.saturdayButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.saturdayButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saturdayButton.ForeColor = System.Drawing.Color.White;
            this.saturdayButton.Location = new System.Drawing.Point(718, 91);
            this.saturdayButton.Name = "saturdayButton";
            this.saturdayButton.Size = new System.Drawing.Size(75, 23);
            this.saturdayButton.TabIndex = 31;
            this.saturdayButton.Text = "Saturday";
            this.saturdayButton.UseVisualStyleBackColor = false;
            this.saturdayButton.Click += new System.EventHandler(this.saturdayButton_Click);
            // 
            // tuesdayButton
            // 
            this.tuesdayButton.BackColor = System.Drawing.Color.Black;
            this.tuesdayButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.tuesdayButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tuesdayButton.ForeColor = System.Drawing.Color.White;
            this.tuesdayButton.Location = new System.Drawing.Point(388, 91);
            this.tuesdayButton.Name = "tuesdayButton";
            this.tuesdayButton.Size = new System.Drawing.Size(75, 23);
            this.tuesdayButton.TabIndex = 27;
            this.tuesdayButton.Text = "Tuesday";
            this.tuesdayButton.UseVisualStyleBackColor = false;
            this.tuesdayButton.Click += new System.EventHandler(this.tuesdayButton_Click);
            // 
            // fridayButton
            // 
            this.fridayButton.BackColor = System.Drawing.Color.Black;
            this.fridayButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.fridayButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fridayButton.ForeColor = System.Drawing.Color.White;
            this.fridayButton.Location = new System.Drawing.Point(637, 91);
            this.fridayButton.Name = "fridayButton";
            this.fridayButton.Size = new System.Drawing.Size(75, 23);
            this.fridayButton.TabIndex = 30;
            this.fridayButton.Text = "Friday";
            this.fridayButton.UseVisualStyleBackColor = false;
            this.fridayButton.Click += new System.EventHandler(this.fridayButton_Click);
            // 
            // wednesdayButton
            // 
            this.wednesdayButton.BackColor = System.Drawing.Color.Black;
            this.wednesdayButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.wednesdayButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wednesdayButton.ForeColor = System.Drawing.Color.White;
            this.wednesdayButton.Location = new System.Drawing.Point(469, 91);
            this.wednesdayButton.Name = "wednesdayButton";
            this.wednesdayButton.Size = new System.Drawing.Size(81, 23);
            this.wednesdayButton.TabIndex = 28;
            this.wednesdayButton.Text = "Wednesday";
            this.wednesdayButton.UseVisualStyleBackColor = false;
            this.wednesdayButton.Click += new System.EventHandler(this.wednesdayButton_Click);
            // 
            // thursdayButton
            // 
            this.thursdayButton.BackColor = System.Drawing.Color.Black;
            this.thursdayButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.thursdayButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thursdayButton.ForeColor = System.Drawing.Color.White;
            this.thursdayButton.Location = new System.Drawing.Point(556, 91);
            this.thursdayButton.Name = "thursdayButton";
            this.thursdayButton.Size = new System.Drawing.Size(75, 23);
            this.thursdayButton.TabIndex = 29;
            this.thursdayButton.Text = "Thursday";
            this.thursdayButton.UseVisualStyleBackColor = false;
            this.thursdayButton.Click += new System.EventHandler(this.thursdayButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(115, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 24);
            this.label8.TabIndex = 23;
            this.label8.Text = "Recipe List";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(418, 7);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(167, 24);
            this.label9.TabIndex = 24;
            this.label9.Text = "Recipes Added";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.sheetsButton);
            this.panel2.Controls.Add(this.addGroceryToList);
            this.panel2.Controls.Add(this.recipeList);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.nutrientList);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(209, 434);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(778, 295);
            this.panel2.TabIndex = 25;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Green;
            this.button3.Location = new System.Drawing.Point(865, 353);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 33;
            this.button3.Text = "Export";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Green;
            this.button4.Location = new System.Drawing.Point(865, 213);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 34;
            this.button4.Text = "Import";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // sheetsButton
            // 
            this.sheetsButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sheetsButton.Location = new System.Drawing.Point(655, 229);
            this.sheetsButton.Name = "sheetsButton";
            this.sheetsButton.Size = new System.Drawing.Size(92, 40);
            this.sheetsButton.TabIndex = 35;
            this.sheetsButton.Text = "Send to Spreadsheet";
            this.sheetsButton.UseVisualStyleBackColor = true;
            this.sheetsButton.Click += new System.EventHandler(this.sheetsButton_Click);
            // 
            // addGroceryToList
            // 
            this.addGroceryToList.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addGroceryToList.Location = new System.Drawing.Point(655, 61);
            this.addGroceryToList.Name = "addGroceryToList";
            this.addGroceryToList.Size = new System.Drawing.Size(92, 41);
            this.addGroceryToList.TabIndex = 36;
            this.addGroceryToList.Text = "Add to Grocery";
            this.addGroceryToList.UseVisualStyleBackColor = true;
            this.addGroceryToList.Click += new System.EventHandler(this.addGroceryToList_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(987, 729);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Canadian Food Guide Calculator";
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
        private System.Windows.Forms.Button addNewRecipe;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button mondayButton;
        private System.Windows.Forms.Button tuesdayButton;
        private System.Windows.Forms.Button wednesdayButton;
        private System.Windows.Forms.Button thursdayButton;
        private System.Windows.Forms.Button fridayButton;
        private System.Windows.Forms.Button saturdayButton;
        private System.Windows.Forms.Button sundayButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button sheetsButton;
        private System.Windows.Forms.Button addGroceryToList;
    }
}

