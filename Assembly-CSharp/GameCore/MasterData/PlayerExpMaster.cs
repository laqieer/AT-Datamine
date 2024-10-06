// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.PlayerExpMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20010C0")]
  [Serializable]
  public sealed class PlayerExpMaster : BaseMaster<PlayerExpData>
  {
    [Token(Token = "0x60060D6")]
    [Address(RVA = "0x28DAF1C", Offset = "0x28DAF1C", VA = "0x28DAF1C")]
    public IReadOnlyDictionary<int, PlayerExpData> GetEntities()
    {
      return (IReadOnlyDictionary<int, PlayerExpData>) null;
    }

    [Token(Token = "0x60060D7")]
    [Address(RVA = "0x28DAF24", Offset = "0x28DAF24", VA = "0x28DAF24", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x60060D8")]
    [Address(RVA = "0x28DAF84", Offset = "0x28DAF84", VA = "0x28DAF84", Slot = "5")]
    protected override PlayerExpData LoadEntity(IMasterDataReader reader) => (PlayerExpData) null;

    [Token(Token = "0x60060D9")]
    [Address(RVA = "0x28DAFDC", Offset = "0x28DAFDC", VA = "0x28DAFDC")]
    public PlayerExpData GetLowestExpData() => (PlayerExpData) null;

    [Token(Token = "0x60060DA")]
    [Address(RVA = "0x28DB120", Offset = "0x28DB120", VA = "0x28DB120")]
    public PlayerExpData GetNowData(int totalExp) => (PlayerExpData) null;

    [Token(Token = "0x60060DB")]
    [Address(RVA = "0x28DB2A8", Offset = "0x28DB2A8", VA = "0x28DB2A8")]
    public PlayerExpData GetNextLevelExpData(int nextLevel) => (PlayerExpData) null;

    [Token(Token = "0x60060DC")]
    [Address(RVA = "0x28DB3B0", Offset = "0x28DB3B0", VA = "0x28DB3B0")]
    public int NextLevelExp(PlayerExpData expData, int experience) => new int();

    [Token(Token = "0x60060DD")]
    [Address(RVA = "0x28DB45C", Offset = "0x28DB45C", VA = "0x28DB45C")]
    public float NextLevelExpRate(PlayerExpData expData, int experience) => new float();

    [Token(Token = "0x60060DE")]
    [Address(RVA = "0x28DB4E4", Offset = "0x28DB4E4", VA = "0x28DB4E4")]
    public IReadOnlyCollection<PlayerExpData> GetList()
    {
      return (IReadOnlyCollection<PlayerExpData>) null;
    }

    [Token(Token = "0x60060DF")]
    [Address(RVA = "0x28DB534", Offset = "0x28DB534", VA = "0x28DB534")]
    public PlayerExpMaster()
    {
    }
  }
}
