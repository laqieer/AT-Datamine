// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryFreeActionPlayerMovePositionData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200126E")]
  [Serializable]
  public sealed class StoryFreeActionPlayerMovePositionData : IMasterDataEntity, ICloneable
  {
    [Token(Token = "0x400581C")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x400581D")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string Name;
    [Token(Token = "0x400581E")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public float validPositionX;
    [Token(Token = "0x400581F")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public float validPositionY;
    [Token(Token = "0x4005820")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public float validPositionZ;
    [Token(Token = "0x4005821")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    public float validRadius;
    [Token(Token = "0x4005822")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public float validRotationY;
    [Token(Token = "0x4005823")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    public float invalidPositionX;
    [Token(Token = "0x4005824")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    public float invalidPositionY;
    [Token(Token = "0x4005825")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    public float invalidPositionZ;
    [Token(Token = "0x4005826")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    public float invalidRadius;

    [Token(Token = "0x17000FDF")]
    public int Key
    {
      [Token(Token = "0x60068CA"), Address(RVA = "0x48C998C", Offset = "0x48C998C", VA = "0x48C998C", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60068CB")]
    [Address(RVA = "0x48C9994", Offset = "0x48C9994", VA = "0x48C9994", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x60068CC")]
    [Address(RVA = "0x48C9E00", Offset = "0x48C9E00", VA = "0x48C9E00", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x60068CD")]
    [Address(RVA = "0x48C9F18", Offset = "0x48C9F18", VA = "0x48C9F18", Slot = "7")]
    public object Clone() => (object) null;

    [Token(Token = "0x60068CE")]
    [Address(RVA = "0x48C9F20", Offset = "0x48C9F20", VA = "0x48C9F20")]
    public Vector3 GetValidPosition() => new Vector3();

    [Token(Token = "0x60068CF")]
    [Address(RVA = "0x48C9F2C", Offset = "0x48C9F2C", VA = "0x48C9F2C")]
    public Vector3 GetValidRotation() => new Vector3();

    [Token(Token = "0x60068D0")]
    [Address(RVA = "0x48C9F3C", Offset = "0x48C9F3C", VA = "0x48C9F3C")]
    public Vector3 GetInvalidPosition() => new Vector3();

    [Token(Token = "0x60068D1")]
    [Address(RVA = "0x48C9F48", Offset = "0x48C9F48", VA = "0x48C9F48")]
    public StoryFreeActionPlayerMovePositionData()
    {
    }
  }
}
