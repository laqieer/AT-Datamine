// Decompiled with JetBrains decompiler
// Type: FreeMap.Parameter.UIParam.FreeMapFacilityEventUIParam
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
namespace FreeMap.Parameter.UIParam
{
  [Token(Token = "0x2001869")]
  public class FreeMapFacilityEventUIParam : FreeMapUIParamBase
  {
    [Token(Token = "0x170015F1")]
    public override ActionIconTypeEnum ActionIconType
    {
      [Token(Token = "0x6008A39"), Address(RVA = "0x4520C68", Offset = "0x4520C68", VA = "0x4520C68", Slot = "6")] get
      {
        return new ActionIconTypeEnum();
      }
    }

    [Token(Token = "0x170015F2")]
    public int FacilityAttachID
    {
      [Token(Token = "0x6008A3A"), Address(RVA = "0x4520D1C", Offset = "0x4520D1C", VA = "0x4520D1C")] get
      {
        return new int();
      }
      [Token(Token = "0x6008A3B"), Address(RVA = "0x4520D24", Offset = "0x4520D24", VA = "0x4520D24")] private set
      {
      }
    }

    [Token(Token = "0x170015F3")]
    public FreeMapFacilityEventUIParam.ADVInfo ADV
    {
      [Token(Token = "0x6008A3C"), Address(RVA = "0x4520D2C", Offset = "0x4520D2C", VA = "0x4520D2C")] get
      {
        return new FreeMapFacilityEventUIParam.ADVInfo();
      }
      [Token(Token = "0x6008A3D"), Address(RVA = "0x4520D34", Offset = "0x4520D34", VA = "0x4520D34")] private set
      {
      }
    }

    [Token(Token = "0x170015F4")]
    public int RewardSetId
    {
      [Token(Token = "0x6008A3E"), Address(RVA = "0x4520D3C", Offset = "0x4520D3C", VA = "0x4520D3C")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170015F5")]
    public bool IsBounus
    {
      [Token(Token = "0x6008A3F"), Address(RVA = "0x4520D44", Offset = "0x4520D44", VA = "0x4520D44")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170015F6")]
    public int AddRewardSetIdWhenBounus
    {
      [Token(Token = "0x6008A40"), Address(RVA = "0x4520D4C", Offset = "0x4520D4C", VA = "0x4520D4C")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170015F7")]
    public bool Acted
    {
      [Token(Token = "0x6008A41"), Address(RVA = "0x4520D54", Offset = "0x4520D54", VA = "0x4520D54")] get
      {
        return new bool();
      }
      [Token(Token = "0x6008A42"), Address(RVA = "0x4520D5C", Offset = "0x4520D5C", VA = "0x4520D5C")] private set
      {
      }
    }

    [Token(Token = "0x6008A43")]
    [Address(RVA = "0x4520D68", Offset = "0x4520D68", VA = "0x4520D68")]
    public FreeMapFacilityEventUIParam(
      int objectID,
      Vector3 iconOffset,
      int cameraMoveID,
      int playerMoveID,
      int facilityAttachID,
      FreeMapFacilityEventUIParam.ADVInfo adv,
      int RewardSetId,
      bool IsBounus,
      int AddRewardSetIdWhenBounus,
      EventNpcActEnum eventNpcAct)
    {
    }

    [Token(Token = "0x6008A44")]
    [Address(RVA = "0x4520E30", Offset = "0x4520E30", VA = "0x4520E30", Slot = "0")]
    public override bool Equals(object obj) => new bool();

    [Token(Token = "0x6008A45")]
    [Address(RVA = "0x4520F78", Offset = "0x4520F78", VA = "0x4520F78", Slot = "2")]
    public override int GetHashCode() => new int();

    [Token(Token = "0x6008A46")]
    [Address(RVA = "0x4520F80", Offset = "0x4520F80", VA = "0x4520F80", Slot = "11")]
    public override UIParameterType GetParamType() => new UIParameterType();

    [Token(Token = "0x6008A47")]
    [Address(RVA = "0x4520F88", Offset = "0x4520F88", VA = "0x4520F88")]
    public void SetActed(bool acted)
    {
    }

    [Token(Token = "0x6008A48")]
    [Address(RVA = "0x4520F94", Offset = "0x4520F94", VA = "0x4520F94")]
    public void Set(FreeMapFacilityEventUIParam.ADVInfo advinfo)
    {
    }

    [Token(Token = "0x6008A49")]
    [Address(RVA = "0x4520F9C", Offset = "0x4520F9C", VA = "0x4520F9C", Slot = "12")]
    public override IFreeMapUIClip CreateClipClass(FreeMapUITransformHolder uiTransformHolder)
    {
      return (IFreeMapUIClip) null;
    }

    [Token(Token = "0x6008A4A")]
    [Address(RVA = "0x4521000", Offset = "0x4521000", VA = "0x4521000", Slot = "13")]
    public override IFreeMapIconButtonEvent CreateEvent(FreeMapCommonElement commonElement)
    {
      return (IFreeMapIconButtonEvent) null;
    }

    [Token(Token = "0x6008A4B")]
    [Address(RVA = "0x4521268", Offset = "0x4521268", VA = "0x4521268", Slot = "10")]
    public override string GetTitle() => (string) null;

    [Token(Token = "0x6008A4C")]
    [Address(RVA = "0x4520C6C", Offset = "0x4520C6C", VA = "0x4520C6C")]
    private ActionIconTypeEnum GetActionIconType() => new ActionIconTypeEnum();

    [Token(Token = "0x200186A")]
    public struct ADVInfo
    {
      [Token(Token = "0x170015F8")]
      public readonly int Adv
      {
        [Token(Token = "0x6008A4D"), Address(RVA = "0x4521378", Offset = "0x4521378", VA = "0x4521378")] get
        {
          return new int();
        }
      }

      [Token(Token = "0x6008A4E")]
      [Address(RVA = "0x4521380", Offset = "0x4521380", VA = "0x4521380")]
      public ADVInfo(int adv)
      {
      }

      [Token(Token = "0x6008A4F")]
      [Address(RVA = "0x4521388", Offset = "0x4521388", VA = "0x4521388")]
      public static FreeMapFacilityEventUIParam.ADVInfo OnNormal(Facility facility)
      {
        return new FreeMapFacilityEventUIParam.ADVInfo();
      }
    }
  }
}
