namespace BusTicketSystem.Forms
{
    partial class ManageRoutesForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOrigin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDistination = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbBusType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpDepartureTime = new System.Windows.Forms.DateTimePicker();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.btnAddRoute = new System.Windows.Forms.Button();
            this.btnEditRoute = new System.Windows.Forms.Button();
            this.btnDeleteRoute = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpDepartureTime);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmbBusType);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtPrice);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtDistination);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtOrigin);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(901, 129);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Routes Detail";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(18, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Origin:";
            // 
            // txtOrigin
            // 
            this.txtOrigin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOrigin.Location = new System.Drawing.Point(87, 23);
            this.txtOrigin.Multiline = true;
            this.txtOrigin.Name = "txtOrigin";
            this.txtOrigin.Size = new System.Drawing.Size(178, 29);
            this.txtOrigin.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(322, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Distination:";
            // 
            // txtDistination
            // 
            this.txtDistination.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDistination.Location = new System.Drawing.Point(400, 23);
            this.txtDistination.Multiline = true;
            this.txtDistination.Name = "txtDistination";
            this.txtDistination.Size = new System.Drawing.Size(178, 29);
            this.txtDistination.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(621, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Price:";
            // 
            // txtPrice
            // 
            this.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrice.Location = new System.Drawing.Point(684, 19);
            this.txtPrice.Multiline = true;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(178, 29);
            this.txtPrice.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(18, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Bus Type:";
            // 
            // cmbBusType
            // 
            this.cmbBusType.FormattingEnabled = true;
            this.cmbBusType.Location = new System.Drawing.Point(87, 83);
            this.cmbBusType.Name = "cmbBusType";
            this.cmbBusType.Size = new System.Drawing.Size(121, 21);
            this.cmbBusType.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(298, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Departure Time:";
            // 
            // dtpDepartureTime
            // 
            this.dtpDepartureTime.Location = new System.Drawing.Point(400, 83);
            this.dtpDepartureTime.Name = "dtpDepartureTime";
            this.dtpDepartureTime.Size = new System.Drawing.Size(200, 20);
            this.dtpDepartureTime.TabIndex = 9;
            // 
            // dgvList
            // 
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Location = new System.Drawing.Point(12, 213);
            this.dgvList.Name = "dgvList";
            this.dgvList.Size = new System.Drawing.Size(901, 200);
            this.dgvList.TabIndex = 1;
            // 
            // btnAddRoute
            // 
            this.btnAddRoute.Location = new System.Drawing.Point(12, 153);
            this.btnAddRoute.Name = "btnAddRoute";
            this.btnAddRoute.Size = new System.Drawing.Size(128, 49);
            this.btnAddRoute.TabIndex = 2;
            this.btnAddRoute.Text = "Add Route";
            this.btnAddRoute.UseVisualStyleBackColor = true;
            // 
            // btnEditRoute
            // 
            this.btnEditRoute.Location = new System.Drawing.Point(159, 153);
            this.btnEditRoute.Name = "btnEditRoute";
            this.btnEditRoute.Size = new System.Drawing.Size(128, 49);
            this.btnEditRoute.TabIndex = 3;
            this.btnEditRoute.Text = "Edit Route";
            this.btnEditRoute.UseVisualStyleBackColor = true;
            // 
            // btnDeleteRoute
            // 
            this.btnDeleteRoute.Location = new System.Drawing.Point(313, 153);
            this.btnDeleteRoute.Name = "btnDeleteRoute";
            this.btnDeleteRoute.Size = new System.Drawing.Size(128, 49);
            this.btnDeleteRoute.TabIndex = 4;
            this.btnDeleteRoute.Text = "Delete Route";
            this.btnDeleteRoute.UseVisualStyleBackColor = true;
            // 
            // ManageRoutesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(130)))));
            this.ClientSize = new System.Drawing.Size(925, 425);
            this.Controls.Add(this.btnDeleteRoute);
            this.Controls.Add(this.btnEditRoute);
            this.Controls.Add(this.btnAddRoute);
            this.Controls.Add(this.dgvList);
            this.Controls.Add(this.groupBox1);
            this.Name = "ManageRoutesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageRoutesForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDistination;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOrigin;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.DateTimePicker dtpDepartureTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbBusType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.Button btnAddRoute;
        private System.Windows.Forms.Button btnEditRoute;
        private System.Windows.Forms.Button btnDeleteRoute;
    }
}