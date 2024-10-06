// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.CommonEffectListMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Effect;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000E87")]
  [Serializable]
  public sealed class CommonEffectListMaster : BaseMaster<CommonEffectListData>
  {
    [Token(Token = "0x4004618")]
    [FieldOffset(Offset = "0x20")]
    private Dictionary<string, EffectInfo> infoListByEffectName;
    [Token(Token = "0x400461A")]
    [FieldOffset(Offset = "0x30")]
    private List<string> assetBundleLabels;

    [Token(Token = "0x600586D")]
    [Address(RVA = "0x3E48D48", Offset = "0x3E48D48", VA = "0x3E48D48")]
    public IReadOnlyDictionary<int, CommonEffectListData> GetEntities()
    {
      return (IReadOnlyDictionary<int, CommonEffectListData>) null;
    }

    [Token(Token = "0x600586E")]
    [Address(RVA = "0x3E48D50", Offset = "0x3E48D50", VA = "0x3E48D50", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x600586F")]
    [Address(RVA = "0x3E48F68", Offset = "0x3E48F68", VA = "0x3E48F68", Slot = "5")]
    protected override CommonEffectListData LoadEntity(IMasterDataReader reader)
    {
      return (CommonEffectListData) null;
    }

    [Token(Token = "0x6005870")]
    [Address(RVA = "0x3E48DB8", Offset = "0x3E48DB8", VA = "0x3E48DB8")]
    private void OnAwakeLoading()
    {
    }

    [Token(Token = "0x6005871")]
    [Address(RVA = "0x3E48FD8", Offset = "0x3E48FD8", VA = "0x3E48FD8")]
    private void OnLoadEntity(CommonEffectListData entity)
    {
    }

    [Token(Token = "0x17000D23")]
    public ReadOnlyDictionary<string, EffectInfo> InfoListByEffectName
    {
      [Token(Token = "0x6005872"), Address(RVA = "0x3E4911C", Offset = "0x3E4911C", VA = "0x3E4911C")] get
      {
        return (ReadOnlyDictionary<string, EffectInfo>) null;
      }
      [Token(Token = "0x6005873"), Address(RVA = "0x3E49124", Offset = "0x3E49124", VA = "0x3E49124")] private set
      {
      }
    }

    [Token(Token = "0x17000D24")]
    public ReadOnlyCollection<string> AssetBundleLabels
    {
      [Token(Token = "0x6005874"), Address(RVA = "0x3E4912C", Offset = "0x3E4912C", VA = "0x3E4912C")] get
      {
        return (ReadOnlyCollection<string>) null;
      }
      [Token(Token = "0x6005875"), Address(RVA = "0x3E49134", Offset = "0x3E49134", VA = "0x3E49134")] private set
      {
      }
    }

    [Token(Token = "0x6005876")]
    [Address(RVA = "0x3E4913C", Offset = "0x3E4913C", VA = "0x3E4913C")]
    public CommonEffectListMaster()
    {
    }
  }
}
