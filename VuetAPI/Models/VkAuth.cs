using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace VuetAPI.Models
{
    public class VkAuth
    {
        private readonly int clientId = 6969867;
        private readonly string version = "5.95";
        private readonly string clientSecret = "BQXW0H2k1n8HnuGTF9Gc";
        private readonly string display;
        private readonly string redirect;
        private readonly string scope;

        public VkAuth(string display, string redirect, string scope)
        {
            this.display = display;
            this.redirect = redirect;
            this.scope = scope;
        }

        public string AuthenticationUri()
        {
            return $"https://oauth.vk.com/authorize?" +
                $"client_id={clientId}&display={display}&redirect_uri={redirect}&scope={scope}&response_type=code&v={version}";
        }
        
        private string AccessTokenUri(string code)
        {
            return $"https://oauth.vk.com/access_token?" +
                $"client_id={clientId}&client_secret={clientSecret}&redirect_uri={redirect}&code={code}"; ;
        } 

        public AccessToken AccessToken(string code)
        {
            using (WebClient client = new WebClient())
            {
                return JsonConvert.DeserializeObject<AccessToken>(client.DownloadString(AccessTokenUri(code)));
            }
        }
    }
}
