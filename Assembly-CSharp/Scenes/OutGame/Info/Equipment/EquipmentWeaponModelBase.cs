// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Info.Equipment.EquipmentWeaponModelBase
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
  [Token(Token = "0x20035A1")]
  public abstract class EquipmentWeaponModelBase
  {
    [Token(Token = "0x400E941")]
    [FieldOffset(Offset = "0x10")]
    public Action OnChange;

    [Token(Token = "0x17004617")]
    public abstract SkillModelListBase SkillModelList { [Token(Token = "0x6015160")] get; }

    [Token(Token = "0x17004618")]
    public abstract ParameterModelBase Parameter { [Token(Token = "0x6015161")] get; }

    [Token(Token = "0x17004619")]
    public abstract EquipmentCommonModelBase Common { [Token(Token = "0x6015162")] get; }

    [Token(Token = "0x1700461A")]
    public int Id
    {
      [Token(Token = "0x6015163"), Address(RVA = "0x4AAB710", Offset = "0x4AAB710", VA = "0x4AAB710", Slot = "7")] get
      {
        return new int();
      }
      [Token(Token = "0x6015164"), Address(RVA = "0x4AAB718", Offset = "0x4AAB718", VA = "0x4AAB718")] protected set
      {
      }
    }

    [Token(Token = "0x1700461B")]
    public int Level
    {
      [Token(Token = "0x6015165"), Address(RVA = "0x4AAB720", Offset = "0x4AAB720", VA = "0x4AAB720")] get
      {
        return new int();
      }
      [Token(Token = "0x6015166"), Address(RVA = "0x4AAB728", Offset = "0x4AAB728", VA = "0x4AAB728")] set
      {
      }
    }

    [Token(Token = "0x1700461C")]
    public int LevelMax
    {
      [Token(Token = "0x6015167"), Address(RVA = "0x4AAB730", Offset = "0x4AAB730", VA = "0x4AAB730")] get
      {
        return new int();
      }
      [Token(Token = "0x6015168"), Address(RVA = "0x4AAB738", Offset = "0x4AAB738", VA = "0x4AAB738")] set
      {
      }
    }

    [Token(Token = "0x1700461D")]
    public int LimitBreakCount
    {
      [Token(Token = "0x6015169"), Address(RVA = "0x4AAB740", Offset = "0x4AAB740", VA = "0x4AAB740")] get
      {
        return new int();
      }
      [Token(Token = "0x601516A"), Address(RVA = "0x4AAB748", Offset = "0x4AAB748", VA = "0x4AAB748")] set
      {
      }
    }

    [Token(Token = "0x1700461E")]
    public int LimitBreakCountMax
    {
      [Token(Token = "0x601516B"), Address(RVA = "0x4AAB750", Offset = "0x4AAB750", VA = "0x4AAB750")] get
      {
        return new int();
      }
      [Token(Token = "0x601516C"), Address(RVA = "0x4AAB758", Offset = "0x4AAB758", VA = "0x4AAB758")] set
      {
      }
    }

    [Token(Token = "0x1700461F")]
    public AttackTypeEnum AttackType
    {
      [Token(Token = "0x601516D"), Address(RVA = "0x4AAB760", Offset = "0x4AAB760", VA = "0x4AAB760")] get
      {
        return new AttackTypeEnum();
      }
      [Token(Token = "0x601516E"), Address(RVA = "0x4AAB768", Offset = "0x4AAB768", VA = "0x4AAB768")] set
      {
      }
    }

    [Token(Token = "0x17004620")]
    public WeaponTypeEnum WeaponType
    {
      [Token(Token = "0x601516F"), Address(RVA = "0x4AAB770", Offset = "0x4AAB770", VA = "0x4AAB770")] get
      {
        return new WeaponTypeEnum();
      }
      [Token(Token = "0x6015170"), Address(RVA = "0x4AAB778", Offset = "0x4AAB778", VA = "0x4AAB778")] set
      {
      }
    }

    [Token(Token = "0x17004621")]
    public int RangeMin
    {
      [Token(Token = "0x6015171"), Address(RVA = "0x4AAB780", Offset = "0x4AAB780", VA = "0x4AAB780")] get
      {
        return new int();
      }
      [Token(Token = "0x6015172"), Address(RVA = "0x4AAB788", Offset = "0x4AAB788", VA = "0x4AAB788")] set
      {
      }
    }

    [Token(Token = "0x17004622")]
    public int RangeMax
    {
      [Token(Token = "0x6015173"), Address(RVA = "0x4AAB790", Offset = "0x4AAB790", VA = "0x4AAB790")] get
      {
        return new int();
      }
      [Token(Token = "0x6015174"), Address(RVA = "0x4AAB798", Offset = "0x4AAB798", VA = "0x4AAB798")] set
      {
      }
    }

    [Token(Token = "0x17004623")]
    public int RangeTypeID
    {
      [Token(Token = "0x6015175"), Address(RVA = "0x4AAB7A0", Offset = "0x4AAB7A0", VA = "0x4AAB7A0")] get
      {
        return new int();
      }
      [Token(Token = "0x6015176"), Address(RVA = "0x4AAB7A8", Offset = "0x4AAB7A8", VA = "0x4AAB7A8")] set
      {
      }
    }

    [Token(Token = "0x17004624")]
    public int OptionSlotMax
    {
      [Token(Token = "0x6015177"), Address(RVA = "0x4AAB7B0", Offset = "0x4AAB7B0", VA = "0x4AAB7B0")] get
      {
        return new int();
      }
      [Token(Token = "0x6015178"), Address(RVA = "0x4AAB7B8", Offset = "0x4AAB7B8", VA = "0x4AAB7B8")] set
      {
      }
    }

    [Token(Token = "0x17004625")]
    public IEnumerable<WeaponOptionEffect> OptionEffects
    {
      [Token(Token = "0x6015179"), Address(RVA = "0x4AAB7C0", Offset = "0x4AAB7C0", VA = "0x4AAB7C0")] get
      {
        return (IEnumerable<WeaponOptionEffect>) null;
      }
      [Token(Token = "0x601517A"), Address(RVA = "0x4AAB7C8", Offset = "0x4AAB7C8", VA = "0x4AAB7C8")] protected set
      {
      }
    }

    [Token(Token = "0x17004626")]
    public int Endurance
    {
      [Token(Token = "0x601517B"), Address(RVA = "0x4AAB7D0", Offset = "0x4AAB7D0", VA = "0x4AAB7D0")] get
      {
        return new int();
      }
      [Token(Token = "0x601517C"), Address(RVA = "0x4AAB7D8", Offset = "0x4AAB7D8", VA = "0x4AAB7D8")] set
      {
      }
    }

    [Token(Token = "0x17004627")]
    public int[] ReinforceAttack
    {
      [Token(Token = "0x601517D"), Address(RVA = "0x4AAB7E0", Offset = "0x4AAB7E0", VA = "0x4AAB7E0", Slot = "8")] get
      {
        return (int[]) null;
      }
      [Token(Token = "0x601517E"), Address(RVA = "0x4AAB7E8", Offset = "0x4AAB7E8", VA = "0x4AAB7E8")] protected set
      {
      }
    }

    [Token(Token = "0x17004628")]
    public int[] ReinforceElement
    {
      [Token(Token = "0x601517F"), Address(RVA = "0x4AAB7F0", Offset = "0x4AAB7F0", VA = "0x4AAB7F0", Slot = "9")] get
      {
        return (int[]) null;
      }
      [Token(Token = "0x6015180"), Address(RVA = "0x4AAB7F8", Offset = "0x4AAB7F8", VA = "0x4AAB7F8")] protected set
      {
      }
    }

    [Token(Token = "0x17004629")]
    public int[] ReinforceBadStatus
    {
      [Token(Token = "0x6015181"), Address(RVA = "0x4AAB800", Offset = "0x4AAB800", VA = "0x4AAB800", Slot = "10")] get
      {
        return (int[]) null;
      }
      [Token(Token = "0x6015182"), Address(RVA = "0x4AAB808", Offset = "0x4AAB808", VA = "0x4AAB808")] protected set
      {
      }
    }

    [Token(Token = "0x1700462A")]
    public int[] ResistAttack
    {
      [Token(Token = "0x6015183"), Address(RVA = "0x4AAB810", Offset = "0x4AAB810", VA = "0x4AAB810", Slot = "11")] get
      {
        return (int[]) null;
      }
      [Token(Token = "0x6015184"), Address(RVA = "0x4AAB818", Offset = "0x4AAB818", VA = "0x4AAB818")] protected set
      {
      }
    }

    [Token(Token = "0x1700462B")]
    public int[] ResistElement
    {
      [Token(Token = "0x6015185"), Address(RVA = "0x4AAB820", Offset = "0x4AAB820", VA = "0x4AAB820", Slot = "12")] get
      {
        return (int[]) null;
      }
      [Token(Token = "0x6015186"), Address(RVA = "0x4AAB828", Offset = "0x4AAB828", VA = "0x4AAB828")] protected set
      {
      }
    }

    [Token(Token = "0x1700462C")]
    public int[] ResistBadStatus
    {
      [Token(Token = "0x6015187"), Address(RVA = "0x4AAB830", Offset = "0x4AAB830", VA = "0x4AAB830", Slot = "13")] get
      {
        return (int[]) null;
      }
      [Token(Token = "0x6015188"), Address(RVA = "0x4AAB838", Offset = "0x4AAB838", VA = "0x4AAB838")] protected set
      {
      }
    }

    [Token(Token = "0x1700462D")]
    public int[] SlayMove
    {
      [Token(Token = "0x6015189"), Address(RVA = "0x4AAB840", Offset = "0x4AAB840", VA = "0x4AAB840", Slot = "14")] get
      {
        return (int[]) null;
      }
      [Token(Token = "0x601518A"), Address(RVA = "0x4AAB848", Offset = "0x4AAB848", VA = "0x4AAB848")] protected set
      {
      }
    }

    [Token(Token = "0x1700462E")]
    public int[] SlayArmor
    {
      [Token(Token = "0x601518B"), Address(RVA = "0x4AAB850", Offset = "0x4AAB850", VA = "0x4AAB850", Slot = "15")] get
      {
        return (int[]) null;
      }
      [Token(Token = "0x601518C"), Address(RVA = "0x4AAB858", Offset = "0x4AAB858", VA = "0x4AAB858")] protected set
      {
      }
    }

    [Token(Token = "0x1700462F")]
    public int[] SlayRide
    {
      [Token(Token = "0x601518D"), Address(RVA = "0x4AAB860", Offset = "0x4AAB860", VA = "0x4AAB860", Slot = "16")] get
      {
        return (int[]) null;
      }
      [Token(Token = "0x601518E"), Address(RVA = "0x4AAB868", Offset = "0x4AAB868", VA = "0x4AAB868")] protected set
      {
      }
    }

    [Token(Token = "0x17004630")]
    public int[] SlaySpecies
    {
      [Token(Token = "0x601518F"), Address(RVA = "0x4AAB870", Offset = "0x4AAB870", VA = "0x4AAB870", Slot = "17")] get
      {
        return (int[]) null;
      }
      [Token(Token = "0x6015190"), Address(RVA = "0x4AAB878", Offset = "0x4AAB878", VA = "0x4AAB878")] protected set
      {
      }
    }

    [Token(Token = "0x17004631")]
    public int[] ResistSlayMove
    {
      [Token(Token = "0x6015191"), Address(RVA = "0x4AAB880", Offset = "0x4AAB880", VA = "0x4AAB880", Slot = "18")] get
      {
        return (int[]) null;
      }
      [Token(Token = "0x6015192"), Address(RVA = "0x4AAB888", Offset = "0x4AAB888", VA = "0x4AAB888")] protected set
      {
      }
    }

    [Token(Token = "0x17004632")]
    public int[] ResistSlayArmor
    {
      [Token(Token = "0x6015193"), Address(RVA = "0x4AAB890", Offset = "0x4AAB890", VA = "0x4AAB890", Slot = "19")] get
      {
        return (int[]) null;
      }
      [Token(Token = "0x6015194"), Address(RVA = "0x4AAB898", Offset = "0x4AAB898", VA = "0x4AAB898")] protected set
      {
      }
    }

    [Token(Token = "0x17004633")]
    public int[] ResistSlayRide
    {
      [Token(Token = "0x6015195"), Address(RVA = "0x4AAB8A0", Offset = "0x4AAB8A0", VA = "0x4AAB8A0", Slot = "20")] get
      {
        return (int[]) null;
      }
      [Token(Token = "0x6015196"), Address(RVA = "0x4AAB8A8", Offset = "0x4AAB8A8", VA = "0x4AAB8A8")] protected set
      {
      }
    }

    [Token(Token = "0x17004634")]
    public int[] ResistSlaySpecies
    {
      [Token(Token = "0x6015197"), Address(RVA = "0x4AAB8B0", Offset = "0x4AAB8B0", VA = "0x4AAB8B0", Slot = "21")] get
      {
        return (int[]) null;
      }
      [Token(Token = "0x6015198"), Address(RVA = "0x4AAB8B8", Offset = "0x4AAB8B8", VA = "0x4AAB8B8")] protected set
      {
      }
    }

    [Token(Token = "0x17004635")]
    public bool IsEmpty
    {
      [Token(Token = "0x6015199"), Address(RVA = "0x4AAB8C0", Offset = "0x4AAB8C0", VA = "0x4AAB8C0", Slot = "22")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17004636")]
    public abstract bool IsUnknown { [Token(Token = "0x601519A")] get; }

    [Token(Token = "0x601519B")]
    [Address(RVA = "0x4AAB8D0", Offset = "0x4AAB8D0", VA = "0x4AAB8D0")]
    protected EquipmentWeaponModelBase()
    {
    }
  }
}
