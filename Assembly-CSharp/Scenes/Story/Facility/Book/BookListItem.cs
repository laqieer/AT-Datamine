// Decompiled with JetBrains decompiler
// Type: Scenes.Story.Facility.Book.BookListItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UI;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.Story.Facility.Book
{
  [Token(Token = "0x2002EC3")]
  public class BookListItem : MonoBehaviour
  {
    [Token(Token = "0x400C894")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private TextAccessor title;
    [Token(Token = "0x400C895")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private TextAccessor progress;
    [Token(Token = "0x400C896")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Image iconNew;
    [Token(Token = "0x400C897")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Image iconRead;
    [Token(Token = "0x400C898")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Image iconUnRead;
    [Token(Token = "0x400C899")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private Image iconLocked;
    [Token(Token = "0x400C89A")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private Image bookmarkIcon;
    [Token(Token = "0x400C89B")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private TextAccessor bookmarkText;
    [Token(Token = "0x400C89C")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private GameObject[] onLockedDeactivateObjs;
    [Token(Token = "0x400C89D")]
    [FieldOffset(Offset = "0x60")]
    public Action OnClick;

    [Token(Token = "0x17003DFC")]
    public string Title
    {
      [Token(Token = "0x6012448"), Address(RVA = "0x22F22CC", Offset = "0x22F22CC", VA = "0x22F22CC")] set
      {
      }
    }

    [Token(Token = "0x6012449")]
    [Address(RVA = "0x22F22E8", Offset = "0x22F22E8", VA = "0x22F22E8")]
    public void SetProgress(int num, int max)
    {
    }

    [Token(Token = "0x601244A")]
    [Address(RVA = "0x22F23AC", Offset = "0x22F23AC", VA = "0x22F23AC")]
    public void OnClickItem()
    {
    }

    [Token(Token = "0x17003DFD")]
    public BookListItem.IState State
    {
      [Token(Token = "0x601244B"), Address(RVA = "0x22F23C8", Offset = "0x22F23C8", VA = "0x22F23C8")] set
      {
      }
    }

    [Token(Token = "0x17003DFE")]
    public bool NewBadge
    {
      [Token(Token = "0x601244C"), Address(RVA = "0x22F25B4", Offset = "0x22F25B4", VA = "0x22F25B4")] set
      {
      }
    }

    [Token(Token = "0x601244D")]
    [Address(RVA = "0x22F25E4", Offset = "0x22F25E4", VA = "0x22F25E4")]
    private void SetRentalStateAlpha(float strength)
    {
    }

    [Token(Token = "0x601244E")]
    [Address(RVA = "0x22F26E4", Offset = "0x22F26E4", VA = "0x22F26E4")]
    public BookListItem Duplicate() => (BookListItem) null;

    [Token(Token = "0x601244F")]
    [Address(RVA = "0x22F277C", Offset = "0x22F277C", VA = "0x22F277C")]
    public BookListItem()
    {
    }

    [Token(Token = "0x2002EC4")]
    public interface IState
    {
      [Token(Token = "0x6012450")]
      void Activate(BookListItem item);
    }

    [Token(Token = "0x2002EC5")]
    public class StateRead : BookListItem.IState
    {
      [Token(Token = "0x6012451")]
      [Address(RVA = "0x22F27D4", Offset = "0x22F27D4", VA = "0x22F27D4", Slot = "4")]
      private void Scenes\u002EStory\u002EFacility\u002EBook\u002EBookListItem\u002EIState\u002EActivate(
        BookListItem item)
      {
      }

      [Token(Token = "0x6012452")]
      [Address(RVA = "0x22F2814", Offset = "0x22F2814", VA = "0x22F2814")]
      public StateRead()
      {
      }
    }

    [Token(Token = "0x2002EC6")]
    public class StateUnRead : BookListItem.IState
    {
      [Token(Token = "0x6012453")]
      [Address(RVA = "0x22F281C", Offset = "0x22F281C", VA = "0x22F281C", Slot = "4")]
      private void Scenes\u002EStory\u002EFacility\u002EBook\u002EBookListItem\u002EIState\u002EActivate(
        BookListItem item)
      {
      }

      [Token(Token = "0x6012454")]
      [Address(RVA = "0x22F285C", Offset = "0x22F285C", VA = "0x22F285C")]
      public StateUnRead()
      {
      }
    }

    [Token(Token = "0x2002EC7")]
    public class StateLocked : BookListItem.IState
    {
      [Token(Token = "0x6012455")]
      [Address(RVA = "0x22F2864", Offset = "0x22F2864", VA = "0x22F2864", Slot = "4")]
      private void Scenes\u002EStory\u002EFacility\u002EBook\u002EBookListItem\u002EIState\u002EActivate(
        BookListItem item)
      {
      }

      [Token(Token = "0x6012456")]
      [Address(RVA = "0x22F28A4", Offset = "0x22F28A4", VA = "0x22F28A4")]
      public StateLocked()
      {
      }
    }
  }
}
