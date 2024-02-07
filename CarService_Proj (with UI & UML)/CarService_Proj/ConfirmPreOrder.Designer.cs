namespace CarService_Proj
{
    partial class ConfirmPreOrder
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
            this.components = new System.ComponentModel.Container();
            this.confirmed = new System.Windows.Forms.Label();
            this.confirm = new System.Windows.Forms.Label();
            this.preorderN = new System.Windows.Forms.Button();
            this.preorderY = new System.Windows.Forms.Button();
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.SuspendLayout();
            // 
            // confirmed
            // 
            this.confirmed.AutoSize = true;
            this.confirmed.Location = new System.Drawing.Point(177, 157);
            this.confirmed.Name = "confirmed";
            this.confirmed.Size = new System.Drawing.Size(0, 16);
            this.confirmed.TabIndex = 45;
            // 
            // confirm
            // 
            this.confirm.AutoSize = true;
            this.confirm.Font = new System.Drawing.Font("Rockwell Nova", 12F);
            this.confirm.Location = new System.Drawing.Point(100, 26);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(202, 27);
            this.confirm.TabIndex = 44;
            this.confirm.Text = "Confirm PreOrder?";
            // 
            // preorderN
            // 
            this.preorderN.Font = new System.Drawing.Font("Rockwell Nova", 8F, System.Drawing.FontStyle.Bold);
            this.preorderN.Location = new System.Drawing.Point(238, 91);
            this.preorderN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.preorderN.Name = "preorderN";
            this.preorderN.Size = new System.Drawing.Size(64, 27);
            this.preorderN.TabIndex = 43;
            this.preorderN.Text = "No";
            this.preorderN.UseVisualStyleBackColor = true;
            this.preorderN.Click += new System.EventHandler(this.preorderN_Click_1);
            // 
            // preorderY
            // 
            this.preorderY.Font = new System.Drawing.Font("Rockwell Nova", 8F, System.Drawing.FontStyle.Bold);
            this.preorderY.Location = new System.Drawing.Point(105, 91);
            this.preorderY.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.preorderY.Name = "preorderY";
            this.preorderY.Size = new System.Drawing.Size(64, 27);
            this.preorderY.TabIndex = 42;
            this.preorderY.Text = "Yes";
            this.preorderY.UseVisualStyleBackColor = true;
            this.preorderY.Click += new System.EventHandler(this.preorderY_Click);
            // 
            // kryptonPalette1
            // 
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Rounding = 12;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.ButtonEdgeInset = 10;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, -1, -1, -1);
            // 
            // ConfirmPreOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(402, 199);
            this.Controls.Add(this.confirmed);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.preorderN);
            this.Controls.Add(this.preorderY);
            this.Name = "ConfirmPreOrder";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConfirmPreorder";
            this.Load += new System.EventHandler(this.ConfirmPreOrder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label confirmed;
        private System.Windows.Forms.Label confirm;
        private System.Windows.Forms.Button preorderN;
        private System.Windows.Forms.Button preorderY;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
    }
}