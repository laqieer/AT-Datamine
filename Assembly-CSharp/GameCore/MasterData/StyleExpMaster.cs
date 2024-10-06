// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StyleExpMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20013B1")]
  [Serializable]
  public sealed class StyleExpMaster : BaseMaster<StyleExpData>
  {
    [Token(Token = "0x4005BBC")]
    [FieldOffset(Offset = "0x18")]
    private Dictionary<int, StyleExpData> expTable;

    [Token(Token = "0x6006E9A")]
    [Address(RVA = "0x4708564", Offset = "0x4708564", VA = "0x4708564")]
    public IReadOnlyDictionary<int, StyleExpData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StyleExpData>) null;
    }

    [Token(Token = "0x6006E9B")]
    [Address(RVA = "0x470856C", Offset = "0x470856C", VA = "0x470856C", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006E9C")]
    [Address(RVA = "0x47085CC", Offset = "0x47085CC", VA = "0x47085CC", Slot = "5")]
    protected override StyleExpData LoadEntity(IMasterDataReader reader) => (StyleExpData) null;

    [Token(Token = "0x6006E9D")]
    [Address(RVA = "0x470863C", Offset = "0x470863C", VA = "0x470863C")]
    private void OnLoadEntity(StyleExpData entity)
    {
    }

    [Token(Token = "0x6006E9E")]
    [Address(RVA = "0x4708640", Offset = "0x4708640", VA = "0x4708640")]
    private void GroupingByRarity(StyleExpData entity)
    {
    }

    [Token(Token = "0x6006E9F")]
    [Address(RVA = "0x47086E4", Offset = "0x47086E4", VA = "0x47086E4")]
    public StyleExpData GetDataByRarity(int rarity) => (StyleExpData) null;

    [Token(Token = "0x6006EA0")]
    [Address(RVA = "0x470875C", Offset = "0x470875C", VA = "0x470875C")]
    public StyleExpMaster()
    {
    }
  }
}
