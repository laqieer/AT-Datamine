// Decompiled with JetBrains decompiler
// Type: FreeMap.Parameter.UIParam.AreaEvent.FreeMapAreaEventQuestTaskEventUIParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.UI;
using FreeMap.UI.ButtonEvent;
using FreeMap.UI.Control.Clip;
using GameCore.MasterData;
using Il2CppDummyDll;
using StaqData.AreaEvent;
using UnityEngine;

#nullable disable
namespace FreeMap.Parameter.UIParam.AreaEvent
{
  [Token(Token = "0x2001881")]
  public class FreeMapAreaEventQuestTaskEventUIParam : FreeMapAreaEventQuestEventUIParam
  {
    [Token(Token = "0x17001638")]
    public override bool IsTracking
    {
      [Token(Token = "0x6008B1A"), Address(RVA = "0x4525824", Offset = "0x4525824", VA = "0x4525824", Slot = "16")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001639")]
    public override ActionIconTypeEnum ActionIconType
    {
      [Token(Token = "0x6008B1B"), Address(RVA = "0x452582C", Offset = "0x452582C", VA = "0x452582C", Slot = "6")] get
      {
        return new ActionIconTypeEnum();
      }
    }

    [Token(Token = "0x1700163A")]
    public StoryAreaEventQuestTaskData TaskInfo
    {
      [Token(Token = "0x6008B1C"), Address(RVA = "0x45258F8", Offset = "0x45258F8", VA = "0x45258F8")] get
      {
        return (StoryAreaEventQuestTaskData) null;
      }
      [Token(Token = "0x6008B1D"), Address(RVA = "0x4525900", Offset = "0x4525900", VA = "0x4525900")] private set
      {
      }
    }

    [Token(Token = "0x1700163B")]
    private AreaEventQuestData areaeventquest
    {
      [Token(Token = "0x6008B1E"), Address(RVA = "0x4525888", Offset = "0x4525888", VA = "0x4525888")] get
      {
        return (AreaEventQuestData) null;
      }
    }

    [Token(Token = "0x6008B1F")]
    [Address(RVA = "0x4525908", Offset = "0x4525908", VA = "0x4525908")]
    public FreeMapAreaEventQuestTaskEventUIParam(
      int objectID,
      Vector3 iconOffset,
      int cameraMoveID,
      int playerMoveID,
      int subQuestID,
      int task,
      int advID,
      EventNpcActEnum eventNpcAct)
    {
    }

    [Token(Token = "0x6008B20")]
    [Address(RVA = "0x4523B04", Offset = "0x4523B04", VA = "0x4523B04")]
    public FreeMapAreaEventQuestTaskEventUIParam(StoryAreaEventQuestTaskData taskData)
    {
    }

    [Token(Token = "0x6008B21")]
    [Address(RVA = "0x4525A30", Offset = "0x4525A30", VA = "0x4525A30", Slot = "17")]
    public override AreaEventQuestEventType GetAreaEventQuestEventType()
    {
      return new AreaEventQuestEventType();
    }

    [Token(Token = "0x6008B22")]
    [Address(RVA = "0x4525A38", Offset = "0x4525A38", VA = "0x4525A38", Slot = "12")]
    public override IFreeMapUIClip CreateClipClass(FreeMapUITransformHolder uiTransformHolder)
    {
      return (IFreeMapUIClip) null;
    }

    [Token(Token = "0x6008B23")]
    [Address(RVA = "0x4525AD0", Offset = "0x4525AD0", VA = "0x4525AD0", Slot = "13")]
    public override IFreeMapIconButtonEvent CreateEvent(FreeMapCommonElement commonElement)
    {
      return (IFreeMapIconButtonEvent) null;
    }
  }
}
