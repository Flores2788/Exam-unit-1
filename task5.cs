class Task5
{
    void Main()
    {
        while (!IsAtGoal())
        {
            TurnLeft();
            if (CanMoveForward())
            {
                MoveForward();
            }
            else
            {
                TurnRight();
                if (CanMoveForward())
                {
                    MoveForward();
                }
                else
                {
                    TurnRight();
                    MoveForward();
                }
            }
        }
    }

    // Basic functions

    void MoveForward()
    {
        // Moves the car 1 cell in the direction it is heading. 
    }

    void TurnRight()
    {
        // Turns the car 90 deg clockwise.
    }

    bool CanMoveForward()
    {
        // Returns true if the next cell is open, otherwise false.
        return true; // Just a placeholder value. 
    }

    bool IsAtGoal()
    {
        // Returns true if the current cell is the goal cell.
        return true; // just a placeholder
    }

    // Created functions

    void TurnLeft()
    {
        for (int i = 0; i < 3; i++)
        {
            TurnRight();
        }
    }
}