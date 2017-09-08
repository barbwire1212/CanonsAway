using System;

namespace CannonsAway
{
    public class FireClass
    {
        public int rnd;
        public int counter = 6;





        public Single Shots(int txt1, int txt2)
        {
            Single Num1, Num2, Answer;
            //pass the number from the text box to the variables;
            Num1 = Convert.ToSingle(txt1);
            Num2 = Convert.ToSingle(txt2);

            //run the calculation
            Answer = Num1 * Num2;

            //pass the answer to the label and the listbox
            return Answer;
        }
        public int Canon()
        {
            //creates a new instance of the random class
            Random random = new Random(DateTime.Now.Millisecond);
            // Represents random numbers between 0 and 7
            int RndCanonShot = random.Next(1, 7);
            //send the number back to the program
            return RndCanonShot;

        }
            

            
        
        
    }
         
    
}
