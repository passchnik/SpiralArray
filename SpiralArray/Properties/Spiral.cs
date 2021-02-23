using System;
using System.Threading;

namespace SpiralArray
{
    public class Spiral
    {
        private int[,] _Arrey;
        private int maxI;
        private int maxJ;
        private int speed;

        public Spiral(int[,] arrey, int speed)
        {
            _Arrey = arrey;
            maxI = _Arrey.GetUpperBound(0) + 1;
            maxJ = _Arrey.Length / maxI;
            this.speed = speed;
            
            Controller();
        }

        //ONE METHOD TO RULE THEM ALL
        private void Controller()
        {
            ArreyFillingStart();
            Console.Clear();
            ArreyProcessing();
        }

        // primary values
        private void ArreyFillingStart()
        {
            for (int i = 0; i < maxI; i++)
            {
                for (int j = 0; j < maxJ; j++)
                {
                    _Arrey[i,j] = 0;
                }
            }
        }

        // outputing new image with pouse
        private void ArreyOutPut()
        {
            
            for (int i = 0; i < maxI; i++)
            {
                for (int j = 0; j < maxJ; j++)
                {
                    int temp = _Arrey[i, j];

                    if (temp != 0)
                    {
                        Console.Write($"{temp}\t");

                    }
                    else
                    {
                        Console.Write("\t");
                    }

                }
                Console.WriteLine();
            }
            
        }



        private void ArreyProcessing()
        {
            //like a real compass with directions
            //e - east
            //s - south
            //o - west
            //n - north
            char compass = 'e'; 

            int currentI = 0;
            int currentJ = 0;

            for (int i = 0; i < _Arrey.Length; i++)
            {
                int temp = i + 1;
                if (compass == 'e')
                {
                    
                    if (currentJ + 1 == maxJ)
                    {
                        _Arrey[currentI, currentJ] = temp;
                        compass = 's';
                        currentI++;

                    }
                    else if (_Arrey[currentI, currentJ + 1] != 0)  
                    {
                        _Arrey[currentI, currentJ] = temp;
                        compass = 's';
                        currentI++;
                    }
                    else
                    {
                        _Arrey[currentI, currentJ] = temp;
                        currentJ++;
                    }
                    Final();
                    continue;
                }

                if (compass == 's')
                {
                    if (currentI + 1 == maxI)
                    {
                        _Arrey[currentI, currentJ] = temp;
                        compass = 'w';
                        currentJ--;

                    } else if (_Arrey[currentI + 1, currentJ] != 0)
                    {
                        _Arrey[currentI, currentJ] = temp;
                        compass = 'w';
                        currentJ--;
                    }
                    else
                    {
                        _Arrey[currentI, currentJ] = temp;
                        currentI++;
                    }
                    Final();
                    continue;
                }

                if (compass == 'w')
                {
                    if (currentJ == 0)
                    {
                        _Arrey[currentI, currentJ] = temp;
                        compass = 'n';
                        currentI--;
                    } else if (_Arrey[currentI, currentJ - 1] != 0)
                    {
                        _Arrey[currentI, currentJ] = temp;
                        compass = 'n';
                        currentI--;
                    }
                    else
                    {
                        _Arrey[currentI, currentJ] = temp;
                        currentJ--;
                    }
                    Final();
                    continue;
                }

                if (compass == 'n')
                {
                    if (_Arrey[currentI -1, currentJ] != 0)
                    {
                        _Arrey[currentI, currentJ] = temp;
                        compass = 'e';
                        currentJ++;
                    }
                    else
                    {
                        _Arrey[currentI, currentJ] = temp;
                        currentI--;
                    }
                    Final();
                    continue;
                }
                  

                
            }
        }

        //trash from ArreyProcessing
        //call print fun and cleaning screen
        private void Final()
        {
            Console.SetCursorPosition(0, 0);
            ArreyOutPut();
            Thread.Sleep(speed);
        }

        
    }
}
