namespace MidtermPart2
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
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            Search = new Button();
            EmpId = new TextBox();
            Fname = new TextBox();
            Lname = new TextBox();
            dats = new DataGridView();
            label5 = new Label();
            Pos = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dats).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Symbol", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 57);
            label2.Name = "label2";
            label2.Size = new Size(114, 28);
            label2.TabIndex = 1;
            label2.Text = "Primary key";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Emoji", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(152, 9);
            label1.Name = "label1";
            label1.Size = new Size(113, 32);
            label1.TabIndex = 2;
            label1.Text = "Midterm ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Symbol", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(27, 95);
            label3.Name = "label3";
            label3.Size = new Size(73, 28);
            label3.TabIndex = 3;
            label3.Text = "entity1";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Symbol", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(27, 136);
            label4.Name = "label4";
            label4.Size = new Size(78, 28);
            label4.TabIndex = 4;
            label4.Text = "Entity 2";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(384, 57);
            button1.Name = "button1";
            button1.Size = new Size(75, 28);
            button1.TabIndex = 5;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(384, 95);
            button2.Name = "button2";
            button2.Size = new Size(75, 28);
            button2.TabIndex = 6;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(384, 136);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 7;
            button3.Text = "Update";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Search
            // 
            Search.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Search.Location = new Point(384, 176);
            Search.Name = "Search";
            Search.Size = new Size(75, 23);
            Search.TabIndex = 8;
            Search.Text = "Reset";
            Search.UseVisualStyleBackColor = true;
            Search.Click += button4_Click;
            // 
            // EmpId
            // 
            EmpId.Location = new Point(132, 62);
            EmpId.Name = "EmpId";
            EmpId.Size = new Size(199, 23);
            EmpId.TabIndex = 9;
            // 
            // Fname
            // 
            Fname.Location = new Point(132, 99);
            Fname.Name = "Fname";
            Fname.Size = new Size(199, 23);
            Fname.TabIndex = 10;
            // 
            // Lname
            // 
            Lname.Location = new Point(132, 144);
            Lname.Name = "Lname";
            Lname.Size = new Size(199, 23);
            Lname.TabIndex = 11;
            // 
            // dats
            // 
            dats.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dats.Location = new Point(35, 231);
            dats.Name = "dats";
            dats.RowTemplate.Height = 25;
            dats.Size = new Size(424, 215);
            dats.TabIndex = 12;
            dats.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Symbol", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(27, 176);
            label5.Name = "label5";
            label5.Size = new Size(78, 28);
            label5.TabIndex = 13;
            label5.Text = "Entity 3";
            label5.Click += label5_Click;
            // 
            // Pos
            // 
            Pos.Location = new Point(131, 181);
            Pos.Name = "Pos";
            Pos.Size = new Size(199, 23);
            Pos.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GhostWhite;
            ClientSize = new Size(479, 467);
            Controls.Add(Pos);
            Controls.Add(label5);
            Controls.Add(dats);
            Controls.Add(Lname);
            Controls.Add(Fname);
            Controls.Add(EmpId);
            Controls.Add(Search);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dats).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button Search;
        private TextBox EmpId;
        private TextBox Fname;
        private TextBox Lname;
        private DataGridView dats;
        private Label label5;
        private TextBox Pos;
    }
}