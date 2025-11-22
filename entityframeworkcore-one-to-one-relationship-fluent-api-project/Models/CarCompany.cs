using System.Text.Json.Serialization;

namespace entityframeworkcore_one_to_one_relationship_example_project.Models
{
    public class CarCompany
    {
        public int ID { get; set; }
        public string? Name { get; set; }

        // One-to-one relationship
        [JsonIgnore]
        public CarModel? CarModel { get; set; } // Navigation property
    }
}