// Decompiled with JetBrains decompiler
// Type: Story.Chart.UI.Popup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Popup;
using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace Story.Chart.UI
{
  [Token(Token = "0x20006F4")]
  public class Popup : PopupBase
  {
    [Token(Token = "0x40020B7")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private Transform contentRoot;
    [Token(Token = "0x40020B8")]
    [FieldOffset(Offset = "0x90")]
    private Story.Chart.UI.Popup.Content content;

    [Token(Token = "0x170005E1")]
    public bool IsBusy
    {
      [Token(Token = "0x6002764"), Address(RVA = "0x366E4BC", Offset = "0x366E4BC", VA = "0x366E4BC")] get
      {
        return new bool();
      }
      [Token(Token = "0x6002765"), Address(RVA = "0x366E4C4", Offset = "0x366E4C4", VA = "0x366E4C4")] private set
      {
      }
    }

    [Token(Token = "0x6002766")]
    [Address(RVA = "0x366E4D0", Offset = "0x366E4D0", VA = "0x366E4D0", Slot = "8")]
    public override void Open()
    {
    }

    [Token(Token = "0x6002767")]
    [Address(RVA = "0x366E4E0", Offset = "0x366E4E0", VA = "0x366E4E0")]
    public void SetContent(Story.Chart.UI.Popup.Content content)
    {
    }

    [Token(Token = "0x6002768")]
    [Address(RVA = "0x366E540", Offset = "0x366E540", VA = "0x366E540", Slot = "9")]
    public override void Close()
    {
    }

    [Token(Token = "0x6002769")]
    [Address(RVA = "0x366E650", Offset = "0x366E650", VA = "0x366E650")]
    public Popup()
    {
    }

    [Token(Token = "0x20006F5")]
    public abstract class Content : MonoBehaviour
    {
      [Token(Token = "0x600276B")]
      [Address(RVA = "0x366E688", Offset = "0x366E688", VA = "0x366E688", Slot = "4")]
      public virtual void OnClose()
      {
      }

      [Token(Token = "0x600276C")]
      [Address(RVA = "0x366E68C", Offset = "0x366E68C", VA = "0x366E68C")]
      protected Content()
      {
      }
    }
  }
}
