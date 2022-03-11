using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gameClient.model
{
    [Serializable]
    public class Shield
    {
        private int shieldId;
        private String name;
        private int defensePoints;
        private String quality;
        private int cost;

        public int ShieldId { get => shieldId; set => shieldId = value; }
        public string Name { get => name; set => name = value; }
        public int DefensePoints { get => defensePoints; set => defensePoints = value; }
        public string Quality { get => quality; set => quality = value; }
        public int Cost { get => cost; set => cost = value; }

        public Shield(int shieldId, string name, int defensePoints, string quality, int cost)
        {
            this.shieldId = shieldId;
            this.name = name;
            this.defensePoints = defensePoints;
            this.quality = quality;
            this.cost = cost;
        }

        public Shield(int shieldId)
        {
            this.shieldId = shieldId;
        }

        public Shield()
        {
        }

        public override bool Equals(object obj)
        {
            return obj is Shield shield &&
                   shieldId == shield.shieldId &&
                   Cost == shield.Cost;
        }

        public override int GetHashCode()
        {
            int hashCode = 223534253;
            hashCode = hashCode * -1521134295 + shieldId.GetHashCode();
            hashCode = hashCode * -1521134295 + Cost.GetHashCode();
            return hashCode;
        }

    }
}
