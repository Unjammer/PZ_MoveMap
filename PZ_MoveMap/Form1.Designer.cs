namespace PZ_MoveMap
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
            this.btn_LoadMap = new System.Windows.Forms.Button();
            this.dgv_Cells = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_MapPath = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbx_Yold = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbx_Xold = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.num_Ynew = new System.Windows.Forms.NumericUpDown();
            this.num_Xnew = new System.Windows.Forms.NumericUpDown();
            this.tbx_TargetY = new System.Windows.Forms.TextBox();
            this.tbx_TargetX = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_MoveMap = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Cells)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Ynew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Xnew)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_LoadMap
            // 
            this.btn_LoadMap.Location = new System.Drawing.Point(12, 12);
            this.btn_LoadMap.Name = "btn_LoadMap";
            this.btn_LoadMap.Size = new System.Drawing.Size(41, 23);
            this.btn_LoadMap.TabIndex = 12;
            this.btn_LoadMap.Text = "...";
            this.btn_LoadMap.UseVisualStyleBackColor = true;
            this.btn_LoadMap.Click += new System.EventHandler(this.btn_LoadMap_Click);
            // 
            // dgv_Cells
            // 
            this.dgv_Cells.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgv_Cells.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Cells.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgv_Cells.Location = new System.Drawing.Point(12, 42);
            this.dgv_Cells.MultiSelect = false;
            this.dgv_Cells.Name = "dgv_Cells";
            this.dgv_Cells.ReadOnly = true;
            this.dgv_Cells.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Cells.Size = new System.Drawing.Size(226, 396);
            this.dgv_Cells.TabIndex = 13;
            this.dgv_Cells.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Cells_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "File";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "X";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 40;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Y";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 40;
            // 
            // lbl_MapPath
            // 
            this.lbl_MapPath.Location = new System.Drawing.Point(59, 17);
            this.lbl_MapPath.Name = "lbl_MapPath";
            this.lbl_MapPath.Size = new System.Drawing.Size(384, 13);
            this.lbl_MapPath.TabIndex = 14;
            this.lbl_MapPath.Text = "...";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbx_Yold);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbx_Xold);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(244, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(206, 55);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Actual Cell (Start)";
            // 
            // tbx_Yold
            // 
            this.tbx_Yold.Location = new System.Drawing.Point(128, 19);
            this.tbx_Yold.Name = "tbx_Yold";
            this.tbx_Yold.ReadOnly = true;
            this.tbx_Yold.Size = new System.Drawing.Size(62, 20);
            this.tbx_Yold.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Y:";
            // 
            // tbx_Xold
            // 
            this.tbx_Xold.Location = new System.Drawing.Point(33, 19);
            this.tbx_Xold.Name = "tbx_Xold";
            this.tbx_Xold.ReadOnly = true;
            this.tbx_Xold.Size = new System.Drawing.Size(62, 20);
            this.tbx_Xold.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "X:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.num_Ynew);
            this.groupBox2.Controls.Add(this.num_Xnew);
            this.groupBox2.Controls.Add(this.tbx_TargetY);
            this.groupBox2.Controls.Add(this.tbx_TargetX);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(244, 103);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(206, 82);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "New Cell (Start)";
            // 
            // num_Ynew
            // 
            this.num_Ynew.Location = new System.Drawing.Point(128, 19);
            this.num_Ynew.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.num_Ynew.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.num_Ynew.Name = "num_Ynew";
            this.num_Ynew.Size = new System.Drawing.Size(62, 20);
            this.num_Ynew.TabIndex = 10;
            this.num_Ynew.ValueChanged += new System.EventHandler(this.num_Ynew_ValueChanged);
            // 
            // num_Xnew
            // 
            this.num_Xnew.Location = new System.Drawing.Point(33, 19);
            this.num_Xnew.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.num_Xnew.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.num_Xnew.Name = "num_Xnew";
            this.num_Xnew.Size = new System.Drawing.Size(62, 20);
            this.num_Xnew.TabIndex = 9;
            this.num_Xnew.ValueChanged += new System.EventHandler(this.num_Xnew_ValueChanged);
            // 
            // tbx_TargetY
            // 
            this.tbx_TargetY.Location = new System.Drawing.Point(128, 45);
            this.tbx_TargetY.Name = "tbx_TargetY";
            this.tbx_TargetY.ReadOnly = true;
            this.tbx_TargetY.Size = new System.Drawing.Size(62, 20);
            this.tbx_TargetY.TabIndex = 8;
            // 
            // tbx_TargetX
            // 
            this.tbx_TargetX.Location = new System.Drawing.Point(33, 45);
            this.tbx_TargetX.Name = "tbx_TargetX";
            this.tbx_TargetX.ReadOnly = true;
            this.tbx_TargetX.Size = new System.Drawing.Size(62, 20);
            this.tbx_TargetX.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Y:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "X:";
            // 
            // btn_MoveMap
            // 
            this.btn_MoveMap.Location = new System.Drawing.Point(244, 191);
            this.btn_MoveMap.Name = "btn_MoveMap";
            this.btn_MoveMap.Size = new System.Drawing.Size(206, 47);
            this.btn_MoveMap.TabIndex = 17;
            this.btn_MoveMap.Text = "Move Cell(s)";
            this.btn_MoveMap.UseVisualStyleBackColor = true;
            this.btn_MoveMap.Click += new System.EventHandler(this.btn_MoveMap_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_MoveMap);
            this.Controls.Add(this.btn_LoadMap);
            this.Controls.Add(this.dgv_Cells);
            this.Controls.Add(this.lbl_MapPath);
            this.MinimumSize = new System.Drawing.Size(469, 489);
            this.Name = "Form1";
            this.Text = "PZ Map Mover";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Cells)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Ynew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Xnew)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_LoadMap;
        private System.Windows.Forms.DataGridView dgv_Cells;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Label lbl_MapPath;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbx_Yold;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbx_Xold;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown num_Ynew;
        private System.Windows.Forms.NumericUpDown num_Xnew;
        private System.Windows.Forms.TextBox tbx_TargetY;
        private System.Windows.Forms.TextBox tbx_TargetX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_MoveMap;
    }
}

