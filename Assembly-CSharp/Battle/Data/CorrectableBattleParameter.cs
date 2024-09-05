// Decompiled with JetBrains decompiler
// Type: Battle.Data.CorrectableBattleParameter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using StaqData;

#nullable disable
namespace Battle.Data
{
  [Token(Token = "0x2002724")]
  public class CorrectableBattleParameter : ICorrectableParameter<IBattleParameter>
  {
    [Token(Token = "0x400A768")]
    [FieldOffset(Offset = "0x10")]
    private BattleParameter baseParam;
    [Token(Token = "0x400A769")]
    [FieldOffset(Offset = "0x18")]
    private BattleParameter calculated;
    [Token(Token = "0x400A76A")]
    [FieldOffset(Offset = "0x20")]
    private BattleParameter totalOffset;
    [Token(Token = "0x400A76B")]
    [FieldOffset(Offset = "0x28")]
    private BattleParameter fixedOffset;
    [Token(Token = "0x400A76C")]
    [FieldOffset(Offset = "0x30")]
    private BattleParameter ratedOffset;

    [Token(Token = "0x170033D2")]
    public IBattleParameter BaseParam
    {
      [Token(Token = "0x600F35A"), Address(RVA = "0x1FA1F5C", Offset = "0x1FA1F5C", VA = "0x1FA1F5C", Slot = "4")] get
      {
        return (IBattleParameter) null;
      }
    }

    [Token(Token = "0x170033D3")]
    public IBattleParameter Calculated
    {
      [Token(Token = "0x600F35B"), Address(RVA = "0x1FA1F64", Offset = "0x1FA1F64", VA = "0x1FA1F64", Slot = "5")] get
      {
        return (IBattleParameter) null;
      }
    }

    [Token(Token = "0x170033D4")]
    public IBattleParameter TotalOffset
    {
      [Token(Token = "0x600F35C"), Address(RVA = "0x1FA1F6C", Offset = "0x1FA1F6C", VA = "0x1FA1F6C", Slot = "6")] get
      {
        return (IBattleParameter) null;
      }
    }

    [Token(Token = "0x170033D5")]
    public IBattleParameter FixedOffset
    {
      [Token(Token = "0x600F35D"), Address(RVA = "0x1FA1F74", Offset = "0x1FA1F74", VA = "0x1FA1F74", Slot = "7")] get
      {
        return (IBattleParameter) null;
      }
    }

    [Token(Token = "0x170033D6")]
    public IBattleParameter RatedOffset
    {
      [Token(Token = "0x600F35E"), Address(RVA = "0x1FA1F7C", Offset = "0x1FA1F7C", VA = "0x1FA1F7C", Slot = "8")] get
      {
        return (IBattleParameter) null;
      }
    }

    [Token(Token = "0x600F35F")]
    [Address(RVA = "0x1FA1F84", Offset = "0x1FA1F84", VA = "0x1FA1F84")]
    public CorrectableBattleParameter()
    {
    }

    [Token(Token = "0x600F360")]
    [Address(RVA = "0x1FA1FD8", Offset = "0x1FA1FD8", VA = "0x1FA1FD8")]
    public CorrectableBattleParameter(ICorrectableParameter<IBattleParameter> src)
    {
    }

    [Token(Token = "0x600F361")]
    [Address(RVA = "0x1F9F5C8", Offset = "0x1F9F5C8", VA = "0x1F9F5C8")]
    public CorrectableBattleParameter(
      IBattleParameter baseParam = null,
      IBattleParameter fixedOffset = null,
      IBattleParameter ratedOffset = null)
    {
    }

    [Token(Token = "0x600F362")]
    [Address(RVA = "0x1FA22D4", Offset = "0x1FA22D4", VA = "0x1FA22D4", Slot = "9")]
    public void CalcParameters()
    {
    }

    [Token(Token = "0x600F363")]
    [Address(RVA = "0x1FA2A64", Offset = "0x1FA2A64", VA = "0x1FA2A64", Slot = "10")]
    public void ResetParameters()
    {
    }

    [Token(Token = "0x600F364")]
    [Address(RVA = "0x1FA2044", Offset = "0x1FA2044", VA = "0x1FA2044")]
    public void Update(ICorrectableParameter<IBattleParameter> src)
    {
    }

    [Token(Token = "0x600F365")]
    [Address(RVA = "0x1FA28E4", Offset = "0x1FA28E4", VA = "0x1FA28E4")]
    private int CalcTotalBattleParameterValue(BattleParameterType battleParamType) => new int();
  }
}
