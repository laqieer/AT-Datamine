// Decompiled with JetBrains decompiler
// Type: GameCore.TimelineTransitionPanelController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.DLC;
using GameCore.Scene;
using Il2CppDummyDll;
using System.Collections;
using System.Collections.Generic;
using UI.Direction;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace GameCore
{
  [Token(Token = "0x2000BB1")]
  public class TimelineTransitionPanelController : LoadingPanelController
  {
    [Token(Token = "0x400355B")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private UITimelineController _controller;
    [Token(Token = "0x400355C")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Image trasitionImage;
    [Token(Token = "0x400355D")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private string assetBundleMaterialLabel;
    [Token(Token = "0x400355E")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private string materialAssetName;
    [Token(Token = "0x400355F")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private string assetBundleTimelineLabel;
    [Token(Token = "0x4003560")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private string settingAssetName;
    [Token(Token = "0x4003561")]
    [FieldOffset(Offset = "0x58")]
    private bool forceStartReqest;
    [Token(Token = "0x4003562")]
    [FieldOffset(Offset = "0x60")]
    private Dictionary<TimelineTransitionPanelController.AnimationType, TimelineTransitionPanelController.Timeline> timelineSettings;
    [Token(Token = "0x4003563")]
    [FieldOffset(Offset = "0x68")]
    private TimelineTransitionPanelController.AnimationType animationType;

    [Token(Token = "0x60042D1")]
    [Address(RVA = "0x363CB00", Offset = "0x363CB00", VA = "0x363CB00")]
    public void SetAnimationType(
      TimelineTransitionPanelController.AnimationType animationType)
    {
    }

    [Token(Token = "0x60042D2")]
    [Address(RVA = "0x363CB08", Offset = "0x363CB08", VA = "0x363CB08")]
    private void ResetAnimationTypeToDefault()
    {
    }

    [Token(Token = "0x60042D3")]
    [Address(RVA = "0x363CB14", Offset = "0x363CB14", VA = "0x363CB14", Slot = "5")]
    public override IEnumerator SetAssetData(AssetBundleManager manager) => (IEnumerator) null;

    [Token(Token = "0x60042D4")]
    [Address(RVA = "0x363CBB0", Offset = "0x363CBB0", VA = "0x363CBB0", Slot = "7")]
    protected override IEnumerator Show() => (IEnumerator) null;

    [Token(Token = "0x60042D5")]
    [Address(RVA = "0x363CC40", Offset = "0x363CC40", VA = "0x363CC40", Slot = "9")]
    protected override IEnumerator Hide() => (IEnumerator) null;

    [Token(Token = "0x60042D6")]
    [Address(RVA = "0x363CCD0", Offset = "0x363CCD0", VA = "0x363CCD0", Slot = "6")]
    public override void OnChangeOtherFade()
    {
    }

    [Token(Token = "0x60042D7")]
    [Address(RVA = "0x363CCF8", Offset = "0x363CCF8", VA = "0x363CCF8")]
    public TimelineTransitionPanelController()
    {
    }

    [Token(Token = "0x2000BB2")]
    public enum AnimationType
    {
      [Token(Token = "0x4003565")] Fast,
      [Token(Token = "0x4003566")] Normal,
    }

    [Token(Token = "0x2000BB3")]
    private struct Timeline
    {
      [Token(Token = "0x4003567")]
      [FieldOffset(Offset = "0x0")]
      public string InAnimationName;
      [Token(Token = "0x4003568")]
      [FieldOffset(Offset = "0x8")]
      public string OutAnimationName;

      [Token(Token = "0x60042DD")]
      [Address(RVA = "0x363CE90", Offset = "0x363CE90", VA = "0x363CE90")]
      public Timeline(string inAnimationName, string outAnimationName)
      {
      }
    }
  }
}
