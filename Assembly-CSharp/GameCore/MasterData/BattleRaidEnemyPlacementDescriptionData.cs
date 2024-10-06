// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.BattleRaidEnemyPlacementDescriptionData
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
  [Token(Token = "0x2000E3F")]
  [Serializable]
  public sealed class BattleRaidEnemyPlacementDescriptionData : IMasterDataEntity, IUnitPlacementData
  {
    [Token(Token = "0x4004406")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4004407")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int placement;
    [Token(Token = "0x4004408")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int troops;
    [Token(Token = "0x4004409")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int unitNo;
    [Token(Token = "0x400440A")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public bool isBoss;
    [Token(Token = "0x400440B")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int enemy;
    [Token(Token = "0x400440C")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public int correction;
    [Token(Token = "0x400440D")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    public bool skipDefeat;
    [Token(Token = "0x400440E")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public int x;
    [Token(Token = "0x400440F")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    public int y;
    [Token(Token = "0x4004410")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    public int fromX;
    [Token(Token = "0x4004411")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    public int fromY;
    [Token(Token = "0x4004412")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    public int waitTurnCount;
    [Token(Token = "0x4004413")]
    [FieldOffset(Offset = "0x44")]
    [SerializeField]
    public int barrier;
    [Token(Token = "0x4004414")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    public int barrierHp;
    [Token(Token = "0x4004415")]
    [FieldOffset(Offset = "0x4C")]
    [SerializeField]
    public int baseSupportRank;
    [Token(Token = "0x4004416")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    public int supportUnit1;
    [Token(Token = "0x4004417")]
    [FieldOffset(Offset = "0x54")]
    [SerializeField]
    public int supportRank1;
    [Token(Token = "0x4004418")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    public int supportUnit2;
    [Token(Token = "0x4004419")]
    [FieldOffset(Offset = "0x5C")]
    [SerializeField]
    public int supportRank2;
    [Token(Token = "0x400441A")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    public int supportUnit3;
    [Token(Token = "0x400441B")]
    [FieldOffset(Offset = "0x64")]
    [SerializeField]
    public int supportRank3;

    [Token(Token = "0x17000C8D")]
    public int Key
    {
      [Token(Token = "0x60056CB"), Address(RVA = "0x3E39954", Offset = "0x3E39954", VA = "0x3E39954", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60056CC")]
    [Address(RVA = "0x3E3995C", Offset = "0x3E3995C", VA = "0x3E3995C", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x60056CD")]
    [Address(RVA = "0x3E3A1F0", Offset = "0x3E3A1F0", VA = "0x3E3A1F0", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x17000C8E")]
    public int Id
    {
      [Token(Token = "0x60056CE"), Address(RVA = "0x3E3A3B4", Offset = "0x3E3A3B4", VA = "0x3E3A3B4", Slot = "7")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000C8F")]
    public int UnitNo
    {
      [Token(Token = "0x60056CF"), Address(RVA = "0x3E3A3BC", Offset = "0x3E3A3BC", VA = "0x3E3A3BC", Slot = "10")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000C90")]
    public int NpcMasterDataId
    {
      [Token(Token = "0x60056D0"), Address(RVA = "0x3E3A3C4", Offset = "0x3E3A3C4", VA = "0x3E3A3C4", Slot = "9")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000C91")]
    public int Troops
    {
      [Token(Token = "0x60056D1"), Address(RVA = "0x3E3A3CC", Offset = "0x3E3A3CC", VA = "0x3E3A3CC", Slot = "8")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000C92")]
    public int X
    {
      [Token(Token = "0x60056D2"), Address(RVA = "0x3E3A3D4", Offset = "0x3E3A3D4", VA = "0x3E3A3D4", Slot = "14")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000C93")]
    public int Y
    {
      [Token(Token = "0x60056D3"), Address(RVA = "0x3E3A3DC", Offset = "0x3E3A3DC", VA = "0x3E3A3DC", Slot = "15")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000C94")]
    public int SortieFromX
    {
      [Token(Token = "0x60056D4"), Address(RVA = "0x3E3A3E4", Offset = "0x3E3A3E4", VA = "0x3E3A3E4", Slot = "11")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000C95")]
    public int SortieFromY
    {
      [Token(Token = "0x60056D5"), Address(RVA = "0x3E3A3EC", Offset = "0x3E3A3EC", VA = "0x3E3A3EC", Slot = "12")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000C96")]
    public int WaitTurnCount
    {
      [Token(Token = "0x60056D6"), Address(RVA = "0x3E3A3F4", Offset = "0x3E3A3F4", VA = "0x3E3A3F4", Slot = "13")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000C97")]
    public int BaseExp
    {
      [Token(Token = "0x60056D7"), Address(RVA = "0x3E3A3FC", Offset = "0x3E3A3FC", VA = "0x3E3A3FC", Slot = "16")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000C98")]
    public int Damage
    {
      [Token(Token = "0x60056D8"), Address(RVA = "0x3E3A404", Offset = "0x3E3A404", VA = "0x3E3A404", Slot = "17")] get
      {
        return new int();
      }
      [Token(Token = "0x60056D9"), Address(RVA = "0x3E3A40C", Offset = "0x3E3A40C", VA = "0x3E3A40C", Slot = "18")] set
      {
      }
    }

    [Token(Token = "0x17000C99")]
    public int Barrier
    {
      [Token(Token = "0x60056DA"), Address(RVA = "0x3E3A414", Offset = "0x3E3A414", VA = "0x3E3A414", Slot = "19")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000C9A")]
    public int BarrierHp
    {
      [Token(Token = "0x60056DB"), Address(RVA = "0x3E3A41C", Offset = "0x3E3A41C", VA = "0x3E3A41C", Slot = "20")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000C9B")]
    public bool Modifiable
    {
      [Token(Token = "0x60056DC"), Address(RVA = "0x3E3A424", Offset = "0x3E3A424", VA = "0x3E3A424", Slot = "21")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000C9C")]
    public int BaseSupportRank
    {
      [Token(Token = "0x60056DD"), Address(RVA = "0x3E3A42C", Offset = "0x3E3A42C", VA = "0x3E3A42C", Slot = "22")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60056DE")]
    [Address(RVA = "0x3E3A434", Offset = "0x3E3A434", VA = "0x3E3A434", Slot = "23")]
    public Dictionary<int, int> GetSupportInfo() => (Dictionary<int, int>) null;

    [Token(Token = "0x17000C9D")]
    public QuestCorrection Correction
    {
      [Token(Token = "0x60056DF"), Address(RVA = "0x3E3A504", Offset = "0x3E3A504", VA = "0x3E3A504", Slot = "24")] get
      {
        return (QuestCorrection) null;
      }
      [Token(Token = "0x60056E0"), Address(RVA = "0x3E3A50C", Offset = "0x3E3A50C", VA = "0x3E3A50C", Slot = "25")] set
      {
      }
    }

    [Token(Token = "0x17000C9E")]
    public bool IsBoss
    {
      [Token(Token = "0x60056E1"), Address(RVA = "0x3E3A514", Offset = "0x3E3A514", VA = "0x3E3A514", Slot = "26")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x60056E2")]
    [Address(RVA = "0x3E3A51C", Offset = "0x3E3A51C", VA = "0x3E3A51C")]
    public BattleRaidEnemyPlacementDescriptionData()
    {
    }
  }
}
