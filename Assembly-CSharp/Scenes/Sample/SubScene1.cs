// Decompiled with JetBrains decompiler
// Type: Scenes.Sample.SubScene1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Scene;
using Il2CppDummyDll;
using System.Collections;

#nullable disable
namespace Scenes.Sample
{
  [Token(Token = "0x20028BB")]
  public class SubScene1 : SubScene
  {
    [Token(Token = "0x6010063")]
    [Address(RVA = "0x4166ABC", Offset = "0x4166ABC", VA = "0x4166ABC", Slot = "6")]
    public override void Initialize(ChangeSceneParameter param)
    {
    }

    [Token(Token = "0x6010064")]
    [Address(RVA = "0x4166B04", Offset = "0x4166B04", VA = "0x4166B04", Slot = "7")]
    public override IEnumerator InitializeAsync() => (IEnumerator) null;

    [Token(Token = "0x6010065")]
    [Address(RVA = "0x4166B8C", Offset = "0x4166B8C", VA = "0x4166B8C", Slot = "8")]
    public override void Disable()
    {
    }

    [Token(Token = "0x6010066")]
    [Address(RVA = "0x4166B94", Offset = "0x4166B94", VA = "0x4166B94", Slot = "9")]
    public override void Destroy()
    {
    }

    [Token(Token = "0x6010067")]
    [Address(RVA = "0x4166B98", Offset = "0x4166B98", VA = "0x4166B98", Slot = "4")]
    public override void OnPause()
    {
    }

    [Token(Token = "0x6010068")]
    [Address(RVA = "0x4166B9C", Offset = "0x4166B9C", VA = "0x4166B9C", Slot = "5")]
    public override void OnResume()
    {
    }

    [Token(Token = "0x6010069")]
    [Address(RVA = "0x4166BA0", Offset = "0x4166BA0", VA = "0x4166BA0", Slot = "25")]
    public override void OnBackScene()
    {
    }

    [Token(Token = "0x601006A")]
    [Address(RVA = "0x4166BA4", Offset = "0x4166BA4", VA = "0x4166BA4", Slot = "26")]
    public override IEnumerator OnBackSceneAsync() => (IEnumerator) null;

    [Token(Token = "0x601006B")]
    [Address(RVA = "0x4166C2C", Offset = "0x4166C2C", VA = "0x4166C2C")]
    private void Update()
    {
    }

    [Token(Token = "0x601006C")]
    [Address(RVA = "0x4166C30", Offset = "0x4166C30", VA = "0x4166C30")]
    public SubScene1()
    {
    }
  }
}
