namespace SmashASmurf
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblHit = new System.Windows.Forms.Label();
            this.lblMiss = new System.Windows.Forms.Label();
            this.Smurf = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Smurf)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHit
            // 
            this.lblHit.AutoSize = true;
            this.lblHit.BackColor = System.Drawing.Color.Transparent;
            this.lblHit.CausesValidation = false;
            this.lblHit.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHit.Location = new System.Drawing.Point(485, 9);
            this.lblHit.Name = "lblHit";
            this.lblHit.Size = new System.Drawing.Size(45, 24);
            this.lblHit.TabIndex = 0;
            this.lblHit.Text = "Hit:";
            this.lblHit.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblMiss
            // 
            this.lblMiss.AutoSize = true;
            this.lblMiss.BackColor = System.Drawing.Color.Transparent;
            this.lblMiss.CausesValidation = false;
            this.lblMiss.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMiss.Location = new System.Drawing.Point(485, 33);
            this.lblMiss.Name = "lblMiss";
            this.lblMiss.Size = new System.Drawing.Size(57, 24);
            this.lblMiss.TabIndex = 1;
            this.lblMiss.Text = "Miss:";
            // 
            // Smurf
            // 
            this.Smurf.BackColor = System.Drawing.Color.Transparent;
            this.Smurf.Image = ((System.Drawing.Image)(resources.GetObject("Smurf.Image")));
            this.Smurf.Location = new System.Drawing.Point(246, 186);
            this.Smurf.Name = "Smurf";
            this.Smurf.Size = new System.Drawing.Size(122, 100);
            this.Smurf.TabIndex = 2;
            this.Smurf.TabStop = false;
            this.Smurf.Click += new System.EventHandler(this.gotSmurf);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.moveSmurf);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SmashASmurf.Properties.Resources.ground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(591, 547);
            this.Controls.Add(this.Smurf);
            this.Controls.Add(this.lblMiss);
            this.Controls.Add(this.lblHit);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Smash A Smurf";
            ((System.ComponentModel.ISupportInitialize)(this.Smurf)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHit;
        private System.Windows.Forms.Label lblMiss;
        private System.Windows.Forms.PictureBox Smurf;
        private System.Windows.Forms.Timer timer1;
    }
}

