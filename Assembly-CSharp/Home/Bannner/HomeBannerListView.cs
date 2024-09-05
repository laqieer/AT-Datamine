// Decompiled with JetBrains decompiler
// Type: Home.Bannner.HomeBannerListView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

#nullable disable
namespace Home.Bannner
{
  [Token(Token = "0x2000B84")]
  public class HomeBannerListView : 
    MonoBehaviour,
    LoopScrollPrefabSource,
    LoopScrollDataSource,
    IBeginDragHandler,
    IEventSystemHandler,
    IEndDragHandler
  {
    [Token(Token = "0x4003470")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private HomeBannerListItemView templateBannerView;
    [Token(Token = "0x4003471")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private HomeBannerDotView templateBannerDot;
    [Token(Token = "0x4003472")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private LoopHorizontalScrollRect loopHorizontalScrollRect;
    [Token(Token = "0x4003473")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private HomeBannerListView.BannerScrollSetting bannerScrollSetting;
    [Token(Token = "0x4003474")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private float swipeDistanceThreshold;
    [Token(Token = "0x4003475")]
    [FieldOffset(Offset = "0x40")]
    private List<HomeBannerDotView> homeBannerDotViews;
    [Token(Token = "0x4003477")]
    [FieldOffset(Offset = "0x50")]
    private int bannerCount;
    [Token(Token = "0x4003478")]
    [FieldOffset(Offset = "0x54")]
    private int currentBannerIndex;
    [Token(Token = "0x4003479")]
    [FieldOffset(Offset = "0x58")]
    private int dragBeginIndex;
    [Token(Token = "0x400347A")]
    [FieldOffset(Offset = "0x60")]
    private ObjectPool objectPool;
    [Token(Token = "0x400347B")]
    [FieldOffset(Offset = "0x68")]
    private SwipeState swipeState;
    [Token(Token = "0x400347C")]
    [FieldOffset(Offset = "0x70")]
    private bool isScrollAnimationPlaying;

    [Token(Token = "0x140000F1")]
    public event Action<int, HomeBannerListItemView> OnUpdateListItemView
    {
      [Token(Token = "0x600418D"), Address(RVA = "0x2A2FC4C", Offset = "0x2A2FC4C", VA = "0x2A2FC4C")] add
      {
      }
      [Token(Token = "0x600418E"), Address(RVA = "0x2A2FF30", Offset = "0x2A2FF30", VA = "0x2A2FF30")] remove
      {
      }
    }

    [Token(Token = "0x600418F")]
    [Address(RVA = "0x2A2F5FC", Offset = "0x2A2F5FC", VA = "0x2A2F5FC")]
    public void Setup(int bannerCount)
    {
    }

    [Token(Token = "0x6004190")]
    [Address(RVA = "0x2A305A0", Offset = "0x2A305A0", VA = "0x2A305A0")]
    private void InitializeBannerListItemViewData()
    {
    }

    [Token(Token = "0x6004191")]
    [Address(RVA = "0x2A306DC", Offset = "0x2A306DC", VA = "0x2A306DC")]
    private void InitializeDotList()
    {
    }

    [Token(Token = "0x6004192")]
    [Address(RVA = "0x2A307E0", Offset = "0x2A307E0", VA = "0x2A307E0")]
    private void InitializeSwipeState()
    {
    }

    [Token(Token = "0x6004193")]
    [Address(RVA = "0x2A30B14", Offset = "0x2A30B14", VA = "0x2A30B14")]
    private HomeBannerDotView CreateBannerDotView(bool isSelected) => (HomeBannerDotView) null;

    [Token(Token = "0x6004194")]
    [Address(RVA = "0x2A2FAC4", Offset = "0x2A2FAC4", VA = "0x2A2FAC4")]
    public void Refresh()
    {
    }

    [Token(Token = "0x6004195")]
    [Address(RVA = "0x2A3095C", Offset = "0x2A3095C", VA = "0x2A3095C")]
    private void ClearDot()
    {
    }

    [Token(Token = "0x6004196")]
    [Address(RVA = "0x2A2EA68", Offset = "0x2A2EA68", VA = "0x2A2EA68")]
    public void StartBannerAnimation()
    {
    }

    [Token(Token = "0x6004197")]
    [Address(RVA = "0x2A30C5C", Offset = "0x2A30C5C", VA = "0x2A30C5C")]
    private IEnumerator StartBannerAnimationAsync() => (IEnumerator) null;

    [Token(Token = "0x6004198")]
    [Address(RVA = "0x2A30CEC", Offset = "0x2A30CEC", VA = "0x2A30CEC")]
    private int GetFirstItemIndex() => new int();

    [Token(Token = "0x6004199")]
    [Address(RVA = "0x2A30D44", Offset = "0x2A30D44", VA = "0x2A30D44")]
    private IEnumerator BannerAnimationAsync() => (IEnumerator) null;

    [Token(Token = "0x600419A")]
    [Address(RVA = "0x2A30DD4", Offset = "0x2A30DD4", VA = "0x2A30DD4")]
    public IEnumerator StartBannerAnimationAfterSnap() => (IEnumerator) null;

    [Token(Token = "0x600419B")]
    [Address(RVA = "0x2A30C1C", Offset = "0x2A30C1C", VA = "0x2A30C1C")]
    private void StopBannerAnimation()
    {
    }

    [Token(Token = "0x600419C")]
    [Address(RVA = "0x2A30E64", Offset = "0x2A30E64", VA = "0x2A30E64")]
    private void SetDotHighlight(int index)
    {
    }

    [Token(Token = "0x600419D")]
    [Address(RVA = "0x2A30F34", Offset = "0x2A30F34", VA = "0x2A30F34")]
    private void UpdateCurrentIndex()
    {
    }

    [Token(Token = "0x600419E")]
    [Address(RVA = "0x2A30F94", Offset = "0x2A30F94", VA = "0x2A30F94")]
    private void SetCurrentIndex(int index)
    {
    }

    [Token(Token = "0x600419F")]
    [Address(RVA = "0x2A30FF4", Offset = "0x2A30FF4", VA = "0x2A30FF4")]
    private void OnScrollChanged(Vector2 nomalizedPosition)
    {
    }

    [Token(Token = "0x60041A0")]
    [Address(RVA = "0x2A31004", Offset = "0x2A31004", VA = "0x2A31004", Slot = "7")]
    public void OnBeginDrag(PointerEventData eventData)
    {
    }

    [Token(Token = "0x60041A1")]
    [Address(RVA = "0x2A3103C", Offset = "0x2A3103C", VA = "0x2A3103C", Slot = "8")]
    public void OnEndDrag(PointerEventData eventData)
    {
    }

    [Token(Token = "0x60041A2")]
    [Address(RVA = "0x2A310E0", Offset = "0x2A310E0", VA = "0x2A310E0", Slot = "4")]
    private GameObject UnityEngine\u002EUI\u002ELoopScrollPrefabSource\u002EGetObject(int index)
    {
      return (GameObject) null;
    }

    [Token(Token = "0x60041A3")]
    [Address(RVA = "0x2A31250", Offset = "0x2A31250", VA = "0x2A31250", Slot = "5")]
    private void UnityEngine\u002EUI\u002ELoopScrollPrefabSource\u002EReturnObject(Transform trans)
    {
    }

    [Token(Token = "0x60041A4")]
    [Address(RVA = "0x2A312E4", Offset = "0x2A312E4", VA = "0x2A312E4", Slot = "6")]
    private void UnityEngine\u002EUI\u002ELoopScrollDataSource\u002EProvideData(
      Transform transform,
      int idx)
    {
    }

    [Token(Token = "0x60041A5")]
    [Address(RVA = "0x2A313BC", Offset = "0x2A313BC", VA = "0x2A313BC")]
    public HomeBannerListView()
    {
    }

    [Token(Token = "0x2000B85")]
    [Serializable]
    private class BannerScrollSetting
    {
      [Token(Token = "0x400347D")]
      [FieldOffset(Offset = "0x10")]
      [Tooltip("スクロール処理が開始するまでの待ち時間")]
      public float StartWaitTime;
      [Token(Token = "0x400347E")]
      [FieldOffset(Offset = "0x14")]
      [Tooltip("スクロールにかかる時間")]
      public float ScrollDuration;
      [Token(Token = "0x400347F")]
      [FieldOffset(Offset = "0x18")]
      [Tooltip("スクロール間の待ち時間")]
      public float ScrollWaitTimeSpan;

      [Token(Token = "0x60041A6")]
      [Address(RVA = "0x2A31440", Offset = "0x2A31440", VA = "0x2A31440")]
      public BannerScrollSetting()
      {
      }
    }

    [Token(Token = "0x2000B86")]
    private class ScrollingScope : IDisposable
    {
      [Token(Token = "0x4003480")]
      [FieldOffset(Offset = "0x10")]
      private HomeBannerListView view;

      [Token(Token = "0x60041A7")]
      [Address(RVA = "0x2A3145C", Offset = "0x2A3145C", VA = "0x2A3145C")]
      public ScrollingScope(HomeBannerListView view)
      {
      }

      [Token(Token = "0x60041A8")]
      [Address(RVA = "0x2A31494", Offset = "0x2A31494", VA = "0x2A31494", Slot = "4")]
      public void Dispose()
      {
      }
    }
  }
}
