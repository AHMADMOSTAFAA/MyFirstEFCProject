using System;
using System.Drawing;
using System.Windows.Forms;

namespace Sportify
{
    partial class SportCategory
    {
        private System.ComponentModel.IContainer components = null;
        private PictureBox PowerLifting;
        private PictureBox SelfDefence;
        private PictureBox Atheletics;
        private PictureBox Fitness;
        private Label label4;
        private Label label5;

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
            PowerLifting = new PictureBox();
            SelfDefence = new PictureBox();
            Atheletics = new PictureBox();
            Fitness = new PictureBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label1 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)PowerLifting).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SelfDefence).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Atheletics).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Fitness).BeginInit();
            SuspendLayout();
            // 
            // PowerLifting
            // 
            PowerLifting.Location = new Point(13, 47);
            PowerLifting.Margin = new Padding(4, 5, 4, 5);
            PowerLifting.Name = "PowerLifting";
            PowerLifting.Size = new Size(165, 156);
            PowerLifting.SizeMode = PictureBoxSizeMode.StretchImage;
            PowerLifting.TabIndex = 0;
            PowerLifting.TabStop = false;
            // 
            // SelfDefence
            // 
            SelfDefence.Location = new Point(227, 47);
            SelfDefence.Margin = new Padding(4, 5, 4, 5);
            SelfDefence.Name = "SelfDefence";
            SelfDefence.Size = new Size(200, 156);
            SelfDefence.SizeMode = PictureBoxSizeMode.StretchImage;
            SelfDefence.TabIndex = 1;
            SelfDefence.TabStop = false;
            // 
            // Atheletics
            // 
            Atheletics.Location = new Point(490, 47);
            Atheletics.Margin = new Padding(4, 5, 4, 5);
            Atheletics.Name = "Atheletics";
            Atheletics.Size = new Size(194, 156);
            Atheletics.SizeMode = PictureBoxSizeMode.StretchImage;
            Atheletics.TabIndex = 2;
            Atheletics.TabStop = false;
            // 
            // Fitness
            // 
            Fitness.Location = new Point(761, 47);
            Fitness.Margin = new Padding(4, 5, 4, 5);
            Fitness.Name = "Fitness";
            Fitness.Size = new Size(187, 156);
            Fitness.SizeMode = PictureBoxSizeMode.StretchImage;
            Fitness.TabIndex = 3;
            Fitness.TabStop = false;
            Fitness.Click += Fitness_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bauhaus 93", 9F, FontStyle.Bold);
            label4.ForeColor = Color.LimeGreen;
            label4.Location = new Point(810, 277);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 7;
            label4.Text = "Fitness";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bauhaus 93", 9F, FontStyle.Bold);
            label5.ForeColor = Color.LimeGreen;
            label5.Location = new Point(392, 390);
            label5.Name = "label5";
            label5.Size = new Size(240, 20);
            label5.TabIndex = 8;
            label5.Text = "More to Come Stay Tuned";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Bauhaus 93", 9F, FontStyle.Bold);
            label6.ForeColor = Color.LimeGreen;
            label6.Location = new Point(533, 277);
            label6.Name = "label6";
            label6.Size = new Size(99, 20);
            label6.TabIndex = 9;
            label6.Text = "Atheletics";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Bauhaus 93", 9F, FontStyle.Bold);
            label7.ForeColor = Color.LimeGreen;
            label7.Location = new Point(40, 277);
            label7.Name = "label7";
            label7.Size = new Size(125, 20);
            label7.TabIndex = 10;
            label7.Text = "Power Lifting";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bauhaus 93", 9F, FontStyle.Bold);
            label1.ForeColor = Color.LimeGreen;
            label1.Location = new Point(258, 277);
            label1.Name = "label1";
            label1.Size = new Size(123, 20);
            label1.TabIndex = 11;
            label1.Text = "Self Defence";
            // 
            // button1
            // 
            button1.Font = new Font("Bauhaus 93", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.LawnGreen;
            button1.Location = new Point(53, 390);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 12;
            button1.Text = "<<";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // SportCategory
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 26, 36);
            ClientSize = new Size(1000, 703);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(PowerLifting);
            Controls.Add(SelfDefence);
            Controls.Add(Atheletics);
            Controls.Add(Fitness);
            Margin = new Padding(4, 5, 4, 5);
            Name = "SportCategory";
            Text = "Sport Category";
            Load += SportCategory_Load;
            ((System.ComponentModel.ISupportInitialize)PowerLifting).EndInit();
            ((System.ComponentModel.ISupportInitialize)SelfDefence).EndInit();
            ((System.ComponentModel.ISupportInitialize)Atheletics).EndInit();
            ((System.ComponentModel.ISupportInitialize)Fitness).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label6;
        private Label label7;
        private Label label1;
        private Button button1;
    }
}
