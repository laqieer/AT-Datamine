// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.ChatRoomMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000E7A")]
  [Serializable]
  public sealed class ChatRoomMaster : BaseMaster<ChatRoomData>
  {
    [Token(Token = "0x6005841")]
    [Address(RVA = "0x3E474E4", Offset = "0x3E474E4", VA = "0x3E474E4")]
    public IReadOnlyDictionary<int, ChatRoomData> GetEntities()
    {
      return (IReadOnlyDictionary<int, ChatRoomData>) null;
    }

    [Token(Token = "0x6005842")]
    [Address(RVA = "0x3E474EC", Offset = "0x3E474EC", VA = "0x3E474EC", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005843")]
    [Address(RVA = "0x3E4754C", Offset = "0x3E4754C", VA = "0x3E4754C", Slot = "5")]
    protected override ChatRoomData LoadEntity(IMasterDataReader reader) => (ChatRoomData) null;

    [Token(Token = "0x6005844")]
    [Address(RVA = "0x3E475A4", Offset = "0x3E475A4", VA = "0x3E475A4")]
    public Dictionary<int, ChatRoomData> GetChatCategoryName()
    {
      return (Dictionary<int, ChatRoomData>) null;
    }

    [Token(Token = "0x6005845")]
    [Address(RVA = "0x3E477B0", Offset = "0x3E477B0", VA = "0x3E477B0")]
    public Dictionary<int, ChatRoomData> GetChatChannelList(int category)
    {
      return (Dictionary<int, ChatRoomData>) null;
    }

    [Token(Token = "0x6005846")]
    [Address(RVA = "0x3E47A70", Offset = "0x3E47A70", VA = "0x3E47A70")]
    public Dictionary<int, ChatRoomData> GetChatRoomList(int category, int channel)
    {
      return (Dictionary<int, ChatRoomData>) null;
    }

    [Token(Token = "0x6005847")]
    [Address(RVA = "0x3E47CB0", Offset = "0x3E47CB0", VA = "0x3E47CB0")]
    public ChatRoomMaster()
    {
    }
  }
}
