// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.AreaQuestAreaGroupMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20010EB")]
  [Serializable]
  public sealed class AreaQuestAreaGroupMaster : BaseMaster<AreaQuestAreaGroupData>
  {
    [Token(Token = "0x600618F")]
    [Address(RVA = "0x28E1824", Offset = "0x28E1824", VA = "0x28E1824")]
    public IReadOnlyDictionary<int, AreaQuestAreaGroupData> GetEntities()
    {
      return (IReadOnlyDictionary<int, AreaQuestAreaGroupData>) null;
    }

    [Token(Token = "0x6006190")]
    [Address(RVA = "0x28E182C", Offset = "0x28E182C", VA = "0x28E182C", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006191")]
    [Address(RVA = "0x28E188C", Offset = "0x28E188C", VA = "0x28E188C", Slot = "5")]
    protected override AreaQuestAreaGroupData LoadEntity(IMasterDataReader reader)
    {
      return (AreaQuestAreaGroupData) null;
    }

    [Token(Token = "0x6006192")]
    [Address(RVA = "0x28E18E4", Offset = "0x28E18E4", VA = "0x28E18E4")]
    public bool IsEventTypeGroupByAreaGroupId(int groupId) => new bool();

    [Token(Token = "0x6006193")]
    [Address(RVA = "0x28E1AE4", Offset = "0x28E1AE4", VA = "0x28E1AE4")]
    public int GetBackgroundResourceId(int groupId) => new int();

    [Token(Token = "0x6006194")]
    [Address(RVA = "0x28E1BF8", Offset = "0x28E1BF8", VA = "0x28E1BF8")]
    public AreaGroupTypeEnum GetAreaGroupType(int groupId) => new AreaGroupTypeEnum();

    [Token(Token = "0x6006195")]
    [Address(RVA = "0x28E1D0C", Offset = "0x28E1D0C", VA = "0x28E1D0C")]
    public AreaQuestAreaGroupMaster()
    {
    }
  }
}
