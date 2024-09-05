// Decompiled with JetBrains decompiler
// Type: FreeMap.UI.Control.Position.UITransfromAvoidElementBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.UI.Control.Animation;
using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace FreeMap.UI.Control.Position
{
  [Token(Token = "0x20016B5")]
  public abstract class UITransfromAvoidElementBase : MonoBehaviour
  {
    [Token(Token = "0x40065C5")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    [Header("回避する範囲")]
    protected RectTransform avoidRectTransform;
    [Token(Token = "0x40065C6")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    [Header("設定されているcanvasGroupのアルファ値を参照")]
    protected CanvasGroup canvasGroup;

    [Token(Token = "0x170013ED")]
    protected Rect AvoidRect
    {
      [Token(Token = "0x6008086"), Address(RVA = "0x41F4DC0", Offset = "0x41F4DC0", VA = "0x41F4DC0")] get
      {
        return new Rect();
      }
    }

    [Token(Token = "0x170013EE")]
    protected bool IsActive
    {
      [Token(Token = "0x6008087"), Address(RVA = "0x41F4E64", Offset = "0x41F4E64", VA = "0x41F4E64")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6008088")]
    [Address(RVA = "0x41F4340", Offset = "0x41F4340", VA = "0x41F4340")]
    public bool IsOverLapped(Rect targetRect) => new bool();

    [Token(Token = "0x6008089")]
    public abstract void CalcAvoidPosition(
      RectTransform parentRectTransform,
      Rect targetRect,
      RectTransform canvasRectTransform,
      out FreeMapUIDirection direction);

    [Token(Token = "0x600808A")]
    [Address(RVA = "0x41F4EF0", Offset = "0x41F4EF0", VA = "0x41F4EF0")]
    protected UITransfromAvoidElementBase()
    {
    }
  }
}
