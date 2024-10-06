// Decompiled with JetBrains decompiler
// Type: Battle.UI.AdditionalParameterModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using GameCore.MasterData;
using Il2CppDummyDll;
using Scenes.OutGame.Info.Common;
using System.Collections.Generic;

#nullable disable
namespace Battle.UI
{
  [Token(Token = "0x2002393")]
  public class AdditionalParameterModel : AdditionalParameterModelBase
  {
    [Token(Token = "0x600D94D")]
    [Address(RVA = "0x22C92A8", Offset = "0x22C92A8", VA = "0x22C92A8")]
    private AdditionalParameter CreateAddtionalParam(GameCore.MasterData.ElementType element, string label, int value)
    {
      return (AdditionalParameter) null;
    }

    [Token(Token = "0x600D94E")]
    [Address(RVA = "0x22C9320", Offset = "0x22C9320", VA = "0x22C9320")]
    private void AddReinforce(GameCore.MasterData.ElementType element, string label, int value)
    {
    }

    [Token(Token = "0x600D94F")]
    [Address(RVA = "0x22C93F8", Offset = "0x22C93F8", VA = "0x22C93F8")]
    private void AddResist(GameCore.MasterData.ElementType element, string label, int value)
    {
    }

    [Token(Token = "0x600D950")]
    [Address(RVA = "0x22C94D0", Offset = "0x22C94D0", VA = "0x22C94D0")]
    private void AddSlay(GameCore.MasterData.ElementType element, string label, int value)
    {
    }

    [Token(Token = "0x600D951")]
    [Address(RVA = "0x22C95A8", Offset = "0x22C95A8", VA = "0x22C95A8")]
    private void AddResistSlay(GameCore.MasterData.ElementType element, string label, int value)
    {
    }

    [Token(Token = "0x600D952")]
    [Address(RVA = "0x22C9680", Offset = "0x22C9680", VA = "0x22C9680")]
    private void Clear()
    {
    }

    [Token(Token = "0x600D953")]
    [Address(RVA = "0x22C6AAC", Offset = "0x22C6AAC", VA = "0x22C6AAC")]
    public void Set(AdditionalParameterModelBase additional)
    {
    }

    [Token(Token = "0x600D954")]
    [Address(RVA = "0x22C9794", Offset = "0x22C9794", VA = "0x22C9794")]
    public void Set(UnitParameterData unit, WeaponParameterData weapon)
    {
    }

    [Token(Token = "0x600D955")]
    [Address(RVA = "0x22CBBD8", Offset = "0x22CBBD8", VA = "0x22CBBD8")]
    public void Set(WeaponParameterData weapon)
    {
    }

    [Token(Token = "0x600D956")]
    [Address(RVA = "0x22CBE14", Offset = "0x22CBE14", VA = "0x22CBE14")]
    public void Set(AccessoryData acc)
    {
    }

    [Token(Token = "0x600D957")]
    [Address(RVA = "0x22C68C0", Offset = "0x22C68C0", VA = "0x22C68C0")]
    public void Set(Battle.Data.Board.MindEquipmentData mindEquipment)
    {
    }

    [Token(Token = "0x600D958")]
    [Address(RVA = "0x22CC2F8", Offset = "0x22CC2F8", VA = "0x22CC2F8")]
    public void Set(Battle.Data.Board.TrustData trust)
    {
    }

    [Token(Token = "0x600D959")]
    [Address(RVA = "0x22C97DC", Offset = "0x22C97DC", VA = "0x22C97DC")]
    private AdditionalParameterModel.TempParam GetTempParam(
      UnitParameterData unit,
      WeaponParameterData currentWeapon)
    {
      return new AdditionalParameterModel.TempParam();
    }

    [Token(Token = "0x600D95A")]
    [Address(RVA = "0x22CBC1C", Offset = "0x22CBC1C", VA = "0x22CBC1C")]
    private AdditionalParameterModel.TempParam CreateTempParam(WeaponParameterData weapon)
    {
      return new AdditionalParameterModel.TempParam();
    }

    [Token(Token = "0x600D95B")]
    [Address(RVA = "0x22CBE58", Offset = "0x22CBE58", VA = "0x22CBE58")]
    private AdditionalParameterModel.TempParam CreateTempParam(AccessoryData acc)
    {
      return new AdditionalParameterModel.TempParam();
    }

    [Token(Token = "0x600D95C")]
    [Address(RVA = "0x22CC100", Offset = "0x22CC100", VA = "0x22CC100")]
    private AdditionalParameterModel.TempParam CreateTempParam(Battle.Data.Board.MindEquipmentData mindEquipment)
    {
      return new AdditionalParameterModel.TempParam();
    }

    [Token(Token = "0x600D95D")]
    [Address(RVA = "0x22CC33C", Offset = "0x22CC33C", VA = "0x22CC33C")]
    private AdditionalParameterModel.TempParam CreateTempParam(Battle.Data.Board.TrustData trust)
    {
      return new AdditionalParameterModel.TempParam();
    }

    [Token(Token = "0x600D95E")]
    [Address(RVA = "0x22CD418", Offset = "0x22CD418", VA = "0x22CD418")]
    private AdditionalParameterModel.TempParam CreateTempParam(List<Battle.Data.Board.SkillData> skills)
    {
      return new AdditionalParameterModel.TempParam();
    }

    [Token(Token = "0x600D95F")]
    [Address(RVA = "0x22CC824", Offset = "0x22CC824", VA = "0x22CC824")]
    private AdditionalParameterModel.TempParam CreateTempParam(List<SkillParameterData> skillParams)
    {
      return new AdditionalParameterModel.TempParam();
    }

    [Token(Token = "0x600D960")]
    [Address(RVA = "0x22C9E70", Offset = "0x22C9E70", VA = "0x22C9E70")]
    private void Set(AdditionalParameterModel.TempParam param)
    {
    }

    [Token(Token = "0x600D961")]
    [Address(RVA = "0x22C7158", Offset = "0x22C7158", VA = "0x22C7158")]
    public AdditionalParameterModel()
    {
    }

    [Token(Token = "0x2002394")]
    private struct TempParam
    {
      [Token(Token = "0x400975A")]
      [FieldOffset(Offset = "0x0")]
      public static int elementLength;
      [Token(Token = "0x400975B")]
      [FieldOffset(Offset = "0x4")]
      public static int attackTypeLength;
      [Token(Token = "0x400975C")]
      [FieldOffset(Offset = "0x8")]
      public static int badStatLength;
      [Token(Token = "0x400975D")]
      [FieldOffset(Offset = "0xC")]
      public static int moveTypeLength;
      [Token(Token = "0x400975E")]
      [FieldOffset(Offset = "0x10")]
      public static int armorTypeLength;
      [Token(Token = "0x400975F")]
      [FieldOffset(Offset = "0x14")]
      public static int rideTypeLength;
      [Token(Token = "0x4009760")]
      [FieldOffset(Offset = "0x18")]
      public static int speciesTypeLength;
      [Token(Token = "0x4009761")]
      [FieldOffset(Offset = "0x0")]
      public int[] reinforceElement;
      [Token(Token = "0x4009762")]
      [FieldOffset(Offset = "0x8")]
      public int[] reinforceAttackType;
      [Token(Token = "0x4009763")]
      [FieldOffset(Offset = "0x10")]
      public int[] reinforceBadStat;
      [Token(Token = "0x4009764")]
      [FieldOffset(Offset = "0x18")]
      public int[] resistElement;
      [Token(Token = "0x4009765")]
      [FieldOffset(Offset = "0x20")]
      public int[] resistAttackType;
      [Token(Token = "0x4009766")]
      [FieldOffset(Offset = "0x28")]
      public int[] resistBadStat;
      [Token(Token = "0x4009767")]
      [FieldOffset(Offset = "0x30")]
      public int[] slayMove;
      [Token(Token = "0x4009768")]
      [FieldOffset(Offset = "0x38")]
      public int[] slayArmor;
      [Token(Token = "0x4009769")]
      [FieldOffset(Offset = "0x40")]
      public int[] slayRide;
      [Token(Token = "0x400976A")]
      [FieldOffset(Offset = "0x48")]
      public int[] slaySpecies;
      [Token(Token = "0x400976B")]
      [FieldOffset(Offset = "0x50")]
      public int[] resistSlayMove;
      [Token(Token = "0x400976C")]
      [FieldOffset(Offset = "0x58")]
      public int[] resistSlayArmor;
      [Token(Token = "0x400976D")]
      [FieldOffset(Offset = "0x60")]
      public int[] resistSlayRide;
      [Token(Token = "0x400976E")]
      [FieldOffset(Offset = "0x68")]
      public int[] resistSlaySpecies;

      [Token(Token = "0x600D962")]
      [Address(RVA = "0x22CC5E4", Offset = "0x22CC5E4", VA = "0x22CC5E4")]
      public static AdditionalParameterModel.TempParam Create()
      {
        return new AdditionalParameterModel.TempParam();
      }

      [Token(Token = "0x600D963")]
      [Address(RVA = "0x22CCF60", Offset = "0x22CCF60", VA = "0x22CCF60")]
      public void Add(AdditionalParameterModel.TempParam src)
      {
      }

      [Token(Token = "0x600D964")]
      [Address(RVA = "0x22CDB60", Offset = "0x22CDB60", VA = "0x22CDB60")]
      static TempParam()
      {
      }
    }
  }
}
