// Decompiled with JetBrains decompiler
// Type: Scenes.Guild.Detail.GuildLevelDetailBenefitParts
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

#nullable disable
namespace Scenes.Guild.Detail
{
  [Token(Token = "0x2002C04")]
  public class GuildLevelDetailBenefitParts : MonoBehaviour
  {
    [Token(Token = "0x400BB67")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private TextMeshProUGUI levelText;
    [Token(Token = "0x400BB68")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject releaseImage;
    [Token(Token = "0x400BB69")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private TextMeshProUGUI benefitBigText;
    [Token(Token = "0x400BB6A")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private GameObject benefitText;
    [Token(Token = "0x400BB6B")]
    [FieldOffset(Offset = "0x38")]
    private List<TextMeshProUGUI> benefitTexts;
    [Token(Token = "0x400BB6C")]
    [FieldOffset(Offset = "0x40")]
    private string leveltemplate;

    [Token(Token = "0x6011308")]
    [Address(RVA = "0x4A13BC8", Offset = "0x4A13BC8", VA = "0x4A13BC8")]
    public void Setup(GuildLevelDetailBenefitParts.UIParameter param)
    {
    }

    [Token(Token = "0x6011309")]
    [Address(RVA = "0x4A14058", Offset = "0x4A14058", VA = "0x4A14058")]
    public GuildLevelDetailBenefitParts()
    {
    }

    [Token(Token = "0x2002C05")]
    public class UIParameter
    {
      [Token(Token = "0x17003B3D")]
      public int guildLevel
      {
        [Token(Token = "0x601130A"), Address(RVA = "0x4A140EC", Offset = "0x4A140EC", VA = "0x4A140EC")] get
        {
          return new int();
        }
        [Token(Token = "0x601130B"), Address(RVA = "0x4A140F4", Offset = "0x4A140F4", VA = "0x4A140F4")] set
        {
        }
      }

      [Token(Token = "0x17003B3E")]
      public bool isUnlocked
      {
        [Token(Token = "0x601130C"), Address(RVA = "0x4A140FC", Offset = "0x4A140FC", VA = "0x4A140FC")] get
        {
          return new bool();
        }
        [Token(Token = "0x601130D"), Address(RVA = "0x4A14104", Offset = "0x4A14104", VA = "0x4A14104")] set
        {
        }
      }

      [Token(Token = "0x17003B3F")]
      public List<string> rewards
      {
        [Token(Token = "0x601130E"), Address(RVA = "0x4A14110", Offset = "0x4A14110", VA = "0x4A14110")] get
        {
          return (List<string>) null;
        }
        [Token(Token = "0x601130F"), Address(RVA = "0x4A14118", Offset = "0x4A14118", VA = "0x4A14118")] set
        {
        }
      }

      [Token(Token = "0x6011310")]
      [Address(RVA = "0x4A14120", Offset = "0x4A14120", VA = "0x4A14120")]
      public UIParameter()
      {
      }
    }
  }
}
