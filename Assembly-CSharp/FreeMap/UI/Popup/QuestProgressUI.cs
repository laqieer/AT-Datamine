// Decompiled with JetBrains decompiler
// Type: FreeMap.UI.Popup.QuestProgressUI
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace FreeMap.UI.Popup
{
  [Token(Token = "0x200163D")]
  public class QuestProgressUI : MonoBehaviour
  {
    [Token(Token = "0x40064F8")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private QuestProgressElementUI elementUI;
    [Token(Token = "0x40064F9")]
    [FieldOffset(Offset = "0x20")]
    private List<QuestProgressElementUI> rentList;
    [Token(Token = "0x40064FA")]
    [FieldOffset(Offset = "0x28")]
    private Queue<QuestProgressElementUI> pool;

    [Token(Token = "0x6007E21")]
    [Address(RVA = "0x21A86C8", Offset = "0x21A86C8", VA = "0x21A86C8")]
    public QuestProgressElementUI TryGetPoolingInstance() => (QuestProgressElementUI) null;

    [Token(Token = "0x6007E22")]
    [Address(RVA = "0x21AD2A0", Offset = "0x21AD2A0", VA = "0x21AD2A0")]
    public void Release()
    {
    }

    [Token(Token = "0x6007E23")]
    [Address(RVA = "0x21AD48C", Offset = "0x21AD48C", VA = "0x21AD48C")]
    public void Resizing()
    {
    }

    [Token(Token = "0x6007E24")]
    [Address(RVA = "0x21AD528", Offset = "0x21AD528", VA = "0x21AD528")]
    public QuestProgressUI()
    {
    }
  }
}
