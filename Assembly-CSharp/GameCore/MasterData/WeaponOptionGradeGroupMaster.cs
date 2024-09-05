// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.WeaponOptionGradeGroupMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000F8A")]
  [Serializable]
  public sealed class WeaponOptionGradeGroupMaster : BaseMaster<WeaponOptionGradeGroupData>
  {
    [Token(Token = "0x6005B57")]
    [Address(RVA = "0x27816B4", Offset = "0x27816B4", VA = "0x27816B4")]
    public IReadOnlyDictionary<int, WeaponOptionGradeGroupData> GetEntities()
    {
      return (IReadOnlyDictionary<int, WeaponOptionGradeGroupData>) null;
    }

    [Token(Token = "0x6005B58")]
    [Address(RVA = "0x27816BC", Offset = "0x27816BC", VA = "0x27816BC", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005B59")]
    [Address(RVA = "0x278171C", Offset = "0x278171C", VA = "0x278171C", Slot = "5")]
    protected override WeaponOptionGradeGroupData LoadEntity(IMasterDataReader reader)
    {
      return (WeaponOptionGradeGroupData) null;
    }

    [Token(Token = "0x6005B5A")]
    [Address(RVA = "0x2781774", Offset = "0x2781774", VA = "0x2781774")]
    public IReadOnlyCollection<WeaponOptionGradeGroupData> GetList()
    {
      return (IReadOnlyCollection<WeaponOptionGradeGroupData>) null;
    }

    [Token(Token = "0x6005B5B")]
    [Address(RVA = "0x27817C4", Offset = "0x27817C4", VA = "0x27817C4")]
    public WeaponOptionGradeGroupMaster()
    {
    }
  }
}
