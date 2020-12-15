using System;
using System.Collections.Generic;

namespace TechJobsOO
{
    public class Job
    {
        public int Id { get; }
        private static int nextId = 1;

        public string Name { get; set; }
        public Employer EmployerName { get; set; }
        public  Location EmployerLocation { get; set; }
        public PositionType JobType { get; set; }
        public CoreCompetency JobCoreCompetency { get; set; }

        public string ACME;

        public Job()
        {
            Id = nextId;
            nextId++;
        }

        public Job(string name, Employer employerName, Location employerLocation, PositionType jobType, CoreCompetency jobCoreCompetency) : this()

        {
            Name = name;
            EmployerName = employerName;
            EmployerLocation = employerLocation;
            JobType = jobType;
            JobCoreCompetency = jobCoreCompetency;
            
        }
       

        public override string ToString()
        {
            string JobData = $"\n ID: { Id}\nName: { Name}\n Employer: { EmployerName}\n Location: { EmployerLocation}\n Position Type: { JobType}\n Core Competency: { JobCoreCompetency} \n"; 
            if(Name == "" || Name == null)
            {
                return "Data not available";
            }
            if( EmployerName.Value == "")
            {
                return "Data not available";
            }
            if(EmployerLocation.Value == "")
            {
                return "Data not available";
            }
            if(JobType.Value == "")
            {
                return "Data not available";
            }
            if(JobCoreCompetency.Value == "")
            {
                return "Data not available";
            }
                return JobData;

        }




        public override bool Equals(object obj)
        {
            return obj is Job job &&
                   Id == job.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        //TODO: Add the two necessary constructors.

        // TODO: Generate Equals() and GetHashCode() methods.
    }
}

