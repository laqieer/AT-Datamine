// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.AdvOptionOneMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000DB9")]
  [Serializable]
  public sealed class AdvOptionOneMaster : BaseMaster<AdvOptionOneData>
  {
    [Token(Token = "0x40041B0")]
    [FieldOffset(Offset = "0x18")]
    private Dictionary<int, List<AdvOptionOneData>> optionTable;

    [Token(Token = "0x60053EF")]
    [Address(RVA = "0x3A9F338", Offset = "0x3A9F338", VA = "0x3A9F338")]
    public IReadOnlyDictionary<int, AdvOptionOneData> GetEntities()
    {
      return (IReadOnlyDictionary<int, AdvOptionOneData>) null;
    }

    [Token(Token = "0x60053F0")]
    [Address(RVA = "0x3A9F340", Offset = "0x3A9F340", VA = "0x3A9F340", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x60053F1")]
    [Address(RVA = "0x3A9F3F8", Offset = "0x3A9F3F8", VA = "0x3A9F3F8", Slot = "5")]
    protected override AdvOptionOneData LoadEntity(IMasterDataReader reader)
    {
      return (AdvOptionOneData) null;
    }

    [Token(Token = "0x60053F2")]
    [Address(RVA = "0x3A9F3A8", Offset = "0x3A9F3A8", VA = "0x3A9F3A8")]
    private void OnAwakeLoading()
    {
    }

    [Token(Token = "0x60053F3")]
    [Address(RVA = "0x3A9F468", Offset = "0x3A9F468", VA = "0x3A9F468")]
    private void OnLoadEntity(AdvOptionOneData entity)
    {
    }

    [Token(Token = "0x60053F4")]
    [Address(RVA = "0x3A9F5E4", Offset = "0x3A9F5E4", VA = "0x3A9F5E4")]
    public List<AdvOptionOneData> GetOptionOrderTable(int optionID)
    {
      return (List<AdvOptionOneData>) null;
    }

    [Token(Token = "0x60053F5")]
    [Address(RVA = "0x3A9F6A0", Offset = "0x3A9F6A0", VA = "0x3A9F6A0")]
    public IEnumerable<IEnumerable<AdvOptionOneData>> GetOptionList(int optionID)
    {
      return (IEnumerable<IEnumerable<AdvOptionOneData>>) null;
    }

    [Token(Token = "0x60053F6")]
    [Address(RVA = "0x3A9F9D8", Offset = "0x3A9F9D8", VA = "0x3A9F9D8")]
    public AdvOptionOneMaster()
    {
    }
  }
}
