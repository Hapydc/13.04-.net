namespace Zadatak_04
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
            this.btnRed = new System.Windows.Forms.Button();
            this.btnGreen = new System.Windows.Forms.Button();
            this.btnBlue = new System.Windows.Forms.Button();
            this.txtEvent = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnRed
            // 
            this.btnRed.BackColor = System.Drawing.Color.Red;
            this.btnRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRed.ForeColor = System.Drawing.Color.White;
            this.btnRed.Location = new System.Drawing.Point(12, 12);
            this.btnRed.Name = "btnRed";
            this.btnRed.Size = new System.Drawing.Size(164, 163);
            this.btnRed.TabIndex = 0;
            this.btnRed.Text = "CRVENI";
            this.btnRed.UseVisualStyleBackColor = false;
            this.btnRed.Click += new System.EventHandler(this.btnRed_Click);
            this.btnRed.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnRed_MouseClick);
            this.btnRed.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnRed_MouseDown);
            // 
            // btnGreen
            // 
            this.btnGreen.BackColor = System.Drawing.Color.Green;
            this.btnGreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGreen.ForeColor = System.Drawing.Color.White;
            this.btnGreen.Location = new System.Drawing.Point(237, 12);
            this.btnGreen.Name = "btnGreen";
            this.btnGreen.Size = new System.Drawing.Size(185, 163);
            this.btnGreen.TabIndex = 1;
            this.btnGreen.Text = "ZELENI";
            this.btnGreen.UseVisualStyleBackColor = false;
            this.btnGreen.Click += new System.EventHandler(this.button2_Click);
            this.btnGreen.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnGreen_MouseClick);
            this.btnGreen.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnGreen_MouseDown);
            // 
            // btnBlue
            // 
            this.btnBlue.BackColor = System.Drawing.Color.Blue;
            this.btnBlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBlue.ForeColor = System.Drawing.Color.White;
            this.btnBlue.Location = new System.Drawing.Point(487, 12);
            this.btnBlue.Name = "btnBlue";
            this.btnBlue.Size = new System.Drawing.Size(183, 163);
            this.btnBlue.TabIndex = 2;
            this.btnBlue.Text = "PLAVI";
            this.btnBlue.UseVisualStyleBackColor = false;
            this.btnBlue.Click += new System.EventHandler(this.btnBlue_Click);
            this.btnBlue.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnBlue_MouseClick);
            this.btnBlue.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnBlue_MouseDown);
            // 
            // txtEvent
            // 
            this.txtEvent.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtEvent.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtEvent.Location = new System.Drawing.Point(0, 181);
            this.txtEvent.Multiline = true;
            this.txtEvent.Name = "txtEvent";
            this.txtEvent.ReadOnly = true;
            this.txtEvent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtEvent.Size = new System.Drawing.Size(682, 572);
            this.txtEvent.TabIndex = 3;
            this.txtEvent.TextChanged += new System.EventHandler(this.txtEvent_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 753);
            this.Controls.Add(this.txtEvent);
            this.Controls.Add(this.btnBlue);
            this.Controls.Add(this.btnGreen);
            this.Controls.Add(this.btnRed);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRed;
        private System.Windows.Forms.Button btnGreen;
        private System.Windows.Forms.Button btnBlue;
        private System.Windows.Forms.TextBox txtEvent;
    }
}

