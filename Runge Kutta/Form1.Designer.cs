namespace Runge_Kutta
{
    partial class Form1
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.functionTextBox = new MetroFramework.Controls.MetroTextBox();
            this.x0TextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.y0TextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.xTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.hTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.evaluateButton = new MetroFramework.Controls.MetroButton();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.resultLabel = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(42, 94);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(54, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Funcion";
            // 
            // functionTextBox
            // 
            this.functionTextBox.Location = new System.Drawing.Point(141, 94);
            this.functionTextBox.Name = "functionTextBox";
            this.functionTextBox.Size = new System.Drawing.Size(137, 23);
            this.functionTextBox.TabIndex = 1;
            this.functionTextBox.Text = "(x+y)/2";
            // 
            // x0TextBox
            // 
            this.x0TextBox.Location = new System.Drawing.Point(141, 137);
            this.x0TextBox.Name = "x0TextBox";
            this.x0TextBox.Size = new System.Drawing.Size(137, 23);
            this.x0TextBox.TabIndex = 3;
            this.x0TextBox.Text = "0";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(42, 137);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(22, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "x0";
            // 
            // y0TextBox
            // 
            this.y0TextBox.Location = new System.Drawing.Point(141, 181);
            this.y0TextBox.Name = "y0TextBox";
            this.y0TextBox.Size = new System.Drawing.Size(137, 23);
            this.y0TextBox.TabIndex = 5;
            this.y0TextBox.Text = "1";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(42, 181);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(22, 19);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "y0";
            // 
            // xTextBox
            // 
            this.xTextBox.Location = new System.Drawing.Point(141, 228);
            this.xTextBox.Name = "xTextBox";
            this.xTextBox.Size = new System.Drawing.Size(137, 23);
            this.xTextBox.TabIndex = 7;
            this.xTextBox.Text = "2";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(42, 228);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(15, 19);
            this.metroLabel4.TabIndex = 6;
            this.metroLabel4.Text = "x";
            // 
            // hTextBox
            // 
            this.hTextBox.Location = new System.Drawing.Point(141, 276);
            this.hTextBox.Name = "hTextBox";
            this.hTextBox.Size = new System.Drawing.Size(137, 23);
            this.hTextBox.TabIndex = 9;
            this.hTextBox.Text = "0.2";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(42, 276);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(16, 19);
            this.metroLabel5.TabIndex = 8;
            this.metroLabel5.Text = "h";
            // 
            // evaluateButton
            // 
            this.evaluateButton.Location = new System.Drawing.Point(174, 322);
            this.evaluateButton.Name = "evaluateButton";
            this.evaluateButton.Size = new System.Drawing.Size(75, 23);
            this.evaluateButton.TabIndex = 10;
            this.evaluateButton.Text = "Evaluar";
            this.evaluateButton.Click += new System.EventHandler(this.EvaluateButton_Click);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(450, 111);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(66, 19);
            this.metroLabel6.TabIndex = 11;
            this.metroLabel6.Text = "Resultado";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(450, 137);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(0, 0);
            this.resultLabel.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.evaluateButton);
            this.Controls.Add(this.hTextBox);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.xTextBox);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.y0TextBox);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.x0TextBox);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.functionTextBox);
            this.Controls.Add(this.metroLabel1);
            this.Name = "Form1";
            this.Text = "Kunge Rutta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox functionTextBox;
        private MetroFramework.Controls.MetroTextBox x0TextBox;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox y0TextBox;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox xTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox hTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroButton evaluateButton;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel resultLabel;
    }
}

