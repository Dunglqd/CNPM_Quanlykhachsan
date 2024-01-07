namespace Restaurant_Management
{
    partial class MANAGE_ROOM
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
            this.btnCLEAR = new System.Windows.Forms.Button();
            this.btnDEL = new System.Windows.Forms.Button();
            this.btnEDIT = new System.Windows.Forms.Button();
            this.btnADD = new System.Windows.Forms.Button();
            this.dtvContent = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.btnPH = new System.Windows.Forms.Button();
            this.btnLP = new System.Windows.Forms.Button();
            this.btnTT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtvContent)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCLEAR
            // 
            this.btnCLEAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCLEAR.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCLEAR.ForeColor = System.Drawing.Color.Gold;
            this.btnCLEAR.Location = new System.Drawing.Point(217, 510);
            this.btnCLEAR.Name = "btnCLEAR";
            this.btnCLEAR.Size = new System.Drawing.Size(154, 42);
            this.btnCLEAR.TabIndex = 67;
            this.btnCLEAR.Text = "Bỏ chọn";
            this.btnCLEAR.UseVisualStyleBackColor = true;
            this.btnCLEAR.Click += new System.EventHandler(this.btnCLEAR_Click);
            // 
            // btnDEL
            // 
            this.btnDEL.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(146)))), ((int)(((byte)(89)))));
            this.btnDEL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDEL.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDEL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(146)))), ((int)(((byte)(89)))));
            this.btnDEL.Location = new System.Drawing.Point(12, 438);
            this.btnDEL.Name = "btnDEL";
            this.btnDEL.Size = new System.Drawing.Size(154, 42);
            this.btnDEL.TabIndex = 64;
            this.btnDEL.Text = "XÓA";
            this.btnDEL.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDEL.UseVisualStyleBackColor = false;
            this.btnDEL.Click += new System.EventHandler(this.btnDEL_Click);
            // 
            // btnEDIT
            // 
            this.btnEDIT.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(190)))), ((int)(((byte)(240)))));
            this.btnEDIT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEDIT.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEDIT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(190)))), ((int)(((byte)(240)))));
            this.btnEDIT.Location = new System.Drawing.Point(217, 438);
            this.btnEDIT.Name = "btnEDIT";
            this.btnEDIT.Size = new System.Drawing.Size(154, 42);
            this.btnEDIT.TabIndex = 65;
            this.btnEDIT.Text = "SỬA";
            this.btnEDIT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEDIT.UseVisualStyleBackColor = false;
            this.btnEDIT.Click += new System.EventHandler(this.btnEDIT_Click);
            // 
            // btnADD
            // 
            this.btnADD.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(99)))), ((int)(((byte)(135)))));
            this.btnADD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnADD.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnADD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(99)))), ((int)(((byte)(135)))));
            this.btnADD.Location = new System.Drawing.Point(12, 510);
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(154, 42);
            this.btnADD.TabIndex = 66;
            this.btnADD.Text = "THÊM";
            this.btnADD.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnADD.UseVisualStyleBackColor = false;
            this.btnADD.Click += new System.EventHandler(this.btnADD_Click);
            // 
            // dtvContent
            // 
            this.dtvContent.AllowUserToAddRows = false;
            this.dtvContent.AllowUserToDeleteRows = false;
            this.dtvContent.AllowUserToOrderColumns = true;
            this.dtvContent.AllowUserToResizeColumns = false;
            this.dtvContent.AllowUserToResizeRows = false;
            this.dtvContent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtvContent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dtvContent.BackgroundColor = System.Drawing.Color.White;
            this.dtvContent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtvContent.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtvContent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvContent.Location = new System.Drawing.Point(403, 72);
            this.dtvContent.MultiSelect = false;
            this.dtvContent.Name = "dtvContent";
            this.dtvContent.ReadOnly = true;
            this.dtvContent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtvContent.Size = new System.Drawing.Size(332, 480);
            this.dtvContent.TabIndex = 63;
            this.dtvContent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtvContent_CellClick);
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.LawnGreen;
            this.button4.Location = new System.Drawing.Point(21, 328);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(145, 26);
            this.button4.TabIndex = 62;
            this.button4.Text = "TÌM KIẾM";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            this.button15.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(87)))), ((int)(((byte)(255)))));
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button15.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(87)))), ((int)(((byte)(255)))));
            this.button15.Location = new System.Drawing.Point(21, 21);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(154, 42);
            this.button15.TabIndex = 60;
            this.button15.Text = "BACK";
            this.button15.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // btnPH
            // 
            this.btnPH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPH.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPH.ForeColor = System.Drawing.Color.LawnGreen;
            this.btnPH.Location = new System.Drawing.Point(21, 143);
            this.btnPH.Name = "btnPH";
            this.btnPH.Size = new System.Drawing.Size(145, 45);
            this.btnPH.TabIndex = 68;
            this.btnPH.Text = "PHÒNG";
            this.btnPH.UseVisualStyleBackColor = true;
            this.btnPH.Click += new System.EventHandler(this.btnPH_Click);
            // 
            // btnLP
            // 
            this.btnLP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLP.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLP.ForeColor = System.Drawing.Color.LawnGreen;
            this.btnLP.Location = new System.Drawing.Point(21, 194);
            this.btnLP.Name = "btnLP";
            this.btnLP.Size = new System.Drawing.Size(145, 45);
            this.btnLP.TabIndex = 69;
            this.btnLP.Text = "LOẠI PHÒNG";
            this.btnLP.UseVisualStyleBackColor = true;
            this.btnLP.Click += new System.EventHandler(this.btnLP_Click);
            // 
            // btnTT
            // 
            this.btnTT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTT.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTT.ForeColor = System.Drawing.Color.LawnGreen;
            this.btnTT.Location = new System.Drawing.Point(21, 250);
            this.btnTT.Name = "btnTT";
            this.btnTT.Size = new System.Drawing.Size(145, 45);
            this.btnTT.TabIndex = 70;
            this.btnTT.Text = "TÌNH TRẠNG";
            this.btnTT.UseVisualStyleBackColor = true;
            this.btnTT.Click += new System.EventHandler(this.btnTT_Click);
            // 
            // MANAGE_ROOM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(772, 598);
            this.Controls.Add(this.btnTT);
            this.Controls.Add(this.btnLP);
            this.Controls.Add(this.btnPH);
            this.Controls.Add(this.btnCLEAR);
            this.Controls.Add(this.btnDEL);
            this.Controls.Add(this.btnEDIT);
            this.Controls.Add(this.btnADD);
            this.Controls.Add(this.dtvContent);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button15);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MANAGE_ROOM";
            this.Text = "MANAGE___ROOM";
            this.Shown += new System.EventHandler(this.MANAGE_ROOM_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dtvContent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCLEAR;
        private System.Windows.Forms.Button btnDEL;
        private System.Windows.Forms.Button btnEDIT;
        private System.Windows.Forms.Button btnADD;
        private System.Windows.Forms.DataGridView dtvContent;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button btnPH;
        private System.Windows.Forms.Button btnLP;
        private System.Windows.Forms.Button btnTT;
    }
}