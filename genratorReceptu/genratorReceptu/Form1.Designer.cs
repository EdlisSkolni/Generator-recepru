namespace genratorReceptu
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
            btnSearchRecipes = new Button();
            cmbCategoryFilter = new ComboBox();
            lstRecipes = new ListBox();
            btnBack = new Button();
            label1 = new Label();
            button1 = new Button();
            clbIngredient = new CheckedListBox();
            SuspendLayout();
            // 
            // btnSearchRecipes
            // 
            btnSearchRecipes.Location = new Point(352, 327);
            btnSearchRecipes.Name = "btnSearchRecipes";
            btnSearchRecipes.Size = new Size(136, 48);
            btnSearchRecipes.TabIndex = 1;
            btnSearchRecipes.Text = "Vyhledat recepty";
            btnSearchRecipes.UseVisualStyleBackColor = true;
            btnSearchRecipes.Click += btnSearchRecipes_Click;
            // 
            // cmbCategoryFilter
            // 
            cmbCategoryFilter.FormattingEnabled = true;
            cmbCategoryFilter.Location = new Point(352, 248);
            cmbCategoryFilter.Name = "cmbCategoryFilter";
            cmbCategoryFilter.Size = new Size(136, 23);
            cmbCategoryFilter.TabIndex = 2;
            // 
            // lstRecipes
            // 
            lstRecipes.FormattingEnabled = true;
            lstRecipes.ItemHeight = 15;
            lstRecipes.Location = new Point(277, 106);
            lstRecipes.Name = "lstRecipes";
            lstRecipes.Size = new Size(290, 184);
            lstRecipes.TabIndex = 3;
            lstRecipes.SelectedIndexChanged += lstRecipes_SelectedIndexChanged;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(352, 349);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(136, 48);
            btnBack.TabIndex = 4;
            btnBack.Text = "Zpět";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(299, 139);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 5;
            label1.Text = "label1";
            // 
            // button1
            // 
            button1.Location = new Point(352, 339);
            button1.Name = "button1";
            button1.Size = new Size(136, 48);
            button1.TabIndex = 6;
            button1.Text = "Zpět do nabídky";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // clbIngredient
            // 
            clbIngredient.FormattingEnabled = true;
            clbIngredient.Location = new Point(352, 51);
            clbIngredient.Name = "clbIngredient";
            clbIngredient.Size = new Size(136, 112);
            clbIngredient.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(clbIngredient);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(btnBack);
            Controls.Add(lstRecipes);
            Controls.Add(cmbCategoryFilter);
            Controls.Add(btnSearchRecipes);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnSearchRecipes;
        private ComboBox cmbCategoryFilter;
        private ListBox lstRecipes;
        private Button btnBack;
        private Label label1;
        private Button button1;
        private CheckedListBox clbIngredient;
    }
}