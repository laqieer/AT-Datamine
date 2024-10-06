// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.CustomSkillMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20011A9")]
  [Serializable]
  public sealed class CustomSkillMaster : BaseMaster<CustomSkillData>
  {
    [Token(Token = "0x6006533")]
    [Address(RVA = "0x4AF68A4", Offset = "0x4AF68A4", VA = "0x4AF68A4")]
    public IReadOnlyDictionary<int, CustomSkillData> GetEntities()
    {
      return (IReadOnlyDictionary<int, CustomSkillData>) null;
    }

    [Token(Token = "0x6006534")]
    [Address(RVA = "0x4AF68AC", Offset = "0x4AF68AC", VA = "0x4AF68AC", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006535")]
    [Address(RVA = "0x4AF690C", Offset = "0x4AF690C", VA = "0x4AF690C", Slot = "5")]
    protected override CustomSkillData LoadEntity(IMasterDataReader reader)
    {
      return (CustomSkillData) null;
    }

    [Token(Token = "0x6006536")]
    [Address(RVA = "0x4AF6964", Offset = "0x4AF6964", VA = "0x4AF6964")]
    public CustomSkillMaster()
    {
    }
  }
}
