
namespace ProxyChecker
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
            this.components = new System.ComponentModel.Container();
            this.Title = new System.Windows.Forms.Label();
            this.TopBar = new System.Windows.Forms.Panel();
            this.minimiseButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.proxiesHere = new System.Windows.Forms.RichTextBox();
            this.checkButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.clearButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.scrapeProxies = new System.Windows.Forms.Button();
            this.proxiesType = new System.Windows.Forms.CheckedListBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.creditButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.validInvalid = new System.Windows.Forms.RichTextBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Title.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Title.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Title.Location = new System.Drawing.Point(310, 6);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(77, 15);
            this.Title.TabIndex = 6;
            this.Title.Text = "Proxy Checker";
            // 
            // TopBar
            // 
            this.TopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(148)))));
            this.TopBar.Location = new System.Drawing.Point(0, -1);
            this.TopBar.Name = "TopBar";
            this.TopBar.Size = new System.Drawing.Size(700, 7);
            this.TopBar.TabIndex = 5;
            this.TopBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopBar_MouseDown);
            this.TopBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopBar_MouseMove);
            this.TopBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TopBar_MouseUp);
            // 
            // minimiseButton
            // 
            this.minimiseButton.FlatAppearance.BorderSize = 0;
            this.minimiseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimiseButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.minimiseButton.Location = new System.Drawing.Point(658, 6);
            this.minimiseButton.Name = "minimiseButton";
            this.minimiseButton.Size = new System.Drawing.Size(20, 20);
            this.minimiseButton.TabIndex = 8;
            this.minimiseButton.Text = "-";
            this.minimiseButton.UseVisualStyleBackColor = true;
            this.minimiseButton.Click += new System.EventHandler(this.minimiseButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.closeButton.Location = new System.Drawing.Point(681, 6);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(20, 20);
            this.closeButton.TabIndex = 7;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.proxiesHere);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 83);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(507, 305);
            this.flowLayoutPanel1.TabIndex = 9;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // proxiesHere
            // 
            this.proxiesHere.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.proxiesHere.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.proxiesHere.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.proxiesHere.Location = new System.Drawing.Point(3, 3);
            this.proxiesHere.Name = "proxiesHere";
            this.proxiesHere.Size = new System.Drawing.Size(503, 301);
            this.proxiesHere.TabIndex = 0;
            this.proxiesHere.Text = "";
            // 
            // checkButton
            // 
            this.checkButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.checkButton.FlatAppearance.BorderSize = 0;
            this.checkButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkButton.Location = new System.Drawing.Point(-1, -1);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(170, 40);
            this.checkButton.TabIndex = 10;
            this.checkButton.Text = "Check";
            this.checkButton.UseVisualStyleBackColor = false;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.checkButton);
            this.panel1.Location = new System.Drawing.Point(525, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(170, 40);
            this.panel1.TabIndex = 11;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.clearButton);
            this.panel2.Location = new System.Drawing.Point(525, 129);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(170, 40);
            this.panel2.TabIndex = 12;
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.clearButton.FlatAppearance.BorderSize = 0;
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.clearButton.Location = new System.Drawing.Point(-1, -1);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(170, 40);
            this.clearButton.TabIndex = 10;
            this.clearButton.Text = "Clear List";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.scrapeProxies);
            this.panel3.Location = new System.Drawing.Point(525, 175);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(170, 40);
            this.panel3.TabIndex = 13;
            // 
            // scrapeProxies
            // 
            this.scrapeProxies.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.scrapeProxies.FlatAppearance.BorderSize = 0;
            this.scrapeProxies.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scrapeProxies.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.scrapeProxies.Location = new System.Drawing.Point(-1, -1);
            this.scrapeProxies.Name = "scrapeProxies";
            this.scrapeProxies.Size = new System.Drawing.Size(170, 40);
            this.scrapeProxies.TabIndex = 10;
            this.scrapeProxies.Text = "Scrape Proxies";
            this.scrapeProxies.UseVisualStyleBackColor = false;
            this.scrapeProxies.Click += new System.EventHandler(this.scrapeProxies_Click);
            // 
            // proxiesType
            // 
            this.proxiesType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.proxiesType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.proxiesType.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.proxiesType.FormattingEnabled = true;
            this.proxiesType.Items.AddRange(new object[] {
            "HTTP",
            "SOCKS 4 : SOON",
            "SOCKS 5 : SOON"});
            this.proxiesType.Location = new System.Drawing.Point(3, 3);
            this.proxiesType.Name = "proxiesType";
            this.proxiesType.Size = new System.Drawing.Size(170, 54);
            this.proxiesType.TabIndex = 0;
            this.proxiesType.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.proxiesType_ItemCheck);
            this.proxiesType.SelectedIndexChanged += new System.EventHandler(this.proxiesType_SelectedIndexChanged);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.creditButton);
            this.panel4.Location = new System.Drawing.Point(525, 221);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(170, 40);
            this.panel4.TabIndex = 15;
            // 
            // creditButton
            // 
            this.creditButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.creditButton.FlatAppearance.BorderSize = 0;
            this.creditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.creditButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.creditButton.Location = new System.Drawing.Point(-1, -1);
            this.creditButton.Name = "creditButton";
            this.creditButton.Size = new System.Drawing.Size(170, 40);
            this.creditButton.TabIndex = 10;
            this.creditButton.Text = "Credit";
            this.creditButton.UseVisualStyleBackColor = false;
            this.creditButton.Click += new System.EventHandler(this.creditButton_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel2.Controls.Add(this.validInvalid);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(525, 329);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(170, 59);
            this.flowLayoutPanel2.TabIndex = 16;
            // 
            // validInvalid
            // 
            this.validInvalid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.validInvalid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.validInvalid.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.validInvalid.Location = new System.Drawing.Point(3, 3);
            this.validInvalid.Name = "validInvalid";
            this.validInvalid.ReadOnly = true;
            this.validInvalid.Size = new System.Drawing.Size(166, 55);
            this.validInvalid.TabIndex = 0;
            this.validInvalid.Text = "VALID : ??\n\nINVALID : ??";
            this.validInvalid.TextChanged += new System.EventHandler(this.validInvalid_TextChanged);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.flowLayoutPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel3.Controls.Add(this.proxiesType);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(525, 265);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(170, 58);
            this.flowLayoutPanel3.TabIndex = 17;
            // 
            // timer1
            // 
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(700, 400);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.minimiseButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.TopBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Panel TopBar;
        private System.Windows.Forms.Button minimiseButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.RichTextBox proxiesHere;
        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button scrapeProxies;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button creditButton;
        private System.Windows.Forms.CheckedListBox proxiesType;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.RichTextBox validInvalid;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
    }
}

