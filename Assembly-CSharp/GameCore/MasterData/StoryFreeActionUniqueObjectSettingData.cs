// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryFreeActionUniqueObjectSettingData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200128F")]
  [Serializable]
  public sealed class StoryFreeActionUniqueObjectSettingData : IMasterDataEntity
  {
    [Token(Token = "0x400589E")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x400589F")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int groupLabel;
    [Token(Token = "0x40058A0")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string objectName;
    [Token(Token = "0x40058A1")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public bool visible;
    [Token(Token = "0x40058A2")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public float offsetPosX;
    [Token(Token = "0x40058A3")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public float offsetPosY;
    [Token(Token = "0x40058A4")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    public float offsetPosZ;
    [Token(Token = "0x40058A5")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public float rotationY;

    [Token(Token = "0x17000FF2")]
    public int Key
    {
      [Token(Token = "0x6006978"), Address(RVA = "0x48D0844", Offset = "0x48D0844", VA = "0x48D0844", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006979")]
    [Address(RVA = "0x48D084C", Offset = "0x48D084C", VA = "0x48D084C", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x600697A")]
    [Address(RVA = "0x48D0B9C", Offset = "0x48D0B9C", VA = "0x48D0B9C", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x600697B")]
    [Address(RVA = "0x48D0C84", Offset = "0x48D0C84", VA = "0x48D0C84")]
    public Vector3 GetOffsetPosition() => new Vector3();

    [Token(Token = "0x600697C")]
    [Address(RVA = "0x48D0CE8", Offset = "0x48D0CE8", VA = "0x48D0CE8")]
    public Vector3 GetPosition(Vector3 basePosition) => new Vector3();

    [Token(Token = "0x600697D")]
    [Address(RVA = "0x48D0D00", Offset = "0x48D0D00", VA = "0x48D0D00")]
    public Quaternion GetOffsetRotation() => new Quaternion();

    [Token(Token = "0x600697E")]
    [Address(RVA = "0x48D0D54", Offset = "0x48D0D54", VA = "0x48D0D54")]
    public Quaternion GetRotation(Vector3 baseEulerAngle) => new Quaternion();

    [Token(Token = "0x600697F")]
    [Address(RVA = "0x48D0DF4", Offset = "0x48D0DF4", VA = "0x48D0DF4")]
    public StoryFreeActionUniqueObjectSettingData()
    {
    }
  }
}
