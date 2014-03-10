using PortableSteam;
using PortableSteam.Interfaces.General.ISteamUser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Portable.Wrapper
{
    public class Steam : ISteam
    {
        public Steam(string steamWebApiKey)
        {
            SteamWebAPI.SetGlobalKey(steamWebApiKey);
        }

        public async Task<IEnumerable<Friend>> GetFriendList(long steamId, RelationshipType relationship = RelationshipType.All)
        {
            var response = await SteamWebAPI.General().ISteamUser().GetFriendList(SteamIdentity.FromSteamID(steamId), relationship).GetResponseAsync();

            return response.Data.Friends;
        }
    }
}
