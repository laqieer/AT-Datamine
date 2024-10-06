// Decompiled with JetBrains decompiler
// Type: Battle.Data.Board.BoardData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Command;
using Battle.Grid;
using Battle.Process;
using Battle.RouteSearch;
using Battle.Unit;
using GameCore.MasterData;
using Il2CppDummyDll;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

#nullable disable
namespace Battle.Data.Board
{
  [Token(Token = "0x200275B")]
  public class BoardData : 
    IBoardDataHandler,
    IUnitParameterDataHandler,
    IBattlePlayerDataHandler,
    ISkillParameterDataHandler
  {
    [Token(Token = "0x400A838")]
    [FieldOffset(Offset = "0x3C")]
    public int ActivePlayerIndex;
    [Token(Token = "0x400A839")]
    [FieldOffset(Offset = "0x40")]
    private Dictionary<int, SkillParameterData> skillParamDic;
    [Token(Token = "0x400A83A")]
    [FieldOffset(Offset = "0x48")]
    private List<FacilityData> facilities;
    [Token(Token = "0x400A83B")]
    [FieldOffset(Offset = "0x50")]
    private List<UnitParameterData> unitParams;
    [Token(Token = "0x400A83C")]
    [FieldOffset(Offset = "0x58")]
    private Dictionary<int, UnitParameterData> unitParamDic;
    [Token(Token = "0x400A83D")]
    [FieldOffset(Offset = "0x60")]
    public List<VoicePlayData> VoicePlayedList;
    [Token(Token = "0x400A83E")]
    [FieldOffset(Offset = "0x68")]
    public Dictionary<int, int> UnitLevelReachedDic;
    [Token(Token = "0x400A83F")]
    [FieldOffset(Offset = "0x70")]
    public BattleAdvDataManager Adv;
    [Token(Token = "0x400A840")]
    [FieldOffset(Offset = "0x78")]
    public BattleMissionDataManager Mission;
    [Token(Token = "0x400A841")]
    [FieldOffset(Offset = "0x80")]
    public Queue<UnitCommandLog> ReservedCommand;
    [Token(Token = "0x400A842")]
    [FieldOffset(Offset = "0x88")]
    public UnitCommandLog ResumeCommand;
    [Token(Token = "0x400A843")]
    [FieldOffset(Offset = "0x90")]
    public PhaseCode ResumePhase;
    [Token(Token = "0x400A844")]
    [FieldOffset(Offset = "0x98")]
    public StringBuilder SecurityLog;
    [Token(Token = "0x400A849")]
    [FieldOffset(Offset = "0xC0")]
    private Dictionary<(MoveTypeEnum, bool), Battle.RouteSearch.Node[,]> moveRouteSearchNodeMap;
    [Token(Token = "0x400A84A")]
    [FieldOffset(Offset = "0xC8")]
    private Dictionary<int, List<GridData>> facilityGroupMap;

    [Token(Token = "0x170034A6")]
    public SceneParameter SceneParameter
    {
      [Token(Token = "0x600F5C6"), Address(RVA = "0x1ECB5D0", Offset = "0x1ECB5D0", VA = "0x1ECB5D0")] get
      {
        return (SceneParameter) null;
      }
      [Token(Token = "0x600F5C7"), Address(RVA = "0x1ECB5D8", Offset = "0x1ECB5D8", VA = "0x1ECB5D8")] private set
      {
      }
    }

    [Token(Token = "0x170034A7")]
    public BattleData BattleData
    {
      [Token(Token = "0x600F5C8"), Address(RVA = "0x1ECB5E0", Offset = "0x1ECB5E0", VA = "0x1ECB5E0")] get
      {
        return (BattleData) null;
      }
      [Token(Token = "0x600F5C9"), Address(RVA = "0x1ECB5E8", Offset = "0x1ECB5E8", VA = "0x1ECB5E8")] private set
      {
      }
    }

    [Token(Token = "0x170034A8")]
    public string Description
    {
      [Token(Token = "0x600F5CA"), Address(RVA = "0x1ECB5F0", Offset = "0x1ECB5F0", VA = "0x1ECB5F0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600F5CB"), Address(RVA = "0x1ECB5F8", Offset = "0x1ECB5F8", VA = "0x1ECB5F8")] set
      {
      }
    }

    [Token(Token = "0x170034A9")]
    public List<BattlePlayerData> Players
    {
      [Token(Token = "0x600F5CC"), Address(RVA = "0x1ECB600", Offset = "0x1ECB600", VA = "0x1ECB600")] get
      {
        return (List<BattlePlayerData>) null;
      }
      [Token(Token = "0x600F5CD"), Address(RVA = "0x1ECB608", Offset = "0x1ECB608", VA = "0x1ECB608")] private set
      {
      }
    }

    [Token(Token = "0x170034AA")]
    public Dictionary<int, BattlePlayerData> PlayerDic
    {
      [Token(Token = "0x600F5CE"), Address(RVA = "0x1ECB610", Offset = "0x1ECB610", VA = "0x1ECB610")] get
      {
        return (Dictionary<int, BattlePlayerData>) null;
      }
      [Token(Token = "0x600F5CF"), Address(RVA = "0x1ECB618", Offset = "0x1ECB618", VA = "0x1ECB618")] private set
      {
      }
    }

    [Token(Token = "0x170034AB")]
    public BattlePlayerData UserPlayer
    {
      [Token(Token = "0x600F5D0"), Address(RVA = "0x1ECB620", Offset = "0x1ECB620", VA = "0x1ECB620")] get
      {
        return (BattlePlayerData) null;
      }
    }

    [Token(Token = "0x170034AC")]
    public int Turn
    {
      [Token(Token = "0x600F5D1"), Address(RVA = "0x1ECB788", Offset = "0x1ECB788", VA = "0x1ECB788")] get
      {
        return new int();
      }
      [Token(Token = "0x600F5D2"), Address(RVA = "0x1ECB790", Offset = "0x1ECB790", VA = "0x1ECB790")] private set
      {
      }
    }

    [Token(Token = "0x170034AD")]
    public BattlePlayerData ActivePlayer
    {
      [Token(Token = "0x600F5D3"), Address(RVA = "0x1ECB798", Offset = "0x1ECB798", VA = "0x1ECB798")] get
      {
        return (BattlePlayerData) null;
      }
    }

    [Token(Token = "0x600F5D4")]
    [Address(RVA = "0x1ECB864", Offset = "0x1ECB864", VA = "0x1ECB864")]
    public int GetPlayerIndex(int playerId) => new int();

    [Token(Token = "0x170034AE")]
    public IReadOnlyList<UnitParameterData> UnitParams
    {
      [Token(Token = "0x600F5D5"), Address(RVA = "0x1ECB8E4", Offset = "0x1ECB8E4", VA = "0x1ECB8E4")] get
      {
        return (IReadOnlyList<UnitParameterData>) null;
      }
    }

    [Token(Token = "0x170034AF")]
    public IReadOnlyDictionary<int, UnitParameterData> UnitParamDic
    {
      [Token(Token = "0x600F5D6"), Address(RVA = "0x1ECB8EC", Offset = "0x1ECB8EC", VA = "0x1ECB8EC")] get
      {
        return (IReadOnlyDictionary<int, UnitParameterData>) null;
      }
    }

    [Token(Token = "0x170034B0")]
    public Vector2Int MapSize
    {
      [Token(Token = "0x600F5D7"), Address(RVA = "0x1ECB8F4", Offset = "0x1ECB8F4", VA = "0x1ECB8F4")] get
      {
        return new Vector2Int();
      }
      [Token(Token = "0x600F5D8"), Address(RVA = "0x1ECB8FC", Offset = "0x1ECB8FC", VA = "0x1ECB8FC")] private set
      {
      }
    }

    [Token(Token = "0x170034B1")]
    public Vector2Int UpLeftCoord
    {
      [Token(Token = "0x600F5D9"), Address(RVA = "0x1ECB904", Offset = "0x1ECB904", VA = "0x1ECB904")] get
      {
        return new Vector2Int();
      }
    }

    [Token(Token = "0x170034B2")]
    public Vector2Int UpRightCoord
    {
      [Token(Token = "0x600F5DA"), Address(RVA = "0x1ECB90C", Offset = "0x1ECB90C", VA = "0x1ECB90C")] get
      {
        return new Vector2Int();
      }
    }

    [Token(Token = "0x170034B3")]
    public Vector2Int DownLeftCoord
    {
      [Token(Token = "0x600F5DB"), Address(RVA = "0x1ECB914", Offset = "0x1ECB914", VA = "0x1ECB914")] get
      {
        return new Vector2Int();
      }
    }

    [Token(Token = "0x170034B4")]
    public Vector2Int DownRightCoord
    {
      [Token(Token = "0x600F5DC"), Address(RVA = "0x1ECB920", Offset = "0x1ECB920", VA = "0x1ECB920")] get
      {
        return new Vector2Int();
      }
    }

    [Token(Token = "0x170034B5")]
    public GridData[,] Grids
    {
      [Token(Token = "0x600F5DD"), Address(RVA = "0x1ECB928", Offset = "0x1ECB928", VA = "0x1ECB928")] get
      {
        return (GridData[,]) null;
      }
      [Token(Token = "0x600F5DE"), Address(RVA = "0x1ECB930", Offset = "0x1ECB930", VA = "0x1ECB930")] private set
      {
      }
    }

    [Token(Token = "0x170034B6")]
    public BoardSettings Validator
    {
      [Token(Token = "0x600F5DF"), Address(RVA = "0x1ECB938", Offset = "0x1ECB938", VA = "0x1ECB938")] get
      {
        return (BoardSettings) null;
      }
      [Token(Token = "0x600F5E0"), Address(RVA = "0x1ECB940", Offset = "0x1ECB940", VA = "0x1ECB940")] private set
      {
      }
    }

    [Token(Token = "0x170034B7")]
    public Battle.RouteSearch.Node[,] StandardNodes
    {
      [Token(Token = "0x600F5E1"), Address(RVA = "0x1ECB948", Offset = "0x1ECB948", VA = "0x1ECB948")] get
      {
        return (Battle.RouteSearch.Node[,]) null;
      }
      [Token(Token = "0x600F5E2"), Address(RVA = "0x1ECB950", Offset = "0x1ECB950", VA = "0x1ECB950")] private set
      {
      }
    }

    [Token(Token = "0x600F5E3")]
    [Address(RVA = "0x1ECB958", Offset = "0x1ECB958", VA = "0x1ECB958")]
    public void CreateFacilityCache()
    {
    }

    [Token(Token = "0x600F5E4")]
    [Address(RVA = "0x1ECBCB4", Offset = "0x1ECBCB4", VA = "0x1ECBCB4")]
    public List<GridData> GetFacilityGroup(int groupId) => (List<GridData>) null;

    [Token(Token = "0x600F5E5")]
    [Address(RVA = "0x1ECBD8C", Offset = "0x1ECBD8C", VA = "0x1ECBD8C")]
    public List<GridData> GetFacility() => (List<GridData>) null;

    [Token(Token = "0x600F5E6")]
    public List<GridData> GetFacility<TFacility>() where TFacility : FacilityData
    {
      return (List<GridData>) null;
    }

    [Token(Token = "0x600F5E7")]
    [Address(RVA = "0x1ECBDD4", Offset = "0x1ECBDD4", VA = "0x1ECBDD4")]
    public List<GridData> GetFacility(BattleFacilityTypeEnum type) => (List<GridData>) null;

    [Token(Token = "0x170034B8")]
    public Random Random
    {
      [Token(Token = "0x600F5E8"), Address(RVA = "0x1ECC138", Offset = "0x1ECC138", VA = "0x1ECC138")] get
      {
        return (Random) null;
      }
      [Token(Token = "0x600F5E9"), Address(RVA = "0x1ECC140", Offset = "0x1ECC140", VA = "0x1ECC140")] private set
      {
      }
    }

    [Token(Token = "0x600F5EA")]
    [Address(RVA = "0x1ECC148", Offset = "0x1ECC148", VA = "0x1ECC148")]
    private BoardData()
    {
    }

    [Token(Token = "0x600F5EB")]
    [Address(RVA = "0x1ECC50C", Offset = "0x1ECC50C", VA = "0x1ECC50C")]
    public static BoardData Create(SceneParameter sceneParameter, BoardSettings validator)
    {
      return (BoardData) null;
    }

    [Token(Token = "0x600F5EC")]
    [Address(RVA = "0x1ECC584", Offset = "0x1ECC584", VA = "0x1ECC584")]
    public void Initialize(
      Vector2Int mapSize,
      List<GridData> grids,
      BattleData battleData,
      int randomSeed)
    {
    }

    [Token(Token = "0x600F5ED")]
    [Address(RVA = "0x1ECC948", Offset = "0x1ECC948", VA = "0x1ECC948")]
    public BoardData Copy() => (BoardData) null;

    [Token(Token = "0x600F5EE")]
    [Address(RVA = "0x1ECC98C", Offset = "0x1ECC98C", VA = "0x1ECC98C")]
    private void Initialize(BoardData board)
    {
    }

    [Token(Token = "0x600F5EF")]
    [Address(RVA = "0x1ECC57C", Offset = "0x1ECC57C", VA = "0x1ECC57C")]
    public void SetValidator(BoardSettings validator)
    {
    }

    [Token(Token = "0x600F5F0")]
    [Address(RVA = "0x1ECC814", Offset = "0x1ECC814", VA = "0x1ECC814")]
    public void SetBasicData(BattleData battleData, int turn, int activePlayerIdx, Random random)
    {
    }

    [Token(Token = "0x600F5F1")]
    [Address(RVA = "0x1ECC630", Offset = "0x1ECC630", VA = "0x1ECC630")]
    public void SetGrid(Vector2Int mapSize, List<GridData> grids)
    {
    }

    [Token(Token = "0x600F5F2")]
    [Address(RVA = "0x1ECD3C0", Offset = "0x1ECD3C0", VA = "0x1ECD3C0")]
    public void CopyGrid(BoardData srcBoard)
    {
    }

    [Token(Token = "0x600F5F3")]
    [Address(RVA = "0x1ECDBCC", Offset = "0x1ECDBCC", VA = "0x1ECDBCC")]
    public void RePlaceAll()
    {
    }

    [Token(Token = "0x600F5F4")]
    [Address(RVA = "0x1ECD4C8", Offset = "0x1ECD4C8", VA = "0x1ECD4C8")]
    private void AddPlayer(BattlePlayerData player)
    {
    }

    [Token(Token = "0x600F5F5")]
    [Address(RVA = "0x1ECC824", Offset = "0x1ECC824", VA = "0x1ECC824")]
    private void ClearPlayer()
    {
    }

    [Token(Token = "0x600F5F6")]
    [Address(RVA = "0x1ECE814", Offset = "0x1ECE814", VA = "0x1ECE814")]
    private void AddUnitParam(UnitParameterData unitParam)
    {
    }

    [Token(Token = "0x600F5F7")]
    [Address(RVA = "0x1ECC8C0", Offset = "0x1ECC8C0", VA = "0x1ECC8C0")]
    private void ClearUnitParam()
    {
    }

    [Token(Token = "0x600F5F8")]
    [Address(RVA = "0x1ECE8FC", Offset = "0x1ECE8FC", VA = "0x1ECE8FC")]
    public void SetupTurnOrderByPlayerID()
    {
    }

    [Token(Token = "0x600F5F9")]
    [Address(RVA = "0x1ECB7EC", Offset = "0x1ECB7EC", VA = "0x1ECB7EC")]
    public BattlePlayerData GetPlayer(int id) => (BattlePlayerData) null;

    [Token(Token = "0x600F5FA")]
    [Address(RVA = "0x1ECBCAC", Offset = "0x1ECBCAC", VA = "0x1ECBCAC")]
    public GridData GetGrid(Vector2Int coord) => (GridData) null;

    [Token(Token = "0x600F5FB")]
    [Address(RVA = "0x1ECEADC", Offset = "0x1ECEADC", VA = "0x1ECEADC")]
    public GridData GetGrid(int x, int y) => (GridData) null;

    [Token(Token = "0x600F5FC")]
    [Address(RVA = "0x1ECEB50", Offset = "0x1ECEB50", VA = "0x1ECEB50")]
    public List<GridData> GetNeighborGrid(int x, int y) => (List<GridData>) null;

    [Token(Token = "0x600F5FD")]
    [Address(RVA = "0x1ECED9C", Offset = "0x1ECED9C", VA = "0x1ECED9C")]
    public Battle.RouteSearch.Node[,] GetRouteSearchNodes(MoveData moveType, bool largeUnit)
    {
      return (Battle.RouteSearch.Node[,]) null;
    }

    [Token(Token = "0x600F5FE")]
    [Address(RVA = "0x1ECD618", Offset = "0x1ECD618", VA = "0x1ECD618")]
    private void CreateStandardNodes()
    {
    }

    [Token(Token = "0x600F5FF")]
    [Address(RVA = "0x1ECD794", Offset = "0x1ECD794", VA = "0x1ECD794")]
    public void ResetMoveRouteSearchNode()
    {
    }

    [Token(Token = "0x600F600")]
    [Address(RVA = "0x1ECEE78", Offset = "0x1ECEE78", VA = "0x1ECEE78")]
    private Battle.RouteSearch.Node[,] GenerateMoveRouteSearchGridNodes(MoveTypeEnum moveType)
    {
      return (Battle.RouteSearch.Node[,]) null;
    }

    [Token(Token = "0x600F601")]
    [Address(RVA = "0x1ECF078", Offset = "0x1ECF078", VA = "0x1ECF078")]
    private Battle.RouteSearch.Node[,] GenerateMoveRouteSearchGridNodesForLargeUnit(
      MoveTypeEnum moveType)
    {
      return (Battle.RouteSearch.Node[,]) null;
    }

    [Token(Token = "0x600F602")]
    [Address(RVA = "0x1ECF320", Offset = "0x1ECF320", VA = "0x1ECF320")]
    public List<Vector2Int> GetEffectiveZoC(UnitParameterData target) => (List<Vector2Int>) null;

    [Token(Token = "0x600F603")]
    [Address(RVA = "0x1ECD0F0", Offset = "0x1ECD0F0", VA = "0x1ECD0F0")]
    public void SetupPlayerCorrelations()
    {
    }

    [Token(Token = "0x600F604")]
    [Address(RVA = "0x1ECFF58", Offset = "0x1ECFF58", VA = "0x1ECFF58")]
    public void SetupBattleAdv(int questId)
    {
    }

    [Token(Token = "0x600F605")]
    [Address(RVA = "0x1ECFFC8", Offset = "0x1ECFFC8", VA = "0x1ECFFC8")]
    public void SetupBattleMission(QuestTypeEnum questType, int missionId)
    {
    }

    [Token(Token = "0x170034B9")]
    public IEnumerable<UnitParameterData> OnBoardUnit
    {
      [Token(Token = "0x600F606"), Address(RVA = "0x1ECFB8C", Offset = "0x1ECFB8C", VA = "0x1ECFB8C")] get
      {
        return (IEnumerable<UnitParameterData>) null;
      }
    }

    [Token(Token = "0x600F607")]
    [Address(RVA = "0x1ED0074", Offset = "0x1ED0074", VA = "0x1ED0074")]
    public void SetAllUnitTargetState(TargetState state)
    {
    }

    [Token(Token = "0x600F608")]
    [Address(RVA = "0x1ED0380", Offset = "0x1ED0380", VA = "0x1ED0380")]
    public bool PlaceAround(UnitParameterData unitParam, Vector2Int mainCoord) => new bool();

    [Token(Token = "0x600F609")]
    [Address(RVA = "0x1ED0640", Offset = "0x1ED0640", VA = "0x1ED0640")]
    public bool PlaceAround(UnitParameterData unitParam, Vector2Int mainCoord, int distance)
    {
      return new bool();
    }

    [Token(Token = "0x600F60A")]
    [Address(RVA = "0x1ED084C", Offset = "0x1ED084C", VA = "0x1ED084C")]
    public bool TryPlaceFront(
      UnitParameterData unitParam,
      Vector2Int mainCoord,
      out GridData mainGrid,
      out IReadOnlyList<GridData> subGrids)
    {
      return new bool();
    }

    [Token(Token = "0x600F60B")]
    [Address(RVA = "0x1ED0E98", Offset = "0x1ED0E98", VA = "0x1ED0E98")]
    public bool TryPlace(
      UnitParameterData unitParam,
      Vector2Int mainCoord,
      out GridData mainGrid,
      out IReadOnlyList<GridData> subGrids)
    {
      return new bool();
    }

    [Token(Token = "0x600F60C")]
    [Address(RVA = "0x1ED0804", Offset = "0x1ED0804", VA = "0x1ED0804")]
    public bool PlaceFront(UnitParameterData unitParam, Vector2Int mainCoord) => new bool();

    [Token(Token = "0x600F60D")]
    [Address(RVA = "0x1ED1D9C", Offset = "0x1ED1D9C", VA = "0x1ED1D9C")]
    public bool Place(UnitParameterData unitParam, Vector2Int mainCoord) => new bool();

    [Token(Token = "0x600F60E")]
    [Address(RVA = "0x1ED17A4", Offset = "0x1ED17A4", VA = "0x1ED17A4")]
    public bool PlaceFront(UnitParameterData unitParam, GridData grid) => new bool();

    [Token(Token = "0x600F60F")]
    [Address(RVA = "0x1ECE0F8", Offset = "0x1ECE0F8", VA = "0x1ECE0F8")]
    public bool Place(UnitParameterData unitParam, GridData grid) => new bool();

    [Token(Token = "0x600F610")]
    [Address(RVA = "0x1ED1DE4", Offset = "0x1ED1DE4", VA = "0x1ED1DE4")]
    public void Remove(UnitParameterData unitParam)
    {
    }

    [Token(Token = "0x600F611")]
    [Address(RVA = "0x1ED2080", Offset = "0x1ED2080", VA = "0x1ED2080")]
    public NearGridInfo GetNearGridInfo(UnitParameterData unit) => new NearGridInfo();

    [Token(Token = "0x600F612")]
    [Address(RVA = "0x1ED03B8", Offset = "0x1ED03B8", VA = "0x1ED03B8")]
    public int MaxDistanceToMapCornersFrom(Vector2Int coord) => new int();

    [Token(Token = "0x600F613")]
    [Address(RVA = "0x1ED2D20", Offset = "0x1ED2D20", VA = "0x1ED2D20", Slot = "6")]
    public bool TryGetBattlePlayer(int id, out BattlePlayerData player) => new bool();

    [Token(Token = "0x600F614")]
    [Address(RVA = "0x1ED2D88", Offset = "0x1ED2D88", VA = "0x1ED2D88", Slot = "7")]
    public bool RegisterBattlePlayer(BattlePlayerData player) => new bool();

    [Token(Token = "0x600F615")]
    [Address(RVA = "0x1ECD5B0", Offset = "0x1ECD5B0", VA = "0x1ECD5B0", Slot = "4")]
    public bool TryGetUnitParameter(int id, out UnitParameterData param) => new bool();

    [Token(Token = "0x600F616")]
    [Address(RVA = "0x1ED2DD8", Offset = "0x1ED2DD8", VA = "0x1ED2DD8", Slot = "5")]
    public bool RegisterUnitParameter(UnitParameterData param) => new bool();

    [Token(Token = "0x600F617")]
    [Address(RVA = "0x1ED2E38", Offset = "0x1ED2E38", VA = "0x1ED2E38", Slot = "8")]
    public int RequestSkillParameterId() => new int();

    [Token(Token = "0x600F618")]
    [Address(RVA = "0x1ED2E90", Offset = "0x1ED2E90", VA = "0x1ED2E90", Slot = "9")]
    public bool TryGetSkillParameter(int id, out SkillParameterData skillParam) => new bool();

    [Token(Token = "0x600F619")]
    [Address(RVA = "0x1ED2EF8", Offset = "0x1ED2EF8", VA = "0x1ED2EF8", Slot = "10")]
    public bool RegisterSkillParameter(SkillParameterData skillParam) => new bool();

    [Token(Token = "0x600F61A")]
    [Address(RVA = "0x1ED2F88", Offset = "0x1ED2F88", VA = "0x1ED2F88")]
    public IReadOnlyList<SkillParameterData> GetSkillParameterList()
    {
      return (IReadOnlyList<SkillParameterData>) null;
    }

    [Token(Token = "0x600F61B")]
    [Address(RVA = "0x1ECD3EC", Offset = "0x1ECD3EC", VA = "0x1ECD3EC")]
    public bool RegisterFacility(FacilityData facility) => new bool();

    [Token(Token = "0x600F61C")]
    [Address(RVA = "0x1ED2FF4", Offset = "0x1ED2FF4", VA = "0x1ED2FF4")]
    public IReadOnlyList<FacilityData> GetFacilityDataList() => (IReadOnlyList<FacilityData>) null;

    [Token(Token = "0x600F61D")]
    [Address(RVA = "0x1ED2FFC", Offset = "0x1ED2FFC", VA = "0x1ED2FFC")]
    public bool IsStoppableGrid(Vector2Int coord, MoveData moveType) => new bool();

    [Token(Token = "0x600F61E")]
    [Address(RVA = "0x1ED3038", Offset = "0x1ED3038", VA = "0x1ED3038")]
    public PathSearcher2D.NodeValidationCallback GetAttackableSearchStartNodeValidator(
      UnitParameterData actionUnit)
    {
      return (PathSearcher2D.NodeValidationCallback) null;
    }

    [Token(Token = "0x600F61F")]
    [Address(RVA = "0x1ED3064", Offset = "0x1ED3064", VA = "0x1ED3064")]
    public PathSearcher2D.NodeValidationCallback GetAttackableSearchTargetValidator(
      UnitParameterData actionUnit,
      SkillParameterData skill,
      BoardSettings.ExtendAttackableSearchTargetValidator extendValidator = null)
    {
      return (PathSearcher2D.NodeValidationCallback) null;
    }

    [Token(Token = "0x600F620")]
    [Address(RVA = "0x1ED3098", Offset = "0x1ED3098", VA = "0x1ED3098")]
    public PathSearcher2D.NodeValidationCallback GetMovableSearchTargetValidator(
      UnitParameterData actionUnit)
    {
      return (PathSearcher2D.NodeValidationCallback) null;
    }

    [Token(Token = "0x600F621")]
    [Address(RVA = "0x1ED30C4", Offset = "0x1ED30C4", VA = "0x1ED30C4", Slot = "11")]
    public virtual PathSearcher2D.NodeValidationCallback GetOccupiableSearchTargetValidator(
      UnitParameterData actionUnit)
    {
      return (PathSearcher2D.NodeValidationCallback) null;
    }

    [Token(Token = "0x600F622")]
    [Address(RVA = "0x1ED30F0", Offset = "0x1ED30F0", VA = "0x1ED30F0")]
    public void CountUpTurn()
    {
    }

    [Token(Token = "0x600F623")]
    [Address(RVA = "0x1ED3100", Offset = "0x1ED3100", VA = "0x1ED3100")]
    public string ToJson() => (string) null;
  }
}
