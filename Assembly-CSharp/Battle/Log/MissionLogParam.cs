// Decompiled with JetBrains decompiler
// Type: Battle.Log.MissionLogParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using GameCore.MasterData;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Battle.Log
{
  [Token(Token = "0x2002515")]
  public class MissionLogParam
  {
    [Token(Token = "0x4009F50")]
    [FieldOffset(Offset = "0x10")]
    private List<UnitMissionLogParam> unitLogs;
    [Token(Token = "0x4009F59")]
    [FieldOffset(Offset = "0x38")]
    private HashSet<int> destroyObjectIds;
    [Token(Token = "0x4009F5B")]
    [FieldOffset(Offset = "0x48")]
    private List<MissionLogParam.UseGimmickParam> useGimmickParams;

    [Token(Token = "0x17003108")]
    public int StageId
    {
      [Token(Token = "0x600E4C9"), Address(RVA = "0x47895C8", Offset = "0x47895C8", VA = "0x47895C8")] get
      {
        return new int();
      }
      [Token(Token = "0x600E4CA"), Address(RVA = "0x47895D0", Offset = "0x47895D0", VA = "0x47895D0")] private set
      {
      }
    }

    [Token(Token = "0x17003109")]
    public int MissionId
    {
      [Token(Token = "0x600E4CB"), Address(RVA = "0x47895D8", Offset = "0x47895D8", VA = "0x47895D8")] get
      {
        return new int();
      }
      [Token(Token = "0x600E4CC"), Address(RVA = "0x47895E0", Offset = "0x47895E0", VA = "0x47895E0")] private set
      {
      }
    }

    [Token(Token = "0x1700310A")]
    public int ContinueCount
    {
      [Token(Token = "0x600E4CD"), Address(RVA = "0x47895E8", Offset = "0x47895E8", VA = "0x47895E8")] get
      {
        return new int();
      }
      [Token(Token = "0x600E4CE"), Address(RVA = "0x47895F0", Offset = "0x47895F0", VA = "0x47895F0")] private set
      {
      }
    }

    [Token(Token = "0x1700310B")]
    public int UseItemCount
    {
      [Token(Token = "0x600E4CF"), Address(RVA = "0x47895F8", Offset = "0x47895F8", VA = "0x47895F8")] get
      {
        return new int();
      }
      [Token(Token = "0x600E4D0"), Address(RVA = "0x4789600", Offset = "0x4789600", VA = "0x4789600")] private set
      {
      }
    }

    [Token(Token = "0x1700310C")]
    public int ChainCount
    {
      [Token(Token = "0x600E4D1"), Address(RVA = "0x4789608", Offset = "0x4789608", VA = "0x4789608")] get
      {
        return new int();
      }
      [Token(Token = "0x600E4D2"), Address(RVA = "0x4789610", Offset = "0x4789610", VA = "0x4789610")] private set
      {
      }
    }

    [Token(Token = "0x1700310D")]
    public int ElementChainCount
    {
      [Token(Token = "0x600E4D3"), Address(RVA = "0x4789618", Offset = "0x4789618", VA = "0x4789618")] get
      {
        return new int();
      }
      [Token(Token = "0x600E4D4"), Address(RVA = "0x4789620", Offset = "0x4789620", VA = "0x4789620")] private set
      {
      }
    }

    [Token(Token = "0x1700310E")]
    public int Turn
    {
      [Token(Token = "0x600E4D5"), Address(RVA = "0x4789628", Offset = "0x4789628", VA = "0x4789628")] get
      {
        return new int();
      }
      [Token(Token = "0x600E4D6"), Address(RVA = "0x4789630", Offset = "0x4789630", VA = "0x4789630")] private set
      {
      }
    }

    [Token(Token = "0x1700310F")]
    public int RollbackCount
    {
      [Token(Token = "0x600E4D7"), Address(RVA = "0x4789638", Offset = "0x4789638", VA = "0x4789638")] get
      {
        return new int();
      }
      [Token(Token = "0x600E4D8"), Address(RVA = "0x4789640", Offset = "0x4789640", VA = "0x4789640")] private set
      {
      }
    }

    [Token(Token = "0x17003110")]
    public IReadOnlyCollection<int> DestroyObjectIds
    {
      [Token(Token = "0x600E4D9"), Address(RVA = "0x4789648", Offset = "0x4789648", VA = "0x4789648")] get
      {
        return (IReadOnlyCollection<int>) null;
      }
    }

    [Token(Token = "0x17003111")]
    public bool IsSortieFriendUnit
    {
      [Token(Token = "0x600E4DA"), Address(RVA = "0x4789650", Offset = "0x4789650", VA = "0x4789650")] get
      {
        return new bool();
      }
      [Token(Token = "0x600E4DB"), Address(RVA = "0x4789658", Offset = "0x4789658", VA = "0x4789658")] private set
      {
      }
    }

    [Token(Token = "0x17003112")]
    public IReadOnlyList<MissionLogParam.UseGimmickParam> UseGimmickParams
    {
      [Token(Token = "0x600E4DC"), Address(RVA = "0x4789664", Offset = "0x4789664", VA = "0x4789664")] get
      {
        return (IReadOnlyList<MissionLogParam.UseGimmickParam>) null;
      }
    }

    [Token(Token = "0x17003113")]
    public int TotalUseGimmickCount
    {
      [Token(Token = "0x600E4DD"), Address(RVA = "0x478966C", Offset = "0x478966C", VA = "0x478966C")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600E4DE")]
    [Address(RVA = "0x4789954", Offset = "0x4789954", VA = "0x4789954")]
    private MissionLogParam(MissionLogParam src)
    {
    }

    [Token(Token = "0x600E4DF")]
    [Address(RVA = "0x4789BF0", Offset = "0x4789BF0", VA = "0x4789BF0")]
    public MissionLogParam(int stageId, int missionId)
    {
    }

    [Token(Token = "0x600E4E0")]
    [Address(RVA = "0x4789D80", Offset = "0x4789D80", VA = "0x4789D80")]
    public MissionLogParam Clone() => (MissionLogParam) null;

    [Token(Token = "0x600E4E1")]
    [Address(RVA = "0x4789DE0", Offset = "0x4789DE0", VA = "0x4789DE0")]
    public void AddUnit(UnitParameterData unit)
    {
    }

    [Token(Token = "0x600E4E2")]
    [Address(RVA = "0x478A094", Offset = "0x478A094", VA = "0x478A094")]
    public void Apply(IEnumerable<MissionLogParam.Diff> diffs)
    {
    }

    [Token(Token = "0x600E4E3")]
    [Address(RVA = "0x478A370", Offset = "0x478A370", VA = "0x478A370")]
    public void Apply(MissionLogParam.Diff diff, bool updateText = true)
    {
    }

    [Token(Token = "0x600E4E4")]
    [Address(RVA = "0x478B9B0", Offset = "0x478B9B0", VA = "0x478B9B0")]
    public void Revert(IEnumerable<MissionLogParam.Diff> diffs)
    {
    }

    [Token(Token = "0x600E4E5")]
    [Address(RVA = "0x478BC8C", Offset = "0x478BC8C", VA = "0x478BC8C")]
    public void Revert(MissionLogParam.Diff diff, bool updateText = true)
    {
    }

    [Token(Token = "0x600E4E6")]
    [Address(RVA = "0x478B04C", Offset = "0x478B04C", VA = "0x478B04C")]
    public UnitMissionLogParam GetUnitMissionLogParam(int id) => (UnitMissionLogParam) null;

    [Token(Token = "0x600E4E7")]
    [Address(RVA = "0x478CC94", Offset = "0x478CC94", VA = "0x478CC94")]
    public IEnumerable<UnitMissionLogParam> GetUnitMissionLogParamByStyleId(
      int playerId,
      int styleId)
    {
      return (IEnumerable<UnitMissionLogParam>) null;
    }

    [Token(Token = "0x600E4E8")]
    [Address(RVA = "0x478CF2C", Offset = "0x478CF2C", VA = "0x478CF2C")]
    public IEnumerable<UnitMissionLogParam> GetUnitMissionLogParamsByCharacterId(
      int playerId,
      int characterId)
    {
      return (IEnumerable<UnitMissionLogParam>) null;
    }

    [Token(Token = "0x600E4E9")]
    [Address(RVA = "0x478D1A4", Offset = "0x478D1A4", VA = "0x478D1A4")]
    public IEnumerable<UnitMissionLogParam> GetUnitMissionLogParamsByPlayerId(int playerId)
    {
      return (IEnumerable<UnitMissionLogParam>) null;
    }

    [Token(Token = "0x600E4EA")]
    [Address(RVA = "0x478AC64", Offset = "0x478AC64", VA = "0x478AC64")]
    public MissionLogParam.UseGimmickParam GetUseGimmickParam(int id)
    {
      return (MissionLogParam.UseGimmickParam) null;
    }

    [Token(Token = "0x600E4EB")]
    [Address(RVA = "0x478D3D8", Offset = "0x478D3D8", VA = "0x478D3D8")]
    public bool IsDeadAll(IEnumerable<int> playerIds) => new bool();

    [Token(Token = "0x600E4EC")]
    [Address(RVA = "0x478D824", Offset = "0x478D824", VA = "0x478D824")]
    public bool IsPartyElementSame(IEnumerable<int> playerIds, ElementTypeEnum element)
    {
      return new bool();
    }

    [Token(Token = "0x600E4ED")]
    [Address(RVA = "0x478DB2C", Offset = "0x478DB2C", VA = "0x478DB2C")]
    public bool IsPartyElementSame(int playerId, ElementTypeEnum element) => new bool();

    [Token(Token = "0x600E4EE")]
    [Address(RVA = "0x478DE6C", Offset = "0x478DE6C", VA = "0x478DE6C")]
    public bool IsAliveSpecifiedUnit(int guestId) => new bool();

    [Token(Token = "0x600E4EF")]
    [Address(RVA = "0x478DFE8", Offset = "0x478DFE8", VA = "0x478DFE8")]
    public bool IsOverCurrentHPRate(IEnumerable<int> playerIds, int rate) => new bool();

    [Token(Token = "0x600E4F0")]
    [Address(RVA = "0x478E2F0", Offset = "0x478E2F0", VA = "0x478E2F0")]
    public bool IsOverCurrentHPRate(int playerId, int rate) => new bool();

    [Token(Token = "0x600E4F1")]
    [Address(RVA = "0x478E694", Offset = "0x478E694", VA = "0x478E694")]
    public int TotalDeathCount(IEnumerable<int> playerIds) => new int();

    [Token(Token = "0x600E4F2")]
    [Address(RVA = "0x478E97C", Offset = "0x478E97C", VA = "0x478E97C")]
    public int TotalDeathCount(int playerId) => new int();

    [Token(Token = "0x600E4F3")]
    [Address(RVA = "0x478EDC0", Offset = "0x478EDC0", VA = "0x478EDC0")]
    public int TotalHealValue(int playerId) => new int();

    [Token(Token = "0x600E4F4")]
    [Address(RVA = "0x478F0B8", Offset = "0x478F0B8", VA = "0x478F0B8")]
    public int TotalDealBadStatusCount(int playerId) => new int();

    [Token(Token = "0x600E4F5")]
    [Address(RVA = "0x478F4FC", Offset = "0x478F4FC", VA = "0x478F4FC")]
    public int TotalDefeatBadStatusCount(int playerId) => new int();

    [Token(Token = "0x600E4F6")]
    [Address(RVA = "0x478F94C", Offset = "0x478F94C", VA = "0x478F94C")]
    public int TotalTakeDamge(int playerId) => new int();

    [Token(Token = "0x600E4F7")]
    [Address(RVA = "0x478FC44", Offset = "0x478FC44", VA = "0x478FC44")]
    public int MaxDealDamage(int playerId) => new int();

    [Token(Token = "0x2002516")]
    public class Diff : MissionLogParam
    {
      [Token(Token = "0x4009F5C")]
      [FieldOffset(Offset = "0x50")]
      private IEnumerable<UnitMissionLogParam.Diff> diffs;

      [Token(Token = "0x17003114")]
      public IReadOnlyList<UnitMissionLogParam.Diff> Diffs
      {
        [Token(Token = "0x600E4F8"), Address(RVA = "0x478AF88", Offset = "0x478AF88", VA = "0x478AF88")] get
        {
          return (IReadOnlyList<UnitMissionLogParam.Diff>) null;
        }
      }

      [Token(Token = "0x600E4F9")]
      [Address(RVA = "0x478FF40", Offset = "0x478FF40", VA = "0x478FF40")]
      public Diff(int stageId, int missionId)
      {
      }

      [Token(Token = "0x600E4FA")]
      [Address(RVA = "0x4790118", Offset = "0x4790118", VA = "0x4790118")]
      public void AddContinueCount(int count)
      {
      }

      [Token(Token = "0x600E4FB")]
      [Address(RVA = "0x4790128", Offset = "0x4790128", VA = "0x4790128")]
      public void AddUseItemCount(int count = 1)
      {
      }

      [Token(Token = "0x600E4FC")]
      [Address(RVA = "0x4790138", Offset = "0x4790138", VA = "0x4790138")]
      public void AddChainCount(int count)
      {
      }

      [Token(Token = "0x600E4FD")]
      [Address(RVA = "0x4790148", Offset = "0x4790148", VA = "0x4790148")]
      public void AddElementChainCount(int count)
      {
      }

      [Token(Token = "0x600E4FE")]
      [Address(RVA = "0x4790158", Offset = "0x4790158", VA = "0x4790158")]
      public void AddTurn(int turn)
      {
      }

      [Token(Token = "0x600E4FF")]
      [Address(RVA = "0x4790168", Offset = "0x4790168", VA = "0x4790168")]
      public void AddRollbackCount(int count)
      {
      }

      [Token(Token = "0x600E500")]
      [Address(RVA = "0x4790178", Offset = "0x4790178", VA = "0x4790178")]
      public void AddDestroyObjectId(int objectId)
      {
      }

      [Token(Token = "0x600E501")]
      [Address(RVA = "0x47901D0", Offset = "0x47901D0", VA = "0x47901D0")]
      public void AddUseGimmickParam(int gimmickId, int count = 1)
      {
      }

      [Token(Token = "0x600E502")]
      [Address(RVA = "0x4790308", Offset = "0x4790308", VA = "0x4790308")]
      public void AddDiff(UnitMissionLogParam.Diff diff)
      {
      }

      [Token(Token = "0x600E503")]
      [Address(RVA = "0x47903B0", Offset = "0x47903B0", VA = "0x47903B0")]
      public void AddRangeDiff(IEnumerable<UnitMissionLogParam.Diff> diffs)
      {
      }
    }

    [Token(Token = "0x2002518")]
    public class UseGimmickParam
    {
      [Token(Token = "0x17003115")]
      public int Id
      {
        [Token(Token = "0x600E508"), Address(RVA = "0x4790564", Offset = "0x4790564", VA = "0x4790564")] get
        {
          return new int();
        }
        [Token(Token = "0x600E509"), Address(RVA = "0x479056C", Offset = "0x479056C", VA = "0x479056C")] private set
        {
        }
      }

      [Token(Token = "0x17003116")]
      public int Count
      {
        [Token(Token = "0x600E50A"), Address(RVA = "0x4790574", Offset = "0x4790574", VA = "0x4790574")] get
        {
          return new int();
        }
        [Token(Token = "0x600E50B"), Address(RVA = "0x479057C", Offset = "0x479057C", VA = "0x479057C")] private set
        {
        }
      }

      [Token(Token = "0x600E50C")]
      [Address(RVA = "0x47902DC", Offset = "0x47902DC", VA = "0x47902DC")]
      public UseGimmickParam(int id, int count = 1)
      {
      }

      [Token(Token = "0x600E50D")]
      [Address(RVA = "0x478AF78", Offset = "0x478AF78", VA = "0x478AF78")]
      public void AddGimmickCount(int count)
      {
      }
    }
  }
}
