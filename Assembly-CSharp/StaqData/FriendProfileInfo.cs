// Decompiled with JetBrains decompiler
// Type: StaqData.FriendProfileInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using Network.API;
using Network.Param;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x2002005")]
  public class FriendProfileInfo : PlayerPublicProfileInfo
  {
    [Token(Token = "0x17002781")]
    public FriendStatusTypeEnum FriendStatusType
    {
      [Token(Token = "0x600BE97"), Address(RVA = "0x20027B0", Offset = "0x20027B0", VA = "0x20027B0")] get
      {
        return new FriendStatusTypeEnum();
      }
      [Token(Token = "0x600BE98"), Address(RVA = "0x20027B8", Offset = "0x20027B8", VA = "0x20027B8")] private set
      {
      }
    }

    [Token(Token = "0x17002782")]
    public bool IsBlocked
    {
      [Token(Token = "0x600BE99"), Address(RVA = "0x20027C0", Offset = "0x20027C0", VA = "0x20027C0")] get
      {
        return new bool();
      }
      [Token(Token = "0x600BE9A"), Address(RVA = "0x20027C8", Offset = "0x20027C8", VA = "0x20027C8")] private set
      {
      }
    }

    [Token(Token = "0x600BE9B")]
    [Address(RVA = "0x2001AAC", Offset = "0x2001AAC", VA = "0x2001AAC")]
    public void Apply(PlayerFriendType playerFriendType)
    {
    }

    [Token(Token = "0x600BE9C")]
    [Address(RVA = "0x200145C", Offset = "0x200145C", VA = "0x200145C")]
    public void Apply(PlayerBlockType playerBlockType)
    {
    }

    [Token(Token = "0x600BE9D")]
    [Address(RVA = "0x200164C", Offset = "0x200164C", VA = "0x200164C")]
    public void ApplyFriendSearchResponse(APIFriendSearchResponse response)
    {
    }

    [Token(Token = "0x600BE9E")]
    [Address(RVA = "0x200187C", Offset = "0x200187C", VA = "0x200187C")]
    public void ApplyPlayerDetailResponse(APIPlayerDetailResponse response)
    {
    }

    [Token(Token = "0x600BE9F")]
    [Address(RVA = "0x2001C54", Offset = "0x2001C54", VA = "0x2001C54")]
    public void ApplyFriendStatusType(FriendStatusTypeEnum friendStatusType)
    {
    }

    [Token(Token = "0x600BEA0")]
    [Address(RVA = "0x2002334", Offset = "0x2002334", VA = "0x2002334")]
    public void ApplyIsBlocked(bool value)
    {
    }

    [Token(Token = "0x600BEA1")]
    [Address(RVA = "0x2001454", Offset = "0x2001454", VA = "0x2001454")]
    public FriendProfileInfo()
    {
    }
  }
}
