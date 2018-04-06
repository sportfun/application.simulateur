namespace application.simulateur
{
    partial class Simulateur
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.sendInterval = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.textBox = new System.Windows.Forms.RichTextBox();
            this.btnRightButtonLower = new System.Windows.Forms.Button();
            this.btnRightButtonUpper = new System.Windows.Forms.Button();
            this.btnLeftButtonLower = new System.Windows.Forms.Button();
            this.btnLeftButtonUpper = new System.Windows.Forms.Button();
            this.numVariationMin = new System.Windows.Forms.NumericUpDown();
            this.numVariationMax = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numRPM = new System.Windows.Forms.NumericUpDown();
            this.lblUsername = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.numVariationMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVariationMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRPM)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Montserrat SemiBold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.label2.Location = new System.Drawing.Point(171, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 62);
            this.label2.TabIndex = 21;
            this.label2.Text = "Fun";
            // 
            // sendInterval
            // 
            this.sendInterval.Interval = 500;
            this.sendInterval.Tick += new System.EventHandler(this.sendInterval_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Montserrat SemiBold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label1.Location = new System.Drawing.Point(39, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 51);
            this.label1.TabIndex = 20;
            this.label1.Text = "Sports";
            // 
            // textBox
            // 
            this.textBox.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox.Location = new System.Drawing.Point(319, 15);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(697, 268);
            this.textBox.TabIndex = 17;
            this.textBox.Text = "";
            // 
            // btnRightButtonLower
            // 
            this.btnRightButtonLower.Font = new System.Drawing.Font("Montserrat Alternates ExLight", 12F);
            this.btnRightButtonLower.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnRightButtonLower.Location = new System.Drawing.Point(184, 65);
            this.btnRightButtonLower.Name = "btnRightButtonLower";
            this.btnRightButtonLower.Size = new System.Drawing.Size(120, 40);
            this.btnRightButtonLower.TabIndex = 8;
            this.btnRightButtonLower.Text = "RB 2";
            this.btnRightButtonLower.UseVisualStyleBackColor = true;
            this.btnRightButtonLower.Click += new System.EventHandler(this.btnRightButtonLower_Click);
            // 
            // btnRightButtonUpper
            // 
            this.btnRightButtonUpper.Font = new System.Drawing.Font("Montserrat Alternates ExLight", 12F);
            this.btnRightButtonUpper.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnRightButtonUpper.Location = new System.Drawing.Point(184, 19);
            this.btnRightButtonUpper.Name = "btnRightButtonUpper";
            this.btnRightButtonUpper.Size = new System.Drawing.Size(120, 40);
            this.btnRightButtonUpper.TabIndex = 7;
            this.btnRightButtonUpper.Text = "RB 1";
            this.btnRightButtonUpper.UseVisualStyleBackColor = true;
            this.btnRightButtonUpper.Click += new System.EventHandler(this.btnRightButtonUpper_Click);
            // 
            // btnLeftButtonLower
            // 
            this.btnLeftButtonLower.Font = new System.Drawing.Font("Montserrat Alternates ExLight", 12F);
            this.btnLeftButtonLower.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnLeftButtonLower.Location = new System.Drawing.Point(6, 65);
            this.btnLeftButtonLower.Name = "btnLeftButtonLower";
            this.btnLeftButtonLower.Size = new System.Drawing.Size(120, 40);
            this.btnLeftButtonLower.TabIndex = 6;
            this.btnLeftButtonLower.Text = "LB 2";
            this.btnLeftButtonLower.UseVisualStyleBackColor = true;
            this.btnLeftButtonLower.Click += new System.EventHandler(this.btnLeftButtonLower_Click);
            // 
            // btnLeftButtonUpper
            // 
            this.btnLeftButtonUpper.Font = new System.Drawing.Font("Montserrat Alternates ExLight", 12F);
            this.btnLeftButtonUpper.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnLeftButtonUpper.Location = new System.Drawing.Point(6, 19);
            this.btnLeftButtonUpper.Name = "btnLeftButtonUpper";
            this.btnLeftButtonUpper.Size = new System.Drawing.Size(120, 40);
            this.btnLeftButtonUpper.TabIndex = 5;
            this.btnLeftButtonUpper.Text = "LB 1";
            this.btnLeftButtonUpper.UseVisualStyleBackColor = true;
            this.btnLeftButtonUpper.Click += new System.EventHandler(this.btnLeftButtonUpper_Click);
            // 
            // numVariationMin
            // 
            this.numVariationMin.Font = new System.Drawing.Font("Montserrat Alternates ExLight", 12F);
            this.numVariationMin.Location = new System.Drawing.Point(67, 49);
            this.numVariationMin.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numVariationMin.Name = "numVariationMin";
            this.numVariationMin.Size = new System.Drawing.Size(109, 27);
            this.numVariationMin.TabIndex = 8;
            // 
            // numVariationMax
            // 
            this.numVariationMax.Font = new System.Drawing.Font("Montserrat Alternates ExLight", 12F);
            this.numVariationMax.Location = new System.Drawing.Point(184, 49);
            this.numVariationMax.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numVariationMax.Name = "numVariationMax";
            this.numVariationMax.Size = new System.Drawing.Size(109, 27);
            this.numVariationMax.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat Alternates ExLight", 12F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label3.Location = new System.Drawing.Point(18, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "+/-";
            // 
            // numRPM
            // 
            this.numRPM.Font = new System.Drawing.Font("Montserrat Alternates ExLight", 12F);
            this.numRPM.Location = new System.Drawing.Point(67, 16);
            this.numRPM.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numRPM.Name = "numRPM";
            this.numRPM.Size = new System.Drawing.Size(226, 27);
            this.numRPM.TabIndex = 5;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Montserrat Alternates ExLight", 12F);
            this.lblUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblUsername.Location = new System.Drawing.Point(6, 16);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(52, 22);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "RPM";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.numVariationMin);
            this.groupBox1.Controls.Add(this.numVariationMax);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.numRPM);
            this.groupBox1.Controls.Add(this.lblUsername);
            this.groupBox1.Location = new System.Drawing.Point(3, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 96);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.btnRightButtonLower);
            this.groupBox2.Controls.Add(this.btnRightButtonUpper);
            this.groupBox2.Controls.Add(this.btnLeftButtonLower);
            this.groupBox2.Controls.Add(this.btnLeftButtonUpper);
            this.groupBox2.Location = new System.Drawing.Point(3, 165);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(310, 118);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            // 
            // Simulateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 294);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Simulateur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simulateur";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numVariationMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVariationMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRPM)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer sendInterval;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox textBox;
        private System.Windows.Forms.Button btnRightButtonLower;
        private System.Windows.Forms.Button btnRightButtonUpper;
        private System.Windows.Forms.Button btnLeftButtonLower;
        private System.Windows.Forms.Button btnLeftButtonUpper;
        private System.Windows.Forms.NumericUpDown numVariationMin;
        private System.Windows.Forms.NumericUpDown numVariationMax;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numRPM;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

