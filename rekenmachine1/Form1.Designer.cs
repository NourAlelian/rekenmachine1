namespace rekenmachine1
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
            this.b7 = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.bCE = new System.Windows.Forms.Button();
            this.bDiv = new System.Windows.Forms.Button();
            this.b9 = new System.Windows.Forms.Button();
            this.b8 = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.bC = new System.Windows.Forms.Button();
            this.bMul = new System.Windows.Forms.Button();
            this.b6 = new System.Windows.Forms.Button();
            this.b5 = new System.Windows.Forms.Button();
            this.b1 = new System.Windows.Forms.Button();
            this.bEq = new System.Windows.Forms.Button();
            this.bSub = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.bAdd = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.b0 = new System.Windows.Forms.Button();
            this.ibResult = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // b7
            // 
            this.b7.Location = new System.Drawing.Point(12, 60);
            this.b7.Name = "b7";
            this.b7.Size = new System.Drawing.Size(64, 62);
            this.b7.TabIndex = 0;
            this.b7.Text = "7";
            this.b7.UseVisualStyleBackColor = true;
            this.b7.Click += new System.EventHandler(this.NumEvent);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(9, 12);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(370, 42);
            this.txtResult.TabIndex = 1;
            this.txtResult.Text = "0";
            this.txtResult.TextChanged += new System.EventHandler(this.txtResult_TextChanged);
            // 
            // bCE
            // 
            this.bCE.Location = new System.Drawing.Point(292, 60);
            this.bCE.Name = "bCE";
            this.bCE.Size = new System.Drawing.Size(90, 62);
            this.bCE.TabIndex = 2;
            this.bCE.Text = "CE";
            this.bCE.UseVisualStyleBackColor = true;
            this.bCE.Click += new System.EventHandler(this.bCE_Click);
            // 
            // bDiv
            // 
            this.bDiv.Location = new System.Drawing.Point(222, 60);
            this.bDiv.Name = "bDiv";
            this.bDiv.Size = new System.Drawing.Size(64, 62);
            this.bDiv.TabIndex = 3;
            this.bDiv.Text = "/";
            this.bDiv.UseVisualStyleBackColor = true;
            this.bDiv.Click += new System.EventHandler(this.operandEvent);
            // 
            // b9
            // 
            this.b9.Location = new System.Drawing.Point(152, 60);
            this.b9.Name = "b9";
            this.b9.Size = new System.Drawing.Size(64, 62);
            this.b9.TabIndex = 4;
            this.b9.Text = "9";
            this.b9.UseVisualStyleBackColor = true;
            this.b9.Click += new System.EventHandler(this.NumEvent);
            // 
            // b8
            // 
            this.b8.Location = new System.Drawing.Point(82, 60);
            this.b8.Name = "b8";
            this.b8.Size = new System.Drawing.Size(64, 62);
            this.b8.TabIndex = 5;
            this.b8.Text = "8";
            this.b8.UseVisualStyleBackColor = true;
            this.b8.Click += new System.EventHandler(this.NumEvent);
            // 
            // b4
            // 
            this.b4.Location = new System.Drawing.Point(12, 128);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(64, 62);
            this.b4.TabIndex = 0;
            this.b4.Text = "4";
            this.b4.UseVisualStyleBackColor = true;
            this.b4.Click += new System.EventHandler(this.NumEvent);
            // 
            // bC
            // 
            this.bC.Location = new System.Drawing.Point(292, 128);
            this.bC.Name = "bC";
            this.bC.Size = new System.Drawing.Size(90, 62);
            this.bC.TabIndex = 2;
            this.bC.Text = "C";
            this.bC.UseVisualStyleBackColor = true;
            this.bC.Click += new System.EventHandler(this.bC_Click);
            // 
            // bMul
            // 
            this.bMul.Location = new System.Drawing.Point(222, 128);
            this.bMul.Name = "bMul";
            this.bMul.Size = new System.Drawing.Size(64, 62);
            this.bMul.TabIndex = 3;
            this.bMul.Text = "*";
            this.bMul.UseVisualStyleBackColor = true;
            this.bMul.Click += new System.EventHandler(this.operandEvent);
            // 
            // b6
            // 
            this.b6.Location = new System.Drawing.Point(152, 128);
            this.b6.Name = "b6";
            this.b6.Size = new System.Drawing.Size(64, 62);
            this.b6.TabIndex = 4;
            this.b6.Text = "6";
            this.b6.UseVisualStyleBackColor = true;
            this.b6.Click += new System.EventHandler(this.NumEvent);
            // 
            // b5
            // 
            this.b5.Location = new System.Drawing.Point(82, 128);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(64, 62);
            this.b5.TabIndex = 5;
            this.b5.Text = "5";
            this.b5.UseVisualStyleBackColor = true;
            this.b5.Click += new System.EventHandler(this.NumEvent);
            // 
            // b1
            // 
            this.b1.Location = new System.Drawing.Point(12, 196);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(64, 62);
            this.b1.TabIndex = 0;
            this.b1.Text = "1";
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.NumEvent);
            // 
            // bEq
            // 
            this.bEq.Location = new System.Drawing.Point(292, 196);
            this.bEq.Name = "bEq";
            this.bEq.Size = new System.Drawing.Size(90, 130);
            this.bEq.TabIndex = 2;
            this.bEq.Text = "=";
            this.bEq.UseVisualStyleBackColor = true;
            this.bEq.Click += new System.EventHandler(this.bEq_Click);
            // 
            // bSub
            // 
            this.bSub.Location = new System.Drawing.Point(222, 196);
            this.bSub.Name = "bSub";
            this.bSub.Size = new System.Drawing.Size(64, 62);
            this.bSub.TabIndex = 3;
            this.bSub.Text = "-";
            this.bSub.UseVisualStyleBackColor = true;
            this.bSub.Click += new System.EventHandler(this.operandEvent);
            // 
            // b3
            // 
            this.b3.Location = new System.Drawing.Point(152, 196);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(64, 62);
            this.b3.TabIndex = 4;
            this.b3.Text = "3";
            this.b3.UseVisualStyleBackColor = true;
            this.b3.Click += new System.EventHandler(this.NumEvent);
            // 
            // b2
            // 
            this.b2.Location = new System.Drawing.Point(82, 196);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(64, 62);
            this.b2.TabIndex = 5;
            this.b2.Text = "2";
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.NumEvent);
            // 
            // bAdd
            // 
            this.bAdd.Location = new System.Drawing.Point(222, 264);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(64, 62);
            this.bAdd.TabIndex = 3;
            this.bAdd.Text = "+";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.operandEvent);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(152, 264);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(64, 62);
            this.button15.TabIndex = 3;
            this.button15.Text = ",";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // b0
            // 
            this.b0.Location = new System.Drawing.Point(12, 264);
            this.b0.Name = "b0";
            this.b0.Size = new System.Drawing.Size(134, 62);
            this.b0.TabIndex = 3;
            this.b0.Text = "0";
            this.b0.UseVisualStyleBackColor = true;
            this.b0.Click += new System.EventHandler(this.NumEvent);
            // 
            // ibResult
            // 
            this.ibResult.AutoSize = true;
            this.ibResult.Location = new System.Drawing.Point(12, 37);
            this.ibResult.Name = "ibResult";
            this.ibResult.Size = new System.Drawing.Size(0, 17);
            this.ibResult.TabIndex = 6;
            this.ibResult.Click += new System.EventHandler(this.ibResult_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 7;
            this.label1.Click += new System.EventHandler(this.lbResult);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 348);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ibResult);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b5);
            this.Controls.Add(this.b8);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.b6);
            this.Controls.Add(this.b9);
            this.Controls.Add(this.b0);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.bSub);
            this.Controls.Add(this.bEq);
            this.Controls.Add(this.bMul);
            this.Controls.Add(this.bC);
            this.Controls.Add(this.bDiv);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.bCE);
            this.Controls.Add(this.b4);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.b7);
            this.Name = "Form1";
            this.Text = "Rekenmachine";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b7;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button bCE;
        private System.Windows.Forms.Button bDiv;
        private System.Windows.Forms.Button b9;
        private System.Windows.Forms.Button b8;
        private System.Windows.Forms.Button b4;
        private System.Windows.Forms.Button bC;
        private System.Windows.Forms.Button bMul;
        private System.Windows.Forms.Button b6;
        private System.Windows.Forms.Button b5;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button bEq;
        private System.Windows.Forms.Button bSub;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button b0;
        private System.Windows.Forms.Label ibResult;
        private System.Windows.Forms.Label label1;
    }
}

