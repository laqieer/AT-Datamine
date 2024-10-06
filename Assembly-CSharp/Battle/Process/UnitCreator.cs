// Decompiled with JetBrains decompiler
// Type: Battle.Process.UnitCreator
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data;
using Battle.Data.Board;
using GameCore.MasterData;
using Il2CppDummyDll;
using StaqData;
using System.Collections.Generic;

#nullable disable
namespace Battle.Process
{
  [Token(Token = "0x20026B5")]
  public class UnitCreator : UnitCreatorBase
  {
    [Token(Token = "0x400A5F8")]
    [FieldOffset(Offset = "0x18")]
    private BoardData boardData;
    [Token(Token = "0x400A5F9")]
    [FieldOffset(Offset = "0x20")]
    private StoryBattleConfig config;

    [Token(Token = "0x600EFB6")]
    [Address(RVA = "0x40DD2EC", Offset = "0x40DD2EC", VA = "0x40DD2EC")]
    private UnitCreator()
    {
    }

    [Token(Token = "0x600EFB7")]
    [Address(RVA = "0x40DD2FC", Offset = "0x40DD2FC", VA = "0x40DD2FC")]
    public UnitCreator(BattleCore battleCore)
    {
    }

    [Token(Token = "0x600EFB8")]
    [Address(RVA = "0x40DD3D4", Offset = "0x40DD3D4", VA = "0x40DD3D4")]
    private UnitParameterData CreateUserUnit(
      int id,
      DeckSlot slot,
      Dictionary<int, BasicParameter> lvUpInfo,
      ForceTypeEnum force)
    {
      return (UnitParameterData) null;
    }

    [Token(Token = "0x600EFB9")]
    [Address(RVA = "0x40DD5F0", Offset = "0x40DD5F0", VA = "0x40DD5F0")]
    public UnitCreatorBase.ArmyProductData CreateAllies(Deck deck, int[] sortieSlots)
    {
      return new UnitCreatorBase.ArmyProductData();
    }

    [Token(Token = "0x600EFBA")]
    [Address(RVA = "0x40DE220", Offset = "0x40DE220", VA = "0x40DE220")]
    public UnitCreatorBase.ArmyProductData CreateAlliesOnResume()
    {
      return new UnitCreatorBase.ArmyProductData();
    }

    [Token(Token = "0x600EFBB")]
    [Address(RVA = "0x40DE4BC", Offset = "0x40DE4BC", VA = "0x40DE4BC")]
    public UnitCreatorBase.ArmyProductData CreateGuests(List<IUnitPlacementData> placements)
    {
      return new UnitCreatorBase.ArmyProductData();
    }

    [Token(Token = "0x600EFBC")]
    [Address(RVA = "0x40DE67C", Offset = "0x40DE67C", VA = "0x40DE67C")]
    public UnitCreatorBase.ArmyProductData CreateEnemies(List<IUnitPlacementData> placements)
    {
      return new UnitCreatorBase.ArmyProductData();
    }

    [Token(Token = "0x600EFBD")]
    [Address(RVA = "0x40DE83C", Offset = "0x40DE83C", VA = "0x40DE83C")]
    public UnitCreatorBase.ArmyProductData CreateThirds(List<IUnitPlacementData> placements)
    {
      return new UnitCreatorBase.ArmyProductData();
    }

    [Token(Token = "0x600EFBE")]
    private List<UnitParameterData> CreateNpc<TPlaceInfo>(
      IReadOnlyList<TPlaceInfo> placements,
      ForceTypeEnum force)
      where TPlaceInfo : IUnitPlacementData
    {
      return (List<UnitParameterData>) null;
    }

    [Token(Token = "0x600EFBF")]
    [Address(RVA = "0x40DE9FC", Offset = "0x40DE9FC", VA = "0x40DE9FC")]
    public UnitCreatorBase.ArmyProductData CreateGuestsOnResume()
    {
      return new UnitCreatorBase.ArmyProductData();
    }

    [Token(Token = "0x600EFC0")]
    [Address(RVA = "0x40DEB44", Offset = "0x40DEB44", VA = "0x40DEB44")]
    public UnitCreatorBase.ArmyProductData CreateEnemiesOnResume()
    {
      return new UnitCreatorBase.ArmyProductData();
    }

    [Token(Token = "0x600EFC1")]
    [Address(RVA = "0x40DEBF4", Offset = "0x40DEBF4", VA = "0x40DEBF4")]
    public UnitCreatorBase.ArmyProductData CreateThirdsOnResume()
    {
      return new UnitCreatorBase.ArmyProductData();
    }

    [Token(Token = "0x600EFC2")]
    [Address(RVA = "0x40DEAAC", Offset = "0x40DEAAC", VA = "0x40DEAAC")]
    private List<UnitParameterData> CreateNpcOnResume(int playerId)
    {
      return (List<UnitParameterData>) null;
    }
  }
}
