namespace CsLauncher
{
    partial class DivideSaveForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if ( disposing && ( components != null ) )
            {
                components.Dispose( );
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent( )
        {
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.FromBox = new System.Windows.Forms.ListBox();
            this.NewBox = new System.Windows.Forms.ListBox();
            this.ToLeft = new System.Windows.Forms.Button();
            this.ToRight = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.252816F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 97.74718F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 294F));
            this.tableLayoutPanel2.Controls.Add(this.FromBox, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.NewBox, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.ToLeft, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.ToRight, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.SaveButton, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(932, 552);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // FromBox
            // 
            this.FromBox.AllowDrop = true;
            this.FromBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FromBox.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FromBox.FormattingEnabled = true;
            this.FromBox.ItemHeight = 16;
            this.FromBox.Location = new System.Drawing.Point(17, 4);
            this.FromBox.Name = "FromBox";
            this.FromBox.Size = new System.Drawing.Size(537, 462);
            this.FromBox.TabIndex = 0;
            // 
            // NewBox
            // 
            this.NewBox.AllowDrop = true;
            this.NewBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NewBox.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.NewBox.FormattingEnabled = true;
            this.NewBox.ItemHeight = 16;
            this.NewBox.Location = new System.Drawing.Point(639, 4);
            this.NewBox.Name = "NewBox";
            this.NewBox.Size = new System.Drawing.Size(289, 462);
            this.NewBox.TabIndex = 1;
            // 
            // ToLeft
            // 
            this.ToLeft.Location = new System.Drawing.Point(561, 512);
            this.ToLeft.Name = "ToLeft";
            this.ToLeft.Size = new System.Drawing.Size(71, 23);
            this.ToLeft.TabIndex = 3;
            this.ToLeft.Text = "<<";
            this.ToLeft.UseVisualStyleBackColor = true;
            // 
            // ToRight
            // 
            this.ToRight.Location = new System.Drawing.Point(561, 473);
            this.ToRight.Name = "ToRight";
            this.ToRight.Size = new System.Drawing.Size(71, 23);
            this.ToRight.TabIndex = 2;
            this.ToRight.Text = ">>";
            this.ToRight.UseVisualStyleBackColor = true;
            this.ToRight.Click += new System.EventHandler(this.ToRight_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(561, 4);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(71, 23);
            this.SaveButton.TabIndex = 4;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // DivideSaveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 552);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "DivideSaveForm";
            this.Text = "DivideSaveForm";
            this.Load += new System.EventHandler(this.DivideSaveForm_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ListBox FromBox;
        private System.Windows.Forms.ListBox NewBox;
        private System.Windows.Forms.Button ToLeft;
        private System.Windows.Forms.Button ToRight;
        private System.Windows.Forms.Button SaveButton;
    }
}