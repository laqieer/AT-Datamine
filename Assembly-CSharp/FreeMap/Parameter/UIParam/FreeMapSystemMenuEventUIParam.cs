// Decompiled with JetBrains decompiler
// Type: FreeMap.Parameter.UIParam.FreeMapSystemMenuEventUIParam
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
namespace FreeMap.Parameter.UIParam
{
  [Token(Token = "0x2001872")]
  public class FreeMapSystemMenuEventUIParam : FreeMapUIParamBase
  {
    [Token(Token = "0x4006A64")]
    [FieldOffset(Offset = "0x4C")]
    private ActionIconTypeEnum actionIconType;

    [Token(Token = "0x1700160F")]
    public int PlayAdvID
    {
      [Token(Token = "0x6008A93"), Address(RVA = "0x4522604", Offset = "0x4522604", VA = "0x4522604")] get
      {
        return new int();
      }
      [Token(Token = "0x6008A94"), Address(RVA = "0x452260C", Offset = "0x452260C", VA = "0x452260C")] private set
      {
      }
    }

    [Token(Token = "0x17001610")]
    public override ActionIconTypeEnum ActionIconType
    {
      [Token(Token = "0x6008A95"), Address(RVA = "0x4522614", Offset = "0x4522614", VA = "0x4522614", Slot = "6")] get
      {
        return new ActionIconTypeEnum();
      }
    }

    [Token(Token = "0x6008A96")]
    [Address(RVA = "0x452261C", Offset = "0x452261C", VA = "0x452261C")]
    public FreeMapSystemMenuEventUIParam(
      int objectID,
      Vector3 iconOffset,
      int advId,
      int cameraMoveID,
      int playerMoveID,
      ActionIconTypeEnum iconType,
      EventNpcActEnum eventNpcAct)
    {
    }

    [Token(Token = "0x6008A97")]
    [Address(RVA = "0x45226BC", Offset = "0x45226BC", VA = "0x45226BC", Slot = "0")]
    public override bool Equals(object obj) => new bool();

    [Token(Token = "0x6008A98")]
    [Address(RVA = "0x4522784", Offset = "0x4522784", VA = "0x4522784", Slot = "2")]
    public override int GetHashCode() => new int();

    [Token(Token = "0x6008A99")]
    [Address(RVA = "0x452278C", Offset = "0x452278C", VA = "0x452278C", Slot = "11")]
    public override UIParameterType GetParamType() => new UIParameterType();

    [Token(Token = "0x6008A9A")]
    [Address(RVA = "0x4522794", Offset = "0x4522794", VA = "0x4522794", Slot = "12")]
    public override IFreeMapUIClip CreateClipClass(FreeMapUITransformHolder uiTransformHolder)
    {
      return (IFreeMapUIClip) null;
    }

    [Token(Token = "0x6008A9B")]
    [Address(RVA = "0x452282C", Offset = "0x452282C", VA = "0x452282C", Slot = "13")]
    public override IFreeMapIconButtonEvent CreateEvent(FreeMapCommonElement commonElement)
    {
      return (IFreeMapIconButtonEvent) null;
    }
  }
}
