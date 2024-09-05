// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.WeaponExpMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000F70")]
  [Serializable]
  public sealed class WeaponExpMaster : BaseMaster<WeaponExpData>
  {
    [Token(Token = "0x4004DDA")]
    [FieldOffset(Offset = "0x18")]
    private List<WeaponExpData> expList;

    [Token(Token = "0x6005ADD")]
    [Address(RVA = "0x277B6A0", Offset = "0x277B6A0", VA = "0x277B6A0")]
    public IReadOnlyDictionary<int, WeaponExpData> GetEntities()
    {
      return (IReadOnlyDictionary<int, WeaponExpData>) null;
    }

    [Token(Token = "0x6005ADE")]
    [Address(RVA = "0x277B6A8", Offset = "0x277B6A8", VA = "0x277B6A8", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005ADF")]
    [Address(RVA = "0x277B7EC", Offset = "0x277B7EC", VA = "0x277B7EC", Slot = "5")]
    protected override WeaponExpData LoadEntity(IMasterDataReader reader) => (WeaponExpData) null;

    [Token(Token = "0x6005AE0")]
    [Address(RVA = "0x277B710", Offset = "0x277B710", VA = "0x277B710")]
    private void OnAwakeLoading()
    {
    }

    [Token(Token = "0x6005AE1")]
    [Address(RVA = "0x277B85C", Offset = "0x277B85C", VA = "0x277B85C")]
    private void OnLoadEntity(WeaponExpData entity)
    {
    }

    [Token(Token = "0x6005AE2")]
    [Address(RVA = "0x277B90C", Offset = "0x277B90C", VA = "0x277B90C")]
    public WeaponExpData GetData(int level) => (WeaponExpData) null;

    [Token(Token = "0x6005AE3")]
    [Address(RVA = "0x277B994", Offset = "0x277B994", VA = "0x277B994")]
    public WeaponExpData GetDataByExp(int exp) => (WeaponExpData) null;

    [Token(Token = "0x6005AE4")]
    [Address(RVA = "0x277BA74", Offset = "0x277BA74", VA = "0x277BA74")]
    public IReadOnlyList<WeaponExpData> GetList(int startLevel, int endLevel)
    {
      return (IReadOnlyList<WeaponExpData>) null;
    }

    [Token(Token = "0x6005AE5")]
    [Address(RVA = "0x277BB90", Offset = "0x277BB90", VA = "0x277BB90")]
    public IReadOnlyList<WeaponExpData> GetListByExp(int exp1, int exp2)
    {
      return (IReadOnlyList<WeaponExpData>) null;
    }

    [Token(Token = "0x6005AE6")]
    [Address(RVA = "0x277BC90", Offset = "0x277BC90", VA = "0x277BC90")]
    public WeaponExpData GetDataByMaxExp() => (WeaponExpData) null;

    [Token(Token = "0x6005AE7")]
    [Address(RVA = "0x277BCD8", Offset = "0x277BCD8", VA = "0x277BCD8")]
    public WeaponExpMaster()
    {
    }
  }
}
