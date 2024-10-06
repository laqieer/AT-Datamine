// Decompiled with JetBrains decompiler
// Type: Scenes.Story.Facility.Book.BookTab
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.Story.Facility.Book
{
  [Token(Token = "0x2002EE3")]
  public class BookTab : MonoBehaviour
  {
    [Token(Token = "0x400C8F0")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Button active;
    [Token(Token = "0x400C8F1")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Button deactive;

    [Token(Token = "0x17003E26")]
    public BookTab.EventData<bool> IsOn
    {
      [Token(Token = "0x601250C"), Address(RVA = "0x22F6478", Offset = "0x22F6478", VA = "0x22F6478")] get
      {
        return (BookTab.EventData<bool>) null;
      }
      [Token(Token = "0x601250D"), Address(RVA = "0x22F6480", Offset = "0x22F6480", VA = "0x22F6480")] set
      {
      }
    }

    [Token(Token = "0x1400018A")]
    public event Action OnActive
    {
      [Token(Token = "0x601250E"), Address(RVA = "0x22F4BB8", Offset = "0x22F4BB8", VA = "0x22F4BB8")] add
      {
      }
      [Token(Token = "0x601250F"), Address(RVA = "0x22F6488", Offset = "0x22F6488", VA = "0x22F6488")] remove
      {
      }
    }

    [Token(Token = "0x6012510")]
    [Address(RVA = "0x22F6524", Offset = "0x22F6524", VA = "0x22F6524")]
    private void Start()
    {
    }

    [Token(Token = "0x6012511")]
    [Address(RVA = "0x22F4C5C", Offset = "0x22F4C5C", VA = "0x22F4C5C")]
    public void Activate(bool activate)
    {
    }

    [Token(Token = "0x6012512")]
    [Address(RVA = "0x22F6634", Offset = "0x22F6634", VA = "0x22F6634")]
    private void OnClickEvent()
    {
    }

    [Token(Token = "0x6012513")]
    [Address(RVA = "0x22F6688", Offset = "0x22F6688", VA = "0x22F6688")]
    public BookTab()
    {
    }

    [Token(Token = "0x2002EE4")]
    public class EventData<T>
    {
      [Token(Token = "0x400C8F4")]
      [FieldOffset(Offset = "0x0")]
      private T value;

      [Token(Token = "0x17003E27")]
      public T Value
      {
        [Token(Token = "0x6012515")] get => (T) null;
        [Token(Token = "0x6012516")] set
        {
        }
      }

      [Token(Token = "0x1400018B")]
      public event Action<T> OnChange
      {
        [Token(Token = "0x6012517")] add
        {
        }
        [Token(Token = "0x6012518")] remove
        {
        }
      }

      [Token(Token = "0x6012519")]
      public EventData()
      {
      }

      [Token(Token = "0x601251A")]
      public EventData(T value)
      {
      }
    }
  }
}
