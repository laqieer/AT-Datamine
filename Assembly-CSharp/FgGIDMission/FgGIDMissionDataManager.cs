// Decompiled with JetBrains decompiler
// Type: FgGIDMission.FgGIDMissionDataManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network.API;
using Network.Param;
using System;
using System.Collections;
using System.Collections.Generic;

#nullable disable
namespace FgGIDMission
{
  [Token(Token = "0x200197C")]
  public class FgGIDMissionDataManager
  {
    [Token(Token = "0x4006D8E")]
    [FieldOffset(Offset = "0x18")]
    private List<FgGIDCoinData> CoinDatas;
    [Token(Token = "0x4006D90")]
    [FieldOffset(Offset = "0x28")]
    private Action<FgGIDAppData> selectedAppChanged;
    [Token(Token = "0x4006D91")]
    [FieldOffset(Offset = "0x30")]
    private int selectedGameId;
    [Token(Token = "0x4006D92")]
    [FieldOffset(Offset = "0x38")]
    public Action<FgGIDAppData> MissionListChanged;
    [Token(Token = "0x4006D93")]
    [FieldOffset(Offset = "0x40")]
    public Action<List<FgGIDMissionData>> MissionRewardReceived;
    [Token(Token = "0x4006D94")]
    [FieldOffset(Offset = "0x48")]
    public Action<FgGIDCoinModel> CoinDataChanged;

    [Token(Token = "0x17001774")]
    public int OwnGameId
    {
      [Token(Token = "0x600917E"), Address(RVA = "0x4D0A4C8", Offset = "0x4D0A4C8", VA = "0x4D0A4C8")] get
      {
        return new int();
      }
      [Token(Token = "0x600917F"), Address(RVA = "0x4D0A4D0", Offset = "0x4D0A4D0", VA = "0x4D0A4D0")] private set
      {
      }
    }

    [Token(Token = "0x17001775")]
    public List<FgGIDAppData> AppDatas
    {
      [Token(Token = "0x6009180"), Address(RVA = "0x4D0A4D8", Offset = "0x4D0A4D8", VA = "0x4D0A4D8")] get
      {
        return (List<FgGIDAppData>) null;
      }
      [Token(Token = "0x6009181"), Address(RVA = "0x4D0A4E0", Offset = "0x4D0A4E0", VA = "0x4D0A4E0")] private set
      {
      }
    }

    [Token(Token = "0x1400012F")]
    public event Action<FgGIDAppData> SelectedAppChanged
    {
      [Token(Token = "0x6009182"), Address(RVA = "0x4D0A4E8", Offset = "0x4D0A4E8", VA = "0x4D0A4E8")] add
      {
      }
      [Token(Token = "0x6009183"), Address(RVA = "0x4D0A6B4", Offset = "0x4D0A6B4", VA = "0x4D0A6B4")] remove
      {
      }
    }

    [Token(Token = "0x6009184")]
    [Address(RVA = "0x4D0A75C", Offset = "0x4D0A75C", VA = "0x4D0A75C")]
    public FgGIDMissionDataManager(int ownGameId)
    {
    }

    [Token(Token = "0x6009185")]
    [Address(RVA = "0x4D0A784", Offset = "0x4D0A784", VA = "0x4D0A784")]
    public FgGIDCoinModel GetFgGCoinModel() => (FgGIDCoinModel) null;

    [Token(Token = "0x6009186")]
    [Address(RVA = "0x4D0A5C0", Offset = "0x4D0A5C0", VA = "0x4D0A5C0")]
    private bool TryGetAppData(int gameId, out FgGIDAppData appData) => new bool();

    [Token(Token = "0x6009187")]
    [Address(RVA = "0x4D0A800", Offset = "0x4D0A800", VA = "0x4D0A800")]
    public void SelectFirstValidApp()
    {
    }

    [Token(Token = "0x6009188")]
    [Address(RVA = "0x4D0A94C", Offset = "0x4D0A94C", VA = "0x4D0A94C")]
    public void SelectApp(int gameId)
    {
    }

    [Token(Token = "0x6009189")]
    [Address(RVA = "0x4D0A994", Offset = "0x4D0A994", VA = "0x4D0A994")]
    public void RequestChallenge(FgGIDMissionData missionData)
    {
    }

    [Token(Token = "0x600918A")]
    [Address(RVA = "0x4D0A9D0", Offset = "0x4D0A9D0", VA = "0x4D0A9D0")]
    public void RequestBalkReceive(int gameId)
    {
    }

    [Token(Token = "0x600918B")]
    [Address(RVA = "0x4D0AAF4", Offset = "0x4D0AAF4", VA = "0x4D0AAF4")]
    public void RequestReceive(FgGIDMissionData missionData)
    {
    }

    [Token(Token = "0x600918C")]
    [Address(RVA = "0x4D0AA58", Offset = "0x4D0AA58", VA = "0x4D0AA58")]
    public void RequestReceive(List<FgGIDMissionData> missionData)
    {
    }

    [Token(Token = "0x600918D")]
    [Address(RVA = "0x4D0ABE4", Offset = "0x4D0ABE4", VA = "0x4D0ABE4")]
    private IEnumerator RequestReceiveAsync(List<FgGIDMissionData> missionData)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x600918E")]
    [Address(RVA = "0x4D0AC80", Offset = "0x4D0AC80", VA = "0x4D0AC80")]
    public void ApplyCoinDatas(List<PlayerFggfcCoin> playerFggfcCoins)
    {
    }

    [Token(Token = "0x600918F")]
    [Address(RVA = "0x4D0AC9C", Offset = "0x4D0AC9C", VA = "0x4D0AC9C")]
    public void ApplyAppDatas(
      List<PlayerFggIDRegisterGame> playerFggIDRegisterGames,
      List<PlayerFggIDAchievementMission> playerFggIDAchievementMissions,
      List<PlayerFggfcCoinMission> playerFggfcCoinMissions)
    {
    }

    [Token(Token = "0x6009190")]
    [Address(RVA = "0x4D0B138", Offset = "0x4D0B138", VA = "0x4D0B138")]
    private void ApplyAPIFggfcMissionAcceptResponse(APIFggfcMissionAcceptResponse response)
    {
    }

    [Token(Token = "0x6009191")]
    [Address(RVA = "0x4D0B174", Offset = "0x4D0B174", VA = "0x4D0B174")]
    private void ApplyAPIFggfcMissionAcceptResponse(APIFggfcMissionResponse response)
    {
    }

    [Token(Token = "0x6009192")]
    [Address(RVA = "0x4D0B1B0", Offset = "0x4D0B1B0", VA = "0x4D0B1B0")]
    public static FgGIDMissionDataManager CreateFromServerData(APIFggfcMissionResponse response)
    {
      return (FgGIDMissionDataManager) null;
    }
  }
}
