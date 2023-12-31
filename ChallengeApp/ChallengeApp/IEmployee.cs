﻿namespace ChallengeApp
{
    public interface IEmployee
    {
        string Name { get; }
        string Surname { get; }
        Statistics GetStatistics();
        void AddGrade(float grade);
        void AddGrade(string grade);
        void AddGrade(char grade);
        void AddGrade(double grade);
        void AddGrade(int grade);

        event EmployeeBase.GradeAddedDelegate GradeAdded;
    
    }
    
    


    
    
}
