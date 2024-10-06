// Decompiled with JetBrains decompiler
// Type: GameCore.Popup.AccountDeleteConfirmationPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace GameCore.Popup
{
  [Token(Token = "0x2000CCF")]
  public class AccountDeleteConfirmationPopup : CommonPopup
  {
    [Token(Token = "0x4003978")]
    private const int RIGHT_BUTTON_INDEX = 1;
    [Token(Token = "0x4003979")]
    [FieldOffset(Offset = "0x128")]
    [SerializeField]
    private CommonToggle confirmationToggle;

    [Token(Token = "0x60049B2")]
    [Address(RVA = "0x313AE30", Offset = "0x313AE30", VA = "0x313AE30")]
    public void InitConfirmationToggle()
    {
    }

    [Token(Token = "0x60049B3")]
    [Address(RVA = "0x313AEF0", Offset = "0x313AEF0", VA = "0x313AEF0")]
    public AccountDeleteConfirmationPopup()
    {
    }
  }
}
