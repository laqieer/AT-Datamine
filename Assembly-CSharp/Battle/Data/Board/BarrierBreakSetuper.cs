// Decompiled with JetBrains decompiler
// Type: Battle.Data.Board.BarrierBreakSetuper
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;

#nullable disable
namespace Battle.Data.Board
{
  [Token(Token = "0x2002779")]
  public class BarrierBreakSetuper : BadStatusSetuper
  {
    [Token(Token = "0x600F687")]
    [Address(RVA = "0x1ED6D10", Offset = "0x1ED6D10", VA = "0x1ED6D10", Slot = "4")]
    public override RestrictedInfo CreateRestrictedInfo() => new RestrictedInfo();

    [Token(Token = "0x600F688")]
    [Address(RVA = "0x1ED6D54", Offset = "0x1ED6D54", VA = "0x1ED6D54", Slot = "5")]
    public override EffectiveLengthTypeEnum GetEffectiveLength() => new EffectiveLengthTypeEnum();

    [Token(Token = "0x600F689")]
    [Address(RVA = "0x1ED6A60", Offset = "0x1ED6A60", VA = "0x1ED6A60")]
    public BarrierBreakSetuper()
    {
    }
  }
}
