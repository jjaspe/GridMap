namespace GridMaps
{
    partial class GridMapsView
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
            this.frontButton = new System.Windows.Forms.Button();
            this.topButton = new System.Windows.Forms.Button();
            this.btnIsoFront = new System.Windows.Forms.Button();
            this.btnIso = new System.Windows.Forms.Button();
            this.btnGetNewMap = new System.Windows.Forms.Button();
            this.btnAdvance = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // frontButton
            // 
            this.frontButton.Location = new System.Drawing.Point(772, 29);
            this.frontButton.Name = "frontButton";
            this.frontButton.Size = new System.Drawing.Size(75, 23);
            this.frontButton.TabIndex = 28;
            this.frontButton.Text = "Front";
            this.frontButton.UseVisualStyleBackColor = true;
            this.frontButton.Click += new System.EventHandler(this.frontButton_Click);
            // 
            // topButton
            // 
            this.topButton.Location = new System.Drawing.Point(772, 87);
            this.topButton.Name = "topButton";
            this.topButton.Size = new System.Drawing.Size(75, 23);
            this.topButton.TabIndex = 26;
            this.topButton.Text = "Top";
            this.topButton.UseVisualStyleBackColor = true;
            this.topButton.Click += new System.EventHandler(this.topButton_Click);
            // 
            // btnIsoFront
            // 
            this.btnIsoFront.Location = new System.Drawing.Point(772, 58);
            this.btnIsoFront.Name = "btnIsoFront";
            this.btnIsoFront.Size = new System.Drawing.Size(75, 23);
            this.btnIsoFront.TabIndex = 31;
            this.btnIsoFront.Text = "Iso Front";
            this.btnIsoFront.UseVisualStyleBackColor = true;
            this.btnIsoFront.Click += new System.EventHandler(this.btnIsoFront_Click);
            // 
            // btnIso
            // 
            this.btnIso.Location = new System.Drawing.Point(772, 116);
            this.btnIso.Name = "btnIso";
            this.btnIso.Size = new System.Drawing.Size(75, 23);
            this.btnIso.TabIndex = 32;
            this.btnIso.Text = "Iso";
            this.btnIso.UseVisualStyleBackColor = true;
            this.btnIso.Click += new System.EventHandler(this.btnIso_Click);
            // 
            // btnGetNewMap
            // 
            this.btnGetNewMap.Location = new System.Drawing.Point(772, 223);
            this.btnGetNewMap.Name = "btnGetNewMap";
            this.btnGetNewMap.Size = new System.Drawing.Size(75, 23);
            this.btnGetNewMap.TabIndex = 33;
            this.btnGetNewMap.Text = "Get New Map";
            this.btnGetNewMap.UseVisualStyleBackColor = true;
            this.btnGetNewMap.Click += new System.EventHandler(this.btnGetNewMap_Click);
            // 
            // btnAdvance
            // 
            this.btnAdvance.Location = new System.Drawing.Point(772, 290);
            this.btnAdvance.Name = "btnAdvance";
            this.btnAdvance.Size = new System.Drawing.Size(75, 23);
            this.btnAdvance.TabIndex = 34;
            this.btnAdvance.Text = "Advance";
            this.btnAdvance.UseVisualStyleBackColor = true;
            this.btnAdvance.Click += new System.EventHandler(this.btnAdvance_Click);
            // 
            // GridMapsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 735);
            this.Controls.Add(this.btnAdvance);
            this.Controls.Add(this.btnGetNewMap);
            this.Controls.Add(this.btnIso);
            this.Controls.Add(this.btnIsoFront);
            this.Controls.Add(this.frontButton);
            this.Controls.Add(this.topButton);
            this.Name = "GridMapsView";
            this.Text = "Form1";
            this.Controls.SetChildIndex(this.simpleOpenGlView1, 0);
            this.Controls.SetChildIndex(this.topButton, 0);
            this.Controls.SetChildIndex(this.frontButton, 0);
            this.Controls.SetChildIndex(this.btnIsoFront, 0);
            this.Controls.SetChildIndex(this.btnIso, 0);
            this.Controls.SetChildIndex(this.btnGetNewMap, 0);
            this.Controls.SetChildIndex(this.btnAdvance, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button frontButton;
        private System.Windows.Forms.Button topButton;
        private System.Windows.Forms.Button btnIsoFront;
        private System.Windows.Forms.Button btnIso;
        private System.Windows.Forms.Button btnGetNewMap;
        private System.Windows.Forms.Button btnAdvance;
    }
}

