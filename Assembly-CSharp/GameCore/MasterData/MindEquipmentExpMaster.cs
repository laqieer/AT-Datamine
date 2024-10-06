// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.MindEquipmentExpMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000F5B")]
  [Serializable]
  public sealed class MindEquipmentExpMaster : BaseMaster<MindEquipmentExpData>
  {
    [Token(Token = "0x4004D1A")]
    [FieldOffset(Offset = "0x18")]
    private List<MindEquipmentExpData> expList;

    [Token(Token = "0x6005A5F")]
    [Address(RVA = "0x3C3DA64", Offset = "0x3C3DA64", VA = "0x3C3DA64")]
    public IReadOnlyDictionary<int, MindEquipmentExpData> GetEntities()
    {
      return (IReadOnlyDictionary<int, MindEquipmentExpData>) null;
    }

    [Token(Token = "0x6005A60")]
    [Address(RVA = "0x3C3DA6C", Offset = "0x3C3DA6C", VA = "0x3C3DA6C", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005A61")]
    [Address(RVA = "0x3C3DCB8", Offset = "0x3C3DCB8", VA = "0x3C3DCB8", Slot = "5")]
    protected override MindEquipmentExpData LoadEntity(IMasterDataReader reader)
    {
      return (MindEquipmentExpData) null;
    }

    [Token(Token = "0x6005A62")]
    [Address(RVA = "0x3C3DADC", Offset = "0x3C3DADC", VA = "0x3C3DADC")]
    private void OnAwakeLoading()
    {
    }

    [Token(Token = "0x6005A63")]
    [Address(RVA = "0x3C3DD28", Offset = "0x3C3DD28", VA = "0x3C3DD28")]
    private void OnLoadEntity(MindEquipmentExpData entity)
    {
    }

    [Token(Token = "0x6005A64")]
    [Address(RVA = "0x3C3DBB8", Offset = "0x3C3DBB8", VA = "0x3C3DBB8")]
    private void OnCompletedLoading()
    {
    }

    [Token(Token = "0x6005A65")]
    [Address(RVA = "0x3C3DDD8", Offset = "0x3C3DDD8", VA = "0x3C3DDD8")]
    public MindEquipmentExpData GetData(int level) => (MindEquipmentExpData) null;

    [Token(Token = "0x6005A66")]
    [Address(RVA = "0x3C3DE60", Offset = "0x3C3DE60", VA = "0x3C3DE60")]
    public MindEquipmentExpData GetDataByExp(int exp) => (MindEquipmentExpData) null;

    [Token(Token = "0x6005A67")]
    [Address(RVA = "0x3C3DF8C", Offset = "0x3C3DF8C", VA = "0x3C3DF8C")]
    public IReadOnlyCollection<MindEquipmentExpData> GetList(int startLevel, int endLevel)
    {
      return (IReadOnlyCollection<MindEquipmentExpData>) null;
    }

    [Token(Token = "0x6005A68")]
    [Address(RVA = "0x3C3E0A8", Offset = "0x3C3E0A8", VA = "0x3C3E0A8")]
    public IReadOnlyCollection<MindEquipmentExpData> GetListByExp(int exp1, int exp2)
    {
      return (IReadOnlyCollection<MindEquipmentExpData>) null;
    }

    [Token(Token = "0x6005A69")]
    [Address(RVA = "0x3C3E1A8", Offset = "0x3C3E1A8", VA = "0x3C3E1A8")]
    public MindEquipmentExpMaster()
    {
    }
  }
}
