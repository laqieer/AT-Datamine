// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.GuildEmblemMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000FEE")]
  [Serializable]
  public sealed class GuildEmblemMaster : BaseMaster<GuildEmblemData>
  {
    [Token(Token = "0x4004F9C")]
    [FieldOffset(Offset = "0x20")]
    private int? defaultId;

    [Token(Token = "0x6005D00")]
    [Address(RVA = "0x27900F4", Offset = "0x27900F4", VA = "0x27900F4")]
    public IReadOnlyDictionary<int, GuildEmblemData> GetEntities()
    {
      return (IReadOnlyDictionary<int, GuildEmblemData>) null;
    }

    [Token(Token = "0x6005D01")]
    [Address(RVA = "0x27900FC", Offset = "0x27900FC", VA = "0x27900FC", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005D02")]
    [Address(RVA = "0x279036C", Offset = "0x279036C", VA = "0x279036C", Slot = "5")]
    protected override GuildEmblemData LoadEntity(IMasterDataReader reader)
    {
      return (GuildEmblemData) null;
    }

    [Token(Token = "0x6005D03")]
    [Address(RVA = "0x27903DC", Offset = "0x27903DC", VA = "0x27903DC")]
    private void OnLoadEntity(GuildEmblemData entity)
    {
    }

    [Token(Token = "0x6005D04")]
    [Address(RVA = "0x2790164", Offset = "0x2790164", VA = "0x2790164")]
    private void OnCompletedLoading()
    {
    }

    [Token(Token = "0x17000DB8")]
    public IReadOnlyCollection<int> AvailableIdsOnBuild
    {
      [Token(Token = "0x6005D05"), Address(RVA = "0x2790494", Offset = "0x2790494", VA = "0x2790494")] get
      {
        return (IReadOnlyCollection<int>) null;
      }
      [Token(Token = "0x6005D06"), Address(RVA = "0x279049C", Offset = "0x279049C", VA = "0x279049C")] private set
      {
      }
    }

    [Token(Token = "0x17000DB9")]
    public int DefaultId
    {
      [Token(Token = "0x6005D07"), Address(RVA = "0x27904A4", Offset = "0x27904A4", VA = "0x27904A4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005D08")]
    [Address(RVA = "0x27904EC", Offset = "0x27904EC", VA = "0x27904EC")]
    public GuildEmblemMaster()
    {
    }
  }
}
