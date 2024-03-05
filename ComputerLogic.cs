namespace Tic_Tac_Toe
{
    public static class ComputerLogic
    {
        public static int[] TakePoint(int moves, int[,] field)
        {
            if (moves == 0)
            {
                return [1, 1];
            }
            if (moves == 2)
            {
                if (field[0, 0] == 1) return [2, 2];
                if (field[2, 2] == 1) return [0, 0];
                if (field[0, 2] == 1) return [2, 0];
                if (field[2, 0] == 1) return [0, 2];
                return [0, 0];
            }
            if (moves == 4)
            {
                int[]? first = null;
                int[] second = [1, 1];
                for (int i = 0; i < field.GetLength(0); i++)
                {
                    for (int j = 0; j < field.GetLength(1); j++)
                    {
                        if (field[i, j] == 1)
                        {
                            if (first == null)
                            {
                                first = [i, j];
                            }
                            else
                            {
                                second = [i, j];
                            }
                        }

                    }
                }
                if (first?[0] == second[0])
                {
                    if (field[first[0], 0] == 0) return [first[0], 0];
                    if (field[first[0], 1] == 0) return [first[0], 1];
                    if (field[first[0], 2] == 0) return [first[0], 2];
                }
                else
                {
                    if (field[0, first[1]] == 0) return [0, first[1]];
                    if (field[1, first[1]] == 0) return [1, first[1]];
                    if (field[2, first[1]] == 0) return [2, first[1]];
                }
            }
            if (moves == 1)
            {
                if (field[1, 1] == 0)
                {
                    return [1, 1];
                }
                else
                {
                    return [0, 0];
                }
            }

            if (moves == 6)
            {
                for (int i = 0; i < field.GetLength(0); i++)
                {
                    for (int j = 0; j < field.GetLength(1); j++)
                    {
                        if (field[i, j] == 0)
                        {
                            int countX = 0;
                            int countO = 0;
                            for (int k = 0; k < field.GetLength(1); k++)
                            {
                                if (field[i, k] == 1) countO++;
                                if (field[i, k] == 2) countX++;
                            }
                            if (countX > 1 || countO > 1)
                            {
                                return [i, j];
                            }
                            else
                            {
                                countO = 0;
                                countX = 0;
                                for (int k = 0; k < field.GetLength(1); k++)
                                {
                                    if (field[k, j] == 1) countO++;
                                    if (field[k, j] == 2) countX++;
                                }
                                if (countX > 1 || countO > 1)
                                {
                                    return [i, j];
                                }
                            }
                        }
                    }
                }
            }
            if (moves == 3)
            {
                if (field[0, 0] == 1 && field[2, 2] == 0) return [2, 2];
                if (field[2, 0] == 1 && field[0, 2] == 0) return [0, 2];
                if (field[0, 2] == 1 && field[2, 0] == 0) return [2, 0];
                if (field[2, 2] == 1 && field[0, 0] == 0) return [0, 0];
                for (int i = 0; i < field.GetLength(0); i++)
                {
                    for (int j = 0; j < field.GetLength(1); j++)
                    {
                        if (field[i, j] == 0)
                        {
                            int countX = 0;
                            int countO = 0;
                            for (int k = 0; k < field.GetLength(1); k++)
                            {
                                if (field[i, k] == 1) countO++;
                                if (field[i, k] == 2) countX++;
                            }
                            if (countX > 1 || countO > 1)
                            {
                                return [i, j];
                            }
                            else
                            {
                                countO = 0;
                                countX = 0;
                                for (int k = 0; k < field.GetLength(1); k++)
                                {
                                    if (field[k, j] == 1) countO++;
                                    if (field[k, j] == 2) countX++;
                                }
                                if (countX > 1 || countO > 1)
                                {
                                    return [i, j];
                                }
                            }
                        }
                    }
                }
            }
            if (moves == 5)
            {
                for (int i = 0; i < field.GetLength(0); i++)
                {
                    for (int j = 0; j < field.GetLength(1); j++)
                    {
                        if (field[i, j] == 0)
                        {
                            int countX = 0;
                            int countO = 0;
                            for (int k = 0; k < field.GetLength(1); k++)
                            {
                                if (field[i, k] == 1) countO++;
                                if (field[i, k] == 2) countX++;
                            }
                            if (countX > 1 || countO > 1)
                            {
                                return [i, j];
                            }
                            else
                            {
                                countO = 0;
                                countX = 0;
                                for (int k = 0; k < field.GetLength(1); k++)
                                {
                                    if (field[k, j] == 1) countO++;
                                    if (field[k, j] == 2) countX++;
                                }
                                if (countX > 1 || countO > 1)
                                {
                                    return [i, j];
                                }
                            }
                        }
                    }
                }
            }
            if (moves == 7)
            {
                for (int i = 0; i < field.GetLength(0); i++)
                {
                    for (int j = 0; j < field.GetLength(1); j++)
                    {
                        if (field[i, j] == 0)
                        {
                            int countX = 0;
                            int countO = 0;
                            for (int k = 0; k < field.GetLength(1); k++)
                            {
                                if (field[i, k] == 1) countO++;
                                if (field[i, k] == 2) countX++;
                            }
                            if (countX > 1 || countO > 1)
                            {
                                return [i, j];
                            }
                            else
                            {
                                countO = 0;
                                countX = 0;
                                for (int k = 0; k < field.GetLength(1); k++)
                                {
                                    if (field[k, j] == 1) countO++;
                                    if (field[k, j] == 2) countX++;
                                }
                                if (countX > 1 || countO > 1)
                                {
                                    return [i, j];
                                }
                            }
                        }
                    }
                }
            }


            List<int[]> freePoints = [];
            for (int i = 0; i < field.GetLength(0); i++)
            {
                for (int j = 0; j < field.GetLength(1); j++)
                {
                    if (field[i, j] == 0)
                    {
                        freePoints.Add([i, j]);
                    }
                }
            }
            Random random = new Random();
            return freePoints[random.Next(freePoints.Count())];
        }
    }
}
