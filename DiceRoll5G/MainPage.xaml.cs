namespace DiceRoll5G
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent();
        }

        private void DiceRoll(object sender, EventArgs e)
        {
            //tablica zawierająca 5 liczb całkowitych - wyników rzutu kośćmi
            int[] dice = new int[5];
            //obiekt generatora liczb losowych
            Random r = new Random();
            //losujemy rzuty kośćmi
            for (int i = 0; i < 5; i++)
            {
                //losowanie liczby z zakresu 1-6
                dice[i] = r.Next(1, 7);
            }
            //wyświetlenie wyników rzutu kośćmi
            Dice0.Source = "k6_" + dice[0] + ".png";
            Dice1.Source = "k6_" + dice[1] + ".png";
            Dice2.Source = "k6_" + dice[2] + ".png";
            Dice3.Source = "k6_" + dice[3] + ".png";
            Dice4.Source = "k6_" + dice[4] + ".png";
        }

        private void ResetGame(object sender, EventArgs e)
        {
            Dice0.Source = "k6_0.png";
            Dice1.Source = "k6_0.png";
            Dice2.Source = "k6_0.png";
            Dice3.Source = "k6_0.png";
            Dice4.Source = "k6_0.png";
        }
    }

}
