// Decompiled with JetBrains decompiler
// Type: FreeMap.UI.ButtonEvent.FreeMapIconEventCommunicationAdvStage
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
  [Token(Token = "0x2001702")]
  public class FreeMapIconEventCommunicationAdvStage : FreeMapIconEventAdvStage
  {
    [Token(Token = "0x40066B8")]
    [FieldOffset(Offset = "0x64")]
    private int commuId;
    [Token(Token = "0x40066B9")]
    [FieldOffset(Offset = "0x68")]
    private int locationID;

    [Token(Token = "0x6008244")]
    [Address(RVA = "0x41FA474", Offset = "0x41FA474", VA = "0x41FA474")]
    public FreeMapIconEventCommunicationAdvStage(
      int advId,
      IFreeMapAdvControl advControllMethod,
      int commuId,
      int locationID,
      IFreeMapTemporarySceneLoader sceneHandler)
    {
    }

    [Token(Token = "0x6008245")]
    [Address(RVA = "0x41FF128", Offset = "0x41FF128", VA = "0x41FF128", Slot = "5")]
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
