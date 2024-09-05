// Decompiled with JetBrains decompiler
// Type: Battle.Data.Board.MindEquipmentData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using StaqData;
using System.Collections.Generic;

#nullable disable
namespace Battle.Data.Board
{
  [Token(Token = "0x20027F2")]
  public class MindEquipmentData : IBattleParameter, IItemData
  {
    [Token(Token = "0x400A9EF")]
    [FieldOffset(Offset = "0x38")]
    private BattleParameter battleParameter;
    [Token(Token = "0x400A9F0")]
    [FieldOffset(Offset = "0x40")]
    public int[] ReinforceAttack;
    [Token(Token = "0x400A9F1")]
    [FieldOffset(Offset = "0x48")]
    public int[] ReinforceElement;
    [Token(Token = "0x400A9F2")]
    [FieldOffset(Offset = "0x50")]
    public int[] ReinforceBadStat;

    [Token(Token = "0x17003603")]
    public int Id
    {
      [Token(Token = "0x600F982"), Address(RVA = "0x44C2498", Offset = "0x44C2498", VA = "0x44C2498")] get
      {
        return new int();
      }
      [Token(Token = "0x600F983"), Address(RVA = "0x44C24A0", Offset = "0x44C24A0", VA = "0x44C24A0")] private set
      {
      }
    }

    [Token(Token = "0x17003604")]
    public UniqueID UniqueId
    {
      [Token(Token = "0x600F984"), Address(RVA = "0x44C24A8", Offset = "0x44C24A8", VA = "0x44C24A8")] get
      {
        return new UniqueID();
      }
      [Token(Token = "0x600F985"), Address(RVA = "0x44C24B0", Offset = "0x44C24B0", VA = "0x44C24B0")] private set
      {
      }
    }

    [Token(Token = "0x17003605")]
    public GameCore.MasterData.MindEquipmentData MasterData
    {
      [Token(Token = "0x600F986"), Address(RVA = "0x44C24B8", Offset = "0x44C24B8", VA = "0x44C24B8")] get
      {
        return (GameCore.MasterData.MindEquipmentData) null;
      }
      [Token(Token = "0x600F987"), Address(RVA = "0x44C24C0", Offset = "0x44C24C0", VA = "0x44C24C0")] private set
      {
      }
    }

    [Token(Token = "0x17003606")]
    public int Level
    {
      [Token(Token = "0x600F988"), Address(RVA = "0x44C24C8", Offset = "0x44C24C8", VA = "0x44C24C8")] get
      {
        return new int();
      }
      [Token(Token = "0x600F989"), Address(RVA = "0x44C24D0", Offset = "0x44C24D0", VA = "0x44C24D0")] private set
      {
      }
    }

    [Token(Token = "0x17003607")]
    public int LimitBreak
    {
      [Token(Token = "0x600F98A"), Address(RVA = "0x44C24D8", Offset = "0x44C24D8", VA = "0x44C24D8")] get
      {
        return new int();
      }
      [Token(Token = "0x600F98B"), Address(RVA = "0x44C24E0", Offset = "0x44C24E0", VA = "0x44C24E0")] private set
      {
      }
    }

    [Token(Token = "0x17003608")]
    public List<SkillData> Skills
    {
      [Token(Token = "0x600F98C"), Address(RVA = "0x44C24E8", Offset = "0x44C24E8", VA = "0x44C24E8")] get
      {
        return (List<SkillData>) null;
      }
      [Token(Token = "0x600F98D"), Address(RVA = "0x44C24F0", Offset = "0x44C24F0", VA = "0x44C24F0")] private set
      {
      }
    }

    [Token(Token = "0x17003609")]
    public int HP
    {
      [Token(Token = "0x600F98E"), Address(RVA = "0x44C24F8", Offset = "0x44C24F8", VA = "0x44C24F8", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700360A")]
    public int PhysicalAtk
    {
      [Token(Token = "0x600F98F"), Address(RVA = "0x44C2514", Offset = "0x44C2514", VA = "0x44C2514", Slot = "5")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700360B")]
    public int PhysicalDef
    {
      [Token(Token = "0x600F990"), Address(RVA = "0x44C2530", Offset = "0x44C2530", VA = "0x44C2530", Slot = "6")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700360C")]
    public int MagicalAtk
    {
      [Token(Token = "0x600F991"), Address(RVA = "0x44C254C", Offset = "0x44C254C", VA = "0x44C254C", Slot = "7")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700360D")]
    public int MagicalDef
    {
      [Token(Token = "0x600F992"), Address(RVA = "0x44C2568", Offset = "0x44C2568", VA = "0x44C2568", Slot = "8")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700360E")]
    public int Hit
    {
      [Token(Token = "0x600F993"), Address(RVA = "0x44C2584", Offset = "0x44C2584", VA = "0x44C2584", Slot = "9")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700360F")]
    public int Avoid
    {
      [Token(Token = "0x600F994"), Address(RVA = "0x44C25A0", Offset = "0x44C25A0", VA = "0x44C25A0", Slot = "10")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17003610")]
    public int Critical
    {
      [Token(Token = "0x600F995"), Address(RVA = "0x44C25BC", Offset = "0x44C25BC", VA = "0x44C25BC", Slot = "11")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17003611")]
    public int CriticalAvoid
    {
      [Token(Token = "0x600F996"), Address(RVA = "0x44C25D8", Offset = "0x44C25D8", VA = "0x44C25D8", Slot = "12")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17003612")]
    public int AtkSpeed
    {
      [Token(Token = "0x600F997"), Address(RVA = "0x44C25F4", Offset = "0x44C25F4", VA = "0x44C25F4", Slot = "13")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17003613")]
    public ItemTypeEnum ItemType
    {
      [Token(Token = "0x600F998"), Address(RVA = "0x44C2610", Offset = "0x44C2610", VA = "0x44C2610", Slot = "14")] get
      {
        return new ItemTypeEnum();
      }
    }

    [Token(Token = "0x17003614")]
    public int ItemId
    {
      [Token(Token = "0x600F999"), Address(RVA = "0x44C2618", Offset = "0x44C2618", VA = "0x44C2618", Slot = "15")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17003615")]
    public int Amount
    {
      [Token(Token = "0x600F99A"), Address(RVA = "0x44C2634", Offset = "0x44C2634", VA = "0x44C2634", Slot = "16")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17003616")]
    public int MaxAmount
    {
      [Token(Token = "0x600F99B"), Address(RVA = "0x44C263C", Offset = "0x44C263C", VA = "0x44C263C", Slot = "17")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17003617")]
    public string Name
    {
      [Token(Token = "0x600F99C"), Address(RVA = "0x44C2644", Offset = "0x44C2644", VA = "0x44C2644", Slot = "18")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17003618")]
    public int LevelCap
    {
      [Token(Token = "0x600F99D"), Address(RVA = "0x44C2660", Offset = "0x44C2660", VA = "0x44C2660")] get
      {
        return new int();
      }
      [Token(Token = "0x600F99E"), Address(RVA = "0x44C2668", Offset = "0x44C2668", VA = "0x44C2668")] private set
      {
      }
    }

    [Token(Token = "0x17003619")]
    public int MaxLimitBreak
    {
      [Token(Token = "0x600F99F"), Address(RVA = "0x44C2670", Offset = "0x44C2670", VA = "0x44C2670")] get
      {
        return new int();
      }
      [Token(Token = "0x600F9A0"), Address(RVA = "0x44C2678", Offset = "0x44C2678", VA = "0x44C2678")] private set
      {
      }
    }

    [Token(Token = "0x600F9A1")]
    [Address(RVA = "0x44C2680", Offset = "0x44C2680", VA = "0x44C2680")]
    public static MindEquipmentData Create(MindEquipmentSource source) => (MindEquipmentData) null;

    [Token(Token = "0x600F9A2")]
    [Address(RVA = "0x44C28C8", Offset = "0x44C28C8", VA = "0x44C28C8")]
    private void UpdateBattleParameter()
    {
    }

    [Token(Token = "0x600F9A3")]
    [Address(RVA = "0x44C2984", Offset = "0x44C2984", VA = "0x44C2984", Slot = "3")]
    public override string ToString() => (string) null;

    [Token(Token = "0x600F9A4")]
    [Address(RVA = "0x44C2A28", Offset = "0x44C2A28", VA = "0x44C2A28")]
    public string ToJson() => (string) null;

    [Token(Token = "0x600F9A5")]
    [Address(RVA = "0x44C284C", Offset = "0x44C284C", VA = "0x44C284C")]
    public MindEquipmentData()
    {
    }
  }
}
