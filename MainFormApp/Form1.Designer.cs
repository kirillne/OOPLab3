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
            this.integerNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.stringTextBox = new System.Windows.Forms.TextBox();
            this.booleanComboBox = new System.Windows.Forms.ComboBox();
            this.changeValueButton = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.changeValueGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.integerNumericUpDown)).BeginInit();
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
            // stringTextBox
            // 
            this.stringTextBox.Enabled = false;
            this.stringTextBox.Location = new System.Drawing.Point(5, 45);
            this.stringTextBox.Name = "stringTextBox";
            this.stringTextBox.Size = new System.Drawing.Size(134, 20);
            this.stringTextBox.TabIndex = 1;
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
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "XML files (*.xml)|*.xml|Binary file (*.bin)|*.bin|My format (*.lab3)|*.lab3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 448);
            this.Controls.Add(this.changeValueGroupBox);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.treeView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.changeValueGroupBox.ResumeLayout(false);
            this.changeValueGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.integerNumericUpDown)).EndInit();
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
    }
}

