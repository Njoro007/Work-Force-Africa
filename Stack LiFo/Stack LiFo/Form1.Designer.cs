namespace Stack_LiFo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panelID1 = new System.Windows.Forms.Panel();
            this.panelID2 = new System.Windows.Forms.Panel();
            this.panelID3 = new System.Windows.Forms.Panel();
            this.panelID4 = new System.Windows.Forms.Panel();
            this.btnRandomStack = new System.Windows.Forms.Button();
            this.btnRemoveStackLiFo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Location = new System.Drawing.Point(280, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(214, 264);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stack Imagery";
            // 
            // panelID1
            // 
            this.panelID1.BackColor = System.Drawing.Color.White;
            this.panelID1.Location = new System.Drawing.Point(542, 127);
            this.panelID1.Name = "panelID1";
            this.panelID1.Size = new System.Drawing.Size(149, 41);
            this.panelID1.TabIndex = 3;
            // 
            // panelID2
            // 
            this.panelID2.BackColor = System.Drawing.Color.White;
            this.panelID2.Location = new System.Drawing.Point(543, 185);
            this.panelID2.Name = "panelID2";
            this.panelID2.Size = new System.Drawing.Size(149, 41);
            this.panelID2.TabIndex = 2;
            // 
            // panelID3
            // 
            this.panelID3.BackColor = System.Drawing.Color.White;
            this.panelID3.Location = new System.Drawing.Point(543, 245);
            this.panelID3.Name = "panelID3";
            this.panelID3.Size = new System.Drawing.Size(149, 41);
            this.panelID3.TabIndex = 1;
            // 
            // panelID4
            // 
            this.panelID4.BackColor = System.Drawing.Color.White;
            this.panelID4.Location = new System.Drawing.Point(543, 302);
            this.panelID4.Name = "panelID4";
            this.panelID4.Size = new System.Drawing.Size(149, 41);
            this.panelID4.TabIndex = 0;
            // 
            // btnRandomStack
            // 
            this.btnRandomStack.Location = new System.Drawing.Point(12, 51);
            this.btnRandomStack.Name = "btnRandomStack";
            this.btnRandomStack.Size = new System.Drawing.Size(211, 39);
            this.btnRandomStack.TabIndex = 1;
            this.btnRandomStack.Text = "Stack Random Colors";
            this.btnRandomStack.UseVisualStyleBackColor = true;
            this.btnRandomStack.Click += new System.EventHandler(this.btnRandomStack_Click);
            // 
            // btnRemoveStackLiFo
            // 
            this.btnRemoveStackLiFo.Location = new System.Drawing.Point(577, 51);
            this.btnRemoveStackLiFo.Name = "btnRemoveStackLiFo";
            this.btnRemoveStackLiFo.Size = new System.Drawing.Size(211, 39);
            this.btnRemoveStackLiFo.TabIndex = 2;
            this.btnRemoveStackLiFo.Text = "Remove Stack LiFo";
            this.btnRemoveStackLiFo.UseVisualStyleBackColor = true;
            this.btnRemoveStackLiFo.Click += new System.EventHandler(this.btnRemoveStackLiFo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelID1);
            this.Controls.Add(this.btnRemoveStackLiFo);
            this.Controls.Add(this.panelID2);
            this.Controls.Add(this.btnRandomStack);
            this.Controls.Add(this.panelID3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panelID4);
            this.Name = "Form1";
            this.Text = "Stack - Last In First Out";
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Panel panelID1;
        private Panel panelID2;
        private Panel panelID3;
        private Panel panelID4;
        private Button btnRandomStack;
        private Button btnRemoveStackLiFo;
    }
}