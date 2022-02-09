using System;

namespace Question5
{
    class Program
    {
        static void Main(string[] args)
        {
            static bool inside(int x, int y, int x1,  int y1, int x2, int y2)
            {
                if (x > x1 && x < x2 && y > y1 && y < y2){
                    return true;
                         }else{
                            return false;
            }

       
    }
            Console.Write(inside(1,1,0,0,2,3));
            Console.Write("\n");
            Console.Write(inside(-1,-1,0,0,2,3));

            

}
    }
    }
