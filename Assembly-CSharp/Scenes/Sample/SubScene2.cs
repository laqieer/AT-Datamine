// Decompiled with JetBrains decompiler
// Type: Scenes.Sample.SubScene2
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Scene;
using Il2CppDummyDll;
using System.Collections;

#nullable disable
namespace Scenes.Sample
{
  [Token(Token = "0x20028BE")]
  public class SubScene2 : SubScene
  {
    [Token(Token = "0x6010079")]
    [Address(RVA = "0x4166D10", Offset = "0x4166D10", VA = "0x4166D10", Slot = "6")]
    public override void Initialize(ChangeSceneParameter param)
    {
    }

    [Token(Token = "0x601007A")]
    [Address(RVA = "0x4166D3C", Offset = "0x4166D3C", VA = "0x4166D3C", Slot = "7")]
    public override IEnumerator InitializeAsync() => (IEnumerator) null;

    [Token(Token = "0x601007B")]
    [Address(RVA = "0x4166DC4", Offset = "0x4166DC4", VA = "0x4166DC4", Slot = "8")]
    public override void Disable()
    {
    }

    [Token(Token = "0x601007C")]
    [Address(RVA = "0x4166DCC", Offset = "0x4166DCC", VA = "0x4166DCC", Slot = "9")]
    public override void Destroy()
    {
    }

    [Token(Token = "0x601007D")]
    [Address(RVA = "0x4166DD0", Offset = "0x4166DD0", VA = "0x4166DD0", Slot = "4")]
    public override void OnPause()
    {
    }

    [Token(Token = "0x601007E")]
    [Address(RVA = "0x4166DD4", Offset = "0x4166DD4", VA = "0x4166DD4", Slot = "5")]
    public override void OnResume()
    {
    }

    [Token(Token = "0x601007F")]
    [Address(RVA = "0x4166DD8", Offset = "0x4166DD8", VA = "0x4166DD8")]
    private void Update()
    {
    }

    [Token(Token = "0x6010080")]
    [Address(RVA = "0x4166DDC", Offset = "0x4166DDC", VA = "0x4166DDC")]
    public void OnBackButton()
    {
    }

    [Token(Token = "0x6010081")]
    [Address(RVA = "0x4166E5C", Offset = "0x4166E5C", VA = "0x4166E5C")]
    public SubScene2()
    {
    }
  }
}
