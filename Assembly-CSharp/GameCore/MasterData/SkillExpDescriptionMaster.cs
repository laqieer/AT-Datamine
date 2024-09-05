// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.SkillExpDescriptionMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20011BA")]
  [Serializable]
  public sealed class SkillExpDescriptionMaster : BaseMaster<SkillExpDescriptionData>
  {
    [Token(Token = "0x4005556")]
    [FieldOffset(Offset = "0x18")]
    private Dictionary<int, List<SkillExpDescriptionData>> mapByGroup;

    [Token(Token = "0x6006580")]
    [Address(RVA = "0x4D1C0F8", Offset = "0x4D1C0F8", VA = "0x4D1C0F8")]
    public IReadOnlyDictionary<int, SkillExpDescriptionData> GetEntities()
    {
      return (IReadOnlyDictionary<int, SkillExpDescriptionData>) null;
    }

    [Token(Token = "0x6006581")]
    [Address(RVA = "0x4D1C100", Offset = "0x4D1C100", VA = "0x4D1C100", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006582")]
    [Address(RVA = "0x4D1C160", Offset = "0x4D1C160", VA = "0x4D1C160", Slot = "5")]
    protected override SkillExpDescriptionData LoadEntity(IMasterDataReader reader)
    {
      return (SkillExpDescriptionData) null;
    }

    [Token(Token = "0x6006583")]
    [Address(RVA = "0x4D1C1D0", Offset = "0x4D1C1D0", VA = "0x4D1C1D0")]
    private void OnLoadEntity(SkillExpDescriptionData entity)
    {
    }

    [Token(Token = "0x6006584")]
    [Address(RVA = "0x4D1C324", Offset = "0x4D1C324", VA = "0x4D1C324")]
    public SkillExpDescriptionData GetByGroupAndValue(int groupId, int value)
    {
      return (SkillExpDescriptionData) null;
    }

    [Token(Token = "0x6006585")]
    [Address(RVA = "0x4D1C4D4", Offset = "0x4D1C4D4", VA = "0x4D1C4D4")]
    public List<SkillExpDescriptionData> GetByGroup(int groupId)
    {
      return (List<SkillExpDescriptionData>) null;
    }

    [Token(Token = "0x6006586")]
    [Address(RVA = "0x4D1C54C", Offset = "0x4D1C54C", VA = "0x4D1C54C")]
    public IReadOnlyCollection<SkillExpDescriptionData> GetList()
    {
      return (IReadOnlyCollection<SkillExpDescriptionData>) null;
    }

    [Token(Token = "0x6006587")]
    [Address(RVA = "0x4D1C59C", Offset = "0x4D1C59C", VA = "0x4D1C59C")]
    public SkillExpDescriptionMaster()
    {
    }
  }
}
