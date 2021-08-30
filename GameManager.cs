namespace SharkkitAPI
{
    public interface GameManager
    {
        bool FriendlyFire { get; set; }
        float TimePlayed { get; set; }
        int TargetFrameRate { get; set; }
        bool HasPassword { get; }
        string Password { get; set; }
        
        GameManager Instance { get; }
        
        string Version { get; }
        string ApiImplVersion { get; }

        IChatManager GetChatManager();
    }
}
