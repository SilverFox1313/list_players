namespace lista_jugadores
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
            this.label1 = new System.Windows.Forms.Label();
            this.list_players = new System.Windows.Forms.DataGridView();
            this.name_txb = new System.Windows.Forms.TextBox();
            this.lastname_txb = new System.Windows.Forms.TextBox();
            this.position_txb = new System.Windows.Forms.TextBox();
            this.add_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.list_players)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(109, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(574, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Los Lobos De Olimpo";
            // 
            // list_players
            // 
            this.list_players.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.list_players.Location = new System.Drawing.Point(36, 169);
            this.list_players.Name = "list_players";
            this.list_players.RowHeadersWidth = 62;
            this.list_players.RowTemplate.Height = 28;
            this.list_players.Size = new System.Drawing.Size(727, 242);
            this.list_players.TabIndex = 2;
            this.list_players.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.list_players_CellMouseDoubleClick);
            // 
            // name_txb
            // 
            this.name_txb.Location = new System.Drawing.Point(57, 127);
            this.name_txb.Name = "name_txb";
            this.name_txb.Size = new System.Drawing.Size(174, 26);
            this.name_txb.TabIndex = 3;
            // 
            // lastname_txb
            // 
            this.lastname_txb.Location = new System.Drawing.Point(246, 127);
            this.lastname_txb.Name = "lastname_txb";
            this.lastname_txb.Size = new System.Drawing.Size(174, 26);
            this.lastname_txb.TabIndex = 4;
            // 
            // position_txb
            // 
            this.position_txb.Location = new System.Drawing.Point(437, 127);
            this.position_txb.Name = "position_txb";
            this.position_txb.Size = new System.Drawing.Size(174, 26);
            this.position_txb.TabIndex = 5;
            // 
            // add_btn
            // 
            this.add_btn.BackColor = System.Drawing.SystemColors.Window;
            this.add_btn.Location = new System.Drawing.Point(617, 123);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(120, 36);
            this.add_btn.TabIndex = 6;
            this.add_btn.Text = "Agregar";
            this.add_btn.UseVisualStyleBackColor = false;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(491, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Posicion:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(296, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Apellido:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 466);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.position_txb);
            this.Controls.Add(this.lastname_txb);
            this.Controls.Add(this.name_txb);
            this.Controls.Add(this.list_players);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.list_players)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView list_players;
        private System.Windows.Forms.TextBox name_txb;
        private System.Windows.Forms.TextBox lastname_txb;
        private System.Windows.Forms.TextBox position_txb;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

