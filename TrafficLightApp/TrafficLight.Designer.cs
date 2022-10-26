namespace TrafficLightApp
{
    partial class TrafficLight
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
            this.lbl_S_Bound = new System.Windows.Forms.Label();
            this.lbl_W_Bound = new System.Windows.Forms.Label();
            this.lbl_N_Bound = new System.Windows.Forms.Label();
            this.lbl_E_Bound = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_start = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_S_Bound
            // 
            this.lbl_S_Bound.Enabled = false;
            this.lbl_S_Bound.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_S_Bound.ForeColor = System.Drawing.Color.White;
            this.lbl_S_Bound.Location = new System.Drawing.Point(113, 131);
            this.lbl_S_Bound.Name = "lbl_S_Bound";
            this.lbl_S_Bound.Size = new System.Drawing.Size(100, 20);
            this.lbl_S_Bound.TabIndex = 0;
            // 
            // lbl_W_Bound
            // 
            this.lbl_W_Bound.Enabled = false;
            this.lbl_W_Bound.Location = new System.Drawing.Point(243, 131);
            this.lbl_W_Bound.Name = "lbl_W_Bound";
            this.lbl_W_Bound.Size = new System.Drawing.Size(100, 20);
            this.lbl_W_Bound.TabIndex = 1;
            // 
            // lbl_N_Bound
            // 
            this.lbl_N_Bound.Enabled = false;
            this.lbl_N_Bound.Location = new System.Drawing.Point(377, 131);
            this.lbl_N_Bound.Name = "lbl_N_Bound";
            this.lbl_N_Bound.Size = new System.Drawing.Size(100, 20);
            this.lbl_N_Bound.TabIndex = 2;
            // 
            // lbl_E_Bound
            // 
            this.lbl_E_Bound.Enabled = false;
            this.lbl_E_Bound.Location = new System.Drawing.Point(529, 131);
            this.lbl_E_Bound.Name = "lbl_E_Bound";
            this.lbl_E_Bound.Size = new System.Drawing.Size(100, 20);
            this.lbl_E_Bound.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(110, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "SOUTH BOUND";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(253, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "WEST BOUND";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(383, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "NORTH BOUND";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(552, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "EAST BOUND";
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(331, 224);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(75, 23);
            this.btn_start.TabIndex = 8;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // TrafficLight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_E_Bound);
            this.Controls.Add(this.lbl_N_Bound);
            this.Controls.Add(this.lbl_W_Bound);
            this.Controls.Add(this.lbl_S_Bound);
            this.Name = "TrafficLight";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_S_Bound;
        private System.Windows.Forms.Label lbl_W_Bound;
        private System.Windows.Forms.Label lbl_N_Bound;
        private System.Windows.Forms.Label lbl_E_Bound;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_start;
    }
}

