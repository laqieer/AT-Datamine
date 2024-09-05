// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Friend.PlayerBlockRemovePopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network.API;
using System.Collections;

#nullable disable
namespace Scenes.OutGame.Friend
{
  [Token(Token = "0x2003624")]
  public class PlayerBlockRemovePopup : 
    APIConfirmPopupBase<PlayerBlockRemovePopup, APIBlockRemove, APIBlockRemoveRequest, APIBlockRemoveResponse>
  {
    [Token(Token = "0x400EB69")]
    private const string PopupTitle = "ブロック解除";
    [Token(Token = "0x400EB6A")]
    private const string PopupMessage = "{0}\nのブロックを解除しますか？";

    [Token(Token = "0x601552D")]
    [Address(RVA = "0x4D980C4", Offset = "0x4D980C4", VA = "0x4D980C4", Slot = "4")]
    protected override void OnCreate(APIConfirmPopupParameter popupParameter)
    {
    }

    [Token(Token = "0x601552E")]
    [Address(RVA = "0x4D981AC", Offset = "0x4D981AC", VA = "0x4D981AC", Slot = "5")]
    protected override IEnumerator SendRequest() => (IEnumerator) null;

    [Token(Token = "0x601552F")]
    [Address(RVA = "0x4D9823C", Offset = "0x4D9823C", VA = "0x4D9823C")]
    public PlayerBlockRemovePopup()
    {
    }
  }
}
