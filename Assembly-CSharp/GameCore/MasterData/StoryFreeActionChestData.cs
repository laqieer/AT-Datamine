// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryFreeActionChestData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200124F")]
  [Serializable]
  public sealed class StoryFreeActionChestData : IMasterDataEntity
  {
    [Token(Token = "0x400579B")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x400579C")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;
    [Token(Token = "0x400579D")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int chestType;
    [Token(Token = "0x400579E")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int chapter;
    [Token(Token = "0x400579F")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public float iconOffsetX;
    [Token(Token = "0x40057A0")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    public float iconOffsetY;
    [Token(Token = "0x40057A1")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public float iconOffsetZ;
    [Token(Token = "0x40057A2")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    public int playerMovePosition;

    [Token(Token = "0x17000FB5")]
    public int Key
    {
      [Token(Token = "0x6006820"), Address(RVA = "0x4D35CA8", Offset = "0x4D35CA8", VA = "0x4D35CA8", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006821")]
    [Address(RVA = "0x4D35CB0", Offset = "0x4D35CB0", VA = "0x4D35CB0", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006822")]
    [Address(RVA = "0x4D35FFC", Offset = "0x4D35FFC", VA = "0x4D35FFC", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x17000FB6")]
    public Vector3 IconOffset
    {
      [Token(Token = "0x6006823"), Address(RVA = "0x4D360E4", Offset = "0x4D360E4", VA = "0x4D360E4")] get
      {
        return new Vector3();
      }
      [Token(Token = "0x6006824"), Address(RVA = "0x4D360F0", Offset = "0x4D360F0", VA = "0x4D360F0")] set
      {
      }
    }

    [Token(Token = "0x6006825")]
    [Address(RVA = "0x4D35C4C", Offset = "0x4D35C4C", VA = "0x4D35C4C")]
    public void OnLoad()
    {
    }

    [Token(Token = "0x6006826")]
    [Address(RVA = "0x4D360FC", Offset = "0x4D360FC", VA = "0x4D360FC")]
    public StoryFreeActionChestData()
    {
    }
  }
}
