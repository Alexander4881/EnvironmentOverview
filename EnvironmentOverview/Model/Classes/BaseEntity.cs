using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnvironmentOverview.Model.Classes
{
    public class BaseEntity
    {
        // Attributes
        private int id;

        // Properties
        public int Id { get => id; set => id = value; }

        // Constructor
        public BaseEntity(int id)
        {
            Id = id;
        }
    }
}
