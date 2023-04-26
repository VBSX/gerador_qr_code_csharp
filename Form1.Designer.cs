namespace gerador_qr_code
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_gerar_qr_code = new System.Windows.Forms.Button();
            this.label_message_to_user = new System.Windows.Forms.Label();
            this.textBox_user_input = new System.Windows.Forms.TextBox();
            this.pictureBox_for_qr_code = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_for_qr_code)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_gerar_qr_code
            // 
            this.button_gerar_qr_code.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_gerar_qr_code.Location = new System.Drawing.Point(15, 100);
            this.button_gerar_qr_code.MinimumSize = new System.Drawing.Size(488, 40);
            this.button_gerar_qr_code.Name = "button_gerar_qr_code";
            this.button_gerar_qr_code.Size = new System.Drawing.Size(488, 50);
            this.button_gerar_qr_code.TabIndex = 0;
            this.button_gerar_qr_code.Text = "Gerar QrCode";
            this.button_gerar_qr_code.UseVisualStyleBackColor = true;
            this.button_gerar_qr_code.Click += new System.EventHandler(this.button_gerar_qr_code_Click);
            // 
            // label_message_to_user
            // 
            this.label_message_to_user.AutoSize = true;
            this.label_message_to_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_message_to_user.Location = new System.Drawing.Point(15, 11);
            this.label_message_to_user.MinimumSize = new System.Drawing.Size(488, 40);
            this.label_message_to_user.Name = "label_message_to_user";
            this.label_message_to_user.Size = new System.Drawing.Size(488, 40);
            this.label_message_to_user.TabIndex = 1;
            this.label_message_to_user.Text = "Coloque o texto que sera convertido para QrCode";
            this.label_message_to_user.Click += new System.EventHandler(this.label_message_to_user_Click);
            // 
            // textBox_user_input
            // 
            this.textBox_user_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_user_input.Location = new System.Drawing.Point(15, 54);
            this.textBox_user_input.MinimumSize = new System.Drawing.Size(488, 40);
            this.textBox_user_input.Name = "textBox_user_input";
            this.textBox_user_input.Size = new System.Drawing.Size(488, 31);
            this.textBox_user_input.TabIndex = 2;
            this.textBox_user_input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox_for_qr_code
            // 
            this.pictureBox_for_qr_code.Location = new System.Drawing.Point(105, 156);
            this.pictureBox_for_qr_code.MinimumSize = new System.Drawing.Size(200, 200);
            this.pictureBox_for_qr_code.Name = "pictureBox_for_qr_code";
            this.pictureBox_for_qr_code.Size = new System.Drawing.Size(300, 200);
            this.pictureBox_for_qr_code.TabIndex = 3;
            this.pictureBox_for_qr_code.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_gerar_qr_code);
            this.panel1.Controls.Add(this.pictureBox_for_qr_code);
            this.panel1.Controls.Add(this.label_message_to_user);
            this.panel1.Controls.Add(this.textBox_user_input);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(517, 426);
            this.panel1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_for_qr_code)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_gerar_qr_code;
        private System.Windows.Forms.Label label_message_to_user;
        private System.Windows.Forms.TextBox textBox_user_input;
        private System.Windows.Forms.PictureBox pictureBox_for_qr_code;
        private System.Windows.Forms.Panel panel1;
    }
}

