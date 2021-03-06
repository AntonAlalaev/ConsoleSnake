﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.SetBufferSize( 80, 24);
            Console.SetWindowSize(80,25);
            //HorizontalLine upLine = new HorizontalLine(0, 78, 0, '+');
            //Draw(upLine);
            //HorizontalLine downLine = new HorizontalLine(0, 78, 24, '+');
            //Draw(downLine);

            //VerticalLine leftLine = new VerticalLine(0, 24, 0, '+');
            //VerticalLine rightLine = new VerticalLine(0, 24, 78, '+');
            //Draw(leftLine);
            //Draw(rightLine);
            Walls walls = new Walls(80, 25);
            walls.Draw();

            Point p = new Point(4, 5, '*');
            Figure fSnake = new Snake(p, 4, Direction.RIGHT);
            Draw(fSnake);
            Snake snake = (Snake)fSnake;

            FoodCreator foodCreator = new FoodCreator(78, 24, '$');
            Point food = foodCreator.CreateFood();
            food.Draw();
            while (true)
            {
                if (walls.IsHit(snake) || snake.IsHitTail())
                {
                    break;
                }
                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                else
                {
                    snake.Move();
                }
                Thread.Sleep(100);

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
            }
            //Console.ReadKey();
        }

        static void Draw(Figure figure)
        {
            figure.Draw();
        }

    }
}
