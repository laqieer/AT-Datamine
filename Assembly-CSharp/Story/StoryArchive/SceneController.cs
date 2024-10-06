// Decompiled with JetBrains decompiler
// Type: Story.StoryArchive.SceneController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Scene;
using Il2CppDummyDll;

#nullable disable
namespace Story.StoryArchive
{
  [Token(Token = "0x200061F")]
  public class SceneController
  {
    [Token(Token = "0x6002367")]
    [Address(RVA = "0x2DA5920", Offset = "0x2DA5920", VA = "0x2DA5920")]
    public void TransitionToStoryArchivePlayer(int replayId)
    {
    }

    [Token(Token = "0x6002368")]
    [Address(RVA = "0x2DA5A84", Offset = "0x2DA5A84", VA = "0x2DA5A84")]
    private void TransitionSceneSimple(
      string sceneAssetName,
      string subSceneAssetBundleName,
      string subSceneAssetName,
      ChangeSceneParameter param = null)
    {
    }

    [Token(Token = "0x6002369")]
    [Address(RVA = "0x2DA58F4", Offset = "0x2DA58F4", VA = "0x2DA58F4")]
    public SceneController()
    {
    }

    [Token(Token = "0x2000620")]
    public class StoryReplayChangeSceneParameter : ChangeSceneParameter
    {
      [Token(Token = "0x4001DF0")]
      [FieldOffset(Offset = "0x14")]
      public int ReplayId;

      [Token(Token = "0x600236A")]
      [Address(RVA = "0x2DA5A78", Offset = "0x2DA5A78", VA = "0x2DA5A78")]
      public StoryReplayChangeSceneParameter()
      {
      }
    }
  }
}
