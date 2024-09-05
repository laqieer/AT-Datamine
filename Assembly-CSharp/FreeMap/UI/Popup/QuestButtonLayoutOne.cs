// Decompiled with JetBrains decompiler
// Type: FreeMap.UI.Popup.QuestButtonLayoutOne
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace FreeMap.UI.Popup
{
  [Token(Token = "0x2001631")]
  public class QuestButtonLayoutOne : MonoBehaviour
  {
    [Token(Token = "0x40064C9")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private QuestButtonUI center;
    [Token(Token = "0x40064CA")]
    [FieldOffset(Offset = "0x20")]
    public Action ClickCenter;

    [Token(Token = "0x1700136F")]
    public QuestButtonUI Center
    {
      [Token(Token = "0x6007DC7"), Address(RVA = "0x21ABB88", Offset = "0x21ABB88", VA = "0x21ABB88")] get
      {
        return (QuestButtonUI) null;
      }
    }

    [Token(Token = "0x6007DC8")]
    [Address(RVA = "0x21AB460", Offset = "0x21AB460", VA = "0x21AB460")]
    public void SetActiveChild(bool active)
    {
    }

    [Token(Token = "0x6007DC9")]
    [Address(RVA = "0x21ABB90", Offset = "0x21ABB90", VA = "0x21ABB90")]
    public QuestButtonLayoutOne Use() => (QuestButtonLayoutOne) null;

    [Token(Token = "0x6007DCA")]
    [Address(RVA = "0x21ABBDC", Offset = "0x21ABBDC", VA = "0x21ABBDC")]
    private void OnEnable()
    {
    }

    [Token(Token = "0x6007DCB")]
    [Address(RVA = "0x21ABC64", Offset = "0x21ABC64", VA = "0x21ABC64")]
    private void OnDisable()
    {
    }

    [Token(Token = "0x6007DCC")]
    [Address(RVA = "0x21ABCEC", Offset = "0x21ABCEC", VA = "0x21ABCEC")]
    private void OnClick()
    {
    }

    [Token(Token = "0x6007DCD")]
    [Address(RVA = "0x21ABD08", Offset = "0x21ABD08", VA = "0x21ABD08")]
    public QuestButtonLayoutOne()
    {
    }
  }
}
