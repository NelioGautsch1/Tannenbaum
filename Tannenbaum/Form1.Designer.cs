namespace Tannenbaum_mit_Klasse
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
            this.buttonDraw = new System.Windows.Forms.Button();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxKronenhoehe = new System.Windows.Forms.TextBox();
            this.textBoxStammbreite = new System.Windows.Forms.TextBox();
            this.textBoxStammhoehe = new System.Windows.Forms.TextBox();
            this.buttonBeenden = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonDraw
            // 
            this.buttonDraw.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDraw.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.buttonDraw.Location = new System.Drawing.Point(1280, 5);
            this.buttonDraw.Margin = new System.Windows.Forms.Padding(5);
            this.buttonDraw.Name = "buttonDraw";
            this.buttonDraw.Size = new System.Drawing.Size(155, 40);
            this.buttonDraw.TabIndex = 4;
            this.buttonDraw.Text = "Tanne zeichnen";
            this.buttonDraw.UseVisualStyleBackColor = false;
            this.buttonDraw.Click += new System.EventHandler(this.buttonDraw_Click);
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxOutput.BackColor = System.Drawing.Color.Lime;
            this.textBoxOutput.Font = new System.Drawing.Font("Courier New", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOutput.Location = new System.Drawing.Point(6, 124);
            this.textBoxOutput.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxOutput.Multiline = true;
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.Size = new System.Drawing.Size(1429, 960);
            this.textBoxOutput.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Kronenhöhe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Stammbreite";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 91);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Stammhöhe";
            // 
            // textBoxKronenhoehe
            // 
            this.textBoxKronenhoehe.Location = new System.Drawing.Point(140, 15);
            this.textBoxKronenhoehe.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxKronenhoehe.Name = "textBoxKronenhoehe";
            this.textBoxKronenhoehe.Size = new System.Drawing.Size(78, 30);
            this.textBoxKronenhoehe.TabIndex = 1;
            this.textBoxKronenhoehe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxKronenHoehe_KeyPress);
            // 
            // textBoxStammbreite
            // 
            this.textBoxStammbreite.Location = new System.Drawing.Point(140, 51);
            this.textBoxStammbreite.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxStammbreite.Name = "textBoxStammbreite";
            this.textBoxStammbreite.Size = new System.Drawing.Size(78, 30);
            this.textBoxStammbreite.TabIndex = 2;
            this.textBoxStammbreite.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxKronenHoehe_KeyPress);
            // 
            // textBoxStammhoehe
            // 
            this.textBoxStammhoehe.Location = new System.Drawing.Point(140, 88);
            this.textBoxStammhoehe.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxStammhoehe.Name = "textBoxStammhoehe";
            this.textBoxStammhoehe.Size = new System.Drawing.Size(78, 30);
            this.textBoxStammhoehe.TabIndex = 3;
            this.textBoxStammhoehe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxKronenHoehe_KeyPress);
            // 
            // buttonBeenden
            // 
            this.buttonBeenden.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBeenden.BackColor = System.Drawing.Color.Red;
            this.buttonBeenden.Location = new System.Drawing.Point(1280, 76);
            this.buttonBeenden.Margin = new System.Windows.Forms.Padding(5);
            this.buttonBeenden.Name = "buttonBeenden";
            this.buttonBeenden.Size = new System.Drawing.Size(155, 40);
            this.buttonBeenden.TabIndex = 13;
            this.buttonBeenden.Text = "Beenden";
            this.buttonBeenden.UseVisualStyleBackColor = false;
            this.buttonBeenden.Click += new System.EventHandler(this.buttonBeenden_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(1445, 1090);
            this.Controls.Add(this.buttonBeenden);
            this.Controls.Add(this.textBoxStammhoehe);
            this.Controls.Add(this.textBoxStammbreite);
            this.Controls.Add(this.textBoxKronenhoehe);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDraw);
            this.Controls.Add(this.textBoxOutput);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tanne zeichnen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDraw;
        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxKronenhoehe;
        private System.Windows.Forms.TextBox textBoxStammbreite;
        private System.Windows.Forms.TextBox textBoxStammhoehe;
        private System.Windows.Forms.Button buttonBeenden;
    }
}

