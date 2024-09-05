// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StyleMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20013BE")]
  [Serializable]
  public sealed class StyleMaster : BaseMaster<StyleData>
  {
    [Token(Token = "0x4005BD2")]
    public const string TEXT_AB = "text_masterdata_unit";

    [Token(Token = "0x6006EDA")]
    [Address(RVA = "0x470A788", Offset = "0x470A788", VA = "0x470A788")]
    public IReadOnlyDictionary<int, StyleData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StyleData>) null;
    }

    [Token(Token = "0x6006EDB")]
    [Address(RVA = "0x470A790", Offset = "0x470A790", VA = "0x470A790", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006EDC")]
    [Address(RVA = "0x470A7F0", Offset = "0x470A7F0", VA = "0x470A7F0", Slot = "5")]
    protected override StyleData LoadEntity(IMasterDataReader reader) => (StyleData) null;

    [Token(Token = "0x6006EDD")]
    [Address(RVA = "0x470A860", Offset = "0x470A860", VA = "0x470A860")]
    private void OnLoadEntity(StyleData entity)
    {
    }

    [Token(Token = "0x6006EDE")]
    [Address(RVA = "0x470A8D4", Offset = "0x470A8D4", VA = "0x470A8D4")]
    public IReadOnlyCollection<StyleData> GetList() => (IReadOnlyCollection<StyleData>) null;

    [Token(Token = "0x6006EDF")]
    [Address(RVA = "0x470A924", Offset = "0x470A924", VA = "0x470A924")]
    public StyleData GetStyleMasterDataByStyleId(int styleId) => (StyleData) null;

    [Token(Token = "0x6006EE0")]
    [Address(RVA = "0x470AAA8", Offset = "0x470AAA8", VA = "0x470AAA8")]
    public StyleMaster()
    {
    }
  }
}
