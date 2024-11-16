// #r "nuget: LibVLCSharp, 3.0.0"

using System;
using LibVLCSharp.Shared;

// Point d'entrée du programme
public static class Program
{
    public static void Main(string[] args)
    {
        // Initialiser LibVLC
        Core.Initialize();

        // Créer un objet libvlc
        using var libvlc = new LibVLC();

        // Spécifier le fichier mp3
        if (args.Length == 0)
        {
            Console.WriteLine("Please provide the path to the MP3 file as an argument.");
            return;
        }

        string filePath = args[0];

        // Créer un media à partir du fichier
        var media = new Media(libvlc, filePath, FromType.FromPath);

        // Créer un lecteur et l'associer au media
        using var mediaPlayer = new MediaPlayer(media)
        {
            EnableHardwareDecoding = true
        };

        // Régler le volume à 50% (NO SHITTT)
        int volume = 50; // Default volume

        if (args.Length > 1 && int.TryParse(args[1], out int parsedVolume))
        {
            volume = parsedVolume;
        }

        mediaPlayer.Volume = volume;

        // Jouer le fichier
        mediaPlayer.Play();


        // Attendre que la lecture soit terminée
        Console.WriteLine("Press any key to stop...");
        Console.ReadKey();
    }
}
