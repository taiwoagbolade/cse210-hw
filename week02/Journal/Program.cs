using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");

        // Create first job and set values
        Job Job1 = new Job();
        Job1._jobTitle = "Software Engineer";
        Job1._company = "Microsoft";
        Job1._startYear = 2019;
        Job1._endYear = 2022;

        // Create second job and set values
        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._startYear = 2022;
        job2._endYear = 2023;

        // Initially display company names using dot notation
        Console.WriteLine(Job1._company); //Microsoft
        Console.WriteLine(job2._company); //Apple

        // Now use the Display method to show job information
        Job1.Display(); // Software Engineer (Microsoft) 2019-2022
        job2.Display(); // Manager (Apple) 2022-2023

        // Create a Resume instance and assign name 
        Resume myResume = new Resume();
        myResume._name = "Taiwo Agbolade";

        // Add jobs to the resume
        myResume._jobs.Add(Job1);
        myResume._jobs.Add(job2);

        // Access and display job title using dot notation
        Console.WriteLine(myResume._jobs[0]._jobTitle); // Software Engineer

        // Final display using Resume's abstraction 
        myResume.Display(); // Name: Taiwo Agbolade, Jobs: Software Engineer (Microsoft) 2019-2022, Manager (Apple) 2022-2023
        // Wait for user input before closing

    }
}