// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.ShopLayoutData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200118B")]
  [Serializable]
  public sealed class ShopLayoutData : IMasterDataEntity
  {
    [Token(Token = "0x40054B3")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x40054B4")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int shopLayoutLabel;
    [Token(Token = "0x40054B5")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public ShopTypeEnum shopType;
    [Token(Token = "0x40054B6")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int objectID;
    [Token(Token = "0x40054B7")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int cameraMovePosition;
    [Token(Token = "0x40054B8")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int playerMovePosition;
    [Token(Token = "0x40054B9")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public int beforeAdvID;
    [Token(Token = "0x40054BA")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    public int afterAdvID;
    [Token(Token = "0x40054BB")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public EventNpcActEnum beginNpcAct;
    [Token(Token = "0x40054BC")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    public float iconPositionX;
    [Token(Token = "0x40054BD")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    public float iconPositionY;
    [Token(Token = "0x40054BE")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    public float iconPositionZ;

    [Token(Token = "0x17000F3F")]
    public int Key
    {
      [Token(Token = "0x60064CA"), Address(RVA = "0x4AF2634", Offset = "0x4AF2634", VA = "0x4AF2634", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60064CB")]
    [Address(RVA = "0x4AF263C", Offset = "0x4AF263C", VA = "0x4AF263C", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x60064CC")]
    [Address(RVA = "0x4AF2B08", Offset = "0x4AF2B08", VA = "0x4AF2B08", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x60064CD")]
    [Address(RVA = "0x4AF2C2C", Offset = "0x4AF2C2C", VA = "0x4AF2C2C")]
    public ShopLayoutData()
    {
    }
  }
}
