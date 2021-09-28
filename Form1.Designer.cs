
namespace phoneNumbers
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
            this.listBox_listNumbers = new System.Windows.Forms.ListBox();
            this.textBox_number = new System.Windows.Forms.TextBox();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label_number = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.button_add = new System.Windows.Forms.Button();
            this.listView_contacts = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // listBox_listNumbers
            // 
            this.listBox_listNumbers.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBox_listNumbers.FormattingEnabled = true;
            this.listBox_listNumbers.ItemHeight = 21;
            this.listBox_listNumbers.Location = new System.Drawing.Point(12, 15);
            this.listBox_listNumbers.Name = "listBox_listNumbers";
            this.listBox_listNumbers.Size = new System.Drawing.Size(41, 214);
            this.listBox_listNumbers.TabIndex = 0;
            this.listBox_listNumbers.Click += new System.EventHandler(this.listBox_listNumbers_Click);
            // 
            // textBox_number
            // 
            this.textBox_number.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_number.Location = new System.Drawing.Point(59, 39);
            this.textBox_number.Name = "textBox_number";
            this.textBox_number.Size = new System.Drawing.Size(160, 29);
            this.textBox_number.TabIndex = 1;
            this.textBox_number.Text = "+7";
            // 
            // textBox_name
            // 
            this.textBox_name.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_name.Location = new System.Drawing.Point(244, 39);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(170, 29);
            this.textBox_name.TabIndex = 2;
            // 
            // label_number
            // 
            this.label_number.AutoSize = true;
            this.label_number.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_number.Location = new System.Drawing.Point(104, 15);
            this.label_number.Name = "label_number";
            this.label_number.Size = new System.Drawing.Size(78, 21);
            this.label_number.TabIndex = 3;
            this.label_number.Text = "Телефон";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_name.Location = new System.Drawing.Point(312, 15);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(44, 21);
            this.label_name.TabIndex = 4;
            this.label_name.Text = "Имя";
            // 
            // button_add
            // 
            this.button_add.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_add.Location = new System.Drawing.Point(424, 34);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(231, 36);
            this.button_add.TabIndex = 5;
            this.button_add.Text = "Добавить контакт";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // listView_contacts
            // 
            this.listView_contacts.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.listView_contacts.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listView_contacts.HideSelection = false;
            this.listView_contacts.Location = new System.Drawing.Point(59, 79);
            this.listView_contacts.Name = "listView_contacts";
            this.listView_contacts.Size = new System.Drawing.Size(354, 150);
            this.listView_contacts.TabIndex = 6;
            this.listView_contacts.UseCompatibleStateImageBehavior = false;
            this.listView_contacts.View = System.Windows.Forms.View.List;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 277);
            this.Controls.Add(this.listView_contacts);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.label_number);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.textBox_number);
            this.Controls.Add(this.listBox_listNumbers);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_listNumbers;
        private System.Windows.Forms.TextBox textBox_number;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label label_number;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.ListView listView_contacts;
    }
}

