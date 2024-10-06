// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryFreeActionObjectData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001264")]
  [Serializable]
  public sealed class StoryFreeActionObjectData : IMasterDataEntity, IFreeActionObjectData
  {
    [Token(Token = "0x40057FF")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005800")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string Name;
    [Token(Token = "0x4005801")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int characterSwitchPatternID;
    [Token(Token = "0x4005802")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int propID;
    [Token(Token = "0x4005803")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public string objectAccessName;
    [Token(Token = "0x4005804")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public int objectType;

    [Token(Token = "0x17000FCC")]
    public int Key
    {
      [Token(Token = "0x6006896"), Address(RVA = "0x48C8384", Offset = "0x48C8384", VA = "0x48C8384", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006897")]
    [Address(RVA = "0x48C838C", Offset = "0x48C838C", VA = "0x48C838C", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006898")]
    [Address(RVA = "0x48C8618", Offset = "0x48C8618", VA = "0x48C8618", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x17000FCD")]
    public int DataID
    {
      [Token(Token = "0x6006899"), Address(RVA = "0x48C86E4", Offset = "0x48C86E4", VA = "0x48C86E4", Slot = "7")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000FCE")]
    public string ObjectName
    {
      [Token(Token = "0x600689A"), Address(RVA = "0x48C86EC", Offset = "0x48C86EC", VA = "0x48C86EC", Slot = "8")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000FCF")]
    public int CharacterSwitchPatternID
    {
      [Token(Token = "0x600689B"), Address(RVA = "0x48C86F4", Offset = "0x48C86F4", VA = "0x48C86F4", Slot = "9")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000FD0")]
    public int PropID
    {
      [Token(Token = "0x600689C"), Address(RVA = "0x48C86FC", Offset = "0x48C86FC", VA = "0x48C86FC", Slot = "11")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000FD1")]
    public string ObjectAccessName
    {
      [Token(Token = "0x600689D"), Address(RVA = "0x48C8704", Offset = "0x48C8704", VA = "0x48C8704", Slot = "10")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000FD2")]
    public StoryFreeActionObjectTypeEnum ObjectType
    {
      [Token(Token = "0x600689E"), Address(RVA = "0x48C870C", Offset = "0x48C870C", VA = "0x48C870C", Slot = "12")] get
      {
        return new StoryFreeActionObjectTypeEnum();
      }
    }

    [Token(Token = "0x600689F")]
    [Address(RVA = "0x48C8714", Offset = "0x48C8714", VA = "0x48C8714")]
    public StoryFreeActionObjectData()
    {
    }
  }
}
