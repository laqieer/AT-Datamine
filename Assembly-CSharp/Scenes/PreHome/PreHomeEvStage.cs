// Decompiled with JetBrains decompiler
// Type: Scenes.PreHome.PreHomeEvStage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;

#nullable disable
namespace Scenes.PreHome
{
  [Token(Token = "0x200317B")]
  public class PreHomeEvStage : GameCore.Scene.Scene
  {
    [Token(Token = "0x400D2AA")]
    public const string PREHOME_MAINSCENE_NAME = "PreHomeEvStage";
    [Token(Token = "0x400D2AB")]
    private const string HOME_MAINSCENE_NAME = "Home3D";
    [Token(Token = "0x400D2AC")]
    private const string HOME_SUBSCENE_AB_NAME = "page_home";
    [Token(Token = "0x400D2AD")]
    [FieldOffset(Offset = "0x58")]
    private bool isInitEnd;
    [Token(Token = "0x400D2AE")]
    [FieldOffset(Offset = "0x59")]
    private bool runSceneChange;
    [Token(Token = "0x400D2AF")]
    [FieldOffset(Offset = "0x60")]
    private EvStageEventPlayer advPlayer;

    [Token(Token = "0x60134E2")]
    [Address(RVA = "0x4A2D858", Offset = "0x4A2D858", VA = "0x4A2D858", Slot = "7")]
    public override IEnumerator InitializeAsync() => (IEnumerator) null;

    [Token(Token = "0x60134E3")]
    [Address(RVA = "0x4A2D8E8", Offset = "0x4A2D8E8", VA = "0x4A2D8E8", Slot = "22")]
    protected override void Update()
    {
    }

    [Token(Token = "0x60134E4")]
    [Address(RVA = "0x4A2DA50", Offset = "0x4A2DA50", VA = "0x4A2DA50")]
    public PreHomeEvStage()
    {
    }
  }
}
