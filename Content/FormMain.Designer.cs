namespace Content;

partial class FormMain
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
        panelUserCards = new Panel();
        userCard1 = new CustomControls.UserCard();
        panelUserCards.SuspendLayout();
        SuspendLayout();
        // 
        // panelUserCards
        // 
        panelUserCards.Controls.Add(userCard1);
        panelUserCards.Dock = DockStyle.Fill;
        panelUserCards.Location = new Point(0, 0);
        panelUserCards.Name = "panelUserCards";
        panelUserCards.Size = new Size(882, 533);
        panelUserCards.TabIndex = 0;
        // 
        // userCard1
        // 
        userCard1.BorderStyle = BorderStyle.FixedSingle;
        userCard1.Location = new Point(3, 3);
        userCard1.Name = "userCard1";
        userCard1.Size = new Size(521, 191);
        userCard1.TabIndex = 0;
        // 
        // FormMain
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(882, 533);
        Controls.Add(panelUserCards);
        MinimumSize = new Size(900, 580);
        Name = "FormMain";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Main";
        Load += FormMain_Load;
        panelUserCards.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private Panel panelUserCards;
    private CustomControls.UserCard userCard1;
}
