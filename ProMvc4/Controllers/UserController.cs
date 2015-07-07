using ProMvc4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProMvc4.Controllers
{
    public class UserController : ApiController
    {
        [HttpGet]
        public UserInfo GetUserInfo(int userid)
        {
            UserInfo userinfo = new UserInfo() { Name="Bingo",UserID=10 };
            return userinfo;
        }

        [HttpGet]
        public IEnumerable<UserInfo> GetUserInfos()
        {
            var userinfos = new List<UserInfo>() { 
              new UserInfo(){ UserID = 1, Name = "000"},
              new UserInfo(){ UserID = 2, Name = "222"},
              new UserInfo(){ UserID = 3, Name = "333"}
            };
            return userinfos;
        }

        [HttpPost]
        public bool DeleteUser([FromBody]int userid)
        {
            return false;
        }
    }
}
