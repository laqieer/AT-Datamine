// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.FriendConstMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000FB7")]
  [Serializable]
  public sealed class FriendConstMaster : BaseMaster<FriendConstData>
  {
    [Token(Token = "0x6005C35")]
    [Address(RVA = "0x278A1B4", Offset = "0x278A1B4", VA = "0x278A1B4")]
    public IReadOnlyDictionary<int, FriendConstData> GetEntities()
    {
      return (IReadOnlyDictionary<int, FriendConstData>) null;
    }

    [Token(Token = "0x6005C36")]
    [Address(RVA = "0x278A1BC", Offset = "0x278A1BC", VA = "0x278A1BC", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005C37")]
    [Address(RVA = "0x278A21C", Offset = "0x278A21C", VA = "0x278A21C", Slot = "5")]
    protected override FriendConstData LoadEntity(IMasterDataReader reader)
    {
      return (FriendConstData) null;
    }

    [Token(Token = "0x6005C38")]
    [Address(RVA = "0x278A274", Offset = "0x278A274", VA = "0x278A274")]
    public FriendConstData FirstOrDefault() => (FriendConstData) null;

    [Token(Token = "0x6005C39")]
    [Address(RVA = "0x278A2E0", Offset = "0x278A2E0", VA = "0x278A2E0")]
    public int CalcFriendCountLimit(int playerRank) => new int();

    [Token(Token = "0x6005C3A")]
    [Address(RVA = "0x278A380", Offset = "0x278A380", VA = "0x278A380")]
    public FriendConstMaster()
    {
    }
  }
}
