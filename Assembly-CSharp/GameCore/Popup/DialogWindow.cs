// Decompiled with JetBrains decompiler
// Type: GameCore.Popup.DialogWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace GameCore.Popup
{
  [Token(Token = "0x2000CE8")]
  public class DialogWindow : DialogWindowBase
  {
    [Token(Token = "0x40039C4")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    [DialogWindowBase.ArrayElement(new string[] {"No Button", "Yes Button"})]
    protected Button[] Buttons;
    [Token(Token = "0x40039C5")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    protected Transform ContentParent;

    [Token(Token = "0x17000AD7")]
    protected override Button[] DialogButtons
    {
      [Token(Token = "0x6004A2C"), Address(RVA = "0x313D920", Offset = "0x313D920", VA = "0x313D920", Slot = "4")] get
      {
        return (Button[]) null;
      }
    }

    [Token(Token = "0x17000AD8")]
    public DialogWindowContent Content
    {
      [Token(Token = "0x6004A2D"), Address(RVA = "0x313D928", Offset = "0x313D928", VA = "0x313D928")] get
      {
        return (DialogWindowContent) null;
      }
      [Token(Token = "0x6004A2E"), Address(RVA = "0x313D930", Offset = "0x313D930", VA = "0x313D930")] private set
      {
      }
    }

    [Token(Token = "0x6004A2F")]
    [Address(RVA = "0x313D938", Offset = "0x313D938", VA = "0x313D938")]
    public void AddContent(DialogWindowContent content)
    {
    }

    [Token(Token = "0x6004A30")]
    [Address(RVA = "0x313DA5C", Offset = "0x313DA5C", VA = "0x313DA5C")]
    public void SetContent(DialogWindowContent content)
    {
    }

    [Token(Token = "0x6004A31")]
    [Address(RVA = "0x313DD24", Offset = "0x313DD24", VA = "0x313DD24", Slot = "7")]
    protected override void OnButtonClicked(int index)
    {
    }

    [Token(Token = "0x6004A32")]
    [Address(RVA = "0x313DE48", Offset = "0x313DE48", VA = "0x313DE48")]
    public DialogWindow()
    {
    }

    [Token(Token = "0x2000CE9")]
    protected internal interface IContent
    {
      [Token(Token = "0x6004A33")]
      string GetButtonMessage(int index);

      [Token(Token = "0x6004A34")]
      string GetButtonSoundLabel(int index);
    }
  }
}
