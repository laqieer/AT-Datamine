// Decompiled with JetBrains decompiler
// Type: Scenes.Sample.SampleScene
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Scene;
using Il2CppDummyDll;
using System.Collections;

#nullable disable
namespace Scenes.Sample
{
  [Token(Token = "0x20028B3")]
  public class SampleScene : GameCore.Scene.Scene
  {
    [Token(Token = "0x6010038")]
    [Address(RVA = "0x41666D8", Offset = "0x41666D8", VA = "0x41666D8", Slot = "6")]
    public override void Initialize(ChangeSceneParameter param)
    {
    }

    [Token(Token = "0x6010039")]
    [Address(RVA = "0x4166704", Offset = "0x4166704", VA = "0x4166704", Slot = "7")]
    public override IEnumerator InitializeAsync() => (IEnumerator) null;

    [Token(Token = "0x601003A")]
    [Address(RVA = "0x416678C", Offset = "0x416678C", VA = "0x416678C", Slot = "8")]
    public override void Disable()
    {
    }

    [Token(Token = "0x601003B")]
    [Address(RVA = "0x4166794", Offset = "0x4166794", VA = "0x4166794", Slot = "9")]
    public override void Destroy()
    {
    }

    [Token(Token = "0x601003C")]
    [Address(RVA = "0x4166798", Offset = "0x4166798", VA = "0x4166798", Slot = "4")]
    public override void OnPause()
    {
    }

    [Token(Token = "0x601003D")]
    [Address(RVA = "0x416679C", Offset = "0x416679C", VA = "0x416679C", Slot = "5")]
    public override void OnResume()
    {
    }

    [Token(Token = "0x601003E")]
    [Address(RVA = "0x41667A0", Offset = "0x41667A0", VA = "0x41667A0")]
    public SampleScene()
    {
    }
  }
}
