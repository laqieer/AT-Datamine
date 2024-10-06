// Decompiled with JetBrains decompiler
// Type: staq.SaveSchema.SortFilterSave
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FlatBuffers;
using Il2CppDummyDll;

#nullable disable
namespace staq.SaveSchema
{
  [Token(Token = "0x2003CDD")]
  public struct SortFilterSave : IFlatbufferObject
  {
    [Token(Token = "0x4010C3E")]
    [FieldOffset(Offset = "0x0")]
    private Table __p;

    [Token(Token = "0x17004FC9")]
    public ByteBuffer ByteBuffer
    {
      [Token(Token = "0x60186B4"), Address(RVA = "0x26E1B18", Offset = "0x26E1B18", VA = "0x26E1B18", Slot = "4")] get
      {
        return (ByteBuffer) null;
      }
    }

    [Token(Token = "0x60186B5")]
    [Address(RVA = "0x26E1B20", Offset = "0x26E1B20", VA = "0x26E1B20")]
    public static SortFilterSave GetRootAsSortFilterSave(ByteBuffer _bb) => new SortFilterSave();

    [Token(Token = "0x60186B6")]
    [Address(RVA = "0x26E1B2C", Offset = "0x26E1B2C", VA = "0x26E1B2C")]
    public static SortFilterSave GetRootAsSortFilterSave(ByteBuffer _bb, SortFilterSave obj)
    {
      return new SortFilterSave();
    }

    [Token(Token = "0x60186B7")]
    [Address(RVA = "0x26E1B88", Offset = "0x26E1B88", VA = "0x26E1B88")]
    public static bool SortFilterSaveBufferHasIdentifier(ByteBuffer _bb) => new bool();

    [Token(Token = "0x60186B8")]
    [Address(RVA = "0x26E1BD4", Offset = "0x26E1BD4", VA = "0x26E1BD4", Slot = "5")]
    public void __init(int _i, ByteBuffer _bb)
    {
    }

    [Token(Token = "0x60186B9")]
    [Address(RVA = "0x26E1B70", Offset = "0x26E1B70", VA = "0x26E1B70")]
    public SortFilterSave __assign(int _i, ByteBuffer _bb) => new SortFilterSave();

    [Token(Token = "0x17004FCA")]
    public SortFilterData? Style
    {
      [Token(Token = "0x60186BA"), Address(RVA = "0x26E1BE0", Offset = "0x26E1BE0", VA = "0x26E1BE0")] get
      {
        return new SortFilterData?();
      }
    }

    [Token(Token = "0x17004FCB")]
    public SortFilterData? Weapon
    {
      [Token(Token = "0x60186BB"), Address(RVA = "0x26E1C90", Offset = "0x26E1C90", VA = "0x26E1C90")] get
      {
        return new SortFilterData?();
      }
    }

    [Token(Token = "0x17004FCC")]
    public SortFilterData? Accessory
    {
      [Token(Token = "0x60186BC"), Address(RVA = "0x26E1D28", Offset = "0x26E1D28", VA = "0x26E1D28")] get
      {
        return new SortFilterData?();
      }
    }

    [Token(Token = "0x17004FCD")]
    public SortFilterData? MindEquipment
    {
      [Token(Token = "0x60186BD"), Address(RVA = "0x26E1DC0", Offset = "0x26E1DC0", VA = "0x26E1DC0")] get
      {
        return new SortFilterData?();
      }
    }

    [Token(Token = "0x17004FCE")]
    public SortFilterData? UnitTrust
    {
      [Token(Token = "0x60186BE"), Address(RVA = "0x26E1E58", Offset = "0x26E1E58", VA = "0x26E1E58")] get
      {
        return new SortFilterData?();
      }
    }

    [Token(Token = "0x17004FCF")]
    public SortFilterData? CustomSkill
    {
      [Token(Token = "0x60186BF"), Address(RVA = "0x26E1EF0", Offset = "0x26E1EF0", VA = "0x26E1EF0")] get
      {
        return new SortFilterData?();
      }
    }

    [Token(Token = "0x17004FD0")]
    public SortFilterData? SaleItem
    {
      [Token(Token = "0x60186C0"), Address(RVA = "0x26E1F88", Offset = "0x26E1F88", VA = "0x26E1F88")] get
      {
        return new SortFilterData?();
      }
    }

    [Token(Token = "0x17004FD1")]
    public SortFilterData? StyleRanking
    {
      [Token(Token = "0x60186C1"), Address(RVA = "0x26E2020", Offset = "0x26E2020", VA = "0x26E2020")] get
      {
        return new SortFilterData?();
      }
    }

    [Token(Token = "0x17004FD2")]
    public SortFilterData? PersonalEmblem
    {
      [Token(Token = "0x60186C2"), Address(RVA = "0x26E20B8", Offset = "0x26E20B8", VA = "0x26E20B8")] get
      {
        return new SortFilterData?();
      }
    }

    [Token(Token = "0x17004FD3")]
    public SortFilterData? Item
    {
      [Token(Token = "0x60186C3"), Address(RVA = "0x26E2150", Offset = "0x26E2150", VA = "0x26E2150")] get
      {
        return new SortFilterData?();
      }
    }

    [Token(Token = "0x60186C4")]
    [Address(RVA = "0x26E21E8", Offset = "0x26E21E8", VA = "0x26E21E8")]
    public static Offset<SortFilterSave> CreateSortFilterSave(
      FlatBufferBuilder builder,
      Offset<SortFilterData> styleOffset = default (Offset<SortFilterData>),
      Offset<SortFilterData> weaponOffset = default (Offset<SortFilterData>),
      Offset<SortFilterData> accessoryOffset = default (Offset<SortFilterData>),
      Offset<SortFilterData> mind_equipmentOffset = default (Offset<SortFilterData>),
      Offset<SortFilterData> unit_trustOffset = default (Offset<SortFilterData>),
      Offset<SortFilterData> custom_skillOffset = default (Offset<SortFilterData>),
      Offset<SortFilterData> sale_itemOffset = default (Offset<SortFilterData>),
      Offset<SortFilterData> style_rankingOffset = default (Offset<SortFilterData>),
      Offset<SortFilterData> personal_emblemOffset = default (Offset<SortFilterData>),
      Offset<SortFilterData> itemOffset = default (Offset<SortFilterData>))
    {
      return new Offset<SortFilterSave>();
    }

    [Token(Token = "0x60186C5")]
    [Address(RVA = "0x26E246C", Offset = "0x26E246C", VA = "0x26E246C")]
    public static void StartSortFilterSave(FlatBufferBuilder builder)
    {
    }

    [Token(Token = "0x60186C6")]
    [Address(RVA = "0x26E23FC", Offset = "0x26E23FC", VA = "0x26E23FC")]
    public static void AddStyle(FlatBufferBuilder builder, Offset<SortFilterData> styleOffset)
    {
    }

    [Token(Token = "0x60186C7")]
    [Address(RVA = "0x26E23DC", Offset = "0x26E23DC", VA = "0x26E23DC")]
    public static void AddWeapon(FlatBufferBuilder builder, Offset<SortFilterData> weaponOffset)
    {
    }

    [Token(Token = "0x60186C8")]
    [Address(RVA = "0x26E23BC", Offset = "0x26E23BC", VA = "0x26E23BC")]
    public static void AddAccessory(
      FlatBufferBuilder builder,
      Offset<SortFilterData> accessoryOffset)
    {
    }

    [Token(Token = "0x60186C9")]
    [Address(RVA = "0x26E239C", Offset = "0x26E239C", VA = "0x26E239C")]
    public static void AddMindEquipment(
      FlatBufferBuilder builder,
      Offset<SortFilterData> mindEquipmentOffset)
    {
    }

    [Token(Token = "0x60186CA")]
    [Address(RVA = "0x26E237C", Offset = "0x26E237C", VA = "0x26E237C")]
    public static void AddUnitTrust(
      FlatBufferBuilder builder,
      Offset<SortFilterData> unitTrustOffset)
    {
    }

    [Token(Token = "0x60186CB")]
    [Address(RVA = "0x26E235C", Offset = "0x26E235C", VA = "0x26E235C")]
    public static void AddCustomSkill(
      FlatBufferBuilder builder,
      Offset<SortFilterData> customSkillOffset)
    {
    }

    [Token(Token = "0x60186CC")]
    [Address(RVA = "0x26E233C", Offset = "0x26E233C", VA = "0x26E233C")]
    public static void AddSaleItem(FlatBufferBuilder builder, Offset<SortFilterData> saleItemOffset)
    {
    }

    [Token(Token = "0x60186CD")]
    [Address(RVA = "0x26E231C", Offset = "0x26E231C", VA = "0x26E231C")]
    public static void AddStyleRanking(
      FlatBufferBuilder builder,
      Offset<SortFilterData> styleRankingOffset)
    {
    }

    [Token(Token = "0x60186CE")]
    [Address(RVA = "0x26E22FC", Offset = "0x26E22FC", VA = "0x26E22FC")]
    public static void AddPersonalEmblem(
      FlatBufferBuilder builder,
      Offset<SortFilterData> personalEmblemOffset)
    {
    }

    [Token(Token = "0x60186CF")]
    [Address(RVA = "0x26E22DC", Offset = "0x26E22DC", VA = "0x26E22DC")]
    public static void AddItem(FlatBufferBuilder builder, Offset<SortFilterData> itemOffset)
    {
    }

    [Token(Token = "0x60186D0")]
    [Address(RVA = "0x26E241C", Offset = "0x26E241C", VA = "0x26E241C")]
    public static Offset<SortFilterSave> EndSortFilterSave(FlatBufferBuilder builder)
    {
      return new Offset<SortFilterSave>();
    }

    [Token(Token = "0x60186D1")]
    [Address(RVA = "0x26E2484", Offset = "0x26E2484", VA = "0x26E2484")]
    public static void FinishSortFilterSaveBuffer(
      FlatBufferBuilder builder,
      Offset<SortFilterSave> offset)
    {
    }

    [Token(Token = "0x60186D2")]
    [Address(RVA = "0x26E24E0", Offset = "0x26E24E0", VA = "0x26E24E0")]
    public static void FinishSizePrefixedSortFilterSaveBuffer(
      FlatBufferBuilder builder,
      Offset<SortFilterSave> offset)
    {
    }
  }
}
