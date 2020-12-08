
namespace WindowsFormsApp8
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.siticoneButton1 = new Siticone.UI.WinForms.SiticoneButton();
            this.siticoneMaterialTextBox1 = new Siticone.UI.WinForms.SiticoneMaterialTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.screenColorPicker1 = new Cyotek.Windows.Forms.ScreenColorPicker();
            this.SuspendLayout();
            // 
            // siticoneButton1
            // 
            this.siticoneButton1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneButton1.BorderRadius = 5;
            this.siticoneButton1.CheckedState.Parent = this.siticoneButton1;
            this.siticoneButton1.CustomImages.Parent = this.siticoneButton1;
            this.siticoneButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.siticoneButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneButton1.ForeColor = System.Drawing.Color.White;
            this.siticoneButton1.HoveredState.Parent = this.siticoneButton1;
            this.siticoneButton1.Location = new System.Drawing.Point(12, 173);
            this.siticoneButton1.Name = "siticoneButton1";
            this.siticoneButton1.ShadowDecoration.Parent = this.siticoneButton1;
            this.siticoneButton1.Size = new System.Drawing.Size(184, 30);
            this.siticoneButton1.TabIndex = 1;
            this.siticoneButton1.Text = "Start";
            this.siticoneButton1.Click += new System.EventHandler(this.siticoneButton1_Click);
            // 
            // siticoneMaterialTextBox1
            // 
            this.siticoneMaterialTextBox1.Animated = false;
            this.siticoneMaterialTextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(100)))), ((int)(((byte)(140)))));
            this.siticoneMaterialTextBox1.BorderThickness = 3;
            this.siticoneMaterialTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.siticoneMaterialTextBox1.DefaultText = "";
            this.siticoneMaterialTextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.siticoneMaterialTextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.siticoneMaterialTextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneMaterialTextBox1.DisabledState.Parent = this.siticoneMaterialTextBox1;
            this.siticoneMaterialTextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneMaterialTextBox1.FillColor = System.Drawing.Color.WhiteSmoke;
            this.siticoneMaterialTextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneMaterialTextBox1.FocusedState.Parent = this.siticoneMaterialTextBox1;
            this.siticoneMaterialTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.siticoneMaterialTextBox1.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.siticoneMaterialTextBox1.HoveredState.Parent = this.siticoneMaterialTextBox1;
            this.siticoneMaterialTextBox1.Location = new System.Drawing.Point(12, 44);
            this.siticoneMaterialTextBox1.Name = "siticoneMaterialTextBox1";
            this.siticoneMaterialTextBox1.PasswordChar = '\0';
            this.siticoneMaterialTextBox1.PlaceholderText = "";
            this.siticoneMaterialTextBox1.SelectedText = "";
            this.siticoneMaterialTextBox1.ShadowDecoration.Parent = this.siticoneMaterialTextBox1;
            this.siticoneMaterialTextBox1.Size = new System.Drawing.Size(184, 36);
            this.siticoneMaterialTextBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Window Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Target Color";
            // 
            // screenColorPicker1
            // 
            this.screenColorPicker1.Color = System.Drawing.Color.Empty;
            this.screenColorPicker1.ForeColor = System.Drawing.Color.White;
            this.screenColorPicker1.Location = new System.Drawing.Point(12, 120);
            this.screenColorPicker1.Name = "screenColorPicker1";
            this.screenColorPicker1.ShowGrid = false;
            this.screenColorPicker1.Size = new System.Drawing.Size(184, 47);
            this.screenColorPicker1.Text = "Color Picker (click & drag)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(208, 218);
            this.Controls.Add(this.screenColorPicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.siticoneMaterialTextBox1);
            this.Controls.Add(this.siticoneButton1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Siticone.UI.WinForms.SiticoneButton siticoneButton1;
        private Siticone.UI.WinForms.SiticoneMaterialTextBox siticoneMaterialTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Cyotek.Windows.Forms.ScreenColorPicker screenColorPicker1;
    }
}

