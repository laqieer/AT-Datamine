// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.AreaQuestAreaReleaseConditionMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001101")]
  [Serializable]
  public sealed class AreaQuestAreaReleaseConditionMaster : 
    BaseMaster<AreaQuestAreaReleaseConditionData>
  {
    [Token(Token = "0x600620D")]
    [Address(RVA = "0x4ADBC20", Offset = "0x4ADBC20", VA = "0x4ADBC20")]
    public IReadOnlyDictionary<int, AreaQuestAreaReleaseConditionData> GetEntities()
    {
      return (IReadOnlyDictionary<int, AreaQuestAreaReleaseConditionData>) null;
    }

    [Token(Token = "0x600620E")]
    [Address(RVA = "0x4ADBC28", Offset = "0x4ADBC28", VA = "0x4ADBC28", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x600620F")]
    [Address(RVA = "0x4ADBC88", Offset = "0x4ADBC88", VA = "0x4ADBC88", Slot = "5")]
    protected override AreaQuestAreaReleaseConditionData LoadEntity(IMasterDataReader reader)
    {
      return (AreaQuestAreaReleaseConditionData) null;
    }

    [Token(Token = "0x6006210")]
    [Address(RVA = "0x4ADBCE0", Offset = "0x4ADBCE0", VA = "0x4ADBCE0")]
    public AreaQuestAreaReleaseConditionMaster()
    {
    }
  }
}
