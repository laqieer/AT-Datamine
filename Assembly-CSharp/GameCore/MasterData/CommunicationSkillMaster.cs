// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.CommunicationSkillMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200136B")]
  [Serializable]
  public sealed class CommunicationSkillMaster : BaseMaster<CommunicationSkillData>
  {
    [Token(Token = "0x6006D57")]
    [Address(RVA = "0x46FC0D0", Offset = "0x46FC0D0", VA = "0x46FC0D0")]
    public IReadOnlyDictionary<int, CommunicationSkillData> GetEntities()
    {
      return (IReadOnlyDictionary<int, CommunicationSkillData>) null;
    }

    [Token(Token = "0x6006D58")]
    [Address(RVA = "0x46FC0D8", Offset = "0x46FC0D8", VA = "0x46FC0D8", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006D59")]
    [Address(RVA = "0x46FC138", Offset = "0x46FC138", VA = "0x46FC138", Slot = "5")]
    protected override CommunicationSkillData LoadEntity(IMasterDataReader reader)
    {
      return (CommunicationSkillData) null;
    }

    [Token(Token = "0x6006D5A")]
    [Address(RVA = "0x46FC190", Offset = "0x46FC190", VA = "0x46FC190")]
    public List<CommunicationSkillData> GetCommunicationSkillData(int characterId)
    {
      return (List<CommunicationSkillData>) null;
    }

    [Token(Token = "0x6006D5B")]
    [Address(RVA = "0x46FC2B4", Offset = "0x46FC2B4", VA = "0x46FC2B4")]
    public CommunicationSkillMaster()
    {
    }
  }
}
