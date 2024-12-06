using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        List<Video> _videos = [];

        Video video1 = new Video("The Most Beautiful Girl in the Cave", "Fight of the Conchords", 200);
        video1.AddComment("Homerun Forever", "I love this song! It's way better than that silly remix.");
        video1.AddComment("Flight of the Conchords", "Not cool man");
        video1.AddComment("Ed Sheeran", "Okay, this one is copyright infringement.");

        Video video2 = new Video("Top 10 reasons my child is crazy", "no one in particular", 300);
        video2.AddComment("The Real Donald Trump","Oh my goodness, my children all did this too. I thought I was the crazy one, but it turns out my kids are perfectly normal");
        video2.AddComment("Mom Talk","Okay, this is child exploitation and secretive verbal abuse. I can't believe you're posting this.");
        video2.AddComment("Just Chillin","@Mom Talk woah lady, no need to have an aneurysm over this. It's just funny relatable content");
        video2.AddComment("Mom Talk","I'm tired of being the only person looking out for children's rights on the internet. I'm starting a petition about this. Come to my page to sign and stay for relatable AND appropriate content.");
        
        Video video3 = new Video("My grandma's cookies are better than yours", "The Jealous Jellybeans", 60);
        video3.AddComment("You Suck at Cooking","Yeah you totally suck - (pop-culture reference, please don't dock points for toxicity) -");
        video3.AddComment("Grammys of the World Unite","This is a great recipe! Do you mind if I add it to my free digital cookbook? I'll link your video for credit and further instruction.");
        video3.AddComment("SpongeGar","Banuga ready! Banga Gary. mau. Gary! Kabanga!.......mau");
        video3.AddComment("Shirley Curry","I just made those on stream and gained 5,000 new subscribers.");

        _videos.Add(video1);
        _videos.Add(video2);
        _videos.Add(video3);

        Console.WriteLine("Press enter to see video comments");
        Console.ReadLine();
        Console.WriteLine("Here are your lovely comments:\n");
        DisplayVidInfo();
        



        void DisplayVidInfo()
        {
            foreach (Video video in _videos)
            {
                video.DisplayInfo();
            }
        }
    }
}