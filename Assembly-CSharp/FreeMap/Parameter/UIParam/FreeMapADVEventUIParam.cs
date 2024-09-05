// Decompiled with JetBrains decompiler
// Type: FreeMap.Parameter.UIParam.FreeMapADVEventUIParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.UI;
using FreeMap.UI.ButtonEvent;
using FreeMap.UI.Control.Clip;
using GameCore.MasterData;
using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace FreeMap.Parameter.UIParam
{
  [Token(Token = "0x2001862")]
  public class FreeMapADVEventUIParam : FreeMapUIParamBase
  {
    [Token(Token = "0x4006A42")]
    [FieldOffset(Offset = "0x48")]
    private int tableID;

    [Token(Token = "0x170015DD")]
    public override bool IsShowMap
    {
      [Token(Token = "0x60089F0"), Address(RVA = "0x451EEF4", Offset = "0x451EEF4", VA = "0x451EEF4", Slot = "8")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170015DE")]
    public IReadOnlyList<StoryFreeActionTalkADVEventTextData> AdvGroupingList
    {
      [Token(Token = "0x60089F1"), Address(RVA = "0x451EEFC", Offset = "0x451EEFC", VA = "0x451EEFC")] get
      {
        return (IReadOnlyList<StoryFreeActionTalkADVEventTextData>) null;
      }
    }

    [Token(Token = "0x170015DF")]
    public PlayAdvPatternEnum PlayPattern
    {
      [Token(Token = "0x60089F2"), Address(RVA = "0x451EF04", Offset = "0x451EF04", VA = "0x451EF04")] private set
      {
      }
      [Token(Token = "0x60089F3"), Address(RVA = "0x451EF0C", Offset = "0x451EF0C", VA = "0x451EF0C")] get
      {
        return new PlayAdvPatternEnum();
      }
    }

    [Token(Token = "0x170015E0")]
    public override ActionIconTypeEnum ActionIconType
    {
      [Token(Token = "0x60089F4"), Address(RVA = "0x451EF14", Offset = "0x451EF14", VA = "0x451EF14", Slot = "6")] get
      {
        return new ActionIconTypeEnum();
      }
    }

    [Token(Token = "0x60089F5")]
    [Address(RVA = "0x451F298", Offset = "0x451F298", VA = "0x451F298")]
    public FreeMapADVEventUIParam(
      int objectID,
      Vector3 iconOffset,
      int tableID,
      int cameraMoveID,
      int playerMoveID,
      EventNpcActEnum eventNpcAct,
      PlayAdvPatternEnum playPattern)
    {
    }

    [Token(Token = "0x60089F6")]
    [Address(RVA = "0x451F420", Offset = "0x451F420", VA = "0x451F420", Slot = "0")]
    public override bool Equals(object obj) => new bool();

    [Token(Token = "0x60089F7")]
    [Address(RVA = "0x451F5B0", Offset = "0x451F5B0", VA = "0x451F5B0", Slot = "2")]
    public override int GetHashCode() => new int();

    [Token(Token = "0x60089F8")]
    [Address(RVA = "0x451F5C0", Offset = "0x451F5C0", VA = "0x451F5C0", Slot = "11")]
    public override UIParameterType GetParamType() => new UIParameterType();

    [Token(Token = "0x60089F9")]
    [Address(RVA = "0x451F5C8", Offset = "0x451F5C8", VA = "0x451F5C8", Slot = "12")]
    public override IFreeMapUIClip CreateClipClass(FreeMapUITransformHolder uiTransformHolder)
    {
      return (IFreeMapUIClip) null;
    }

    [Token(Token = "0x60089FA")]
    [Address(RVA = "0x451EF30", Offset = "0x451EF30", VA = "0x451EF30")]
    public bool CheckAlreadyRead() => new bool();

    [Token(Token = "0x60089FB")]
    [Address(RVA = "0x451F67C", Offset = "0x451F67C", VA = "0x451F67C", Slot = "13")]
    public override IFreeMapIconButtonEvent CreateEvent(FreeMapCommonElement commonElement)
    {
      return (IFreeMapIconButtonEvent) null;
    }
  }
}
