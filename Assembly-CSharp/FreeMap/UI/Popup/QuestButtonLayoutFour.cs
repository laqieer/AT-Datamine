// Decompiled with JetBrains decompiler
// Type: FreeMap.UI.Popup.QuestButtonLayoutFour
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace FreeMap.UI.Popup
{
  [Token(Token = "0x2001630")]
  public class QuestButtonLayoutFour : MonoBehaviour
  {
    [Token(Token = "0x40064C1")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private QuestButtonUI left;
    [Token(Token = "0x40064C2")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private QuestButtonUI centerLeft;
    [Token(Token = "0x40064C3")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private QuestButtonUI centerRight;
    [Token(Token = "0x40064C4")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private QuestButtonUI right;
    [Token(Token = "0x40064C5")]
    [FieldOffset(Offset = "0x38")]
    public Action ClickLeft;
    [Token(Token = "0x40064C6")]
    [FieldOffset(Offset = "0x40")]
    public Action ClickCenterLeft;
    [Token(Token = "0x40064C7")]
    [FieldOffset(Offset = "0x48")]
    public Action ClickCenterRight;
    [Token(Token = "0x40064C8")]
    [FieldOffset(Offset = "0x50")]
    public Action ClickRight;

    [Token(Token = "0x1700136B")]
    public QuestButtonUI Left
    {
      [Token(Token = "0x6007DBA"), Address(RVA = "0x21AB60C", Offset = "0x21AB60C", VA = "0x21AB60C")] get
      {
        return (QuestButtonUI) null;
      }
    }

    [Token(Token = "0x1700136C")]
    public QuestButtonUI CenterLeft
    {
      [Token(Token = "0x6007DBB"), Address(RVA = "0x21AB614", Offset = "0x21AB614", VA = "0x21AB614")] get
      {
        return (QuestButtonUI) null;
      }
    }

    [Token(Token = "0x1700136D")]
    public QuestButtonUI CenterRight
    {
      [Token(Token = "0x6007DBC"), Address(RVA = "0x21AB61C", Offset = "0x21AB61C", VA = "0x21AB61C")] get
      {
        return (QuestButtonUI) null;
      }
    }

    [Token(Token = "0x1700136E")]
    public QuestButtonUI Right
    {
      [Token(Token = "0x6007DBD"), Address(RVA = "0x21AB624", Offset = "0x21AB624", VA = "0x21AB624")] get
      {
        return (QuestButtonUI) null;
      }
    }

    [Token(Token = "0x6007DBE")]
    [Address(RVA = "0x21AB568", Offset = "0x21AB568", VA = "0x21AB568")]
    public void SetActiveChild(bool active)
    {
    }

    [Token(Token = "0x6007DBF")]
    [Address(RVA = "0x21AB62C", Offset = "0x21AB62C", VA = "0x21AB62C")]
    public QuestButtonLayoutFour Use() => (QuestButtonLayoutFour) null;

    [Token(Token = "0x6007DC0")]
    [Address(RVA = "0x21AB74C", Offset = "0x21AB74C", VA = "0x21AB74C")]
    private void OnEnable()
    {
    }

    [Token(Token = "0x6007DC1")]
    [Address(RVA = "0x21AB904", Offset = "0x21AB904", VA = "0x21AB904")]
    private void OnDisable()
    {
    }

    [Token(Token = "0x6007DC2")]
    [Address(RVA = "0x21ABB10", Offset = "0x21ABB10", VA = "0x21ABB10")]
    private void OnClickLeft()
    {
    }

    [Token(Token = "0x6007DC3")]
    [Address(RVA = "0x21ABB2C", Offset = "0x21ABB2C", VA = "0x21ABB2C")]
    private void OnClickCenterLeft()
    {
    }

    [Token(Token = "0x6007DC4")]
    [Address(RVA = "0x21ABB48", Offset = "0x21ABB48", VA = "0x21ABB48")]
    private void OnClickCenterRight()
    {
    }

    [Token(Token = "0x6007DC5")]
    [Address(RVA = "0x21ABB64", Offset = "0x21ABB64", VA = "0x21ABB64")]
    private void OnClickRight()
    {
    }

    [Token(Token = "0x6007DC6")]
    [Address(RVA = "0x21ABB80", Offset = "0x21ABB80", VA = "0x21ABB80")]
    public QuestButtonLayoutFour()
    {
    }
  }
}
