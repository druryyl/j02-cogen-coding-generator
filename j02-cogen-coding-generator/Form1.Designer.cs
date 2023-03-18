namespace j02_cogen_coding_generator
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
            splitContainer1 = new SplitContainer();
            panel1 = new Panel();
            label3 = new Label();
            PrefixTableTextBox = new TextBox();
            PropertiesTextBox = new TextBox();
            label2 = new Label();
            ModelNameTextBox = new TextBox();
            label1 = new Label();
            GenerateButton = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            ClassModelTextBox = new TextBox();
            tabPage2 = new TabPage();
            ScriptTableTextBox = new TextBox();
            tabPage3 = new TabPage();
            QueryDalTextBox = new TextBox();
            statusStrip1 = new StatusStrip();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            splitContainer1.FixedPanel = FixedPanel.Panel1;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(panel1);
            splitContainer1.Panel1.Controls.Add(GenerateButton);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(tabControl1);
            splitContainer1.Size = new Size(800, 425);
            splitContainer1.SplitterDistance = 288;
            splitContainer1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(PrefixTableTextBox);
            panel1.Controls.Add(PropertiesTextBox);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(ModelNameTextBox);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(273, 374);
            panel1.TabIndex = 0;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new Point(8, 322);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 5;
            label3.Text = "Prefix Table";
            // 
            // PrefixTableTextBox
            // 
            PrefixTableTextBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PrefixTableTextBox.Location = new Point(8, 340);
            PrefixTableTextBox.Name = "PrefixTableTextBox";
            PrefixTableTextBox.Size = new Size(258, 23);
            PrefixTableTextBox.TabIndex = 4;
            // 
            // PropertiesTextBox
            // 
            PropertiesTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PropertiesTextBox.Location = new Point(8, 70);
            PropertiesTextBox.Multiline = true;
            PropertiesTextBox.Name = "PropertiesTextBox";
            PropertiesTextBox.Size = new Size(258, 249);
            PropertiesTextBox.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 52);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 2;
            label2.Text = "Properties";
            // 
            // ModelNameTextBox
            // 
            ModelNameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ModelNameTextBox.Location = new Point(8, 26);
            ModelNameTextBox.Name = "ModelNameTextBox";
            ModelNameTextBox.Size = new Size(258, 23);
            ModelNameTextBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 8);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 0;
            label1.Text = "Model Name";
            // 
            // GenerateButton
            // 
            GenerateButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            GenerateButton.Location = new Point(12, 392);
            GenerateButton.Name = "GenerateButton";
            GenerateButton.Size = new Size(273, 30);
            GenerateButton.TabIndex = 1;
            GenerateButton.Text = "Generate";
            GenerateButton.UseVisualStyleBackColor = true;
            GenerateButton.Click += GenerateButton_Click;
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(3, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(493, 410);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(ClassModelTextBox);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(485, 382);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Class Model";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // ClassModelTextBox
            // 
            ClassModelTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ClassModelTextBox.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ClassModelTextBox.Location = new Point(3, 6);
            ClassModelTextBox.Multiline = true;
            ClassModelTextBox.Name = "ClassModelTextBox";
            ClassModelTextBox.Size = new Size(476, 370);
            ClassModelTextBox.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(ScriptTableTextBox);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(485, 382);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Script Table";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // ScriptTableTextBox
            // 
            ScriptTableTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ScriptTableTextBox.Location = new Point(4, 6);
            ScriptTableTextBox.Multiline = true;
            ScriptTableTextBox.Name = "ScriptTableTextBox";
            ScriptTableTextBox.Size = new Size(476, 370);
            ScriptTableTextBox.TabIndex = 1;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(QueryDalTextBox);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(485, 382);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Query DAL";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // QueryDalTextBox
            // 
            QueryDalTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            QueryDalTextBox.Font = new Font("Consolas", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            QueryDalTextBox.Location = new Point(4, 6);
            QueryDalTextBox.Multiline = true;
            QueryDalTextBox.Name = "QueryDalTextBox";
            QueryDalTextBox.Size = new Size(476, 370);
            QueryDalTextBox.TabIndex = 2;
            // 
            // statusStrip1
            // 
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(800, 450);
            Controls.Add(statusStrip1);
            Controls.Add(splitContainer1);
            Name = "Form1";
            Text = "Cogen";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private SplitContainer splitContainer1;
        private Button GenerateButton;
        private Label label1;
        private TextBox ModelNameTextBox;
        private Label label2;
        private TextBox PropertiesTextBox;
        private StatusStrip statusStrip1;
        private Panel panel1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TextBox ClassModelTextBox;
        private TextBox ScriptTableTextBox;
        private TabPage tabPage3;
        private TextBox QueryDalTextBox;
        private Label label3;
        private TextBox PrefixTableTextBox;
    }
}