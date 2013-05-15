namespace NotesApp
{
    partial class notesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(notesForm));
            this.saveButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.dslblinkCbx = new System.Windows.Forms.CheckBox();
            this.inetredCbx = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbrSameCbx = new System.Windows.Forms.CheckBox();
            this.e1Cbx = new System.Windows.Forms.CheckBox();
            this.e2Cbx = new System.Windows.Forms.CheckBox();
            this.e3Cbx = new System.Windows.Forms.CheckBox();
            this.e4Cbx = new System.Windows.Forms.CheckBox();
            this.wlanCbx = new System.Windows.Forms.CheckBox();
            this.dslCbx = new System.Windows.Forms.CheckBox();
            this.inetCbx = new System.Windows.Forms.CheckBox();
            this.pnlCheckBoxes = new System.Windows.Forms.Panel();
            this.pwrCbx = new System.Windows.Forms.CheckBox();
            this.enetCbx = new System.Windows.Forms.CheckBox();
            this.activityChkbox = new System.Windows.Forms.CheckBox();
            this.notesViewText = new System.Windows.Forms.RichTextBox();
            this.notesViewContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copy_context = new System.Windows.Forms.ToolStripMenuItem();
            this.cb_tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.custCbrText = new System.Windows.Forms.MaskedTextBox();
            this.custBtnText = new System.Windows.Forms.MaskedTextBox();
            this.copyBtn = new System.Windows.Forms.LinkLabel();
            this.cbrTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.frontierButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.outageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.faitpointFormButton = new System.Windows.Forms.ToolStripButton();
            this.copied_status = new System.Windows.Forms.ToolStripLabel();
            this.noModemChkbox = new System.Windows.Forms.CheckBox();
            this.tshootingLabel = new System.Windows.Forms.Label();
            this.layoutTable = new System.Windows.Forms.TableLayoutPanel();
            this.otherNotesText = new wmgCMS.WaterMarkTextBox();
            this.tShootText = new NotesApp.ExtTextBox();
            this.svcsOfferedText = new wmgCMS.WaterMarkTextBox();
            this.custModemText = new wmgCMS.WaterMarkTextBox();
            this.custNameText = new wmgCMS.WaterMarkTextBox();
            this.pnlCheckBoxes.SuspendLayout();
            this.notesViewContext.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.layoutTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Location = new System.Drawing.Point(3, 554);
            this.saveButton.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(96, 22);
            this.saveButton.TabIndex = 20;
            this.saveButton.Text = "Generate/Copy";
            this.cb_tooltip.SetToolTip(this.saveButton, "Clicking here will generate all notes into the main output with proper formatting" +
        ". It will also at the same time copy your notes into the clipboard for easy past" +
        "ing into IE.");
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.save_button_Click);
            // 
            // resetButton
            // 
            this.resetButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetButton.Location = new System.Drawing.Point(105, 554);
            this.resetButton.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(64, 22);
            this.resetButton.TabIndex = 21;
            this.resetButton.Text = "Reset";
            this.cb_tooltip.SetToolTip(this.resetButton, "Reset entire form.");
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.reset_form_button_Click);
            // 
            // dslblinkCbx
            // 
            this.dslblinkCbx.AutoSize = true;
            this.dslblinkCbx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dslblinkCbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dslblinkCbx.Location = new System.Drawing.Point(48, 96);
            this.dslblinkCbx.Name = "dslblinkCbx";
            this.dslblinkCbx.Size = new System.Drawing.Size(61, 16);
            this.dslblinkCbx.TabIndex = 16;
            this.dslblinkCbx.Tag = "DSL Blink";
            this.dslblinkCbx.Text = "DSL Blink";
            this.dslblinkCbx.UseVisualStyleBackColor = true;
            // 
            // inetredCbx
            // 
            this.inetredCbx.AutoSize = true;
            this.inetredCbx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inetredCbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inetredCbx.Location = new System.Drawing.Point(48, 118);
            this.inetredCbx.Name = "inetredCbx";
            this.inetredCbx.Size = new System.Drawing.Size(61, 16);
            this.inetredCbx.TabIndex = 18;
            this.inetredCbx.Tag = "Internet Red";
            this.inetredCbx.Text = "INET Red";
            this.inetredCbx.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 12);
            this.label2.TabIndex = 23;
            this.label2.Text = "Billing Telephone #";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 12);
            this.label3.TabIndex = 24;
            this.label3.Text = "Customer CBR#";
            // 
            // cbrSameCbx
            // 
            this.cbrSameCbx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbrSameCbx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbrSameCbx.Font = new System.Drawing.Font("Vani", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbrSameCbx.Location = new System.Drawing.Point(102, 44);
            this.cbrSameCbx.Margin = new System.Windows.Forms.Padding(0);
            this.cbrSameCbx.Name = "cbrSameCbx";
            this.cbrSameCbx.Size = new System.Drawing.Size(74, 20);
            this.cbrSameCbx.TabIndex = 2;
            this.cbrSameCbx.Text = "BTN = CBR";
            this.cbrTooltip.SetToolTip(this.cbrSameCbx, "If the customers CBR and BTN are the same number please check this box.");
            this.cbrSameCbx.UseVisualStyleBackColor = true;
            this.cbrSameCbx.CheckedChanged += new System.EventHandler(this.cbrSameCbx_CheckedChanged);
            // 
            // e1Cbx
            // 
            this.e1Cbx.AutoSize = true;
            this.e1Cbx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.e1Cbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.e1Cbx.Location = new System.Drawing.Point(3, 30);
            this.e1Cbx.Name = "e1Cbx";
            this.e1Cbx.Size = new System.Drawing.Size(32, 16);
            this.e1Cbx.TabIndex = 9;
            this.e1Cbx.Tag = "E1";
            this.e1Cbx.Text = "E1";
            this.e1Cbx.UseVisualStyleBackColor = true;
            // 
            // e2Cbx
            // 
            this.e2Cbx.AutoSize = true;
            this.e2Cbx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.e2Cbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.e2Cbx.Location = new System.Drawing.Point(3, 52);
            this.e2Cbx.Name = "e2Cbx";
            this.e2Cbx.Size = new System.Drawing.Size(32, 16);
            this.e2Cbx.TabIndex = 11;
            this.e2Cbx.Tag = "E2";
            this.e2Cbx.Text = "E2";
            this.e2Cbx.UseVisualStyleBackColor = true;
            // 
            // e3Cbx
            // 
            this.e3Cbx.AutoSize = true;
            this.e3Cbx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.e3Cbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.e3Cbx.Location = new System.Drawing.Point(48, 52);
            this.e3Cbx.Name = "e3Cbx";
            this.e3Cbx.Size = new System.Drawing.Size(32, 16);
            this.e3Cbx.TabIndex = 12;
            this.e3Cbx.Tag = "E3";
            this.e3Cbx.Text = "E3";
            this.e3Cbx.UseVisualStyleBackColor = true;
            // 
            // e4Cbx
            // 
            this.e4Cbx.AutoSize = true;
            this.e4Cbx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.e4Cbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.e4Cbx.Location = new System.Drawing.Point(3, 74);
            this.e4Cbx.Name = "e4Cbx";
            this.e4Cbx.Size = new System.Drawing.Size(32, 16);
            this.e4Cbx.TabIndex = 13;
            this.e4Cbx.Tag = "E4";
            this.e4Cbx.Text = "E4";
            this.e4Cbx.UseVisualStyleBackColor = true;
            // 
            // wlanCbx
            // 
            this.wlanCbx.AutoSize = true;
            this.wlanCbx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.wlanCbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wlanCbx.Location = new System.Drawing.Point(48, 74);
            this.wlanCbx.Name = "wlanCbx";
            this.wlanCbx.Size = new System.Drawing.Size(49, 16);
            this.wlanCbx.TabIndex = 14;
            this.wlanCbx.Tag = "Wlan";
            this.wlanCbx.Text = "WLAN";
            this.wlanCbx.UseVisualStyleBackColor = true;
            // 
            // dslCbx
            // 
            this.dslCbx.AutoSize = true;
            this.dslCbx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dslCbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dslCbx.Location = new System.Drawing.Point(3, 95);
            this.dslCbx.Name = "dslCbx";
            this.dslCbx.Size = new System.Drawing.Size(39, 16);
            this.dslCbx.TabIndex = 15;
            this.dslCbx.Tag = "Dsl";
            this.dslCbx.Text = "DSL";
            this.dslCbx.UseVisualStyleBackColor = true;
            // 
            // inetCbx
            // 
            this.inetCbx.AutoSize = true;
            this.inetCbx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inetCbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inetCbx.Location = new System.Drawing.Point(3, 117);
            this.inetCbx.Name = "inetCbx";
            this.inetCbx.Size = new System.Drawing.Size(42, 16);
            this.inetCbx.TabIndex = 17;
            this.inetCbx.Tag = "Internet";
            this.inetCbx.Text = "INET";
            this.inetCbx.UseVisualStyleBackColor = true;
            // 
            // pnlCheckBoxes
            // 
            this.layoutTable.SetColumnSpan(this.pnlCheckBoxes, 2);
            this.pnlCheckBoxes.Controls.Add(this.pwrCbx);
            this.pnlCheckBoxes.Controls.Add(this.enetCbx);
            this.pnlCheckBoxes.Controls.Add(this.activityChkbox);
            this.pnlCheckBoxes.Controls.Add(this.e1Cbx);
            this.pnlCheckBoxes.Controls.Add(this.e2Cbx);
            this.pnlCheckBoxes.Controls.Add(this.e3Cbx);
            this.pnlCheckBoxes.Controls.Add(this.e4Cbx);
            this.pnlCheckBoxes.Controls.Add(this.wlanCbx);
            this.pnlCheckBoxes.Controls.Add(this.dslCbx);
            this.pnlCheckBoxes.Controls.Add(this.dslblinkCbx);
            this.pnlCheckBoxes.Controls.Add(this.inetCbx);
            this.pnlCheckBoxes.Controls.Add(this.inetredCbx);
            this.pnlCheckBoxes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlCheckBoxes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCheckBoxes.Location = new System.Drawing.Point(3, 108);
            this.pnlCheckBoxes.Name = "pnlCheckBoxes";
            this.pnlCheckBoxes.Size = new System.Drawing.Size(170, 144);
            this.pnlCheckBoxes.TabIndex = 7;
            this.cb_tooltip.SetToolTip(this.pnlCheckBoxes, "Use the checkboxes to indicate which lights are illuminated on the modem.");
            // 
            // pwrCbx
            // 
            this.pwrCbx.AutoSize = true;
            this.pwrCbx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pwrCbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pwrCbx.Location = new System.Drawing.Point(3, 8);
            this.pwrCbx.Name = "pwrCbx";
            this.pwrCbx.Size = new System.Drawing.Size(43, 16);
            this.pwrCbx.TabIndex = 7;
            this.pwrCbx.Tag = "Power";
            this.pwrCbx.Text = "PWR";
            this.pwrCbx.UseVisualStyleBackColor = true;
            // 
            // enetCbx
            // 
            this.enetCbx.AutoSize = true;
            this.enetCbx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enetCbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enetCbx.Location = new System.Drawing.Point(48, 8);
            this.enetCbx.Name = "enetCbx";
            this.enetCbx.Size = new System.Drawing.Size(70, 16);
            this.enetCbx.TabIndex = 8;
            this.enetCbx.Tag = "Ethernet";
            this.enetCbx.Text = "ETHERNET";
            this.enetCbx.UseVisualStyleBackColor = true;
            // 
            // activityChkbox
            // 
            this.activityChkbox.AutoSize = true;
            this.activityChkbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.activityChkbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activityChkbox.Location = new System.Drawing.Point(48, 30);
            this.activityChkbox.Name = "activityChkbox";
            this.activityChkbox.Size = new System.Drawing.Size(63, 16);
            this.activityChkbox.TabIndex = 10;
            this.activityChkbox.Tag = "Activity";
            this.activityChkbox.Text = "ACTIVITY";
            this.activityChkbox.UseVisualStyleBackColor = true;
            // 
            // notesViewText
            // 
            this.notesViewText.ContextMenuStrip = this.notesViewContext;
            this.notesViewText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.notesViewText.Location = new System.Drawing.Point(179, 3);
            this.notesViewText.Name = "notesViewText";
            this.layoutTable.SetRowSpan(this.notesViewText, 12);
            this.notesViewText.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.notesViewText.Size = new System.Drawing.Size(154, 572);
            this.notesViewText.TabIndex = 22;
            this.notesViewText.Text = "";
            // 
            // notesViewContext
            // 
            this.notesViewContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copy_context});
            this.notesViewContext.Name = "notes_view_context";
            this.notesViewContext.Size = new System.Drawing.Size(103, 26);
            // 
            // copy_context
            // 
            this.copy_context.Name = "copy_context";
            this.copy_context.Size = new System.Drawing.Size(102, 22);
            this.copy_context.Text = "Copy";
            this.copy_context.Click += new System.EventHandler(this.copy_context_Click);
            // 
            // custCbrText
            // 
            this.custCbrText.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.custCbrText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.custCbrText.Location = new System.Drawing.Point(3, 44);
            this.custCbrText.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.custCbrText.Mask = "999-000-0000";
            this.custCbrText.Name = "custCbrText";
            this.custCbrText.Size = new System.Drawing.Size(96, 20);
            this.custCbrText.TabIndex = 3;
            this.custCbrText.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.cb_tooltip.SetToolTip(this.custCbrText, "Use this textbox to input the customer\'s CBR. It will format it in a way that is " +
        "easy to read but will copy without the hyphens.");
            // 
            // custBtnText
            // 
            this.custBtnText.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.custBtnText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.custBtnText.Location = new System.Drawing.Point(3, 12);
            this.custBtnText.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.custBtnText.Mask = "999-000-0000";
            this.custBtnText.Name = "custBtnText";
            this.custBtnText.Size = new System.Drawing.Size(96, 20);
            this.custBtnText.TabIndex = 1;
            this.custBtnText.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.cb_tooltip.SetToolTip(this.custBtnText, "Use this textbox to input the customer\'s BTN. It will format it in a way that is " +
        "easy to read but will copy without the hyphens.");
            // 
            // copyBtn
            // 
            this.copyBtn.AutoSize = true;
            this.copyBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.copyBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyBtn.Location = new System.Drawing.Point(105, 0);
            this.copyBtn.Name = "copyBtn";
            this.copyBtn.Size = new System.Drawing.Size(68, 12);
            this.copyBtn.TabIndex = 41;
            this.copyBtn.TabStop = true;
            this.copyBtn.Text = "Copy BTN";
            this.cb_tooltip.SetToolTip(this.copyBtn, "You can click here to easily copy the BTN you typed in to clipboard for posting t" +
        "o web.");
            this.copyBtn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.copyBtn_LinkClicked);
            // 
            // toolStrip1
            // 
            this.toolStrip1.AllowItemReorder = true;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.frontierButton,
            this.faitpointFormButton,
            this.copied_status});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(336, 25);
            this.toolStrip1.TabIndex = 23;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // frontierButton
            // 
            this.frontierButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.frontierButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.outageToolStripMenuItem});
            this.frontierButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.frontierButton.Name = "frontierButton";
            this.frontierButton.Size = new System.Drawing.Size(61, 22);
            this.frontierButton.Text = "Frontier";
            this.frontierButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // outageToolStripMenuItem
            // 
            this.outageToolStripMenuItem.Name = "outageToolStripMenuItem";
            this.outageToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.outageToolStripMenuItem.Text = "Outage";
            this.outageToolStripMenuItem.Click += new System.EventHandler(this.outageToolStripMenuItem_Click);
            // 
            // faitpointFormButton
            // 
            this.faitpointFormButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.faitpointFormButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.faitpointFormButton.Name = "faitpointFormButton";
            this.faitpointFormButton.Size = new System.Drawing.Size(58, 22);
            this.faitpointFormButton.Text = "Fairpoint";
            this.faitpointFormButton.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // copied_status
            // 
            this.copied_status.Name = "copied_status";
            this.copied_status.Size = new System.Drawing.Size(0, 22);
            // 
            // noModemChkbox
            // 
            this.noModemChkbox.AutoSize = true;
            this.noModemChkbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.noModemChkbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.noModemChkbox.Font = new System.Drawing.Font("Vani", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noModemChkbox.Location = new System.Drawing.Point(102, 84);
            this.noModemChkbox.Margin = new System.Windows.Forms.Padding(0);
            this.noModemChkbox.Name = "noModemChkbox";
            this.noModemChkbox.Size = new System.Drawing.Size(74, 21);
            this.noModemChkbox.TabIndex = 6;
            this.noModemChkbox.Text = "Modem N/A";
            this.noModemChkbox.UseVisualStyleBackColor = true;
            this.noModemChkbox.CheckedChanged += new System.EventHandler(this.noModemChkbox_CheckedChanged);
            // 
            // tshootingLabel
            // 
            this.tshootingLabel.AutoSize = true;
            this.tshootingLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tshootingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tshootingLabel.Location = new System.Drawing.Point(3, 255);
            this.tshootingLabel.Name = "tshootingLabel";
            this.tshootingLabel.Size = new System.Drawing.Size(96, 12);
            this.tshootingLabel.TabIndex = 54;
            this.tshootingLabel.Text = "Troubleshooting";
            // 
            // layoutTable
            // 
            this.layoutTable.ColumnCount = 3;
            this.layoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 102F));
            this.layoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 74F));
            this.layoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.layoutTable.Controls.Add(this.label3, 0, 2);
            this.layoutTable.Controls.Add(this.custBtnText, 0, 1);
            this.layoutTable.Controls.Add(this.otherNotesText, 0, 10);
            this.layoutTable.Controls.Add(this.notesViewText, 2, 0);
            this.layoutTable.Controls.Add(this.pnlCheckBoxes, 0, 6);
            this.layoutTable.Controls.Add(this.tshootingLabel, 0, 7);
            this.layoutTable.Controls.Add(this.tShootText, 0, 8);
            this.layoutTable.Controls.Add(this.svcsOfferedText, 0, 9);
            this.layoutTable.Controls.Add(this.custModemText, 0, 5);
            this.layoutTable.Controls.Add(this.noModemChkbox, 1, 5);
            this.layoutTable.Controls.Add(this.cbrSameCbx, 1, 3);
            this.layoutTable.Controls.Add(this.copyBtn, 1, 0);
            this.layoutTable.Controls.Add(this.saveButton, 0, 11);
            this.layoutTable.Controls.Add(this.resetButton, 1, 11);
            this.layoutTable.Controls.Add(this.custNameText, 0, 4);
            this.layoutTable.Controls.Add(this.custCbrText, 0, 3);
            this.layoutTable.Controls.Add(this.label2, 0, 0);
            this.layoutTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutTable.Location = new System.Drawing.Point(0, 25);
            this.layoutTable.Margin = new System.Windows.Forms.Padding(0);
            this.layoutTable.Name = "layoutTable";
            this.layoutTable.RowCount = 11;
            this.layoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.layoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.layoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.layoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.layoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.layoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.layoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.layoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.layoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.layoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.layoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.layoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.layoutTable.Size = new System.Drawing.Size(336, 578);
            this.layoutTable.TabIndex = 56;
            // 
            // otherNotesText
            // 
            this.layoutTable.SetColumnSpan(this.otherNotesText, 2);
            this.otherNotesText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.otherNotesText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otherNotesText.Location = new System.Drawing.Point(3, 459);
            this.otherNotesText.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.otherNotesText.Multiline = true;
            this.otherNotesText.Name = "otherNotesText";
            this.otherNotesText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.otherNotesText.Size = new System.Drawing.Size(170, 95);
            this.otherNotesText.TabIndex = 19;
            this.otherNotesText.WaterMarkColor = System.Drawing.Color.Gray;
            this.otherNotesText.WaterMarkText = "Other Notes/Ticket Info";
            // 
            // tShootText
            // 
            this.tShootText.AcceptsReturn = true;
            this.tShootText.AcceptsTab = false;
            this.tShootText.BackColor = System.Drawing.Color.White;
            this.tShootText.ChangedColour = System.Drawing.Color.Empty;
            this.layoutTable.SetColumnSpan(this.tShootText, 2);
            this.tShootText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tShootText.ErrorProvider = null;
            this.tShootText.Location = new System.Drawing.Point(3, 267);
            this.tShootText.Mandatory = false;
            this.tShootText.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.tShootText.MaxLength = 0;
            this.tShootText.Name = "tShootText";
            this.tShootText.OriginalText = "";
            this.tShootText.Size = new System.Drawing.Size(170, 143);
            this.tShootText.SpellCheck = true;
            this.tShootText.TabIndex = 17;
            this.tShootText.TextCase = System.Windows.Forms.CharacterCasing.Normal;
            this.tShootText.TextType = NotesApp.ExtTextBox.TextTypes.String;
            this.tShootText.Wrapping = true;
            // 
            // svcsOfferedText
            // 
            this.layoutTable.SetColumnSpan(this.svcsOfferedText, 2);
            this.svcsOfferedText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.svcsOfferedText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.svcsOfferedText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.svcsOfferedText.Location = new System.Drawing.Point(3, 410);
            this.svcsOfferedText.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.svcsOfferedText.Multiline = true;
            this.svcsOfferedText.Name = "svcsOfferedText";
            this.svcsOfferedText.Size = new System.Drawing.Size(170, 49);
            this.svcsOfferedText.TabIndex = 18;
            this.svcsOfferedText.WaterMarkColor = System.Drawing.Color.Maroon;
            this.svcsOfferedText.WaterMarkText = "Services Sold";
            // 
            // custModemText
            // 
            this.custModemText.AutoCompleteCustomSource.AddRange(new string[] {
            "Gigaset SE567 ",
            "Speedstream 6520",
            "Speedstream 5200 ",
            "Speedstream 5260",
            "Speedstream 5667 ",
            "Speedstream 5861",
            "Speedstream 5930",
            "Siemens SX762",
            "Westell 6100 ",
            "Westell 6100F",
            "Westell 6110",
            "Westell 327W",
            "Westell 7500 ",
            "Netgear 7550 ",
            "Westell 9100 ",
            "Actiontec GT701C ",
            "Actiontec GT704",
            "Actiontec MI424WR ",
            "Westell 2100 ",
            "Westell 2200 ",
            "Westell 516",
            "HT1000 Satellite Modem ",
            "3Com Dual-Link ",
            "3Com Dual-Link ",
            "3Com 812 Router ",
            "3Com 812 Router (Business Class)",
            "D-Link 100D ",
            "D-Link 500 (1 Port) ",
            "D-Link 504 (4 Ports)",
            "D-Link DSB-650 TX USB NIC",
            "Alcatel Router ",
            "Cisco 677",
            "Arescom DSL Modem ",
            "Best Data AR 520 ",
            "Best Data DSL600EU ",
            "Best Data DSL502EU ",
            "Best Data 500EU ",
            "Best Data 800E ",
            "ClearAccess EG10W - Fiber ",
            "ClearAccess AG10 - Wired ",
            "ClearAccess AG10W - Wireless",
            "Conexant ADSL 2/2+ (EA142) ",
            "Conexant XDSL2+ 4-port Router EA143 ",
            "Diamond SupraMax DSL642WLG ",
            "Diamond SupraMax DSL642WLGV2 ",
            "SMC ADSL Barricade G - SMC7904WBRA ",
            "SMC Networks ADSL Barricade G - SMC7904WBRA2 ",
            "Linksys BEFSR11",
            "ActionTec V1000W",
            "Zyxel P663",
            "Zyxel P-870HN",
            "Comtrend 5631",
            "Comtrend 5381",
            "Comtrend 5072",
            "Actiontec R1408",
            "DLink VDI-624",
            "DLink VDI-604",
            "Cisco Linksys E1000",
            "Cisco Linksys E1200",
            "Cisco DPQ3212 ",
            "Cisco DPC3010",
            "Engenius ESR1221 ",
            "Motorola Surfboard SB4100 ",
            "Webstar DPC2100",
            "Webstar DPX100 ",
            "Netgear N600 (WNDR3800) "});
            this.custModemText.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.custModemText.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.custModemText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.custModemText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custModemText.Location = new System.Drawing.Point(3, 84);
            this.custModemText.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.custModemText.Name = "custModemText";
            this.custModemText.Size = new System.Drawing.Size(96, 20);
            this.custModemText.TabIndex = 5;
            this.custModemText.WaterMarkColor = System.Drawing.Color.Gray;
            this.custModemText.WaterMarkText = "Modem Model";
            // 
            // custNameText
            // 
            this.custNameText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.custNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custNameText.Location = new System.Drawing.Point(3, 64);
            this.custNameText.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.custNameText.Name = "custNameText";
            this.custNameText.Size = new System.Drawing.Size(96, 20);
            this.custNameText.TabIndex = 4;
            this.custNameText.WaterMarkColor = System.Drawing.Color.Gray;
            this.custNameText.WaterMarkText = "Customer\'s Name";
            // 
            // notesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(336, 603);
            this.CloseButton = false;
            this.CloseButtonVisible = false;
            this.Controls.Add(this.layoutTable);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HideOnClose = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "notesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.TabText = "Notes";
            this.Text = "Notes";
            this.TransparencyKey = System.Drawing.Color.GreenYellow;
            this.pnlCheckBoxes.ResumeLayout(false);
            this.pnlCheckBoxes.PerformLayout();
            this.notesViewContext.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.layoutTable.ResumeLayout(false);
            this.layoutTable.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button resetButton;
        public System.Windows.Forms.CheckBox dslblinkCbx;
        public System.Windows.Forms.CheckBox inetredCbx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.CheckBox cbrSameCbx;
        public System.Windows.Forms.CheckBox e1Cbx;
        public System.Windows.Forms.CheckBox e2Cbx;
        public System.Windows.Forms.CheckBox e3Cbx;
        public System.Windows.Forms.CheckBox e4Cbx;
        public System.Windows.Forms.CheckBox wlanCbx;
        public System.Windows.Forms.CheckBox dslCbx;
        public System.Windows.Forms.CheckBox inetCbx;
        public System.Windows.Forms.Panel pnlCheckBoxes;
        public System.Windows.Forms.CheckBox enetCbx;
        public System.Windows.Forms.CheckBox pwrCbx;
        public System.Windows.Forms.RichTextBox notesViewText;
        private System.Windows.Forms.ContextMenuStrip notesViewContext;
        private System.Windows.Forms.ToolStripMenuItem copy_context;
        private System.Windows.Forms.ToolTip cb_tooltip;
        private System.Windows.Forms.ToolTip cbrTooltip;
        public System.Windows.Forms.MaskedTextBox custCbrText;
        public wmgCMS.WaterMarkTextBox custNameText;
        public wmgCMS.WaterMarkTextBox custModemText;
        public wmgCMS.WaterMarkTextBox svcsOfferedText;
        public wmgCMS.WaterMarkTextBox otherNotesText;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton faitpointFormButton;
        private System.Windows.Forms.CheckBox noModemChkbox;
        private System.Windows.Forms.CheckBox activityChkbox;
        private System.Windows.Forms.ToolStripDropDownButton frontierButton;
        private System.Windows.Forms.Label tshootingLabel;
        public ExtTextBox tShootText;
        private System.Windows.Forms.ToolStripMenuItem outageToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel layoutTable;
        public System.Windows.Forms.MaskedTextBox custBtnText;
        private System.Windows.Forms.ToolStripLabel copied_status;
        private System.Windows.Forms.LinkLabel copyBtn;
    }
}

