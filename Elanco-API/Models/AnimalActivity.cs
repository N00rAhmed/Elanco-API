using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Elanco_API.Models
{
    public class AnimalActivity
    {


/*        [Key]
        public string Id { get; set; }
*/
        [Column("DogID")]
        public string DogID { get; set; }

        [Column("Weight(kg)")]
        public double WeightKG { get; set; }

        public string Date { get; set; }

        public int Hour { get; set; }

        [Column("BehaviourPattern")]
        public string BehaviourPattern { get; set; }

        [Column("ActivityLevel(steps)")]
        public int ActivityLevelSteps { get; set; }

        [Column("HeartRate(bpm)")]
        public int HeartRateBpm { get; set; }

        [Column("CalorieBurn")]
        public double CalorieBurn { get; set; }

        [Column("Temperature(C)")]
        public double TemperatureC { get; set; }

        [Column("FoodIntake(calories)")]
        public int FoodIntakeCalories { get; set; }

        [Column("WaterIntake(ml)")]
        public int WaterIntakeMl { get; set; }

        [Column("BreathingRate(breaths/min)")]
        public int BreathingRateBreathsPerMin { get; set; }

        [Column("BarkingFrequency")]
        public string BarkingFrequency { get; set; }




    }
}