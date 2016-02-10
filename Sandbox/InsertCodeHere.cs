using System;

namespace Sandbox
{
    class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            // 2.a
            Status myFirstStatus = new Status("This is my first status!");

            //2.b
            Console.WriteLine("{0} has {1} likes and {2} dislikes. It has been read {3} times", myFirstStatus.GetStatusText(),myFirstStatus.GetNoOfLikes(), myFirstStatus.GetNoOfDislikes(), myFirstStatus.GetNumberOfReads());

            myFirstStatus.AddOneLike();
            myFirstStatus.AddOneLike();
            myFirstStatus.AddOneLike();
            myFirstStatus.AddOneLike();
            myFirstStatus.AddOneLike();
            myFirstStatus.AddOneLike();
            myFirstStatus.AddOneLike();
            myFirstStatus.AddOneLike();
            myFirstStatus.AddOneLike();
            myFirstStatus.AddOneLike();

            myFirstStatus.AddReadCount();
            myFirstStatus.AddReadCount();
            myFirstStatus.AddReadCount();
            myFirstStatus.AddReadCount();
            myFirstStatus.AddReadCount();
            myFirstStatus.AddReadCount();

            myFirstStatus.AddOneDislike();

            Console.WriteLine();
            Console.WriteLine("{0} now has {1} likes and {2} dislikes. It has been read {3} times", myFirstStatus.GetStatusText(), myFirstStatus.GetNoOfLikes(), myFirstStatus.GetNoOfDislikes(), myFirstStatus.GetNumberOfReads());

            myFirstStatus.ReadStatusMultiple(400);

            Console.WriteLine();
            Console.WriteLine("{0} now has {1} likes and {2} dislikes. It has been read {3} times", myFirstStatus.GetStatusText(), myFirstStatus.GetNoOfLikes(), myFirstStatus.GetNoOfDislikes(), myFirstStatus.GetNumberOfReads());
            // The LAST line of code should be ABOVE this line
        }
    }
}
