// Decompiled with JetBrains decompiler
// Type: FreeMap.State.Process.ShowMap
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.State.ModeState;
using Il2CppDummyDll;

#nullable disable
namespace FreeMap.State.Process
{
  [Token(Token = "0x20017E5")]
  public class ShowMap : FreeMapProcess
  {
    [Token(Token = "0x40068E2")]
    [FieldOffset(Offset = "0x38")]
    private IPlayerAreaOperationEvent playerOperation;

    [Token(Token = "0x600872C")]
    [Address(RVA = "0x43D50DC", Offset = "0x43D50DC", VA = "0x43D50DC")]
    public ShowMap(FreeMapStateManager entity, IPlayerAreaOperationEvent playerOperation)
    {
    }

    [Token(Token = "0x600872D")]
    [Address(RVA = "0x43D5100", Offset = "0x43D5100", VA = "0x43D5100", Slot = "4")]
    public override void Begin()
    {
    }
  }
}
