// Decompiled with JetBrains decompiler
// Type: GameCore.Popup.DialogWindowContent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace GameCore.Popup
{
  [Token(Token = "0x2000CF2")]
  public class DialogWindowContent : MonoBehaviour, DialogWindow.IContent
  {
    [Token(Token = "0x40039E2")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    protected string[] buttonMessages;

    [Token(Token = "0x6004A6F")]
    [Address(RVA = "0x313DB8C", Offset = "0x313DB8C", VA = "0x313DB8C", Slot = "4")]
    public string GetButtonMessage(int index) => (string) null;

    [Token(Token = "0x6004A70")]
    [Address(RVA = "0x313EDD4", Offset = "0x313EDD4", VA = "0x313EDD4", Slot = "6")]
    public virtual string GetButtonSoundLabel(int index) => (string) null;

    [Token(Token = "0x6004A71")]
    [Address(RVA = "0x313EE5C", Offset = "0x313EE5C", VA = "0x313EE5C")]
    public DialogWindowContent()
    {
    }

    [Token(Token = "0x2000CF3")]
    public enum Result
    {
      [Token(Token = "0x40039E4")] No,
      [Token(Token = "0x40039E5")] Yes,
    }
  }
}
