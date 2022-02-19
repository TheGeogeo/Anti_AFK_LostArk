
namespace Anti_Deco_LostArk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.leftRB = new System.Windows.Forms.RadioButton();
            this.rightRB = new System.Windows.Forms.RadioButton();
            this.logTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.onOffL = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.timeActionNum = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.timeActionNum)).BeginInit();
            this.SuspendLayout();
            // 
            // leftRB
            // 
            this.leftRB.AutoSize = true;
            this.leftRB.Checked = true;
            this.leftRB.Location = new System.Drawing.Point(146, 12);
            this.leftRB.Name = "leftRB";
            this.leftRB.Size = new System.Drawing.Size(68, 17);
            this.leftRB.TabIndex = 0;
            this.leftRB.TabStop = true;
            this.leftRB.Text = "Left click";
            this.leftRB.UseVisualStyleBackColor = true;
            // 
            // rightRB
            // 
            this.rightRB.AutoSize = true;
            this.rightRB.Location = new System.Drawing.Point(220, 12);
            this.rightRB.Name = "rightRB";
            this.rightRB.Size = new System.Drawing.Size(75, 17);
            this.rightRB.TabIndex = 1;
            this.rightRB.Text = "Right click";
            this.rightRB.UseVisualStyleBackColor = true;
            // 
            // logTB
            // 
            this.logTB.AcceptsReturn = true;
            this.logTB.Location = new System.Drawing.Point(12, 35);
            this.logTB.Multiline = true;
            this.logTB.Name = "logTB";
            this.logTB.ReadOnly = true;
            this.logTB.Size = new System.Drawing.Size(283, 199);
            this.logTB.TabIndex = 2;
            this.logTB.WordWrap = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "F8 :";
            // 
            // onOffL
            // 
            this.onOffL.AutoSize = true;
            this.onOffL.ForeColor = System.Drawing.Color.Red;
            this.onOffL.Location = new System.Drawing.Point(43, 14);
            this.onOffL.Name = "onOffL";
            this.onOffL.Size = new System.Drawing.Size(27, 13);
            this.onOffL.TabIndex = 4;
            this.onOffL.Text = "OFF";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(95, 14);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(45, 17);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Top";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Time between action (sec) :";
            // 
            // timeActionNum
            // 
            this.timeActionNum.Location = new System.Drawing.Point(156, 242);
            this.timeActionNum.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.timeActionNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.timeActionNum.Name = "timeActionNum";
            this.timeActionNum.Size = new System.Drawing.Size(65, 20);
            this.timeActionNum.TabIndex = 7;
            this.timeActionNum.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 266);
            this.Controls.Add(this.timeActionNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.onOffL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logTB);
            this.Controls.Add(this.rightRB);
            this.Controls.Add(this.leftRB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Anti afk by TheGeogeo";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.timeActionNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton leftRB;
        private System.Windows.Forms.RadioButton rightRB;
        private System.Windows.Forms.TextBox logTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label onOffL;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown timeActionNum;
    }
}

