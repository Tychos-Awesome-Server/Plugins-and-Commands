namespace MCGalaxy {
  public class StartupPlugin : Plugin {
    public override string name { get { return "StartupPlugin"; } }
    public override string MCGalaxy_Version { get { return "1.0.0.0"; } }
    public override void Unload(bool shutdown) {}

    public override void Load(bool startup) {
      if (startup) Command.Find("setsoftwarename").Use(Player.Console, "%4TAS Server%f");
    }
  }
}