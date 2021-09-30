
namespace QLSV_HTC
{
    partial class ChooseServerForm
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPowerOff = new FontAwesome.Sharp.IconButton();
            this.btnDoorOpen = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "CÔNG NGHỆ THÔNG TIN",
            "VIỄN THÔNG",
            "HỌC PHÍ"});
            this.comboBox1.Location = new System.Drawing.Point(145, 32);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(230, 29);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Server :";
            // 
            // btnPowerOff
            // 
            this.btnPowerOff.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnPowerOff.AllowDrop = true;
            this.btnPowerOff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPowerOff.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnPowerOff.FlatAppearance.BorderSize = 0;
            this.btnPowerOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPowerOff.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            this.btnPowerOff.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(0)))), ((int)(((byte)(41)))));
            this.btnPowerOff.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPowerOff.IconSize = 40;
            this.btnPowerOff.Location = new System.Drawing.Point(25, 90);
            this.btnPowerOff.Name = "btnPowerOff";
            this.btnPowerOff.Size = new System.Drawing.Size(40, 40);
            this.btnPowerOff.TabIndex = 3;
            this.btnPowerOff.TabStop = false;
            this.btnPowerOff.UseVisualStyleBackColor = true;
            this.btnPowerOff.Click += new System.EventHandler(this.btnPowerOff_Click);
            // 
            // btnDoorOpen
            // 
            this.btnDoorOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoorOpen.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            this.btnDoorOpen.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(180)))), ((int)(((byte)(229)))));
            this.btnDoorOpen.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDoorOpen.IconSize = 40;
            this.btnDoorOpen.Location = new System.Drawing.Point(150, 90);
            this.btnDoorOpen.Name = "btnDoorOpen";
            this.btnDoorOpen.Size = new System.Drawing.Size(100, 40);
            this.btnDoorOpen.TabIndex = 2;
            this.btnDoorOpen.UseVisualStyleBackColor = true;
            this.btnDoorOpen.Click += new System.EventHandler(this.btnDoorOpen_Click);
            // 
            // ChooseServerForm
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 150);
            this.Controls.Add(this.btnPowerOff);
            this.Controls.Add(this.btnDoorOpen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChooseServerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnDoorOpen;
        private FontAwesome.Sharp.IconButton btnPowerOff;
    }
}