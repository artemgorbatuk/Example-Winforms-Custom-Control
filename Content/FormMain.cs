using CustomControls;
using Domain;

namespace Content;

public partial class FormMain : Form
{
    public FormMain()
    {
        InitializeComponent();
    }

    private void FormMain_Load(object sender, EventArgs e)
    {
        var users = new[] {
            new UserModel() { Name = "Name1", Sex = "Man", Age = 20, Married = true },
            new UserModel() { Name = "Name2", Sex = "Woman", Age = 23, Married = true },
            new UserModel() { Name = "Name3", Sex = "Man", Age = 32, Married = false },
        }.ToList();
        
        panelUserCards.Controls.Clear();

        foreach (var user in users) {

            var userCard = new UserCard();

            var index = users.IndexOf(user);

            userCard.CreateUser(user, index);


            userCard.CheckBoxMarriedChanged += (obj, args) =>
            {
                var married = (obj as UserCard)?.Married ?? false;

                ShowChanges(married);
            };

            panelUserCards.Controls.Add(userCard);      
        }
    }

    private void ShowChanges(bool married)
    {
        MessageBox.Show($"married: {married}");
    }
}
