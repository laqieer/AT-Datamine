// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.AreaQuestAreaGroupReleaseConditionDescriptionMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20010E9")]
  [Serializable]
  public sealed class AreaQuestAreaGroupReleaseConditionDescriptionMaster : 
    BaseMaster<AreaQuestAreaGroupReleaseConditionDescriptionData>
  {
    [Token(Token = "0x6006183")]
    [Address(RVA = "0x28E139C", Offset = "0x28E139C", VA = "0x28E139C")]
    public IReadOnlyDictionary<int, AreaQuestAreaGroupReleaseConditionDescriptionData> GetEntities()
    {
      return (IReadOnlyDictionary<int, AreaQuestAreaGroupReleaseConditionDescriptionData>) null;
    }

    [Token(Token = "0x6006184")]
    [Address(RVA = "0x28E13A4", Offset = "0x28E13A4", VA = "0x28E13A4", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006185")]
    [Address(RVA = "0x28E1404", Offset = "0x28E1404", VA = "0x28E1404", Slot = "5")]
    protected override AreaQuestAreaGroupReleaseConditionDescriptionData LoadEntity(
      IMasterDataReader reader)
    {
      return (AreaQuestAreaGroupReleaseConditionDescriptionData) null;
    }

    [Token(Token = "0x6006186")]
    [Address(RVA = "0x28E145C", Offset = "0x28E145C", VA = "0x28E145C")]
    public AreaQuestAreaGroupReleaseConditionDescriptionMaster()
    {
    }
  }
}
