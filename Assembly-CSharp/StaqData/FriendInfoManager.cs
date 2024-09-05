// Decompiled with JetBrains decompiler
// Type: StaqData.FriendInfoManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network.API;
using Network.Param;
using System.Collections.Generic;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x2001FF9")]
  public class FriendInfoManager
  {
    [Token(Token = "0x4008873")]
    [FieldOffset(Offset = "0x10")]
    private List<FriendProfileInfo> friendInfoList;

    [Token(Token = "0x1700277E")]
    public IReadOnlyList<FriendProfileInfo> FriendList
    {
      [Token(Token = "0x600BE6F"), Address(RVA = "0x2000E5C", Offset = "0x2000E5C", VA = "0x2000E5C")] get
      {
        return (IReadOnlyList<FriendProfileInfo>) null;
      }
    }

    [Token(Token = "0x1700277F")]
    public int CurrentFriendCount
    {
      [Token(Token = "0x600BE70"), Address(RVA = "0x2000E64", Offset = "0x2000E64", VA = "0x2000E64")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17002780")]
    public int FriendCountLimit
    {
      [Token(Token = "0x600BE71"), Address(RVA = "0x2000F60", Offset = "0x2000F60", VA = "0x2000F60")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600BE72")]
    [Address(RVA = "0x2001020", Offset = "0x2001020", VA = "0x2001020")]
    public void Apply(APIFriendListResponse response)
    {
    }

    [Token(Token = "0x600BE73")]
    [Address(RVA = "0x2001498", Offset = "0x2001498", VA = "0x2001498")]
    public void ApplyFriendSearchResponse(APIFriendSearchResponse response)
    {
    }

    [Token(Token = "0x600BE74")]
    [Address(RVA = "0x20016C8", Offset = "0x20016C8", VA = "0x20016C8")]
    public void ApplyPlayerDetailResponse(APIPlayerDetailResponse response)
    {
    }

    [Token(Token = "0x600BE75")]
    [Address(RVA = "0x20018F8", Offset = "0x20018F8", VA = "0x20018F8")]
    public void ApplyFriendApply(PlayerFriendType playerFriendType)
    {
    }

    [Token(Token = "0x600BE76")]
    [Address(RVA = "0x2001AF4", Offset = "0x2001AF4", VA = "0x2001AF4")]
    public void ApplyFriendApplyCancel(string targetPlayerId)
    {
    }

    [Token(Token = "0x600BE77")]
    [Address(RVA = "0x2001C5C", Offset = "0x2001C5C", VA = "0x2001C5C")]
    public void ApplyFriendRequestAccept(PlayerFriendType playerFriendType)
    {
    }

    [Token(Token = "0x600BE78")]
    [Address(RVA = "0x2001D60", Offset = "0x2001D60", VA = "0x2001D60")]
    public void ApplyFriendRequestReject(string targetPlayerId)
    {
    }

    [Token(Token = "0x600BE79")]
    [Address(RVA = "0x2001EC0", Offset = "0x2001EC0", VA = "0x2001EC0")]
    public void ApplyFriendRemove(string targetPlayerId)
    {
    }

    [Token(Token = "0x600BE7A")]
    [Address(RVA = "0x2002020", Offset = "0x2002020", VA = "0x2002020")]
    public void ApplyPlayerBlockAdd(PlayerBlockType playerBlockType)
    {
    }

    [Token(Token = "0x600BE7B")]
    [Address(RVA = "0x20021D4", Offset = "0x20021D4", VA = "0x20021D4")]
    public void ApplyPlayerBlockRemove(string targetPlayerId)
    {
    }

    [Token(Token = "0x600BE7C")]
    [Address(RVA = "0x2002340", Offset = "0x2002340", VA = "0x2002340")]
    public FriendProfileInfo FindFriendInfo(string targetPlayerId) => (FriendProfileInfo) null;

    [Token(Token = "0x600BE7D")]
    [Address(RVA = "0x2002424", Offset = "0x2002424", VA = "0x2002424")]
    public FriendInfoManager()
    {
    }
  }
}
