// Decompiled with JetBrains decompiler
// Type: Scenes.Guild.Facility.GuildFacilityListItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.Guild.Facility
{
  [Token(Token = "0x2002BFE")]
  public class GuildFacilityListItem : MonoBehaviour
  {
    [Token(Token = "0x400BB51")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Text textFacilityName;
    [Token(Token = "0x400BB52")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Text textFacilityLevel;
    [Token(Token = "0x400BB53")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Slider gaugeFacilityExp;
    [Token(Token = "0x400BB54")]
    [FieldOffset(Offset = "0x30")]
    private GuildFacilityListItem.UIParameter uiParameter;

    [Token(Token = "0x60112ED")]
    [Address(RVA = "0x4A1386C", Offset = "0x4A1386C", VA = "0x4A1386C")]
    public void Setup(GuildFacilityListItem.UIParameter param)
    {
    }

    [Token(Token = "0x60112EE")]
    [Address(RVA = "0x4A13A28", Offset = "0x4A13A28", VA = "0x4A13A28")]
    public GuildFacilityListItem.UIParameter GetParam() => (GuildFacilityListItem.UIParameter) null;

    [Token(Token = "0x60112EF")]
    [Address(RVA = "0x4A13A30", Offset = "0x4A13A30", VA = "0x4A13A30")]
    public GuildFacilityListItem()
    {
    }

    [Token(Token = "0x2002BFF")]
    public class UIParameter
    {
      [Token(Token = "0x17003B35")]
      public int facilityExp
      {
        [Token(Token = "0x60112F0"), Address(RVA = "0x4A13A38", Offset = "0x4A13A38", VA = "0x4A13A38")] get
        {
          return new int();
        }
        [Token(Token = "0x60112F1"), Address(RVA = "0x4A13A40", Offset = "0x4A13A40", VA = "0x4A13A40")] set
        {
        }
      }

      [Token(Token = "0x17003B36")]
      public string facilityName
      {
        [Token(Token = "0x60112F2"), Address(RVA = "0x4A13A48", Offset = "0x4A13A48", VA = "0x4A13A48")] get
        {
          return (string) null;
        }
        [Token(Token = "0x60112F3"), Address(RVA = "0x4A13A50", Offset = "0x4A13A50", VA = "0x4A13A50")] set
        {
        }
      }

      [Token(Token = "0x17003B37")]
      public int facilityId
      {
        [Token(Token = "0x60112F4"), Address(RVA = "0x4A13A58", Offset = "0x4A13A58", VA = "0x4A13A58")] get
        {
          return new int();
        }
        [Token(Token = "0x60112F5"), Address(RVA = "0x4A13A60", Offset = "0x4A13A60", VA = "0x4A13A60")] set
        {
        }
      }

      [Token(Token = "0x17003B38")]
      public int FacilityLevel
      {
        [Token(Token = "0x60112F6"), Address(RVA = "0x4A13918", Offset = "0x4A13918", VA = "0x4A13918")] get
        {
          return new int();
        }
      }

      [Token(Token = "0x17003B39")]
      public float expGaugeValue
      {
        [Token(Token = "0x60112F7"), Address(RVA = "0x4A139A0", Offset = "0x4A139A0", VA = "0x4A139A0")] get
        {
          return new float();
        }
      }

      [Token(Token = "0x60112F8")]
      [Address(RVA = "0x4A13A68", Offset = "0x4A13A68", VA = "0x4A13A68")]
      public UIParameter()
      {
      }
    }
  }
}
