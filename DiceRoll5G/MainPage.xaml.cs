namespace DiceRoll5G
{
    public partial class MainPage : ContentPage
    {
        //wynik gry
        int gameResult = 0;

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
            //policz całkowity wynik rzutu
            //deklaruj zmienną przechowująca wynik rzutu
            int rollResult = 0;
            //ile jest kości o danej ilości oczek
            for(int dots = 1; dots <= 6; dots++)
            {
                //iterujemy przez ilość kości
                //pierwszy przebieg sprawdz ile jest jedynek
                //drugi ile jest dwójek itd.

                //definiujemy sobie licznik kości o 
                //zadanej ilości oczek
                int count = 0; //na początek zero kości
                //drugą pętlą iterujemy przez tablicę z wynikami
                for(int diceIndex = 0; diceIndex < 5; diceIndex++)
                {
                    //zliczamy kości o danej ilości oczek
                    //jeżeli wartość w tablicy dice jest równa ilości 
                    //oczek której szukamy
                    if (dice[diceIndex] == dots)
                    {
                        //inkrementuj licznik
                        count++;
                    }
                }
                //wiemy już ile jest kości o danej ilości oczek
                //tylko dla tych których jest więcej niż 1
                if(count > 1)
                {
                    //wynik to ilość oczek * ilość kości
                    rollResult += dots * count;
                }
            }
            //wyświetl wynik rzutu
            RollResultLabel.Text = "Wynik tego losowania: " + rollResult;
            //dodaj wynik rzutu do wyniku całej gry
            gameResult += rollResult;
            //wyświetl wynik całej gry
            GameResultLabel.Text = "Wynik gry: " + gameResult;
        }
        /* Funkcja ResetGame
         * Funkcja resetuje interfejs gry i punktacje do stanu początkowego
         * Parametry: sender - obiekt wywołujący zdarzenie
         *            e - argumenty zdarzenia
         * Autor: 00000000000
         */
        private void ResetGame(object sender, EventArgs e)
        {
            //przywróć wygląd kości do startowego
            Dice0.Source = "k6_0.png";
            Dice1.Source = "k6_0.png";
            Dice2.Source = "k6_0.png";
            Dice3.Source = "k6_0.png";
            Dice4.Source = "k6_0.png";

            gameResult = 0;
            RollResultLabel.Text = "Wynik tego losowania: 0";
            GameResultLabel.Text = "Wynik gry: " + gameResult;
        }
    }

}
