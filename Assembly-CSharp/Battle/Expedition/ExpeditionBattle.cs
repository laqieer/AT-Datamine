// Decompiled with JetBrains decompiler
// Type: Battle.Expedition.ExpeditionBattle
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using Battle.Expedition.Data;
using Battle.Process;
using Battle.Stage;
using Il2CppDummyDll;
using Network.Param;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Battle.Expedition
{
  [Token(Token = "0x20025D7")]
  public class ExpeditionBattle : MonoBehaviour, IProcessOwner<ProcessCode>
  {
    [Token(Token = "0x400A2BC")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private MainDirector mainDirector;
    [Token(Token = "0x400A2BD")]
    [FieldOffset(Offset = "0x20")]
    private ExpeditionBattleData battleData;
    [Token(Token = "0x400A2BE")]
    [FieldOffset(Offset = "0x28")]
    private BoardData boardData;
    [Token(Token = "0x400A2BF")]
    [FieldOffset(Offset = "0x30")]
    private ExpeditionBattleData oldBattleData;
    [Token(Token = "0x400A2C2")]
    [FieldOffset(Offset = "0x48")]
    public IBattleProcessFactory processFactory;
    [Token(Token = "0x400A2C3")]
    [FieldOffset(Offset = "0x50")]
    private BattleProcessBase process;
    [Token(Token = "0x400A2C4")]
    [FieldOffset(Offset = "0x58")]
    private ProcessCode nextProcess;
    [Token(Token = "0x400A2C5")]
    [FieldOffset(Offset = "0x5C")]
    private bool initialized;
    [Token(Token = "0x400A2C7")]
    [FieldOffset(Offset = "0x68")]
    private Action<int> onSelectUnitCallback;
    [Token(Token = "0x400A2C8")]
    [FieldOffset(Offset = "0x70")]
    private Action<int> onUnSelectUnitCallback;
    [Token(Token = "0x400A2C9")]
    [FieldOffset(Offset = "0x78")]
    private Action<int> onLongPressUnitCallback;
    [Token(Token = "0x400A2CA")]
    [FieldOffset(Offset = "0x80")]
    private Action onFinishInitializeCallback;
    [Token(Token = "0x400A2CB")]
    [FieldOffset(Offset = "0x0")]
    public static readonly string CACHE_ASSETBUNDLE_TAG;

    [Token(Token = "0x170031EF")]
    public BattleCore battleCore
    {
      [Token(Token = "0x600E9C3"), Address(RVA = "0x4C4BC64", Offset = "0x4C4BC64", VA = "0x4C4BC64")] get
      {
        return (BattleCore) null;
      }
      [Token(Token = "0x600E9C4"), Address(RVA = "0x4C4BC6C", Offset = "0x4C4BC6C", VA = "0x4C4BC6C")] private set
      {
      }
    }

    [Token(Token = "0x170031F0")]
    public BattleStage BattleStage
    {
      [Token(Token = "0x600E9C5"), Address(RVA = "0x4C4BC74", Offset = "0x4C4BC74", VA = "0x4C4BC74")] get
      {
        return (BattleStage) null;
      }
      [Token(Token = "0x600E9C6"), Address(RVA = "0x4C4BC7C", Offset = "0x4C4BC7C", VA = "0x4C4BC7C")] private set
      {
      }
    }

    [Token(Token = "0x170031F1")]
    public int CurrentNormalBattlePartyNo
    {
      [Token(Token = "0x600E9C7"), Address(RVA = "0x4C4BC84", Offset = "0x4C4BC84", VA = "0x4C4BC84")] get
      {
        return new int();
      }
      [Token(Token = "0x600E9C8"), Address(RVA = "0x4C4BC8C", Offset = "0x4C4BC8C", VA = "0x4C4BC8C")] private set
      {
      }
    }

    [Token(Token = "0x600E9C9")]
    [Address(RVA = "0x4C4BC94", Offset = "0x4C4BC94", VA = "0x4C4BC94", Slot = "4")]
    public void OnFinishProcess(ProcessCode code)
    {
    }

    [Token(Token = "0x600E9CA")]
    [Address(RVA = "0x4C4BC9C", Offset = "0x4C4BC9C", VA = "0x4C4BC9C")]
    private void LateUpdate()
    {
    }

    [Token(Token = "0x600E9CB")]
    [Address(RVA = "0x4C4BE08", Offset = "0x4C4BE08", VA = "0x4C4BE08")]
    public void CreateStage(ExpeditionBattle.BattleParameter param, Action finishCallback = null)
    {
    }

    [Token(Token = "0x600E9CC")]
    [Address(RVA = "0x4C4C6D8", Offset = "0x4C4C6D8", VA = "0x4C4C6D8")]
    public void RePlaceBossPartyUnit(
      List<PlayerExpeditionStageBossPartyUnitType> partyUnits)
    {
    }

    [Token(Token = "0x600E9CD")]
    [Address(RVA = "0x4C4C754", Offset = "0x4C4C754", VA = "0x4C4C754")]
    public void DisableSelectGrid()
    {
    }

    [Token(Token = "0x600E9CE")]
    [Address(RVA = "0x4C4C7BC", Offset = "0x4C4C7BC", VA = "0x4C4C7BC")]
    public void EnableSelectGrid()
    {
    }

    [Token(Token = "0x600E9CF")]
    [Address(RVA = "0x4C4C824", Offset = "0x4C4C824", VA = "0x4C4C824")]
    public void SelectUnit(int manageNo)
    {
    }

    [Token(Token = "0x600E9D0")]
    [Address(RVA = "0x4C4C8A0", Offset = "0x4C4C8A0", VA = "0x4C4C8A0")]
    public void UnSelectUnit()
    {
    }

    [Token(Token = "0x600E9D1")]
    [Address(RVA = "0x4C4C914", Offset = "0x4C4C914", VA = "0x4C4C914")]
    public List<ExpeditionBattleData.UnitInfo> GetAllUnitInfo()
    {
      return (List<ExpeditionBattleData.UnitInfo>) null;
    }

    [Token(Token = "0x600E9D2")]
    [Address(RVA = "0x4C4CB18", Offset = "0x4C4CB18", VA = "0x4C4CB18")]
    public ExpeditionBattleData.UnitInfo GetUnitInfo(int manageNo)
    {
      return (ExpeditionBattleData.UnitInfo) null;
    }

    [Token(Token = "0x600E9D3")]
    [Address(RVA = "0x4C4CB98", Offset = "0x4C4CB98", VA = "0x4C4CB98")]
    public BattlePlayerData GetPlayerData(int player) => (BattlePlayerData) null;

    [Token(Token = "0x600E9D4")]
    [Address(RVA = "0x4C4CBBC", Offset = "0x4C4CBBC", VA = "0x4C4CBBC")]
    public int GetBattleTurn() => new int();

    [Token(Token = "0x600E9D5")]
    [Address(RVA = "0x4C4CBD8", Offset = "0x4C4CBD8", VA = "0x4C4CBD8")]
    public void SetOnFinishInitializeCallback(Action onFinishInitialize)
    {
    }

    [Token(Token = "0x600E9D6")]
    [Address(RVA = "0x4C4CBE0", Offset = "0x4C4CBE0", VA = "0x4C4CBE0")]
    public void RemoveOnFinishInitializeCallback()
    {
    }

    [Token(Token = "0x600E9D7")]
    [Address(RVA = "0x4C4CBE8", Offset = "0x4C4CBE8", VA = "0x4C4CBE8")]
    public void SetUnitActionCallback(
      Action<int> onSelectUnit,
      Action<int> onUnSelectUnit,
      Action<int> onLongPressUnit)
    {
    }

    [Token(Token = "0x600E9D8")]
    [Address(RVA = "0x4C4CBF4", Offset = "0x4C4CBF4", VA = "0x4C4CBF4")]
    public void StartBossBattle()
    {
    }

    [Token(Token = "0x600E9D9")]
    [Address(RVA = "0x4C4CC6C", Offset = "0x4C4CC6C", VA = "0x4C4CC6C")]
    public bool CanStartBossBattle() => new bool();

    [Token(Token = "0x600E9DA")]
    [Address(RVA = "0x4C4CCD4", Offset = "0x4C4CCD4", VA = "0x4C4CCD4")]
    public void CancelBossBattle()
    {
    }

    [Token(Token = "0x600E9DB")]
    [Address(RVA = "0x4C4CD3C", Offset = "0x4C4CD3C", VA = "0x4C4CD3C")]
    public void ChangeCameraAngle()
    {
    }

    [Token(Token = "0x600E9DC")]
    [Address(RVA = "0x4C4CD54", Offset = "0x4C4CD54", VA = "0x4C4CD54")]
    public void SwitchGridVisible()
    {
    }

    [Token(Token = "0x600E9DD")]
    [Address(RVA = "0x4C4CD6C", Offset = "0x4C4CD6C", VA = "0x4C4CD6C")]
    public void SwitchFastMode(bool isFirstMode)
    {
    }

    [Token(Token = "0x600E9DE")]
    [Address(RVA = "0x4C4CE1C", Offset = "0x4C4CE1C", VA = "0x4C4CE1C")]
    public void Hide()
    {
    }

    [Token(Token = "0x600E9DF")]
    [Address(RVA = "0x4C4CEA0", Offset = "0x4C4CEA0", VA = "0x4C4CEA0")]
    public void Dispose()
    {
    }

    [Token(Token = "0x600E9E0")]
    [Address(RVA = "0x4C4CE70", Offset = "0x4C4CE70", VA = "0x4C4CE70")]
    private void DisposeProcess()
    {
    }

    [Token(Token = "0x600E9E1")]
    [Address(RVA = "0x4C4D04C", Offset = "0x4C4D04C", VA = "0x4C4D04C")]
    public void OnApplicationFocus(bool hasFocus)
    {
    }

    [Token(Token = "0x600E9E2")]
    [Address(RVA = "0x4C4D06C", Offset = "0x4C4D06C", VA = "0x4C4D06C")]
    public void OnApplicationPause(bool isPaused)
    {
    }

    [Token(Token = "0x600E9E3")]
    [Address(RVA = "0x4C4D08C", Offset = "0x4C4D08C", VA = "0x4C4D08C")]
    public void ChangeBgActive(bool isActive)
    {
    }

    [Token(Token = "0x600E9E4")]
    [Address(RVA = "0x4C4D104", Offset = "0x4C4D104", VA = "0x4C4D104")]
    public void PlayFieldExit(bool isIn)
    {
    }

    [Token(Token = "0x600E9E5")]
    [Address(RVA = "0x4C4D184", Offset = "0x4C4D184", VA = "0x4C4D184")]
    public void ChackFieldExitEffect()
    {
    }

    [Token(Token = "0x600E9E6")]
    [Address(RVA = "0x4C4D1B4", Offset = "0x4C4D1B4", VA = "0x4C4D1B4")]
    public IEnumerator LoadResource() => (IEnumerator) null;

    [Token(Token = "0x600E9E7")]
    [Address(RVA = "0x4C4D244", Offset = "0x4C4D244", VA = "0x4C4D244")]
    public ExpeditionBattle()
    {
    }

    [Token(Token = "0x600E9E8")]
    [Address(RVA = "0x4C4D25C", Offset = "0x4C4D25C", VA = "0x4C4D25C")]
    static ExpeditionBattle()
    {
    }

    [Token(Token = "0x600E9E9")]
    [Address(RVA = "0x4C4D2BC", Offset = "0x4C4D2BC", VA = "0x4C4D2BC", Slot = "5")]
    private Coroutine Battle\u002EProcess\u002EIProcessOwner\u003CBattle\u002EProcess\u002EProcessCode\u003E\u002EStartCoroutine(
      IEnumerator routine)
    {
      return (Coroutine) null;
    }

    [Token(Token = "0x600E9EA")]
    [Address(RVA = "0x4C4D2C4", Offset = "0x4C4D2C4", VA = "0x4C4D2C4", Slot = "6")]
    private void Battle\u002EProcess\u002EIProcessOwner\u003CBattle\u002EProcess\u002EProcessCode\u003E\u002EStopCoroutine(
      IEnumerator routine)
    {
    }

    [Token(Token = "0x20025D8")]
    public sealed class BattleParameter
    {
      [Token(Token = "0x400A2CC")]
      [FieldOffset(Offset = "0x10")]
      public int stageId;
      [Token(Token = "0x400A2CD")]
      [FieldOffset(Offset = "0x14")]
      public int partyNo;
      [Token(Token = "0x400A2CE")]
      [FieldOffset(Offset = "0x18")]
      public bool isBossExpedition;
      [Token(Token = "0x400A2CF")]
      [FieldOffset(Offset = "0x1C")]
      public int bossLevel;

      [Token(Token = "0x600E9ED")]
      [Address(RVA = "0x4C4D31C", Offset = "0x4C4D31C", VA = "0x4C4D31C")]
      public BattleParameter()
      {
      }
    }
  }
}
