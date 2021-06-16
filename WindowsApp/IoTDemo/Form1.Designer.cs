
namespace IoTDemo
{
    partial class MainIoTForm
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
            this.labelConnectionString = new System.Windows.Forms.Label();
            this.textBoxConnectionString = new System.Windows.Forms.TextBox();
            this.buttonShop1 = new System.Windows.Forms.Button();
            this.buttonShop2 = new System.Windows.Forms.Button();
            this.buttonShop3 = new System.Windows.Forms.Button();
            this.buttonShop4 = new System.Windows.Forms.Button();
            this.buttonShop5 = new System.Windows.Forms.Button();
            this.buttonShop6 = new System.Windows.Forms.Button();
            this.buttonShop7 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // labelConnectionString
            // 
            this.labelConnectionString.AutoSize = true;
            this.labelConnectionString.Location = new System.Drawing.Point(12, 25);
            this.labelConnectionString.Name = "labelConnectionString";
            this.labelConnectionString.Size = new System.Drawing.Size(222, 25);
            this.labelConnectionString.TabIndex = 0;
            this.labelConnectionString.Text = "IoT Hub Connection String";
            // 
            // textBoxConnectionString
            // 
            this.textBoxConnectionString.Location = new System.Drawing.Point(240, 22);
            this.textBoxConnectionString.Name = "textBoxConnectionString";
            this.textBoxConnectionString.Size = new System.Drawing.Size(891, 31);
            this.textBoxConnectionString.TabIndex = 1;
            this.textBoxConnectionString.TextChanged += new System.EventHandler(this.textBoxConnectionString_TextChanged);
            // 
            // buttonShop1
            // 
            this.buttonShop1.Font = new System.Drawing.Font("Segoe UI Black", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonShop1.Location = new System.Drawing.Point(12, 73);
            this.buttonShop1.Name = "buttonShop1";
            this.buttonShop1.Size = new System.Drawing.Size(380, 139);
            this.buttonShop1.TabIndex = 2;
            this.buttonShop1.Text = "Spam";
            this.buttonShop1.UseVisualStyleBackColor = true;
            this.buttonShop1.Click += new System.EventHandler(this.buttonShop_Click);
            // 
            // buttonShop2
            // 
            this.buttonShop2.Font = new System.Drawing.Font("Segoe UI Black", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonShop2.Location = new System.Drawing.Point(398, 73);
            this.buttonShop2.Name = "buttonShop2";
            this.buttonShop2.Size = new System.Drawing.Size(380, 139);
            this.buttonShop2.TabIndex = 3;
            this.buttonShop2.Text = "Baked Beans";
            this.buttonShop2.UseVisualStyleBackColor = true;
            this.buttonShop2.Click += new System.EventHandler(this.buttonShop_Click);
            // 
            // buttonShop3
            // 
            this.buttonShop3.Font = new System.Drawing.Font("Segoe UI Black", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonShop3.Location = new System.Drawing.Point(12, 508);
            this.buttonShop3.Name = "buttonShop3";
            this.buttonShop3.Size = new System.Drawing.Size(766, 166);
            this.buttonShop3.TabIndex = 4;
            this.buttonShop3.Text = "Lobster Thermidor aux crevettes with a Mornay sauce, garnished with truffle pâté," +
    " brandy and a fried egg on top";
            this.buttonShop3.UseVisualStyleBackColor = true;
            this.buttonShop3.Click += new System.EventHandler(this.buttonShop_Click);
            // 
            // buttonShop4
            // 
            this.buttonShop4.Font = new System.Drawing.Font("Segoe UI Black", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonShop4.Location = new System.Drawing.Point(398, 363);
            this.buttonShop4.Name = "buttonShop4";
            this.buttonShop4.Size = new System.Drawing.Size(380, 139);
            this.buttonShop4.TabIndex = 5;
            this.buttonShop4.Text = "Tomato";
            this.buttonShop4.UseVisualStyleBackColor = true;
            this.buttonShop4.Click += new System.EventHandler(this.buttonShop_Click);
            // 
            // buttonShop5
            // 
            this.buttonShop5.Font = new System.Drawing.Font("Segoe UI Black", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonShop5.Location = new System.Drawing.Point(12, 363);
            this.buttonShop5.Name = "buttonShop5";
            this.buttonShop5.Size = new System.Drawing.Size(380, 139);
            this.buttonShop5.TabIndex = 6;
            this.buttonShop5.Text = "Sausage";
            this.buttonShop5.UseVisualStyleBackColor = true;
            this.buttonShop5.Click += new System.EventHandler(this.buttonShop_Click);
            // 
            // buttonShop6
            // 
            this.buttonShop6.Font = new System.Drawing.Font("Segoe UI Black", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonShop6.Location = new System.Drawing.Point(398, 218);
            this.buttonShop6.Name = "buttonShop6";
            this.buttonShop6.Size = new System.Drawing.Size(380, 139);
            this.buttonShop6.TabIndex = 7;
            this.buttonShop6.Text = "Bacon";
            this.buttonShop6.UseVisualStyleBackColor = true;
            this.buttonShop6.Click += new System.EventHandler(this.buttonShop_Click);
            // 
            // buttonShop7
            // 
            this.buttonShop7.Font = new System.Drawing.Font("Segoe UI Black", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonShop7.Location = new System.Drawing.Point(12, 218);
            this.buttonShop7.Name = "buttonShop7";
            this.buttonShop7.Size = new System.Drawing.Size(380, 139);
            this.buttonShop7.TabIndex = 8;
            this.buttonShop7.Text = "Egg";
            this.buttonShop7.UseVisualStyleBackColor = true;
            this.buttonShop7.Click += new System.EventHandler(this.buttonShop_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(784, 73);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(347, 601);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "";
            // 
            // MainIoTForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 690);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.buttonShop7);
            this.Controls.Add(this.buttonShop6);
            this.Controls.Add(this.buttonShop5);
            this.Controls.Add(this.buttonShop4);
            this.Controls.Add(this.buttonShop3);
            this.Controls.Add(this.buttonShop2);
            this.Controls.Add(this.buttonShop1);
            this.Controls.Add(this.textBoxConnectionString);
            this.Controls.Add(this.labelConnectionString);
            this.Name = "MainIoTForm";
            this.Text = "IoT Shopping Simulator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelConnectionString;
        private System.Windows.Forms.TextBox textBoxConnectionString;
        private System.Windows.Forms.Button buttonShop1;
        private System.Windows.Forms.Button buttonShop2;
        private System.Windows.Forms.Button buttonShop3;
        private System.Windows.Forms.Button buttonShop4;
        private System.Windows.Forms.Button buttonShop5;
        private System.Windows.Forms.Button buttonShop6;
        private System.Windows.Forms.Button buttonShop7;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

