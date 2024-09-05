// Decompiled with JetBrains decompiler
// Type: GameCore.Scene.CustomLoadingPanelController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;

#nullable disable
namespace GameCore.Scene
{
  [Token(Token = "0x2000C8A")]
  public class CustomLoadingPanelController : LoadingPanelController
  {
    [Token(Token = "0x600485F")]
    [Address(RVA = "0x3131838", Offset = "0x3131838", VA = "0x3131838", Slot = "4")]
    public override void Initialize()
    {
    }

    [Token(Token = "0x6004860")]
    [Address(RVA = "0x3131840", Offset = "0x3131840", VA = "0x3131840", Slot = "7")]
    protected override IEnumerator Show() => (IEnumerator) null;

    [Token(Token = "0x6004861")]
    [Address(RVA = "0x31318D0", Offset = "0x31318D0", VA = "0x31318D0", Slot = "8")]
    protected override void ShowImpl()
    {
    }

    [Token(Token = "0x6004862")]
    [Address(RVA = "0x31318D4", Offset = "0x31318D4", VA = "0x31318D4", Slot = "9")]
    protected override IEnumerator Hide() => (IEnumerator) null;

    [Token(Token = "0x6004863")]
    [Address(RVA = "0x3131964", Offset = "0x3131964", VA = "0x3131964", Slot = "10")]
    protected override void HideImpl()
    {
    }

    [Token(Token = "0x6004864")]
    [Address(RVA = "0x3131968", Offset = "0x3131968", VA = "0x3131968")]
    public CustomLoadingPanelController()
    {
    }
  }
}
