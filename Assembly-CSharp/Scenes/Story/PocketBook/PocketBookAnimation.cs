// Decompiled with JetBrains decompiler
// Type: Scenes.Story.PocketBook.PocketBookAnimation
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
namespace Scenes.Story.PocketBook
{
  [Token(Token = "0x2002DA1")]
  [Serializable]
  public class PocketBookAnimation : MonoBehaviour
  {
    [Token(Token = "0x400C423")]
    [FieldOffset(Offset = "0x18")]
    private readonly Dictionary<int, UITimelineController> settingObjectMap;

    [Token(Token = "0x17003CFB")]
    public bool IsPlaying
    {
      [Token(Token = "0x6011D92"), Address(RVA = "0x3FA57BC", Offset = "0x3FA57BC", VA = "0x3FA57BC")] get
      {
        return new bool();
      }
      [Token(Token = "0x6011D93"), Address(RVA = "0x3FA57C4", Offset = "0x3FA57C4", VA = "0x3FA57C4")] private set
      {
      }
    }

    [Token(Token = "0x6011D94")]
    [Address(RVA = "0x3FA4C7C", Offset = "0x3FA4C7C", VA = "0x3FA4C7C")]
    public void Initialize()
    {
    }

    [Token(Token = "0x6011D95")]
    [Address(RVA = "0x3FA4F14", Offset = "0x3FA4F14", VA = "0x3FA4F14")]
    public void SetObject(PocketBookLoader.TimelinePattern timelinePattern, GameObject gameObject)
    {
    }

    [Token(Token = "0x6011D96")]
    [Address(RVA = "0x3FA4E30", Offset = "0x3FA4E30", VA = "0x3FA4E30")]
    public IEnumerator SetTimelineAsset(
      PocketBookLoader.TimelinePattern timelinePattern,
      UITimelineSettingAsset settingAsset,
      Action finishCallback = null)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6011D97")]
    [Address(RVA = "0x3FA4430", Offset = "0x3FA4430", VA = "0x3FA4430")]
    public void ReadyForPlayToIn(
      PocketBookLoader.TimelinePattern timelinePattern,
      string assetBundleName)
    {
    }

    [Token(Token = "0x6011D98")]
    [Address(RVA = "0x3FA4030", Offset = "0x3FA4030", VA = "0x3FA4030")]
    public void PlayToIn(
      bool setup,
      PocketBookLoader.TimelinePattern timelinePattern,
      string assetBundleName,
      Action finishCallback)
    {
    }

    [Token(Token = "0x6011D99")]
    [Address(RVA = "0x3FA2620", Offset = "0x3FA2620", VA = "0x3FA2620")]
    public void PlayToIn(
      PocketBookLoader.TimelinePattern timelinePattern,
      string assetBundleName,
      PocketBookAnimation.BindData[] bindDatas,
      Action finishCallback)
    {
    }

    [Token(Token = "0x6011D9A")]
    [Address(RVA = "0x3FA52B0", Offset = "0x3FA52B0", VA = "0x3FA52B0")]
    public void PlayToIn(
      PocketBookLoader.TimelinePattern timelinePattern,
      string assetBundleName,
      Action finishCallback)
    {
    }

    [Token(Token = "0x6011D9B")]
    [Address(RVA = "0x3FA2824", Offset = "0x3FA2824", VA = "0x3FA2824")]
    public void PlayToOut(
      PocketBookLoader.TimelinePattern timelinePattern,
      string assetBundleName,
      PocketBookAnimation.BindData[] bindDatas,
      Action finishCallback)
    {
    }

    [Token(Token = "0x6011D9C")]
    [Address(RVA = "0x3FA54DC", Offset = "0x3FA54DC", VA = "0x3FA54DC")]
    public void PlayToOut(
      PocketBookLoader.TimelinePattern timelinePattern,
      string assetBundleName,
      Action finishCallback)
    {
    }

    [Token(Token = "0x6011D9D")]
    [Address(RVA = "0x3FA38C8", Offset = "0x3FA38C8", VA = "0x3FA38C8")]
    public void Release()
    {
    }

    [Token(Token = "0x6011D9E")]
    [Address(RVA = "0x3FA5820", Offset = "0x3FA5820", VA = "0x3FA5820")]
    public PocketBookAnimation()
    {
    }

    [Token(Token = "0x2002DA2")]
    public class BindData
    {
      [Token(Token = "0x17003CFC")]
      public string RootTrackName
      {
        [Token(Token = "0x6011D9F"), Address(RVA = "0x3FA589C", Offset = "0x3FA589C", VA = "0x3FA589C")] get
        {
          return (string) null;
        }
        [Token(Token = "0x6011DA0"), Address(RVA = "0x3FA58A4", Offset = "0x3FA58A4", VA = "0x3FA58A4")] set
        {
        }
      }

      [Token(Token = "0x17003CFD")]
      public string TrackName
      {
        [Token(Token = "0x6011DA1"), Address(RVA = "0x3FA58AC", Offset = "0x3FA58AC", VA = "0x3FA58AC")] get
        {
          return (string) null;
        }
        [Token(Token = "0x6011DA2"), Address(RVA = "0x3FA58B4", Offset = "0x3FA58B4", VA = "0x3FA58B4")] set
        {
        }
      }

      [Token(Token = "0x17003CFE")]
      public GameObject BindObj
      {
        [Token(Token = "0x6011DA3"), Address(RVA = "0x3FA58BC", Offset = "0x3FA58BC", VA = "0x3FA58BC")] get
        {
          return (GameObject) null;
        }
        [Token(Token = "0x6011DA4"), Address(RVA = "0x3FA58C4", Offset = "0x3FA58C4", VA = "0x3FA58C4")] set
        {
        }
      }

      [Token(Token = "0x6011DA5")]
      [Address(RVA = "0x3FA25C8", Offset = "0x3FA25C8", VA = "0x3FA25C8")]
      public BindData()
      {
      }
    }
  }
}
