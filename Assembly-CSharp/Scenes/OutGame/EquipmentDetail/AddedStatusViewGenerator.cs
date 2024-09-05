// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.EquipmentDetail.AddedStatusViewGenerator
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using StaqData;
using System;
using System.Collections.Generic;

#nullable disable
namespace Scenes.OutGame.EquipmentDetail
{
  [Token(Token = "0x2003672")]
  public class AddedStatusViewGenerator
  {
    [Token(Token = "0x400ECDF")]
    [FieldOffset(Offset = "0x0")]
    private static Func<string, string> GetText;
    [Token(Token = "0x400ECE0")]
    [FieldOffset(Offset = "0x8")]
    public static Func<string> ATTACK_ENHANCEMENT_NAME;
    [Token(Token = "0x400ECE1")]
    [FieldOffset(Offset = "0x10")]
    public static Func<string> ENHASNCED_RESISTANCE_NAME;
    [Token(Token = "0x400ECE2")]
    [FieldOffset(Offset = "0x18")]
    public static Func<string> REINFORCE_NAME;
    [Token(Token = "0x400ECE3")]
    [FieldOffset(Offset = "0x20")]
    public static Func<string> RESIST_NAME;
    [Token(Token = "0x400ECE4")]
    [FieldOffset(Offset = "0x28")]
    public static Func<string> SLAY_NAME;
    [Token(Token = "0x400ECE5")]
    [FieldOffset(Offset = "0x30")]
    public static Func<string> RESIST_SLAY_NAME;
    [Token(Token = "0x400ECE6")]
    [FieldOffset(Offset = "0x38")]
    public static Func<string> REINFORCE_LABEL;
    [Token(Token = "0x400ECE7")]
    [FieldOffset(Offset = "0x40")]
    public static Func<string> RESIST_LABEL;
    [Token(Token = "0x400ECE8")]
    [FieldOffset(Offset = "0x48")]
    public static Func<string> SLAY_LABEL;
    [Token(Token = "0x400ECE9")]
    [FieldOffset(Offset = "0x50")]
    public static Func<string> RESIST_SLAY_LABEL;
    [Token(Token = "0x400ECEA")]
    [FieldOffset(Offset = "0x10")]
    private Action<string> _createTitleFunc;
    [Token(Token = "0x400ECEB")]
    [FieldOffset(Offset = "0x18")]
    private Action<string, int, int?> _createItemFunc;
    [Token(Token = "0x400ECEC")]
    [FieldOffset(Offset = "0x20")]
    private Action<bool> _visibleNothingFunc;

    [Token(Token = "0x60156D8")]
    [Address(RVA = "0x18E0CA4", Offset = "0x18E0CA4", VA = "0x18E0CA4")]
    public AddedStatusViewGenerator(
      Action<string> createTitleFunc,
      Action<string, int, int?> createItemFunc,
      Action<bool> visibleNothingFunc = null)
    {
    }

    [Token(Token = "0x60156D9")]
    [Address(RVA = "0x18E0CE0", Offset = "0x18E0CE0", VA = "0x18E0CE0")]
    public AddedStatusViewGenerator(
      Action<string> createTitleFunc,
      Action<string, int> createItemFunc,
      Action<bool> visibleNothingFunc = null)
    {
    }

    [Token(Token = "0x60156DA")]
    [Address(RVA = "0x18E0DC0", Offset = "0x18E0DC0", VA = "0x18E0DC0")]
    public void Apply(Equipment equipmentData, Equipment assumption = null)
    {
    }

    [Token(Token = "0x60156DB")]
    [Address(RVA = "0x18E1640", Offset = "0x18E1640", VA = "0x18E1640")]
    private int AddGroup(string title, List<AddedStatusViewGenerator.Entry> entries) => new int();

    [Token(Token = "0x60156DC")]
    [Address(RVA = "0x18E0EDC", Offset = "0x18E0EDC", VA = "0x18E0EDC")]
    private List<AddedStatusViewGenerator.Entry> GetReinforce(
      Equipment equipmentData,
      Equipment assumption = null)
    {
      return (List<AddedStatusViewGenerator.Entry>) null;
    }

    [Token(Token = "0x60156DD")]
    [Address(RVA = "0x18E1778", Offset = "0x18E1778", VA = "0x18E1778")]
    private List<AddedStatusViewGenerator.Entry> GetResist(
      Equipment equipmentData,
      Equipment assumption = null)
    {
      return (List<AddedStatusViewGenerator.Entry>) null;
    }

    [Token(Token = "0x60156DE")]
    [Address(RVA = "0x18E1EDC", Offset = "0x18E1EDC", VA = "0x18E1EDC")]
    static AddedStatusViewGenerator()
    {
    }

    [Token(Token = "0x2003673")]
    private struct Entry
    {
      [Token(Token = "0x400ECED")]
      [FieldOffset(Offset = "0x0")]
      public string Name;
      [Token(Token = "0x400ECEE")]
      [FieldOffset(Offset = "0x8")]
      public int Num;
      [Token(Token = "0x400ECEF")]
      [FieldOffset(Offset = "0xC")]
      public int? AssumeNum;
    }
  }
}
