// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryFreeActionFlavorObjectData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001257")]
  [Serializable]
  public sealed class StoryFreeActionFlavorObjectData : IMasterDataEntity
  {
    [Token(Token = "0x40057C3")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x40057C4")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int flavorGroup;
    [Token(Token = "0x40057C5")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int attachObject;
    [Token(Token = "0x40057C6")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public PlayAdvPatternEnum playADVPattern;
    [Token(Token = "0x40057C7")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public float iconOffsetX;
    [Token(Token = "0x40057C8")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public float iconOffsetY;
    [Token(Token = "0x40057C9")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public float iconOffsetZ;
    [Token(Token = "0x40057CA")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    public int cameraPosition;
    [Token(Token = "0x40057CB")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public int playerMovePosition;

    [Token(Token = "0x17000FBB")]
    public int Key
    {
      [Token(Token = "0x600684A"), Address(RVA = "0x4D37818", Offset = "0x4D37818", VA = "0x4D37818", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600684B")]
    [Address(RVA = "0x4D37820", Offset = "0x4D37820", VA = "0x4D37820", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x600684C")]
    [Address(RVA = "0x4D37BCC", Offset = "0x4D37BCC", VA = "0x4D37BCC", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x17000FBC")]
    public Vector3 IconOffset
    {
      [Token(Token = "0x600684D"), Address(RVA = "0x4D37CC0", Offset = "0x4D37CC0", VA = "0x4D37CC0")] get
      {
        return new Vector3();
      }
      [Token(Token = "0x600684E"), Address(RVA = "0x4D37CCC", Offset = "0x4D37CCC", VA = "0x4D37CCC")] private set
      {
      }
    }

    [Token(Token = "0x600684F")]
    [Address(RVA = "0x4D37668", Offset = "0x4D37668", VA = "0x4D37668")]
    public void OnLoad()
    {
    }

    [Token(Token = "0x6006850")]
    [Address(RVA = "0x4D37CD8", Offset = "0x4D37CD8", VA = "0x4D37CD8")]
    public StoryFreeActionFlavorObjectData()
    {
    }
  }
}
