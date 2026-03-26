using System.Runtime.InteropServices;
using System.Diagnostics;

public class SFX
{
    public void PlaySound(string fileName)
    {
        string path = Path.Combine("Sounds", fileName);

        if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "powershell",
                Arguments = $"-c (New-Object Media.SoundPlayer '{path}').PlaySync()",
                CreateNoWindow = true
            });
        }
        else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
        {
            Process.Start("aplay", $"-q {path}");
        }
    }

    public void StartMusic(string fileName)
    {
        string path = Path.Combine("Sounds", fileName);

        if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
        {
            // Windows : launching PowerShell that plays the song in loop (.PlayLooping)
            // using the Start-Job so PowerShell does it in the background without blocking C#
            string script = $"$p = New-Object Media.SoundPlayer '{path}'; $p.PlayLooping(); while($true){{Start-Sleep 1}}";
            Process.Start(new ProcessStartInfo
            {
                FileName = "powershell",
                Arguments = $"-c \"{script}\"",
                CreateNoWindow = true,
                WindowStyle = ProcessWindowStyle.Hidden
            });
        }
        else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
        {
            Process.Start("ffplay", $"-nodisp -loop 0 -loglevel quiet {path}");
        }
    }

    // Same logic for SFXMusic
    public void StartSFXMusic(string fileName) => StartMusic(fileName);

    public void StopMusic()
    {
        if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
        {
            Process.Start("pkill", "ffplay");
        }
        else if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
        {
            // Windows : killing all the processes PowerShell that could play sounds
            Process.Start(new ProcessStartInfo
            {
                FileName = "powershell",
                Arguments = "-c \"Stop-Process -Name powershell -Force -ErrorAction SilentlyContinue\"",
                CreateNoWindow = true
            });
        }
    }
}