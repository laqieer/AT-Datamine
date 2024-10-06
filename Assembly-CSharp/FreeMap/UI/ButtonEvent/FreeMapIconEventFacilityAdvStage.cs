// Decompiled with JetBrains decompiler
// Type: FreeMap.UI.ButtonEvent.FreeMapIconEventFacilityAdvStage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.Adv;
using FreeMap.Loader;
using GameCore.MasterData;
using Il2CppDummyDll;
using Story.Adv;
using System;
using UnityEngine;

#nullable disable
namespace FreeMap.UI.ButtonEvent
{
  [Token(Token = "0x2001705")]
  public class FreeMapIconEventFacilityAdvStage : FreeMapIconEventAdvStage
  {
    [Token(Token = "0x40066BC")]
    [FieldOffset(Offset = "0x64")]
    public int AttachID;
    [Token(Token = "0x40066BD")]
    [FieldOffset(Offset = "0x68")]
    public int RewardSetLabelID;
    [Token(Token = "0x40066BE")]
    [FieldOffset(Offset = "0x6C")]
    public int BonusSetLabelID;
    [Token(Token = "0x40066BF")]
    [FieldOffset(Offset = "0x70")]
    public int TargetWorkID;

    [Token(Token = "0x600824E")]
    [Address(RVA = "0x41FBC28", Offset = "0x41FBC28", VA = "0x41FBC28")]
    public FreeMapIconEventFacilityAdvStage(
      int advId,
      IFreeMapAdvControl advControlMethod,
      IFreeMapTemporarySceneLoader mapSceneHandler)
    {
    }

    [Token(Token = "0x600824F")]
    [Address(RVA = "0x41FF338", Offset = "0x41FF338", VA = "0x41FF338", Slot = "5")]
    protected override AdvStage CreateAdvStage(
      AdvDemoInfoData demoInfo,
      Func<string, GameObject> areaObjectModelRefGetMethod,
      Func<GameObject> getPlayerOjectModelRefMethod,
      Action onChangeArea)
    {
      return (AdvStage) null;
    }
  }
}
