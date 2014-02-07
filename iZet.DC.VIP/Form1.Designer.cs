namespace iZet.DC.VIP
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TextBox tb_SharedMax;
            System.Windows.Forms.TextBox tb_SharedAverage;
            System.Windows.Forms.TextBox tb_OnlineHours;
            System.Windows.Forms.TextBox tb_StatsTime;
            System.Windows.Forms.DateTimePicker dateTimePicker1;
            this.button1 = new System.Windows.Forms.Button();
            this.statsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            tb_SharedMax = new System.Windows.Forms.TextBox();
            tb_SharedAverage = new System.Windows.Forms.TextBox();
            tb_OnlineHours = new System.Windows.Forms.TextBox();
            tb_StatsTime = new System.Windows.Forms.TextBox();
            dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.statsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_SharedMax
            // 
            tb_SharedMax.Cursor = System.Windows.Forms.Cursors.No;
            tb_SharedMax.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.statsBindingSource, "SharedMax", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            tb_SharedMax.Location = new System.Drawing.Point(100, 12);
            tb_SharedMax.Name = "tb_SharedMax";
            tb_SharedMax.ReadOnly = true;
            tb_SharedMax.Size = new System.Drawing.Size(159, 20);
            tb_SharedMax.TabIndex = 0;
            // 
            // tb_SharedAverage
            // 
            tb_SharedAverage.Cursor = System.Windows.Forms.Cursors.No;
            tb_SharedAverage.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.statsBindingSource, "SharedAverage", true));
            tb_SharedAverage.Location = new System.Drawing.Point(100, 38);
            tb_SharedAverage.Name = "tb_SharedAverage";
            tb_SharedAverage.ReadOnly = true;
            tb_SharedAverage.Size = new System.Drawing.Size(159, 20);
            tb_SharedAverage.TabIndex = 2;
            // 
            // tb_OnlineHours
            // 
            tb_OnlineHours.Cursor = System.Windows.Forms.Cursors.No;
            tb_OnlineHours.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.statsBindingSource, "OnlineHours", true));
            tb_OnlineHours.Location = new System.Drawing.Point(100, 64);
            tb_OnlineHours.Name = "tb_OnlineHours";
            tb_OnlineHours.ReadOnly = true;
            tb_OnlineHours.Size = new System.Drawing.Size(159, 20);
            tb_OnlineHours.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(564, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb_StatsTime
            // 
            tb_StatsTime.Cursor = System.Windows.Forms.Cursors.No;
            tb_StatsTime.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.statsBindingSource, "Time", true));
            tb_StatsTime.Location = new System.Drawing.Point(100, 90);
            tb_StatsTime.Name = "tb_StatsTime";
            tb_StatsTime.ReadOnly = true;
            tb_StatsTime.Size = new System.Drawing.Size(159, 20);
            tb_StatsTime.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CausesValidation = false;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            dateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.statsBindingSource, "Time", true));
            dateTimePicker1.Enabled = false;
            dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new System.Drawing.Point(100, 116);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            dateTimePicker1.TabIndex = 3;
            // 
            // statsBindingSource
            // 
            this.statsBindingSource.DataSource = typeof(iZet.DC.VIP.Models.Stats);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 261);
            this.Controls.Add(dateTimePicker1);
            this.Controls.Add(tb_StatsTime);
            this.Controls.Add(tb_OnlineHours);
            this.Controls.Add(tb_SharedAverage);
            this.Controls.Add(this.button1);
            this.Controls.Add(tb_SharedMax);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.statsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource statsBindingSource;
    }
}

