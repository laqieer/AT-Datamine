// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryFreeActionRewardObjectBreakableObjectData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001276")]
  [Serializable]
  public sealed class StoryFreeActionRewardObjectBreakableObjectData : IMasterDataEntity
  {
    [Token(Token = "0x4005833")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005834")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;
    [Token(Token = "0x4005835")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int chapter;
    [Token(Token = "0x4005836")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int propSettingID;
    [Token(Token = "0x4005837")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public float iconOffsetX;
    [Token(Token = "0x4005838")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    public float iconOffsetY;
    [Token(Token = "0x4005839")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public float iconOffsetZ;
    [Token(Token = "0x400583A")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    public int playerMovePosition;

    [Token(Token = "0x17000FE3")]
    public int Key
    {
      [Token(Token = "0x60068F1"), Address(RVA = "0x48CABF8", Offset = "0x48CABF8", VA = "0x48CABF8", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60068F2")]
    [Address(RVA = "0x48CAC00", Offset = "0x48CAC00", VA = "0x48CAC00", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x60068F3")]
    [Address(RVA = "0x48CAF4C", Offset = "0x48CAF4C", VA = "0x48CAF4C", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x17000FE4")]
    public Vector3 IconOffset
    {
      [Token(Token = "0x60068F4"), Address(RVA = "0x48CB034", Offset = "0x48CB034", VA = "0x48CB034")] get
      {
        return new Vector3();
      }
      [Token(Token = "0x60068F5"), Address(RVA = "0x48CB040", Offset = "0x48CB040", VA = "0x48CB040")] private set
      {
      }
    }

    [Token(Token = "0x60068F6")]
    [Address(RVA = "0x48CAB9C", Offset = "0x48CAB9C", VA = "0x48CAB9C")]
    public void OnLoad()
    {
    }

    [Token(Token = "0x60068F7")]
    [Address(RVA = "0x48CB04C", Offset = "0x48CB04C", VA = "0x48CB04C")]
    public StoryFreeActionRewardObjectBreakableObjectData()
    {
    }
  }
}
