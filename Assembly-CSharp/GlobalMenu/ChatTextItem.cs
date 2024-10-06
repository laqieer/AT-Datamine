// Decompiled with JetBrains decompiler
// Type: GlobalMenu.ChatTextItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace GlobalMenu
{
  [Token(Token = "0x2000B8F")]
  public class ChatTextItem : MonoBehaviour
  {
    [Token(Token = "0x40034A2")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private RectTransform rectTransform;
    [Token(Token = "0x40034A3")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Text text;

    [Token(Token = "0x17000994")]
    public RectTransform RectTransform
    {
      [Token(Token = "0x60041DD"), Address(RVA = "0x2A320C8", Offset = "0x2A320C8", VA = "0x2A320C8")] get
      {
        return (RectTransform) null;
      }
    }

    [Token(Token = "0x17000995")]
    public float Height
    {
      [Token(Token = "0x60041DE"), Address(RVA = "0x2A320D0", Offset = "0x2A320D0", VA = "0x2A320D0")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x60041DF")]
    [Address(RVA = "0x2A320F4", Offset = "0x2A320F4", VA = "0x2A320F4")]
    public void SetText(string message)
    {
    }

    [Token(Token = "0x60041E0")]
    [Address(RVA = "0x2A32118", Offset = "0x2A32118", VA = "0x2A32118")]
    public ChatTextItem()
    {
    }
  }
}
