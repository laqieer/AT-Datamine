// Decompiled with JetBrains decompiler
// Type: Battle.Data.Board.BadStatusSetuper
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;

#nullable disable
namespace Battle.Data.Board
{
  [Token(Token = "0x2002775")]
  public class BadStatusSetuper
  {
    [Token(Token = "0x600F67E")]
    [Address(RVA = "0x1ED6A80", Offset = "0x1ED6A80", VA = "0x1ED6A80", Slot = "4")]
    public virtual RestrictedInfo CreateRestrictedInfo() => new RestrictedInfo();

    [Token(Token = "0x600F67F")]
    [Address(RVA = "0x1ED6A8C", Offset = "0x1ED6A8C", VA = "0x1ED6A8C", Slot = "5")]
    public virtual EffectiveLengthTypeEnum GetEffectiveLength() => new EffectiveLengthTypeEnum();

    [Token(Token = "0x600F680")]
    [Address(RVA = "0x1ED6A70", Offset = "0x1ED6A70", VA = "0x1ED6A70")]
    public BadStatusSetuper()
    {
    }
  }
}
