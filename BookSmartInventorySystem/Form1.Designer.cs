namespace BookSmartInventorySystem
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
            btnManageInventory = new Button();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnManageInventory
            // 
            btnManageInventory.Location = new Point(12, 23);
            btnManageInventory.Name = "btnManageInventory";
            btnManageInventory.Size = new Size(131, 23);
            btnManageInventory.TabIndex = 0;
            btnManageInventory.Text = "Manage Inventory";
            btnManageInventory.UseVisualStyleBackColor = true;
            btnManageInventory.Click += btnManageInventory_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(312, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1132, 761);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button1
            // 
            button1.Location = new Point(12, 389);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Quit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btn_Quit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1472, 785);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(btnManageInventory);
            Name = "Form1";
            Text = "BookSmart Inventory System";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnManageInventory;
        private DataGridView dataGridView1;
        private Button button1;
    }
}
