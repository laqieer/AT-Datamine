// Decompiled with JetBrains decompiler
// Type: Scenes.Story.Facility.Book.BookList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;
using UI.Direction;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.Story.Facility.Book
{
  [Token(Token = "0x2002EC1")]
  public class BookList : MonoBehaviour
  {
    [Token(Token = "0x400C884")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private BookListItem listItem;
    [Token(Token = "0x400C885")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private UITimelineController timelineController;
    [Token(Token = "0x400C886")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Button firstBtn;
    [Token(Token = "0x400C887")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Button prevBtn;
    [Token(Token = "0x400C888")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Button nextBtn;
    [Token(Token = "0x400C889")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private Button endBtn;
    [Token(Token = "0x400C88A")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private BookListPageJump[] pageJumbs;
    [Token(Token = "0x400C88B")]
    [FieldOffset(Offset = "0x50")]
    [Header("ページ送りアニメーション中にデータを更新するためのディレイ(s)")]
    [SerializeField]
    private float valueChangeDelay;

    [Token(Token = "0x17003DF8")]
    public BookListPageJump[] PageJumbs
    {
      [Token(Token = "0x6012428"), Address(RVA = "0x459C4BC", Offset = "0x459C4BC", VA = "0x459C4BC")] get
      {
        return (BookListPageJump[]) null;
      }
    }

    [Token(Token = "0x17003DF9")]
    public float ValueChangeDelay
    {
      [Token(Token = "0x6012429"), Address(RVA = "0x459C4C4", Offset = "0x459C4C4", VA = "0x459C4C4")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x601242A")]
    [Address(RVA = "0x459C4CC", Offset = "0x459C4CC", VA = "0x459C4CC")]
    private void Start()
    {
    }

    [Token(Token = "0x601242B")]
    [Address(RVA = "0x459C664", Offset = "0x459C664", VA = "0x459C664")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x601242C")]
    [Address(RVA = "0x459C7FC", Offset = "0x459C7FC", VA = "0x459C7FC")]
    public void Arrow(bool first, bool prev, bool next, bool end)
    {
    }

    [Token(Token = "0x601242D")]
    [Address(RVA = "0x459C8AC", Offset = "0x459C8AC", VA = "0x459C8AC")]
    public BookListItem DuplicateItem() => (BookListItem) null;

    [Token(Token = "0x601242E")]
    [Address(RVA = "0x459C8C8", Offset = "0x459C8C8", VA = "0x459C8C8")]
    public IEnumerator Initialize() => (IEnumerator) null;

    [Token(Token = "0x601242F")]
    [Address(RVA = "0x459C958", Offset = "0x459C958", VA = "0x459C958")]
    public void In()
    {
    }

    [Token(Token = "0x6012430")]
    [Address(RVA = "0x459C97C", Offset = "0x459C97C", VA = "0x459C97C")]
    public void Out()
    {
    }

    [Token(Token = "0x6012431")]
    [Address(RVA = "0x459C9A0", Offset = "0x459C9A0", VA = "0x459C9A0")]
    public void Change()
    {
    }

    [Token(Token = "0x14000180")]
    public event Action OnFirst
    {
      [Token(Token = "0x6012432"), Address(RVA = "0x459C9C4", Offset = "0x459C9C4", VA = "0x459C9C4")] add
      {
      }
      [Token(Token = "0x6012433"), Address(RVA = "0x459CA60", Offset = "0x459CA60", VA = "0x459CA60")] remove
      {
      }
    }

    [Token(Token = "0x14000181")]
    public event Action OnPrev
    {
      [Token(Token = "0x6012434"), Address(RVA = "0x459CAFC", Offset = "0x459CAFC", VA = "0x459CAFC")] add
      {
      }
      [Token(Token = "0x6012435"), Address(RVA = "0x459CB98", Offset = "0x459CB98", VA = "0x459CB98")] remove
      {
      }
    }

    [Token(Token = "0x14000182")]
    public event Action OnNext
    {
      [Token(Token = "0x6012436"), Address(RVA = "0x459CC34", Offset = "0x459CC34", VA = "0x459CC34")] add
      {
      }
      [Token(Token = "0x6012437"), Address(RVA = "0x459CCD0", Offset = "0x459CCD0", VA = "0x459CCD0")] remove
      {
      }
    }

    [Token(Token = "0x14000183")]
    public event Action OnEnd
    {
      [Token(Token = "0x6012438"), Address(RVA = "0x459CD6C", Offset = "0x459CD6C", VA = "0x459CD6C")] add
      {
      }
      [Token(Token = "0x6012439"), Address(RVA = "0x459CE08", Offset = "0x459CE08", VA = "0x459CE08")] remove
      {
      }
    }

    [Token(Token = "0x14000184")]
    public event Action OnClose
    {
      [Token(Token = "0x601243A"), Address(RVA = "0x459CEA4", Offset = "0x459CEA4", VA = "0x459CEA4")] add
      {
      }
      [Token(Token = "0x601243B"), Address(RVA = "0x459CF40", Offset = "0x459CF40", VA = "0x459CF40")] remove
      {
      }
    }

    [Token(Token = "0x601243C")]
    [Address(RVA = "0x459CFDC", Offset = "0x459CFDC", VA = "0x459CFDC")]
    private void OnFirstEvent()
    {
    }

    [Token(Token = "0x601243D")]
    [Address(RVA = "0x459CFF8", Offset = "0x459CFF8", VA = "0x459CFF8")]
    private void OnPrevEvent()
    {
    }

    [Token(Token = "0x601243E")]
    [Address(RVA = "0x459D014", Offset = "0x459D014", VA = "0x459D014")]
    private void OnNextEvent()
    {
    }

    [Token(Token = "0x601243F")]
    [Address(RVA = "0x459D030", Offset = "0x459D030", VA = "0x459D030")]
    private void OnEndEvent()
    {
    }

    [Token(Token = "0x6012440")]
    [Address(RVA = "0x459D04C", Offset = "0x459D04C", VA = "0x459D04C")]
    public void OnCloseEvent()
    {
    }

    [Token(Token = "0x6012441")]
    [Address(RVA = "0x459D068", Offset = "0x459D068", VA = "0x459D068")]
    public BookList()
    {
    }
  }
}
