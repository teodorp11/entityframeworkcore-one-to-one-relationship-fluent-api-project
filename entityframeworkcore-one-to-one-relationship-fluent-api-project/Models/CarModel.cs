using System.Text.Json.Serialization;

namespace entityframeworkcore_one_to_one_relationship_example_project.Models
{
    public class CarModel
    {
        public int ID { get; set; }
        public string? Model { get; set; }

        // One-to-one relationship
        [JsonIgnore]
        public CarCompany? CarCompany { get; set; } // navigation property
        public int CarCompanyID { get; set; } // foreign key

    }
}