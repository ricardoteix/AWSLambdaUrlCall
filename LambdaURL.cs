using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWSLambdaUrlCall
{
    public class LambdaURL
    {
        private String name;
        private String profile;
        private String url;
        private String region;
        private String content;

        public string Region { get => region; set => region = value; }
        public string Url { get => url; set => url = value; }
        public string Profile { get => profile; set => profile = value; }
        public string Name { get => name; set => name = value; }
        public string Content { get => content; set => content = value; }

        public override String ToString()
        {
            return $"{Name} | {Profile} | {Url} | {Region}";
        }
    }
}
