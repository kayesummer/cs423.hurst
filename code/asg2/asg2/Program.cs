// See https://aka.ms/new-console-template for more information
// CITE: https://www.chegg.com/homework-help/questions-and-answers/suppose-robot-turtle-walks-around-room-control-computer-program-turtle-holds-pen-one-two-p-q7857423

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
namespace TurtleCode
{
     class Code
     {
          static void Main(string[] args)
          {
               try
               {
                    doTask();
               }
               catch (Exception Except)
               {
                    Console.WriteLine(Except.Message);
               }
          }
          public static void doTask()
          {
               #region DEFINITION
               TurtleClass person = new TurtleClass('E', 0, 0, true);
               int[,] ground = new int[25, 25];
               #region FOR INITIALIZATION
               for (int a = 0; a < ground.GetLength(0); a++)
               {
                    for (int b = 0; b < ground.GetLength(1); b++)
                    {
                         ground[a, b] = 0;
                    }
               }
               #endregion
# endregion
               Console.Clear();
               person.Display(ground);

               TurtleClass.menus(person, ground);
          }
     }
}
namespace TurtleCode
{
     class TurtleClass
     {
          private char directions;
          public char Directions
          {
               get
               {
                    return directions;
               }
               set
               {
                    directions = value;
               }
          }
          private int m;
          public int M
          {
               get
               {
                    return m;
               }
               set
               {
                    if (m > 19)
                         value = 19;
                    else
                         value = m;
               }
          }
          private int n;
          public int N
          {
               get
               {
                    return n;
               }
               set
               {
                    if (n > 19)
                         value = 19;
                    else
                         value = n;
               }
          }
          private bool tpen;
          public bool Tpen
          {
               get
               {
                    return tpen;
               }
               set
               {
                    tpen = value;
               }
          }
          public TurtleClass(char directions, int m, int n, bool tpen)
          {
               this.directions = directions;
               this.m = m;
               this.n = n;
               this.tpen = tpen;
          }
          public void UpPen()
          {
               tpen = false;
          }
          public void DownPen()
          {
               tpen = true;
          }
          public void RightTurn(int[,] ground)
          {
               #region DIRECTIONS
               switch (directions)
               {
                    case 'N':
                         directions = 'E';
                         break;
                    case 'S':
                         directions = 'W';
                         break;
                    case 'E':
                         directions = 'S';
                         break;
                    case 'W':
                         directions = 'N';
                         break;
                    default:
                         break;
               }
               #endregion
          }
          public void LeftTurn(int[,] ground)
          {
               #region DIRECTIONS
               switch (Directions)
               {
                    case 'N':
                         directions = 'W';
                         break;
                    case 'S':
                         directions = 'E';
                         break;
                    case 'E':
                         directions = 'N';
                         break;
                    case 'W':
                         directions = 'S';
                         break;
                    default:
                         break;
               }
               #endregion
          }
          public void MovForward(int[,] ground)
          {
               Console.Write("How many step u like 2 go?: ");
               int step = int.Parse(Console.ReadLine());
               #region DIRECTIONS
               switch (directions)
               {
                    case 'N':
                         for (int a = n; a <= n + step; a++)
                         {
                              if (tpen == true)
                                   ground[m, a] = 1;
                              else
                                   ground[m, a] = 0;
                         }
                         n = n + step;
                         break;
                    case 'S':
                         for (int a = n - step; a <= n; a++)
                         {
                              if (tpen == true)
                                   ground[a, m] = 1;
                              else
                                   ground[a, m] = 0;
                         }
                         n = n - step;
                         break;
                    case 'E':
                         for (int a = m; a <= m + step; a++)
                         {
                              if (tpen == true)
                                   ground[a, n] = 1;
                              else
                                   ground[a, n] = 0;
                         }
                         m = m + step;
                         break;
                    case 'W':
                         for (int a = m - step; a <= m; a++)
                         {
                              if (tpen == true)
                                   ground[a, n] = 1;
                              else
                                   ground[a, n] = 0;
                         }
                         m = m - step;
                         break;
               }
               ground[m, n] = 2;
               #endregion
          }
          public void Display(int[,] ground)
          {
               Console.WriteLine("TURTLE CODE");
               #region NESTED FOR LOOP FOR DISPLAYING
               for (int a = 0; a < ground.GetLength(0); a++)
               {
                    for (int b = 0; b < ground.GetLength(1); b++)
                    {
                         if (ground[a, b] == 0)
                              Console.Write(".");
                         else if (ground[a, b] == 1)
                              Console.Write("*");
                         else if (ground[a, b] == 2)
                              Console.Write("T");
                    }
                    Console.WriteLine();
               }
          }
          #endregion
     }
     public static void menus(TurtleClass person, int[,] ground)
     {
          #region MENUS WRITINGS
          Console.WriteLine("1 PenUP");
          Console.WriteLine("2 PenDOWN");
          Console.WriteLine("3 TurnRIGHT");
          Console.WriteLine("4 TurnLEFT");
          Console.WriteLine("5 MoveFORWARD");
          Console.WriteLine("6 Display");
          Console.WriteLine("7 End");
          #endregion
          Console.WriteLine("Enter command u want to realize?: ");
          int command = int.Parse(Console.ReadLine());
          #region COMMAND SWITCH FUNCTIONAL
          switch (command)
          {
               case 1:
                    person.UpPen();
                    Code.doTask();
                    break;
               case 2:
                    person.DownPen();
                    Code.doTask();
                    break;
               case 3:
                    person.RightTurn(ground);
                    Code.doTask();
                    break;
               case 4:
                    person.LeftTurn(ground);
                    Code.doTask();
                    break;
               case 5:
                    person.MovForward(ground);
                    person.Display(ground);
                    break;
               case 6:
                    person.Display(ground);
                    Code.doTask();
                    break;
               case 7:
                    Console.clear();
                    person.Display(ground);
                    break;
               default:
                    Console.WriteLine("Entered Invalid Choice!");
                    break;
          }
          #endregion
     }
}
