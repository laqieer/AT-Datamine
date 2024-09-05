// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.WeaponProficiencyLevelMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001385")]
  [Serializable]
  public sealed class WeaponProficiencyLevelMaster : BaseMaster<WeaponProficiencyLevelData>
  {
    [Token(Token = "0x4005B54")]
    [FieldOffset(Offset = "0x18")]
    private IReadOnlyList<WeaponProficiencyLevelData> levelList;

    [Token(Token = "0x6006DCF")]
    [Address(RVA = "0x46FFE80", Offset = "0x46FFE80", VA = "0x46FFE80")]
    public IReadOnlyDictionary<int, WeaponProficiencyLevelData> GetEntities()
    {
      return (IReadOnlyDictionary<int, WeaponProficiencyLevelData>) null;
    }

    [Token(Token = "0x6006DD0")]
    [Address(RVA = "0x46FFE88", Offset = "0x46FFE88", VA = "0x46FFE88", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006DD1")]
    [Address(RVA = "0x47001F4", Offset = "0x47001F4", VA = "0x47001F4", Slot = "5")]
    protected override WeaponProficiencyLevelData LoadEntity(IMasterDataReader reader)
    {
      return (WeaponProficiencyLevelData) null;
    }

    [Token(Token = "0x6006DD2")]
    [Address(RVA = "0x46FFEF0", Offset = "0x46FFEF0", VA = "0x46FFEF0")]
    private void OnCompletedLoading()
    {
    }

    [Token(Token = "0x6006DD3")]
    [Address(RVA = "0x470024C", Offset = "0x470024C", VA = "0x470024C")]
    public WeaponProficiencyLevelData GetData(ProficiencyTypeEnum proficiencyRank)
    {
      return (WeaponProficiencyLevelData) null;
    }

    [Token(Token = "0x6006DD4")]
    [Address(RVA = "0x4700354", Offset = "0x4700354", VA = "0x4700354")]
    public WeaponProficiencyLevelData GetDataByExp(int exp) => (WeaponProficiencyLevelData) null;

    [Token(Token = "0x6006DD5")]
    [Address(RVA = "0x470045C", Offset = "0x470045C", VA = "0x470045C")]
    public IReadOnlyCollection<WeaponProficiencyLevelData> GetList(
      ProficiencyTypeEnum startRank,
      ProficiencyTypeEnum endRank)
    {
      return (IReadOnlyCollection<WeaponProficiencyLevelData>) null;
    }

    [Token(Token = "0x6006DD6")]
    [Address(RVA = "0x4700578", Offset = "0x4700578", VA = "0x4700578")]
    public IReadOnlyCollection<WeaponProficiencyLevelData> GetListByExp(int exp1, int exp2)
    {
      return (IReadOnlyCollection<WeaponProficiencyLevelData>) null;
    }

    [Token(Token = "0x6006DD7")]
    [Address(RVA = "0x4700678", Offset = "0x4700678", VA = "0x4700678")]
    public WeaponProficiencyLevelData GetMin() => (WeaponProficiencyLevelData) null;

    [Token(Token = "0x6006DD8")]
    [Address(RVA = "0x47006C0", Offset = "0x47006C0", VA = "0x47006C0")]
    public WeaponProficiencyLevelData GetMax() => (WeaponProficiencyLevelData) null;

    [Token(Token = "0x6006DD9")]
    [Address(RVA = "0x4700708", Offset = "0x4700708", VA = "0x4700708")]
    public WeaponProficiencyLevelMaster()
    {
    }
  }
}
