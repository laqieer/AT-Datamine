// Decompiled with JetBrains decompiler
// Type: UI.Scroll.InfiniteScroll
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

#nullable disable
namespace UI.Scroll
{
  [Token(Token = "0x20008AF")]
  public class InfiniteScroll : UIBehaviour
  {
    [Token(Token = "0x40028BE")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private RectTransform itemPrototype;
    [Token(Token = "0x40028BF")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    [Range(0.0f, 30f)]
    private int instanceCount;
    [Token(Token = "0x40028C0")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private InfiniteScroll.Direction direction;
    [Token(Token = "0x40028C3")]
    [FieldOffset(Offset = "0x38")]
    protected float diffPreFramePosition;
    [Token(Token = "0x40028C5")]
    [FieldOffset(Offset = "0x40")]
    private RectTransform selfRectTransform;
    [Token(Token = "0x40028C6")]
    [FieldOffset(Offset = "0x48")]
    private float itemScale;

    [Token(Token = "0x17000723")]
    public InfiniteScroll.OnItemPositionChange OnUpdateItem
    {
      [Token(Token = "0x600315B"), Address(RVA = "0x3C16B4C", Offset = "0x3C16B4C", VA = "0x3C16B4C")] get
      {
        return (InfiniteScroll.OnItemPositionChange) null;
      }
      [Token(Token = "0x600315C"), Address(RVA = "0x3C16B54", Offset = "0x3C16B54", VA = "0x3C16B54")] set
      {
      }
    }

    [Token(Token = "0x17000724")]
    public LinkedList<RectTransform> ItemList
    {
      [Token(Token = "0x600315D"), Address(RVA = "0x3C16B5C", Offset = "0x3C16B5C", VA = "0x3C16B5C")] get
      {
        return (LinkedList<RectTransform>) null;
      }
      [Token(Token = "0x600315E"), Address(RVA = "0x3C16B64", Offset = "0x3C16B64", VA = "0x3C16B64")] set
      {
      }
    }

    [Token(Token = "0x17000725")]
    public int CurrentItemNo
    {
      [Token(Token = "0x600315F"), Address(RVA = "0x3C16B6C", Offset = "0x3C16B6C", VA = "0x3C16B6C")] get
      {
        return new int();
      }
      [Token(Token = "0x6003160"), Address(RVA = "0x3C16B74", Offset = "0x3C16B74", VA = "0x3C16B74")] set
      {
      }
    }

    [Token(Token = "0x17000726")]
    public RectTransform RectTransform
    {
      [Token(Token = "0x6003161"), Address(RVA = "0x3C16B7C", Offset = "0x3C16B7C", VA = "0x3C16B7C")] get
      {
        return (RectTransform) null;
      }
    }

    [Token(Token = "0x17000727")]
    private float anchorPosition
    {
      [Token(Token = "0x6003162"), Address(RVA = "0x3C16C10", Offset = "0x3C16C10", VA = "0x3C16C10")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x17000728")]
    public float ItemScale
    {
      [Token(Token = "0x6003163"), Address(RVA = "0x3C16C40", Offset = "0x3C16C40", VA = "0x3C16C40")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x6003164")]
    [Address(RVA = "0x3C16CDC", Offset = "0x3C16CDC", VA = "0x3C16CDC")]
    public void Initialize()
    {
    }

    [Token(Token = "0x6003165")]
    [Address(RVA = "0x3C17384", Offset = "0x3C17384", VA = "0x3C17384")]
    private void Update()
    {
    }

    [Token(Token = "0x6003166")]
    [Address(RVA = "0x3C176C0", Offset = "0x3C176C0", VA = "0x3C176C0")]
    public InfiniteScroll()
    {
    }

    [Token(Token = "0x20008B0")]
    [Serializable]
    public class OnItemPositionChange : UnityEvent<int, GameObject>
    {
      [Token(Token = "0x6003167")]
      [Address(RVA = "0x3C1774C", Offset = "0x3C1774C", VA = "0x3C1774C")]
      public OnItemPositionChange()
      {
      }
    }

    [Token(Token = "0x20008B1")]
    public enum Direction
    {
      [Token(Token = "0x40028C8")] Vertical,
      [Token(Token = "0x40028C9")] Horizontal,
    }
  }
}
