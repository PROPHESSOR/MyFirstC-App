namespace ПервыйБлинКомом
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_ver5 = new System.Windows.Forms.Button();
            this.cmb_curVer = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_ver3 = new System.Windows.Forms.Button();
            this.btn_ver1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_update = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_nextVer = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_ver5
            // 
            this.btn_ver5.Location = new System.Drawing.Point(66, 87);
            this.btn_ver5.Name = "btn_ver5";
            this.btn_ver5.Size = new System.Drawing.Size(75, 23);
            this.btn_ver5.TabIndex = 0;
            this.btn_ver5.Text = "Батон";
            this.btn_ver5.UseVisualStyleBackColor = true;
            this.btn_ver5.Click += new System.EventHandler(this.btn_ver5_Click);
            // 
            // cmb_curVer
            // 
            this.cmb_curVer.FormattingEnabled = true;
            this.cmb_curVer.Location = new System.Drawing.Point(196, 61);
            this.cmb_curVer.Name = "cmb_curVer";
            this.cmb_curVer.Size = new System.Drawing.Size(48, 21);
            this.cmb_curVer.TabIndex = 1;
            this.cmb_curVer.Text = "1.0";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btn_ver3);
            this.groupBox1.Controls.Add(this.btn_ver1);
            this.groupBox1.Controls.Add(this.btn_ver5);
            this.groupBox1.Location = new System.Drawing.Point(468, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(203, 137);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Определение версии прошивки";
            // 
            // btn_ver3
            // 
            this.btn_ver3.Location = new System.Drawing.Point(66, 58);
            this.btn_ver3.Name = "btn_ver3";
            this.btn_ver3.Size = new System.Drawing.Size(75, 23);
            this.btn_ver3.TabIndex = 2;
            this.btn_ver3.Text = "Button";
            this.btn_ver3.UseVisualStyleBackColor = true;
            this.btn_ver3.Click += new System.EventHandler(this.btn_ver3_Click);
            // 
            // btn_ver1
            // 
            this.btn_ver1.Location = new System.Drawing.Point(66, 29);
            this.btn_ver1.Name = "btn_ver1";
            this.btn_ver1.Size = new System.Drawing.Size(75, 23);
            this.btn_ver1.TabIndex = 1;
            this.btn_ver1.Text = "Кнопка";
            this.btn_ver1.UseVisualStyleBackColor = true;
            this.btn_ver1.Click += new System.EventHandler(this.btn_ver1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Текущая версия прошивки мозга:";
            // 
            // btn_update
            // 
            this.btn_update.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_update.Location = new System.Drawing.Point(12, 187);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(656, 23);
            this.btn_update.TabIndex = 4;
            this.btn_update.Text = "Обновить";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(659, 39);
            this.label2.TabIndex = 5;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // cmb_nextVer
            // 
            this.cmb_nextVer.FormattingEnabled = true;
            this.cmb_nextVer.Location = new System.Drawing.Point(196, 92);
            this.cmb_nextVer.Name = "cmb_nextVer";
            this.cmb_nextVer.Size = new System.Drawing.Size(48, 21);
            this.cmb_nextVer.TabIndex = 1;
            this.cmb_nextVer.Text = "2.0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Желаемая версия прошивки:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(294, 26);
            this.label4.TabIndex = 6;
            this.label4.Text = "Внимание!\r\nОбновлять можно только на следующую версию за раз!";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(15, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(336, 37);
            this.label5.TabIndex = 7;
            this.label5.Text = "Прошивальщик мозга";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 277);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmb_nextVer);
            this.Controls.Add(this.cmb_curVer);
            this.Name = "Form1";
            this.Text = "Прошивальщик мозга v1.0.0";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ver5;
        private System.Windows.Forms.ComboBox cmb_curVer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_ver3;
        private System.Windows.Forms.Button btn_ver1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_nextVer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

