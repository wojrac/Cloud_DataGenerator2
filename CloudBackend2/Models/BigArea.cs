using System;
namespace CloudBackend1.Models
{
    public class BigArea : Area
    {
        public BigArea(string name) : base(name)
        {}
        public override void RandDeaths()
        {
            var rand = new Random();
            this.DeathNumber = rand.Next(100,1000); 
        }
    }
}