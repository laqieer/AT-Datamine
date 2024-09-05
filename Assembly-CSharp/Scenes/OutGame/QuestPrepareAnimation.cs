// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.QuestPrepareAnimation
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
namespace Scenes.OutGame
{
  [Token(Token = "0x2003236")]
  [Serializable]
  public class QuestPrepareAnimation : MonoBehaviour
  {
    [Token(Token = "0x400D67F")]
    [FieldOffset(Offset = "0x18")]
    private readonly Dictionary<int, UITimelineController> settingObjectMap;

    [Token(Token = "0x1700412E")]
    public bool IsPlaying
    {
      [Token(Token = "0x601393A"), Address(RVA = "0x460CF90", Offset = "0x460CF90", VA = "0x460CF90")] get
      {
        return new bool();
      }
      [Token(Token = "0x601393B"), Address(RVA = "0x460CF98", Offset = "0x460CF98", VA = "0x460CF98")] private set
      {
      }
    }

    [Token(Token = "0x601393C")]
    [Address(RVA = "0x460CFA4", Offset = "0x460CFA4", VA = "0x460CFA4")]
    public void Initialize()
    {
    }

    [Token(Token = "0x601393D")]
    [Address(RVA = "0x460D058", Offset = "0x460D058", VA = "0x460D058")]
    public void SetObject(
      QuestPrepareAssetLoader.TimelinePattern timelinePattern,
      GameObject gameObject)
    {
    }

    [Token(Token = "0x601393E")]
    [Address(RVA = "0x460D124", Offset = "0x460D124", VA = "0x460D124")]
    public IEnumerator SetTimelineAsset(
      QuestPrepareAssetLoader.TimelinePattern timelinePattern,
      UITimelineSettingAsset settingAsset)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x601393F")]
    [Address(RVA = "0x460D1CC", Offset = "0x460D1CC", VA = "0x460D1CC")]
    public void PlayToIn(
      QuestPrepareAssetLoader.TimelinePattern timelinePattern,
      string assetBundleName,
      QuestPrepareAnimation.BindData[] bindDatas,
      Action finishCallback)
    {
    }

    [Token(Token = "0x6013940")]
    [Address(RVA = "0x460D3B4", Offset = "0x460D3B4", VA = "0x460D3B4")]
    public void PlayToIn(
      QuestPrepareAssetLoader.TimelinePattern timelinePattern,
      string assetBundleName,
      Action finishCallback)
    {
    }

    [Token(Token = "0x6013941")]
    [Address(RVA = "0x460D4E0", Offset = "0x460D4E0", VA = "0x460D4E0")]
    public void PlayToOut(
      QuestPrepareAssetLoader.TimelinePattern timelinePattern,
      string assetBundleName,
      QuestPrepareAnimation.BindData[] bindDatas,
      Action finishCallback)
    {
    }

    [Token(Token = "0x6013942")]
    [Address(RVA = "0x460D6C8", Offset = "0x460D6C8", VA = "0x460D6C8")]
    public void PlayToOut(
      QuestPrepareAssetLoader.TimelinePattern timelinePattern,
      string assetBundleName,
      Action finishCallback)
    {
    }

    [Token(Token = "0x6013943")]
    [Address(RVA = "0x460D7F4", Offset = "0x460D7F4", VA = "0x460D7F4")]
    public void PlayToGeneral(
      QuestPrepareAssetLoader.TimelinePattern timelinePattern,
      string assetBundleName,
      Action finishCallback)
    {
    }

    [Token(Token = "0x6013944")]
    [Address(RVA = "0x460D920", Offset = "0x460D920", VA = "0x460D920")]
    public void Release()
    {
    }

    [Token(Token = "0x6013945")]
    [Address(RVA = "0x460D970", Offset = "0x460D970", VA = "0x460D970")]
    public QuestPrepareAnimation()
    {
    }

    [Token(Token = "0x2003237")]
    public class BindData
    {
      [Token(Token = "0x1700412F")]
      public string RootTrackName
      {
        [Token(Token = "0x6013946"), Address(RVA = "0x460D9EC", Offset = "0x460D9EC", VA = "0x460D9EC")] get
        {
          return (string) null;
        }
        [Token(Token = "0x6013947"), Address(RVA = "0x460D9F4", Offset = "0x460D9F4", VA = "0x460D9F4")] set
        {
        }
      }

      [Token(Token = "0x17004130")]
      public string TrackName
      {
        [Token(Token = "0x6013948"), Address(RVA = "0x460D9FC", Offset = "0x460D9FC", VA = "0x460D9FC")] get
        {
          return (string) null;
        }
        [Token(Token = "0x6013949"), Address(RVA = "0x460DA04", Offset = "0x460DA04", VA = "0x460DA04")] set
        {
        }
      }

      [Token(Token = "0x17004131")]
      public GameObject BindObj
      {
        [Token(Token = "0x601394A"), Address(RVA = "0x460DA0C", Offset = "0x460DA0C", VA = "0x460DA0C")] get
        {
          return (GameObject) null;
        }
        [Token(Token = "0x601394B"), Address(RVA = "0x460DA14", Offset = "0x460DA14", VA = "0x460DA14")] set
        {
        }
      }

      [Token(Token = "0x601394C")]
      [Address(RVA = "0x460DA1C", Offset = "0x460DA1C", VA = "0x460DA1C")]
      public BindData()
      {
      }
    }
  }
}
