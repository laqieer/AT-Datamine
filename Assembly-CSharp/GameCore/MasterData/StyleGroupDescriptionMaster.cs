// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StyleGroupDescriptionMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20013B3")]
  [Serializable]
  public sealed class StyleGroupDescriptionMaster : BaseMaster<StyleGroupDescriptionData>
  {
    [Token(Token = "0x4005BBF")]
    [FieldOffset(Offset = "0x18")]
    private Dictionary<int, List<StyleGroupDescriptionData>> descriptionTable;

    [Token(Token = "0x6006EA8")]
    [Address(RVA = "0x4708C18", Offset = "0x4708C18", VA = "0x4708C18")]
    public IReadOnlyDictionary<int, StyleGroupDescriptionData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StyleGroupDescriptionData>) null;
    }

    [Token(Token = "0x6006EA9")]
    [Address(RVA = "0x4708C20", Offset = "0x4708C20", VA = "0x4708C20", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006EAA")]
    [Address(RVA = "0x4708C80", Offset = "0x4708C80", VA = "0x4708C80", Slot = "5")]
    protected override StyleGroupDescriptionData LoadEntity(IMasterDataReader reader)
    {
      return (StyleGroupDescriptionData) null;
    }

    [Token(Token = "0x6006EAB")]
    [Address(RVA = "0x4708CF0", Offset = "0x4708CF0", VA = "0x4708CF0")]
    private void OnLoadEntity(StyleGroupDescriptionData entity)
    {
    }

    [Token(Token = "0x6006EAC")]
    [Address(RVA = "0x4708CF4", Offset = "0x4708CF4", VA = "0x4708CF4")]
    private void GroupingByStyleId(StyleGroupDescriptionData entity)
    {
    }

    [Token(Token = "0x6006EAD")]
    [Address(RVA = "0x4708E4C", Offset = "0x4708E4C", VA = "0x4708E4C")]
    public IReadOnlyList<StyleGroupDescriptionData> GetListByStyleId(int styleId)
    {
      return (IReadOnlyList<StyleGroupDescriptionData>) null;
    }

    [Token(Token = "0x6006EAE")]
    [Address(RVA = "0x4708F08", Offset = "0x4708F08", VA = "0x4708F08")]
    public StyleGroupDescriptionData GetByStyleGroupType(StyleGroupTypeEnum styleGroupTypeEnum)
    {
      return (StyleGroupDescriptionData) null;
    }

    [Token(Token = "0x6006EAF")]
    [Address(RVA = "0x4709010", Offset = "0x4709010", VA = "0x4709010")]
    public StyleGroupDescriptionMaster()
    {
    }
  }
}
