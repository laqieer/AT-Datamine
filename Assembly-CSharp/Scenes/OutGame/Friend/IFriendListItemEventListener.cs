// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Friend.IFriendListItemEventListener
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Scenes.OutGame.Friend
{
  [Token(Token = "0x2003602")]
  public interface IFriendListItemEventListener
  {
    [Token(Token = "0x601540C")]
    void OnFriendRemove(string playerName, string playerId);

    [Token(Token = "0x601540D")]
    void OnFriendAccept(string playerName, string playerId);

    [Token(Token = "0x601540E")]
    void OnFriendReject(string playerName, string playerId);

    [Token(Token = "0x601540F")]
    void OnFriendCancel(string playerName, string playerId);

    [Token(Token = "0x6015410")]
    void OnFriendBlockAdd(string playerName, string playerId);

    [Token(Token = "0x6015411")]
    void OnFriendBlockRemove(string playerName, string playerId);

    [Token(Token = "0x6015412")]
    void OnDetail(string playerId);
  }
}
