namespace lista_jugadores
{
    partial class UpdatePlayer
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.name_txb = new System.Windows.Forms.TextBox();
            this.lastname_txb = new System.Windows.Forms.TextBox();
            this.position_txb = new System.Windows.Forms.TextBox();
            this.update_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Actualizar Jugador";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellido:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Posicion:";
            // 
            // name_txb
            // 
            this.name_txb.Location = new System.Drawing.Point(154, 100);
            this.name_txb.Name = "name_txb";
            this.name_txb.Size = new System.Drawing.Size(226, 26);
            this.name_txb.TabIndex = 4;
            // 
            // lastname_txb
            // 
            this.lastname_txb.Location = new System.Drawing.Point(154, 147);
            this.lastname_txb.Name = "lastname_txb";
            this.lastname_txb.Size = new System.Drawing.Size(226, 26);
            this.lastname_txb.TabIndex = 5;
            // 
            // position_txb
            // 
            this.position_txb.Location = new System.Drawing.Point(154, 195);
            this.position_txb.Name = "position_txb";
            this.position_txb.Size = new System.Drawing.Size(226, 26);
            this.position_txb.TabIndex = 6;
            // 
            // update_btn
            // 
            this.update_btn.Location = new System.Drawing.Point(77, 245);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(303, 43);
            this.update_btn.TabIndex = 7;
            this.update_btn.Text = "Enviar";
            this.update_btn.UseVisualStyleBackColor = true;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.Location = new System.Drawing.Point(77, 302);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(303, 43);
            this.delete_btn.TabIndex = 9;
            this.delete_btn.Text = "Eliminar Jugador";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // UpdatePlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 368);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.position_txb);
            this.Controls.Add(this.lastname_txb);
            this.Controls.Add(this.name_txb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UpdatePlayer";
            this.Text = "UpdatePlayer";
            this.Load += new System.EventHandler(this.UpdatePlayer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox name_txb;
        private System.Windows.Forms.TextBox lastname_txb;
        private System.Windows.Forms.TextBox position_txb;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.Button delete_btn;
    }
}