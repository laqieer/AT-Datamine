// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.GuildConstMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000FBB")]
  [Serializable]
  public sealed class GuildConstMaster : BaseMaster<GuildConstData>
  {
    [Token(Token = "0x6005C47")]
    [Address(RVA = "0x278A9D4", Offset = "0x278A9D4", VA = "0x278A9D4")]
    public IReadOnlyDictionary<int, GuildConstData> GetEntities()
    {
      return (IReadOnlyDictionary<int, GuildConstData>) null;
    }

    [Token(Token = "0x6005C48")]
    [Address(RVA = "0x278A9DC", Offset = "0x278A9DC", VA = "0x278A9DC", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005C49")]
    [Address(RVA = "0x278AAB8", Offset = "0x278AAB8", VA = "0x278AAB8", Slot = "5")]
    protected override GuildConstData LoadEntity(IMasterDataReader reader) => (GuildConstData) null;

    [Token(Token = "0x6005C4A")]
    [Address(RVA = "0x278AA44", Offset = "0x278AA44", VA = "0x278AA44")]
    private void OnCompletedLoading()
    {
    }

    [Token(Token = "0x17000D9D")]
    public GuildConstData CachedConstData
    {
      [Token(Token = "0x6005C4B"), Address(RVA = "0x278AB10", Offset = "0x278AB10", VA = "0x278AB10")] get
      {
        return (GuildConstData) null;
      }
      [Token(Token = "0x6005C4C"), Address(RVA = "0x278AB18", Offset = "0x278AB18", VA = "0x278AB18")] private set
      {
      }
    }

    [Token(Token = "0x6005C4D")]
    [Address(RVA = "0x278AB20", Offset = "0x278AB20", VA = "0x278AB20")]
    public GuildConstMaster()
    {
    }
  }
}
