// Decompiled with JetBrains decompiler
// Type: Gacha.GachaListView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Home.Bannner;
using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

#nullable disable
namespace Gacha
{
  [Token(Token = "0x2001506")]
  internal class GachaListView : 
    MonoBehaviour,
    IBeginDragHandler,
    IEventSystemHandler,
    IDragHandler,
    IEndDragHandler
  {
    [Token(Token = "0x400608E")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    [Header("入力制御用")]
    private CanvasGroup canvasGroup;
    [Token(Token = "0x400608F")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private HorizontalGridInfiniteScrollView scrollView;
    [Token(Token = "0x4006090")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private HorizontalLayoutGroup scheduleLayout;
    [Token(Token = "0x4006091")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private ScrollRect scheduleScrollRect;
    [Token(Token = "0x4006092")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private GameObject selectCursor;
    [Token(Token = "0x4006093")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private float durationSnap;
    [Token(Token = "0x4006097")]
    [FieldOffset(Offset = "0x60")]
    private SwipeState swipeState;
    [Token(Token = "0x4006098")]
    [FieldOffset(Offset = "0x68")]
    private int currentBannerIndex;
    [Token(Token = "0x4006099")]
    [FieldOffset(Offset = "0x6C")]
    private int dragBeginIndex;
    [Token(Token = "0x400609A")]
    [FieldOffset(Offset = "0x70")]
    private List<InfiniteCellData> cellDatas;
    [Token(Token = "0x400609B")]
    [FieldOffset(Offset = "0x78")]
    private bool isScrollAnimationPlaying;
    [Token(Token = "0x400609C")]
    [FieldOffset(Offset = "0x79")]
    private bool disableDragging;

    [Token(Token = "0x140000FE")]
    public event Action<int, GachaListItemView> OnUpdateListItem
    {
      [Token(Token = "0x60076EC"), Address(RVA = "0x44EC030", Offset = "0x44EC030", VA = "0x44EC030")] add
      {
      }
      [Token(Token = "0x60076ED"), Address(RVA = "0x44ED568", Offset = "0x44ED568", VA = "0x44ED568")] remove
      {
      }
    }

    [Token(Token = "0x140000FF")]
    public event Action<int, GachaListItemView> OnClickListItem
    {
      [Token(Token = "0x60076EE"), Address(RVA = "0x44EC0E0", Offset = "0x44EC0E0", VA = "0x44EC0E0")] add
      {
      }
      [Token(Token = "0x60076EF"), Address(RVA = "0x44ED618", Offset = "0x44ED618", VA = "0x44ED618")] remove
      {
      }
    }

    [Token(Token = "0x14000100")]
    public event Action<int> OnSwiped
    {
      [Token(Token = "0x60076F0"), Address(RVA = "0x44EC190", Offset = "0x44EC190", VA = "0x44EC190")] add
      {
      }
      [Token(Token = "0x60076F1"), Address(RVA = "0x44ED6C8", Offset = "0x44ED6C8", VA = "0x44ED6C8")] remove
      {
      }
    }

    [Token(Token = "0x1700125D")]
    private Vector2 cellSize
    {
      [Token(Token = "0x60076F2"), Address(RVA = "0x44ED778", Offset = "0x44ED778", VA = "0x44ED778")] get
      {
        return new Vector2();
      }
    }

    [Token(Token = "0x60076F3")]
    [Address(RVA = "0x44ED7EC", Offset = "0x44ED7EC", VA = "0x44ED7EC")]
    private void Awake()
    {
    }

    [Token(Token = "0x60076F4")]
    [Address(RVA = "0x44EC6B4", Offset = "0x44EC6B4", VA = "0x44EC6B4")]
    public void Setup(int count)
    {
    }

    [Token(Token = "0x60076F5")]
    [Address(RVA = "0x44ECBD4", Offset = "0x44ECBD4", VA = "0x44ECBD4")]
    public void Refresh()
    {
    }

    [Token(Token = "0x60076F6")]
    [Address(RVA = "0x44ED914", Offset = "0x44ED914", VA = "0x44ED914")]
    private void InitializeScrollAreaPadding()
    {
    }

    [Token(Token = "0x60076F7")]
    [Address(RVA = "0x44EDA64", Offset = "0x44EDA64", VA = "0x44EDA64")]
    private void ResetScrollData(int count)
    {
    }

    [Token(Token = "0x60076F8")]
    [Address(RVA = "0x44EDC3C", Offset = "0x44EDC3C", VA = "0x44EDC3C")]
    private void OnUpdateListItemView(int index, GachaListItemView view)
    {
    }

    [Token(Token = "0x60076F9")]
    [Address(RVA = "0x44EDC58", Offset = "0x44EDC58", VA = "0x44EDC58")]
    private void OnClickListItemButton(int index, GachaListItemView view)
    {
    }

    [Token(Token = "0x60076FA")]
    [Address(RVA = "0x44ECB94", Offset = "0x44ECB94", VA = "0x44ECB94")]
    public void SetSelect(int index, bool snapImmediately)
    {
    }

    [Token(Token = "0x60076FB")]
    [Address(RVA = "0x44EDCF8", Offset = "0x44EDCF8", VA = "0x44EDCF8", Slot = "4")]
    private void UnityEngine\u002EEventSystems\u002EIBeginDragHandler\u002EOnBeginDrag(
      PointerEventData eventData)
    {
    }

    [Token(Token = "0x60076FC")]
    [Address(RVA = "0x44EDDC0", Offset = "0x44EDDC0", VA = "0x44EDDC0", Slot = "5")]
    private void UnityEngine\u002EEventSystems\u002EIDragHandler\u002EOnDrag(
      PointerEventData eventData)
    {
    }

    [Token(Token = "0x60076FD")]
    [Address(RVA = "0x44EDE08", Offset = "0x44EDE08", VA = "0x44EDE08", Slot = "6")]
    private void UnityEngine\u002EEventSystems\u002EIEndDragHandler\u002EOnEndDrag(
      PointerEventData eventData)
    {
    }

    [Token(Token = "0x60076FE")]
    [Address(RVA = "0x44EDDA0", Offset = "0x44EDDA0", VA = "0x44EDDA0")]
    private void SetCursorVisible(bool isVisible)
    {
    }

    [Token(Token = "0x60076FF")]
    [Address(RVA = "0x44EDC74", Offset = "0x44EDC74", VA = "0x44EDC74")]
    public IEnumerator SnapByIndex(int index, bool snapImmediately) => (IEnumerator) null;

    [Token(Token = "0x6007700")]
    [Address(RVA = "0x44EDE64", Offset = "0x44EDE64", VA = "0x44EDE64")]
    public IEnumerator SnapToNearest() => (IEnumerator) null;

    [Token(Token = "0x6007701")]
    [Address(RVA = "0x44EDD68", Offset = "0x44EDD68", VA = "0x44EDD68")]
    private void StopBannerAnimation()
    {
    }

    [Token(Token = "0x6007702")]
    [Address(RVA = "0x44EDDD0", Offset = "0x44EDDD0", VA = "0x44EDDD0")]
    private void UpdateCurrentIndex()
    {
    }

    [Token(Token = "0x6007703")]
    [Address(RVA = "0x44EDF1C", Offset = "0x44EDF1C", VA = "0x44EDF1C")]
    private void SetCurrentIndex(int index)
    {
    }

    [Token(Token = "0x6007704")]
    [Address(RVA = "0x44EDF24", Offset = "0x44EDF24", VA = "0x44EDF24")]
    public void SetEnableDragging(bool enable)
    {
    }

    [Token(Token = "0x6007705")]
    [Address(RVA = "0x44EDF34", Offset = "0x44EDF34", VA = "0x44EDF34")]
    public void SetInteractable(bool enable)
    {
    }

    [Token(Token = "0x6007706")]
    [Address(RVA = "0x44EDF74", Offset = "0x44EDF74", VA = "0x44EDF74")]
    public GachaListView()
    {
    }

    [Token(Token = "0x2001507")]
    private class ScrollingScope : IDisposable
    {
      [Token(Token = "0x400609D")]
      [FieldOffset(Offset = "0x10")]
      private GachaListView view;

      [Token(Token = "0x6007708")]
      [Address(RVA = "0x44EDFA4", Offset = "0x44EDFA4", VA = "0x44EDFA4")]
      public ScrollingScope(GachaListView view)
      {
      }

      [Token(Token = "0x6007709")]
      [Address(RVA = "0x44EDFDC", Offset = "0x44EDFDC", VA = "0x44EDFDC", Slot = "4")]
      public void Dispose()
      {
      }
    }
  }
}
