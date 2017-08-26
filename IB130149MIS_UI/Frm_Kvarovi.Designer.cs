namespace IB130149MIS_UI
{
    partial class Frm_Kvarovi
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
            this.dataGridKvarovi = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridKvarovi)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridKvarovi
            // 
            this.dataGridKvarovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridKvarovi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridKvarovi.Location = new System.Drawing.Point(0, 0);
            this.dataGridKvarovi.Name = "dataGridKvarovi";
            this.dataGridKvarovi.Size = new System.Drawing.Size(292, 273);
            this.dataGridKvarovi.TabIndex = 0;
            // 
            // Frm_Kvarovi
            // 
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.dataGridKvarovi);
            this.Name = "Frm_Kvarovi";
            this.Load += new System.EventHandler(this.Frm_Kvarovi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridKvarovi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridKvarovi;
    }
}

