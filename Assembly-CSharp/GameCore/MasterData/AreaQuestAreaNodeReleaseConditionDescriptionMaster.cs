// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.AreaQuestAreaNodeReleaseConditionDescriptionMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20010F5")]
  [Serializable]
  public sealed class AreaQuestAreaNodeReleaseConditionDescriptionMaster : 
    BaseMaster<AreaQuestAreaNodeReleaseConditionDescriptionData>
  {
    [Token(Token = "0x60061C8")]
    [Address(RVA = "0x4AD8730", Offset = "0x4AD8730", VA = "0x4AD8730")]
    public IReadOnlyDictionary<int, AreaQuestAreaNodeReleaseConditionDescriptionData> GetEntities()
    {
      return (IReadOnlyDictionary<int, AreaQuestAreaNodeReleaseConditionDescriptionData>) null;
    }

    [Token(Token = "0x60061C9")]
    [Address(RVA = "0x4AD8738", Offset = "0x4AD8738", VA = "0x4AD8738", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x60061CA")]
    [Address(RVA = "0x4AD8798", Offset = "0x4AD8798", VA = "0x4AD8798", Slot = "5")]
    protected override AreaQuestAreaNodeReleaseConditionDescriptionData LoadEntity(
      IMasterDataReader reader)
    {
      return (AreaQuestAreaNodeReleaseConditionDescriptionData) null;
    }

    [Token(Token = "0x60061CB")]
    [Address(RVA = "0x4AD87F0", Offset = "0x4AD87F0", VA = "0x4AD87F0")]
    public AreaQuestAreaNodeReleaseConditionDescriptionMaster()
    {
    }
  }
}
