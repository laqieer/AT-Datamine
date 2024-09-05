// Decompiled with JetBrains decompiler
// Type: FreeMap.UI.Popup.QuestButtonLayoutTwo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace FreeMap.UI.Popup
{
  [Token(Token = "0x2001633")]
  public class QuestButtonLayoutTwo : MonoBehaviour
  {
    [Token(Token = "0x40064D1")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private QuestButtonUI left;
    [Token(Token = "0x40064D2")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private QuestButtonUI right;
    [Token(Token = "0x40064D3")]
    [FieldOffset(Offset = "0x28")]
    public Action ClickLeft;
    [Token(Token = "0x40064D4")]
    [FieldOffset(Offset = "0x30")]
    public Action ClickRight;

    [Token(Token = "0x17001373")]
    public QuestButtonUI Left
    {
      [Token(Token = "0x6007DD9"), Address(RVA = "0x21AC028", Offset = "0x21AC028", VA = "0x21AC028")] get
      {
        return (QuestButtonUI) null;
      }
    }

    [Token(Token = "0x17001374")]
    public QuestButtonUI Right
    {
      [Token(Token = "0x6007DDA"), Address(RVA = "0x21AC030", Offset = "0x21AC030", VA = "0x21AC030")] get
      {
        return (QuestButtonUI) null;
      }
    }

    [Token(Token = "0x6007DDB")]
    [Address(RVA = "0x21AB490", Offset = "0x21AB490", VA = "0x21AB490")]
    public void SetActiveChild(bool active)
    {
    }

    [Token(Token = "0x6007DDC")]
    [Address(RVA = "0x21AC038", Offset = "0x21AC038", VA = "0x21AC038")]
    public QuestButtonLayoutTwo Use() => (QuestButtonLayoutTwo) null;

    [Token(Token = "0x6007DDD")]
    [Address(RVA = "0x21AC090", Offset = "0x21AC090", VA = "0x21AC090")]
    private void OnEnable()
    {
    }

    [Token(Token = "0x6007DDE")]
    [Address(RVA = "0x21AC168", Offset = "0x21AC168", VA = "0x21AC168")]
    private void OnDisable()
    {
    }

    [Token(Token = "0x6007DDF")]
    [Address(RVA = "0x21AC240", Offset = "0x21AC240", VA = "0x21AC240")]
    private void OnClickLeft()
    {
    }

    [Token(Token = "0x6007DE0")]
    [Address(RVA = "0x21AC25C", Offset = "0x21AC25C", VA = "0x21AC25C")]
    private void OnClickRight()
    {
    }

    [Token(Token = "0x6007DE1")]
    [Address(RVA = "0x21AC278", Offset = "0x21AC278", VA = "0x21AC278")]
    public QuestButtonLayoutTwo()
    {
    }
  }
}
