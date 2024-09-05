// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.AreaQuestAreaNodeData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20010FE")]
  [Serializable]
  public sealed class AreaQuestAreaNodeData : BaseMaster<StageLevelData>, IMasterDataEntity
  {
    [Token(Token = "0x40052EC")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x40052ED")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public string refName;
    [Token(Token = "0x40052EE")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public int areaId;
    [Token(Token = "0x40052EF")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    public int areaNodeReleaseConditionId;
    [Token(Token = "0x40052F0")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public int nextNodeId1;
    [Token(Token = "0x40052F1")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    public int nextNodeId2;
    [Token(Token = "0x40052F2")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    public int nextNodeId3;
    [Token(Token = "0x40052F3")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    public int nextNodeId4;
    [Token(Token = "0x40052F4")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    public int nextNodeId5;
    [Token(Token = "0x40052F5")]
    [FieldOffset(Offset = "0x44")]
    [SerializeField]
    public AreaNodeTypeEnum areaNodeType;
    [Token(Token = "0x40052F6")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    public int areaNodeTypeContentsId;
    [Token(Token = "0x40052F7")]
    [FieldOffset(Offset = "0x4C")]
    [SerializeField]
    public int displayCoordinatePositionX;
    [Token(Token = "0x40052F8")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    public int displayCoordinatePositionY;
    [Token(Token = "0x40052F9")]
    [FieldOffset(Offset = "0x54")]
    [SerializeField]
    public int backgroundMovieId;
    [Token(Token = "0x40052FA")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    public int areanodeResourceId;
    [Token(Token = "0x40052FB")]
    [FieldOffset(Offset = "0x5C")]
    [SerializeField]
    public int areanodeAccessoriesId;
    [Token(Token = "0x40052FC")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    public int directionAreaNodeIdwhenAreaNodeClear;
    [Token(Token = "0x40052FD")]
    [FieldOffset(Offset = "0x64")]
    [SerializeField]
    public int assignAreaNodeShortcutId;
    [Token(Token = "0x40052FE")]
    public const string TEXT_AB = "text_masterdata_quest";

    [Token(Token = "0x17000E9C")]
    public int Key
    {
      [Token(Token = "0x60061FB"), Address(RVA = "0x4ADAC78", Offset = "0x4ADAC78", VA = "0x4ADAC78", Slot = "6")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60061FC")]
    [Address(RVA = "0x4ADAC80", Offset = "0x4ADAC80", VA = "0x4ADAC80", Slot = "7")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x60061FD")]
    [Address(RVA = "0x4ADB38C", Offset = "0x4ADB38C", VA = "0x4ADB38C", Slot = "8")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x17000E9D")]
    public string Title
    {
      [Token(Token = "0x60061FE"), Address(RVA = "0x4ADB514", Offset = "0x4ADB514", VA = "0x4ADB514")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x60061FF")]
    [Address(RVA = "0x4ADB5F0", Offset = "0x4ADB5F0", VA = "0x4ADB5F0")]
    public List<int> GetNextNodeIds() => (List<int>) null;

    [Token(Token = "0x6006200")]
    [Address(RVA = "0x4ADB830", Offset = "0x4ADB830", VA = "0x4ADB830")]
    public AreaQuestAreaNodeData()
    {
    }
  }
}
