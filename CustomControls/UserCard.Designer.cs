namespace CustomControls;

partial class UserCard
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
        pictureBoxUserPic = new PictureBox();
        labelName = new Label();
        textBoxName = new TextBox();
        textBoxAge = new TextBox();
        labelAge = new Label();
        textBoxSex = new TextBox();
        label1 = new Label();
        checkBoxMarried = new CheckBox();
        ((System.ComponentModel.ISupportInitialize)pictureBoxUserPic).BeginInit();
        SuspendLayout();
        // 
        // pictureBoxUserPic
        // 
        pictureBoxUserPic.BorderStyle = BorderStyle.FixedSingle;
        pictureBoxUserPic.Location = new Point(23, 16);
        pictureBoxUserPic.Name = "pictureBoxUserPic";
        pictureBoxUserPic.Size = new Size(120, 140);
        pictureBoxUserPic.TabIndex = 0;
        pictureBoxUserPic.TabStop = false;
        // 
        // labelName
        // 
        labelName.AutoSize = true;
        labelName.Location = new Point(161, 19);
        labelName.Name = "labelName";
        labelName.Size = new Size(66, 20);
        labelName.TabIndex = 1;
        labelName.Text = "<name>";
        // 
        // textBoxName
        // 
        textBoxName.Location = new Point(233, 16);
        textBoxName.Name = "textBoxName";
        textBoxName.ReadOnly = true;
        textBoxName.Size = new Size(200, 27);
        textBoxName.TabIndex = 2;
        // 
        // textBoxAge
        // 
        textBoxAge.Location = new Point(233, 82);
        textBoxAge.Name = "textBoxAge";
        textBoxAge.ReadOnly = true;
        textBoxAge.Size = new Size(200, 27);
        textBoxAge.TabIndex = 4;
        // 
        // labelAge
        // 
        labelAge.AutoSize = true;
        labelAge.Location = new Point(161, 85);
        labelAge.Name = "labelAge";
        labelAge.Size = new Size(54, 20);
        labelAge.TabIndex = 3;
        labelAge.Text = "<age>";
        // 
        // textBoxSex
        // 
        textBoxSex.Location = new Point(233, 49);
        textBoxSex.Name = "textBoxSex";
        textBoxSex.ReadOnly = true;
        textBoxSex.Size = new Size(200, 27);
        textBoxSex.TabIndex = 6;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(161, 52);
        label1.Name = "label1";
        label1.Size = new Size(50, 20);
        label1.TabIndex = 5;
        label1.Text = "<sex>";
        // 
        // checkBoxMarried
        // 
        checkBoxMarried.AutoSize = true;
        checkBoxMarried.CheckAlign = ContentAlignment.MiddleRight;
        checkBoxMarried.Location = new Point(161, 115);
        checkBoxMarried.Name = "checkBoxMarried";
        checkBoxMarried.Size = new Size(103, 24);
        checkBoxMarried.TabIndex = 7;
        checkBoxMarried.Text = "<married>";
        checkBoxMarried.UseVisualStyleBackColor = true;
        checkBoxMarried.CheckedChanged += checkBoxMarried_CheckedChanged;
        // 
        // UserCard
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(checkBoxMarried);
        Controls.Add(textBoxSex);
        Controls.Add(label1);
        Controls.Add(textBoxAge);
        Controls.Add(labelAge);
        Controls.Add(textBoxName);
        Controls.Add(labelName);
        Controls.Add(pictureBoxUserPic);
        Name = "UserCard";
        Size = new Size(458, 173);
        Load += UserCard_Load;
        ((System.ComponentModel.ISupportInitialize)pictureBoxUserPic).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private PictureBox pictureBoxUserPic;
    private Label labelName;
    private TextBox textBoxName;
    private TextBox textBoxAge;
    private Label labelAge;
    private TextBox textBoxSex;
    private Label label1;
    private CheckBox checkBoxMarried;
}
