namespace SpatialGames
{
    public class Split
    {
        public int xCoor {get; set;}
        public int yCoor{get; set;}
        public int Score {get; set;}

        public Split(int x,int y,int score)
        {
            xCoor = x;
            yCoor = y;
            Score = score;
        }

        //Player Super Class
        //

        // public void Adjacency()
        // {

        //     for (int i = 0; i < 2; i++)
        //     {
        //         for (int j = 0; j < 2; j++)
        //         {
        //             if(i == 2 && j == 2)
        //             {
        //                 break;
        //             }
        //             else if(//adj is Split)
        //             {
        //                 Score = Score + 1;
        //             }
        //             else if(//adj is Steal)
        //             {
        //                 Score = Score - 1;
        //             }
        //             else if(//adj is TitForTat)
        //             {
        //                 //
        //             }
                    
        //         }
        //     }
        // }

        
    }
}