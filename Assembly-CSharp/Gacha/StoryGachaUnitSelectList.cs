// Decompiled with JetBrains decompiler
// Type: Gacha.StoryGachaUnitSelectList
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

#nullable disable
namespace Gacha
{
  [Token(Token = "0x2001592")]
  internal class StoryGachaUnitSelectList : 
    MonoBehaviour,
    IBeginDragHandler,
    IEventSystemHandler,
    IDragHandler,
    IEndDragHandler
  {
    [Token(Token = "0x40062F0")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private HorizontalGridInfiniteScrollView scrollView;
    [Token(Token = "0x40062F1")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private float durationSnap;
    [Token(Token = "0x40062F5")]
    [FieldOffset(Offset = "0x40")]
    private SwipeState swipeState;
    [Token(Token = "0x40062F6")]
    [FieldOffset(Offset = "0x48")]
    private int currentBannerIndex;
    [Token(Token = "0x40062F7")]
    [FieldOffset(Offset = "0x4C")]
    private int dragBeginIndex;
    [Token(Token = "0x40062F8")]
    [FieldOffset(Offset = "0x50")]
    private List<InfiniteCellData> cellDatas;
    [Token(Token = "0x40062F9")]
    [FieldOffset(Offset = "0x58")]
    private Dictionary<int, InfiniteCellBase> cells;
    [Token(Token = "0x40062FA")]
    [FieldOffset(Offset = "0x60")]
    private bool isScrollAnimationPlaying;
    [Token(Token = "0x40062FB")]
    [FieldOffset(Offset = "0x61")]
    private bool disableDragging;

    [Token(Token = "0x14000102")]
    public event Action<int, InfiniteCellBase> OnUpdateListItem
    {
      [Token(Token = "0x6007A36"), Address(RVA = "0x2299DFC", Offset = "0x2299DFC", VA = "0x2299DFC")] add
      {
      }
      [Token(Token = "0x6007A37"), Address(RVA = "0x229B43C", Offset = "0x229B43C", VA = "0x229B43C")] remove
      {
      }
    }

    [Token(Token = "0x14000103")]
    public event Action<int, InfiniteCellBase> OnClickListItem
    {
      [Token(Token = "0x6007A38"), Address(RVA = "0x229B4EC", Offset = "0x229B4EC", VA = "0x229B4EC")] add
      {
      }
      [Token(Token = "0x6007A39"), Address(RVA = "0x229B59C", Offset = "0x229B59C", VA = "0x229B59C")] remove
      {
      }
    }

    [Token(Token = "0x14000104")]
    public event Action<int> OnSwiped
    {
      [Token(Token = "0x6007A3A"), Address(RVA = "0x2299EAC", Offset = "0x2299EAC", VA = "0x2299EAC")] add
      {
      }
      [Token(Token = "0x6007A3B"), Address(RVA = "0x229B64C", Offset = "0x229B64C", VA = "0x229B64C")] remove
      {
      }
    }

    [Token(Token = "0x170012C1")]
    public InfiniteCellBase cellPrefab
    {
      [Token(Token = "0x6007A3C"), Address(RVA = "0x229B6FC", Offset = "0x229B6FC", VA = "0x229B6FC")] get
      {
        return (InfiniteCellBase) null;
      }
      [Token(Token = "0x6007A3D"), Address(RVA = "0x2299DE0", Offset = "0x2299DE0", VA = "0x2299DE0")] set
      {
      }
    }

    [Token(Token = "0x170012C2")]
    private Vector2 cellSize
    {
      [Token(Token = "0x6007A3E"), Address(RVA = "0x229B718", Offset = "0x229B718", VA = "0x229B718")] get
      {
        return new Vector2();
      }
    }

    [Token(Token = "0x6007A3F")]
    [Address(RVA = "0x229B78C", Offset = "0x229B78C", VA = "0x229B78C")]
    private void Awake()
    {
    }

    [Token(Token = "0x6007A40")]
    [Address(RVA = "0x22979C0", Offset = "0x22979C0", VA = "0x22979C0")]
    public void Setup(int count)
    {
    }

    [Token(Token = "0x6007A41")]
    [Address(RVA = "0x229BBC8", Offset = "0x229BBC8", VA = "0x229BBC8")]
    public void Refresh()
    {
    }

    [Token(Token = "0x6007A42")]
    [Address(RVA = "0x229B878", Offset = "0x229B878", VA = "0x229B878")]
    private void InitializeScrollAreaPadding()
    {
    }

    [Token(Token = "0x6007A43")]
    [Address(RVA = "0x229B9CC", Offset = "0x229B9CC", VA = "0x229B9CC")]
    private void ResetScrollData(int count)
    {
    }

    [Token(Token = "0x6007A44")]
    [Address(RVA = "0x229BC30", Offset = "0x229BC30", VA = "0x229BC30")]
    private void OnUpdateListItemView(int index, InfiniteCellBase view)
    {
    }

    [Token(Token = "0x6007A45")]
    [Address(RVA = "0x229BD70", Offset = "0x229BD70", VA = "0x229BD70")]
    private void OnClickListItemButton(int index, InfiniteCellBase view)
    {
    }

    [Token(Token = "0x6007A46")]
    [Address(RVA = "0x229A02C", Offset = "0x229A02C", VA = "0x229A02C")]
    public void SetSelect(int index, bool snapImmediately)
    {
    }

    [Token(Token = "0x6007A47")]
    [Address(RVA = "0x229BD8C", Offset = "0x229BD8C", VA = "0x229BD8C", Slot = "4")]
    private void UnityEngine\u002EEventSystems\u002EIBeginDragHandler\u002EOnBeginDrag(
      PointerEventData eventData)
    {
    }

    [Token(Token = "0x6007A48")]
    [Address(RVA = "0x229BE20", Offset = "0x229BE20", VA = "0x229BE20", Slot = "5")]
    private void UnityEngine\u002EEventSystems\u002EIDragHandler\u002EOnDrag(
      PointerEventData eventData)
    {
    }

    [Token(Token = "0x6007A49")]
    [Address(RVA = "0x229BE68", Offset = "0x229BE68", VA = "0x229BE68", Slot = "6")]
    private void UnityEngine\u002EEventSystems\u002EIEndDragHandler\u002EOnEndDrag(
      PointerEventData eventData)
    {
    }

    [Token(Token = "0x6007A4A")]
    [Address(RVA = "0x229A344", Offset = "0x229A344", VA = "0x229A344")]
    public IEnumerator SnapByIndex(int index, bool snapImmediately) => (IEnumerator) null;

    [Token(Token = "0x6007A4B")]
    [Address(RVA = "0x229BEC4", Offset = "0x229BEC4", VA = "0x229BEC4")]
    public IEnumerator SnapToNearest() => (IEnumerator) null;

    [Token(Token = "0x6007A4C")]
    [Address(RVA = "0x229BDE8", Offset = "0x229BDE8", VA = "0x229BDE8")]
    private void StopBannerAnimation()
    {
    }

    [Token(Token = "0x6007A4D")]
    [Address(RVA = "0x229BE30", Offset = "0x229BE30", VA = "0x229BE30")]
    private void UpdateCurrentIndex()
    {
    }

    [Token(Token = "0x6007A4E")]
    [Address(RVA = "0x229BF7C", Offset = "0x229BF7C", VA = "0x229BF7C")]
    private void SetCurrentIndex(int index)
    {
    }

    [Token(Token = "0x6007A4F")]
    [Address(RVA = "0x229BF84", Offset = "0x229BF84", VA = "0x229BF84")]
    public void SetEnableDragging(bool enable)
    {
    }

    [Token(Token = "0x6007A50")]
    [Address(RVA = "0x2296D18", Offset = "0x2296D18", VA = "0x2296D18")]
    public InfiniteCellBase GetCellByIndex(int index) => (InfiniteCellBase) null;

    [Token(Token = "0x6007A51")]
    [Address(RVA = "0x229BFD4", Offset = "0x229BFD4", VA = "0x229BFD4")]
    public StoryGachaUnitSelectList()
    {
    }

    [Token(Token = "0x2001593")]
    private class ScrollingScope : IDisposable
    {
      [Token(Token = "0x40062FC")]
      [FieldOffset(Offset = "0x10")]
      private StoryGachaUnitSelectList view;

      [Token(Token = "0x6007A52")]
      [Address(RVA = "0x229BFE8", Offset = "0x229BFE8", VA = "0x229BFE8")]
      public ScrollingScope(StoryGachaUnitSelectList view)
      {
      }

      [Token(Token = "0x6007A53")]
      [Address(RVA = "0x229C020", Offset = "0x229C020", VA = "0x229C020", Slot = "4")]
      public void Dispose()
      {
      }
    }
  }
}
