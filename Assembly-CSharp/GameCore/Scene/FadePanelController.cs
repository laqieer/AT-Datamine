// Decompiled with JetBrains decompiler
// Type: GameCore.Scene.FadePanelController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;

#nullable disable
namespace GameCore.Scene
{
  [Token(Token = "0x2000C8D")]
  public class FadePanelController : LoadingPanelController
  {
    [Token(Token = "0x6004873")]
    [Address(RVA = "0x3131C10", Offset = "0x3131C10", VA = "0x3131C10", Slot = "4")]
    public override void Initialize()
    {
    }

    [Token(Token = "0x6004874")]
    [Address(RVA = "0x3131C14", Offset = "0x3131C14", VA = "0x3131C14", Slot = "7")]
    protected override IEnumerator Show() => (IEnumerator) null;

    [Token(Token = "0x6004875")]
    [Address(RVA = "0x3131CA4", Offset = "0x3131CA4", VA = "0x3131CA4", Slot = "8")]
    protected override void ShowImpl()
    {
    }

    [Token(Token = "0x6004876")]
    [Address(RVA = "0x3131CA8", Offset = "0x3131CA8", VA = "0x3131CA8", Slot = "9")]
    protected override IEnumerator Hide() => (IEnumerator) null;

    [Token(Token = "0x6004877")]
    [Address(RVA = "0x3131D38", Offset = "0x3131D38", VA = "0x3131D38", Slot = "10")]
    protected override void HideImpl()
    {
    }

    [Token(Token = "0x6004878")]
    [Address(RVA = "0x3131D3C", Offset = "0x3131D3C", VA = "0x3131D3C")]
    public FadePanelController()
    {
    }
  }
}
