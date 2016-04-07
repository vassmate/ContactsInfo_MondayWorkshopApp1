namespace ContactsInfoApp
{
    partial class Contacts
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
            this.nameBox = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.Label();
            this.typeBox = new System.Windows.Forms.ComboBox();
            this.save = new System.Windows.Forms.Button();
            this.age = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.Label();
            this.mobile = new System.Windows.Forms.Label();
            this.type = new System.Windows.Forms.Label();
            this.addressBox = new System.Windows.Forms.TextBox();
            this.ageBox = new System.Windows.Forms.TextBox();
            this.mobileBox = new System.Windows.Forms.TextBox();
            this.list = new System.Windows.Forms.Button();
            this.listLabel = new System.Windows.Forms.Label();
            this.listBox = new System.Windows.Forms.ListBox();
            this.cpu_usage = new System.Windows.Forms.Label();
            this.memory_usage = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(224, 146);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(161, 20);
            this.nameBox.TabIndex = 1;
            this.nameBox.TextChanged += new System.EventHandler(this.nameBox_TextChanged);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(183, 149);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(35, 13);
            this.name.TabIndex = 2;
            this.name.Text = "Name";
            // 
            // typeBox
            // 
            this.typeBox.FormattingEnabled = true;
            this.typeBox.Location = new System.Drawing.Point(224, 250);
            this.typeBox.Name = "typeBox";
            this.typeBox.Size = new System.Drawing.Size(161, 21);
            this.typeBox.TabIndex = 3;
            this.typeBox.SelectedIndexChanged += new System.EventHandler(this.typeBox_SelectedIndexChanged);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(12, 144);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(80, 23);
            this.save.TabIndex = 4;
            this.save.Text = "Save data";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // age
            // 
            this.age.AutoSize = true;
            this.age.Location = new System.Drawing.Point(192, 201);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(26, 13);
            this.age.TabIndex = 5;
            this.age.Text = "Age";
            // 
            // address
            // 
            this.address.AutoSize = true;
            this.address.Location = new System.Drawing.Point(173, 175);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(45, 13);
            this.address.TabIndex = 6;
            this.address.Text = "Address";
            // 
            // mobile
            // 
            this.mobile.AutoSize = true;
            this.mobile.Location = new System.Drawing.Point(180, 227);
            this.mobile.Name = "mobile";
            this.mobile.Size = new System.Drawing.Size(38, 13);
            this.mobile.TabIndex = 7;
            this.mobile.Text = "Phone";
            this.mobile.Click += new System.EventHandler(this.mobile_Click);
            // 
            // type
            // 
            this.type.AutoSize = true;
            this.type.Location = new System.Drawing.Point(157, 253);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(61, 13);
            this.type.TabIndex = 8;
            this.type.Text = "Phone type";
            // 
            // addressBox
            // 
            this.addressBox.Location = new System.Drawing.Point(224, 172);
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(161, 20);
            this.addressBox.TabIndex = 9;
            this.addressBox.TextChanged += new System.EventHandler(this.addressBox_TextChanged);
            // 
            // ageBox
            // 
            this.ageBox.Location = new System.Drawing.Point(224, 198);
            this.ageBox.Name = "ageBox";
            this.ageBox.Size = new System.Drawing.Size(161, 20);
            this.ageBox.TabIndex = 10;
            this.ageBox.TextChanged += new System.EventHandler(this.ageBox_TextChanged);
            // 
            // mobileBox
            // 
            this.mobileBox.Location = new System.Drawing.Point(224, 224);
            this.mobileBox.Name = "mobileBox";
            this.mobileBox.Size = new System.Drawing.Size(161, 20);
            this.mobileBox.TabIndex = 11;
            this.mobileBox.TextChanged += new System.EventHandler(this.mobileBox_TextChanged);
            // 
            // list
            // 
            this.list.Location = new System.Drawing.Point(12, 173);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(80, 23);
            this.list.TabIndex = 12;
            this.list.Text = "List data";
            this.list.UseVisualStyleBackColor = true;
            this.list.Click += new System.EventHandler(this.list_Click);
            // 
            // listLabel
            // 
            this.listLabel.AutoSize = true;
            this.listLabel.Location = new System.Drawing.Point(9, 9);
            this.listLabel.Name = "listLabel";
            this.listLabel.Size = new System.Drawing.Size(62, 13);
            this.listLabel.TabIndex = 14;
            this.listLabel.Text = "Contact list:";
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.HorizontalScrollbar = true;
            this.listBox.Location = new System.Drawing.Point(12, 29);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(373, 108);
            this.listBox.TabIndex = 15;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // cpu_usage
            // 
            this.cpu_usage.AutoSize = true;
            this.cpu_usage.Location = new System.Drawing.Point(9, 258);
            this.cpu_usage.Name = "cpu_usage";
            this.cpu_usage.Size = new System.Drawing.Size(13, 13);
            this.cpu_usage.TabIndex = 16;
            this.cpu_usage.Text = ">";
            // 
            // memory_usage
            // 
            this.memory_usage.AutoSize = true;
            this.memory_usage.Location = new System.Drawing.Point(9, 279);
            this.memory_usage.Name = "memory_usage";
            this.memory_usage.Size = new System.Drawing.Size(13, 13);
            this.memory_usage.TabIndex = 17;
            this.memory_usage.Text = ">";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Refresh/clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Contacts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 301);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.memory_usage);
            this.Controls.Add(this.cpu_usage);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.listLabel);
            this.Controls.Add(this.list);
            this.Controls.Add(this.mobileBox);
            this.Controls.Add(this.ageBox);
            this.Controls.Add(this.addressBox);
            this.Controls.Add(this.type);
            this.Controls.Add(this.mobile);
            this.Controls.Add(this.address);
            this.Controls.Add(this.age);
            this.Controls.Add(this.save);
            this.Controls.Add(this.typeBox);
            this.Controls.Add(this.name);
            this.Controls.Add(this.nameBox);
            this.MaximumSize = new System.Drawing.Size(415, 340);
            this.MinimumSize = new System.Drawing.Size(415, 340);
            this.Name = "Contacts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contacts";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.ComboBox typeBox;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Label age;
        private System.Windows.Forms.Label address;
        private System.Windows.Forms.Label mobile;
        private System.Windows.Forms.Label type;
        private System.Windows.Forms.TextBox addressBox;
        private System.Windows.Forms.TextBox ageBox;
        private System.Windows.Forms.TextBox mobileBox;
        private System.Windows.Forms.Button list;
        private System.Windows.Forms.Label listLabel;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Label cpu_usage;
        private System.Windows.Forms.Label memory_usage;
        private System.Windows.Forms.Button button1;
    }
}

