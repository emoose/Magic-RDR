
namespace Magic_RDR
{
    partial class HashGeneratorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HashGeneratorForm));
            this.inputBox = new System.Windows.Forms.RichTextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.outputBox = new System.Windows.Forms.RichTextBox();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.generateHashButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputBox
            // 
            this.inputBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputBox.ForeColor = System.Drawing.Color.Silver;
            this.inputBox.Location = new System.Drawing.Point(0, 0);
            this.inputBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.inputBox.Name = "inputBox";
            this.inputBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.inputBox.Size = new System.Drawing.Size(526, 579);
            this.inputBox.TabIndex = 0;
            this.inputBox.Text = "Enter text...";
            this.inputBox.TextChanged += new System.EventHandler(this.inputBox_TextChanged);
            this.inputBox.Enter += new System.EventHandler(this.inputBox_Enter);
            this.inputBox.Leave += new System.EventHandler(this.inputBox_Leave);
            // 
            // statusStrip1
            // 
            this.statusStrip1.AutoSize = false;
            this.statusStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.statusStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.statusStrip1.Location = new System.Drawing.Point(0, 582);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 24, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1078, 58);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // outputBox
            // 
            this.outputBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outputBox.ForeColor = System.Drawing.Color.Black;
            this.outputBox.Location = new System.Drawing.Point(0, 0);
            this.outputBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.outputBox.Name = "outputBox";
            this.outputBox.ReadOnly = true;
            this.outputBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.outputBox.Size = new System.Drawing.Size(527, 579);
            this.outputBox.TabIndex = 2;
            this.outputBox.Text = "";
            // 
            // splitContainer
            // 
            this.splitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.splitContainer.Location = new System.Drawing.Point(9, 9);
            this.splitContainer.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.inputBox);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.outputBox);
            this.splitContainer.Size = new System.Drawing.Size(1060, 579);
            this.splitContainer.SplitterDistance = 526;
            this.splitContainer.SplitterWidth = 7;
            this.splitContainer.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Hex",
            "Unsigned Int"});
            this.comboBox1.Location = new System.Drawing.Point(856, 593);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(210, 32);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.Text = "Hex";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(620, 598);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(226, 33);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Generate on typing";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // generateHashButton
            // 
            this.generateHashButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.generateHashButton.Location = new System.Drawing.Point(9, 592);
            this.generateHashButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.generateHashButton.Name = "generateHashButton";
            this.generateHashButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.generateHashButton.Size = new System.Drawing.Size(206, 44);
            this.generateHashButton.TabIndex = 5;
            this.generateHashButton.Text = "Generate Hash";
            this.generateHashButton.UseVisualStyleBackColor = true;
            this.generateHashButton.Click += new System.EventHandler(this.generateHashButton_Click);
            // 
            // HashGeneratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(168F, 168F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1078, 640);
            this.Controls.Add(this.generateHashButton);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("Arial", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "HashGeneratorForm";
            this.Text = "Hash Generator - MagicRDR";
            this.Load += new System.EventHandler(this.HashGeneratorForm_Load);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox inputBox;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.RichTextBox outputBox;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button generateHashButton;
    }
}