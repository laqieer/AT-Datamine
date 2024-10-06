// Decompiled with JetBrains decompiler
// Type: FreeMap.State.Process.FreeMapSubTutorial
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace FreeMap.State.Process
{
  [Token(Token = "0x20017DB")]
  public class FreeMapSubTutorial : FreeMapProcess
  {
    [Token(Token = "0x40068D7")]
    [FieldOffset(Offset = "0x31")]
    private bool isOpenTutorial;
    [Token(Token = "0x40068D8")]
    [FieldOffset(Offset = "0x34")]
    private int tutorialId;

    [Token(Token = "0x6008708")]
    [Address(RVA = "0x43D3DDC", Offset = "0x43D3DDC", VA = "0x43D3DDC")]
    public FreeMapSubTutorial(FreeMapStateManager entity, int tutorialId)
    {
    }

    [Token(Token = "0x6008709")]
    [Address(RVA = "0x43D3E08", Offset = "0x43D3E08", VA = "0x43D3E08", Slot = "4")]
    public override void Begin()
    {
    }

    [Token(Token = "0x600870A")]
    [Address(RVA = "0x43D3F28", Offset = "0x43D3F28", VA = "0x43D3F28", Slot = "5")]
    protected override void OnUpdate()
    {
    }
  }
}
