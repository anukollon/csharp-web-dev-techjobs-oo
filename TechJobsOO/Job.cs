using System;
namespace TechJobsOO
{
    public class Job
    {
        public int Id { get; }
        private static int nextId = 1;

        public string Name { get; set; }
        public Employer EmployerName { get; set; }
        public Location EmployerLocation { get; set; }
        public PositionType JobType { get; set; }
        public CoreCompetency JobCoreCompetency { get; set; }

        // TODO: Add the two necessary constructors.
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

        // TODO: Generate Equals() and GetHashCode() methods.
        public override bool Equals(object obj)
        {
            return obj is Job job &&
                   Id == job.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string ToString()
        {
            string dataNotAvlb = "Data not available";
            string jobToString = "";
            if((Name == null || Name.Trim() == "") && (EmployerName == null || EmployerName.ToString().Trim() == "") && (EmployerLocation == null || EmployerLocation.ToString().Trim() == "") && 
                (JobType == null || JobType.ToString().Trim() == "") && (JobCoreCompetency == null || JobCoreCompetency.ToString().Trim() == ""))
            {
                return "OOPS! This job does not seem to exist.";
            }

            jobToString += "ID: " + Id+"\n";
            if(Name == null || Name.Trim() == "")
            {
                jobToString += "Name: " + dataNotAvlb + "\n";
            }
            else
            {
                jobToString += "Name: " + Name + "\n";
            }

            if(EmployerName == null || EmployerName.ToString().Trim() == "")
            {
                jobToString += "Employer: " + dataNotAvlb + "\n";
            }
            else
            {
                jobToString += "Employer: " + EmployerName.ToString() + "\n";
            }

            if(EmployerLocation == null || EmployerLocation.ToString().Trim() == "")
            {
                jobToString += "Location: " + dataNotAvlb+ "\n";
            }
            else
            {
                jobToString += "Location: " + EmployerLocation.ToString() + "\n";
            }
            if(JobType == null || JobType.ToString().Trim() == "")
            {
                jobToString += "Position Type: " + dataNotAvlb + "\n";
            }
            else
            {
                jobToString += "Position Type: " + JobType.ToString() + "\n";
            }
            if(JobCoreCompetency == null || JobCoreCompetency.ToString().Trim() == "")
            {
                jobToString += "Core Competency: " + dataNotAvlb;
            }
            else
            {
                jobToString += "Core Competency: " + JobCoreCompetency.ToString()+"\n";
            }
            
            return jobToString;
        }
    }
}
