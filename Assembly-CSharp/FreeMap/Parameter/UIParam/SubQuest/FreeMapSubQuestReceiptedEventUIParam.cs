// Decompiled with JetBrains decompiler
// Type: FreeMap.Parameter.UIParam.SubQuest.FreeMapSubQuestReceiptedEventUIParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.UI;
using FreeMap.UI.ButtonEvent;
using FreeMap.UI.Control.Clip;
using GameCore.MasterData;
using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace FreeMap.Parameter.UIParam.SubQuest
{
  [Token(Token = "0x200187C")]
  public class FreeMapSubQuestReceiptedEventUIParam : FreeMapSubQuestEventUIParam
  {
    [Token(Token = "0x1700162C")]
    public override bool ShowPocketBookList
    {
      [Token(Token = "0x6008AF6"), Address(RVA = "0x4525144", Offset = "0x4525144", VA = "0x4525144", Slot = "17")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700162D")]
    public override bool IsTracking
    {
      [Token(Token = "0x6008AF7"), Address(RVA = "0x452514C", Offset = "0x452514C", VA = "0x452514C", Slot = "16")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700162E")]
    public override ActionIconTypeEnum ActionIconType
    {
      [Token(Token = "0x6008AF8"), Address(RVA = "0x4525154", Offset = "0x4525154", VA = "0x4525154", Slot = "6")] get
      {
        return new ActionIconTypeEnum();
      }
    }

    [Token(Token = "0x6008AF9")]
    [Address(RVA = "0x4523AA0", Offset = "0x4523AA0", VA = "0x4523AA0")]
    public FreeMapSubQuestReceiptedEventUIParam(
      int objectID,
      Vector3 iconOffset,
      int cameraMoveID,
      int playerMoveID,
      int subQuestID,
      int subQuestTaskID,
      int playADVEventName,
      EventNpcActEnum eventNpcAct)
    {
    }

    [Token(Token = "0x6008AFA")]
    [Address(RVA = "0x452515C", Offset = "0x452515C", VA = "0x452515C", Slot = "18")]
    public override SubQuestEventType GetSubQuestEventType() => new SubQuestEventType();

    [Token(Token = "0x6008AFB")]
    [Address(RVA = "0x4525164", Offset = "0x4525164", VA = "0x4525164", Slot = "12")]
    public override IFreeMapUIClip CreateClipClass(FreeMapUITransformHolder uiTransformHolder)
    {
      return (IFreeMapUIClip) null;
    }

    [Token(Token = "0x6008AFC")]
    [Address(RVA = "0x45251FC", Offset = "0x45251FC", VA = "0x45251FC", Slot = "13")]
    public override IFreeMapIconButtonEvent CreateEvent(FreeMapCommonElement commonElement)
    {
      return (IFreeMapIconButtonEvent) null;
    }
  }
}
