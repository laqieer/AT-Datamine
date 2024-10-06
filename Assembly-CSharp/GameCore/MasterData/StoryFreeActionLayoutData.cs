// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryFreeActionLayoutData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Story;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001260")]
  [Serializable]
  public sealed class StoryFreeActionLayoutData : IMasterDataEntity, IFreeActionLayoutData
  {
    [Token(Token = "0x40057E0")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x40057E1")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int LayoutGroupLabel;
    [Token(Token = "0x40057E2")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int Area;
    [Token(Token = "0x40057E3")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public string AnchorName;
    [Token(Token = "0x40057E4")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public int PlacementObject;
    [Token(Token = "0x40057E5")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    public int characterPatternAssignID;
    [Token(Token = "0x40057E6")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public int conditionDate;
    [Token(Token = "0x40057E7")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    public int conditionWeather;
    [Token(Token = "0x40057E8")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    public int conditionTimeslot;
    [Token(Token = "0x40057E9")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    public int activeConditionEvent;
    [Token(Token = "0x40057EA")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    public int inactiveConditionEvent;
    [Token(Token = "0x40057EB")]
    [FieldOffset(Offset = "0x44")]
    [SerializeField]
    public int ObjectRotationY;
    [Token(Token = "0x40057EC")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    public float PositionOffsetX;
    [Token(Token = "0x40057ED")]
    [FieldOffset(Offset = "0x4C")]
    [SerializeField]
    public float PositionOffsetY;
    [Token(Token = "0x40057EE")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    public float PositionOffsetZ;
    [Token(Token = "0x40057EF")]
    [FieldOffset(Offset = "0x54")]
    [SerializeField]
    public float forwardDistance;

    [Token(Token = "0x17000FBF")]
    public int Key
    {
      [Token(Token = "0x600687B"), Address(RVA = "0x4D39818", Offset = "0x4D39818", VA = "0x4D39818", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600687C")]
    [Address(RVA = "0x4D39820", Offset = "0x4D39820", VA = "0x4D39820", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x600687D")]
    [Address(RVA = "0x4D39E6C", Offset = "0x4D39E6C", VA = "0x4D39E6C", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x17000FC0")]
    public int LayoutGroup
    {
      [Token(Token = "0x600687E"), Address(RVA = "0x4D39FD4", Offset = "0x4D39FD4", VA = "0x4D39FD4", Slot = "7")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000FC1")]
    public int AreaID
    {
      [Token(Token = "0x600687F"), Address(RVA = "0x4D39FDC", Offset = "0x4D39FDC", VA = "0x4D39FDC", Slot = "8")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000FC2")]
    public string Anchor
    {
      [Token(Token = "0x6006880"), Address(RVA = "0x4D39FE4", Offset = "0x4D39FE4", VA = "0x4D39FE4", Slot = "9")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000FC3")]
    public IFreeActionObjectData Placement
    {
      [Token(Token = "0x6006881"), Address(RVA = "0x4D39FEC", Offset = "0x4D39FEC", VA = "0x4D39FEC", Slot = "10")] get
      {
        return (IFreeActionObjectData) null;
      }
    }

    [Token(Token = "0x17000FC4")]
    public int CharacterPattern
    {
      [Token(Token = "0x6006882"), Address(RVA = "0x4D3A088", Offset = "0x4D3A088", VA = "0x4D3A088", Slot = "11")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000FC5")]
    public int RotationY
    {
      [Token(Token = "0x6006883"), Address(RVA = "0x4D3A090", Offset = "0x4D3A090", VA = "0x4D3A090", Slot = "12")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000FC6")]
    public Vector3 PositionOffset
    {
      [Token(Token = "0x6006884"), Address(RVA = "0x4D3A098", Offset = "0x4D3A098", VA = "0x4D3A098", Slot = "13")] get
      {
        return new Vector3();
      }
    }

    [Token(Token = "0x17000FC7")]
    public float ForwardDistance
    {
      [Token(Token = "0x6006885"), Address(RVA = "0x4D3A0A4", Offset = "0x4D3A0A4", VA = "0x4D3A0A4")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x17000FC8")]
    public ConditionDate ConditionDate
    {
      [Token(Token = "0x6006886"), Address(RVA = "0x4D396F4", Offset = "0x4D396F4", VA = "0x4D396F4")] get
      {
        return new ConditionDate();
      }
    }

    [Token(Token = "0x17000FC9")]
    public ConditionTimeslot ConditionTimeslot
    {
      [Token(Token = "0x6006887"), Address(RVA = "0x4D396FC", Offset = "0x4D396FC", VA = "0x4D396FC")] get
      {
        return new ConditionTimeslot();
      }
    }

    [Token(Token = "0x17000FCA")]
    public ConditionWeather ConditionWeather
    {
      [Token(Token = "0x6006888"), Address(RVA = "0x4D39704", Offset = "0x4D39704", VA = "0x4D39704")] get
      {
        return new ConditionWeather();
      }
    }

    [Token(Token = "0x6006889")]
    [Address(RVA = "0x4D3A13C", Offset = "0x4D3A13C", VA = "0x4D3A13C")]
    public StoryFreeActionLayoutData()
    {
    }
  }
}
