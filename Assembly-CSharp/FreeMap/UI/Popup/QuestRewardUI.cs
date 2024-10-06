// Decompiled with JetBrains decompiler
// Type: FreeMap.UI.Popup.QuestRewardUI
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UI;
using UnityEngine;

#nullable disable
namespace FreeMap.UI.Popup
{
  [Token(Token = "0x200163F")]
  public class QuestRewardUI : MonoBehaviour
  {
    [Token(Token = "0x40064FC")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private TextAccessor caption;
    [Token(Token = "0x40064FD")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private QuestRewardElementUI elementUI;

    [Token(Token = "0x6007E27")]
    [Address(RVA = "0x21AA570", Offset = "0x21AA570", VA = "0x21AA570")]
    public QuestRewardElementUI CreateInstance() => (QuestRewardElementUI) null;

    [Token(Token = "0x6007E28")]
    [Address(RVA = "0x21AA4EC", Offset = "0x21AA4EC", VA = "0x21AA4EC")]
    public void SetCaption(string text)
    {
    }

    [Token(Token = "0x6007E29")]
    [Address(RVA = "0x21AA53C", Offset = "0x21AA53C", VA = "0x21AA53C")]
    public void NoCaption()
    {
    }

    [Token(Token = "0x6007E2A")]
    [Address(RVA = "0x21AD5F8", Offset = "0x21AD5F8", VA = "0x21AD5F8")]
    public QuestRewardUI()
    {
    }
  }
}
