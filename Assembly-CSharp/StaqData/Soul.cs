// Decompiled with JetBrains decompiler
// Type: StaqData.Soul
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using Network.Param;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x200203D")]
  public sealed class Soul : Item
  {
    [Token(Token = "0x4008921")]
    private const int BLUE_SOUL_ID = 201120001;
    [Token(Token = "0x4008922")]
    private const int RED_SOUL_ID = 201130001;

    [Token(Token = "0x17002888")]
    public override string Name
    {
      [Token(Token = "0x600C147"), Address(RVA = "0x193922C", Offset = "0x193922C", VA = "0x193922C", Slot = "4")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17002889")]
    public override ItemTypeEnum ItemType
    {
      [Token(Token = "0x600C148"), Address(RVA = "0x1939304", Offset = "0x1939304", VA = "0x1939304", Slot = "5")] get
      {
        return new ItemTypeEnum();
      }
    }

    [Token(Token = "0x1700288A")]
    public override RarityTypeEnum Rarity
    {
      [Token(Token = "0x600C149"), Address(RVA = "0x193930C", Offset = "0x193930C", VA = "0x193930C", Slot = "6")] get
      {
        return new RarityTypeEnum();
      }
    }

    [Token(Token = "0x1700288B")]
    public override bool IsSellable
    {
      [Token(Token = "0x600C14A"), Address(RVA = "0x1939314", Offset = "0x1939314", VA = "0x1939314", Slot = "7")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700288C")]
    public ResourceItemData ResourceItemData
    {
      [Token(Token = "0x600C14B"), Address(RVA = "0x1939248", Offset = "0x1939248", VA = "0x1939248")] get
      {
        return (ResourceItemData) null;
      }
    }

    [Token(Token = "0x600C14C")]
    [Address(RVA = "0x1939344", Offset = "0x1939344", VA = "0x1939344")]
    private Soul()
    {
    }

    [Token(Token = "0x600C14D")]
    [Address(RVA = "0x193934C", Offset = "0x193934C", VA = "0x193934C")]
    public void Apply(PlayerSoulType entity)
    {
    }

    [Token(Token = "0x600C14E")]
    [Address(RVA = "0x1939368", Offset = "0x1939368", VA = "0x1939368")]
    public static Soul CreateByServerData(PlayerSoulType entity) => (Soul) null;

    [Token(Token = "0x600C14F")]
    [Address(RVA = "0x1939448", Offset = "0x1939448", VA = "0x1939448")]
    public static int GetSoulItemID(SoulTypeEnum soulTypeEnum) => new int();

    [Token(Token = "0x600C150")]
    [Address(RVA = "0x1939470", Offset = "0x1939470", VA = "0x1939470")]
    public static int GetBlueSoulId() => new int();

    [Token(Token = "0x600C151")]
    [Address(RVA = "0x193947C", Offset = "0x193947C", VA = "0x193947C")]
    public static int GetRedSoulId() => new int();

    [Token(Token = "0x600C152")]
    [Address(RVA = "0x193931C", Offset = "0x193931C", VA = "0x193931C")]
    public static int GetResourceItemId(SoulTypeEnum soulTypeEnum) => new int();
  }
}
