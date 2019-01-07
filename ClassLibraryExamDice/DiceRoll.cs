using System;

namespace ClassLibraryExamDice
{
    public class DiceRoll
    {
        Random rnd = new Random();

        public int Id { get; set; }
        public string Name { get; set; }
        public int Number { get; set; }
        public int Guess { get; set; }
        public int Result { get; set; }

        public DiceRoll(int id, string name, int number, int guess, int result)
        {
            Id = id;
            Name = name;
            Number = number;
            Guess = guess;
            Result = result;
        }
             
        public DiceRoll()
        {

        }

        public int ResultMethod(int guess, int number)
        {
            int result = 0;
            if (number == 1)
            {
                result = rnd.Next(1, 7);
            }
            if (number == 2)
            {
                result = rnd.Next(1, 7) + rnd.Next(1,7);
            }
            return result;
        }


        public override string ToString()
        {
            return Id + Name + Number + Guess + Result;
        }
    }
}
