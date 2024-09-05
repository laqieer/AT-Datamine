// Decompiled with JetBrains decompiler
// Type: Battle.Process.Arena.UnitCreator
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data;
using Battle.Data.Board;
using GameCore.MasterData;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Battle.Process.Arena
{
  [Token(Token = "0x20026DB")]
  public class UnitCreator : UnitCreatorBase
  {
    [Token(Token = "0x400A642")]
    [FieldOffset(Offset = "0x18")]
    private ArenaBattleConfig config;

    [Token(Token = "0x600F065")]
    [Address(RVA = "0x41A54C0", Offset = "0x41A54C0", VA = "0x41A54C0")]
    private UnitCreator()
    {
    }

    [Token(Token = "0x170032BF")]
    public Dictionary<int, int> PlacementDic
    {
      [Token(Token = "0x600F066"), Address(RVA = "0x41A553C", Offset = "0x41A553C", VA = "0x41A553C")] get
      {
        return (Dictionary<int, int>) null;
      }
      [Token(Token = "0x600F067"), Address(RVA = "0x41A5544", Offset = "0x41A5544", VA = "0x41A5544")] private set
      {
      }
    }

    [Token(Token = "0x600F068")]
    [Address(RVA = "0x41A554C", Offset = "0x41A554C", VA = "0x41A554C")]
    public UnitCreator(BattleCore battleCore)
    {
    }

    [Token(Token = "0x600F069")]
    [Address(RVA = "0x41A563C", Offset = "0x41A563C", VA = "0x41A563C")]
    public UnitCreatorBase.ArmyProductData CreateUserUnits(
      List<IUnitPlacementData> placements,
      ForceTypeEnum force,
      DeckTypeEnum deckType = DeckTypeEnum.PVP_OFFENSE)
    {
      return new UnitCreatorBase.ArmyProductData();
    }

    [Token(Token = "0x600F06A")]
    [Address(RVA = "0x41A5E14", Offset = "0x41A5E14", VA = "0x41A5E14")]
    public UnitCreatorBase.ArmyProductData CreateOpponentUnits(
      List<IUnitPlacementData> placements,
      ForceTypeEnum force)
    {
      return new UnitCreatorBase.ArmyProductData();
    }

    [Token(Token = "0x600F06B")]
    [Address(RVA = "0x41A6608", Offset = "0x41A6608", VA = "0x41A6608")]
    public UnitCreatorBase.ArmyProductData CreateUnits(
      List<int> deck,
      List<IUnitPlacementData> placements,
      QuestCorrection correction,
      ForceTypeEnum force)
    {
      return new UnitCreatorBase.ArmyProductData();
    }

    [Token(Token = "0x600F06C")]
    [Address(RVA = "0x41A69B4", Offset = "0x41A69B4", VA = "0x41A69B4")]
    private List<UnitParameterData> CreateNpc(
      List<int> deck,
      IReadOnlyList<IUnitPlacementData> placements,
      QuestCorrection correction,
      ForceTypeEnum force)
    {
      return (List<UnitParameterData>) null;
    }
  }
}
