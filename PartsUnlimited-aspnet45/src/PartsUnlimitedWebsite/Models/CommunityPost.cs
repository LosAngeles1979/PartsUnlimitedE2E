using System;

namespace PartsUnlimited.Models
{

    public class CommunityPost
    {
        // getters and setters
        // these remind me of a co-worker.  :-)
        public string Image { get; set; }
        public string Content { get; set; }
        public DateTime DatePosted { get; set; }
        public CommunitySource Source { get; set; }
    }

    public enum CommunitySource
    {
        Facebook,
        Twitter
    }
}