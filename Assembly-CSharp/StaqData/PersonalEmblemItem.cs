// Decompiled with JetBrains decompiler
// Type: StaqData.PersonalEmblemItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using Network.Param;
using System;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x200203B")]
  public sealed class PersonalEmblemItem : Item
  {
    [Token(Token = "0x400891E")]
    [FieldOffset(Offset = "0x28")]
    private PersonalEmblemData baseData;

    [Token(Token = "0x1700287C")]
    public PersonalEmblemData MasterData
    {
      [Token(Token = "0x600C132"), Address(RVA = "0x1938A78", Offset = "0x1938A78", VA = "0x1938A78")] get
      {
        return (PersonalEmblemData) null;
      }
    }

    [Token(Token = "0x1700287D")]
    public override string Name
    {
      [Token(Token = "0x600C133"), Address(RVA = "0x1938B24", Offset = "0x1938B24", VA = "0x1938B24", Slot = "4")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x1700287E")]
    public override ItemTypeEnum ItemType
    {
      [Token(Token = "0x600C134"), Address(RVA = "0x1938B40", Offset = "0x1938B40", VA = "0x1938B40", Slot = "5")] get
      {
        return new ItemTypeEnum();
      }
    }

    [Token(Token = "0x1700287F")]
    public override RarityTypeEnum Rarity
    {
      [Token(Token = "0x600C135"), Address(RVA = "0x1938B5C", Offset = "0x1938B5C", VA = "0x1938B5C", Slot = "6")] get
      {
        return new RarityTypeEnum();
      }
    }

    [Token(Token = "0x17002880")]
    public override bool IsSellable
    {
      [Token(Token = "0x600C136"), Address(RVA = "0x1938B78", Offset = "0x1938B78", VA = "0x1938B78", Slot = "7")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17002881")]
    private string CreatedAtStr
    {
      [Token(Token = "0x600C137"), Address(RVA = "0x1938B80", Offset = "0x1938B80", VA = "0x1938B80")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600C138"), Address(RVA = "0x1938B88", Offset = "0x1938B88", VA = "0x1938B88")] set
      {
      }
    }

    [Token(Token = "0x17002882")]
    public DateTime CreatedAt
    {
      [Token(Token = "0x600C139"), Address(RVA = "0x1938B90", Offset = "0x1938B90", VA = "0x1938B90")] get
      {
        return new DateTime();
      }
    }

    [Token(Token = "0x600C13A")]
    [Address(RVA = "0x1938C10", Offset = "0x1938C10", VA = "0x1938C10")]
    public void Apply(int id)
    {
    }

    [Token(Token = "0x600C13B")]
    [Address(RVA = "0x1938C18", Offset = "0x1938C18", VA = "0x1938C18")]
    public void Apply(PlayerEmblemType playerEmblemType)
    {
    }

    [Token(Token = "0x600C13C")]
    [Address(RVA = "0x1938CD4", Offset = "0x1938CD4", VA = "0x1938CD4")]
    public static PersonalEmblemItem CreateByServerData(PlayerEmblemType entity)
    {
      return (PersonalEmblemItem) null;
    }

    [Token(Token = "0x600C13D")]
    [Address(RVA = "0x1938DBC", Offset = "0x1938DBC", VA = "0x1938DBC")]
    public PersonalEmblemItem()
    {
    }
  }
}
