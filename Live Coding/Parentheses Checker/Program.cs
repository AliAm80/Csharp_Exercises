using System;

namespace Challenge_3
{
    partial class Program
    {

        static void Main(string[] args)
        {
            // (())
            Console.Clear();
            Console.WriteLine("Hello");

            var characters = Console.ReadLine();
            var indexes = new List<int>();
            var result = false;
            int count = 0;
            if (characters.Length % 2 == 0)
            {
                for (int h = 0; h < characters.Length; h++)
                {
                    if (characters[h] == '(')
                    {
                        for (int i = h; i < characters.Length; i++)
                        {
                            if (characters[i] == '(')
                            {
                                for (int j = i + 1; j < characters.Length; j++)
                                {
                                    if (characters[j] == ')')
                                    {
                                        if (!indexes.Contains(j))
                                        {
                                            indexes.Add(i);
                                            indexes.Add(j);
                                            indexes.Sort();
                                            break;
                                        }
                                    }
                                }
                                break;
                            }
                        }

                    }
                    else if (characters[h] == '{')
                    {
                        for (int i = h; i < characters.Length; i++)
                        {
                            if (characters[i] == '{')
                            {
                                for (int j = i + 1; j < characters.Length; j++)
                                {
                                    if (characters[j] == '}')
                                    {
                                        if (!indexes.Contains(j))
                                        {
                                            indexes.Add(i);
                                            indexes.Add(j);
                                            indexes.Sort();
                                            break;
                                        }
                                    }
                                }
                                break;
                            }
                        }
                    }
                    else if (characters[h] == '[')
                    {
                        for (int i = h; i < characters.Length; i++)
                        {
                            if (characters[i] == '[')
                            {
                                for (int j = i + 1; j < characters.Length; j++)
                                {
                                    if (characters[j] == ']')
                                    {
                                        if (!indexes.Contains(j))
                                        {
                                            indexes.Add(i);
                                            indexes.Add(j);
                                            indexes.Sort();
                                            break;
                                        }
                                    }
                                }
                                break;
                            }
                        }
                    }
                    else if (characters[h] == '/')
                    {
                        for (int i = h; i < characters.Length; i++)
                        {
                            if (characters[i] == '/')
                            {
                                for (int j = i + 1; j < characters.Length; j++)
                                {
                                    if (characters[j] == '\\')
                                    {
                                        if (!indexes.Contains(j))
                                        {
                                            indexes.Add(i);
                                            indexes.Add(j);
                                            indexes.Sort();
                                            break;
                                        }
                                    }
                                }
                                break;
                            }



                        }
                    }
                    else if (characters[h] == '<')
                    {
                        for (int i = h; i < characters.Length; i++)
                        {
                            if (characters[i] == '<')
                            {
                                for (int j = i + 1; j < characters.Length; j++)
                                {
                                    if (characters[j] == '>')
                                    {
                                        if (!indexes.Contains(j))
                                        {
                                            indexes.Add(i);
                                            indexes.Add(j);
                                            indexes.Sort();
                                            break;
                                        }
                                    }
                                }
                                break;
                            }
                        }
                    }


                }
            }
            else
            {
                result = false;
            }
            for (int i = 0; i < indexes.Count; i++)
            {

                // Console.WriteLine(indexes[i]);
                if (indexes[i] != 0)
                {
                    indexes[i] -= count;
                }
                characters = characters.Remove(indexes[i], 1);
                count++;


            }
            if (characters.Length == 0)
            {
                result = true;
            }
            else
            {
                result = false;
            }

            Console.WriteLine(result);







        }
    }



}