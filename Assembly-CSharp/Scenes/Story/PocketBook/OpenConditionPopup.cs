// Decompiled with JetBrains decompiler
// Type: Scenes.Story.PocketBook.OpenConditionPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Popup;
using Il2CppDummyDll;
using System;

#nullable disable
namespace Scenes.Story.PocketBook
{
  [Token(Token = "0x2002DA0")]
  public class OpenConditionPopup : PopupBase
  {
    [Token(Token = "0x17003CFA")]
    public Action OnClickToCloseAction
    {
      [Token(Token = "0x6011D8E"), Address(RVA = "0x3FA5788", Offset = "0x3FA5788", VA = "0x3FA5788")] get
      {
        return (Action) null;
      }
      [Token(Token = "0x6011D8F"), Address(RVA = "0x3FA5790", Offset = "0x3FA5790", VA = "0x3FA5790")] set
      {
      }
    }

    [Token(Token = "0x6011D90")]
    [Address(RVA = "0x3FA5798", Offset = "0x3FA5798", VA = "0x3FA5798", Slot = "5")]
    public override void OnClickClose()
    {
    }

    [Token(Token = "0x6011D91")]
    [Address(RVA = "0x3FA57B4", Offset = "0x3FA57B4", VA = "0x3FA57B4")]
    public OpenConditionPopup()
    {
    }
  }
}
