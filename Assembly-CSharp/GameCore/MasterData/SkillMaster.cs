// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.SkillMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20011BC")]
  [Serializable]
  public sealed class SkillMaster : BaseMaster<SkillData>
  {
    [Token(Token = "0x400555C")]
    public const string TEXT_AB = "text_masterdata_skill";

    [Token(Token = "0x600658C")]
    [Address(RVA = "0x4D1C91C", Offset = "0x4D1C91C", VA = "0x4D1C91C")]
    public IReadOnlyDictionary<int, SkillData> GetEntities()
    {
      return (IReadOnlyDictionary<int, SkillData>) null;
    }

    [Token(Token = "0x600658D")]
    [Address(RVA = "0x4D1C924", Offset = "0x4D1C924", VA = "0x4D1C924", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x600658E")]
    [Address(RVA = "0x4D1C984", Offset = "0x4D1C984", VA = "0x4D1C984", Slot = "5")]
    protected override SkillData LoadEntity(IMasterDataReader reader) => (SkillData) null;

    [Token(Token = "0x600658F")]
    [Address(RVA = "0x4D1C9DC", Offset = "0x4D1C9DC", VA = "0x4D1C9DC")]
    public Dictionary<int, SkillData>.ValueCollection GetList()
    {
      return (Dictionary<int, SkillData>.ValueCollection) null;
    }

    [Token(Token = "0x6006590")]
    [Address(RVA = "0x4D1CA2C", Offset = "0x4D1CA2C", VA = "0x4D1CA2C")]
    public SkillMaster()
    {
    }
  }
}
