using TRADER.Modeles;

namespace TRADERv2
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
            Trader traderAlice = new Trader("Alice", "Liddell", new DateTime(1992, 01, 01), "féminin", "alice@example.com",1234567890);
            Trader traderBob = new Trader("Bob", "Marley", new DateTime(1985, 05, 11), "maculin", "bob@example.com", 0987654321);

            Actionn actionApple = new Actionn("Apple", "US0378331005", 150);
            Actionn actionMicrosoft = new Actionn("Microsoft", "US5949181045", 200);

            CoursAction coursActionA1 = new CoursAction(new DateTime(2023, 10, 25), 148);
            CoursAction coursActionA2 = new CoursAction(new DateTime(2023, 10, 26), 149);
            CoursAction coursActionA3 = new CoursAction(new DateTime(2023, 10, 27), 150);
            CoursAction coursActionA4 = new CoursAction(new DateTime(2023, 10, 28), 151);
            CoursAction coursActionA5 = new CoursAction(new DateTime(2023, 10, 29), 152);

            CoursAction coursActionM1 = new CoursAction(new DateTime(2023, 10, 25), 198);
            CoursAction coursActionM2 = new CoursAction(new DateTime(2023, 10, 26), 199);
            CoursAction coursActionM3 = new CoursAction(new DateTime(2023, 10, 27), 200);
            CoursAction coursActionM4 = new CoursAction(new DateTime(2023, 10, 28), 201);
            CoursAction coursActionM5 = new CoursAction(new DateTime(2023, 10, 29), 202);

            Transaction transactionAlice = new Transaction("Liddell", "Apple", 10, 152, new DateTime(2023, 10, 29));
            Transaction transactionBob = new Transaction("Marley", "Microsoft", -5, 202, new DateTime(2023, 10, 29));
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }
}