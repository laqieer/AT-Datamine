// Decompiled with JetBrains decompiler
// Type: StaqData.SubQuestManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network.Param;
using System.Collections.Generic;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x20020EF")]
  public class SubQuestManager
  {
    [Token(Token = "0x4008B7A")]
    [FieldOffset(Offset = "0x10")]
    private Dictionary<int, SubQuestData> subQuestList;

    [Token(Token = "0x17002B04")]
    public IEnumerable<SubQuestData> AllItem
    {
      [Token(Token = "0x600C798"), Address(RVA = "0x1CDFE80", Offset = "0x1CDFE80", VA = "0x1CDFE80")] get
      {
        return (IEnumerable<SubQuestData>) null;
      }
    }

    [Token(Token = "0x17002B05")]
    public SubQuestData Receipting
    {
      [Token(Token = "0x600C799"), Address(RVA = "0x1CDFED0", Offset = "0x1CDFED0", VA = "0x1CDFED0")] get
      {
        return (SubQuestData) null;
      }
    }

    [Token(Token = "0x17002B06")]
    public IEnumerable<int> ClearedSubQuestIDs
    {
      [Token(Token = "0x600C79A"), Address(RVA = "0x1CDFEE4", Offset = "0x1CDFEE4", VA = "0x1CDFEE4")] get
      {
        return (IEnumerable<int>) null;
      }
    }

    [Token(Token = "0x17002B07")]
    public int ClearedSubQuestKindCount
    {
      [Token(Token = "0x600C79B"), Address(RVA = "0x1CE00AC", Offset = "0x1CE00AC", VA = "0x1CE00AC")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600C79C")]
    [Address(RVA = "0x1CDDE74", Offset = "0x1CDDE74", VA = "0x1CDDE74")]
    public SubQuestData Get(int subquestID) => (SubQuestData) null;

    [Token(Token = "0x600C79D")]
    [Address(RVA = "0x1CE0190", Offset = "0x1CE0190", VA = "0x1CE0190")]
    public bool Contains(int subquestID) => new bool();

    [Token(Token = "0x600C79E")]
    [Address(RVA = "0x1CE00F8", Offset = "0x1CE00F8", VA = "0x1CE00F8")]
    protected SubQuestData Add(int subquestID) => (SubQuestData) null;

    [Token(Token = "0x600C79F")]
    [Address(RVA = "0x1CE0200", Offset = "0x1CE0200", VA = "0x1CE0200")]
    public void Clear()
    {
    }

    [Token(Token = "0x600C7A0")]
    [Address(RVA = "0x1CE0250", Offset = "0x1CE0250", VA = "0x1CE0250")]
    public void Setup(int groupLabel)
    {
    }

    [Token(Token = "0x600C7A1")]
    [Address(RVA = "0x1CDB138", Offset = "0x1CDB138", VA = "0x1CDB138")]
    public void Apply(IEnumerable<PlayerStorySubQuestType> subquestTypes)
    {
    }

    [Token(Token = "0x600C7A2")]
    [Address(RVA = "0x1CE05D4", Offset = "0x1CE05D4", VA = "0x1CE05D4")]
    public void Apply(PlayerStorySubQuestType res)
    {
    }

    [Token(Token = "0x600C7A3")]
    [Address(RVA = "0x1CE05AC", Offset = "0x1CE05AC", VA = "0x1CE05AC")]
    private void OnApply(PlayerStorySubQuestType subquestTypes)
    {
    }

    [Token(Token = "0x600C7A4")]
    [Address(RVA = "0x1CDAA8C", Offset = "0x1CDAA8C", VA = "0x1CDAA8C")]
    public SubQuestManager()
    {
    }
  }
}
