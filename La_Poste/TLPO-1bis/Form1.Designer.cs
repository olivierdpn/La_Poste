using System;
using System.Runtime.InteropServices;

namespace TLPO_1bis
{
    partial class Form1
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
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.textbox_etape5 = new System.Windows.Forms.TextBox();
            this.textbox_etape4 = new System.Windows.Forms.TextBox();
            this.textbox_etape3 = new System.Windows.Forms.TextBox();
            this.textbox_etape2 = new System.Windows.Forms.TextBox();
            this.textbox_etape1 = new System.Windows.Forms.TextBox();
            this.etapes = new System.Windows.Forms.Label();
            this.erreur_origine = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_origin = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(12, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1104, 1167);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.Url = new System.Uri("", System.UriKind.Relative);
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.textbox_etape5);
            this.panel1.Controls.Add(this.textbox_etape4);
            this.panel1.Controls.Add(this.textbox_etape3);
            this.panel1.Controls.Add(this.textbox_etape2);
            this.panel1.Controls.Add(this.textbox_etape1);
            this.panel1.Controls.Add(this.etapes);
            this.panel1.Controls.Add(this.erreur_origine);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox_origin);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(1122, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(464, 1076);
            this.panel1.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft NeoGothic", 7.875F);
            this.button2.Location = new System.Drawing.Point(3, 806);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(461, 40);
            this.button2.TabIndex = 9;
            this.button2.Text = "Démarrer l\'optimisation...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textbox_etape5
            // 
            this.textbox_etape5.Location = new System.Drawing.Point(71, 574);
            this.textbox_etape5.Name = "textbox_etape5";
            this.textbox_etape5.Size = new System.Drawing.Size(335, 31);
            this.textbox_etape5.TabIndex = 8;
            this.textbox_etape5.TextChanged += new System.EventHandler(this.etape5_TextChanged);
            // 
            // textbox_etape4
            // 
            this.textbox_etape4.Location = new System.Drawing.Point(71, 491);
            this.textbox_etape4.Name = "textbox_etape4";
            this.textbox_etape4.Size = new System.Drawing.Size(335, 31);
            this.textbox_etape4.TabIndex = 7;
            this.textbox_etape4.TextChanged += new System.EventHandler(this.etape4_TextChanged);
            // 
            // textbox_etape3
            // 
            this.textbox_etape3.Location = new System.Drawing.Point(71, 421);
            this.textbox_etape3.Name = "textbox_etape3";
            this.textbox_etape3.Size = new System.Drawing.Size(335, 31);
            this.textbox_etape3.TabIndex = 6;
            this.textbox_etape3.TextChanged += new System.EventHandler(this.etape3_TextChanged);
            // 
            // textbox_etape2
            // 
            this.textbox_etape2.Location = new System.Drawing.Point(71, 352);
            this.textbox_etape2.Name = "textbox_etape2";
            this.textbox_etape2.Size = new System.Drawing.Size(335, 31);
            this.textbox_etape2.TabIndex = 5;
            this.textbox_etape2.TextChanged += new System.EventHandler(this.etape2_TextChanged);
            // 
            // textbox_etape1
            // 
            this.textbox_etape1.Location = new System.Drawing.Point(71, 284);
            this.textbox_etape1.Name = "textbox_etape1";
            this.textbox_etape1.Size = new System.Drawing.Size(335, 31);
            this.textbox_etape1.TabIndex = 2;
            this.textbox_etape1.TextChanged += new System.EventHandler(this.etape1_TextChanged);
            // 
            // etapes
            // 
            this.etapes.AutoSize = true;
            this.etapes.Font = new System.Drawing.Font("Microsoft NeoGothic", 9F);
            this.etapes.Location = new System.Drawing.Point(25, 234);
            this.etapes.Name = "etapes";
            this.etapes.Size = new System.Drawing.Size(96, 32);
            this.etapes.TabIndex = 4;
            this.etapes.Text = "Etapes :";
            // 
            // erreur_origine
            // 
            this.erreur_origine.AutoSize = true;
            this.erreur_origine.Location = new System.Drawing.Point(164, 178);
            this.erreur_origine.Name = "erreur_origine";
            this.erreur_origine.Size = new System.Drawing.Size(100, 25);
            this.erreur_origine.TabIndex = 3;
            this.erreur_origine.Text = "ERREUR";
            this.erreur_origine.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft NeoGothic", 9F);
            this.label1.Location = new System.Drawing.Point(26, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Origine :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox_origin
            // 
            this.textBox_origin.Location = new System.Drawing.Point(31, 128);
            this.textBox_origin.Name = "textBox_origin";
            this.textBox_origin.Size = new System.Drawing.Size(346, 31);
            this.textBox_origin.TabIndex = 1;
            this.textBox_origin.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft NeoGothic", 10F);
            this.button1.Location = new System.Drawing.Point(108, 701);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(247, 99);
            this.button1.TabIndex = 0;
            this.button1.Text = "VISUALISATION";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 355);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 424);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 25);
            this.label4.TabIndex = 17;
            this.label4.Text = "2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 491);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 25);
            this.label5.TabIndex = 18;
            this.label5.Text = "3";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 574);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 25);
            this.label6.TabIndex = 19;
            this.label6.Text = "4";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Font = new System.Drawing.Font("Microsoft NeoGothic", 12F);
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.Location = new System.Drawing.Point(1173, 0);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(370, 43);
            this.label7.TabIndex = 20;
            this.label7.Text = "PIX TLPO : GPS FACTEUR";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1598, 1096);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.webBrowser1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1624, 1167);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1624, 1167);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        
        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox_origin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label erreur_origine;
        private System.Windows.Forms.Label etapes;
        private System.Windows.Forms.TextBox textbox_etape5;
        private System.Windows.Forms.TextBox textbox_etape4;
        private System.Windows.Forms.TextBox textbox_etape3;
        private System.Windows.Forms.TextBox textbox_etape2;
        private System.Windows.Forms.TextBox textbox_etape1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
    }
}

