// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Info.Equipment.EquipmentAccessoryModelBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using Scenes.OutGame.Info.Common;
using Scenes.OutGame.Info.Skill;
using StaqData;
using System;
using System.Collections.Generic;

#nullable disable
namespace Scenes.OutGame.Info.Equipment
{
  [Token(Token = "0x2003599")]
  public abstract class EquipmentAccessoryModelBase
  {
    [Token(Token = "0x400E8F3")]
    [FieldOffset(Offset = "0x10")]
    public Action OnChange;

    [Token(Token = "0x170045BE")]
    public abstract SkillModelListBase SkillModelList { [Token(Token = "0x60150B1")] get; }

    [Token(Token = "0x170045BF")]
    public abstract ParameterModelBase Parameter { [Token(Token = "0x60150B2")] get; }

    [Token(Token = "0x170045C0")]
    public abstract EquipmentCommonModelBase Common { [Token(Token = "0x60150B3")] get; }

    [Token(Token = "0x170045C1")]
    public int Id
    {
      [Token(Token = "0x60150B4"), Address(RVA = "0x4AAA384", Offset = "0x4AAA384", VA = "0x4AAA384", Slot = "7")] get
      {
        return new int();
      }
      [Token(Token = "0x60150B5"), Address(RVA = "0x4AAA38C", Offset = "0x4AAA38C", VA = "0x4AAA38C")] protected set
      {
      }
    }

    [Token(Token = "0x170045C2")]
    public int Level
    {
      [Token(Token = "0x60150B6"), Address(RVA = "0x4AAA394", Offset = "0x4AAA394", VA = "0x4AAA394")] get
      {
        return new int();
      }
      [Token(Token = "0x60150B7"), Address(RVA = "0x4AAA39C", Offset = "0x4AAA39C", VA = "0x4AAA39C")] set
      {
      }
    }

    [Token(Token = "0x170045C3")]
    public int LevelMax
    {
      [Token(Token = "0x60150B8"), Address(RVA = "0x4AAA3A4", Offset = "0x4AAA3A4", VA = "0x4AAA3A4")] get
      {
        return new int();
      }
      [Token(Token = "0x60150B9"), Address(RVA = "0x4AAA3AC", Offset = "0x4AAA3AC", VA = "0x4AAA3AC")] set
      {
      }
    }

    [Token(Token = "0x170045C4")]
    public AccessorieTypeEnum AccessoryType
    {
      [Token(Token = "0x60150BA"), Address(RVA = "0x4AAA3B4", Offset = "0x4AAA3B4", VA = "0x4AAA3B4")] get
      {
        return new AccessorieTypeEnum();
      }
      [Token(Token = "0x60150BB"), Address(RVA = "0x4AAA3BC", Offset = "0x4AAA3BC", VA = "0x4AAA3BC")] set
      {
      }
    }

    [Token(Token = "0x170045C5")]
    public int LimitBreakCount
    {
      [Token(Token = "0x60150BC"), Address(RVA = "0x4AAA3C4", Offset = "0x4AAA3C4", VA = "0x4AAA3C4")] get
      {
        return new int();
      }
      [Token(Token = "0x60150BD"), Address(RVA = "0x4AAA3CC", Offset = "0x4AAA3CC", VA = "0x4AAA3CC")] set
      {
      }
    }

    [Token(Token = "0x170045C6")]
    public int LimitBreakCountMax
    {
      [Token(Token = "0x60150BE"), Address(RVA = "0x4AAA3D4", Offset = "0x4AAA3D4", VA = "0x4AAA3D4")] get
      {
        return new int();
      }
      [Token(Token = "0x60150BF"), Address(RVA = "0x4AAA3DC", Offset = "0x4AAA3DC", VA = "0x4AAA3DC")] set
      {
      }
    }

    [Token(Token = "0x170045C7")]
    public int OptionSlotMax
    {
      [Token(Token = "0x60150C0"), Address(RVA = "0x4AAA3E4", Offset = "0x4AAA3E4", VA = "0x4AAA3E4")] get
      {
        return new int();
      }
      [Token(Token = "0x60150C1"), Address(RVA = "0x4AAA3EC", Offset = "0x4AAA3EC", VA = "0x4AAA3EC")] protected set
      {
      }
    }

    [Token(Token = "0x170045C8")]
    public IEnumerable<AccessoryOptionEffect> OptionEffects
    {
      [Token(Token = "0x60150C2"), Address(RVA = "0x4AAA3F4", Offset = "0x4AAA3F4", VA = "0x4AAA3F4")] get
      {
        return (IEnumerable<AccessoryOptionEffect>) null;
      }
      [Token(Token = "0x60150C3"), Address(RVA = "0x4AAA3FC", Offset = "0x4AAA3FC", VA = "0x4AAA3FC")] protected set
      {
      }
    }

    [Token(Token = "0x170045C9")]
    public int[] ReinforceAttack
    {
      [Token(Token = "0x60150C4"), Address(RVA = "0x4AAA404", Offset = "0x4AAA404", VA = "0x4AAA404", Slot = "8")] get
      {
        return (int[]) null;
      }
      [Token(Token = "0x60150C5"), Address(RVA = "0x4AAA40C", Offset = "0x4AAA40C", VA = "0x4AAA40C")] protected set
      {
      }
    }

    [Token(Token = "0x170045CA")]
    public int[] ReinforceElement
    {
      [Token(Token = "0x60150C6"), Address(RVA = "0x4AAA414", Offset = "0x4AAA414", VA = "0x4AAA414", Slot = "9")] get
      {
        return (int[]) null;
      }
      [Token(Token = "0x60150C7"), Address(RVA = "0x4AAA41C", Offset = "0x4AAA41C", VA = "0x4AAA41C")] protected set
      {
      }
    }

    [Token(Token = "0x170045CB")]
    public int[] ReinforceBadStatus
    {
      [Token(Token = "0x60150C8"), Address(RVA = "0x4AAA424", Offset = "0x4AAA424", VA = "0x4AAA424", Slot = "10")] get
      {
        return (int[]) null;
      }
      [Token(Token = "0x60150C9"), Address(RVA = "0x4AAA42C", Offset = "0x4AAA42C", VA = "0x4AAA42C")] protected set
      {
      }
    }

    [Token(Token = "0x170045CC")]
    public int[] ResistAttack
    {
      [Token(Token = "0x60150CA"), Address(RVA = "0x4AAA434", Offset = "0x4AAA434", VA = "0x4AAA434", Slot = "11")] get
      {
        return (int[]) null;
      }
      [Token(Token = "0x60150CB"), Address(RVA = "0x4AAA43C", Offset = "0x4AAA43C", VA = "0x4AAA43C")] protected set
      {
      }
    }

    [Token(Token = "0x170045CD")]
    public int[] ResistElement
    {
      [Token(Token = "0x60150CC"), Address(RVA = "0x4AAA444", Offset = "0x4AAA444", VA = "0x4AAA444", Slot = "12")] get
      {
        return (int[]) null;
      }
      [Token(Token = "0x60150CD"), Address(RVA = "0x4AAA44C", Offset = "0x4AAA44C", VA = "0x4AAA44C")] protected set
      {
      }
    }

    [Token(Token = "0x170045CE")]
    public int[] ResistBadStatus
    {
      [Token(Token = "0x60150CE"), Address(RVA = "0x4AAA454", Offset = "0x4AAA454", VA = "0x4AAA454", Slot = "13")] get
      {
        return (int[]) null;
      }
      [Token(Token = "0x60150CF"), Address(RVA = "0x4AAA45C", Offset = "0x4AAA45C", VA = "0x4AAA45C")] protected set
      {
      }
    }

    [Token(Token = "0x170045CF")]
    public int[] SlayMove
    {
      [Token(Token = "0x60150D0"), Address(RVA = "0x4AAA464", Offset = "0x4AAA464", VA = "0x4AAA464", Slot = "14")] get
      {
        return (int[]) null;
      }
      [Token(Token = "0x60150D1"), Address(RVA = "0x4AAA46C", Offset = "0x4AAA46C", VA = "0x4AAA46C")] protected set
      {
      }
    }

    [Token(Token = "0x170045D0")]
    public int[] SlayArmor
    {
      [Token(Token = "0x60150D2"), Address(RVA = "0x4AAA474", Offset = "0x4AAA474", VA = "0x4AAA474", Slot = "15")] get
      {
        return (int[]) null;
      }
      [Token(Token = "0x60150D3"), Address(RVA = "0x4AAA47C", Offset = "0x4AAA47C", VA = "0x4AAA47C")] protected set
      {
      }
    }

    [Token(Token = "0x170045D1")]
    public int[] SlayRide
    {
      [Token(Token = "0x60150D4"), Address(RVA = "0x4AAA484", Offset = "0x4AAA484", VA = "0x4AAA484", Slot = "16")] get
      {
        return (int[]) null;
      }
      [Token(Token = "0x60150D5"), Address(RVA = "0x4AAA48C", Offset = "0x4AAA48C", VA = "0x4AAA48C")] protected set
      {
      }
    }

    [Token(Token = "0x170045D2")]
    public int[] SlaySpecies
    {
      [Token(Token = "0x60150D6"), Address(RVA = "0x4AAA494", Offset = "0x4AAA494", VA = "0x4AAA494", Slot = "17")] get
      {
        return (int[]) null;
      }
      [Token(Token = "0x60150D7"), Address(RVA = "0x4AAA49C", Offset = "0x4AAA49C", VA = "0x4AAA49C")] protected set
      {
      }
    }

    [Token(Token = "0x170045D3")]
    public int[] ResistSlayMove
    {
      [Token(Token = "0x60150D8"), Address(RVA = "0x4AAA4A4", Offset = "0x4AAA4A4", VA = "0x4AAA4A4", Slot = "18")] get
      {
        return (int[]) null;
      }
      [Token(Token = "0x60150D9"), Address(RVA = "0x4AAA4AC", Offset = "0x4AAA4AC", VA = "0x4AAA4AC")] protected set
      {
      }
    }

    [Token(Token = "0x170045D4")]
    public int[] ResistSlayArmor
    {
      [Token(Token = "0x60150DA"), Address(RVA = "0x4AAA4B4", Offset = "0x4AAA4B4", VA = "0x4AAA4B4", Slot = "19")] get
      {
        return (int[]) null;
      }
      [Token(Token = "0x60150DB"), Address(RVA = "0x4AAA4BC", Offset = "0x4AAA4BC", VA = "0x4AAA4BC")] protected set
      {
      }
    }

    [Token(Token = "0x170045D5")]
    public int[] ResistSlayRide
    {
      [Token(Token = "0x60150DC"), Address(RVA = "0x4AAA4C4", Offset = "0x4AAA4C4", VA = "0x4AAA4C4", Slot = "20")] get
      {
        return (int[]) null;
      }
      [Token(Token = "0x60150DD"), Address(RVA = "0x4AAA4CC", Offset = "0x4AAA4CC", VA = "0x4AAA4CC")] protected set
      {
      }
    }

    [Token(Token = "0x170045D6")]
    public int[] ResistSlaySpecies
    {
      [Token(Token = "0x60150DE"), Address(RVA = "0x4AAA4D4", Offset = "0x4AAA4D4", VA = "0x4AAA4D4", Slot = "21")] get
      {
        return (int[]) null;
      }
      [Token(Token = "0x60150DF"), Address(RVA = "0x4AAA4DC", Offset = "0x4AAA4DC", VA = "0x4AAA4DC")] protected set
      {
      }
    }

    [Token(Token = "0x170045D7")]
    public bool IsEmpty
    {
      [Token(Token = "0x60150E0"), Address(RVA = "0x4AAA4E4", Offset = "0x4AAA4E4", VA = "0x4AAA4E4", Slot = "22")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170045D8")]
    public abstract bool IsUnknown { [Token(Token = "0x60150E1")] get; }

    [Token(Token = "0x60150E2")]
    [Address(RVA = "0x4AAA4F4", Offset = "0x4AAA4F4", VA = "0x4AAA4F4")]
    protected EquipmentAccessoryModelBase()
    {
    }
  }
}
