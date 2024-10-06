// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.AreaQuestAreaReleaseConditionDescriptionMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20010FF")]
  [Serializable]
  public sealed class AreaQuestAreaReleaseConditionDescriptionMaster : 
    BaseMaster<AreaQuestAreaReleaseConditionDescriptionData>
  {
    [Token(Token = "0x6006201")]
    [Address(RVA = "0x4ADB878", Offset = "0x4ADB878", VA = "0x4ADB878")]
    public IReadOnlyDictionary<int, AreaQuestAreaReleaseConditionDescriptionData> GetEntities()
    {
      return (IReadOnlyDictionary<int, AreaQuestAreaReleaseConditionDescriptionData>) null;
    }

    [Token(Token = "0x6006202")]
    [Address(RVA = "0x4ADB880", Offset = "0x4ADB880", VA = "0x4ADB880", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006203")]
    [Address(RVA = "0x4ADB8E0", Offset = "0x4ADB8E0", VA = "0x4ADB8E0", Slot = "5")]
    protected override AreaQuestAreaReleaseConditionDescriptionData LoadEntity(
      IMasterDataReader reader)
    {
      return (AreaQuestAreaReleaseConditionDescriptionData) null;
    }

    [Token(Token = "0x6006204")]
    [Address(RVA = "0x4ADB938", Offset = "0x4ADB938", VA = "0x4ADB938")]
    public AreaQuestAreaReleaseConditionDescriptionMaster()
    {
    }
  }
}
