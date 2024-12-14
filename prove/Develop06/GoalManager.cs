using System;
using System.Runtime.InteropServices;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _Score;

    public void Start()
    {
        string choice;

        do
        {
            Console.WriteLine("");
            Console.WriteLine($"Total Number of points {_Score}");
            Console.WriteLine("");
            Console.WriteLine("Menu Options");
            Console.WriteLine("Select the corresponding number to perform the desired action");
            Console.WriteLine("");
            Console.WriteLine("1.  Create New Goal");
            Console.WriteLine("2.  List Goals");
            Console.WriteLine("3.  Save Goals");
            Console.WriteLine("4.  Load Goals");
            Console.WriteLine("5.  Record Event");
            Console.WriteLine("6.  Quit");
            Console.Write(" Select a choice from the menu: ");
            choice = Console.ReadLine();

            if ( choice == "1")
            {
                CreateGoal();
            }
            else if ( choice == "2")
            {
                ListGoalDetails();
            }
            else if ( choice == "3")
            {
                SaveGoals();
            }
            else if ( choice == "4")
            {
                Console.Write("What is the name of your file?  ");
                string fileName = Console.ReadLine();
                LoadGoals(fileName);
                Console.WriteLine($"{fileName} has been loded");
            }
            else if ( choice == "5")
            {
                RecordEvent();
            }

            else 
            {
                Console.WriteLine();
                Console.WriteLine("Please enter a valid option !!");

            }
        } while (choice != "6");

    }

    public void DisplayPlayerInfo()
    {
        Console.Write("Which goal have you completed? ");
        int get = int.Parse(Console.ReadLine());
        Console.WriteLine("");
        int index = get-1;
        int points = _goals[index].RecordEvent();

        if (points == 0)
        {
            Console.WriteLine("Goal alraedy completed");

        }
        else
        {
            _Score += points;
            Console.WriteLine($"Points: {_Score}");

        }

    }

    public void ListGoalNames()
    {
        int counter = 1;
        foreach(Goal goal in _goals)
        {
            Console.WriteLine(counter + "," + goal.GetDetailString());
            counter++;

        }
    }

    public void ListGoalDetails()
    {
        int counter = 1;
        foreach(Goal goal in _goals)
        {
            Console.WriteLine("");
            Console.WriteLine(counter + "," + goal.GetDetailString() );
            counter++;



        }
    }

    public void CreateGoal()
    {
        string choice1;

       Console.WriteLine("The types of goals are: ");
       Console.WriteLine("1.  Simple Goal");
       Console.WriteLine("2  Eternal Goal");
       Console.WriteLine("3.  Checklist Goal");
       Console.Write("Which type of goal would you like to create?  ");
       choice1 = Console.ReadLine();
       Console.WriteLine("");

       Console.Write("What is the name of your goal? ");
       string _GoalName = Console.ReadLine();
       Console.Write("Give a brief description of your goal: ");
       string _GoalDesctn = Console.ReadLine();
       Console.WriteLine("");
       Console.Write("What amount of points will be assigned to this goal? ");
       int _GoalPoints = int.Parse(Console.ReadLine());
       Console.WriteLine("");

       if ( choice1 == "1")
       {
         _goals.Add(new SimpleGoal(_GoalName, _GoalDesctn, _GoalPoints));

       }
       else if ( choice1 == "2")
       {
         _goals.Add(new EternalGoal(_GoalName, _GoalDesctn, _GoalPoints));

       }
       else if (choice1 == "3")
       {
          Console.Write("Hoe many times does this goal has to be accomplished?  ");
          int _GoalTarget = int.Parse(Console.ReadLine());
          Console.Write($"What is the bonus for havimg completed the goal {_GoalTarget} times?  ");
          int _GoalBonus = int.Parse(Console.ReadLine());

          Console.WriteLine();

          _goals.Add(new CheckListGoal(_GoalName, _GoalDesctn, _GoalPoints, _GoalTarget, _GoalBonus));

       }

    }

    public void RecordEvent()
    {
        Console.WriteLine("The goals are: ");
        ListGoalNames();
        Console.Write("Which goal have you completed? ");
        int get = int.Parse(Console.ReadLine());
        Console.WriteLine();
        int index = get - 1;
        int points = _goals[index].RecordEvent();

        if (points == 0)
        {
            Console.WriteLine("The goal has already been completed");
            
        }
        else
        {
            _Score += points;

        }
    }

    public void SaveGoals()
    {
        Console.Write("With what name will this file be saved?  ");
        string fileName = Console.ReadLine();
        Console.WriteLine();

        using StreamWriter outputFile = new(fileName);
        outputFile.WriteLine(_Score);
        foreach (Goal goal in _goals)
        {
            outputFile.WriteLine(goal.GetStringRepresentation());
        }
        Console.WriteLine($"File saved as {fileName}");
        _Score = 0;
        Console.WriteLine();
        _goals.Clear();


    }

    public void LoadGoals(string fileName)
    {
        string [] lines = System.IO.File.ReadAllLines(fileName);

        if (lines.Length > 0)
        {
            int lastScore = int.Parse(lines[0]);
            _Score = lastScore;
        }

        foreach ( string line in lines)
        {
            string [] parts = line.Split(",");
            if (parts.Length >= 4)
            {
                string type = parts[0];
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);

                if ( type == "SimpleGoal")
                {
                    bool isComplete = bool.Parse(parts[4]);
                    _goals.Add(new SimpleGoal(name, description, points, isComplete));

                }
                else if (type == "EternalGoal")
                {
                    _goals.Add(new EternalGoal(name, description, points));

                }

                else if (type == "CheckListGoal")
                {
                    if (parts.Length >= 6)
                    {
                        int target = int.Parse(parts[4]);
                        int bonus = int.Parse(parts[5]);
                        int amount = int.Parse(parts[6]);
                        bool isCompleteCheckList = bool.Parse(parts[7]);
                        _goals.Add(new CheckListGoal(name, description, points, target, bonus, amount, isCompleteCheckList));

                    }
                }
            }
        }
    }

}