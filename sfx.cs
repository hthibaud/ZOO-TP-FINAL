using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Media;

public class SFX
{

    //Launches the sounds as one shots
    public void PlaySound(string fileName)
    {
        string path = Path.Combine("Sounds", fileName);

        if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
        {
            // if you are on WINDOWS
            // it uses PowerShell to launch sounds on windows
            Process.Start(new ProcessStartInfo
            {
                FileName = "powershell",
                Arguments = $"-c (New-Object Media.SoundPlayer '{path}').PlaySync()",
                CreateNoWindow = true
            });
        }
        else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
        {
            //Ubuntu
            // it uses aplay
            Process.Start("aplay", $"-q {path}");
        }
    }


    //Starts the loops musics
    public void StartMusic(string fileName)
    {
        string path = Path.Combine("Sounds", fileName);

        // For linux, using ffplay
        Process.Start("ffplay", $"-nodisp -loop 0 -loglevel quiet {path}");

    }

    //Starts the SFX loop
    public void StartSFXMusic(string fileName)
    {
        string path = Path.Combine("Sounds", fileName);

        // For linux, using ffplay
        Process.Start("ffplay", $"-nodisp -loop 0 -loglevel quiet {path}");

    }


    //Stops the loops musics
    public void StopMusic()
    {
        if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
        {
            // Linux (PowerShell)
            Process.Start("pkill", "ffplay");
        }
        else if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
        {
            // Windows (PowerShell)
            Process.Start("powershell", "-c \"Get-Process ffplay, powershell | Stop-Process -ErrorAction SilentlyContinue\"");
        }
    }
}