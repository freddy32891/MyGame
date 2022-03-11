using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gameClient.model
{
    [Serializable]
    public class Matches
    {
        private int matchId;
        private DateTime dateTime;

        public int MatchId { get => matchId; set => matchId = value; }
        public DateTime DateTime { get => dateTime; set => dateTime = value; }

        public Matches(int matchId, DateTime dateTime)
        {
            this.matchId = matchId;
            this.dateTime = dateTime;
        }

        public Matches(int matchId)
        {
            this.matchId = matchId;
        }

        public Matches()
        {
        }

        public override bool Equals(object obj)
        {
            return obj is Matches matches &&
                   matchId == matches.matchId;
        }

        public override int GetHashCode()
        {
            return 1297241091 + matchId.GetHashCode();
        }
    }
}
