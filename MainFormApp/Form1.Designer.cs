namespace MainFormApp
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
            this.treeView = new System.Windows.Forms.TreeView();
            this.saveButton = new System.Windows.Forms.Button();
            this.openButton = new System.Windows.Forms.Button();
            this.changeValueGroupBox = new System.Windows.Forms.GroupBox();
            this.changeValueButton = new System.Windows.Forms.Button();
            this.booleanComboBox = new System.Windows.Forms.ComboBox();
            this.stringTextBox = new System.Windows.Forms.TextBox();
            this.integerNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.changeValueGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.integerNumericUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView
            // 
            this.treeView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView.Location = new System.Drawing.Point(12, 12);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(503, 424);
            this.treeView.TabIndex = 0;
            this.treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_AfterSelect);
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.Location = new System.Drawing.Point(521, 16);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(146, 23);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveXmlButton_Click);
            // 
            // openButton
            // 
            this.openButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.openButton.Location = new System.Drawing.Point(521, 45);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(146, 23);
            this.openButton.TabIndex = 4;
            this.openButton.Text = "Открыть";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // changeValueGroupBox
            // 
            this.changeValueGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.changeValueGroupBox.Controls.Add(this.changeValueButton);
            this.changeValueGroupBox.Controls.Add(this.booleanComboBox);
            this.changeValueGroupBox.Controls.Add(this.stringTextBox);
            this.changeValueGroupBox.Controls.Add(this.integerNumericUpDown);
            this.changeValueGroupBox.Location = new System.Drawing.Point(521, 74);
            this.changeValueGroupBox.Name = "changeValueGroupBox";
            this.changeValueGroupBox.Size = new System.Drawing.Size(146, 155);
            this.changeValueGroupBox.TabIndex = 5;
            this.changeValueGroupBox.TabStop = false;
            this.changeValueGroupBox.Text = "Значение";
            // 
            // changeValueButton
            // 
            this.changeValueButton.Enabled = false;
            this.changeValueButton.Location = new System.Drawing.Point(5, 114);
            this.changeValueButton.Name = "changeValueButton";
            this.changeValueButton.Size = new System.Drawing.Size(134, 23);
            this.changeValueButton.TabIndex = 3;
            this.changeValueButton.Text = "Изменить";
            this.changeValueButton.UseVisualStyleBackColor = true;
            this.changeValueButton.Click += new System.EventHandler(this.changeValueButton_Click);
            // 
            // booleanComboBox
            // 
            this.booleanComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.booleanComboBox.Enabled = false;
            this.booleanComboBox.FormattingEnabled = true;
            this.booleanComboBox.Items.AddRange(new object[] {
            "True",
            "False"});
            this.booleanComboBox.Location = new System.Drawing.Point(5, 71);
            this.booleanComboBox.Name = "booleanComboBox";
            this.booleanComboBox.Size = new System.Drawing.Size(135, 21);
            this.booleanComboBox.TabIndex = 2;
            // 
            // stringTextBox
            // 
            this.stringTextBox.Enabled = false;
            this.stringTextBox.Location = new System.Drawing.Point(5, 45);
            this.stringTextBox.Name = "stringTextBox";
            this.stringTextBox.Size = new System.Drawing.Size(134, 20);
            this.stringTextBox.TabIndex = 1;
            // 
            // integerNumericUpDown
            // 
            this.integerNumericUpDown.Enabled = false;
            this.integerNumericUpDown.Location = new System.Drawing.Point(6, 19);
            this.integerNumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.integerNumericUpDown.Name = "integerNumericUpDown";
            this.integerNumericUpDown.Size = new System.Drawing.Size(134, 20);
            this.integerNumericUpDown.TabIndex = 0;
            this.integerNumericUpDown.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "XML files (*.xml)|*.xml|Binary file (*.bin)|*.bin|My format (*.lab3)|*.lab3";
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "XML files (*.xml)|*.xml|Binary file (*.bin)|*.bin|My format (*.lab3)|*.lab3";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Location = new System.Drawing.Point(521, 235);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(146, 78);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавить";
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(6, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "True",
            "False"});
            this.comboBox1.Location = new System.Drawing.Point(6, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(135, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 448);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.changeValueGroupBox);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.treeView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.changeValueGroupBox.ResumeLayout(false);
            this.changeValueGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.integerNumericUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.GroupBox changeValueGroupBox;
        private System.Windows.Forms.Button changeValueButton;
        private System.Windows.Forms.ComboBox booleanComboBox;
        private System.Windows.Forms.TextBox stringTextBox;
        private System.Windows.Forms.NumericUpDown integerNumericUpDown;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

