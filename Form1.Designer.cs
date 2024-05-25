namespace PizaProject_Solve
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
            this.label1 = new System.Windows.Forms.Label();
            this.grpSize = new System.Windows.Forms.GroupBox();
            this.rdLarg = new System.Windows.Forms.RadioButton();
            this.rdMedium = new System.Windows.Forms.RadioButton();
            this.rdSmall = new System.Windows.Forms.RadioButton();
            this.btnOrderPizza = new System.Windows.Forms.Button();
            this.btRestForm = new System.Windows.Forms.Button();
            this.grpToppings = new System.Windows.Forms.GroupBox();
            this.chkGreenPeppers = new System.Windows.Forms.CheckBox();
            this.chkOlives = new System.Windows.Forms.CheckBox();
            this.chkOnion = new System.Windows.Forms.CheckBox();
            this.chkTomatoes = new System.Windows.Forms.CheckBox();
            this.chkMushrooms = new System.Windows.Forms.CheckBox();
            this.chkExtraChees = new System.Windows.Forms.CheckBox();
            this.grpCrustType = new System.Windows.Forms.GroupBox();
            this.rdThink = new System.Windows.Forms.RadioButton();
            this.rdThin = new System.Windows.Forms.RadioButton();
            this.grpWhereToEat = new System.Windows.Forms.GroupBox();
            this.rdTakeOut = new System.Windows.Forms.RadioButton();
            this.rdEateIn = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.texSize = new System.Windows.Forms.Label();
            this.texToppings = new System.Windows.Forms.Label();
            this.texCrustType = new System.Windows.Forms.Label();
            this.texWhereToEat = new System.Windows.Forms.Label();
            this.textPrice = new System.Windows.Forms.Label();
            this.grpSize.SuspendLayout();
            this.grpToppings.SuspendLayout();
            this.grpCrustType.SuspendLayout();
            this.grpWhereToEat.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(182, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(688, 111);
            this.label1.TabIndex = 0;
            this.label1.Text = "Make Your Pizza";
            // 
            // grpSize
            // 
            this.grpSize.BackColor = System.Drawing.Color.Transparent;
            this.grpSize.Controls.Add(this.rdLarg);
            this.grpSize.Controls.Add(this.rdMedium);
            this.grpSize.Controls.Add(this.rdSmall);
            this.grpSize.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.grpSize.Location = new System.Drawing.Point(99, 123);
            this.grpSize.Name = "grpSize";
            this.grpSize.Size = new System.Drawing.Size(162, 209);
            this.grpSize.TabIndex = 1;
            this.grpSize.TabStop = false;
            this.grpSize.Text = "Size";
            // 
            // rdLarg
            // 
            this.rdLarg.AutoSize = true;
            this.rdLarg.BackColor = System.Drawing.Color.Transparent;
            this.rdLarg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.rdLarg.Location = new System.Drawing.Point(25, 150);
            this.rdLarg.Name = "rdLarg";
            this.rdLarg.Size = new System.Drawing.Size(64, 26);
            this.rdLarg.TabIndex = 8;
            this.rdLarg.TabStop = true;
            this.rdLarg.Tag = "70";
            this.rdLarg.Text = "Larg";
            this.rdLarg.UseVisualStyleBackColor = false;
            this.rdLarg.CheckedChanged += new System.EventHandler(this.rdLarg_CheckedChanged);
            // 
            // rdMedium
            // 
            this.rdMedium.AutoSize = true;
            this.rdMedium.BackColor = System.Drawing.Color.Transparent;
            this.rdMedium.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.rdMedium.Location = new System.Drawing.Point(25, 100);
            this.rdMedium.Name = "rdMedium";
            this.rdMedium.Size = new System.Drawing.Size(94, 26);
            this.rdMedium.TabIndex = 7;
            this.rdMedium.TabStop = true;
            this.rdMedium.Tag = "50";
            this.rdMedium.Text = "Medium";
            this.rdMedium.UseVisualStyleBackColor = false;
            this.rdMedium.CheckedChanged += new System.EventHandler(this.rdMedium_CheckedChanged);
            // 
            // rdSmall
            // 
            this.rdSmall.AutoSize = true;
            this.rdSmall.BackColor = System.Drawing.Color.Transparent;
            this.rdSmall.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.rdSmall.Location = new System.Drawing.Point(25, 50);
            this.rdSmall.Name = "rdSmall";
            this.rdSmall.Size = new System.Drawing.Size(72, 26);
            this.rdSmall.TabIndex = 6;
            this.rdSmall.TabStop = true;
            this.rdSmall.Tag = "30";
            this.rdSmall.Text = "Small";
            this.rdSmall.UseVisualStyleBackColor = false;
            this.rdSmall.CheckedChanged += new System.EventHandler(this.rdSmall_CheckedChanged);
            // 
            // btnOrderPizza
            // 
            this.btnOrderPizza.Location = new System.Drawing.Point(314, 560);
            this.btnOrderPizza.Name = "btnOrderPizza";
            this.btnOrderPizza.Size = new System.Drawing.Size(129, 59);
            this.btnOrderPizza.TabIndex = 4;
            this.btnOrderPizza.Text = "Order Pizza";
            this.btnOrderPizza.UseVisualStyleBackColor = true;
            this.btnOrderPizza.Click += new System.EventHandler(this.btnOrderPizza_Click);
            // 
            // btRestForm
            // 
            this.btRestForm.Location = new System.Drawing.Point(513, 560);
            this.btRestForm.Name = "btRestForm";
            this.btRestForm.Size = new System.Drawing.Size(129, 59);
            this.btRestForm.TabIndex = 5;
            this.btRestForm.Text = "Rest Form";
            this.btRestForm.UseVisualStyleBackColor = true;
            this.btRestForm.Click += new System.EventHandler(this.btRestForm_Click);
            // 
            // grpToppings
            // 
            this.grpToppings.BackColor = System.Drawing.Color.Transparent;
            this.grpToppings.Controls.Add(this.chkGreenPeppers);
            this.grpToppings.Controls.Add(this.chkOlives);
            this.grpToppings.Controls.Add(this.chkOnion);
            this.grpToppings.Controls.Add(this.chkTomatoes);
            this.grpToppings.Controls.Add(this.chkMushrooms);
            this.grpToppings.Controls.Add(this.chkExtraChees);
            this.grpToppings.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpToppings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.grpToppings.Location = new System.Drawing.Point(319, 123);
            this.grpToppings.Name = "grpToppings";
            this.grpToppings.Size = new System.Drawing.Size(328, 276);
            this.grpToppings.TabIndex = 2;
            this.grpToppings.TabStop = false;
            this.grpToppings.Text = "Toppings";
            // 
            // chkGreenPeppers
            // 
            this.chkGreenPeppers.AutoSize = true;
            this.chkGreenPeppers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkGreenPeppers.Location = new System.Drawing.Point(164, 207);
            this.chkGreenPeppers.Name = "chkGreenPeppers";
            this.chkGreenPeppers.Size = new System.Drawing.Size(140, 26);
            this.chkGreenPeppers.TabIndex = 5;
            this.chkGreenPeppers.Tag = "15";
            this.chkGreenPeppers.Text = "Green Peppers";
            this.chkGreenPeppers.UseVisualStyleBackColor = true;
            this.chkGreenPeppers.CheckedChanged += new System.EventHandler(this.chkGreenPeppers_CheckedChanged);
            // 
            // chkOlives
            // 
            this.chkOlives.AutoSize = true;
            this.chkOlives.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkOlives.Location = new System.Drawing.Point(164, 129);
            this.chkOlives.Name = "chkOlives";
            this.chkOlives.Size = new System.Drawing.Size(73, 26);
            this.chkOlives.TabIndex = 4;
            this.chkOlives.Tag = "15";
            this.chkOlives.Text = "Olives";
            this.chkOlives.UseVisualStyleBackColor = true;
            this.chkOlives.CheckedChanged += new System.EventHandler(this.chkOlives_CheckedChanged);
            // 
            // chkOnion
            // 
            this.chkOnion.AutoSize = true;
            this.chkOnion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkOnion.Location = new System.Drawing.Point(164, 51);
            this.chkOnion.Name = "chkOnion";
            this.chkOnion.Size = new System.Drawing.Size(75, 26);
            this.chkOnion.TabIndex = 3;
            this.chkOnion.Tag = "15";
            this.chkOnion.Text = "Onion";
            this.chkOnion.UseVisualStyleBackColor = true;
            this.chkOnion.CheckedChanged += new System.EventHandler(this.chkOnion_CheckedChanged);
            // 
            // chkTomatoes
            // 
            this.chkTomatoes.AutoSize = true;
            this.chkTomatoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkTomatoes.Location = new System.Drawing.Point(7, 207);
            this.chkTomatoes.Name = "chkTomatoes";
            this.chkTomatoes.Size = new System.Drawing.Size(103, 26);
            this.chkTomatoes.TabIndex = 2;
            this.chkTomatoes.Tag = "15";
            this.chkTomatoes.Text = "Tomatoes";
            this.chkTomatoes.UseVisualStyleBackColor = true;
            this.chkTomatoes.CheckedChanged += new System.EventHandler(this.chkTomatoes_CheckedChanged);
            // 
            // chkMushrooms
            // 
            this.chkMushrooms.AutoSize = true;
            this.chkMushrooms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkMushrooms.Location = new System.Drawing.Point(7, 129);
            this.chkMushrooms.Name = "chkMushrooms";
            this.chkMushrooms.Size = new System.Drawing.Size(118, 26);
            this.chkMushrooms.TabIndex = 1;
            this.chkMushrooms.Tag = "15";
            this.chkMushrooms.Text = "Mushrooms";
            this.chkMushrooms.UseVisualStyleBackColor = true;
            this.chkMushrooms.CheckedChanged += new System.EventHandler(this.chkMushrooms_CheckedChanged);
            // 
            // chkExtraChees
            // 
            this.chkExtraChees.AutoSize = true;
            this.chkExtraChees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkExtraChees.Location = new System.Drawing.Point(7, 51);
            this.chkExtraChees.Name = "chkExtraChees";
            this.chkExtraChees.Size = new System.Drawing.Size(117, 26);
            this.chkExtraChees.TabIndex = 0;
            this.chkExtraChees.Tag = "15";
            this.chkExtraChees.Text = "Extra Chees";
            this.chkExtraChees.UseVisualStyleBackColor = true;
            this.chkExtraChees.CheckedChanged += new System.EventHandler(this.chkExtraChees_CheckedChanged);
            // 
            // grpCrustType
            // 
            this.grpCrustType.BackColor = System.Drawing.Color.Transparent;
            this.grpCrustType.Controls.Add(this.rdThink);
            this.grpCrustType.Controls.Add(this.rdThin);
            this.grpCrustType.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCrustType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.grpCrustType.Location = new System.Drawing.Point(99, 378);
            this.grpCrustType.Name = "grpCrustType";
            this.grpCrustType.Size = new System.Drawing.Size(162, 166);
            this.grpCrustType.TabIndex = 2;
            this.grpCrustType.TabStop = false;
            this.grpCrustType.Text = "Crust Type";
            // 
            // rdThink
            // 
            this.rdThink.AutoSize = true;
            this.rdThink.BackColor = System.Drawing.Color.Transparent;
            this.rdThink.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.rdThink.Location = new System.Drawing.Point(25, 107);
            this.rdThink.Name = "rdThink";
            this.rdThink.Size = new System.Drawing.Size(117, 26);
            this.rdThink.TabIndex = 10;
            this.rdThink.TabStop = true;
            this.rdThink.Tag = "10";
            this.rdThink.Text = "Think Crust";
            this.rdThink.UseVisualStyleBackColor = false;
            this.rdThink.CheckedChanged += new System.EventHandler(this.rdThink_CheckedChanged);
            // 
            // rdThin
            // 
            this.rdThin.AutoSize = true;
            this.rdThin.BackColor = System.Drawing.Color.Transparent;
            this.rdThin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.rdThin.Location = new System.Drawing.Point(25, 44);
            this.rdThin.Name = "rdThin";
            this.rdThin.Size = new System.Drawing.Size(109, 26);
            this.rdThin.TabIndex = 9;
            this.rdThin.TabStop = true;
            this.rdThin.Tag = "0";
            this.rdThin.Text = "Thin Crust";
            this.rdThin.UseVisualStyleBackColor = false;
            this.rdThin.CheckedChanged += new System.EventHandler(this.rdThin_CheckedChanged);
            // 
            // grpWhereToEat
            // 
            this.grpWhereToEat.BackColor = System.Drawing.Color.Transparent;
            this.grpWhereToEat.Controls.Add(this.rdTakeOut);
            this.grpWhereToEat.Controls.Add(this.rdEateIn);
            this.grpWhereToEat.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpWhereToEat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.grpWhereToEat.Location = new System.Drawing.Point(314, 422);
            this.grpWhereToEat.Name = "grpWhereToEat";
            this.grpWhereToEat.Size = new System.Drawing.Size(328, 89);
            this.grpWhereToEat.TabIndex = 3;
            this.grpWhereToEat.TabStop = false;
            this.grpWhereToEat.Text = "Where To Eat";
            // 
            // rdTakeOut
            // 
            this.rdTakeOut.AutoSize = true;
            this.rdTakeOut.BackColor = System.Drawing.Color.Transparent;
            this.rdTakeOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.rdTakeOut.Location = new System.Drawing.Point(179, 37);
            this.rdTakeOut.Name = "rdTakeOut";
            this.rdTakeOut.Size = new System.Drawing.Size(100, 26);
            this.rdTakeOut.TabIndex = 12;
            this.rdTakeOut.TabStop = true;
            this.rdTakeOut.Tag = "0";
            this.rdTakeOut.Text = "Take Out";
            this.rdTakeOut.UseVisualStyleBackColor = false;
            this.rdTakeOut.CheckedChanged += new System.EventHandler(this.rdTakeOut_CheckedChanged);
            // 
            // rdEateIn
            // 
            this.rdEateIn.AutoSize = true;
            this.rdEateIn.BackColor = System.Drawing.Color.Transparent;
            this.rdEateIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.rdEateIn.Location = new System.Drawing.Point(40, 37);
            this.rdEateIn.Name = "rdEateIn";
            this.rdEateIn.Size = new System.Drawing.Size(84, 26);
            this.rdEateIn.TabIndex = 11;
            this.rdEateIn.TabStop = true;
            this.rdEateIn.Tag = "0";
            this.rdEateIn.Text = "Eate In";
            this.rdEateIn.UseVisualStyleBackColor = false;
            this.rdEateIn.CheckedChanged += new System.EventHandler(this.rdEateIn_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(705, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 39);
            this.label2.TabIndex = 6;
            this.label2.Text = "Order Summary";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(653, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 31);
            this.label3.TabIndex = 7;
            this.label3.Text = "Size :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(653, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 31);
            this.label4.TabIndex = 8;
            this.label4.Text = "Toppings :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(653, 416);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 31);
            this.label5.TabIndex = 9;
            this.label5.Text = "Crust Type :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(653, 486);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(180, 31);
            this.label6.TabIndex = 10;
            this.label6.Text = "Where To Eat :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(688, 588);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 31);
            this.label7.TabIndex = 11;
            this.label7.Text = "Total Price :";
            // 
            // texSize
            // 
            this.texSize.AutoSize = true;
            this.texSize.BackColor = System.Drawing.Color.Transparent;
            this.texSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texSize.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.texSize.Location = new System.Drawing.Point(754, 196);
            this.texSize.Name = "texSize";
            this.texSize.Size = new System.Drawing.Size(0, 25);
            this.texSize.TabIndex = 12;
            // 
            // texToppings
            // 
            this.texToppings.BackColor = System.Drawing.Color.Transparent;
            this.texToppings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texToppings.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.texToppings.Location = new System.Drawing.Point(666, 299);
            this.texToppings.Name = "texToppings";
            this.texToppings.Size = new System.Drawing.Size(311, 100);
            this.texToppings.TabIndex = 13;
            this.texToppings.Text = "No Toppings";
            // 
            // texCrustType
            // 
            this.texCrustType.AutoSize = true;
            this.texCrustType.BackColor = System.Drawing.Color.Transparent;
            this.texCrustType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texCrustType.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.texCrustType.Location = new System.Drawing.Point(805, 419);
            this.texCrustType.Name = "texCrustType";
            this.texCrustType.Size = new System.Drawing.Size(0, 25);
            this.texCrustType.TabIndex = 14;
            // 
            // texWhereToEat
            // 
            this.texWhereToEat.AutoSize = true;
            this.texWhereToEat.BackColor = System.Drawing.Color.Transparent;
            this.texWhereToEat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texWhereToEat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.texWhereToEat.Location = new System.Drawing.Point(839, 489);
            this.texWhereToEat.Name = "texWhereToEat";
            this.texWhereToEat.Size = new System.Drawing.Size(0, 25);
            this.texWhereToEat.TabIndex = 15;
            // 
            // textPrice
            // 
            this.textPrice.AutoSize = true;
            this.textPrice.BackColor = System.Drawing.Color.Transparent;
            this.textPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPrice.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.textPrice.Location = new System.Drawing.Point(857, 580);
            this.textPrice.Name = "textPrice";
            this.textPrice.Size = new System.Drawing.Size(108, 46);
            this.textPrice.TabIndex = 16;
            this.textPrice.Text = "100$";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1004, 669);
            this.Controls.Add(this.textPrice);
            this.Controls.Add(this.texWhereToEat);
            this.Controls.Add(this.texCrustType);
            this.Controls.Add(this.texToppings);
            this.Controls.Add(this.texSize);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grpWhereToEat);
            this.Controls.Add(this.grpCrustType);
            this.Controls.Add(this.grpToppings);
            this.Controls.Add(this.btRestForm);
            this.Controls.Add(this.btnOrderPizza);
            this.Controls.Add(this.grpSize);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpSize.ResumeLayout(false);
            this.grpSize.PerformLayout();
            this.grpToppings.ResumeLayout(false);
            this.grpToppings.PerformLayout();
            this.grpCrustType.ResumeLayout(false);
            this.grpCrustType.PerformLayout();
            this.grpWhereToEat.ResumeLayout(false);
            this.grpWhereToEat.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpSize;
        private System.Windows.Forms.Button btnOrderPizza;
        private System.Windows.Forms.Button btRestForm;
        private System.Windows.Forms.GroupBox grpToppings;
        private System.Windows.Forms.GroupBox grpCrustType;
        private System.Windows.Forms.GroupBox grpWhereToEat;
        private System.Windows.Forms.RadioButton rdSmall;
        private System.Windows.Forms.RadioButton rdLarg;
        private System.Windows.Forms.RadioButton rdMedium;
        private System.Windows.Forms.CheckBox chkGreenPeppers;
        private System.Windows.Forms.CheckBox chkOlives;
        private System.Windows.Forms.CheckBox chkOnion;
        private System.Windows.Forms.CheckBox chkTomatoes;
        private System.Windows.Forms.CheckBox chkMushrooms;
        private System.Windows.Forms.CheckBox chkExtraChees;
        private System.Windows.Forms.RadioButton rdThink;
        private System.Windows.Forms.RadioButton rdThin;
        private System.Windows.Forms.RadioButton rdTakeOut;
        private System.Windows.Forms.RadioButton rdEateIn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label texSize;
        private System.Windows.Forms.Label texToppings;
        private System.Windows.Forms.Label texCrustType;
        private System.Windows.Forms.Label texWhereToEat;
        private System.Windows.Forms.Label textPrice;
    }
}

