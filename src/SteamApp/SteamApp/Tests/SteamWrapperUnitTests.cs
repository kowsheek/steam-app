using System;
using Portable.Wrapper;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class SteamWrapperUnitTests
    {
        private ISteam steam;

        const string WebApiKey = "6AE84B30050DC27709C6C2CD7847CF0B";
        const long TestSteamId = 76561198047501987;

        [TestInitialize]
        public void TestInitialize()
        {
            steam = new Steam(WebApiKey);
        }

        [TestMethod]
        public async void TestGetFriendList()
        {
            var friends = await steam.GetFriendList(TestSteamId);
            Assert.IsNotNull(friends);
        }
    }
}
