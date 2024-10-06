// Decompiled with JetBrains decompiler
// Type: Battle.Data.Board.ArmorBreakSeruper
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;

#nullable disable
namespace Battle.Data.Board
{
  [Token(Token = "0x200277A")]
  public class ArmorBreakSeruper : BadStatusSetuper
  {
    [Token(Token = "0x600F68A")]
    [Address(RVA = "0x1ED6D5C", Offset = "0x1ED6D5C", VA = "0x1ED6D5C", Slot = "4")]
    public override RestrictedInfo CreateRestrictedInfo() => new RestrictedInfo();

    [Token(Token = "0x600F68B")]
    [Address(RVA = "0x1ED6DA0", Offset = "0x1ED6DA0", VA = "0x1ED6DA0", Slot = "5")]
    public override EffectiveLengthTypeEnum GetEffectiveLength() => new EffectiveLengthTypeEnum();

    [Token(Token = "0x600F68C")]
    [Address(RVA = "0x1ED6A68", Offset = "0x1ED6A68", VA = "0x1ED6A68")]
    public ArmorBreakSeruper()
    {
    }
  }
}
