namespace MCGalaxy {
  public class StartupPlugin : Plugin {
    public override string name { get { return "StartupPlugin"; } }
    public override string MCGalaxy_Version { get { return "1.0.0.0"; } }
    public override void Unload(bool shutdown) {}
    //change "Software Name" to the name you want
    public override void Load(bool startup) {
      if (startup) Command.Find("setsoftwarename").Use(Player.Console, "Software Name");
    }
  }
}
