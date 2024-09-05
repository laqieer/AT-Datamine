// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.GuildStampMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200100D")]
  [Serializable]
  public sealed class GuildStampMaster : BaseMaster<GuildStampData>
  {
    [Token(Token = "0x6005D83")]
    [Address(RVA = "0x27948B0", Offset = "0x27948B0", VA = "0x27948B0")]
    public IReadOnlyDictionary<int, GuildStampData> GetEntities()
    {
      return (IReadOnlyDictionary<int, GuildStampData>) null;
    }

    [Token(Token = "0x6005D84")]
    [Address(RVA = "0x27948B8", Offset = "0x27948B8", VA = "0x27948B8", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005D85")]
    [Address(RVA = "0x2794918", Offset = "0x2794918", VA = "0x2794918", Slot = "5")]
    protected override GuildStampData LoadEntity(IMasterDataReader reader) => (GuildStampData) null;

    [Token(Token = "0x6005D86")]
    [Address(RVA = "0x2794970", Offset = "0x2794970", VA = "0x2794970")]
    public GuildStampMaster()
    {
    }
  }
}
