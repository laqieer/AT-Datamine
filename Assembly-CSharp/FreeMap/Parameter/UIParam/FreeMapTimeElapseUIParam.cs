// Decompiled with JetBrains decompiler
// Type: FreeMap.Parameter.UIParam.FreeMapTimeElapseUIParam
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
  [Token(Token = "0x2001873")]
  public class FreeMapTimeElapseUIParam : FreeMapRewardUIParam
  {
    [Token(Token = "0x4006A65")]
    [FieldOffset(Offset = "0x48")]
    public int advID;

    [Token(Token = "0x17001611")]
    public override ActionIconTypeEnum ActionIconType
    {
      [Token(Token = "0x6008A9C"), Address(RVA = "0x45228A0", Offset = "0x45228A0", VA = "0x45228A0", Slot = "6")] get
      {
        return new ActionIconTypeEnum();
      }
    }

    [Token(Token = "0x6008A9D")]
    [Address(RVA = "0x45228A8", Offset = "0x45228A8", VA = "0x45228A8", Slot = "11")]
    public override UIParameterType GetParamType() => new UIParameterType();

    [Token(Token = "0x6008A9E")]
    [Address(RVA = "0x45228B0", Offset = "0x45228B0", VA = "0x45228B0")]
    public FreeMapTimeElapseUIParam(int layoutID, Vector3 iconOffset, int advID)
    {
    }

    [Token(Token = "0x6008A9F")]
    [Address(RVA = "0x4522928", Offset = "0x4522928", VA = "0x4522928", Slot = "13")]
    public override IFreeMapIconButtonEvent CreateEvent(FreeMapCommonElement commonElement)
    {
      return (IFreeMapIconButtonEvent) null;
    }

    [Token(Token = "0x6008AA0")]
    [Address(RVA = "0x452299C", Offset = "0x452299C", VA = "0x452299C", Slot = "12")]
    public override IFreeMapUIClip CreateClipClass(FreeMapUITransformHolder uiTransformHolder)
    {
      return (IFreeMapUIClip) null;
    }

    [Token(Token = "0x6008AA1")]
    [Address(RVA = "0x4522A34", Offset = "0x4522A34", VA = "0x4522A34")]
    public static FreeMapTimeElapseUIParam Create(
      StoryFreeActionSettingData freeactionSetting,
      int sequenceID)
    {
      return (FreeMapTimeElapseUIParam) null;
    }
  }
}
