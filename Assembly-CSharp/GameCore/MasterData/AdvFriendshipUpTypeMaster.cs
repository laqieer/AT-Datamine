// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.AdvFriendshipUpTypeMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000DB2")]
  [Serializable]
  public sealed class AdvFriendshipUpTypeMaster : BaseMaster<AdvFriendshipUpTypeData>
  {
    [Token(Token = "0x400419C")]
    public const int InvalidTrackNum = -1;

    [Token(Token = "0x60053CD")]
    [Address(RVA = "0x3A9DA70", Offset = "0x3A9DA70", VA = "0x3A9DA70")]
    public IReadOnlyDictionary<int, AdvFriendshipUpTypeData> GetEntities()
    {
      return (IReadOnlyDictionary<int, AdvFriendshipUpTypeData>) null;
    }

    [Token(Token = "0x60053CE")]
    [Address(RVA = "0x3A9DA78", Offset = "0x3A9DA78", VA = "0x3A9DA78", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x60053CF")]
    [Address(RVA = "0x3A9DAD8", Offset = "0x3A9DAD8", VA = "0x3A9DAD8", Slot = "5")]
    protected override AdvFriendshipUpTypeData LoadEntity(IMasterDataReader reader)
    {
      return (AdvFriendshipUpTypeData) null;
    }

    [Token(Token = "0x60053D0")]
    [Address(RVA = "0x3A9DB30", Offset = "0x3A9DB30", VA = "0x3A9DB30")]
    public AdvFriendshipUpTypeData GetDataByExpRange(int exp) => (AdvFriendshipUpTypeData) null;

    [Token(Token = "0x60053D1")]
    [Address(RVA = "0x3A9DCB4", Offset = "0x3A9DCB4", VA = "0x3A9DCB4")]
    public AdvFriendshipUpTypeMaster()
    {
    }
  }
}
