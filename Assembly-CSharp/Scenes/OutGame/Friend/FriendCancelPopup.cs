// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Friend.FriendCancelPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network.API;
using System.Collections;

#nullable disable
namespace Scenes.OutGame.Friend
{
  [Token(Token = "0x20035FE")]
  public class FriendCancelPopup : 
    APIConfirmPopupBase<FriendCancelPopup, APIFriendCancel, APIFriendCancelRequest, APIFriendCancelResponse>
  {
    [Token(Token = "0x400EAC2")]
    private const string PopupTitle = "フレンド申請取り消し";
    [Token(Token = "0x400EAC3")]
    private const string PopupMessage = "{0}\nへのフレンド申請を取り消しますか？";

    [Token(Token = "0x60153F4")]
    [Address(RVA = "0x4D8ECB8", Offset = "0x4D8ECB8", VA = "0x4D8ECB8", Slot = "4")]
    protected override void OnCreate(APIConfirmPopupParameter popupParameter)
    {
    }

    [Token(Token = "0x60153F5")]
    [Address(RVA = "0x4D8EDA0", Offset = "0x4D8EDA0", VA = "0x4D8EDA0", Slot = "5")]
    protected override IEnumerator SendRequest() => (IEnumerator) null;

    [Token(Token = "0x60153F6")]
    [Address(RVA = "0x4D8EE30", Offset = "0x4D8EE30", VA = "0x4D8EE30")]
    public FriendCancelPopup()
    {
    }
  }
}
