namespace DrawingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelSize = new System.Windows.Forms.Label();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblRad = new System.Windows.Forms.Label();
            this.txtRad = new System.Windows.Forms.TextBox();
            this.btnFreehand = new System.Windows.Forms.Button();
            this.btnDrawRect = new System.Windows.Forms.Button();
            this.btnDrawEllipse = new System.Windows.Forms.Button();
            this.btnEraseAll = new System.Windows.Forms.Button();
            this.btnColor = new System.Windows.Forms.Button();
            this.btnDrawLine = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnOkSize = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CursorPos = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(891, 665);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.Location = new System.Drawing.Point(10, 32);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(56, 18);
            this.labelSize.TabIndex = 13;
            this.labelSize.Text = "Latime:";
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(107, 30);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(68, 24);
            this.txtWidth.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 15;
            this.label2.Text = "Inaltime:";
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(107, 60);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(68, 24);
            this.txtHeight.TabIndex = 16;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblRad);
            this.groupBox2.Controls.Add(this.txtRad);
            this.groupBox2.Controls.Add(this.txtWidth);
            this.groupBox2.Controls.Add(this.labelSize);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtHeight);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox2.Location = new System.Drawing.Point(903, 428);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(186, 123);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dimensiuni:";
            // 
            // lblRad
            // 
            this.lblRad.AutoSize = true;
            this.lblRad.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblRad.Location = new System.Drawing.Point(10, 95);
            this.lblRad.Name = "lblRad";
            this.lblRad.Size = new System.Drawing.Size(54, 17);
            this.lblRad.TabIndex = 18;
            this.lblRad.Text = "Centru:";
            // 
            // txtRad
            // 
            this.txtRad.Location = new System.Drawing.Point(89, 90);
            this.txtRad.Name = "txtRad";
            this.txtRad.Size = new System.Drawing.Size(86, 24);
            this.txtRad.TabIndex = 17;
            // 
            // btnFreehand
            // 
            this.btnFreehand.BackgroundImage = global::DrawingForm.Properties.Resources.pen2;
            this.btnFreehand.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFreehand.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnFreehand.Location = new System.Drawing.Point(916, 27);
            this.btnFreehand.Name = "btnFreehand";
            this.btnFreehand.Size = new System.Drawing.Size(62, 47);
            this.btnFreehand.TabIndex = 17;
            this.btnFreehand.UseVisualStyleBackColor = true;
            this.btnFreehand.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnFreehand_MouseClick);
            // 
            // btnDrawRect
            // 
            this.btnDrawRect.BackgroundImage = global::DrawingForm.Properties.Resources.rect;
            this.btnDrawRect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDrawRect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDrawRect.Location = new System.Drawing.Point(916, 188);
            this.btnDrawRect.Name = "btnDrawRect";
            this.btnDrawRect.Size = new System.Drawing.Size(62, 48);
            this.btnDrawRect.TabIndex = 11;
            this.btnDrawRect.UseVisualStyleBackColor = true;
            this.btnDrawRect.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnDrawRect_MouseClick);
            // 
            // btnDrawEllipse
            // 
            this.btnDrawEllipse.BackgroundImage = global::DrawingForm.Properties.Resources.ellipse;
            this.btnDrawEllipse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDrawEllipse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDrawEllipse.Location = new System.Drawing.Point(916, 134);
            this.btnDrawEllipse.Name = "btnDrawEllipse";
            this.btnDrawEllipse.Size = new System.Drawing.Size(62, 48);
            this.btnDrawEllipse.TabIndex = 10;
            this.btnDrawEllipse.UseVisualStyleBackColor = true;
            this.btnDrawEllipse.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnDrawEllipse_MouseClick);
            // 
            // btnEraseAll
            // 
            this.btnEraseAll.BackgroundImage = global::DrawingForm.Properties.Resources.eraser;
            this.btnEraseAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEraseAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnEraseAll.Location = new System.Drawing.Point(1007, 143);
            this.btnEraseAll.Name = "btnEraseAll";
            this.btnEraseAll.Size = new System.Drawing.Size(59, 60);
            this.btnEraseAll.TabIndex = 6;
            this.btnEraseAll.UseVisualStyleBackColor = true;
            this.btnEraseAll.Click += new System.EventHandler(this.btnEraseAll_Click);
            // 
            // btnColor
            // 
            this.btnColor.BackgroundImage = global::DrawingForm.Properties.Resources.col;
            this.btnColor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnColor.Location = new System.Drawing.Point(1010, 51);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(57, 60);
            this.btnColor.TabIndex = 4;
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnDrawLine
            // 
            this.btnDrawLine.BackgroundImage = global::DrawingForm.Properties.Resources.line2;
            this.btnDrawLine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDrawLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDrawLine.Location = new System.Drawing.Point(916, 81);
            this.btnDrawLine.Name = "btnDrawLine";
            this.btnDrawLine.Size = new System.Drawing.Size(62, 47);
            this.btnDrawLine.TabIndex = 2;
            this.btnDrawLine.UseVisualStyleBackColor = true;
            this.btnDrawLine.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnDrawLine_MouseClick);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnClose.Location = new System.Drawing.Point(941, 604);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(125, 40);
            this.btnClose.TabIndex = 21;
            this.btnClose.Text = "Iesire";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtSize
            // 
            this.txtSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtSize.Location = new System.Drawing.Point(13, 42);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(60, 24);
            this.txtSize.TabIndex = 23;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnOkSize);
            this.groupBox1.Controls.Add(this.txtSize);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(903, 325);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(186, 82);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Marime creion:";
            // 
            // btnOkSize
            // 
            this.btnOkSize.Location = new System.Drawing.Point(89, 37);
            this.btnOkSize.Name = "btnOkSize";
            this.btnOkSize.Size = new System.Drawing.Size(86, 34);
            this.btnOkSize.TabIndex = 24;
            this.btnOkSize.Text = "Ok";
            this.btnOkSize.UseVisualStyleBackColor = true;
            this.btnOkSize.Click += new System.EventHandler(this.btnOkSize_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(900, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 18);
            this.label1.TabIndex = 26;
            this.label1.Text = "Pozitie cursor:";
            // 
            // CursorPos
            // 
            this.CursorPos.AutoSize = true;
            this.CursorPos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CursorPos.Location = new System.Drawing.Point(937, 289);
            this.CursorPos.Name = "CursorPos";
            this.CursorPos.Size = new System.Drawing.Size(0, 20);
            this.CursorPos.TabIndex = 27;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 665);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CursorPos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnFreehand);
            this.Controls.Add(this.btnDrawRect);
            this.Controls.Add(this.btnDrawEllipse);
            this.Controls.Add(this.btnEraseAll);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.btnDrawLine);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDrawLine;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Button btnEraseAll;
        private System.Windows.Forms.Button btnDrawEllipse;
        private System.Windows.Forms.Button btnDrawRect;
        private System.Windows.Forms.Label labelSize;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Button btnFreehand;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnOkSize;
        private System.Windows.Forms.Label lblRad;
        private System.Windows.Forms.TextBox txtRad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label CursorPos;
    }
}

