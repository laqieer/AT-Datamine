// Decompiled with JetBrains decompiler
// Type: Battle.Data.Board.TrustData
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
  [Token(Token = "0x2002801")]
  public class TrustData : IBattleParameter, IItemData
  {
    [Token(Token = "0x400AA34")]
    [FieldOffset(Offset = "0x28")]
    private BattleParameter battleParameter;
    [Token(Token = "0x400AA37")]
    [FieldOffset(Offset = "0x40")]
    public int[] ReinforceAttack;
    [Token(Token = "0x400AA38")]
    [FieldOffset(Offset = "0x48")]
    public int[] ReinforceElement;
    [Token(Token = "0x400AA39")]
    [FieldOffset(Offset = "0x50")]
    public int[] ReinforceBadStat;
    [Token(Token = "0x400AA3A")]
    [FieldOffset(Offset = "0x58")]
    public int[] ResistAttack;
    [Token(Token = "0x400AA3B")]
    [FieldOffset(Offset = "0x60")]
    public int[] ResistElement;
    [Token(Token = "0x400AA3C")]
    [FieldOffset(Offset = "0x68")]
    public int[] ResistBadStat;

    [Token(Token = "0x17003680")]
    public int Id
    {
      [Token(Token = "0x600FA81"), Address(RVA = "0x44C72E4", Offset = "0x44C72E4", VA = "0x44C72E4")] get
      {
        return new int();
      }
      [Token(Token = "0x600FA82"), Address(RVA = "0x44C72EC", Offset = "0x44C72EC", VA = "0x44C72EC")] private set
      {
      }
    }

    [Token(Token = "0x17003681")]
    public UniqueID UniqueId
    {
      [Token(Token = "0x600FA83"), Address(RVA = "0x44C72F4", Offset = "0x44C72F4", VA = "0x44C72F4")] get
      {
        return new UniqueID();
      }
      [Token(Token = "0x600FA84"), Address(RVA = "0x44C72FC", Offset = "0x44C72FC", VA = "0x44C72FC")] private set
      {
      }
    }

    [Token(Token = "0x17003682")]
    public GameCore.MasterData.TrustData MasterData
    {
      [Token(Token = "0x600FA85"), Address(RVA = "0x44C7304", Offset = "0x44C7304", VA = "0x44C7304")] get
      {
        return (GameCore.MasterData.TrustData) null;
      }
      [Token(Token = "0x600FA86"), Address(RVA = "0x44C730C", Offset = "0x44C730C", VA = "0x44C730C")] private set
      {
      }
    }

    [Token(Token = "0x17003683")]
    public int Weight
    {
      [Token(Token = "0x600FA87"), Address(RVA = "0x44C7314", Offset = "0x44C7314", VA = "0x44C7314")] get
      {
        return new int();
      }
      [Token(Token = "0x600FA88"), Address(RVA = "0x44C731C", Offset = "0x44C731C", VA = "0x44C731C")] private set
      {
      }
    }

    [Token(Token = "0x17003684")]
    public List<SkillData> Skills
    {
      [Token(Token = "0x600FA89"), Address(RVA = "0x44C7324", Offset = "0x44C7324", VA = "0x44C7324")] get
      {
        return (List<SkillData>) null;
      }
      [Token(Token = "0x600FA8A"), Address(RVA = "0x44C732C", Offset = "0x44C732C", VA = "0x44C732C")] private set
      {
      }
    }

    [Token(Token = "0x17003685")]
    public int HP
    {
      [Token(Token = "0x600FA8B"), Address(RVA = "0x44C7334", Offset = "0x44C7334", VA = "0x44C7334", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17003686")]
    public int PhysicalAtk
    {
      [Token(Token = "0x600FA8C"), Address(RVA = "0x44C7350", Offset = "0x44C7350", VA = "0x44C7350", Slot = "5")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17003687")]
    public int PhysicalDef
    {
      [Token(Token = "0x600FA8D"), Address(RVA = "0x44C736C", Offset = "0x44C736C", VA = "0x44C736C", Slot = "6")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17003688")]
    public int MagicalAtk
    {
      [Token(Token = "0x600FA8E"), Address(RVA = "0x44C7388", Offset = "0x44C7388", VA = "0x44C7388", Slot = "7")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17003689")]
    public int MagicalDef
    {
      [Token(Token = "0x600FA8F"), Address(RVA = "0x44C73A4", Offset = "0x44C73A4", VA = "0x44C73A4", Slot = "8")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700368A")]
    public int Hit
    {
      [Token(Token = "0x600FA90"), Address(RVA = "0x44C73C0", Offset = "0x44C73C0", VA = "0x44C73C0", Slot = "9")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700368B")]
    public int Avoid
    {
      [Token(Token = "0x600FA91"), Address(RVA = "0x44C73DC", Offset = "0x44C73DC", VA = "0x44C73DC", Slot = "10")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700368C")]
    public int Critical
    {
      [Token(Token = "0x600FA92"), Address(RVA = "0x44C73F8", Offset = "0x44C73F8", VA = "0x44C73F8", Slot = "11")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700368D")]
    public int CriticalAvoid
    {
      [Token(Token = "0x600FA93"), Address(RVA = "0x44C7414", Offset = "0x44C7414", VA = "0x44C7414", Slot = "12")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700368E")]
    public int AtkSpeed
    {
      [Token(Token = "0x600FA94"), Address(RVA = "0x44C7430", Offset = "0x44C7430", VA = "0x44C7430", Slot = "13")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700368F")]
    public ItemTypeEnum ItemType
    {
      [Token(Token = "0x600FA95"), Address(RVA = "0x44C744C", Offset = "0x44C744C", VA = "0x44C744C", Slot = "14")] get
      {
        return new ItemTypeEnum();
      }
    }

    [Token(Token = "0x17003690")]
    public int ItemId
    {
      [Token(Token = "0x600FA96"), Address(RVA = "0x44C7454", Offset = "0x44C7454", VA = "0x44C7454", Slot = "15")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17003691")]
    public int Amount
    {
      [Token(Token = "0x600FA97"), Address(RVA = "0x44C7470", Offset = "0x44C7470", VA = "0x44C7470", Slot = "16")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17003692")]
    public int MaxAmount
    {
      [Token(Token = "0x600FA98"), Address(RVA = "0x44C7478", Offset = "0x44C7478", VA = "0x44C7478", Slot = "17")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17003693")]
    public string Name
    {
      [Token(Token = "0x600FA99"), Address(RVA = "0x44C7480", Offset = "0x44C7480", VA = "0x44C7480", Slot = "18")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x600FA9A")]
    [Address(RVA = "0x44C749C", Offset = "0x44C749C", VA = "0x44C749C")]
    public static TrustData Create(
      int id,
      UniqueID uniqueId,
      int masterId,
      IBattleParameter battleParameter,
      int weight,
      List<SkillData> skills)
    {
      return (TrustData) null;
    }

    [Token(Token = "0x600FA9B")]
    [Address(RVA = "0x44C768C", Offset = "0x44C768C", VA = "0x44C768C")]
    public void InitReinforce()
    {
    }

    [Token(Token = "0x600FA9C")]
    [Address(RVA = "0x44C80BC", Offset = "0x44C80BC", VA = "0x44C80BC")]
    public void InitResist()
    {
    }

    [Token(Token = "0x600FA9D")]
    [Address(RVA = "0x44C8AEC", Offset = "0x44C8AEC", VA = "0x44C8AEC", Slot = "3")]
    public override string ToString() => (string) null;

    [Token(Token = "0x600FA9E")]
    [Address(RVA = "0x44C8B90", Offset = "0x44C8B90", VA = "0x44C8B90")]
    public string ToJson() => (string) null;

    [Token(Token = "0x600FA9F")]
    [Address(RVA = "0x44C7610", Offset = "0x44C7610", VA = "0x44C7610")]
    public TrustData()
    {
    }
  }
}
