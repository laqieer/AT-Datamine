// Decompiled with JetBrains decompiler
// Type: FgGIDMission.FgGIDAppData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network.Param;
using System.Collections.Generic;

#nullable disable
namespace FgGIDMission
{
  [Token(Token = "0x2001974")]
  public class FgGIDAppData
  {
    [Token(Token = "0x1700175C")]
    public int GameId
    {
      [Token(Token = "0x600912D"), Address(RVA = "0x4D08C50", Offset = "0x4D08C50", VA = "0x4D08C50")] get
      {
        return new int();
      }
      [Token(Token = "0x600912E"), Address(RVA = "0x4D08C58", Offset = "0x4D08C58", VA = "0x4D08C58")] private set
      {
      }
    }

    [Token(Token = "0x1700175D")]
    public string AppIconName
    {
      [Token(Token = "0x600912F"), Address(RVA = "0x4D08C60", Offset = "0x4D08C60", VA = "0x4D08C60")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6009130"), Address(RVA = "0x4D08C68", Offset = "0x4D08C68", VA = "0x4D08C68")] private set
      {
      }
    }

    [Token(Token = "0x1700175E")]
    public bool IsLinked
    {
      [Token(Token = "0x6009131"), Address(RVA = "0x4D08C70", Offset = "0x4D08C70", VA = "0x4D08C70")] get
      {
        return new bool();
      }
      [Token(Token = "0x6009132"), Address(RVA = "0x4D08C78", Offset = "0x4D08C78", VA = "0x4D08C78")] private set
      {
      }
    }

    [Token(Token = "0x1700175F")]
    public string AppStoreUrl
    {
      [Token(Token = "0x6009133"), Address(RVA = "0x4D08C84", Offset = "0x4D08C84", VA = "0x4D08C84")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6009134"), Address(RVA = "0x4D08C8C", Offset = "0x4D08C8C", VA = "0x4D08C8C")] private set
      {
      }
    }

    [Token(Token = "0x17001760")]
    public string GooglePlayUrl
    {
      [Token(Token = "0x6009135"), Address(RVA = "0x4D08C94", Offset = "0x4D08C94", VA = "0x4D08C94")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6009136"), Address(RVA = "0x4D08C9C", Offset = "0x4D08C9C", VA = "0x4D08C9C")] private set
      {
      }
    }

    [Token(Token = "0x17001761")]
    public List<FgGIDMissionData> MissionDatas
    {
      [Token(Token = "0x6009137"), Address(RVA = "0x4D08CA4", Offset = "0x4D08CA4", VA = "0x4D08CA4")] get
      {
        return (List<FgGIDMissionData>) null;
      }
      [Token(Token = "0x6009138"), Address(RVA = "0x4D08CAC", Offset = "0x4D08CAC", VA = "0x4D08CAC")] private set
      {
      }
    }

    [Token(Token = "0x17001762")]
    public bool HasMission
    {
      [Token(Token = "0x6009139"), Address(RVA = "0x4D08CB4", Offset = "0x4D08CB4", VA = "0x4D08CB4")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001763")]
    public bool HasReceivableMission
    {
      [Token(Token = "0x600913A"), Address(RVA = "0x4D08D04", Offset = "0x4D08D04", VA = "0x4D08D04")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001764")]
    public bool IsOwnApp
    {
      [Token(Token = "0x600913B"), Address(RVA = "0x4D08E00", Offset = "0x4D08E00", VA = "0x4D08E00")] get
      {
        return new bool();
      }
      [Token(Token = "0x600913C"), Address(RVA = "0x4D08E08", Offset = "0x4D08E08", VA = "0x4D08E08")] private set
      {
      }
    }

    [Token(Token = "0x600913D")]
    [Address(RVA = "0x4D08E14", Offset = "0x4D08E14", VA = "0x4D08E14")]
    public static FgGIDAppData CreateForBlank() => (FgGIDAppData) null;

    [Token(Token = "0x600913E")]
    [Address(RVA = "0x4D08EC8", Offset = "0x4D08EC8", VA = "0x4D08EC8")]
    public static FgGIDAppData CreateDummyData(
      int gameId,
      string appIconName,
      bool isLinked,
      List<FgGIDMissionData> missionDatas)
    {
      return (FgGIDAppData) null;
    }

    [Token(Token = "0x600913F")]
    [Address(RVA = "0x4D08F58", Offset = "0x4D08F58", VA = "0x4D08F58")]
    public static FgGIDAppData CreateFromServerData(
      int ownGameId,
      PlayerFggIDRegisterGame serverData)
    {
      return (FgGIDAppData) null;
    }

    [Token(Token = "0x6009140")]
    [Address(RVA = "0x4D08FF4", Offset = "0x4D08FF4", VA = "0x4D08FF4")]
    public static List<FgGIDAppData> CreateFromServerData(
      int ownGameId,
      IEnumerable<PlayerFggIDRegisterGame> serverDatas)
    {
      return (List<FgGIDAppData>) null;
    }

    [Token(Token = "0x6009141")]
    [Address(RVA = "0x4D090EC", Offset = "0x4D090EC", VA = "0x4D090EC")]
    public void ApplyMissions(List<FgGIDMissionData> missionDatas)
    {
    }

    [Token(Token = "0x6009142")]
    [Address(RVA = "0x4D090F4", Offset = "0x4D090F4", VA = "0x4D090F4")]
    public void ApplyMissions(
      List<PlayerMissionProgressType> missionProgressTypes)
    {
    }

    [Token(Token = "0x6009143")]
    [Address(RVA = "0x4D09380", Offset = "0x4D09380", VA = "0x4D09380")]
    public IEnumerable<FgGIDMissionData> GetReceivableMissions()
    {
      return (IEnumerable<FgGIDMissionData>) null;
    }

    [Token(Token = "0x6009144")]
    [Address(RVA = "0x4D08EC0", Offset = "0x4D08EC0", VA = "0x4D08EC0")]
    public FgGIDAppData()
    {
    }
  }
}
