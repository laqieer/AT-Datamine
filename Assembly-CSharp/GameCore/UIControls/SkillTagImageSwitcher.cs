// Decompiled with JetBrains decompiler
// Type: GameCore.UIControls.SkillTagImageSwitcher
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace GameCore.UIControls
{
  [Token(Token = "0x2000C13")]
  [RequireComponent(typeof (Image))]
  public class SkillTagImageSwitcher : MonoBehaviour
  {
    [Token(Token = "0x40036D5")]
    [FieldOffset(Offset = "0x18")]
    [HideInInspector]
    [SerializeField]
    private Image targetImage;
    [Token(Token = "0x40036D6")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Sprite attackTagImage;
    [Token(Token = "0x40036D7")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Sprite healingTagImage;
    [Token(Token = "0x40036D8")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Sprite supportTagImage;
    [Token(Token = "0x40036D9")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Sprite otherTagImage;

    [Token(Token = "0x6004525")]
    [Address(RVA = "0x350DA7C", Offset = "0x350DA7C", VA = "0x350DA7C")]
    public void UpdateView(SkillTagsDetailData tagData)
    {
    }

    [Token(Token = "0x6004526")]
    [Address(RVA = "0x350DA8C", Offset = "0x350DA8C", VA = "0x350DA8C")]
    public void UpdateView(SkillTagTypeEnum tag)
    {
    }

    [Token(Token = "0x6004527")]
    [Address(RVA = "0x350DB10", Offset = "0x350DB10", VA = "0x350DB10")]
    public SkillTagImageSwitcher()
    {
    }
  }
}
