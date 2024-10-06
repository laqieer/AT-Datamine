// Decompiled with JetBrains decompiler
// Type: Player.PlayerRankupStageManage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Player
{
  [Token(Token = "0x20009DE")]
  public class PlayerRankupStageManage
  {
    [Token(Token = "0x4002DC6")]
    private const string ABName = "ui_page_playerrankup_prefab";
    [Token(Token = "0x4002DC7")]
    private const string ABAssetName = "Container_PlayerRankUP";
    [Token(Token = "0x4002DC8")]
    [FieldOffset(Offset = "0x10")]
    private List<string> needABnames;
    [Token(Token = "0x4002DC9")]
    [FieldOffset(Offset = "0x18")]
    private PlayerRankupStage stage;
    [Token(Token = "0x4002DCA")]
    [FieldOffset(Offset = "0x20")]
    private GameObject stageGo;
    [Token(Token = "0x4002DCB")]
    [FieldOffset(Offset = "0x28")]
    private Action outEndCallback;
    [Token(Token = "0x4002DCC")]
    [FieldOffset(Offset = "0x30")]
    private bool ended;
    [Token(Token = "0x4002DCD")]
    [FieldOffset(Offset = "0x31")]
    private bool stageSetup;

    [Token(Token = "0x600382E")]
    [Address(RVA = "0x310A09C", Offset = "0x310A09C", VA = "0x310A09C")]
    public static IEnumerator RequestAsync(
      int beforeExp,
      int afterExp,
      AssetCachedSpawner assetCachedSpawner = null)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x600382F")]
    [Address(RVA = "0x310A140", Offset = "0x310A140", VA = "0x310A140")]
    public IEnumerator SystemInitializeProcess(AssetCachedSpawner assetCachedSpawner = null)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6003830")]
    [Address(RVA = "0x310A1DC", Offset = "0x310A1DC", VA = "0x310A1DC")]
    public void SetContentsData(int beforeTotalExp, int afterTotalExp)
    {
    }

    [Token(Token = "0x6003831")]
    [Address(RVA = "0x310AB28", Offset = "0x310AB28", VA = "0x310AB28")]
    public static bool NeedPlayerRankStage(int beforeTotalExp, int afterTotalExp) => new bool();

    [Token(Token = "0x6003832")]
    [Address(RVA = "0x310AB5C", Offset = "0x310AB5C", VA = "0x310AB5C")]
    private static (int, int) GetRankValueStage(int beforeTotalExp, int afterTotalExp) => ();

    [Token(Token = "0x6003833")]
    [Address(RVA = "0x310A224", Offset = "0x310A224", VA = "0x310A224")]
    private bool CreateNeedDisplayStageInfo(
      int beforeTotalExp,
      int afterTotalExp,
      ref DisplayPlayerRankupStageInfo info)
    {
      return new bool();
    }

    [Token(Token = "0x6003834")]
    [Address(RVA = "0x310AC90", Offset = "0x310AC90", VA = "0x310AC90")]
    public IEnumerator ContentsLoadProcess() => (IEnumerator) null;

    [Token(Token = "0x6003835")]
    [Address(RVA = "0x310AD20", Offset = "0x310AD20", VA = "0x310AD20")]
    public IEnumerator ExecuteToEnded() => (IEnumerator) null;

    [Token(Token = "0x6003836")]
    [Address(RVA = "0x310ADB0", Offset = "0x310ADB0", VA = "0x310ADB0")]
    public void Execute()
    {
    }

    [Token(Token = "0x6003837")]
    [Address(RVA = "0x310AEB4", Offset = "0x310AEB4", VA = "0x310AEB4")]
    private void OnEnded()
    {
    }

    [Token(Token = "0x6003838")]
    [Address(RVA = "0x310AF08", Offset = "0x310AF08", VA = "0x310AF08")]
    public void SetExecuteEndedCallback(Action callback)
    {
    }

    [Token(Token = "0x6003839")]
    [Address(RVA = "0x310AF10", Offset = "0x310AF10", VA = "0x310AF10")]
    public void UnloadAll()
    {
    }

    [Token(Token = "0x600383A")]
    [Address(RVA = "0x310B0E4", Offset = "0x310B0E4", VA = "0x310B0E4")]
    public void Destroy()
    {
    }

    [Token(Token = "0x600383B")]
    [Address(RVA = "0x310B178", Offset = "0x310B178", VA = "0x310B178")]
    public PlayerRankupStageManage()
    {
    }
  }
}
