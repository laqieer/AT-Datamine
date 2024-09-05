// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Friend.FriendRejectPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network.API;
using System.Collections;

#nullable disable
namespace Scenes.OutGame.Friend
{
  [Token(Token = "0x2003618")]
  public class FriendRejectPopup : 
    APIConfirmPopupBase<FriendRejectPopup, APIFriendReject, APIFriendRejectRequest, APIFriendRejectResponse>
  {
    [Token(Token = "0x400EB3B")]
    private const string PopupTitle = "フレンド登録拒否";
    [Token(Token = "0x400EB3C")]
    private const string PopupMessage = "{0}\nのフレンド申請を拒否しますか？";

    [Token(Token = "0x60154D3")]
    [Address(RVA = "0x4D95E84", Offset = "0x4D95E84", VA = "0x4D95E84", Slot = "4")]
    protected override void OnCreate(APIConfirmPopupParameter popupParameter)
    {
    }

    [Token(Token = "0x60154D4")]
    [Address(RVA = "0x4D95F6C", Offset = "0x4D95F6C", VA = "0x4D95F6C", Slot = "5")]
    protected override IEnumerator SendRequest() => (IEnumerator) null;

    [Token(Token = "0x60154D5")]
    [Address(RVA = "0x4D95FFC", Offset = "0x4D95FFC", VA = "0x4D95FFC")]
    public FriendRejectPopup()
    {
    }
  }
}
