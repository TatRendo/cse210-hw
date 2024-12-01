using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        // Crear videos
        Video video1 = new Video("Learn C# Basics", "Programming Guru", 600);
        Video video2 = new Video("Advanced C# Techniques", "Code Master", 1200);
        Video video3 = new Video("C# for Beginners", "Tech Educator", 900);

        // Agregar comentarios al video1
        video1.AddComment(new Comment("Alice", "This video was super helpful!"));
        video1.AddComment(new Comment("Bob", "Great explanation, thanks!"));
        video1.AddComment(new Comment("Charlie", "Could you cover more examples?"));

        // Agregar comentarios al video2
        video2.AddComment(new Comment("Dave", "This is exactly what I needed."));
        video2.AddComment(new Comment("Eve", "Clear and concise."));

        // Agregar comentarios al video3
        video3.AddComment(new Comment("Frank", "Good for beginners."));
        video3.AddComment(new Comment("Grace", "Loved the pacing of this tutorial!"));

        // Lista de videos
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Mostrar información de cada video
        foreach (var video in videos)
        {
            video.DisplayInfo();
        }
    }
}