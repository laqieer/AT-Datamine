// Decompiled with JetBrains decompiler
// Type: Battle.Data.Board.AccessoryData
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
  [Token(Token = "0x2002751")]
  public class AccessoryData : IBasicParameter, IBattleParameter, IItemData
  {
    [Token(Token = "0x400A7ED")]
    [FieldOffset(Offset = "0x38")]
    private BasicParameter basicParameter;
    [Token(Token = "0x400A7EE")]
    [FieldOffset(Offset = "0x40")]
    private BattleParameter battleParameter;
    [Token(Token = "0x400A7F1")]
    [FieldOffset(Offset = "0x58")]
    public int[] ReinforceAttack;
    [Token(Token = "0x400A7F2")]
    [FieldOffset(Offset = "0x60")]
    public int[] ReinforceElement;
    [Token(Token = "0x400A7F3")]
    [FieldOffset(Offset = "0x68")]
    public int[] ReinforceBadStat;
    [Token(Token = "0x400A7F4")]
    [FieldOffset(Offset = "0x70")]
    public int[] ResistAttack;
    [Token(Token = "0x400A7F5")]
    [FieldOffset(Offset = "0x78")]
    public int[] ResistElement;
    [Token(Token = "0x400A7F6")]
    [FieldOffset(Offset = "0x80")]
    public int[] ResistBadStat;

    [Token(Token = "0x17003464")]
    public string Id
    {
      [Token(Token = "0x600F522"), Address(RVA = "0x1FB4398", Offset = "0x1FB4398", VA = "0x1FB4398")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600F523"), Address(RVA = "0x1FB43A0", Offset = "0x1FB43A0", VA = "0x1FB43A0")] private set
      {
      }
    }

    [Token(Token = "0x17003465")]
    public UniqueID UniqueId
    {
      [Token(Token = "0x600F524"), Address(RVA = "0x1FB43A8", Offset = "0x1FB43A8", VA = "0x1FB43A8")] get
      {
        return new UniqueID();
      }
      [Token(Token = "0x600F525"), Address(RVA = "0x1FB43B0", Offset = "0x1FB43B0", VA = "0x1FB43B0")] private set
      {
      }
    }

    [Token(Token = "0x17003466")]
    public AccessoriesData MasterData
    {
      [Token(Token = "0x600F526"), Address(RVA = "0x1FB43B8", Offset = "0x1FB43B8", VA = "0x1FB43B8")] get
      {
        return (AccessoriesData) null;
      }
      [Token(Token = "0x600F527"), Address(RVA = "0x1FB43C0", Offset = "0x1FB43C0", VA = "0x1FB43C0")] private set
      {
      }
    }

    [Token(Token = "0x17003467")]
    public int Level
    {
      [Token(Token = "0x600F528"), Address(RVA = "0x1FB43C8", Offset = "0x1FB43C8", VA = "0x1FB43C8")] get
      {
        return new int();
      }
      [Token(Token = "0x600F529"), Address(RVA = "0x1FB43D0", Offset = "0x1FB43D0", VA = "0x1FB43D0")] private set
      {
      }
    }

    [Token(Token = "0x17003468")]
    public int LimitBreak
    {
      [Token(Token = "0x600F52A"), Address(RVA = "0x1FB43D8", Offset = "0x1FB43D8", VA = "0x1FB43D8")] get
      {
        return new int();
      }
      [Token(Token = "0x600F52B"), Address(RVA = "0x1FB43E0", Offset = "0x1FB43E0", VA = "0x1FB43E0")] private set
      {
      }
    }

    [Token(Token = "0x17003469")]
    public int Weight
    {
      [Token(Token = "0x600F52C"), Address(RVA = "0x1FB43E8", Offset = "0x1FB43E8", VA = "0x1FB43E8")] get
      {
        return new int();
      }
      [Token(Token = "0x600F52D"), Address(RVA = "0x1FB43F0", Offset = "0x1FB43F0", VA = "0x1FB43F0")] private set
      {
      }
    }

    [Token(Token = "0x1700346A")]
    public List<SkillData> Skills
    {
      [Token(Token = "0x600F52E"), Address(RVA = "0x1FB43F8", Offset = "0x1FB43F8", VA = "0x1FB43F8")] get
      {
        return (List<SkillData>) null;
      }
      [Token(Token = "0x600F52F"), Address(RVA = "0x1FB4400", Offset = "0x1FB4400", VA = "0x1FB4400")] private set
      {
      }
    }

    [Token(Token = "0x1700346B")]
    public List<AccessoryOptionEffect> Options
    {
      [Token(Token = "0x600F530"), Address(RVA = "0x1FB4408", Offset = "0x1FB4408", VA = "0x1FB4408")] get
      {
        return (List<AccessoryOptionEffect>) null;
      }
      [Token(Token = "0x600F531"), Address(RVA = "0x1FB4410", Offset = "0x1FB4410", VA = "0x1FB4410")] private set
      {
      }
    }

    [Token(Token = "0x1700346C")]
    public int Life
    {
      [Token(Token = "0x600F532"), Address(RVA = "0x1FB4418", Offset = "0x1FB4418", VA = "0x1FB4418", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700346D")]
    public int Strength
    {
      [Token(Token = "0x600F533"), Address(RVA = "0x1FB4434", Offset = "0x1FB4434", VA = "0x1FB4434", Slot = "5")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700346E")]
    public int Intelligence
    {
      [Token(Token = "0x600F534"), Address(RVA = "0x1FB4450", Offset = "0x1FB4450", VA = "0x1FB4450", Slot = "6")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700346F")]
    public int Vitality
    {
      [Token(Token = "0x600F535"), Address(RVA = "0x1FB446C", Offset = "0x1FB446C", VA = "0x1FB446C", Slot = "7")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17003470")]
    public int Mind
    {
      [Token(Token = "0x600F536"), Address(RVA = "0x1FB4488", Offset = "0x1FB4488", VA = "0x1FB4488", Slot = "8")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17003471")]
    public int Agility
    {
      [Token(Token = "0x600F537"), Address(RVA = "0x1FB44A4", Offset = "0x1FB44A4", VA = "0x1FB44A4", Slot = "9")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17003472")]
    public int Dexterity
    {
      [Token(Token = "0x600F538"), Address(RVA = "0x1FB44C0", Offset = "0x1FB44C0", VA = "0x1FB44C0", Slot = "10")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17003473")]
    public int Lucky
    {
      [Token(Token = "0x600F539"), Address(RVA = "0x1FB44DC", Offset = "0x1FB44DC", VA = "0x1FB44DC", Slot = "11")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17003474")]
    public int HP
    {
      [Token(Token = "0x600F53A"), Address(RVA = "0x1FB44F8", Offset = "0x1FB44F8", VA = "0x1FB44F8", Slot = "12")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17003475")]
    public int PhysicalAtk
    {
      [Token(Token = "0x600F53B"), Address(RVA = "0x1FB4514", Offset = "0x1FB4514", VA = "0x1FB4514", Slot = "13")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17003476")]
    public int PhysicalDef
    {
      [Token(Token = "0x600F53C"), Address(RVA = "0x1FB4530", Offset = "0x1FB4530", VA = "0x1FB4530", Slot = "14")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17003477")]
    public int MagicalAtk
    {
      [Token(Token = "0x600F53D"), Address(RVA = "0x1FB454C", Offset = "0x1FB454C", VA = "0x1FB454C", Slot = "15")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17003478")]
    public int MagicalDef
    {
      [Token(Token = "0x600F53E"), Address(RVA = "0x1FB4568", Offset = "0x1FB4568", VA = "0x1FB4568", Slot = "16")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17003479")]
    public int Hit
    {
      [Token(Token = "0x600F53F"), Address(RVA = "0x1FB4584", Offset = "0x1FB4584", VA = "0x1FB4584", Slot = "17")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700347A")]
    public int Avoid
    {
      [Token(Token = "0x600F540"), Address(RVA = "0x1FB45A0", Offset = "0x1FB45A0", VA = "0x1FB45A0", Slot = "18")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700347B")]
    public int Critical
    {
      [Token(Token = "0x600F541"), Address(RVA = "0x1FB45BC", Offset = "0x1FB45BC", VA = "0x1FB45BC", Slot = "19")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700347C")]
    public int CriticalAvoid
    {
      [Token(Token = "0x600F542"), Address(RVA = "0x1FB45D8", Offset = "0x1FB45D8", VA = "0x1FB45D8", Slot = "20")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700347D")]
    public int AtkSpeed
    {
      [Token(Token = "0x600F543"), Address(RVA = "0x1FB45F4", Offset = "0x1FB45F4", VA = "0x1FB45F4", Slot = "21")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700347E")]
    public ItemTypeEnum ItemType
    {
      [Token(Token = "0x600F544"), Address(RVA = "0x1FB4610", Offset = "0x1FB4610", VA = "0x1FB4610", Slot = "22")] get
      {
        return new ItemTypeEnum();
      }
    }

    [Token(Token = "0x1700347F")]
    public int ItemId
    {
      [Token(Token = "0x600F545"), Address(RVA = "0x1FB4618", Offset = "0x1FB4618", VA = "0x1FB4618", Slot = "23")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17003480")]
    public int Amount
    {
      [Token(Token = "0x600F546"), Address(RVA = "0x1FB4634", Offset = "0x1FB4634", VA = "0x1FB4634", Slot = "24")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17003481")]
    public int MaxAmount
    {
      [Token(Token = "0x600F547"), Address(RVA = "0x1FB463C", Offset = "0x1FB463C", VA = "0x1FB463C", Slot = "25")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17003482")]
    public string Name
    {
      [Token(Token = "0x600F548"), Address(RVA = "0x1FB4644", Offset = "0x1FB4644", VA = "0x1FB4644", Slot = "26")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17003483")]
    public int MaxLimitBreak
    {
      [Token(Token = "0x600F549"), Address(RVA = "0x1FB4660", Offset = "0x1FB4660", VA = "0x1FB4660")] get
      {
        return new int();
      }
      [Token(Token = "0x600F54A"), Address(RVA = "0x1FB4668", Offset = "0x1FB4668", VA = "0x1FB4668")] private set
      {
      }
    }

    [Token(Token = "0x17003484")]
    public int LevelCap
    {
      [Token(Token = "0x600F54B"), Address(RVA = "0x1FB4670", Offset = "0x1FB4670", VA = "0x1FB4670")] get
      {
        return new int();
      }
      [Token(Token = "0x600F54C"), Address(RVA = "0x1FB4678", Offset = "0x1FB4678", VA = "0x1FB4678")] private set
      {
      }
    }

    [Token(Token = "0x600F54D")]
    [Address(RVA = "0x1FB4680", Offset = "0x1FB4680", VA = "0x1FB4680")]
    public static AccessoryData Create(AccessorySource source) => (AccessoryData) null;

    [Token(Token = "0x600F54E")]
    [Address(RVA = "0x1FB4948", Offset = "0x1FB4948", VA = "0x1FB4948")]
    private void UpdateParameter()
    {
    }

    [Token(Token = "0x600F54F")]
    [Address(RVA = "0x1FB4AA8", Offset = "0x1FB4AA8", VA = "0x1FB4AA8", Slot = "3")]
    public override string ToString() => (string) null;

    [Token(Token = "0x600F550")]
    [Address(RVA = "0x1FB4B14", Offset = "0x1FB4B14", VA = "0x1FB4B14")]
    public string ToJson() => (string) null;

    [Token(Token = "0x600F551")]
    [Address(RVA = "0x1FB4878", Offset = "0x1FB4878", VA = "0x1FB4878")]
    public AccessoryData()
    {
    }
  }
}
