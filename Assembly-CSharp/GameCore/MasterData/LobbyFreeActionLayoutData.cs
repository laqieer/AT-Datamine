// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.LobbyFreeActionLayoutData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200107E")]
  [Serializable]
  public sealed class LobbyFreeActionLayoutData : IMasterDataEntity, IFreeActionLayoutData
  {
    [Token(Token = "0x4005184")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005185")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int layoutGroupLabel;
    [Token(Token = "0x4005186")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int conditionID;
    [Token(Token = "0x4005187")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public string anchorName;
    [Token(Token = "0x4005188")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public int placementObjectID;
    [Token(Token = "0x4005189")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    public int characterPatternAssignID;
    [Token(Token = "0x400518A")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public int objectRotationY;
    [Token(Token = "0x400518B")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    public float positionOffsetX;
    [Token(Token = "0x400518C")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    public float positionOffsetY;
    [Token(Token = "0x400518D")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    public float positionOffsetZ;

    [Token(Token = "0x17000E3B")]
    public int Key
    {
      [Token(Token = "0x6005FA3"), Address(RVA = "0x28D03B4", Offset = "0x28D03B4", VA = "0x28D03B4", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005FA4")]
    [Address(RVA = "0x28D03BC", Offset = "0x28D03BC", VA = "0x28D03BC", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005FA5")]
    [Address(RVA = "0x28D07C8", Offset = "0x28D07C8", VA = "0x28D07C8", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x17000E3C")]
    public int LayoutGroup
    {
      [Token(Token = "0x6005FA6"), Address(RVA = "0x28D08D0", Offset = "0x28D08D0", VA = "0x28D08D0", Slot = "7")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000E3D")]
    public int AreaID
    {
      [Token(Token = "0x6005FA7"), Address(RVA = "0x28D08D8", Offset = "0x28D08D8", VA = "0x28D08D8", Slot = "8")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000E3E")]
    public string Anchor
    {
      [Token(Token = "0x6005FA8"), Address(RVA = "0x28D08E0", Offset = "0x28D08E0", VA = "0x28D08E0", Slot = "9")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000E3F")]
    public IFreeActionObjectData Placement
    {
      [Token(Token = "0x6005FA9"), Address(RVA = "0x28D08E8", Offset = "0x28D08E8", VA = "0x28D08E8", Slot = "10")] get
      {
        return (IFreeActionObjectData) null;
      }
    }

    [Token(Token = "0x17000E40")]
    public int CharacterPattern
    {
      [Token(Token = "0x6005FAA"), Address(RVA = "0x28D0984", Offset = "0x28D0984", VA = "0x28D0984", Slot = "11")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000E41")]
    public int RotationY
    {
      [Token(Token = "0x6005FAB"), Address(RVA = "0x28D098C", Offset = "0x28D098C", VA = "0x28D098C", Slot = "12")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000E42")]
    public Vector3 PositionOffset
    {
      [Token(Token = "0x6005FAC"), Address(RVA = "0x28D0994", Offset = "0x28D0994", VA = "0x28D0994", Slot = "13")] get
      {
        return new Vector3();
      }
    }

    [Token(Token = "0x6005FAD")]
    [Address(RVA = "0x28D09A0", Offset = "0x28D09A0", VA = "0x28D09A0")]
    public LobbyFreeActionLayoutData()
    {
    }
  }
}
