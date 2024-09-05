// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.GuildGiftMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000FF4")]
  [Serializable]
  public sealed class GuildGiftMaster : BaseMaster<GuildGiftData>
  {
    [Token(Token = "0x6005D1F")]
    [Address(RVA = "0x27910B0", Offset = "0x27910B0", VA = "0x27910B0")]
    public IReadOnlyDictionary<int, GuildGiftData> GetEntities()
    {
      return (IReadOnlyDictionary<int, GuildGiftData>) null;
    }

    [Token(Token = "0x6005D20")]
    [Address(RVA = "0x27910B8", Offset = "0x27910B8", VA = "0x27910B8", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005D21")]
    [Address(RVA = "0x2791118", Offset = "0x2791118", VA = "0x2791118", Slot = "5")]
    protected override GuildGiftData LoadEntity(IMasterDataReader reader) => (GuildGiftData) null;

    [Token(Token = "0x6005D22")]
    [Address(RVA = "0x2791170", Offset = "0x2791170", VA = "0x2791170")]
    public List<GuildGiftData> GetList() => (List<GuildGiftData>) null;

    [Token(Token = "0x6005D23")]
    [Address(RVA = "0x27911DC", Offset = "0x27911DC", VA = "0x27911DC")]
    public GuildGiftMaster()
    {
    }
  }
}
