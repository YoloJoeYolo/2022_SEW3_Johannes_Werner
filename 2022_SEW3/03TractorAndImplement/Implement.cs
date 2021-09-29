using System;
using System.Collections.Generic;
using System.Text;

namespace _03TractorAndImplement
{
    class Implement
    {
        private string type;
        private int weight;

        public Implement(string type, int weight)
        {
            this.type = type;
            this.weight = weight;
        }

        public string Type
        {
            get
            {
                return this.type;
            }
        }

        public int Weight
        {
            get
            {
                return this.weight;
            }
            set
            {
                this.weight = value;
            }
        }

        public override string ToString()
        {
            return this.type;
        }
    }
}
