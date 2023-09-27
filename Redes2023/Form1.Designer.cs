
namespace Fernandez_Robin
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_ = new System.Windows.Forms.Button();
            this.lbl_Comando = new System.Windows.Forms.Label();
            this.lbl_Log = new System.Windows.Forms.Label();
            this.txt_Comando = new System.Windows.Forms.TextBox();
            this.txt_Log = new System.Windows.Forms.TextBox();
            this.btn_Cerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_
            // 
            this.btn_.Location = new System.Drawing.Point(153, 347);
            this.btn_.Name = "btn_";
            this.btn_.Size = new System.Drawing.Size(75, 23);
            this.btn_.TabIndex = 0;
            this.btn_.Text = "button1";
            this.btn_.UseVisualStyleBackColor = true;
            this.btn_.Click += new System.EventHandler(this.btn__Click);
            // 
            // lbl_Comando
            // 
            this.lbl_Comando.AutoSize = true;
            this.lbl_Comando.Location = new System.Drawing.Point(43, 53);
            this.lbl_Comando.Name = "lbl_Comando";
            this.lbl_Comando.Size = new System.Drawing.Size(60, 15);
            this.lbl_Comando.TabIndex = 1;
            this.lbl_Comando.Text = "Comando";
            // 
            // lbl_Log
            // 
            this.lbl_Log.AutoSize = true;
            this.lbl_Log.Location = new System.Drawing.Point(43, 120);
            this.lbl_Log.Name = "lbl_Log";
            this.lbl_Log.Size = new System.Drawing.Size(27, 15);
            this.lbl_Log.TabIndex = 2;
            this.lbl_Log.Text = "Log";
            // 
            // txt_Comando
            // 
            this.txt_Comando.Location = new System.Drawing.Point(128, 53);
            this.txt_Comando.Name = "txt_Comando";
            this.txt_Comando.Size = new System.Drawing.Size(568, 23);
            this.txt_Comando.TabIndex = 3;
            this.txt_Comando.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_Log
            // 
            this.txt_Log.Location = new System.Drawing.Point(128, 120);
            this.txt_Log.Multiline = true;
            this.txt_Log.Name = "txt_Log";
            this.txt_Log.Size = new System.Drawing.Size(568, 195);
            this.txt_Log.TabIndex = 4;
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.Location = new System.Drawing.Point(672, 347);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cerrar.TabIndex = 5;
            this.btn_Cerrar.Text = "Cerrar";
            this.btn_Cerrar.UseVisualStyleBackColor = true;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Cerrar);
            this.Controls.Add(this.txt_Log);
            this.Controls.Add(this.txt_Comando);
            this.Controls.Add(this.lbl_Log);
            this.Controls.Add(this.lbl_Comando);
            this.Controls.Add(this.btn_);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ServidorChatForm_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_;
        private System.Windows.Forms.Label lbl_Comando;
        private System.Windows.Forms.Label lbl_Log;
        private System.Windows.Forms.TextBox txt_Comando;
        private System.Windows.Forms.TextBox txt_Log;
        private System.Windows.Forms.Button btn_Cerrar;
    }
}

