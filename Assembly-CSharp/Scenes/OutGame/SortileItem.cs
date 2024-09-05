// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.SortileItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame
{
  [Token(Token = "0x2003264")]
  public class SortileItem : MonoBehaviour
  {
    [Token(Token = "0x400D799")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private RectTransform rectTransform;
    [Token(Token = "0x400D79A")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private RectTransform parent;
    [Token(Token = "0x400D79B")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private SortieTextItem baseItem;
    [Token(Token = "0x400D79C")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private GameObject lineItem;
    [Token(Token = "0x400D79D")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Text titleText;
    [Token(Token = "0x400D79E")]
    [FieldOffset(Offset = "0x40")]
    private List<SortieTextItem> createdTextItem;
    [Token(Token = "0x400D79F")]
    [FieldOffset(Offset = "0x48")]
    private List<GameObject> createdLineItem;

    [Token(Token = "0x17004158")]
    public RectTransform RectTransform
    {
      [Token(Token = "0x6013A76"), Address(RVA = "0x4621C70", Offset = "0x4621C70", VA = "0x4621C70")] get
      {
        return (RectTransform) null;
      }
    }

    [Token(Token = "0x6013A77")]
    [Address(RVA = "0x4620C90", Offset = "0x4620C90", VA = "0x4620C90")]
    public void Delete()
    {
    }

    [Token(Token = "0x6013A78")]
    [Address(RVA = "0x46208B4", Offset = "0x46208B4", VA = "0x46208B4")]
    public void SetTitle(string title)
    {
    }

    [Token(Token = "0x6013A79")]
    [Address(RVA = "0x4620930", Offset = "0x4620930", VA = "0x4620930")]
    public void CreateItems(List<Tuple<bool, string>> itemList)
    {
    }

    [Token(Token = "0x6013A7A")]
    [Address(RVA = "0x4621C78", Offset = "0x4621C78", VA = "0x4621C78")]
    public SortileItem()
    {
    }
  }
}
