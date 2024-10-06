// Decompiled with JetBrains decompiler
// Type: FreeMap.Parameter.UIParam.SubQuest.FreeMapSubQuestTaskEventUIParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.UI;
using FreeMap.UI.ButtonEvent;
using FreeMap.UI.Control.Clip;
using GameCore.MasterData;
using Il2CppDummyDll;
using StaqData;
using UnityEngine;

#nullable disable
namespace FreeMap.Parameter.UIParam.SubQuest
{
  [Token(Token = "0x200187E")]
  public class FreeMapSubQuestTaskEventUIParam : FreeMapSubQuestEventUIParam
  {
    [Token(Token = "0x17001631")]
    public override bool ShowPocketBookList
    {
      [Token(Token = "0x6008B03"), Address(RVA = "0x4525360", Offset = "0x4525360", VA = "0x4525360", Slot = "17")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001632")]
    public override ActionIconTypeEnum ActionIconType
    {
      [Token(Token = "0x6008B04"), Address(RVA = "0x452546C", Offset = "0x452546C", VA = "0x452546C", Slot = "6")] get
      {
        return new ActionIconTypeEnum();
      }
    }

    [Token(Token = "0x17001633")]
    public SubQuestTaskInfo TaskInfo
    {
      [Token(Token = "0x6008B05"), Address(RVA = "0x45254C8", Offset = "0x45254C8", VA = "0x45254C8")] get
      {
        return (SubQuestTaskInfo) null;
      }
    }

    [Token(Token = "0x6008B06")]
    [Address(RVA = "0x4525380", Offset = "0x4525380", VA = "0x4525380")]
    public SubQuestData GetSubQuest() => (SubQuestData) null;

    [Token(Token = "0x6008B07")]
    [Address(RVA = "0x4525588", Offset = "0x4525588", VA = "0x4525588")]
    public FreeMapSubQuestTaskEventUIParam(
      int objectID,
      Vector3 iconOffset,
      int cameraMoveID,
      int playerMoveID,
      int subQuestID,
      int subQuestTaskID,
      int advID,
      EventNpcActEnum eventNpcAct)
    {
    }

    [Token(Token = "0x6008B08")]
    [Address(RVA = "0x45244E4", Offset = "0x45244E4", VA = "0x45244E4")]
    public FreeMapSubQuestTaskEventUIParam(SubQuestTaskInfo taskInfo)
    {
    }

    [Token(Token = "0x6008B09")]
    [Address(RVA = "0x452558C", Offset = "0x452558C", VA = "0x452558C", Slot = "18")]
    public override SubQuestEventType GetSubQuestEventType() => new SubQuestEventType();

    [Token(Token = "0x6008B0A")]
    [Address(RVA = "0x4525594", Offset = "0x4525594", VA = "0x4525594", Slot = "12")]
    public override IFreeMapUIClip CreateClipClass(FreeMapUITransformHolder uiTransformHolder)
    {
      return (IFreeMapUIClip) null;
    }

    [Token(Token = "0x6008B0B")]
    [Address(RVA = "0x452562C", Offset = "0x452562C", VA = "0x452562C", Slot = "13")]
    public override IFreeMapIconButtonEvent CreateEvent(FreeMapCommonElement commonElement)
    {
      return (IFreeMapIconButtonEvent) null;
    }
  }
}
