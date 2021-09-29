using System;
using System.Collections.Generic;
using System.Text;

namespace _03TractorAndImplement
{
    class Tractor
    {
        private string type;
        private int weight;
        private int maxWeight;
        private Implement myImplement;

        public Tractor(string type, int weight, int maxWeight)
        {
            this.type = type;
            this.weight = weight;
            this.maxWeight = maxWeight;
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

        public int MaxWeight
        {
            get
            {
                return this.maxWeight;
            }
        }

        public Implement MyImplement
        {
            get
            {
                return this.myImplement;    // möglicherweise null --> aber egal
            }
            set
            {
                Implement i = value;
                if(i != null && this.weight + i.Weight > this.maxWeight)
                {
                    // Anbauerät ist zu schwer
                    throw new ImplementTooHeavyException();
                }
                this.myImplement = value;
            }
        }

        public override string ToString()
        {
            if (this.myImplement != null)
            {
                return "Tractor: " + this.type + "; Implement " + this.myImplement.ToString();
            }
            else
            {
                return "Tractor: " + this.type;
            }
        }
    }
}
