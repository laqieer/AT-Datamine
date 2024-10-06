// Decompiled with JetBrains decompiler
// Type: FreeMap.Parameter.UIParam.SubQuest.FreeMapSubQuestReceiptEventUIParam
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
  [Token(Token = "0x200187D")]
  public class FreeMapSubQuestReceiptEventUIParam : FreeMapSubQuestEventUIParam
  {
    [Token(Token = "0x1700162F")]
    public override bool ShowPocketBookList
    {
      [Token(Token = "0x6008AFD"), Address(RVA = "0x4525270", Offset = "0x4525270", VA = "0x4525270", Slot = "17")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001630")]
    public override ActionIconTypeEnum ActionIconType
    {
      [Token(Token = "0x6008AFE"), Address(RVA = "0x4525278", Offset = "0x4525278", VA = "0x4525278", Slot = "6")] get
      {
        return new ActionIconTypeEnum();
      }
    }

    [Token(Token = "0x6008AFF")]
    [Address(RVA = "0x45239C4", Offset = "0x45239C4", VA = "0x45239C4")]
    public FreeMapSubQuestReceiptEventUIParam(
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

    [Token(Token = "0x6008B00")]
    [Address(RVA = "0x4525280", Offset = "0x4525280", VA = "0x4525280", Slot = "18")]
    public override SubQuestEventType GetSubQuestEventType() => new SubQuestEventType();

    [Token(Token = "0x6008B01")]
    [Address(RVA = "0x4525288", Offset = "0x4525288", VA = "0x4525288", Slot = "12")]
    public override IFreeMapUIClip CreateClipClass(FreeMapUITransformHolder uiTransformHolder)
    {
      return (IFreeMapUIClip) null;
    }

    [Token(Token = "0x6008B02")]
    [Address(RVA = "0x45252EC", Offset = "0x45252EC", VA = "0x45252EC", Slot = "13")]
    public override IFreeMapIconButtonEvent CreateEvent(FreeMapCommonElement commonElement)
    {
      return (IFreeMapIconButtonEvent) null;
    }
  }
}
