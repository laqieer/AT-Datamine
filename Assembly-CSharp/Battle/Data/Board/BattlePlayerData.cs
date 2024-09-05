// Decompiled with JetBrains decompiler
// Type: Battle.Data.Board.BattlePlayerData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Commander;
using Battle.UI;
using GameCore.MasterData;
using Il2CppDummyDll;
using Network.Param;
using System;
using System.Collections.Generic;

#nullable disable
namespace Battle.Data.Board
{
  [Token(Token = "0x2002758")]
  public class BattlePlayerData
  {
    [Token(Token = "0x400A824")]
    [FieldOffset(Offset = "0x88")]
    private List<WeakReference<BattlePlayerData>> friendPlayersWeakRef;
    [Token(Token = "0x400A825")]
    [FieldOffset(Offset = "0x90")]
    private List<WeakReference<BattlePlayerData>> hostilePlayersWeakRef;

    [Token(Token = "0x17003493")]
    public int Id
    {
      [Token(Token = "0x600F58F"), Address(RVA = "0x1EC81D4", Offset = "0x1EC81D4", VA = "0x1EC81D4")] get
      {
        return new int();
      }
      [Token(Token = "0x600F590"), Address(RVA = "0x1EC81DC", Offset = "0x1EC81DC", VA = "0x1EC81DC")] private set
      {
      }
    }

    [Token(Token = "0x17003494")]
    public int ClearCondition
    {
      [Token(Token = "0x600F591"), Address(RVA = "0x1EC81E4", Offset = "0x1EC81E4", VA = "0x1EC81E4")] get
      {
        return new int();
      }
      [Token(Token = "0x600F592"), Address(RVA = "0x1EC81EC", Offset = "0x1EC81EC", VA = "0x1EC81EC")] private set
      {
      }
    }

    [Token(Token = "0x17003495")]
    public int FailedCondition
    {
      [Token(Token = "0x600F593"), Address(RVA = "0x1EC81F4", Offset = "0x1EC81F4", VA = "0x1EC81F4")] get
      {
        return new int();
      }
      [Token(Token = "0x600F594"), Address(RVA = "0x1EC81FC", Offset = "0x1EC81FC", VA = "0x1EC81FC")] private set
      {
      }
    }

    [Token(Token = "0x17003496")]
    public List<UnitParameterData> OwnedUnitParams
    {
      [Token(Token = "0x600F595"), Address(RVA = "0x1EC8204", Offset = "0x1EC8204", VA = "0x1EC8204")] get
      {
        return (List<UnitParameterData>) null;
      }
      [Token(Token = "0x600F596"), Address(RVA = "0x1EC820C", Offset = "0x1EC820C", VA = "0x1EC820C")] private set
      {
      }
    }

    [Token(Token = "0x17003497")]
    public List<UnitParameterData> ControlledUnitParams
    {
      [Token(Token = "0x600F597"), Address(RVA = "0x1EC8214", Offset = "0x1EC8214", VA = "0x1EC8214")] get
      {
        return (List<UnitParameterData>) null;
      }
      [Token(Token = "0x600F598"), Address(RVA = "0x1EC821C", Offset = "0x1EC821C", VA = "0x1EC821C")] private set
      {
      }
    }

    [Token(Token = "0x17003498")]
    public List<ItemParameterData> ItemParams
    {
      [Token(Token = "0x600F599"), Address(RVA = "0x1EC8224", Offset = "0x1EC8224", VA = "0x1EC8224")] get
      {
        return (List<ItemParameterData>) null;
      }
      [Token(Token = "0x600F59A"), Address(RVA = "0x1EC822C", Offset = "0x1EC822C", VA = "0x1EC822C")] private set
      {
      }
    }

    [Token(Token = "0x17003499")]
    public Battle.Data.CharacterSupportData Supports
    {
      [Token(Token = "0x600F59B"), Address(RVA = "0x1EC8234", Offset = "0x1EC8234", VA = "0x1EC8234")] get
      {
        return (Battle.Data.CharacterSupportData) null;
      }
      [Token(Token = "0x600F59C"), Address(RVA = "0x1EC823C", Offset = "0x1EC823C", VA = "0x1EC823C")] private set
      {
      }
    }

    [Token(Token = "0x1700349A")]
    public ControllerType ControllerType
    {
      [Token(Token = "0x600F59D"), Address(RVA = "0x1EC8244", Offset = "0x1EC8244", VA = "0x1EC8244")] get
      {
        return new ControllerType();
      }
      [Token(Token = "0x600F59E"), Address(RVA = "0x1EC824C", Offset = "0x1EC824C", VA = "0x1EC824C")] private set
      {
      }
    }

    [Token(Token = "0x1700349B")]
    public Dictionary<int, int> GottenDropItemList
    {
      [Token(Token = "0x600F59F"), Address(RVA = "0x1EC8254", Offset = "0x1EC8254", VA = "0x1EC8254")] get
      {
        return (Dictionary<int, int>) null;
      }
      [Token(Token = "0x600F5A0"), Address(RVA = "0x1EC825C", Offset = "0x1EC825C", VA = "0x1EC825C")] private set
      {
      }
    }

    [Token(Token = "0x1700349C")]
    public List<int> OpenedChestIds
    {
      [Token(Token = "0x600F5A1"), Address(RVA = "0x1EC8264", Offset = "0x1EC8264", VA = "0x1EC8264")] get
      {
        return (List<int>) null;
      }
      [Token(Token = "0x600F5A2"), Address(RVA = "0x1EC826C", Offset = "0x1EC826C", VA = "0x1EC826C")] private set
      {
      }
    }

    [Token(Token = "0x1700349D")]
    public bool IsUser
    {
      [Token(Token = "0x600F5A3"), Address(RVA = "0x1EC8274", Offset = "0x1EC8274", VA = "0x1EC8274")] get
      {
        return new bool();
      }
      [Token(Token = "0x600F5A4"), Address(RVA = "0x1EC827C", Offset = "0x1EC827C", VA = "0x1EC827C")] set
      {
      }
    }

    [Token(Token = "0x1700349E")]
    public UnitController UnitController
    {
      [Token(Token = "0x600F5A5"), Address(RVA = "0x1EC8288", Offset = "0x1EC8288", VA = "0x1EC8288")] get
      {
        return (UnitController) null;
      }
      [Token(Token = "0x600F5A6"), Address(RVA = "0x1EC8290", Offset = "0x1EC8290", VA = "0x1EC8290")] set
      {
      }
    }

    [Token(Token = "0x1700349F")]
    public PlayerPhaseEffector Effector
    {
      [Token(Token = "0x600F5A7"), Address(RVA = "0x1EC8298", Offset = "0x1EC8298", VA = "0x1EC8298")] get
      {
        return (PlayerPhaseEffector) null;
      }
      [Token(Token = "0x600F5A8"), Address(RVA = "0x1EC82A0", Offset = "0x1EC82A0", VA = "0x1EC82A0")] set
      {
      }
    }

    [Token(Token = "0x170034A0")]
    public bool ExistsActionable
    {
      [Token(Token = "0x600F5A9"), Address(RVA = "0x1EC82A8", Offset = "0x1EC82A8", VA = "0x1EC82A8")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170034A1")]
    public List<BattleClearConditionData> ClearConditions
    {
      [Token(Token = "0x600F5AA"), Address(RVA = "0x1EC84A8", Offset = "0x1EC84A8", VA = "0x1EC84A8")] get
      {
        return (List<BattleClearConditionData>) null;
      }
      [Token(Token = "0x600F5AB"), Address(RVA = "0x1EC84B0", Offset = "0x1EC84B0", VA = "0x1EC84B0")] private set
      {
      }
    }

    [Token(Token = "0x170034A2")]
    public List<BattleFailedConditionData> FailedConditions
    {
      [Token(Token = "0x600F5AC"), Address(RVA = "0x1EC84B8", Offset = "0x1EC84B8", VA = "0x1EC84B8")] get
      {
        return (List<BattleFailedConditionData>) null;
      }
      [Token(Token = "0x600F5AD"), Address(RVA = "0x1EC84C0", Offset = "0x1EC84C0", VA = "0x1EC84C0")] private set
      {
      }
    }

    [Token(Token = "0x170034A3")]
    public List<TroopsData> Troopses
    {
      [Token(Token = "0x600F5AE"), Address(RVA = "0x1EC84C8", Offset = "0x1EC84C8", VA = "0x1EC84C8")] get
      {
        return (List<TroopsData>) null;
      }
      [Token(Token = "0x600F5AF"), Address(RVA = "0x1EC84D0", Offset = "0x1EC84D0", VA = "0x1EC84D0")] private set
      {
      }
    }

    [Token(Token = "0x170034A4")]
    public List<BattlePlayerData> FriendPlayers
    {
      [Token(Token = "0x600F5B0"), Address(RVA = "0x1EC84D8", Offset = "0x1EC84D8", VA = "0x1EC84D8")] get
      {
        return (List<BattlePlayerData>) null;
      }
    }

    [Token(Token = "0x170034A5")]
    public List<BattlePlayerData> HostilePlayers
    {
      [Token(Token = "0x600F5B1"), Address(RVA = "0x1EC8710", Offset = "0x1EC8710", VA = "0x1EC8710")] get
      {
        return (List<BattlePlayerData>) null;
      }
    }

    [Token(Token = "0x600F5B2")]
    [Address(RVA = "0x1EC8948", Offset = "0x1EC8948", VA = "0x1EC8948")]
    public bool ContainsHostile(int playerId) => new bool();

    [Token(Token = "0x600F5B3")]
    [Address(RVA = "0x1EC8AB0", Offset = "0x1EC8AB0", VA = "0x1EC8AB0")]
    public static BattlePlayerData Create(BattlePlayerSource source) => (BattlePlayerData) null;

    [Token(Token = "0x600F5B4")]
    public static BattlePlayerData Clone<THandler>(BattlePlayerData src, THandler handler) where THandler : IUnitParameterDataHandler, ISkillParameterDataHandler
    {
      return (BattlePlayerData) null;
    }

    [Token(Token = "0x600F5B5")]
    [Address(RVA = "0x1EC945C", Offset = "0x1EC945C", VA = "0x1EC945C")]
    public static BattlePlayerData CreateFromSchema(
      staq.SaveSchema.BattlePlayerData schema,
      IBattleDataHandler battleDataHandler,
      IBoardDataHandler boardDataHandler)
    {
      return (BattlePlayerData) null;
    }

    [Token(Token = "0x600F5B6")]
    [Address(RVA = "0x1EC9EA0", Offset = "0x1EC9EA0", VA = "0x1EC9EA0")]
    public bool IsOwned(UnitParameterData unitParam) => new bool();

    [Token(Token = "0x600F5B7")]
    [Address(RVA = "0x1EC9EF8", Offset = "0x1EC9EF8", VA = "0x1EC9EF8")]
    public void AddFriendPlayers(IEnumerable<BattlePlayerData> players)
    {
    }

    [Token(Token = "0x600F5B8")]
    [Address(RVA = "0x1ECA2AC", Offset = "0x1ECA2AC", VA = "0x1ECA2AC")]
    public void AddHostilePlayers(IEnumerable<BattlePlayerData> players)
    {
    }

    [Token(Token = "0x600F5B9")]
    [Address(RVA = "0x1ECA660", Offset = "0x1ECA660", VA = "0x1ECA660")]
    public void ClearCorrelationPlayers()
    {
    }

    [Token(Token = "0x600F5BA")]
    [Address(RVA = "0x1ECA6FC", Offset = "0x1ECA6FC", VA = "0x1ECA6FC")]
    public bool IsFriend(BattlePlayerData player) => new bool();

    [Token(Token = "0x600F5BB")]
    [Address(RVA = "0x1ECA888", Offset = "0x1ECA888", VA = "0x1ECA888")]
    public bool IsAlly(BattlePlayerData player) => new bool();

    [Token(Token = "0x600F5BC")]
    [Address(RVA = "0x1ECA8B8", Offset = "0x1ECA8B8", VA = "0x1ECA8B8")]
    public bool IsHostile(BattlePlayerData player) => new bool();

    [Token(Token = "0x600F5BD")]
    [Address(RVA = "0x1EC91F4", Offset = "0x1EC91F4", VA = "0x1EC91F4")]
    public void SetupTroopses(List<TroopsData> troopses)
    {
    }

    [Token(Token = "0x600F5BE")]
    [Address(RVA = "0x1ECAA44", Offset = "0x1ECAA44", VA = "0x1ECAA44")]
    public void SortieUnit(UnitParameterData unit, bool isQuick)
    {
    }

    [Token(Token = "0x600F5BF")]
    [Address(RVA = "0x1ECAB54", Offset = "0x1ECAB54", VA = "0x1ECAB54")]
    public void RemoveControl(UnitParameterData unit)
    {
    }

    [Token(Token = "0x600F5C0")]
    [Address(RVA = "0x1ECABAC", Offset = "0x1ECABAC", VA = "0x1ECABAC")]
    public UnitParameterData GetFirstPlacedMainUnitParam() => (UnitParameterData) null;

    [Token(Token = "0x600F5C1")]
    [Address(RVA = "0x1ECAD20", Offset = "0x1ECAD20", VA = "0x1ECAD20")]
    public void OpenChest(ChestFacilityData chest)
    {
    }

    [Token(Token = "0x600F5C2")]
    [Address(RVA = "0x1ECADCC", Offset = "0x1ECADCC", VA = "0x1ECADCC")]
    public List<PlayerBattleConsumedExpendable> GetExpendableInfos()
    {
      return (List<PlayerBattleConsumedExpendable>) null;
    }

    [Token(Token = "0x600F5C3")]
    [Address(RVA = "0x1ECB048", Offset = "0x1ECB048", VA = "0x1ECB048")]
    public void AddGottenDropItemList(int dropType, int num)
    {
    }

    [Token(Token = "0x600F5C4")]
    [Address(RVA = "0x1ECB138", Offset = "0x1ECB138", VA = "0x1ECB138")]
    public string ToJson() => (string) null;

    [Token(Token = "0x600F5C5")]
    [Address(RVA = "0x1EC8FDC", Offset = "0x1EC8FDC", VA = "0x1EC8FDC")]
    public BattlePlayerData()
    {
    }
  }
}
