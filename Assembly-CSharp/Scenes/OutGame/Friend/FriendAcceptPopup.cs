// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Friend.FriendAcceptPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network.API;
using System.Collections;

#nullable disable
namespace Scenes.OutGame.Friend
{
  [Token(Token = "0x20035F9")]
  public class FriendAcceptPopup : 
    APIConfirmPopupBase<FriendAcceptPopup, APIFriendAccept, APIFriendAcceptRequest, APIFriendAcceptResponse>
  {
    [Token(Token = "0x400EAB5")]
    private const string PopupTitle = "フレンド登録承認";
    [Token(Token = "0x400EAB6")]
    private const string PopupMessage = "{0}\nのフレンド申請を承認しますか？";

    [Token(Token = "0x60153DF")]
    [Address(RVA = "0x4D8E530", Offset = "0x4D8E530", VA = "0x4D8E530", Slot = "4")]
    protected override void OnCreate(APIConfirmPopupParameter popupParameter)
    {
    }

    [Token(Token = "0x60153E0")]
    [Address(RVA = "0x4D8E618", Offset = "0x4D8E618", VA = "0x4D8E618", Slot = "5")]
    protected override IEnumerator SendRequest() => (IEnumerator) null;

    [Token(Token = "0x60153E1")]
    [Address(RVA = "0x4D8E6A8", Offset = "0x4D8E6A8", VA = "0x4D8E6A8")]
    public FriendAcceptPopup()
    {
    }
  }
}
