// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.BattleEnemyPlacementDescriptionData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000E39")]
  [Serializable]
  public sealed class BattleEnemyPlacementDescriptionData : IMasterDataEntity, IUnitPlacementData
  {
    [Token(Token = "0x40043E4")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x40043E5")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int placement;
    [Token(Token = "0x40043E6")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int troops;
    [Token(Token = "0x40043E7")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int unitNo;
    [Token(Token = "0x40043E8")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int enemy;
    [Token(Token = "0x40043E9")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public bool skipDefeat;
    [Token(Token = "0x40043EA")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public int x;
    [Token(Token = "0x40043EB")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    public int y;
    [Token(Token = "0x40043EC")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public int fromX;
    [Token(Token = "0x40043ED")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    public int fromY;
    [Token(Token = "0x40043EE")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    public int waitTurnCount;
    [Token(Token = "0x40043EF")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    public int barrier;
    [Token(Token = "0x40043F0")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    public int barrierHp;
    [Token(Token = "0x40043F1")]
    [FieldOffset(Offset = "0x44")]
    [SerializeField]
    public int barrierRecovery;
    [Token(Token = "0x40043F2")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    public int baseSupportRank;
    [Token(Token = "0x40043F3")]
    [FieldOffset(Offset = "0x4C")]
    [SerializeField]
    public int supportUnit1;
    [Token(Token = "0x40043F4")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    public int supportRank1;
    [Token(Token = "0x40043F5")]
    [FieldOffset(Offset = "0x54")]
    [SerializeField]
    public int supportUnit2;
    [Token(Token = "0x40043F6")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    public int supportRank2;
    [Token(Token = "0x40043F7")]
    [FieldOffset(Offset = "0x5C")]
    [SerializeField]
    public int supportUnit3;
    [Token(Token = "0x40043F8")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    public int supportRank3;
    [Token(Token = "0x40043F9")]
    [FieldOffset(Offset = "0x64")]
    [SerializeField]
    public int drop;
    [Token(Token = "0x40043FA")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    public int exp;

    [Token(Token = "0x17000C76")]
    public int Key
    {
      [Token(Token = "0x6005698"), Address(RVA = "0x3E3806C", Offset = "0x3E3806C", VA = "0x3E3806C", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005699")]
    [Address(RVA = "0x3E38074", Offset = "0x3E38074", VA = "0x3E38074", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x600569A")]
    [Address(RVA = "0x3E38964", Offset = "0x3E38964", VA = "0x3E38964", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x17000C77")]
    public int Id
    {
      [Token(Token = "0x600569B"), Address(RVA = "0x3E38B38", Offset = "0x3E38B38", VA = "0x3E38B38", Slot = "7")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000C78")]
    public int UnitNo
    {
      [Token(Token = "0x600569C"), Address(RVA = "0x3E38B40", Offset = "0x3E38B40", VA = "0x3E38B40", Slot = "10")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000C79")]
    public int NpcMasterDataId
    {
      [Token(Token = "0x600569D"), Address(RVA = "0x3E38B48", Offset = "0x3E38B48", VA = "0x3E38B48", Slot = "9")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000C7A")]
    public int Troops
    {
      [Token(Token = "0x600569E"), Address(RVA = "0x3E38B50", Offset = "0x3E38B50", VA = "0x3E38B50", Slot = "8")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000C7B")]
    public int X
    {
      [Token(Token = "0x600569F"), Address(RVA = "0x3E38B58", Offset = "0x3E38B58", VA = "0x3E38B58", Slot = "14")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000C7C")]
    public int Y
    {
      [Token(Token = "0x60056A0"), Address(RVA = "0x3E38B60", Offset = "0x3E38B60", VA = "0x3E38B60", Slot = "15")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000C7D")]
    public int SortieFromX
    {
      [Token(Token = "0x60056A1"), Address(RVA = "0x3E38B68", Offset = "0x3E38B68", VA = "0x3E38B68", Slot = "11")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000C7E")]
    public int SortieFromY
    {
      [Token(Token = "0x60056A2"), Address(RVA = "0x3E38B70", Offset = "0x3E38B70", VA = "0x3E38B70", Slot = "12")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000C7F")]
    public int WaitTurnCount
    {
      [Token(Token = "0x60056A3"), Address(RVA = "0x3E38B78", Offset = "0x3E38B78", VA = "0x3E38B78", Slot = "13")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000C80")]
    public int BaseExp
    {
      [Token(Token = "0x60056A4"), Address(RVA = "0x3E38B80", Offset = "0x3E38B80", VA = "0x3E38B80", Slot = "16")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000C81")]
    public int Damage
    {
      [Token(Token = "0x60056A5"), Address(RVA = "0x3E38B88", Offset = "0x3E38B88", VA = "0x3E38B88", Slot = "18")] set
      {
      }
      [Token(Token = "0x60056A6"), Address(RVA = "0x3E38B90", Offset = "0x3E38B90", VA = "0x3E38B90", Slot = "17")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000C82")]
    public int Barrier
    {
      [Token(Token = "0x60056A7"), Address(RVA = "0x3E38B98", Offset = "0x3E38B98", VA = "0x3E38B98", Slot = "19")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000C83")]
    public int BarrierHp
    {
      [Token(Token = "0x60056A8"), Address(RVA = "0x3E38BA0", Offset = "0x3E38BA0", VA = "0x3E38BA0", Slot = "20")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000C84")]
    public bool Modifiable
    {
      [Token(Token = "0x60056A9"), Address(RVA = "0x3E38BA8", Offset = "0x3E38BA8", VA = "0x3E38BA8", Slot = "21")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000C85")]
    public int BaseSupportRank
    {
      [Token(Token = "0x60056AA"), Address(RVA = "0x3E38BB0", Offset = "0x3E38BB0", VA = "0x3E38BB0", Slot = "22")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60056AB")]
    [Address(RVA = "0x3E38BB8", Offset = "0x3E38BB8", VA = "0x3E38BB8", Slot = "23")]
    public Dictionary<int, int> GetSupportInfo() => (Dictionary<int, int>) null;

    [Token(Token = "0x17000C86")]
    public QuestCorrection Correction
    {
      [Token(Token = "0x60056AC"), Address(RVA = "0x3E38C88", Offset = "0x3E38C88", VA = "0x3E38C88", Slot = "25")] set
      {
      }
      [Token(Token = "0x60056AD"), Address(RVA = "0x3E38C90", Offset = "0x3E38C90", VA = "0x3E38C90", Slot = "24")] get
      {
        return (QuestCorrection) null;
      }
    }

    [Token(Token = "0x17000C87")]
    public bool IsBoss
    {
      [Token(Token = "0x60056AE"), Address(RVA = "0x3E38C98", Offset = "0x3E38C98", VA = "0x3E38C98", Slot = "26")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x60056AF")]
    [Address(RVA = "0x3E38CA0", Offset = "0x3E38CA0", VA = "0x3E38CA0")]
    public BattleEnemyPlacementDescriptionData()
    {
    }
  }
}
