using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        Video video1 = new Video("How to Train Your Dragon", "Cressida Cowell", 6120);
        Video video2 = new Video("Ma Meilleure Ennemier", "Stromae & Pomme soundtrack Arcane", 147);
        Video video3 = new Video("general conference 2024 - October", "Church of jesus christ of latter day saints", 18000);

        video1.AddComment(new Comment("Leonardo", "I can't get over Estoico's death."));
        video1.AddComment(new Comment("Kleithin", "excellent character development."));
        
        video2.AddComment(new Comment("Erika", "the Arcane soundtrack when Ekko and Jinx dance is beautiful!"));
        video2.AddComment(new Comment("Eivy", "impossible love but possible enemies."));
        

        video3.AddComment(new Comment("Jonathan", "God's favourite... It made me cry when I remembered that I am still a beloved son of God."));
        video3.AddComment(new Comment("Dante", "Burying Our Weapons of Rebellion. It doesn't matter what weapons they are, if they do harm and distance us from God we have to bury the weapons."));
        video3.AddComment(new Comment("Danny", "Ye are my friends. Sometimes we make decisions but if we are firm we can become good friends and find eternal friends."));

        List<Video> videos = new List<Video> { video1, video2, video3 };

        foreach (var video in videos)
        {
            video.DisplayInfo();
        }
    }
}