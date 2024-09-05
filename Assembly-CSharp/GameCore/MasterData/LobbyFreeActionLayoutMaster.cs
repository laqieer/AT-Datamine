// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.LobbyFreeActionLayoutMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200107C")]
  [Serializable]
  public sealed class LobbyFreeActionLayoutMaster : BaseMaster<LobbyFreeActionLayoutData>
  {
    [Token(Token = "0x4005181")]
    [FieldOffset(Offset = "0x18")]
    private Dictionary<int, List<LobbyFreeActionLayoutData>> groupingTable;

    [Token(Token = "0x6005F99")]
    [Address(RVA = "0x28CFDA4", Offset = "0x28CFDA4", VA = "0x28CFDA4")]
    public IReadOnlyDictionary<int, LobbyFreeActionLayoutData> GetEntities()
    {
      return (IReadOnlyDictionary<int, LobbyFreeActionLayoutData>) null;
    }

    [Token(Token = "0x6005F9A")]
    [Address(RVA = "0x28CFDAC", Offset = "0x28CFDAC", VA = "0x28CFDAC", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005F9B")]
    [Address(RVA = "0x28CFE64", Offset = "0x28CFE64", VA = "0x28CFE64", Slot = "5")]
    protected override LobbyFreeActionLayoutData LoadEntity(IMasterDataReader reader)
    {
      return (LobbyFreeActionLayoutData) null;
    }

    [Token(Token = "0x6005F9C")]
    [Address(RVA = "0x28CFE14", Offset = "0x28CFE14", VA = "0x28CFE14")]
    private void OnAwakeLoading()
    {
    }

    [Token(Token = "0x6005F9D")]
    [Address(RVA = "0x28CFED4", Offset = "0x28CFED4", VA = "0x28CFED4")]
    private void OnLoadEntity(LobbyFreeActionLayoutData entity)
    {
    }

    [Token(Token = "0x6005F9E")]
    [Address(RVA = "0x28D0094", Offset = "0x28D0094", VA = "0x28D0094")]
    public IReadOnlyList<LobbyFreeActionLayoutData> GetListByGroupLabel(int layoutGroupLabel)
    {
      return (IReadOnlyList<LobbyFreeActionLayoutData>) null;
    }

    [Token(Token = "0x6005F9F")]
    [Address(RVA = "0x28D0150", Offset = "0x28D0150", VA = "0x28D0150")]
    public IEnumerable<LobbyFreeActionLayoutData> GetListByCondition(
      int layoutGroupLabel,
      int chapterID,
      DateTime time)
    {
      return (IEnumerable<LobbyFreeActionLayoutData>) null;
    }

    [Token(Token = "0x6005FA0")]
    [Address(RVA = "0x28D0254", Offset = "0x28D0254", VA = "0x28D0254")]
    public LobbyFreeActionLayoutMaster()
    {
    }
  }
}
