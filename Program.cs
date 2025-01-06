using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuliaC_Properties___Encapsulation_jan062025
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class GameCharacter
    {
        // 1. Auto-implemented property
        public string Name { get; private set; }

        // 2. Full property with validation
        private int health;
        public int Health
        {
            get { return health; }
            set
            {
                // TODO: Validate between 0-100
            }
        }

        // 3. Computed property
        public bool IsAlive
        {
            get
            {
                // TODO: Return true if health > 0
            }
        }
    }

    public class Inventory
    {
        // TODO: Implement properties as specified
    }

    public class PowerUp
    {
        // TODO: Implement properties as specified
    }
}
