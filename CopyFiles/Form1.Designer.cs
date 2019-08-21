namespace CopyFiles {
    partial class Form1 {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Actions = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Path1 = new System.Windows.Forms.TextBox();
            this.Path2 = new System.Windows.Forms.TextBox();
            this.Path3 = new System.Windows.Forms.TextBox();
            this.Path4 = new System.Windows.Forms.TextBox();
            this.Search1 = new System.Windows.Forms.Button();
            this.Search2 = new System.Windows.Forms.Button();
            this.Search3 = new System.Windows.Forms.Button();
            this.Search4 = new System.Windows.Forms.Button();
            this.Expansion = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ToChangeFile = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.Path5 = new System.Windows.Forms.TextBox();
            this.Search5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Actions
            // 
            this.Actions.Dock = System.Windows.Forms.DockStyle.Left;
            this.Actions.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Actions.Location = new System.Drawing.Point(0, 0);
            this.Actions.Name = "Actions";
            this.Actions.ReadOnly = true;
            this.Actions.Size = new System.Drawing.Size(395, 505);
            this.Actions.TabIndex = 7;
            this.Actions.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(415, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "Путь к папке 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(415, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "Путь к папке 2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(415, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 21);
            this.label3.TabIndex = 10;
            this.label3.Text = "Путь к папке 3:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(415, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 21);
            this.label4.TabIndex = 11;
            this.label4.Text = "Путь к папке 4:";
            // 
            // Path1
            // 
            this.Path1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Path1.Location = new System.Drawing.Point(419, 32);
            this.Path1.Name = "Path1";
            this.Path1.ReadOnly = true;
            this.Path1.Size = new System.Drawing.Size(218, 26);
            this.Path1.TabIndex = 1;
            // 
            // Path2
            // 
            this.Path2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Path2.Location = new System.Drawing.Point(419, 89);
            this.Path2.Name = "Path2";
            this.Path2.ReadOnly = true;
            this.Path2.Size = new System.Drawing.Size(218, 26);
            this.Path2.TabIndex = 2;
            // 
            // Path3
            // 
            this.Path3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Path3.Location = new System.Drawing.Point(419, 146);
            this.Path3.Name = "Path3";
            this.Path3.ReadOnly = true;
            this.Path3.Size = new System.Drawing.Size(218, 26);
            this.Path3.TabIndex = 3;
            // 
            // Path4
            // 
            this.Path4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Path4.Location = new System.Drawing.Point(419, 206);
            this.Path4.Name = "Path4";
            this.Path4.ReadOnly = true;
            this.Path4.Size = new System.Drawing.Size(218, 26);
            this.Path4.TabIndex = 4;
            // 
            // Search1
            // 
            this.Search1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Search1.Location = new System.Drawing.Point(657, 32);
            this.Search1.Name = "Search1";
            this.Search1.Size = new System.Drawing.Size(39, 23);
            this.Search1.TabIndex = 6;
            this.Search1.Text = "...";
            this.Search1.UseVisualStyleBackColor = true;
            this.Search1.Click += new System.EventHandler(this.Search1_Click);
            // 
            // Search2
            // 
            this.Search2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Search2.Location = new System.Drawing.Point(657, 89);
            this.Search2.Name = "Search2";
            this.Search2.Size = new System.Drawing.Size(39, 23);
            this.Search2.TabIndex = 6;
            this.Search2.Text = "...";
            this.Search2.UseVisualStyleBackColor = true;
            this.Search2.Click += new System.EventHandler(this.Search2_Click);
            // 
            // Search3
            // 
            this.Search3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Search3.Location = new System.Drawing.Point(657, 146);
            this.Search3.Name = "Search3";
            this.Search3.Size = new System.Drawing.Size(39, 23);
            this.Search3.TabIndex = 6;
            this.Search3.Text = "...";
            this.Search3.UseVisualStyleBackColor = true;
            this.Search3.Click += new System.EventHandler(this.Search3_Click);
            // 
            // Search4
            // 
            this.Search4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Search4.Location = new System.Drawing.Point(657, 206);
            this.Search4.Name = "Search4";
            this.Search4.Size = new System.Drawing.Size(39, 23);
            this.Search4.TabIndex = 6;
            this.Search4.Text = "...";
            this.Search4.UseVisualStyleBackColor = true;
            this.Search4.Click += new System.EventHandler(this.Search4_Click);
            // 
            // Expansion
            // 
            this.Expansion.Location = new System.Drawing.Point(626, 327);
            this.Expansion.Name = "Expansion";
            this.Expansion.Size = new System.Drawing.Size(79, 166);
            this.Expansion.TabIndex = 7;
            this.Expansion.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(403, 393);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(217, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Исключённые расширения";
            // 
            // ToChangeFile
            // 
            this.ToChangeFile.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ToChangeFile.Location = new System.Drawing.Point(407, 434);
            this.ToChangeFile.Name = "ToChangeFile";
            this.ToChangeFile.Size = new System.Drawing.Size(124, 39);
            this.ToChangeFile.TabIndex = 12;
            this.ToChangeFile.Text = "Изменить";
            this.ToChangeFile.UseVisualStyleBackColor = true;
            this.ToChangeFile.Click += new System.EventHandler(this.ToChangeFile_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(415, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 21);
            this.label6.TabIndex = 11;
            this.label6.Text = "Путь к папке 5:";
            // 
            // Path5
            // 
            this.Path5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Path5.Location = new System.Drawing.Point(419, 277);
            this.Path5.Name = "Path5";
            this.Path5.ReadOnly = true;
            this.Path5.Size = new System.Drawing.Size(218, 26);
            this.Path5.TabIndex = 4;
            // 
            // Search5
            // 
            this.Search5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Search5.Location = new System.Drawing.Point(655, 280);
            this.Search5.Name = "Search5";
            this.Search5.Size = new System.Drawing.Size(39, 23);
            this.Search5.TabIndex = 6;
            this.Search5.Text = "...";
            this.Search5.UseVisualStyleBackColor = true;
            this.Search5.Click += new System.EventHandler(this.Search5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 505);
            this.Controls.Add(this.ToChangeFile);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Expansion);
            this.Controls.Add(this.Search5);
            this.Controls.Add(this.Search4);
            this.Controls.Add(this.Search3);
            this.Controls.Add(this.Search2);
            this.Controls.Add(this.Search1);
            this.Controls.Add(this.Path5);
            this.Controls.Add(this.Path4);
            this.Controls.Add(this.Path3);
            this.Controls.Add(this.Path2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Path1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Actions);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Copy File";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox Actions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Path1;
        private System.Windows.Forms.TextBox Path2;
        private System.Windows.Forms.TextBox Path3;
        private System.Windows.Forms.TextBox Path4;
        private System.Windows.Forms.Button Search1;
        private System.Windows.Forms.Button Search2;
        private System.Windows.Forms.Button Search3;
        private System.Windows.Forms.Button Search4;
        private System.Windows.Forms.RichTextBox Expansion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ToChangeFile;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Path5;
        private System.Windows.Forms.Button Search5;
    }
}

