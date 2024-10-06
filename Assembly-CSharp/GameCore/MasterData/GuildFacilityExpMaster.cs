// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.GuildFacilityExpMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000FD6")]
  [Serializable]
  public sealed class GuildFacilityExpMaster : BaseMaster<GuildFacilityExpData>
  {
    [Token(Token = "0x6005C9D")]
    [Address(RVA = "0x278CEB8", Offset = "0x278CEB8", VA = "0x278CEB8")]
    public IReadOnlyDictionary<int, GuildFacilityExpData> GetEntities()
    {
      return (IReadOnlyDictionary<int, GuildFacilityExpData>) null;
    }

    [Token(Token = "0x6005C9E")]
    [Address(RVA = "0x278CEC0", Offset = "0x278CEC0", VA = "0x278CEC0", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005C9F")]
    [Address(RVA = "0x278CF20", Offset = "0x278CF20", VA = "0x278CF20", Slot = "5")]
    protected override GuildFacilityExpData LoadEntity(IMasterDataReader reader)
    {
      return (GuildFacilityExpData) null;
    }

    [Token(Token = "0x6005CA0")]
    [Address(RVA = "0x278CF78", Offset = "0x278CF78", VA = "0x278CF78")]
    public int GetLevelWithExp(int experision) => new int();

    [Token(Token = "0x6005CA1")]
    [Address(RVA = "0x278CF94", Offset = "0x278CF94", VA = "0x278CF94")]
    public GuildFacilityExpData GetExpDataWithExp(int experision) => (GuildFacilityExpData) null;

    [Token(Token = "0x6005CA2")]
    [Address(RVA = "0x278D158", Offset = "0x278D158", VA = "0x278D158")]
    public GuildFacilityExpData GetExpDataWithLevel(int level) => (GuildFacilityExpData) null;

    [Token(Token = "0x6005CA3")]
    [Address(RVA = "0x278D318", Offset = "0x278D318", VA = "0x278D318")]
    public int GetLevelCap() => new int();

    [Token(Token = "0x6005CA4")]
    [Address(RVA = "0x278D390", Offset = "0x278D390", VA = "0x278D390")]
    public int GetFromExpWithLevel(int level) => new int();

    [Token(Token = "0x6005CA5")]
    [Address(RVA = "0x278D558", Offset = "0x278D558", VA = "0x278D558")]
    public float GetProgressToNextLevel(int experience) => new float();

    [Token(Token = "0x6005CA6")]
    [Address(RVA = "0x278D630", Offset = "0x278D630", VA = "0x278D630")]
    public int GetNextLevelNeedExp(int experience) => new int();

    [Token(Token = "0x6005CA7")]
    [Address(RVA = "0x278D6F4", Offset = "0x278D6F4", VA = "0x278D6F4")]
    public GuildFacilityExpMaster()
    {
    }
  }
}
