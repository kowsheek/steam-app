using PortableSteam;
using PortableSteam.Interfaces.General.ISteamUser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portable.Wrapper
{
    public interface ISteam
    {
        Task<IEnumerable<Friend>> GetFriendList(long steamId, RelationshipType relationship = RelationshipType.All);
    }
}
