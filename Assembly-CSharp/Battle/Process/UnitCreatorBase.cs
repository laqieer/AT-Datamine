// Decompiled with JetBrains decompiler
// Type: Battle.Process.UnitCreatorBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data;
using Battle.Data.Board;
using GameCore.MasterData;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Battle.Process
{
  [Token(Token = "0x20026B8")]
  public class UnitCreatorBase
  {
    [Token(Token = "0x400A601")]
    [FieldOffset(Offset = "0x10")]
    private BoardData board;

    [Token(Token = "0x170032A8")]
    protected IBoardDataHandler boardHandler
    {
      [Token(Token = "0x600EFCC"), Address(RVA = "0x40DED70", Offset = "0x40DED70", VA = "0x40DED70")] get
      {
        return (IBoardDataHandler) null;
      }
    }

    [Token(Token = "0x170032A9")]
    protected IBattleDataHandler dataHandler
    {
      [Token(Token = "0x600EFCD"), Address(RVA = "0x40DD5D4", Offset = "0x40DD5D4", VA = "0x40DD5D4")] get
      {
        return (IBattleDataHandler) null;
      }
    }

    [Token(Token = "0x600EFCE")]
    [Address(RVA = "0x40DD2F4", Offset = "0x40DD2F4", VA = "0x40DD2F4")]
    protected UnitCreatorBase()
    {
    }

    [Token(Token = "0x600EFCF")]
    [Address(RVA = "0x40DD3AC", Offset = "0x40DD3AC", VA = "0x40DD3AC")]
    public UnitCreatorBase(BoardData board)
    {
    }

    [Token(Token = "0x600EFD0")]
    [Address(RVA = "0x40DE0D0", Offset = "0x40DE0D0", VA = "0x40DE0D0")]
    protected UnitParameterData CreateNpc(
      int unitId,
      int npcId,
      QuestCorrection correction,
      int troops,
      int baseExp,
      int damage,
      int barrierId,
      int barrierMaxHp,
      ForceTypeEnum force)
    {
      return (UnitParameterData) null;
    }

    [Token(Token = "0x600EFD1")]
    protected List<TroopsData> CreateTroops<TTroopsMaster>(
      TTroopsMaster troopsMaster,
      int placementId)
      where TTroopsMaster : ITroopsMaster
    {
      return (List<TroopsData>) null;
    }

    [Token(Token = "0x20026B9")]
    public struct ArmyProductData
    {
      [Token(Token = "0x170032AA")]
      public List<UnitParameterData> UnitParams
      {
        [Token(Token = "0x600EFD2"), Address(RVA = "0x40DED78", Offset = "0x40DED78", VA = "0x40DED78")] readonly get
        {
          return (List<UnitParameterData>) null;
        }
        [Token(Token = "0x600EFD3"), Address(RVA = "0x40DED80", Offset = "0x40DED80", VA = "0x40DED80")] set
        {
        }
      }

      [Token(Token = "0x170032AB")]
      public List<TroopsData> Troopses
      {
        [Token(Token = "0x600EFD4"), Address(RVA = "0x40DED88", Offset = "0x40DED88", VA = "0x40DED88")] readonly get
        {
          return (List<TroopsData>) null;
        }
        [Token(Token = "0x600EFD5"), Address(RVA = "0x40DED90", Offset = "0x40DED90", VA = "0x40DED90")] set
        {
        }
      }

      [Token(Token = "0x170032AC")]
      public bool IsValid
      {
        [Token(Token = "0x600EFD6"), Address(RVA = "0x40DED98", Offset = "0x40DED98", VA = "0x40DED98")] get
        {
          return new bool();
        }
      }
    }
  }
}
