// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryCharacterBuildDataData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Story.Prop;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20011E9")]
  [Serializable]
  public sealed class StoryCharacterBuildDataData : IMasterDataEntity
  {
    [Token(Token = "0x40055E9")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x40055EA")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;
    [Token(Token = "0x40055EB")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int styleID;
    [Token(Token = "0x40055EC")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int controllerID;
    [Token(Token = "0x40055ED")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public int clipPackID;
    [Token(Token = "0x40055EE")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    public float height;
    [Token(Token = "0x40055EF")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public int propID_A;
    [Token(Token = "0x40055F0")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    public string propAttach_A;
    [Token(Token = "0x40055F1")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    public StoryIKSettingEnum propIK_A;
    [Token(Token = "0x40055F2")]
    [FieldOffset(Offset = "0x44")]
    [SerializeField]
    public float propIKPosWeight_A;
    [Token(Token = "0x40055F3")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    public float propIKRotWeight_A;
    [Token(Token = "0x40055F4")]
    [FieldOffset(Offset = "0x4C")]
    [SerializeField]
    public int propID_B;
    [Token(Token = "0x40055F5")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    public string propAttach_B;

    [Token(Token = "0x17000F70")]
    public int Key
    {
      [Token(Token = "0x6006655"), Address(RVA = "0x4D246F4", Offset = "0x4D246F4", VA = "0x4D246F4", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006656")]
    [Address(RVA = "0x4D246FC", Offset = "0x4D246FC", VA = "0x4D246FC", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006657")]
    [Address(RVA = "0x4D24C28", Offset = "0x4D24C28", VA = "0x4D24C28", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x17000F71")]
    public PropSettingData PropDataA
    {
      [Token(Token = "0x6006658"), Address(RVA = "0x4D24D68", Offset = "0x4D24D68", VA = "0x4D24D68")] get
      {
        return new PropSettingData();
      }
    }

    [Token(Token = "0x17000F72")]
    public PropSettingData PropDataB
    {
      [Token(Token = "0x6006659"), Address(RVA = "0x4D24D84", Offset = "0x4D24D84", VA = "0x4D24D84")] get
      {
        return new PropSettingData();
      }
    }

    [Token(Token = "0x600665A")]
    [Address(RVA = "0x4D24D9C", Offset = "0x4D24D9C", VA = "0x4D24D9C")]
    public PropSettingData[] GetProps() => (PropSettingData[]) null;

    [Token(Token = "0x600665B")]
    [Address(RVA = "0x4D24E68", Offset = "0x4D24E68", VA = "0x4D24E68")]
    public StoryCharacterBuildDataData()
    {
    }
  }
}
