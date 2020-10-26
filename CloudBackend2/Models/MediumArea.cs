using System;

namespace CloudBackend1.Models
{
    public class MediumArea:Area
    {
        public MediumArea(string name) : base(name)
        { }
        public override void RandDeaths()
        {
            var rand = new Random();
            this.DeathNumber = rand.Next(40, 500);
        }
    }
}