// Decompiled with JetBrains decompiler
// Type: FreeMap.UI.SwipeController.SwipeControllerMethod
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;

#nullable disable
namespace FreeMap.UI.SwipeController
{
  [Token(Token = "0x2001617")]
  public class SwipeControllerMethod
  {
    [Token(Token = "0x4006493")]
    [FieldOffset(Offset = "0x28")]
    private RectTransform swipeRectTransform;

    [Token(Token = "0x17001352")]
    public bool IsControlling
    {
      [Token(Token = "0x6007D28"), Address(RVA = "0x21A6CA8", Offset = "0x21A6CA8", VA = "0x21A6CA8")] get
      {
        return new bool();
      }
      [Token(Token = "0x6007D29"), Address(RVA = "0x21A6CB0", Offset = "0x21A6CB0", VA = "0x21A6CB0")] private set
      {
      }
    }

    [Token(Token = "0x17001353")]
    public bool IsSwiping
    {
      [Token(Token = "0x6007D2A"), Address(RVA = "0x21A6CBC", Offset = "0x21A6CBC", VA = "0x21A6CBC")] get
      {
        return new bool();
      }
      [Token(Token = "0x6007D2B"), Address(RVA = "0x21A6CC4", Offset = "0x21A6CC4", VA = "0x21A6CC4")] private set
      {
      }
    }

    [Token(Token = "0x17001354")]
    public Vector2 StartPosition
    {
      [Token(Token = "0x6007D2C"), Address(RVA = "0x21A6CD0", Offset = "0x21A6CD0", VA = "0x21A6CD0")] get
      {
        return new Vector2();
      }
      [Token(Token = "0x6007D2D"), Address(RVA = "0x21A6CD8", Offset = "0x21A6CD8", VA = "0x21A6CD8")] private set
      {
      }
    }

    [Token(Token = "0x17001355")]
    public Vector2 SwipeValue
    {
      [Token(Token = "0x6007D2E"), Address(RVA = "0x21A6CE0", Offset = "0x21A6CE0", VA = "0x21A6CE0")] get
      {
        return new Vector2();
      }
      [Token(Token = "0x6007D2F"), Address(RVA = "0x21A6CE8", Offset = "0x21A6CE8", VA = "0x21A6CE8")] private set
      {
      }
    }

    [Token(Token = "0x17001356")]
    public Vector2 SwipeValueInInch
    {
      [Token(Token = "0x6007D30"), Address(RVA = "0x21A6CF0", Offset = "0x21A6CF0", VA = "0x21A6CF0")] get
      {
        return new Vector2();
      }
    }

    [Token(Token = "0x17001357")]
    public float SwipeAngle
    {
      [Token(Token = "0x6007D31"), Address(RVA = "0x21A6E1C", Offset = "0x21A6E1C", VA = "0x21A6E1C")] get
      {
        return new float();
      }
      [Token(Token = "0x6007D32"), Address(RVA = "0x21A6E24", Offset = "0x21A6E24", VA = "0x21A6E24")] private set
      {
      }
    }

    [Token(Token = "0x6007D33")]
    [Address(RVA = "0x21A6E2C", Offset = "0x21A6E2C", VA = "0x21A6E2C")]
    public SwipeControllerMethod(RectTransform rectTransform)
    {
    }

    [Token(Token = "0x6007D34")]
    [Address(RVA = "0x21A6E54", Offset = "0x21A6E54", VA = "0x21A6E54")]
    public void BeginControl(PointerEventData eventData)
    {
    }

    [Token(Token = "0x6007D35")]
    [Address(RVA = "0x21A6F74", Offset = "0x21A6F74", VA = "0x21A6F74")]
    public void EndControl()
    {
    }

    [Token(Token = "0x6007D36")]
    [Address(RVA = "0x21A6FD0", Offset = "0x21A6FD0", VA = "0x21A6FD0")]
    public void Swipe(PointerEventData eventData)
    {
    }

    [Token(Token = "0x6007D37")]
    [Address(RVA = "0x21A6EE0", Offset = "0x21A6EE0", VA = "0x21A6EE0")]
    public void SetStartPosition(Camera camera, Vector2 pointerPosition)
    {
    }

    [Token(Token = "0x6007D38")]
    [Address(RVA = "0x21A7018", Offset = "0x21A7018", VA = "0x21A7018")]
    public void SetDesiredPosition(Camera camera, Vector2 pointerPosition)
    {
    }
  }
}
