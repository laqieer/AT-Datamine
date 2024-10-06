// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Friend.PlayerBlockAddPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network.API;
using System.Collections;

#nullable disable
namespace Scenes.OutGame.Friend
{
  [Token(Token = "0x2003622")]
  public class PlayerBlockAddPopup : 
    APIConfirmPopupBase<PlayerBlockAddPopup, APIBlockAdd, APIBlockAddRequest, APIBlockAddResponse>
  {
    [Token(Token = "0x400EB63")]
    private const string PopupTitle = "ブロック登録";
    [Token(Token = "0x400EB64")]
    private const string PopupMessage = "{0}\nブロックリストに登録しますか？";

    [Token(Token = "0x6015524")]
    [Address(RVA = "0x4D97D0C", Offset = "0x4D97D0C", VA = "0x4D97D0C", Slot = "4")]
    protected override void OnCreate(APIConfirmPopupParameter popupParameter)
    {
    }

    [Token(Token = "0x6015525")]
    [Address(RVA = "0x4D97DF4", Offset = "0x4D97DF4", VA = "0x4D97DF4", Slot = "5")]
    protected override IEnumerator SendRequest() => (IEnumerator) null;

    [Token(Token = "0x6015526")]
    [Address(RVA = "0x4D97E84", Offset = "0x4D97E84", VA = "0x4D97E84")]
    public PlayerBlockAddPopup()
    {
    }
  }
}
