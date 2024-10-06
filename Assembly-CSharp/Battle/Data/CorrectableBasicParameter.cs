// Decompiled with JetBrains decompiler
// Type: Battle.Data.CorrectableBasicParameter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using StaqData;

#nullable disable
namespace Battle.Data
{
  [Token(Token = "0x2002723")]
  public class CorrectableBasicParameter : ICorrectableParameter<IBasicParameter>
  {
    [Token(Token = "0x400A763")]
    [FieldOffset(Offset = "0x10")]
    private BasicParameter baseParam;
    [Token(Token = "0x400A764")]
    [FieldOffset(Offset = "0x18")]
    private BasicParameter calculated;
    [Token(Token = "0x400A765")]
    [FieldOffset(Offset = "0x20")]
    private BasicParameter totalOffset;
    [Token(Token = "0x400A766")]
    [FieldOffset(Offset = "0x28")]
    private BasicParameter fixedOffset;
    [Token(Token = "0x400A767")]
    [FieldOffset(Offset = "0x30")]
    public BasicParameter ratedOffset;

    [Token(Token = "0x170033CD")]
    public IBasicParameter BaseParam
    {
      [Token(Token = "0x600F34E"), Address(RVA = "0x1FA176C", Offset = "0x1FA176C", VA = "0x1FA176C", Slot = "4")] get
      {
        return (IBasicParameter) null;
      }
    }

    [Token(Token = "0x170033CE")]
    public IBasicParameter Calculated
    {
      [Token(Token = "0x600F34F"), Address(RVA = "0x1FA1774", Offset = "0x1FA1774", VA = "0x1FA1774", Slot = "5")] get
      {
        return (IBasicParameter) null;
      }
    }

    [Token(Token = "0x170033CF")]
    public IBasicParameter TotalOffset
    {
      [Token(Token = "0x600F350"), Address(RVA = "0x1FA177C", Offset = "0x1FA177C", VA = "0x1FA177C", Slot = "6")] get
      {
        return (IBasicParameter) null;
      }
    }

    [Token(Token = "0x170033D0")]
    public IBasicParameter FixedOffset
    {
      [Token(Token = "0x600F351"), Address(RVA = "0x1FA1784", Offset = "0x1FA1784", VA = "0x1FA1784", Slot = "7")] get
      {
        return (IBasicParameter) null;
      }
    }

    [Token(Token = "0x170033D1")]
    public IBasicParameter RatedOffset
    {
      [Token(Token = "0x600F352"), Address(RVA = "0x1FA178C", Offset = "0x1FA178C", VA = "0x1FA178C", Slot = "8")] get
      {
        return (IBasicParameter) null;
      }
    }

    [Token(Token = "0x600F353")]
    [Address(RVA = "0x1F9F68C", Offset = "0x1F9F68C", VA = "0x1F9F68C")]
    public CorrectableBasicParameter()
    {
    }

    [Token(Token = "0x600F354")]
    [Address(RVA = "0x1FA1794", Offset = "0x1FA1794", VA = "0x1FA1794")]
    public CorrectableBasicParameter(ICorrectableParameter<IBasicParameter> src)
    {
    }

    [Token(Token = "0x600F355")]
    [Address(RVA = "0x1F9C7F0", Offset = "0x1F9C7F0", VA = "0x1F9C7F0")]
    public CorrectableBasicParameter(
      IBasicParameter baseParam = null,
      IBasicParameter fixedOffset = null,
      IBasicParameter ratedOffset = null)
    {
    }

    [Token(Token = "0x600F356")]
    [Address(RVA = "0x1FA1800", Offset = "0x1FA1800", VA = "0x1FA1800", Slot = "9")]
    public void CalcParameters()
    {
    }

    [Token(Token = "0x600F357")]
    [Address(RVA = "0x1FA1EA4", Offset = "0x1FA1EA4", VA = "0x1FA1EA4", Slot = "10")]
    public void ResetParameters()
    {
    }

    [Token(Token = "0x600F358")]
    [Address(RVA = "0x1F9F6E0", Offset = "0x1F9F6E0", VA = "0x1F9F6E0")]
    public void Update(ICorrectableParameter<IBasicParameter> src)
    {
    }

    [Token(Token = "0x600F359")]
    [Address(RVA = "0x1FA1D24", Offset = "0x1FA1D24", VA = "0x1FA1D24")]
    private int CalcTotalBasicParameterValue(BasicParameterType basicParamType) => new int();
  }
}
