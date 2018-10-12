namespace AppontmentManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.ElipseForm = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.DragForm = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblClose = new System.Windows.Forms.Label();
            this.ddCalendar = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTitle = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtDetails = new System.Windows.Forms.RichTextBox();
            this.btnSave = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ElipseForm
            // 
            this.ElipseForm.ElipseRadius = 5;
            this.ElipseForm.TargetControl = this;
            // 
            // DragForm
            // 
            this.DragForm.Fixed = true;
            this.DragForm.Horizontal = true;
            this.DragForm.TargetControl = this;
            this.DragForm.Vertical = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.txtDetails);
            this.panel1.Controls.Add(this.txtTitle);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ddCalendar);
            this.panel1.Location = new System.Drawing.Point(0, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(704, 322);
            this.panel1.TabIndex = 0;
            // 
            // lblClose
            // 
            this.lblClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblClose.AutoSize = true;
            this.lblClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblClose.Location = new System.Drawing.Point(684, 4);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(20, 22);
            this.lblClose.TabIndex = 1;
            this.lblClose.Text = "X";
            // 
            // ddCalendar
            // 
            this.ddCalendar.BackColor = System.Drawing.Color.MistyRose;
            this.ddCalendar.BorderRadius = 1;
            this.ddCalendar.CalendarMonthBackground = System.Drawing.Color.MistyRose;
            this.ddCalendar.CalendarTitleBackColor = System.Drawing.Color.LightCoral;
            this.ddCalendar.Color = System.Drawing.Color.Firebrick;
            this.ddCalendar.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thick;
            this.ddCalendar.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.ddCalendar.DisabledColor = System.Drawing.Color.Gray;
            this.ddCalendar.DisplayWeekNumbers = false;
            this.ddCalendar.DPHeight = 0;
            this.ddCalendar.FillDatePicker = false;
            this.ddCalendar.ForeColor = System.Drawing.Color.Firebrick;
            this.ddCalendar.Icon = ((System.Drawing.Image)(resources.GetObject("ddCalendar.Icon")));
            this.ddCalendar.IconColor = System.Drawing.Color.Firebrick;
            this.ddCalendar.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.ddCalendar.Location = new System.Drawing.Point(11, 41);
            this.ddCalendar.MinimumSize = new System.Drawing.Size(315, 32);
            this.ddCalendar.Name = "ddCalendar";
            this.ddCalendar.Size = new System.Drawing.Size(315, 32);
            this.ddCalendar.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Choose a day to set your appointment";
            // 
            // txtTitle
            // 
            this.txtTitle.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtTitle.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtTitle.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTitle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtTitle.ForeColor = System.Drawing.Color.Red;
            this.txtTitle.HintForeColor = System.Drawing.Color.Silver;
            this.txtTitle.HintText = "What appointment do you have?";
            this.txtTitle.isPassword = false;
            this.txtTitle.LineFocusedColor = System.Drawing.Color.DarkRed;
            this.txtTitle.LineIdleColor = System.Drawing.Color.DarkRed;
            this.txtTitle.LineMouseHoverColor = System.Drawing.Color.Firebrick;
            this.txtTitle.LineThickness = 3;
            this.txtTitle.Location = new System.Drawing.Point(11, 97);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(4);
            this.txtTitle.MaxLength = 32767;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(663, 33);
            this.txtTitle.TabIndex = 3;
            this.txtTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtDetails
            // 
            this.txtDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.txtDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDetails.ForeColor = System.Drawing.Color.Red;
            this.txtDetails.Location = new System.Drawing.Point(15, 147);
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.Size = new System.Drawing.Size(659, 96);
            this.txtDetails.TabIndex = 4;
            this.txtDetails.Text = "Write your appointment details here";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.ButtonText = "Save Appointment";
            this.btnSave.ButtonTextMarginLeft = 0;
            this.btnSave.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnSave.DisabledFillColor = System.Drawing.Color.Gray;
            this.btnSave.DisabledForecolor = System.Drawing.Color.White;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnSave.IconPadding = 10;
            this.btnSave.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnSave.IdleBorderColor = System.Drawing.Color.Firebrick;
            this.btnSave.IdleBorderRadius = 1;
            this.btnSave.IdleBorderThickness = 0;
            this.btnSave.IdleFillColor = System.Drawing.Color.Firebrick;
            this.btnSave.IdleIconLeftImage = null;
            this.btnSave.IdleIconRightImage = null;
            this.btnSave.Location = new System.Drawing.Point(522, 249);
            this.btnSave.Name = "btnSave";
            stateProperties1.BorderColor = System.Drawing.Color.Red;
            stateProperties1.BorderRadius = 1;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.Red;
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.btnSave.onHoverState = stateProperties1;
            this.btnSave.Size = new System.Drawing.Size(152, 45);
            this.btnSave.TabIndex = 5;
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(707, 354);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse ElipseForm;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuDragControl DragForm;
        private Bunifu.UI.WinForms.BunifuDatePicker ddCalendar;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnSave;
        private System.Windows.Forms.RichTextBox txtDetails;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtTitle;
        private System.Windows.Forms.Label label1;
    }
}

