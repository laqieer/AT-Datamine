// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.GuildUnlockedElementDescriptionMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200101C")]
  [Serializable]
  public sealed class GuildUnlockedElementDescriptionMaster : 
    BaseMaster<GuildUnlockedElementDescriptionData>
  {
    [Token(Token = "0x6005DCC")]
    [Address(RVA = "0x279704C", Offset = "0x279704C", VA = "0x279704C")]
    public IReadOnlyDictionary<int, GuildUnlockedElementDescriptionData> GetEntities()
    {
      return (IReadOnlyDictionary<int, GuildUnlockedElementDescriptionData>) null;
    }

    [Token(Token = "0x6005DCD")]
    [Address(RVA = "0x2797054", Offset = "0x2797054", VA = "0x2797054", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005DCE")]
    [Address(RVA = "0x27970B4", Offset = "0x27970B4", VA = "0x27970B4", Slot = "5")]
    protected override GuildUnlockedElementDescriptionData LoadEntity(IMasterDataReader reader)
    {
      return (GuildUnlockedElementDescriptionData) null;
    }

    [Token(Token = "0x6005DCF")]
    [Address(RVA = "0x279710C", Offset = "0x279710C", VA = "0x279710C")]
    public List<GuildUnlockedElementDescriptionData> GetDescriptionDataListBySetId(
      int unlockElementsSetId)
    {
      return (List<GuildUnlockedElementDescriptionData>) null;
    }

    [Token(Token = "0x6005DD0")]
    [Address(RVA = "0x2797344", Offset = "0x2797344", VA = "0x2797344")]
    public GuildUnlockedElementDescriptionMaster()
    {
    }
  }
}
