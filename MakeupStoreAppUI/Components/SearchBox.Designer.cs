namespace MakeupStoreAppUI.Components
{
    partial class SearchBox
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtSearchEntry = new System.Windows.Forms.TextBox();
            this.gbxFilters = new System.Windows.Forms.GroupBox();
            this.rdbCategoryFilter = new System.Windows.Forms.RadioButton();
            this.rdbCodeFilter = new System.Windows.Forms.RadioButton();
            this.rdbTitleFilter = new System.Windows.Forms.RadioButton();
            this.gbxFilters.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Image = global::MakeupStoreAppUI.Properties.Resources.icons8_search_more_ios_16_32;
            this.btnSearch.Location = new System.Drawing.Point(382, 42);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(126, 39);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnClear
            // 
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Image = global::MakeupStoreAppUI.Properties.Resources.icons8_broom_ios_16_glyph_32;
            this.btnClear.Location = new System.Drawing.Point(523, 42);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(126, 39);
            this.btnClear.TabIndex = 0;
            this.btnClear.Text = "Clear";
            this.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtSearchEntry
            // 
            this.txtSearchEntry.Location = new System.Drawing.Point(12, 42);
            this.txtSearchEntry.MinimumSize = new System.Drawing.Size(0, 39);
            this.txtSearchEntry.Name = "txtSearchEntry";
            this.txtSearchEntry.Size = new System.Drawing.Size(355, 39);
            this.txtSearchEntry.TabIndex = 1;
            // 
            // gbxFilters
            // 
            this.gbxFilters.Controls.Add(this.rdbCategoryFilter);
            this.gbxFilters.Controls.Add(this.rdbCodeFilter);
            this.gbxFilters.Controls.Add(this.rdbTitleFilter);
            this.gbxFilters.Location = new System.Drawing.Point(29, 94);
            this.gbxFilters.Name = "gbxFilters";
            this.gbxFilters.Size = new System.Drawing.Size(594, 65);
            this.gbxFilters.TabIndex = 2;
            this.gbxFilters.TabStop = false;
            this.gbxFilters.Text = "groupBox1";
            // 
            // rdbCategoryFilter
            // 
            this.rdbCategoryFilter.AutoSize = true;
            this.rdbCategoryFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdbCategoryFilter.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.rdbCategoryFilter.Location = new System.Drawing.Point(296, 19);
            this.rdbCategoryFilter.Name = "rdbCategoryFilter";
            this.rdbCategoryFilter.Size = new System.Drawing.Size(143, 26);
            this.rdbCategoryFilter.TabIndex = 3;
            this.rdbCategoryFilter.TabStop = true;
            this.rdbCategoryFilter.Text = "By Category";
            this.rdbCategoryFilter.UseVisualStyleBackColor = true;
            // 
            // rdbCodeFilter
            // 
            this.rdbCodeFilter.AutoSize = true;
            this.rdbCodeFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdbCodeFilter.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.rdbCodeFilter.Location = new System.Drawing.Point(142, 19);
            this.rdbCodeFilter.Name = "rdbCodeFilter";
            this.rdbCodeFilter.Size = new System.Drawing.Size(106, 26);
            this.rdbCodeFilter.TabIndex = 4;
            this.rdbCodeFilter.TabStop = true;
            this.rdbCodeFilter.Text = "By Code";
            this.rdbCodeFilter.UseVisualStyleBackColor = true;
            // 
            // rdbTitleFilter
            // 
            this.rdbTitleFilter.AutoSize = true;
            this.rdbTitleFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdbTitleFilter.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.rdbTitleFilter.Location = new System.Drawing.Point(6, 19);
            this.rdbTitleFilter.Name = "rdbTitleFilter";
            this.rdbTitleFilter.Size = new System.Drawing.Size(87, 26);
            this.rdbTitleFilter.TabIndex = 5;
            this.rdbTitleFilter.TabStop = true;
            this.rdbTitleFilter.Text = "By Title";
            this.rdbTitleFilter.UseVisualStyleBackColor = true;
            // 
            // SearchBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.gbxFilters);
            this.Controls.Add(this.txtSearchEntry);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnClear);
            this.Name = "SearchBox";
            this.Size = new System.Drawing.Size(666, 180);
            this.gbxFilters.ResumeLayout(false);
            this.gbxFilters.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearchEntry;
        private System.Windows.Forms.GroupBox gbxFilters;
        private System.Windows.Forms.RadioButton rdbCategoryFilter;
        private System.Windows.Forms.RadioButton rdbCodeFilter;
        private System.Windows.Forms.RadioButton rdbTitleFilter;
    }
}
