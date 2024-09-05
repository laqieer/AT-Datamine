// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.MindEquipmentMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000F64")]
  [Serializable]
  public sealed class MindEquipmentMaster : BaseMaster<MindEquipmentData>
  {
    [Token(Token = "0x4004D2E")]
    public const string TEXT_AB = "text_masterdata_equipment";

    [Token(Token = "0x6005A88")]
    [Address(RVA = "0x3C3EFB0", Offset = "0x3C3EFB0", VA = "0x3C3EFB0")]
    public IReadOnlyDictionary<int, MindEquipmentData> GetEntities()
    {
      return (IReadOnlyDictionary<int, MindEquipmentData>) null;
    }

    [Token(Token = "0x6005A89")]
    [Address(RVA = "0x3C3EFB8", Offset = "0x3C3EFB8", VA = "0x3C3EFB8", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005A8A")]
    [Address(RVA = "0x3C3F018", Offset = "0x3C3F018", VA = "0x3C3F018", Slot = "5")]
    protected override MindEquipmentData LoadEntity(IMasterDataReader reader)
    {
      return (MindEquipmentData) null;
    }

    [Token(Token = "0x6005A8B")]
    [Address(RVA = "0x3C3F070", Offset = "0x3C3F070", VA = "0x3C3F070")]
    public IReadOnlyCollection<MindEquipmentData> GetList()
    {
      return (IReadOnlyCollection<MindEquipmentData>) null;
    }

    [Token(Token = "0x6005A8C")]
    [Address(RVA = "0x3C3F0C0", Offset = "0x3C3F0C0", VA = "0x3C3F0C0")]
    public MindEquipmentMaster()
    {
    }
  }
}
