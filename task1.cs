

class Task1
{
    void Main()
    {
        int directionChangeFrequency = 1;
        int moveCounter = 0;

        while (!AtGoal())
        {
            if (Peek())
            {
                Move();
                continue;
            }

            ChangeDirectionBasedOnCounter(directionChangeFrequency);
            moveCounter++;

            if (moveCounter == 2)
            {
                moveCounter = 0;
                directionChangeFrequency++;
            }
        }
    }

    // Basic functions

    void Move()
    {
        // Moves the car 1 cell in the direction it is heading. 
    }

    void Turn()
    {
        // Turns the car 90 deg clockwise.
    }

    bool Peek()
    {
        // Returns true if the next cell is open, otherwise false.
        return true; // Just a placeholder value. 
    }

    bool AtGoal()
    {
        // Returns true if the current cell is the goal cell.
        return true; // just a placeholder
    }

    // Created functions

    void TurnLeft()
    {
        for (int i = 0; i < 3; i++)
        {
            Turn();
        }
    }

    void ChangeDirectionBasedOnCounter(int directionChangeFrequency)
    {
        if (directionChangeFrequency % 2 != 0)
        {
            Turn();
        }
        else
        {
            TurnLeft();
        }
    }
}