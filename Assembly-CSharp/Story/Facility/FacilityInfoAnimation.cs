// Decompiled with JetBrains decompiler
// Type: Story.Facility.FacilityInfoAnimation
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using UI.Direction;
using UnityEngine;

#nullable disable
namespace Story.Facility
{
  [Token(Token = "0x200069E")]
  public class FacilityInfoAnimation
  {
    [Token(Token = "0x4001FBD")]
    [FieldOffset(Offset = "0x10")]
    private readonly Dictionary<int, UITimelineController> settingObjectMap;

    [Token(Token = "0x17000586")]
    public bool IsPlaying
    {
      [Token(Token = "0x600259D"), Address(RVA = "0x2F3BF20", Offset = "0x2F3BF20", VA = "0x2F3BF20")] get
      {
        return new bool();
      }
      [Token(Token = "0x600259E"), Address(RVA = "0x2F3BF28", Offset = "0x2F3BF28", VA = "0x2F3BF28")] private set
      {
      }
    }

    [Token(Token = "0x600259F")]
    [Address(RVA = "0x2F3BF34", Offset = "0x2F3BF34", VA = "0x2F3BF34")]
    public void SetObject(FacilityInfoLoader.TimelinePattern timelinePattern, GameObject gameObject)
    {
    }

    [Token(Token = "0x60025A0")]
    [Address(RVA = "0x2F3C000", Offset = "0x2F3C000", VA = "0x2F3C000")]
    public IEnumerator SetTimelineAsset(
      FacilityInfoLoader.TimelinePattern timelinePattern,
      UITimelineSettingAsset settingAsset,
      Action finishCallback = null)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x60025A1")]
    [Address(RVA = "0x2F3C0B4", Offset = "0x2F3C0B4", VA = "0x2F3C0B4")]
    public void PlayToIn(
      FacilityInfoLoader.TimelinePattern timelinePattern,
      string assetBundleName,
      Action finishCallback)
    {
    }

    [Token(Token = "0x60025A2")]
    [Address(RVA = "0x2F3C1E0", Offset = "0x2F3C1E0", VA = "0x2F3C1E0")]
    public void PlayToOut(
      FacilityInfoLoader.TimelinePattern timelinePattern,
      string assetBundleName,
      Action finishCallback)
    {
    }

    [Token(Token = "0x60025A3")]
    [Address(RVA = "0x2F3C310", Offset = "0x2F3C310", VA = "0x2F3C310")]
    public void Release()
    {
    }

    [Token(Token = "0x60025A4")]
    [Address(RVA = "0x2F3C360", Offset = "0x2F3C360", VA = "0x2F3C360")]
    public FacilityInfoAnimation()
    {
    }
  }
}
