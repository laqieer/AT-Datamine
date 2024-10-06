// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.CustomSkillCategoryMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20011A5")]
  [Serializable]
  public sealed class CustomSkillCategoryMaster : BaseMaster<CustomSkillCategoryData>
  {
    [Token(Token = "0x6006521")]
    [Address(RVA = "0x4AF6048", Offset = "0x4AF6048", VA = "0x4AF6048")]
    public IReadOnlyDictionary<int, CustomSkillCategoryData> GetEntities()
    {
      return (IReadOnlyDictionary<int, CustomSkillCategoryData>) null;
    }

    [Token(Token = "0x6006522")]
    [Address(RVA = "0x4AF6050", Offset = "0x4AF6050", VA = "0x4AF6050", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006523")]
    [Address(RVA = "0x4AF60B0", Offset = "0x4AF60B0", VA = "0x4AF60B0", Slot = "5")]
    protected override CustomSkillCategoryData LoadEntity(IMasterDataReader reader)
    {
      return (CustomSkillCategoryData) null;
    }

    [Token(Token = "0x6006524")]
    [Address(RVA = "0x4AF6108", Offset = "0x4AF6108", VA = "0x4AF6108")]
    public CustomSkillCategoryMaster()
    {
    }
  }
}
