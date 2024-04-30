using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Patients
{
    public class Patient
    {
        public Patient() { }
        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public string Species { get; private set; } // e.g., Dog, Cat
        public DateTime DateOfBirth { get; private set; }
        public ICollection<MedicalRecords> MedicalRecords { get; private set; }

        // Constructor and methods
        public Patient(Guid id, string name, string species, DateTime dateOfBirth)
        {
            Id = id;
            Name = name;
            Species = species;
            DateOfBirth = dateOfBirth;
            MedicalRecords = new List<MedicalRecords>();
        }

        public void AddMedicalRecord(MedicalRecords record)
        {
            MedicalRecords.Add(record);
        }
    }
}
