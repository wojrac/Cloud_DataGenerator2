using System.Collections.Generic;

namespace CloudBackend1.Models
{
    public class AreaManager
    {
        public List<Area> Areas {get;private set;}
        public AreaManager()
        {
            Areas = new List<Area>
            {
                new MediumArea("Poland"),
                new MediumArea("Germany"),
                new BigArea("USA"),
                new BigArea("Brazil"),
                new SmallArea("Lithuania"),
                new SmallArea("Estonia")
            };
        }
        public void GenerateDeaths()
        {
            foreach(var item in Areas)
            {
                item.RandDeaths();
            }   
        }
    }
}