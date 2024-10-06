// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.CharacterLimitReleaseDetailMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using StaqData;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001365")]
  [Serializable]
  public sealed class CharacterLimitReleaseDetailMaster : BaseMaster<CharacterLimitReleaseDetailData>
  {
    [Token(Token = "0x4005B0D")]
    [FieldOffset(Offset = "0x18")]
    private Dictionary<int, List<CharacterLimitReleaseDetailData>> descriptionTable;

    [Token(Token = "0x6006D3A")]
    [Address(RVA = "0x46FAFD0", Offset = "0x46FAFD0", VA = "0x46FAFD0")]
    public IReadOnlyDictionary<int, CharacterLimitReleaseDetailData> GetEntities()
    {
      return (IReadOnlyDictionary<int, CharacterLimitReleaseDetailData>) null;
    }

    [Token(Token = "0x6006D3B")]
    [Address(RVA = "0x46FAFD8", Offset = "0x46FAFD8", VA = "0x46FAFD8", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006D3C")]
    [Address(RVA = "0x46FB29C", Offset = "0x46FB29C", VA = "0x46FB29C", Slot = "5")]
    protected override CharacterLimitReleaseDetailData LoadEntity(IMasterDataReader reader)
    {
      return (CharacterLimitReleaseDetailData) null;
    }

    [Token(Token = "0x6006D3D")]
    [Address(RVA = "0x46FB30C", Offset = "0x46FB30C", VA = "0x46FB30C")]
    private void OnLoadEntity(CharacterLimitReleaseDetailData entity)
    {
    }

    [Token(Token = "0x6006D3E")]
    [Address(RVA = "0x46FB040", Offset = "0x46FB040", VA = "0x46FB040")]
    private void OnCompletedLoading()
    {
    }

    [Token(Token = "0x6006D3F")]
    [Address(RVA = "0x46FB464", Offset = "0x46FB464", VA = "0x46FB464")]
    public IReadOnlyCollection<CharacterLimitReleaseDetailData> GetListByLimitRelease(
      int limitRelease)
    {
      return (IReadOnlyCollection<CharacterLimitReleaseDetailData>) null;
    }

    [Token(Token = "0x6006D40")]
    [Address(RVA = "0x46FB520", Offset = "0x46FB520", VA = "0x46FB520")]
    public IReadOnlyCollection<CharacterLimitReleaseDetailData> GetList()
    {
      return (IReadOnlyCollection<CharacterLimitReleaseDetailData>) null;
    }

    [Token(Token = "0x6006D41")]
    [Address(RVA = "0x46FB570", Offset = "0x46FB570", VA = "0x46FB570")]
    public CharacterLimitReleaseDetailData Get(Character character)
    {
      return (CharacterLimitReleaseDetailData) null;
    }

    [Token(Token = "0x6006D42")]
    [Address(RVA = "0x46FB66C", Offset = "0x46FB66C", VA = "0x46FB66C")]
    public CharacterLimitReleaseDetailMaster()
    {
    }
  }
}
