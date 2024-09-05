// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.AccessoriesExpMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000F38")]
  [Serializable]
  public sealed class AccessoriesExpMaster : BaseMaster<AccessoriesExpData>
  {
    [Token(Token = "0x4004C3E")]
    [FieldOffset(Offset = "0x18")]
    private List<AccessoriesExpData> expList;

    [Token(Token = "0x60059B5")]
    [Address(RVA = "0x3C33D10", Offset = "0x3C33D10", VA = "0x3C33D10")]
    public IReadOnlyDictionary<int, AccessoriesExpData> GetEntities()
    {
      return (IReadOnlyDictionary<int, AccessoriesExpData>) null;
    }

    [Token(Token = "0x60059B6")]
    [Address(RVA = "0x3C33D18", Offset = "0x3C33D18", VA = "0x3C33D18", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x60059B7")]
    [Address(RVA = "0x3C33F64", Offset = "0x3C33F64", VA = "0x3C33F64", Slot = "5")]
    protected override AccessoriesExpData LoadEntity(IMasterDataReader reader)
    {
      return (AccessoriesExpData) null;
    }

    [Token(Token = "0x60059B8")]
    [Address(RVA = "0x3C33D88", Offset = "0x3C33D88", VA = "0x3C33D88")]
    private void OnAwakeLoading()
    {
    }

    [Token(Token = "0x60059B9")]
    [Address(RVA = "0x3C33FD4", Offset = "0x3C33FD4", VA = "0x3C33FD4")]
    private void OnLoadEntity(AccessoriesExpData entity)
    {
    }

    [Token(Token = "0x60059BA")]
    [Address(RVA = "0x3C33E64", Offset = "0x3C33E64", VA = "0x3C33E64")]
    private void OnCompletedLoading()
    {
    }

    [Token(Token = "0x60059BB")]
    [Address(RVA = "0x3C34084", Offset = "0x3C34084", VA = "0x3C34084")]
    public AccessoriesExpData GetData(int level) => (AccessoriesExpData) null;

    [Token(Token = "0x60059BC")]
    [Address(RVA = "0x3C3410C", Offset = "0x3C3410C", VA = "0x3C3410C")]
    public AccessoriesExpData GetDataByExp(int exp) => (AccessoriesExpData) null;

    [Token(Token = "0x60059BD")]
    [Address(RVA = "0x3C341EC", Offset = "0x3C341EC", VA = "0x3C341EC")]
    public IReadOnlyCollection<AccessoriesExpData> GetList(int startLevel, int endLevel)
    {
      return (IReadOnlyCollection<AccessoriesExpData>) null;
    }

    [Token(Token = "0x60059BE")]
    [Address(RVA = "0x3C34308", Offset = "0x3C34308", VA = "0x3C34308")]
    public IReadOnlyCollection<AccessoriesExpData> GetListByExp(int exp1, int exp2)
    {
      return (IReadOnlyCollection<AccessoriesExpData>) null;
    }

    [Token(Token = "0x60059BF")]
    [Address(RVA = "0x3C34408", Offset = "0x3C34408", VA = "0x3C34408")]
    public AccessoriesExpData GetDataByMaxExp() => (AccessoriesExpData) null;

    [Token(Token = "0x60059C0")]
    [Address(RVA = "0x3C34450", Offset = "0x3C34450", VA = "0x3C34450")]
    public AccessoriesExpMaster()
    {
    }
  }
}
