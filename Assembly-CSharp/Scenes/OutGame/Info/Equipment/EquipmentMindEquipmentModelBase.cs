// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Info.Equipment.EquipmentMindEquipmentModelBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using Scenes.OutGame.Info.Common;
using Scenes.OutGame.Info.Skill;
using System;

#nullable disable
namespace Scenes.OutGame.Info.Equipment
{
  [Token(Token = "0x200359D")]
  public abstract class EquipmentMindEquipmentModelBase
  {
    [Token(Token = "0x400E913")]
    [FieldOffset(Offset = "0x10")]
    public Action OnChange;

    [Token(Token = "0x170045E3")]
    public abstract SkillModelListBase SkillModelList { [Token(Token = "0x60150FC")] get; }

    [Token(Token = "0x170045E4")]
    public abstract ParameterModelBase Parameter { [Token(Token = "0x60150FD")] get; }

    [Token(Token = "0x170045E5")]
    public abstract EquipmentCommonModelBase Common { [Token(Token = "0x60150FE")] get; }

    [Token(Token = "0x170045E6")]
    public int Id
    {
      [Token(Token = "0x60150FF"), Address(RVA = "0x4AAAC80", Offset = "0x4AAAC80", VA = "0x4AAAC80", Slot = "7")] get
      {
        return new int();
      }
      [Token(Token = "0x6015100"), Address(RVA = "0x4AAAC88", Offset = "0x4AAAC88", VA = "0x4AAAC88")] protected set
      {
      }
    }

    [Token(Token = "0x170045E7")]
    public int Level
    {
      [Token(Token = "0x6015101"), Address(RVA = "0x4AAAC90", Offset = "0x4AAAC90", VA = "0x4AAAC90")] get
      {
        return new int();
      }
      [Token(Token = "0x6015102"), Address(RVA = "0x4AAAC98", Offset = "0x4AAAC98", VA = "0x4AAAC98")] set
      {
      }
    }

    [Token(Token = "0x170045E8")]
    public int LevelMax
    {
      [Token(Token = "0x6015103"), Address(RVA = "0x4AAACA0", Offset = "0x4AAACA0", VA = "0x4AAACA0")] get
      {
        return new int();
      }
      [Token(Token = "0x6015104"), Address(RVA = "0x4AAACA8", Offset = "0x4AAACA8", VA = "0x4AAACA8")] set
      {
      }
    }

    [Token(Token = "0x170045E9")]
    public int LimitBreakCount
    {
      [Token(Token = "0x6015105"), Address(RVA = "0x4AAACB0", Offset = "0x4AAACB0", VA = "0x4AAACB0")] get
      {
        return new int();
      }
      [Token(Token = "0x6015106"), Address(RVA = "0x4AAACB8", Offset = "0x4AAACB8", VA = "0x4AAACB8")] set
      {
      }
    }

    [Token(Token = "0x170045EA")]
    public int LimitBreakCountMax
    {
      [Token(Token = "0x6015107"), Address(RVA = "0x4AAACC0", Offset = "0x4AAACC0", VA = "0x4AAACC0")] get
      {
        return new int();
      }
      [Token(Token = "0x6015108"), Address(RVA = "0x4AAACC8", Offset = "0x4AAACC8", VA = "0x4AAACC8")] set
      {
      }
    }

    [Token(Token = "0x170045EB")]
    public CustomSkillData RewardCustomSkill
    {
      [Token(Token = "0x6015109"), Address(RVA = "0x4AAACD0", Offset = "0x4AAACD0", VA = "0x4AAACD0")] get
      {
        return (CustomSkillData) null;
      }
      [Token(Token = "0x601510A"), Address(RVA = "0x4AAACD8", Offset = "0x4AAACD8", VA = "0x4AAACD8")] set
      {
      }
    }

    [Token(Token = "0x170045EC")]
    public SkillData RewardSkill
    {
      [Token(Token = "0x601510B"), Address(RVA = "0x4AAACE0", Offset = "0x4AAACE0", VA = "0x4AAACE0")] get
      {
        return (SkillData) null;
      }
      [Token(Token = "0x601510C"), Address(RVA = "0x4AAACE8", Offset = "0x4AAACE8", VA = "0x4AAACE8")] set
      {
      }
    }

    [Token(Token = "0x170045ED")]
    public int[] ReinforceAttack
    {
      [Token(Token = "0x601510D"), Address(RVA = "0x4AAACF0", Offset = "0x4AAACF0", VA = "0x4AAACF0", Slot = "8")] get
      {
        return (int[]) null;
      }
      [Token(Token = "0x601510E"), Address(RVA = "0x4AAACF8", Offset = "0x4AAACF8", VA = "0x4AAACF8")] protected set
      {
      }
    }

    [Token(Token = "0x170045EE")]
    public int[] ReinforceElement
    {
      [Token(Token = "0x601510F"), Address(RVA = "0x4AAAD00", Offset = "0x4AAAD00", VA = "0x4AAAD00", Slot = "9")] get
      {
        return (int[]) null;
      }
      [Token(Token = "0x6015110"), Address(RVA = "0x4AAAD08", Offset = "0x4AAAD08", VA = "0x4AAAD08")] protected set
      {
      }
    }

    [Token(Token = "0x170045EF")]
    public int[] ReinforceBadStatus
    {
      [Token(Token = "0x6015111"), Address(RVA = "0x4AAAD10", Offset = "0x4AAAD10", VA = "0x4AAAD10", Slot = "10")] get
      {
        return (int[]) null;
      }
      [Token(Token = "0x6015112"), Address(RVA = "0x4AAAD18", Offset = "0x4AAAD18", VA = "0x4AAAD18")] protected set
      {
      }
    }

    [Token(Token = "0x170045F0")]
    public int[] ResistAttack
    {
      [Token(Token = "0x6015113"), Address(RVA = "0x4AAAD20", Offset = "0x4AAAD20", VA = "0x4AAAD20", Slot = "11")] get
      {
        return (int[]) null;
      }
      [Token(Token = "0x6015114"), Address(RVA = "0x4AAAD28", Offset = "0x4AAAD28", VA = "0x4AAAD28")] protected set
      {
      }
    }

    [Token(Token = "0x170045F1")]
    public int[] ResistElement
    {
      [Token(Token = "0x6015115"), Address(RVA = "0x4AAAD30", Offset = "0x4AAAD30", VA = "0x4AAAD30", Slot = "12")] get
      {
        return (int[]) null;
      }
      [Token(Token = "0x6015116"), Address(RVA = "0x4AAAD38", Offset = "0x4AAAD38", VA = "0x4AAAD38")] protected set
      {
      }
    }

    [Token(Token = "0x170045F2")]
    public int[] ResistBadStatus
    {
      [Token(Token = "0x6015117"), Address(RVA = "0x4AAAD40", Offset = "0x4AAAD40", VA = "0x4AAAD40", Slot = "13")] get
      {
        return (int[]) null;
      }
      [Token(Token = "0x6015118"), Address(RVA = "0x4AAAD48", Offset = "0x4AAAD48", VA = "0x4AAAD48")] protected set
      {
      }
    }

    [Token(Token = "0x170045F3")]
    public int[] SlayMove
    {
      [Token(Token = "0x6015119"), Address(RVA = "0x4AAAD50", Offset = "0x4AAAD50", VA = "0x4AAAD50", Slot = "14")] get
      {
        return (int[]) null;
      }
      [Token(Token = "0x601511A"), Address(RVA = "0x4AAAD58", Offset = "0x4AAAD58", VA = "0x4AAAD58")] protected set
      {
      }
    }

    [Token(Token = "0x170045F4")]
    public int[] SlayArmor
    {
      [Token(Token = "0x601511B"), Address(RVA = "0x4AAAD60", Offset = "0x4AAAD60", VA = "0x4AAAD60", Slot = "15")] get
      {
        return (int[]) null;
      }
      [Token(Token = "0x601511C"), Address(RVA = "0x4AAAD68", Offset = "0x4AAAD68", VA = "0x4AAAD68")] protected set
      {
      }
    }

    [Token(Token = "0x170045F5")]
    public int[] SlayRide
    {
      [Token(Token = "0x601511D"), Address(RVA = "0x4AAAD70", Offset = "0x4AAAD70", VA = "0x4AAAD70", Slot = "16")] get
      {
        return (int[]) null;
      }
      [Token(Token = "0x601511E"), Address(RVA = "0x4AAAD78", Offset = "0x4AAAD78", VA = "0x4AAAD78")] protected set
      {
      }
    }

    [Token(Token = "0x170045F6")]
    public int[] SlaySpecies
    {
      [Token(Token = "0x601511F"), Address(RVA = "0x4AAAD80", Offset = "0x4AAAD80", VA = "0x4AAAD80", Slot = "17")] get
      {
        return (int[]) null;
      }
      [Token(Token = "0x6015120"), Address(RVA = "0x4AAAD88", Offset = "0x4AAAD88", VA = "0x4AAAD88")] protected set
      {
      }
    }

    [Token(Token = "0x170045F7")]
    public int[] ResistSlayMove
    {
      [Token(Token = "0x6015121"), Address(RVA = "0x4AAAD90", Offset = "0x4AAAD90", VA = "0x4AAAD90", Slot = "18")] get
      {
        return (int[]) null;
      }
      [Token(Token = "0x6015122"), Address(RVA = "0x4AAAD98", Offset = "0x4AAAD98", VA = "0x4AAAD98")] protected set
      {
      }
    }

    [Token(Token = "0x170045F8")]
    public int[] ResistSlayArmor
    {
      [Token(Token = "0x6015123"), Address(RVA = "0x4AAADA0", Offset = "0x4AAADA0", VA = "0x4AAADA0", Slot = "19")] get
      {
        return (int[]) null;
      }
      [Token(Token = "0x6015124"), Address(RVA = "0x4AAADA8", Offset = "0x4AAADA8", VA = "0x4AAADA8")] protected set
      {
      }
    }

    [Token(Token = "0x170045F9")]
    public int[] ResistSlayRide
    {
      [Token(Token = "0x6015125"), Address(RVA = "0x4AAADB0", Offset = "0x4AAADB0", VA = "0x4AAADB0", Slot = "20")] get
      {
        return (int[]) null;
      }
      [Token(Token = "0x6015126"), Address(RVA = "0x4AAADB8", Offset = "0x4AAADB8", VA = "0x4AAADB8")] protected set
      {
      }
    }

    [Token(Token = "0x170045FA")]
    public int[] ResistSlaySpecies
    {
      [Token(Token = "0x6015127"), Address(RVA = "0x4AAADC0", Offset = "0x4AAADC0", VA = "0x4AAADC0", Slot = "21")] get
      {
        return (int[]) null;
      }
      [Token(Token = "0x6015128"), Address(RVA = "0x4AAADC8", Offset = "0x4AAADC8", VA = "0x4AAADC8")] protected set
      {
      }
    }

    [Token(Token = "0x170045FB")]
    public bool IsEmpty
    {
      [Token(Token = "0x6015129"), Address(RVA = "0x4AAADD0", Offset = "0x4AAADD0", VA = "0x4AAADD0", Slot = "22")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x601512A")]
    [Address(RVA = "0x4AAADE0", Offset = "0x4AAADE0", VA = "0x4AAADE0")]
    protected EquipmentMindEquipmentModelBase()
    {
    }
  }
}
