// Decompiled with JetBrains decompiler
// Type: FreeMap.UI.Popup.QuestButtonLayoutControUI
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace FreeMap.UI.Popup
{
  [Token(Token = "0x200162F")]
  public class QuestButtonLayoutControUI : MonoBehaviour
  {
    [Token(Token = "0x40064BD")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private QuestButtonLayoutOne layoutOne;
    [Token(Token = "0x40064BE")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private QuestButtonLayoutTwo layoutTwo;
    [Token(Token = "0x40064BF")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private QuestButtonLayoutThree layoutThree;
    [Token(Token = "0x40064C0")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private QuestButtonLayoutFour layoutFour;

    [Token(Token = "0x17001367")]
    public QuestButtonLayoutOne LayoutOne
    {
      [Token(Token = "0x6007DB4"), Address(RVA = "0x21AB370", Offset = "0x21AB370", VA = "0x21AB370")] get
      {
        return (QuestButtonLayoutOne) null;
      }
    }

    [Token(Token = "0x17001368")]
    public QuestButtonLayoutTwo LayoutTwo
    {
      [Token(Token = "0x6007DB5"), Address(RVA = "0x21AB378", Offset = "0x21AB378", VA = "0x21AB378")] get
      {
        return (QuestButtonLayoutTwo) null;
      }
    }

    [Token(Token = "0x17001369")]
    public QuestButtonLayoutThree LayoutThree
    {
      [Token(Token = "0x6007DB6"), Address(RVA = "0x21AB380", Offset = "0x21AB380", VA = "0x21AB380")] get
      {
        return (QuestButtonLayoutThree) null;
      }
    }

    [Token(Token = "0x1700136A")]
    public QuestButtonLayoutFour LayoutFour
    {
      [Token(Token = "0x6007DB7"), Address(RVA = "0x21AB388", Offset = "0x21AB388", VA = "0x21AB388")] get
      {
        return (QuestButtonLayoutFour) null;
      }
    }

    [Token(Token = "0x6007DB8")]
    [Address(RVA = "0x21AB390", Offset = "0x21AB390", VA = "0x21AB390")]
    public void LayoutReset()
    {
    }

    [Token(Token = "0x6007DB9")]
    [Address(RVA = "0x21AB604", Offset = "0x21AB604", VA = "0x21AB604")]
    public QuestButtonLayoutControUI()
    {
    }
  }
}
