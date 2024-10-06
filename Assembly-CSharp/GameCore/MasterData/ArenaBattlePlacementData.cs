// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.ArenaBattlePlacementData
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
  [Token(Token = "0x2000DD7")]
  [Serializable]
  public sealed class ArenaBattlePlacementData : IMasterDataEntity, IUnitPlacementData
  {
    [Token(Token = "0x400423B")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x400423C")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int placementGroup;
    [Token(Token = "0x400423D")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int force;
    [Token(Token = "0x400423E")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int x;
    [Token(Token = "0x400423F")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int y;
    [Token(Token = "0x4004240")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int slot;

    [Token(Token = "0x17000C0C")]
    public int Key
    {
      [Token(Token = "0x6005478"), Address(RVA = "0x3AA5958", Offset = "0x3AA5958", VA = "0x3AA5958", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005479")]
    [Address(RVA = "0x3AA5960", Offset = "0x3AA5960", VA = "0x3AA5960", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x600547A")]
    [Address(RVA = "0x3AA5BEC", Offset = "0x3AA5BEC", VA = "0x3AA5BEC", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x17000C0D")]
    public int Id
    {
      [Token(Token = "0x600547B"), Address(RVA = "0x3AA5CB0", Offset = "0x3AA5CB0", VA = "0x3AA5CB0", Slot = "7")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000C0E")]
    public int Troops
    {
      [Token(Token = "0x600547C"), Address(RVA = "0x3AA5CB8", Offset = "0x3AA5CB8", VA = "0x3AA5CB8", Slot = "8")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000C0F")]
    public int UnitNo
    {
      [Token(Token = "0x600547D"), Address(RVA = "0x3AA5CC0", Offset = "0x3AA5CC0", VA = "0x3AA5CC0", Slot = "10")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000C10")]
    public int X
    {
      [Token(Token = "0x600547E"), Address(RVA = "0x3AA5CC8", Offset = "0x3AA5CC8", VA = "0x3AA5CC8", Slot = "14")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000C11")]
    public int Y
    {
      [Token(Token = "0x600547F"), Address(RVA = "0x3AA5CD0", Offset = "0x3AA5CD0", VA = "0x3AA5CD0", Slot = "15")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000C12")]
    public bool Modifiable
    {
      [Token(Token = "0x6005480"), Address(RVA = "0x3AA5CD8", Offset = "0x3AA5CD8", VA = "0x3AA5CD8", Slot = "21")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000C13")]
    public int SortieFromX
    {
      [Token(Token = "0x6005481"), Address(RVA = "0x3AA5CE0", Offset = "0x3AA5CE0", VA = "0x3AA5CE0", Slot = "11")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000C14")]
    public int SortieFromY
    {
      [Token(Token = "0x6005482"), Address(RVA = "0x3AA5CE8", Offset = "0x3AA5CE8", VA = "0x3AA5CE8", Slot = "12")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000C15")]
    public int WaitTurnCount
    {
      [Token(Token = "0x6005483"), Address(RVA = "0x3AA5CF0", Offset = "0x3AA5CF0", VA = "0x3AA5CF0", Slot = "13")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000C16")]
    public int BaseExp
    {
      [Token(Token = "0x6005484"), Address(RVA = "0x3AA5CF8", Offset = "0x3AA5CF8", VA = "0x3AA5CF8", Slot = "16")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000C17")]
    public int Damage
    {
      [Token(Token = "0x6005485"), Address(RVA = "0x3AA5D00", Offset = "0x3AA5D00", VA = "0x3AA5D00", Slot = "18")] set
      {
      }
      [Token(Token = "0x6005486"), Address(RVA = "0x3AA5D08", Offset = "0x3AA5D08", VA = "0x3AA5D08", Slot = "17")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000C18")]
    public int NpcMasterDataId
    {
      [Token(Token = "0x6005487"), Address(RVA = "0x3AA5D10", Offset = "0x3AA5D10", VA = "0x3AA5D10", Slot = "9")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000C19")]
    public int Barrier
    {
      [Token(Token = "0x6005488"), Address(RVA = "0x3AA5D18", Offset = "0x3AA5D18", VA = "0x3AA5D18", Slot = "19")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000C1A")]
    public int BarrierHp
    {
      [Token(Token = "0x6005489"), Address(RVA = "0x3AA5D20", Offset = "0x3AA5D20", VA = "0x3AA5D20", Slot = "20")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000C1B")]
    public int BaseSupportRank
    {
      [Token(Token = "0x600548A"), Address(RVA = "0x3AA5D28", Offset = "0x3AA5D28", VA = "0x3AA5D28", Slot = "22")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600548B")]
    [Address(RVA = "0x3AA5D30", Offset = "0x3AA5D30", VA = "0x3AA5D30", Slot = "23")]
    public Dictionary<int, int> GetSupportInfo() => (Dictionary<int, int>) null;

    [Token(Token = "0x17000C1C")]
    public QuestCorrection Correction
    {
      [Token(Token = "0x600548C"), Address(RVA = "0x3AA5D38", Offset = "0x3AA5D38", VA = "0x3AA5D38", Slot = "25")] set
      {
      }
      [Token(Token = "0x600548D"), Address(RVA = "0x3AA5D40", Offset = "0x3AA5D40", VA = "0x3AA5D40", Slot = "24")] get
      {
        return (QuestCorrection) null;
      }
    }

    [Token(Token = "0x17000C1D")]
    public bool IsBoss
    {
      [Token(Token = "0x600548E"), Address(RVA = "0x3AA5D48", Offset = "0x3AA5D48", VA = "0x3AA5D48", Slot = "26")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600548F")]
    [Address(RVA = "0x3AA5D50", Offset = "0x3AA5D50", VA = "0x3AA5D50")]
    public ArenaBattlePlacementData()
    {
    }
  }
}
