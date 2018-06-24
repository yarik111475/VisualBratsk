namespace VisualBratsk.Forms {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.cmbxRoutes = new System.Windows.Forms.ComboBox();
            this.lblRoutes = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtDistance = new System.Windows.Forms.TextBox();
            this.lblDistance = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbxRoutes
            // 
            this.cmbxRoutes.FormattingEnabled = true;
            this.cmbxRoutes.Location = new System.Drawing.Point(12, 27);
            this.cmbxRoutes.Name = "cmbxRoutes";
            this.cmbxRoutes.Size = new System.Drawing.Size(218, 21);
            this.cmbxRoutes.TabIndex = 0;
            // 
            // lblRoutes
            // 
            this.lblRoutes.AutoSize = true;
            this.lblRoutes.Location = new System.Drawing.Point(12, 9);
            this.lblRoutes.Name = "lblRoutes";
            this.lblRoutes.Size = new System.Drawing.Size(52, 13);
            this.lblRoutes.TabIndex = 1;
            this.lblRoutes.Text = "Маршрут";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(102, 104);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(128, 20);
            this.txtPrice.TabIndex = 2;
            // 
            // txtDistance
            // 
            this.txtDistance.Location = new System.Drawing.Point(102, 66);
            this.txtDistance.Name = "txtDistance";
            this.txtDistance.Size = new System.Drawing.Size(128, 20);
            this.txtDistance.TabIndex = 3;
            // 
            // lblDistance
            // 
            this.lblDistance.AutoSize = true;
            this.lblDistance.Location = new System.Drawing.Point(12, 73);
            this.lblDistance.Name = "lblDistance";
            this.lblDistance.Size = new System.Drawing.Size(70, 13);
            this.lblDistance.TabIndex = 4;
            this.lblDistance.Text = "Расстояние:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(12, 111);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(36, 13);
            this.lblPrice.TabIndex = 5;
            this.lblPrice.Text = "Цена:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 149);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblDistance);
            this.Controls.Add(this.txtDistance);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblRoutes);
            this.Controls.Add(this.cmbxRoutes);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbxRoutes;
        private System.Windows.Forms.Label lblRoutes;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtDistance;
        private System.Windows.Forms.Label lblDistance;
        private System.Windows.Forms.Label lblPrice;
    }
}