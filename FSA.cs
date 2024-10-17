using System;
/*
Class: CSE 1321L
Section: #04
Term: Spring 2024
Instructor: Gar Lock
Name: Alex Molina
Lab#: Assignment7A (fsa)
*/
using System;

public class FSA
{
    private int state;

    public FSA(int initialState)
    {
        if (initialState >= 0 && initialState <= 3)
        {
            state = initialState;
        }
        else
        {
            state = 0;
            Console.WriteLine("This is an invalid state. Starting at state 0");
        }
    }

    public int goToNextState()
    {
        switch (state)
        {
            case 0: state = 1; break;
            case 1: state = 2; break;
            case 2: state = 3; break;
            case 3: state = 0; break;
        }
        return state;
    }

    public bool end()
    {
        return state == 3;
    }
}
