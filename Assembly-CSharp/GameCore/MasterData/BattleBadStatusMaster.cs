// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.BattleBadStatusMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000E03")]
  [Serializable]
  public sealed class BattleBadStatusMaster : BaseMaster<BattleBadStatusData>
  {
    [Token(Token = "0x40042E9")]
    [FieldOffset(Offset = "0x18")]
    private List<string> allIconAssetNames;
    [Token(Token = "0x40042EA")]
    [FieldOffset(Offset = "0x20")]
    private List<string> allEffectAssetNames;

    [Token(Token = "0x6005577")]
    [Address(RVA = "0x3AB0D6C", Offset = "0x3AB0D6C", VA = "0x3AB0D6C")]
    public IReadOnlyDictionary<int, BattleBadStatusData> GetEntities()
    {
      return (IReadOnlyDictionary<int, BattleBadStatusData>) null;
    }

    [Token(Token = "0x6005578")]
    [Address(RVA = "0x3AB0D74", Offset = "0x3AB0D74", VA = "0x3AB0D74", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005579")]
    [Address(RVA = "0x3AB0DD4", Offset = "0x3AB0DD4", VA = "0x3AB0DD4", Slot = "5")]
    protected override BattleBadStatusData LoadEntity(IMasterDataReader reader)
    {
      return (BattleBadStatusData) null;
    }

    [Token(Token = "0x600557A")]
    [Address(RVA = "0x3AB0E44", Offset = "0x3AB0E44", VA = "0x3AB0E44")]
    private void OnLoadEntity(BattleBadStatusData entity)
    {
    }

    [Token(Token = "0x17000C43")]
    public IReadOnlyList<string> AllIconAssetNames
    {
      [Token(Token = "0x600557B"), Address(RVA = "0x3AB1040", Offset = "0x3AB1040", VA = "0x3AB1040")] get
      {
        return (IReadOnlyList<string>) null;
      }
    }

    [Token(Token = "0x17000C44")]
    public IReadOnlyList<string> AllEffectAssetNames
    {
      [Token(Token = "0x600557C"), Address(RVA = "0x3AB1048", Offset = "0x3AB1048", VA = "0x3AB1048")] get
      {
        return (IReadOnlyList<string>) null;
      }
    }

    [Token(Token = "0x600557D")]
    [Address(RVA = "0x3AB1050", Offset = "0x3AB1050", VA = "0x3AB1050")]
    public BattleBadStatusData FindFirstByType(BattleBadStatusTypeEnum type)
    {
      return (BattleBadStatusData) null;
    }

    [Token(Token = "0x600557E")]
    [Address(RVA = "0x3AB11D4", Offset = "0x3AB11D4", VA = "0x3AB11D4")]
    public BattleBadStatusData GetDataByBadStatusType(BattleBadStatusTypeEnum badStatus)
    {
      return (BattleBadStatusData) null;
    }

    [Token(Token = "0x600557F")]
    [Address(RVA = "0x3AB1358", Offset = "0x3AB1358", VA = "0x3AB1358")]
    public BattleBadStatusMaster()
    {
    }
  }
}
