// Decompiled with JetBrains decompiler
// Type: FreeMap.Parameter.UIParam.FreeMapBreakableUIParam
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
  [Token(Token = "0x2001865")]
  public class FreeMapBreakableUIParam : FreeMapRewardUIParam
  {
    [Token(Token = "0x170015E2")]
    public override bool IsShowMap
    {
      [Token(Token = "0x6008A07"), Address(RVA = "0x451FD4C", Offset = "0x451FD4C", VA = "0x451FD4C", Slot = "8")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170015E3")]
    public override ActionIconTypeEnum ActionIconType
    {
      [Token(Token = "0x6008A08"), Address(RVA = "0x451FD54", Offset = "0x451FD54", VA = "0x451FD54", Slot = "6")] get
      {
        return new ActionIconTypeEnum();
      }
    }

    [Token(Token = "0x6008A09")]
    [Address(RVA = "0x451FD6C", Offset = "0x451FD6C", VA = "0x451FD6C")]
    public StoryFreeActionRewardObjectBreakableObjectPropSettingData PropSettingData()
    {
      return (StoryFreeActionRewardObjectBreakableObjectPropSettingData) null;
    }

    [Token(Token = "0x170015E4")]
    public int BreakableObjectID
    {
      [Token(Token = "0x6008A0A"), Address(RVA = "0x451FE78", Offset = "0x451FE78", VA = "0x451FE78")] get
      {
        return new int();
      }
      [Token(Token = "0x6008A0B"), Address(RVA = "0x451FE80", Offset = "0x451FE80", VA = "0x451FE80")] private set
      {
      }
    }

    [Token(Token = "0x170015E5")]
    public int ChapterID
    {
      [Token(Token = "0x6008A0C"), Address(RVA = "0x451FE88", Offset = "0x451FE88", VA = "0x451FE88")] get
      {
        return new int();
      }
      [Token(Token = "0x6008A0D"), Address(RVA = "0x451FE90", Offset = "0x451FE90", VA = "0x451FE90")] private set
      {
      }
    }

    [Token(Token = "0x6008A0E")]
    [Address(RVA = "0x451FE98", Offset = "0x451FE98", VA = "0x451FE98")]
    public FreeMapBreakableUIParam(
      int rewardLayoutID,
      int breakableObjectID,
      int chapterID,
      Vector3 iconOffset,
      int playerMoveLabel)
    {
    }

    [Token(Token = "0x6008A0F")]
    [Address(RVA = "0x451FF78", Offset = "0x451FF78", VA = "0x451FF78", Slot = "12")]
    public override IFreeMapUIClip CreateClipClass(FreeMapUITransformHolder uiTransformHolder)
    {
      return (IFreeMapUIClip) null;
    }

    [Token(Token = "0x6008A10")]
    [Address(RVA = "0x4520010", Offset = "0x4520010", VA = "0x4520010", Slot = "11")]
    public override UIParameterType GetParamType() => new UIParameterType();

    [Token(Token = "0x6008A11")]
    [Address(RVA = "0x4520018", Offset = "0x4520018", VA = "0x4520018", Slot = "0")]
    public override bool Equals(object obj) => new bool();

    [Token(Token = "0x6008A12")]
    [Address(RVA = "0x4520130", Offset = "0x4520130", VA = "0x4520130", Slot = "2")]
    public override int GetHashCode() => new int();

    [Token(Token = "0x6008A13")]
    [Address(RVA = "0x4520140", Offset = "0x4520140", VA = "0x4520140", Slot = "13")]
    public override IFreeMapIconButtonEvent CreateEvent(FreeMapCommonElement commonElement)
    {
      return (IFreeMapIconButtonEvent) null;
    }
  }
}
