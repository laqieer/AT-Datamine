// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.SubEquipmentClassificationGroupMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001381")]
  [Serializable]
  public sealed class SubEquipmentClassificationGroupMaster : 
    BaseMaster<SubEquipmentClassificationGroupData>
  {
    [Token(Token = "0x6006DBC")]
    [Address(RVA = "0x46FF5D4", Offset = "0x46FF5D4", VA = "0x46FF5D4")]
    public IReadOnlyDictionary<int, SubEquipmentClassificationGroupData> GetEntities()
    {
      return (IReadOnlyDictionary<int, SubEquipmentClassificationGroupData>) null;
    }

    [Token(Token = "0x6006DBD")]
    [Address(RVA = "0x46FF5DC", Offset = "0x46FF5DC", VA = "0x46FF5DC", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006DBE")]
    [Address(RVA = "0x46FF63C", Offset = "0x46FF63C", VA = "0x46FF63C", Slot = "5")]
    protected override SubEquipmentClassificationGroupData LoadEntity(IMasterDataReader reader)
    {
      return (SubEquipmentClassificationGroupData) null;
    }

    [Token(Token = "0x6006DBF")]
    [Address(RVA = "0x46FF694", Offset = "0x46FF694", VA = "0x46FF694")]
    public SubEquipmentClassificationGroupMaster()
    {
    }
  }
}
