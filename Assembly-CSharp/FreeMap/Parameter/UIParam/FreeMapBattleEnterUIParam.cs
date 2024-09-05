// Decompiled with JetBrains decompiler
// Type: FreeMap.Parameter.UIParam.FreeMapBattleEnterUIParam
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
  [Token(Token = "0x2001863")]
  public class FreeMapBattleEnterUIParam : FreeMapUIParamBase
  {
    [Token(Token = "0x170015E1")]
    public override ActionIconTypeEnum ActionIconType
    {
      [Token(Token = "0x60089FC"), Address(RVA = "0x451F6F0", Offset = "0x451F6F0", VA = "0x451F6F0", Slot = "6")] get
      {
        return new ActionIconTypeEnum();
      }
    }

    [Token(Token = "0x60089FD")]
    [Address(RVA = "0x451F6F8", Offset = "0x451F6F8", VA = "0x451F6F8")]
    public FreeMapBattleEnterUIParam(int objectID, Vector3 iconOffset)
    {
    }

    [Token(Token = "0x60089FE")]
    [Address(RVA = "0x451F770", Offset = "0x451F770", VA = "0x451F770", Slot = "11")]
    public override UIParameterType GetParamType() => new UIParameterType();

    [Token(Token = "0x60089FF")]
    [Address(RVA = "0x451F778", Offset = "0x451F778", VA = "0x451F778", Slot = "10")]
    public override string GetTitle() => (string) null;

    [Token(Token = "0x6008A00")]
    [Address(RVA = "0x451F780", Offset = "0x451F780", VA = "0x451F780", Slot = "12")]
    public override IFreeMapUIClip CreateClipClass(FreeMapUITransformHolder uiTransformHolder)
    {
      return (IFreeMapUIClip) null;
    }

    [Token(Token = "0x6008A01")]
    [Address(RVA = "0x451F818", Offset = "0x451F818", VA = "0x451F818", Slot = "0")]
    public override bool Equals(object obj) => new bool();

    [Token(Token = "0x6008A02")]
    [Address(RVA = "0x451F8A4", Offset = "0x451F8A4", VA = "0x451F8A4", Slot = "13")]
    public override IFreeMapIconButtonEvent CreateEvent(FreeMapCommonElement commonElement)
    {
      return (IFreeMapIconButtonEvent) null;
    }

    [Token(Token = "0x6008A03")]
    [Address(RVA = "0x451F918", Offset = "0x451F918", VA = "0x451F918")]
    public static FreeMapBattleEnterUIParam Create() => (FreeMapBattleEnterUIParam) null;

    [Token(Token = "0x6008A04")]
    [Address(RVA = "0x451FA04", Offset = "0x451FA04", VA = "0x451FA04")]
    public static FreeMapBattleEnterUIParam Create(
      StoryFreeActionSettingData freeactionSetting,
      int sequenceID)
    {
      return (FreeMapBattleEnterUIParam) null;
    }
  }
}
