// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.WeaponProficiencyDescriptionMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001383")]
  [Serializable]
  public sealed class WeaponProficiencyDescriptionMaster : 
    BaseMaster<WeaponProficiencyDescriptionData>
  {
    [Token(Token = "0x4005B4F")]
    [FieldOffset(Offset = "0x18")]
    private Dictionary<int, List<WeaponProficiencyDescriptionData>> descriptionTable;

    [Token(Token = "0x6006DC4")]
    [Address(RVA = "0x46FF880", Offset = "0x46FF880", VA = "0x46FF880")]
    public IReadOnlyDictionary<int, WeaponProficiencyDescriptionData> GetEntities()
    {
      return (IReadOnlyDictionary<int, WeaponProficiencyDescriptionData>) null;
    }

    [Token(Token = "0x6006DC5")]
    [Address(RVA = "0x46FF888", Offset = "0x46FF888", VA = "0x46FF888", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006DC6")]
    [Address(RVA = "0x46FF8E8", Offset = "0x46FF8E8", VA = "0x46FF8E8", Slot = "5")]
    protected override WeaponProficiencyDescriptionData LoadEntity(IMasterDataReader reader)
    {
      return (WeaponProficiencyDescriptionData) null;
    }

    [Token(Token = "0x6006DC7")]
    [Address(RVA = "0x46FF958", Offset = "0x46FF958", VA = "0x46FF958")]
    private void OnLoadEntity(WeaponProficiencyDescriptionData entity)
    {
    }

    [Token(Token = "0x6006DC8")]
    [Address(RVA = "0x46FF95C", Offset = "0x46FF95C", VA = "0x46FF95C")]
    private void GroupingByWeaponProficiencyId(WeaponProficiencyDescriptionData entity)
    {
    }

    [Token(Token = "0x6006DC9")]
    [Address(RVA = "0x46FFAB4", Offset = "0x46FFAB4", VA = "0x46FFAB4")]
    public IReadOnlyCollection<WeaponProficiencyDescriptionData> GetListByProficiencyId(
      int proficiencyId)
    {
      return (IReadOnlyCollection<WeaponProficiencyDescriptionData>) null;
    }

    [Token(Token = "0x6006DCA")]
    [Address(RVA = "0x46FFB70", Offset = "0x46FFB70", VA = "0x46FFB70")]
    public WeaponProficiencyDescriptionMaster()
    {
    }
  }
}
