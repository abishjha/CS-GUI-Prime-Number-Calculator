namespace ajha_lab13
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
               this.label1 = new System.Windows.Forms.Label();
               this.label2 = new System.Windows.Forms.Label();
               this.endPointNumber = new System.Windows.Forms.TextBox();
               this.calculateButton = new System.Windows.Forms.Button();
               this.cancelButton = new System.Windows.Forms.Button();
               this.resultListBox = new System.Windows.Forms.ListBox();
               this.SuspendLayout();
               // 
               // label1
               // 
               this.label1.AutoSize = true;
               this.label1.Location = new System.Drawing.Point(13, 13);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(56, 17);
               this.label1.TabIndex = 0;
               this.label1.Text = "from:  2";
               // 
               // label2
               // 
               this.label2.AutoSize = true;
               this.label2.Location = new System.Drawing.Point(108, 13);
               this.label2.Name = "label2";
               this.label2.Size = new System.Drawing.Size(28, 17);
               this.label2.TabIndex = 1;
               this.label2.Text = "to: ";
               // 
               // endPointNumber
               // 
               this.endPointNumber.Location = new System.Drawing.Point(142, 13);
               this.endPointNumber.Name = "endPointNumber";
               this.endPointNumber.Size = new System.Drawing.Size(119, 22);
               this.endPointNumber.TabIndex = 2;
               // 
               // calculateButton
               // 
               this.calculateButton.ForeColor = System.Drawing.Color.Goldenrod;
               this.calculateButton.Location = new System.Drawing.Point(278, 11);
               this.calculateButton.Name = "calculateButton";
               this.calculateButton.Size = new System.Drawing.Size(99, 23);
               this.calculateButton.TabIndex = 3;
               this.calculateButton.Text = "Calculate";
               this.calculateButton.UseVisualStyleBackColor = true;
               this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
               // 
               // cancelButton
               // 
               this.cancelButton.Enabled = false;
               this.cancelButton.ForeColor = System.Drawing.Color.Crimson;
               this.cancelButton.Location = new System.Drawing.Point(383, 12);
               this.cancelButton.Name = "cancelButton";
               this.cancelButton.Size = new System.Drawing.Size(75, 23);
               this.cancelButton.TabIndex = 4;
               this.cancelButton.Text = "Cancel";
               this.cancelButton.UseVisualStyleBackColor = true;
               this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
               // 
               // resultListBox
               // 
               this.resultListBox.FormattingEnabled = true;
               this.resultListBox.ItemHeight = 16;
               this.resultListBox.Location = new System.Drawing.Point(13, 56);
               this.resultListBox.Name = "resultListBox";
               this.resultListBox.Size = new System.Drawing.Size(445, 452);
               this.resultListBox.TabIndex = 5;
               // 
               // Form1
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(470, 520);
               this.Controls.Add(this.resultListBox);
               this.Controls.Add(this.cancelButton);
               this.Controls.Add(this.calculateButton);
               this.Controls.Add(this.endPointNumber);
               this.Controls.Add(this.label2);
               this.Controls.Add(this.label1);
               this.Name = "Form1";
               this.Text = "Prime Numbers from 2 to ..";
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion

          private System.Windows.Forms.Label label1;
          private System.Windows.Forms.Label label2;
          private System.Windows.Forms.TextBox endPointNumber;
          private System.Windows.Forms.Button calculateButton;
          private System.Windows.Forms.Button cancelButton;
          private System.Windows.Forms.ListBox resultListBox;
     }
}

