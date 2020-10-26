using System;

namespace CloudBackend1.Models
{
    public class SmallArea:Area
    {
        public SmallArea(string name) : base(name)
        {}
        public override void RandDeaths()
        {
            var rand = new Random();
            this.DeathNumber = rand.Next(5,100); 
        }
    }
}