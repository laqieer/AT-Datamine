// Decompiled with JetBrains decompiler
// Type: FreeMap.UI.ButtonEvent.FreeMapIconEventAreaEventQuestAdvStage
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
  [Token(Token = "0x2001701")]
  public class FreeMapIconEventAreaEventQuestAdvStage : FreeMapIconEventAdvStage
  {
    [Token(Token = "0x17001457")]
    public int AreaEventQuestTaskID
    {
      [Token(Token = "0x6008241"), Address(RVA = "0x41FF024", Offset = "0x41FF024", VA = "0x41FF024")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6008242")]
    [Address(RVA = "0x41FF02C", Offset = "0x41FF02C", VA = "0x41FF02C")]
    public FreeMapIconEventAreaEventQuestAdvStage(
      int areaeventquestTaskID,
      int advId,
      IFreeMapAdvControl advControlMethod,
      IFreeMapTemporarySceneLoader mapSceneHandler,
      bool isFreeMapEnd = false)
    {
    }

    [Token(Token = "0x6008243")]
    [Address(RVA = "0x41FF088", Offset = "0x41FF088", VA = "0x41FF088", Slot = "5")]
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
