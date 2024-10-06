// Decompiled with JetBrains decompiler
// Type: GuildFacilityBenefitParts
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Scenes.Guild.Facility;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

#nullable disable
[Token(Token = "0x200028F")]
public class GuildFacilityBenefitParts : MonoBehaviour
{
  [Token(Token = "0x4000F28")]
  [FieldOffset(Offset = "0x18")]
  [SerializeField]
  private TextMeshProUGUI level;
  [Token(Token = "0x4000F29")]
  [FieldOffset(Offset = "0x20")]
  private string leveltemplate;
  [Token(Token = "0x4000F2A")]
  [FieldOffset(Offset = "0x28")]
  [SerializeField]
  private GameObject releaseImage;
  [Token(Token = "0x4000F2B")]
  [FieldOffset(Offset = "0x30")]
  [SerializeField]
  private TextMeshProUGUI benefitBigText;
  [Token(Token = "0x4000F2C")]
  [FieldOffset(Offset = "0x38")]
  [SerializeField]
  private GameObject benefitText;
  [Token(Token = "0x4000F2D")]
  [FieldOffset(Offset = "0x40")]
  private List<TextMeshProUGUI> benefitTexts;

  [Token(Token = "0x6000FF0")]
  [Address(RVA = "0x1BE349C", Offset = "0x1BE349C", VA = "0x1BE349C")]
  public void Init(GuildFacilityRewardListItem.UIParameter parameter)
  {
  }

  [Token(Token = "0x6000FF1")]
  [Address(RVA = "0x1BE3B08", Offset = "0x1BE3B08", VA = "0x1BE3B08")]
  public GuildFacilityBenefitParts()
  {
  }
}
