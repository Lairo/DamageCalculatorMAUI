﻿namespace DamageCalculatorMAUI
{
    public partial class MainPage : ContentPage
    {
        SwordDamage swordDamage = new();

        public MainPage()
        {
            InitializeComponent();
            RollDice();
            swordDamage.SetFlaming(Flaming.IsChecked);
            swordDamage.SetMagic(Magic.IsChecked);
        }

        private void RollDice()
        {
            swordDamage.Roll = Random.Shared.Next(1, 7) + Random.Shared.Next(1, 7) +
                Random.Shared.Next(1, 7);
            DisplayDamage();
        }

        private void DisplayDamage()
        {
            Damage.Text = $"Rolled {swordDamage.Roll} for {swordDamage.Damage} HP";
        }

        private void Flaming_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            swordDamage.SetFlaming(e.Value);
            DisplayDamage();
        }

        private void Magic_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            swordDamage.SetMagic(e.Value);
            DisplayDamage();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            RollDice();
        }
    }

}
