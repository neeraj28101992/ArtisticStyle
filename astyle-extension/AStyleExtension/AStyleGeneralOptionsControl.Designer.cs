namespace AStyleExtension {
    partial class AStyleGeneralOptionsControl {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.tabControlOptions = new System.Windows.Forms.TabControl();
            this.tabPageCPP = new System.Windows.Forms.TabPage();
            this.checkBoxCppFormatOnSave = new System.Windows.Forms.CheckBox();
            this.buttonCPPEdit = new System.Windows.Forms.Button();
            this.labelCPP = new System.Windows.Forms.Label();
            this.textBoxCPP = new System.Windows.Forms.TextBox();
            this.buttonCPPSettings = new System.Windows.Forms.Button();

            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.SaveFormatHeader = new System.Windows.Forms.CheckBox();
            this.EditButtonHeader = new System.Windows.Forms.Button();
            this.CommandLableHeader = new System.Windows.Forms.Label();
            this.CppTextHeader = new System.Windows.Forms.TextBox();
            this.SettingButtonHeader = new System.Windows.Forms.Button();

            this.tabPageCS = new System.Windows.Forms.TabPage();
            this.checkBoxCsFormatOnSave = new System.Windows.Forms.CheckBox();
            this.buttonCSEdit = new System.Windows.Forms.Button();
            this.labelCS = new System.Windows.Forms.Label();
            this.textBoxCS = new System.Windows.Forms.TextBox();
            this.buttonCSSettings = new System.Windows.Forms.Button();
            this.tabPageImport = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDetails = new System.Windows.Forms.TextBox();
            this.buttonImport = new System.Windows.Forms.Button();
            this.buttonExport = new System.Windows.Forms.Button();
            this.tabControlOptions.SuspendLayout();
            this.tabPageCPP.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPageCS.SuspendLayout();
            this.tabPageImport.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlOptions
            // 
            this.tabControlOptions.Controls.Add(this.tabPageCPP);
            this.tabControlOptions.Controls.Add(this.tabPage1);
            this.tabControlOptions.Controls.Add(this.tabPageCS);
            this.tabControlOptions.Controls.Add(this.tabPageImport);
            this.tabControlOptions.Location = new System.Drawing.Point(5, 4);
            this.tabControlOptions.Margin = new System.Windows.Forms.Padding(4);
            this.tabControlOptions.Name = "tabControlOptions";
            this.tabControlOptions.SelectedIndex = 0;
            this.tabControlOptions.Size = new System.Drawing.Size(525, 351);
            this.tabControlOptions.TabIndex = 3;
            // 
            // tabPageCPP
            // 
            this.tabPageCPP.Controls.Add(this.checkBoxCppFormatOnSave);
            this.tabPageCPP.Controls.Add(this.buttonCPPEdit);
            this.tabPageCPP.Controls.Add(this.labelCPP);
            this.tabPageCPP.Controls.Add(this.textBoxCPP);
            this.tabPageCPP.Controls.Add(this.buttonCPPSettings);
            this.tabPageCPP.Location = new System.Drawing.Point(4, 25);
            this.tabPageCPP.Name = "tabPageCPP";
            this.tabPageCPP.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageCPP.Size = new System.Drawing.Size(517, 322);
            this.tabPageCPP.TabIndex = 0;
            this.tabPageCPP.Text = "C/C++ - *.cpp";
            this.tabPageCPP.UseVisualStyleBackColor = true;
            // 
            // checkBoxCppFormatOnSave
            // 
            this.checkBoxCppFormatOnSave.AutoSize = true;
            this.checkBoxCppFormatOnSave.Location = new System.Drawing.Point(382, 12);
            this.checkBoxCppFormatOnSave.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxCppFormatOnSave.Name = "checkBoxCppFormatOnSave";
            this.checkBoxCppFormatOnSave.Size = new System.Drawing.Size(128, 21);
            this.checkBoxCppFormatOnSave.TabIndex = 6;
            this.checkBoxCppFormatOnSave.Text = "Format on save";
            this.checkBoxCppFormatOnSave.UseVisualStyleBackColor = true;
            // 
            // buttonCPPEdit
            // 
            this.buttonCPPEdit.Location = new System.Drawing.Point(122, 7);
            this.buttonCPPEdit.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCPPEdit.Name = "buttonCPPEdit";
            this.buttonCPPEdit.Size = new System.Drawing.Size(100, 28);
            this.buttonCPPEdit.TabIndex = 5;
            this.buttonCPPEdit.Text = "Edit";
            this.buttonCPPEdit.UseVisualStyleBackColor = true;
            this.buttonCPPEdit.Click += new System.EventHandler(this.OnButtonCPPEditClick);
            // 
            // labelCPP
            // 
            this.labelCPP.AutoSize = true;
            this.labelCPP.Location = new System.Drawing.Point(10, 49);
            this.labelCPP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCPP.Name = "labelCPP";
            this.labelCPP.Size = new System.Drawing.Size(100, 17);
            this.labelCPP.TabIndex = 4;
            this.labelCPP.Text = "Command line:";
            // 
            // textBoxCPP
            // 
            this.textBoxCPP.Location = new System.Drawing.Point(40, 69);
            this.textBoxCPP.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCPP.Multiline = true;
            this.textBoxCPP.Name = "textBoxCPP";
            this.textBoxCPP.ReadOnly = true;
            this.textBoxCPP.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxCPP.Size = new System.Drawing.Size(489, 233);
            this.textBoxCPP.TabIndex = 3;
            // 
            // buttonCPPSettings
            // 
            this.buttonCPPSettings.Location = new System.Drawing.Point(14, 7);
            this.buttonCPPSettings.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCPPSettings.Name = "buttonCPPSettings";
            this.buttonCPPSettings.Size = new System.Drawing.Size(100, 28);
            this.buttonCPPSettings.TabIndex = 0;
            this.buttonCPPSettings.Text = "Settings";
            this.buttonCPPSettings.UseVisualStyleBackColor = true;
            this.buttonCPPSettings.Click += new System.EventHandler(this.OnButtonCPPSettingsClick);
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.SaveFormatHeader);
            this.tabPage1.Controls.Add(this.EditButtonHeader);
            this.tabPage1.Controls.Add(this.CommandLableHeader);
            this.tabPage1.Controls.Add(this.CppTextHeader);
            this.tabPage1.Controls.Add(this.SettingButtonHeader);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(517, 322);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "C/C++ - *.h";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // SaveFormatHeader
            // 
            this.SaveFormatHeader.AutoSize = true;
            this.SaveFormatHeader.Location = new System.Drawing.Point(382, 12);
            this.SaveFormatHeader.Margin = new System.Windows.Forms.Padding(4);
            this.SaveFormatHeader.Name = "SaveFormatHeader";
            this.SaveFormatHeader.Size = new System.Drawing.Size(128, 21);
            this.SaveFormatHeader.TabIndex = 10;
            this.SaveFormatHeader.Text = "Format on save";
            this.SaveFormatHeader.UseVisualStyleBackColor = true;
            // 
            // EditButtonHeader
            // 
            this.EditButtonHeader.Location = new System.Drawing.Point(122, 7);
            this.EditButtonHeader.Margin = new System.Windows.Forms.Padding(4);
            this.EditButtonHeader.Name = "EditButtonHeader";
            this.EditButtonHeader.Size = new System.Drawing.Size(100, 28);
            this.EditButtonHeader.TabIndex = 9;
            this.EditButtonHeader.Text = "Edit";
            this.EditButtonHeader.UseVisualStyleBackColor = true;
            this.EditButtonHeader.Click += new System.EventHandler(this.OnButtonCPPHeaderEditClick);
            // 
            // CommandLableHeader
            // 
            this.CommandLableHeader.AutoSize = true;
            this.CommandLableHeader.Location = new System.Drawing.Point(10, 49);
            this.CommandLableHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CommandLableHeader.Name = "CommandLableHeader";
            this.CommandLableHeader.Size = new System.Drawing.Size(101, 17);
            this.CommandLableHeader.TabIndex = 8;
            this.CommandLableHeader.Text = "Command line:";
            // 
            // CppTextHeader
            // 
            this.CppTextHeader.Location = new System.Drawing.Point(14, 69);
            this.CppTextHeader.Margin = new System.Windows.Forms.Padding(4);
            this.CppTextHeader.Multiline = true;
            this.CppTextHeader.Name = "CppTextHeader";
            this.CppTextHeader.ReadOnly = true;
            this.CppTextHeader.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.CppTextHeader.Size = new System.Drawing.Size(489, 233);
            this.CppTextHeader.TabIndex = 7;
            // 
            // SettingButtonHeader
            // 
            this.SettingButtonHeader.Location = new System.Drawing.Point(14, 7);
            this.SettingButtonHeader.Margin = new System.Windows.Forms.Padding(4);
            this.SettingButtonHeader.Name = "SettingButtonHeader";
            this.SettingButtonHeader.Size = new System.Drawing.Size(100, 28);
            this.SettingButtonHeader.TabIndex = 1;
            this.SettingButtonHeader.Text = "Settings";
            this.SettingButtonHeader.UseVisualStyleBackColor = true;
            this.SettingButtonHeader.Click += new System.EventHandler(this.OnButtonCPPHeaderSettingsClick);
            // 
            // 
            // tabPageCS
            // 
            this.tabPageCS.Controls.Add(this.checkBoxCsFormatOnSave);
            this.tabPageCS.Controls.Add(this.buttonCSEdit);
            this.tabPageCS.Controls.Add(this.labelCS);
            this.tabPageCS.Controls.Add(this.textBoxCS);
            this.tabPageCS.Controls.Add(this.buttonCSSettings);
            this.tabPageCS.Location = new System.Drawing.Point(4, 25);
            this.tabPageCS.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageCS.Name = "tabPageCS";
            this.tabPageCS.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageCS.Size = new System.Drawing.Size(517, 322);
            this.tabPageCS.TabIndex = 1;
            this.tabPageCS.Text = "C#";
            this.tabPageCS.UseVisualStyleBackColor = true;
            // 
            // checkBoxCsFormatOnSave
            // 
            this.checkBoxCsFormatOnSave.AutoSize = true;
            this.checkBoxCsFormatOnSave.Location = new System.Drawing.Point(382, 12);
            this.checkBoxCsFormatOnSave.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxCsFormatOnSave.Name = "checkBoxCsFormatOnSave";
            this.checkBoxCsFormatOnSave.Size = new System.Drawing.Size(128, 21);
            this.checkBoxCsFormatOnSave.TabIndex = 7;
            this.checkBoxCsFormatOnSave.Text = "Format on save";
            this.checkBoxCsFormatOnSave.UseVisualStyleBackColor = true;
            // 
            // buttonCSEdit
            // 
            this.buttonCSEdit.Location = new System.Drawing.Point(122, 7);
            this.buttonCSEdit.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCSEdit.Name = "buttonCSEdit";
            this.buttonCSEdit.Size = new System.Drawing.Size(100, 28);
            this.buttonCSEdit.TabIndex = 6;
            this.buttonCSEdit.Text = "Edit";
            this.buttonCSEdit.UseVisualStyleBackColor = true;
            this.buttonCSEdit.Click += new System.EventHandler(this.OnButtonCSEditClick);
            // 
            // labelCS
            // 
            this.labelCS.AutoSize = true;
            this.labelCS.Location = new System.Drawing.Point(10, 49);
            this.labelCS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCS.Name = "labelCS";
            this.labelCS.Size = new System.Drawing.Size(101, 17);
            this.labelCS.TabIndex = 5;
            this.labelCS.Text = "Command line:";
            // 
            // textBoxCS
            // 
            this.textBoxCS.Location = new System.Drawing.Point(14, 69);
            this.textBoxCS.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCS.Multiline = true;
            this.textBoxCS.Name = "textBoxCS";
            this.textBoxCS.ReadOnly = true;
            this.textBoxCS.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxCS.Size = new System.Drawing.Size(489, 230);
            this.textBoxCS.TabIndex = 4;
            // 
            // buttonCSSettings
            // 
            this.buttonCSSettings.Location = new System.Drawing.Point(17, 7);
            this.buttonCSSettings.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCSSettings.Name = "buttonCSSettings";
            this.buttonCSSettings.Size = new System.Drawing.Size(100, 28);
            this.buttonCSSettings.TabIndex = 1;
            this.buttonCSSettings.Text = "Settings";
            this.buttonCSSettings.UseVisualStyleBackColor = true;
            this.buttonCSSettings.Click += new System.EventHandler(this.OnButtonCSSettingsClick);
            // 
            // tabPageImport
            // 
            this.tabPageImport.Controls.Add(this.label1);
            this.tabPageImport.Controls.Add(this.textBoxDetails);
            this.tabPageImport.Controls.Add(this.buttonImport);
            this.tabPageImport.Controls.Add(this.buttonExport);
            this.tabPageImport.Location = new System.Drawing.Point(4, 25);
            this.tabPageImport.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageImport.Name = "tabPageImport";
            this.tabPageImport.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageImport.Size = new System.Drawing.Size(517, 322);
            this.tabPageImport.TabIndex = 2;
            this.tabPageImport.Text = "Export/Import";
            this.tabPageImport.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Details:";
            // 
            // textBoxDetails
            // 
            this.textBoxDetails.Location = new System.Drawing.Point(14, 69);
            this.textBoxDetails.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDetails.Multiline = true;
            this.textBoxDetails.Name = "textBoxDetails";
            this.textBoxDetails.ReadOnly = true;
            this.textBoxDetails.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxDetails.Size = new System.Drawing.Size(489, 230);
            this.textBoxDetails.TabIndex = 6;
            // 
            // buttonImport
            // 
            this.buttonImport.Location = new System.Drawing.Point(122, 7);
            this.buttonImport.Margin = new System.Windows.Forms.Padding(4);
            this.buttonImport.Name = "buttonImport";
            this.buttonImport.Size = new System.Drawing.Size(100, 28);
            this.buttonImport.TabIndex = 3;
            this.buttonImport.Text = "Import";
            this.buttonImport.UseVisualStyleBackColor = true;
            this.buttonImport.Click += new System.EventHandler(this.OnButtonImportClick);
            // 
            // buttonExport
            // 
            this.buttonExport.Location = new System.Drawing.Point(14, 7);
            this.buttonExport.Margin = new System.Windows.Forms.Padding(4);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(100, 28);
            this.buttonExport.TabIndex = 2;
            this.buttonExport.Text = "Export";
            this.buttonExport.UseVisualStyleBackColor = true;
            this.buttonExport.Click += new System.EventHandler(this.OnButtonExportClick);
            // 
            // AStyleGeneralOptionsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControlOptions);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AStyleGeneralOptionsControl";
            this.Size = new System.Drawing.Size(5773, 423);
            this.tabControlOptions.ResumeLayout(false);
            this.tabPageCPP.ResumeLayout(false);
            this.tabPageCPP.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPageCS.ResumeLayout(false);
            this.tabPageCS.PerformLayout();
            this.tabPageImport.ResumeLayout(false);
            this.tabPageImport.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlOptions;
        private System.Windows.Forms.TabPage tabPageCPP;
        private System.Windows.Forms.Label labelCPP;
        private System.Windows.Forms.TextBox textBoxCPP;
        private System.Windows.Forms.Button buttonCPPSettings;
        private System.Windows.Forms.TabPage tabPageCS;
        private System.Windows.Forms.Label labelCS;
        private System.Windows.Forms.TextBox textBoxCS;
        private System.Windows.Forms.Button buttonCSSettings;
        private System.Windows.Forms.Button buttonCPPEdit;
        private System.Windows.Forms.Button buttonCSEdit;
        private System.Windows.Forms.TabPage tabPageImport;
        private System.Windows.Forms.Button buttonImport;
        private System.Windows.Forms.Button buttonExport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDetails;
        private System.Windows.Forms.CheckBox checkBoxCppFormatOnSave;
        private System.Windows.Forms.CheckBox checkBoxCsFormatOnSave;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.CheckBox SaveFormatHeader;
        private System.Windows.Forms.Button EditButtonHeader;
        private System.Windows.Forms.Label CommandLableHeader;
        private System.Windows.Forms.TextBox CppTextHeader;
        private System.Windows.Forms.Button SettingButtonHeader;

    }
}
