// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Info.Equipment.EquipmentTrustModelBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Scenes.OutGame.Info.Common;
using Scenes.OutGame.Info.Skill;
using System;

#nullable disable
namespace Scenes.OutGame.Info.Equipment
{
  [Token(Token = "0x200359F")]
  public abstract class EquipmentTrustModelBase
  {
    [Token(Token = "0x400E92D")]
    [FieldOffset(Offset = "0x10")]
    public Action OnChange;

    [Token(Token = "0x17004600")]
    public abstract SkillModelBase Skill { [Token(Token = "0x6015134")] get; }

    [Token(Token = "0x17004601")]
    public abstract ParameterModelBase Parameter { [Token(Token = "0x6015135")] get; }

    [Token(Token = "0x17004602")]
    public abstract EquipmentCommonModelBase Common { [Token(Token = "0x6015136")] get; }

    [Token(Token = "0x17004603")]
    public int Id
    {
      [Token(Token = "0x6015137"), Address(RVA = "0x4AAB278", Offset = "0x4AAB278", VA = "0x4AAB278", Slot = "7")] get
      {
        return new int();
      }
      [Token(Token = "0x6015138"), Address(RVA = "0x4AAB280", Offset = "0x4AAB280", VA = "0x4AAB280")] protected set
      {
      }
    }

    [Token(Token = "0x17004604")]
    public int[] ReinforceAttack
    {
      [Token(Token = "0x6015139"), Address(RVA = "0x4AAB288", Offset = "0x4AAB288", VA = "0x4AAB288", Slot = "8")] get
      {
        return (int[]) null;
      }
      [Token(Token = "0x601513A"), Address(RVA = "0x4AAB290", Offset = "0x4AAB290", VA = "0x4AAB290")] protected set
      {
      }
    }

    [Token(Token = "0x17004605")]
    public int[] ReinforceElement
    {
      [Token(Token = "0x601513B"), Address(RVA = "0x4AAB298", Offset = "0x4AAB298", VA = "0x4AAB298", Slot = "9")] get
      {
        return (int[]) null;
      }
      [Token(Token = "0x601513C"), Address(RVA = "0x4AAB2A0", Offset = "0x4AAB2A0", VA = "0x4AAB2A0")] protected set
      {
      }
    }

    [Token(Token = "0x17004606")]
    public int[] ReinforceBadStatus
    {
      [Token(Token = "0x601513D"), Address(RVA = "0x4AAB2A8", Offset = "0x4AAB2A8", VA = "0x4AAB2A8", Slot = "10")] get
      {
        return (int[]) null;
      }
      [Token(Token = "0x601513E"), Address(RVA = "0x4AAB2B0", Offset = "0x4AAB2B0", VA = "0x4AAB2B0")] protected set
      {
      }
    }

    [Token(Token = "0x17004607")]
    public int[] ResistAttack
    {
      [Token(Token = "0x601513F"), Address(RVA = "0x4AAB2B8", Offset = "0x4AAB2B8", VA = "0x4AAB2B8", Slot = "11")] get
      {
        return (int[]) null;
      }
      [Token(Token = "0x6015140"), Address(RVA = "0x4AAB2C0", Offset = "0x4AAB2C0", VA = "0x4AAB2C0")] protected set
      {
      }
    }

    [Token(Token = "0x17004608")]
    public int[] ResistElement
    {
      [Token(Token = "0x6015141"), Address(RVA = "0x4AAB2C8", Offset = "0x4AAB2C8", VA = "0x4AAB2C8", Slot = "12")] get
      {
        return (int[]) null;
      }
      [Token(Token = "0x6015142"), Address(RVA = "0x4AAB2D0", Offset = "0x4AAB2D0", VA = "0x4AAB2D0")] protected set
      {
      }
    }

    [Token(Token = "0x17004609")]
    public int[] ResistBadStatus
    {
      [Token(Token = "0x6015143"), Address(RVA = "0x4AAB2D8", Offset = "0x4AAB2D8", VA = "0x4AAB2D8", Slot = "13")] get
      {
        return (int[]) null;
      }
      [Token(Token = "0x6015144"), Address(RVA = "0x4AAB2E0", Offset = "0x4AAB2E0", VA = "0x4AAB2E0")] protected set
      {
      }
    }

    [Token(Token = "0x1700460A")]
    public int[] SlayMove
    {
      [Token(Token = "0x6015145"), Address(RVA = "0x4AAB2E8", Offset = "0x4AAB2E8", VA = "0x4AAB2E8", Slot = "14")] get
      {
        return (int[]) null;
      }
      [Token(Token = "0x6015146"), Address(RVA = "0x4AAB2F0", Offset = "0x4AAB2F0", VA = "0x4AAB2F0")] protected set
      {
      }
    }

    [Token(Token = "0x1700460B")]
    public int[] SlayArmor
    {
      [Token(Token = "0x6015147"), Address(RVA = "0x4AAB2F8", Offset = "0x4AAB2F8", VA = "0x4AAB2F8", Slot = "15")] get
      {
        return (int[]) null;
      }
      [Token(Token = "0x6015148"), Address(RVA = "0x4AAB300", Offset = "0x4AAB300", VA = "0x4AAB300")] protected set
      {
      }
    }

    [Token(Token = "0x1700460C")]
    public int[] SlayRide
    {
      [Token(Token = "0x6015149"), Address(RVA = "0x4AAB308", Offset = "0x4AAB308", VA = "0x4AAB308", Slot = "16")] get
      {
        return (int[]) null;
      }
      [Token(Token = "0x601514A"), Address(RVA = "0x4AAB310", Offset = "0x4AAB310", VA = "0x4AAB310")] protected set
      {
      }
    }

    [Token(Token = "0x1700460D")]
    public int[] SlaySpecies
    {
      [Token(Token = "0x601514B"), Address(RVA = "0x4AAB318", Offset = "0x4AAB318", VA = "0x4AAB318", Slot = "17")] get
      {
        return (int[]) null;
      }
      [Token(Token = "0x601514C"), Address(RVA = "0x4AAB320", Offset = "0x4AAB320", VA = "0x4AAB320")] protected set
      {
      }
    }

    [Token(Token = "0x1700460E")]
    public int[] ResistSlayMove
    {
      [Token(Token = "0x601514D"), Address(RVA = "0x4AAB328", Offset = "0x4AAB328", VA = "0x4AAB328", Slot = "18")] get
      {
        return (int[]) null;
      }
      [Token(Token = "0x601514E"), Address(RVA = "0x4AAB330", Offset = "0x4AAB330", VA = "0x4AAB330")] protected set
      {
      }
    }

    [Token(Token = "0x1700460F")]
    public int[] ResistSlayArmor
    {
      [Token(Token = "0x601514F"), Address(RVA = "0x4AAB338", Offset = "0x4AAB338", VA = "0x4AAB338", Slot = "19")] get
      {
        return (int[]) null;
      }
      [Token(Token = "0x6015150"), Address(RVA = "0x4AAB340", Offset = "0x4AAB340", VA = "0x4AAB340")] protected set
      {
      }
    }

    [Token(Token = "0x17004610")]
    public int[] ResistSlayRide
    {
      [Token(Token = "0x6015151"), Address(RVA = "0x4AAB348", Offset = "0x4AAB348", VA = "0x4AAB348", Slot = "20")] get
      {
        return (int[]) null;
      }
      [Token(Token = "0x6015152"), Address(RVA = "0x4AAB350", Offset = "0x4AAB350", VA = "0x4AAB350")] protected set
      {
      }
    }

    [Token(Token = "0x17004611")]
    public int[] ResistSlaySpecies
    {
      [Token(Token = "0x6015153"), Address(RVA = "0x4AAB358", Offset = "0x4AAB358", VA = "0x4AAB358", Slot = "21")] get
      {
        return (int[]) null;
      }
      [Token(Token = "0x6015154"), Address(RVA = "0x4AAB360", Offset = "0x4AAB360", VA = "0x4AAB360")] protected set
      {
      }
    }

    [Token(Token = "0x17004612")]
    public bool IsEmpty
    {
      [Token(Token = "0x6015155"), Address(RVA = "0x4AAB368", Offset = "0x4AAB368", VA = "0x4AAB368", Slot = "22")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6015156")]
    [Address(RVA = "0x4AAB378", Offset = "0x4AAB378", VA = "0x4AAB378")]
    protected EquipmentTrustModelBase()
    {
    }
  }
}
