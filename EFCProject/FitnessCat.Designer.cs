namespace Sportify
{
    partial class FitnessCat
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.PictureBox CrossFit;
        private System.Windows.Forms.PictureBox FitGym;
        private System.Windows.Forms.Label labelCrossFit;
        private System.Windows.Forms.Label labelFitGym;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            CrossFit = new PictureBox();
            FitGym = new PictureBox();
            backButton = new Button();
            labelCrossFit = new Label();
            labelFitGym = new Label();
            ((System.ComponentModel.ISupportInitialize)CrossFit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)FitGym).BeginInit();
            SuspendLayout();
            // 
            // CrossFit
            // 
            CrossFit.Location = new Point(62, 78);
            CrossFit.Margin = new Padding(4, 5, 4, 5);
            CrossFit.Name = "CrossFit";
            CrossFit.Size = new Size(240, 234);
            CrossFit.SizeMode = PictureBoxSizeMode.StretchImage;
            CrossFit.TabIndex = 0;
            CrossFit.TabStop = false;
            CrossFit.Click += CrossFit_Click_Click;
            // 
            // FitGym
            // 
            FitGym.Location = new Point(422, 78);
            FitGym.Margin = new Padding(4, 5, 4, 5);
            FitGym.Name = "FitGym";
            FitGym.Size = new Size(227, 234);
            FitGym.SizeMode = PictureBoxSizeMode.StretchImage;
            FitGym.TabIndex = 2;
            FitGym.TabStop = false;
            // 
            // backButton
            // 
            backButton.Font = new Font("Bauhaus 93", 9F, FontStyle.Bold);
            backButton.ForeColor = Color.Lime;
            backButton.Location = new Point(25, 389);
            backButton.Margin = new Padding(4, 5, 4, 5);
            backButton.Name = "backButton";
            backButton.Size = new Size(94, 36);
            backButton.TabIndex = 1;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += button1_Click;
            // 
            // labelCrossFit
            // 
            labelCrossFit.Font = new Font("Bauhaus 93", 9F, FontStyle.Bold);
            labelCrossFit.ForeColor = Color.Lime;
            labelCrossFit.Location = new Point(95, 353);
            labelCrossFit.Margin = new Padding(4, 0, 4, 0);
            labelCrossFit.Name = "labelCrossFit";
            labelCrossFit.Size = new Size(125, 31);
            labelCrossFit.TabIndex = 3;
            labelCrossFit.Text = "CrossFit";
            labelCrossFit.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelFitGym
            // 
            labelFitGym.Font = new Font("Bauhaus 93", 9F, FontStyle.Bold);
            labelFitGym.ForeColor = Color.Lime;
            labelFitGym.Location = new Point(468, 353);
            labelFitGym.Margin = new Padding(4, 0, 4, 0);
            labelFitGym.Name = "labelFitGym";
            labelFitGym.Size = new Size(125, 31);
            labelFitGym.TabIndex = 4;
            labelFitGym.Text = "2FitGym";
            labelFitGym.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FitnessCat
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 26, 36);
            ClientSize = new Size(702, 469);
            Controls.Add(CrossFit);
            Controls.Add(FitGym);
            Controls.Add(labelCrossFit);
            Controls.Add(labelFitGym);
            Controls.Add(backButton);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FitnessCat";
            Text = "Fitness Categories";
            Load += FitnessCat_Load;
            ((System.ComponentModel.ISupportInitialize)CrossFit).EndInit();
            ((System.ComponentModel.ISupportInitialize)FitGym).EndInit();
            ResumeLayout(false);
        }
    }
}

