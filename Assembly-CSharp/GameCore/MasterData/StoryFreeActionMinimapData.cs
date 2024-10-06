// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryFreeActionMinimapData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001262")]
  [Serializable]
  public sealed class StoryFreeActionMinimapData : IMasterDataEntity
  {
    [Token(Token = "0x40057F0")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x40057F1")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string Name;
    [Token(Token = "0x40057F2")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public float Width;
    [Token(Token = "0x40057F3")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public float Height;
    [Token(Token = "0x40057F4")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public int Angle;
    [Token(Token = "0x40057F5")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    public float LeftPos_X;
    [Token(Token = "0x40057F6")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public float LeftPos_Z;
    [Token(Token = "0x40057F7")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    public int mapInitScale;
    [Token(Token = "0x40057F8")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    public int mapMinScale;
    [Token(Token = "0x40057F9")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    public int mapMaxScale;
    [Token(Token = "0x40057FA")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    public int mapTrianglePixelsPerUnitMultiplier;
    [Token(Token = "0x40057FB")]
    [FieldOffset(Offset = "0x44")]
    [SerializeField]
    public int minimapInitScale;
    [Token(Token = "0x40057FC")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    public int minimapMinScale;
    [Token(Token = "0x40057FD")]
    [FieldOffset(Offset = "0x4C")]
    [SerializeField]
    public int minimapMaxScale;
    [Token(Token = "0x40057FE")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    public int minimapTrianglePixelsPerUnitMultiplier;

    [Token(Token = "0x17000FCB")]
    public int Key
    {
      [Token(Token = "0x600688E"), Address(RVA = "0x48C7B28", Offset = "0x48C7B28", VA = "0x48C7B28", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600688F")]
    [Address(RVA = "0x48C7B30", Offset = "0x48C7B30", VA = "0x48C7B30", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006890")]
    [Address(RVA = "0x48C811C", Offset = "0x48C811C", VA = "0x48C811C", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6006891")]
    [Address(RVA = "0x48C8274", Offset = "0x48C8274", VA = "0x48C8274")]
    public StoryFreeActionMinimapData()
    {
    }
  }
}
