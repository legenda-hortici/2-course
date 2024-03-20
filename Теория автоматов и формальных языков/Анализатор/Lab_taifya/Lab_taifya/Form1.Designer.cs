
namespace Lab_taifya
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
            this.label_head = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_input = new System.Windows.Forms.Label();
            this.input_box = new System.Windows.Forms.RichTextBox();
            this.button_check = new System.Windows.Forms.Button();
            this.label_table = new System.Windows.Forms.Label();
            this.identificators_and_constants = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_head
            // 
            this.label_head.AutoSize = true;
            this.label_head.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_head.Location = new System.Drawing.Point(70, 30);
            this.label_head.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_head.Name = "label_head";
            this.label_head.Size = new System.Drawing.Size(1199, 130);
            this.label_head.TabIndex = 0;
            this.label_head.Text = "Лабораторная работа\r\nВыполнил студент группы 6203 Мананников Максим\r\n";
            this.label_head.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label_head);
            this.panel1.Location = new System.Drawing.Point(0, -3);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1338, 197);
            this.panel1.TabIndex = 1;
            // 
            // label_input
            // 
            this.label_input.AutoSize = true;
            this.label_input.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_input.Location = new System.Drawing.Point(27, 198);
            this.label_input.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_input.Name = "label_input";
            this.label_input.Size = new System.Drawing.Size(296, 51);
            this.label_input.TabIndex = 2;
            this.label_input.Text = "Введите строку:";
            // 
            // input_box
            // 
            this.input_box.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.input_box.Location = new System.Drawing.Point(27, 266);
            this.input_box.Margin = new System.Windows.Forms.Padding(4);
            this.input_box.Name = "input_box";
            this.input_box.Size = new System.Drawing.Size(977, 69);
            this.input_box.TabIndex = 3;
            this.input_box.Text = "";
            // 
            // button_check
            // 
            this.button_check.BackColor = System.Drawing.SystemColors.Control;
            this.button_check.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button_check.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_check.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_check.Location = new System.Drawing.Point(1045, 266);
            this.button_check.Margin = new System.Windows.Forms.Padding(4);
            this.button_check.Name = "button_check";
            this.button_check.Size = new System.Drawing.Size(224, 70);
            this.button_check.TabIndex = 4;
            this.button_check.Text = "Проверить";
            this.button_check.UseVisualStyleBackColor = false;
            this.button_check.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_table
            // 
            this.label_table.AutoSize = true;
            this.label_table.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_table.Location = new System.Drawing.Point(16, 449);
            this.label_table.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_table.Name = "label_table";
            this.label_table.Size = new System.Drawing.Size(524, 41);
            this.label_table.TabIndex = 5;
            this.label_table.Text = "Список идентификаторов и констант";
            // 
            // identificators_and_constants
            // 
            this.identificators_and_constants.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.identificators_and_constants.FormattingEnabled = true;
            this.identificators_and_constants.ItemHeight = 45;
            this.identificators_and_constants.Location = new System.Drawing.Point(25, 498);
            this.identificators_and_constants.Margin = new System.Windows.Forms.Padding(4);
            this.identificators_and_constants.Name = "identificators_and_constants";
            this.identificators_and_constants.Size = new System.Drawing.Size(979, 274);
            this.identificators_and_constants.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(18, 340);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(988, 109);
            this.label3.TabIndex = 7;
            this.label3.Text = "Здесь будет результат работы анализатора";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(1045, 344);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(224, 70);
            this.button1.TabIndex = 8;
            this.button1.Text = "Стереть";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1336, 805);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.identificators_and_constants);
            this.Controls.Add(this.label_table);
            this.Controls.Add(this.button_check);
            this.Controls.Add(this.input_box);
            this.Controls.Add(this.label_input);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Анализатор";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_head;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_input;
        private System.Windows.Forms.RichTextBox input_box;
        private System.Windows.Forms.Button button_check;
        private System.Windows.Forms.Label label_table;
        private System.Windows.Forms.ListBox identificators_and_constants;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}

