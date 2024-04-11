using Domain;

namespace CustomControls;
public partial class UserCard : UserControl
{
    public bool Married { get; set; }

    public UserCard()
    {
        InitializeComponent();
    }

    public void CreateUser(UserModel user, int index)
    {
        Location = new Point(5, 5 * index + Size.Height * index);

        textBoxName.Text = user.Name;
        textBoxSex.Text = user.Sex;
        textBoxAge.Text = user.Age.ToString();
        checkBoxMarried.Checked = user.Married;
    }

    private void UserCard_Load(object sender, EventArgs e)
    {
        Size = new Size(Width, Height);
        BorderStyle = BorderStyle.FixedSingle;
    }

    public event EventHandler CheckBoxMarriedChanged;

    private void checkBoxMarried_CheckedChanged(object sender, EventArgs e)
    {
        Married = (sender as CheckBox)?.CheckState == CheckState.Checked;
        CheckBoxMarriedChanged?.Invoke(this, e);
    }
}
