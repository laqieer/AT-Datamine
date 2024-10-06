// Decompiled with JetBrains decompiler
// Type: Battle.Data.EffectParameterContainer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using GameCore.MasterData;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Battle.Data
{
  [Token(Token = "0x2002726")]
  public class EffectParameterContainer : IEffectParameterContainer
  {
    [Token(Token = "0x400A76D")]
    [FieldOffset(Offset = "0x10")]
    private System.Collections.Generic.List<EffectParameterData> list;

    [Token(Token = "0x170033DC")]
    public System.Collections.Generic.List<EffectParameterData> List
    {
      [Token(Token = "0x600F36D"), Address(RVA = "0x1FA2B1C", Offset = "0x1FA2B1C", VA = "0x1FA2B1C", Slot = "4")] get
      {
        return (System.Collections.Generic.List<EffectParameterData>) null;
      }
    }

    [Token(Token = "0x170033DD")]
    public int Count
    {
      [Token(Token = "0x600F36E"), Address(RVA = "0x1FA2B98", Offset = "0x1FA2B98", VA = "0x1FA2B98", Slot = "5")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170033DE")]
    public bool Any
    {
      [Token(Token = "0x600F36F"), Address(RVA = "0x1FA2BE0", Offset = "0x1FA2BE0", VA = "0x1FA2BE0", Slot = "6")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600F370")]
    [Address(RVA = "0x1FA2BF8", Offset = "0x1FA2BF8", VA = "0x1FA2BF8", Slot = "7")]
    public void Add(EffectParameterData param)
    {
    }

    [Token(Token = "0x600F371")]
    [Address(RVA = "0x1FA2CA0", Offset = "0x1FA2CA0", VA = "0x1FA2CA0", Slot = "8")]
    public void AddRange(IEnumerable<EffectParameterData> list)
    {
    }

    [Token(Token = "0x600F372")]
    [Address(RVA = "0x1FA2F78", Offset = "0x1FA2F78", VA = "0x1FA2F78", Slot = "9")]
    public void Remove(EffectParameterData param)
    {
    }

    [Token(Token = "0x600F373")]
    [Address(RVA = "0x1FA2FD0", Offset = "0x1FA2FD0", VA = "0x1FA2FD0", Slot = "10")]
    public System.Collections.Generic.List<EffectParameterData> RemoveExpiredEffects()
    {
      return (System.Collections.Generic.List<EffectParameterData>) null;
    }

    [Token(Token = "0x600F374")]
    [Address(RVA = "0x1FA3130", Offset = "0x1FA3130", VA = "0x1FA3130", Slot = "11")]
    public void Clear()
    {
    }

    [Token(Token = "0x600F375")]
    [Address(RVA = "0x1FA31A0", Offset = "0x1FA31A0", VA = "0x1FA31A0", Slot = "12")]
    public System.Collections.Generic.List<EffectParameterData> GetDeactivateTriggeredEffects(
      EffectiveLengthTypeEnum length)
    {
      return (System.Collections.Generic.List<EffectParameterData>) null;
    }

    [Token(Token = "0x600F376")]
    [Address(RVA = "0x1FA33C8", Offset = "0x1FA33C8", VA = "0x1FA33C8")]
    public void Elapse(int turnNumber, int phaseIndex)
    {
    }

    [Token(Token = "0x600F377")]
    [Address(RVA = "0x1FA351C", Offset = "0x1FA351C", VA = "0x1FA351C")]
    public EffectParameterContainer()
    {
    }
  }
}
