using PickRandomCards;

Console.Write("Wpisz liczbę generowanych kart: ");
string line = Console.ReadLine();

if (int.TryParse(line, out int numberOfCards))
{
    string[] cards = CardPicker.PickSomeCards(numberOfCards);

    foreach (string card in cards)
    {
        Console.WriteLine(card);
    }

}
else
{
    Console.WriteLine("Wpisz prawidłową liczbę");
}