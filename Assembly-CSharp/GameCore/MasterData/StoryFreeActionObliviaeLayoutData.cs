// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryFreeActionObliviaeLayoutData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001268")]
  [Serializable]
  public sealed class StoryFreeActionObliviaeLayoutData : IMasterDataEntity
  {
    [Token(Token = "0x400580B")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x400580C")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int layoutLabelID;
    [Token(Token = "0x400580D")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int objectID;
    [Token(Token = "0x400580E")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int advID;
    [Token(Token = "0x400580F")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int cameraMovePosition;
    [Token(Token = "0x4005810")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int playerMovePosition;
    [Token(Token = "0x4005811")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public EventNpcActEnum beginNpcAct;
    [Token(Token = "0x4005812")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    public float positionOffsetX;
    [Token(Token = "0x4005813")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public float positionOffsetY;
    [Token(Token = "0x4005814")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    public float positionOffsetZ;
    [Token(Token = "0x4005815")]
    public const string TEXT_AB = "text_masterdata_story";

    [Token(Token = "0x17000FD3")]
    public int Key
    {
      [Token(Token = "0x60068A7"), Address(RVA = "0x48C8950", Offset = "0x48C8950", VA = "0x48C8950", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60068A8")]
    [Address(RVA = "0x48C8958", Offset = "0x48C8958", VA = "0x48C8958", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x60068A9")]
    [Address(RVA = "0x48C8D64", Offset = "0x48C8D64", VA = "0x48C8D64", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x17000FD4")]
    public string Text
    {
      [Token(Token = "0x60068AA"), Address(RVA = "0x48C8E68", Offset = "0x48C8E68", VA = "0x48C8E68")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x60068AB")]
    [Address(RVA = "0x48C8F44", Offset = "0x48C8F44", VA = "0x48C8F44")]
    public StoryFreeActionObliviaeLayoutData()
    {
    }
  }
}
