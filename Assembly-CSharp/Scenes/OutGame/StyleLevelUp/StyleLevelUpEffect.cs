// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.StyleLevelUp.StyleLevelUpEffect
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.Input;
using GameCore.Tween;
using Il2CppDummyDll;
using Network.Param;
using StaqData;
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UI.Direction;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.StyleLevelUp
{
  [Token(Token = "0x200337F")]
  public class StyleLevelUpEffect : MonoBehaviour
  {
    [Token(Token = "0x400DF3D")]
    private const string AssetbundleName = "ui_page_ingame_lvup";
    [Token(Token = "0x400DF3E")]
    private const string AssetName = "Container_Battle_StyleLVUP";
    [Token(Token = "0x400DF3F")]
    private const string PlayVoiceStr = "VO_{0}_unit_{1}";
    [Token(Token = "0x400DF40")]
    private const string BestVoice = "0002";
    [Token(Token = "0x400DF41")]
    private const string GoodVoice = "0003";
    [Token(Token = "0x400DF42")]
    private const string BadVoice = "0004";
    [Token(Token = "0x400DF43")]
    private const string LvMaxVoice = "0005";
    [Token(Token = "0x400DF44")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Image styleImage;
    [Token(Token = "0x400DF45")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private TextMeshProUGUI styleName;
    [Token(Token = "0x400DF46")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private TextMeshProUGUI charaName;
    [Token(Token = "0x400DF47")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private UITimelineController timelineController;
    [Token(Token = "0x400DF48")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private UITweenGroup uITweenGroup;
    [Token(Token = "0x400DF49")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private CanvasGroup canvasGroup;
    [Token(Token = "0x400DF4A")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private CommonButton button;
    [Token(Token = "0x400DF4B")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private StyleLevelObject fromStyleLevelObject;
    [Token(Token = "0x400DF4C")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private StyleLevelObject toStyleLevelObject;
    [Token(Token = "0x400DF4D")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private PlayableDirector playable;
    [Token(Token = "0x400DF4E")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private StyleLevelUpParaList[] styleLevelUpParaList;
    [Token(Token = "0x400DF4F")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private BackKeyHandlerComponent backKeyHandlerComponent;
    [Token(Token = "0x400DF50")]
    [FieldOffset(Offset = "0x78")]
    private bool isLevelMax;
    [Token(Token = "0x400DF51")]
    [FieldOffset(Offset = "0x79")]
    private bool isClosed;
    [Token(Token = "0x400DF52")]
    [FieldOffset(Offset = "0x7A")]
    private bool IsValidBack;
    [Token(Token = "0x400DF53")]
    [FieldOffset(Offset = "0x80")]
    private Action CloseCallBack;
    [Token(Token = "0x400DF54")]
    [FieldOffset(Offset = "0x88")]
    private Action playVoice;

    [Token(Token = "0x60143C1")]
    [Address(RVA = "0x1E1C5CC", Offset = "0x1E1C5CC", VA = "0x1E1C5CC")]
    public static void SpawnAsync(
      AssetCachedSpawner assetCachedSpawner,
      int styleId,
      Action<GameObject> onFinish,
      Action<Sprite> onFinish2)
    {
    }

    [Token(Token = "0x60143C2")]
    [Address(RVA = "0x1E1C784", Offset = "0x1E1C784", VA = "0x1E1C784")]
    public void SetImage(Sprite sprite)
    {
    }

    [Token(Token = "0x60143C3")]
    [Address(RVA = "0x1E1C7A0", Offset = "0x1E1C7A0", VA = "0x1E1C7A0")]
    public IEnumerator InitializeAsync(
      AssetCachedSpawner assetCachedSpawner,
      Style style,
      IBasicParameter toParam,
      int fromLevel,
      int toLevel,
      Action endCallBack)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x60143C4")]
    [Address(RVA = "0x1E1C868", Offset = "0x1E1C868", VA = "0x1E1C868")]
    public IEnumerator InitializeAsyncAfterReincarnation(
      Style style,
      PlayerUnitType toParam,
      Action endCallBack)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x60143C5")]
    [Address(RVA = "0x1E1C8F0", Offset = "0x1E1C8F0", VA = "0x1E1C8F0")]
    private IEnumerator PlayEffect() => (IEnumerator) null;

    [Token(Token = "0x60143C6")]
    [Address(RVA = "0x1E1C958", Offset = "0x1E1C958", VA = "0x1E1C958")]
    public void ForceClose(Action closeAction)
    {
    }

    [Token(Token = "0x60143C7")]
    [Address(RVA = "0x1E1CA2C", Offset = "0x1E1CA2C", VA = "0x1E1CA2C")]
    private void Close()
    {
    }

    [Token(Token = "0x60143C8")]
    [Address(RVA = "0x1E1CAD8", Offset = "0x1E1CAD8", VA = "0x1E1CAD8")]
    public void Back()
    {
    }

    [Token(Token = "0x60143C9")]
    [Address(RVA = "0x1E1CAE8", Offset = "0x1E1CAE8", VA = "0x1E1CAE8")]
    private void LevelUpEffect()
    {
    }

    [Token(Token = "0x60143CA")]
    [Address(RVA = "0x1E1CB14", Offset = "0x1E1CB14", VA = "0x1E1CB14")]
    private int GetParameter(BasicParameterType parameterType, IBasicParameter parameter)
    {
      return new int();
    }

    [Token(Token = "0x60143CB")]
    [Address(RVA = "0x1E1CDE8", Offset = "0x1E1CDE8", VA = "0x1E1CDE8")]
    private int GetLimitParameter(BasicParameterType parameterType, Style parameter) => new int();

    [Token(Token = "0x60143CC")]
    [Address(RVA = "0x1E1CEC0", Offset = "0x1E1CEC0", VA = "0x1E1CEC0")]
    private float GetGrowParameter(BasicParameterType parameterType, Style parameter)
    {
      return new float();
    }

    [Token(Token = "0x60143CD")]
    [Address(RVA = "0x1E1CF98", Offset = "0x1E1CF98", VA = "0x1E1CF98")]
    private void SetParaListData(
      Style fromStyle,
      IBasicParameter levelupParam,
      int fromLevel,
      int toLevel,
      bool isReinarnation = false)
    {
    }

    [Token(Token = "0x60143CE")]
    [Address(RVA = "0x1E1D574", Offset = "0x1E1D574", VA = "0x1E1D574")]
    private TrackAsset GetAverageTrack(HashSet<TrackAsset> styleLvUpIn, BasicParameterType type)
    {
      return (TrackAsset) null;
    }

    [Token(Token = "0x60143CF")]
    [Address(RVA = "0x1E1D77C", Offset = "0x1E1D77C", VA = "0x1E1D77C")]
    private void PlayVoice(string voicePackid, string voiceId)
    {
    }

    [Token(Token = "0x60143D0")]
    [Address(RVA = "0x1E1D844", Offset = "0x1E1D844", VA = "0x1E1D844")]
    public StyleLevelUpEffect()
    {
    }
  }
}
