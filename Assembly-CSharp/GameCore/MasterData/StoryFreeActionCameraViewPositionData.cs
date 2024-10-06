// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryFreeActionCameraViewPositionData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200124B")]
  [Serializable]
  public sealed class StoryFreeActionCameraViewPositionData : IMasterDataEntity, ICloneable
  {
    [Token(Token = "0x4005789")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x400578A")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string Name;
    [Token(Token = "0x400578B")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public CameraViewPositionReferenceEnum RefarencePosition;
    [Token(Token = "0x400578C")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public float CameraPositionX;
    [Token(Token = "0x400578D")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public float CameraPositionY;
    [Token(Token = "0x400578E")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    public float CameraPositionZ;
    [Token(Token = "0x400578F")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public float CameraRotationX;
    [Token(Token = "0x4005790")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    public float CameraRotationY;
    [Token(Token = "0x4005791")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    public float CameraRotationZ;
    [Token(Token = "0x4005792")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    public float CameraFovAbsolute;
    [Token(Token = "0x4005793")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    public float CameraFovRelative;

    [Token(Token = "0x17000FB2")]
    public int Key
    {
      [Token(Token = "0x600680A"), Address(RVA = "0x4D3508C", Offset = "0x4D3508C", VA = "0x4D3508C", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600680B")]
    [Address(RVA = "0x4D35094", Offset = "0x4D35094", VA = "0x4D35094", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x600680C")]
    [Address(RVA = "0x4D35500", Offset = "0x4D35500", VA = "0x4D35500", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x600680D")]
    [Address(RVA = "0x4D35618", Offset = "0x4D35618", VA = "0x4D35618", Slot = "7")]
    public object Clone() => (object) null;

    [Token(Token = "0x600680E")]
    [Address(RVA = "0x4D35620", Offset = "0x4D35620", VA = "0x4D35620")]
    public Vector3 GetPosition() => new Vector3();

    [Token(Token = "0x600680F")]
    [Address(RVA = "0x4D3562C", Offset = "0x4D3562C", VA = "0x4D3562C")]
    public Vector3 GetRotation() => new Vector3();

    [Token(Token = "0x6006810")]
    [Address(RVA = "0x4D35638", Offset = "0x4D35638", VA = "0x4D35638")]
    public float GetValidCameraFoV() => new float();

    [Token(Token = "0x17000FB3")]
    public bool isAbsoluteFoV
    {
      [Token(Token = "0x6006811"), Address(RVA = "0x4D35654", Offset = "0x4D35654", VA = "0x4D35654")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6006812")]
    [Address(RVA = "0x4D35664", Offset = "0x4D35664", VA = "0x4D35664")]
    public StoryFreeActionCameraViewPositionData()
    {
    }
  }
}
