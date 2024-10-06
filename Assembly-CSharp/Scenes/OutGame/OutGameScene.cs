// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.OutGameScene
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Scene;
using Il2CppDummyDll;

#nullable disable
namespace Scenes.OutGame
{
  [Token(Token = "0x2003204")]
  public class OutGameScene : GameCore.Scene.Scene
  {
    [Token(Token = "0x17004119")]
    public SubSceneTransitions SubSceneTransitions
    {
      [Token(Token = "0x6013874"), Address(RVA = "0x49C00D8", Offset = "0x49C00D8", VA = "0x49C00D8")] get
      {
        return (SubSceneTransitions) null;
      }
    }

    [Token(Token = "0x6013875")]
    [Address(RVA = "0x49C00E0", Offset = "0x49C00E0", VA = "0x49C00E0", Slot = "6")]
    public override void Initialize(ChangeSceneParameter param = null)
    {
    }

    [Token(Token = "0x6013876")]
    [Address(RVA = "0x49C00E8", Offset = "0x49C00E8", VA = "0x49C00E8")]
    public void ChangeSubScene(
      SubSceneTransitions.TransitionData transition,
      ChangeSceneParameter changeSceneParam = null)
    {
    }

    [Token(Token = "0x6013877")]
    [Address(RVA = "0x49C0180", Offset = "0x49C0180", VA = "0x49C0180")]
    public static OutGameScene ActiveScene() => (OutGameScene) null;

    [Token(Token = "0x6013878")]
    [Address(RVA = "0x49C0280", Offset = "0x49C0280", VA = "0x49C0280")]
    public OutGameScene()
    {
    }
  }
}
