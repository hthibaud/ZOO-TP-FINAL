using System.Runtime.InteropServices;
using System.Diagnostics;

public class SFX
{
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

    public void StartMusic(string fileName)
{
    string path = Path.Combine("Sounds", fileName);

    if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
    {
        //Windows command to launch a media (loop) without blocking C#
        Process.Start("wmplayer", $"/Play /Close {path}"); 
    }
    else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
    {
        //Linux command (with ffplay)
        Process.Start("ffplay", $"-nodisp -loop 0 -loglevel quiet {path}");
    }
}
}