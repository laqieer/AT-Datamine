// Decompiled with JetBrains decompiler
// Type: TeamOrganization.CustomSkillSlotUI
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace TeamOrganization
{
  [Token(Token = "0x20007AA")]
  public class CustomSkillSlotUI : MonoBehaviour
  {
    [Token(Token = "0x40023B2")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Image iconImage;
    [Token(Token = "0x40023B3")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject attentionIcon;
    [Token(Token = "0x40023B4")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private TextMeshProUGUI customSkillNameText;

    [Token(Token = "0x17000674")]
    public Image IconImage
    {
      [Token(Token = "0x6002B3D"), Address(RVA = "0x386C270", Offset = "0x386C270", VA = "0x386C270")] get
      {
        return (Image) null;
      }
    }

    [Token(Token = "0x17000675")]
    public GameObject AttentionIcon
    {
      [Token(Token = "0x6002B3E"), Address(RVA = "0x386C278", Offset = "0x386C278", VA = "0x386C278")] get
      {
        return (GameObject) null;
      }
    }

    [Token(Token = "0x17000676")]
    public TextMeshProUGUI CustomSkillNameText
    {
      [Token(Token = "0x6002B3F"), Address(RVA = "0x386C280", Offset = "0x386C280", VA = "0x386C280")] get
      {
        return (TextMeshProUGUI) null;
      }
    }

    [Token(Token = "0x6002B40")]
    [Address(RVA = "0x386C288", Offset = "0x386C288", VA = "0x386C288")]
    public CustomSkillSlotUI()
    {
    }
  }
}
