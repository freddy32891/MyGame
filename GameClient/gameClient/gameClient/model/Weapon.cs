using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gameClient.model
{
    [Serializable]
    public class Weapon
    {
        private int weaponId;
        private String name;
        private int damage;
        private int effectiveness;
        private String quality;
        private int cost;

        public int WeaponId { get => weaponId; set => weaponId = value; }
        public string Name { get => name; set => name = value; }
        public int Damage { get => damage; set => damage = value; }
        public int Effectiveness { get => effectiveness; set => effectiveness = value; }
        public string Quality { get => quality; set => quality = value; }
        public int Cost { get => cost; set => cost = value; }

        public Weapon(int weaponId, string name, int damage, int effectiveness, string quality, int cost)
        {
            this.weaponId = weaponId;
            this.name = name;
            this.damage = damage;
            this.effectiveness = effectiveness;
            this.quality = quality;
            this.cost = cost;
        }

        public Weapon(int weaponId)
        {
            this.weaponId = weaponId;
        }

        public Weapon()
        {
        }

        public override bool Equals(object obj)
        {
            return obj is Weapon weapon &&
                   weaponId == weapon.weaponId;
        }

        public override int GetHashCode()
        {
            return 1561522388 + weaponId.GetHashCode();
        }
    }
}
