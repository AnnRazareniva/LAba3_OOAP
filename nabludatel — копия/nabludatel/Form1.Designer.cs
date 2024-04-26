namespace nabludatel
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.High = new System.Windows.Forms.Label();
            this.Weight = new System.Windows.Forms.Label();
            this.Age = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textHigh = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textWeight = new System.Windows.Forms.TextBox();
            this.textAge = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelHealth = new System.Windows.Forms.Label();
            this.labelOften = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.weightChange = new System.Windows.Forms.Label();
            this.highChange = new System.Windows.Forms.Label();
            this.month = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // High
            // 
            this.High.AutoSize = true;
            this.High.Location = new System.Drawing.Point(32, 62);
            this.High.Name = "High";
            this.High.Size = new System.Drawing.Size(66, 13);
            this.High.TabIndex = 3;
            this.High.Text = "Размер, см";
            // 
            // Weight
            // 
            this.Weight.AutoSize = true;
            this.Weight.Location = new System.Drawing.Point(32, 100);
            this.Weight.Name = "Weight";
            this.Weight.Size = new System.Drawing.Size(37, 13);
            this.Weight.TabIndex = 4;
            this.Weight.Text = "Вес, г";
            // 
            // Age
            // 
            this.Age.Location = new System.Drawing.Point(32, 139);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(100, 23);
            this.Age.TabIndex = 5;
            this.Age.Text = "Возраст, мес";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Начальные данные вашего котика";
            // 
            // textHigh
            // 
            this.textHigh.Location = new System.Drawing.Point(128, 59);
            this.textHigh.Name = "textHigh";
            this.textHigh.Size = new System.Drawing.Size(98, 20);
            this.textHigh.TabIndex = 7;
            this.textHigh.Text = "15";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(68, 404);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(671, 397);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // textWeight
            // 
            this.textWeight.Location = new System.Drawing.Point(128, 97);
            this.textWeight.Name = "textWeight";
            this.textWeight.Size = new System.Drawing.Size(98, 20);
            this.textWeight.TabIndex = 9;
            this.textWeight.Text = "1500";
            // 
            // textAge
            // 
            this.textAge.Location = new System.Drawing.Point(128, 136);
            this.textAge.Name = "textAge";
            this.textAge.Size = new System.Drawing.Size(98, 20);
            this.textAge.TabIndex = 10;
            this.textAge.Text = "6";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(64, 317);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 22);
            this.label2.TabIndex = 18;
            this.label2.Text = "Здоровье котика";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(497, 317);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(273, 22);
            this.label3.TabIndex = 19;
            this.label3.Text = "Сколько нужно кормить котика";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(262, 317);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 22);
            this.label4.TabIndex = 20;
            this.label4.Text = "Тип вашего котика";
            // 
            // labelHealth
            // 
            this.labelHealth.AutoSize = true;
            this.labelHealth.Location = new System.Drawing.Point(65, 373);
            this.labelHealth.Name = "labelHealth";
            this.labelHealth.Size = new System.Drawing.Size(48, 13);
            this.labelHealth.TabIndex = 21;
            this.labelHealth.Text = "Данные";
            // 
            // labelOften
            // 
            this.labelOften.AutoSize = true;
            this.labelOften.Location = new System.Drawing.Point(498, 373);
            this.labelOften.Name = "labelOften";
            this.labelOften.Size = new System.Drawing.Size(48, 13);
            this.labelOften.TabIndex = 22;
            this.labelOften.Text = "Данные";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(263, 373);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(48, 13);
            this.labelType.TabIndex = 23;
            this.labelType.Text = "Данные";
            this.labelType.UseMnemonic = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(320, 171);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 59);
            this.button1.TabIndex = 24;
            this.button1.Text = "Как котик?";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // weightChange
            // 
            this.weightChange.AutoSize = true;
            this.weightChange.Location = new System.Drawing.Point(374, 266);
            this.weightChange.Name = "weightChange";
            this.weightChange.Size = new System.Drawing.Size(26, 13);
            this.weightChange.TabIndex = 30;
            this.weightChange.Text = "Вес";
            // 
            // highChange
            // 
            this.highChange.AutoSize = true;
            this.highChange.Location = new System.Drawing.Point(531, 266);
            this.highChange.Name = "highChange";
            this.highChange.Size = new System.Drawing.Size(46, 13);
            this.highChange.TabIndex = 29;
            this.highChange.Text = "Размер";
            // 
            // month
            // 
            this.month.AutoSize = true;
            this.month.Location = new System.Drawing.Point(190, 266);
            this.month.Name = "month";
            this.month.Size = new System.Drawing.Size(48, 13);
            this.month.TabIndex = 28;
            this.month.Text = "Месяцы";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(342, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "Вес";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(479, 266);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Размер";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(136, 266);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Месяцы";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 813);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.weightChange);
            this.Controls.Add(this.highChange);
            this.Controls.Add(this.month);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.labelOften);
            this.Controls.Add(this.labelHealth);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textAge);
            this.Controls.Add(this.textWeight);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textHigh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Age);
            this.Controls.Add(this.Weight);
            this.Controls.Add(this.High);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label High;
        private System.Windows.Forms.Label Weight;
        private System.Windows.Forms.Label Age;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textHigh;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textWeight;
        private System.Windows.Forms.TextBox textAge;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelHealth;
        private System.Windows.Forms.Label labelOften;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label weightChange;
        private System.Windows.Forms.Label highChange;
        private System.Windows.Forms.Label month;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}

