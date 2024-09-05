// Decompiled with JetBrains decompiler
// Type: GameCore.UIControls.SkillCategoryImageSwitcher
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
  [Token(Token = "0x2000C0F")]
  [RequireComponent(typeof (Image))]
  public class SkillCategoryImageSwitcher : MonoBehaviour
  {
    [Token(Token = "0x40036BE")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    [HideInInspector]
    private Image targetImage;
    [Token(Token = "0x40036BF")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Sprite activeSkillSprite;
    [Token(Token = "0x40036C0")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Sprite stratagemSkillSprite;
    [Token(Token = "0x40036C1")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Sprite duelSkillSprite;
    [Token(Token = "0x40036C2")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Sprite passiveSkillSprite;

    [Token(Token = "0x600450F")]
    [Address(RVA = "0x364E828", Offset = "0x364E828", VA = "0x364E828")]
    public void UpdateView(SkillData data)
    {
    }

    [Token(Token = "0x6004510")]
    [Address(RVA = "0x364E844", Offset = "0x364E844", VA = "0x364E844")]
    public void UpdateView(SkillCategoryTypeEnum category, SkillKindTypeEnum kind)
    {
    }

    [Token(Token = "0x6004511")]
    [Address(RVA = "0x364E8DC", Offset = "0x364E8DC", VA = "0x364E8DC")]
    public SkillCategoryImageSwitcher()
    {
    }
  }
}
