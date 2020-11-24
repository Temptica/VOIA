namespace InboundOutbound
{
    partial class Display
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
            this.labelZuluTime = new System.Windows.Forms.Label();
            this.labelDepartures = new System.Windows.Forms.Label();
            this.labelArrivals = new System.Windows.Forms.Label();
            this.ButtonRefrech = new System.Windows.Forms.Button();
            this.listDepartures = new System.Windows.Forms.ListView();
            this.listViewArrivals = new System.Windows.Forms.ListView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelZuluTime
            // 
            this.labelZuluTime.AutoSize = true;
            this.labelZuluTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelZuluTime.Location = new System.Drawing.Point(635, 9);
            this.labelZuluTime.Name = "labelZuluTime";
            this.labelZuluTime.Size = new System.Drawing.Size(65, 25);
            this.labelZuluTime.TabIndex = 0;
            this.labelZuluTime.Text = "Label";
            // 
            // labelDepartures
            // 
            this.labelDepartures.AutoSize = true;
            this.labelDepartures.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDepartures.Location = new System.Drawing.Point(110, 97);
            this.labelDepartures.Name = "labelDepartures";
            this.labelDepartures.Size = new System.Drawing.Size(175, 37);
            this.labelDepartures.TabIndex = 1;
            this.labelDepartures.Text = "Departures";
            this.labelDepartures.Click += new System.EventHandler(this.labelDepartures_Click);
            // 
            // labelArrivals
            // 
            this.labelArrivals.AutoSize = true;
            this.labelArrivals.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelArrivals.Location = new System.Drawing.Point(832, 112);
            this.labelArrivals.Name = "labelArrivals";
            this.labelArrivals.Size = new System.Drawing.Size(124, 37);
            this.labelArrivals.TabIndex = 2;
            this.labelArrivals.Text = "Arrivals";
            this.labelArrivals.Click += new System.EventHandler(this.label1_Click);
            // 
            // ButtonRefrech
            // 
            this.ButtonRefrech.Enabled = false;
            this.ButtonRefrech.Location = new System.Drawing.Point(387, 26);
            this.ButtonRefrech.Name = "ButtonRefrech";
            this.ButtonRefrech.Size = new System.Drawing.Size(60, 21);
            this.ButtonRefrech.TabIndex = 5;
            this.ButtonRefrech.Text = "Refresh";
            this.ButtonRefrech.UseVisualStyleBackColor = true;
            this.ButtonRefrech.Click += new System.EventHandler(this.ButtonRefrech_Click);
            // 
            // listDepartures
            // 
            this.listDepartures.HideSelection = false;
            this.listDepartures.Location = new System.Drawing.Point(12, 173);
            this.listDepartures.Name = "listDepartures";
            this.listDepartures.Size = new System.Drawing.Size(420, 227);
            this.listDepartures.TabIndex = 6;
            this.listDepartures.UseCompatibleStateImageBehavior = false;
            // 
            // listViewArrivals
            // 
            this.listViewArrivals.HideSelection = false;
            this.listViewArrivals.Location = new System.Drawing.Point(557, 173);
            this.listViewArrivals.Name = "listViewArrivals";
            this.listViewArrivals.Size = new System.Drawing.Size(603, 227);
            this.listViewArrivals.TabIndex = 7;
            this.listViewArrivals.UseCompatibleStateImageBehavior = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(189, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "label1";
            // 
            // Display
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 583);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listViewArrivals);
            this.Controls.Add(this.listDepartures);
            this.Controls.Add(this.ButtonRefrech);
            this.Controls.Add(this.labelArrivals);
            this.Controls.Add(this.labelDepartures);
            this.Controls.Add(this.labelZuluTime);
            this.Name = "Display";
            this.Text = "Display";
            this.Load += new System.EventHandler(this.Display_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelZuluTime;
        private System.Windows.Forms.Label labelDepartures;
        private System.Windows.Forms.Label labelArrivals;
        private System.Windows.Forms.Button ButtonRefrech;
        private System.Windows.Forms.ListView listDepartures;
        private System.Windows.Forms.ListView listViewArrivals;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}