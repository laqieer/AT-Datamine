// Decompiled with JetBrains decompiler
// Type: GameCore.UIControls.SkillIcon
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using StaqData;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

#nullable disable
namespace GameCore.UIControls
{
  [Token(Token = "0x2000C10")]
  public class SkillIcon : MonoBehaviour
  {
    [Token(Token = "0x40036C3")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Image image;
    [Token(Token = "0x40036C4")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private TextMeshProUGUI level;
    [Token(Token = "0x40036C5")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private SkillUtility.IconSize size;

    [Token(Token = "0x140000F3")]
    public event UnityAction OnLongPress
    {
      [Token(Token = "0x6004512"), Address(RVA = "0x364E8E4", Offset = "0x364E8E4", VA = "0x364E8E4")] add
      {
      }
      [Token(Token = "0x6004513"), Address(RVA = "0x364E964", Offset = "0x364E964", VA = "0x364E964")] remove
      {
      }
    }

    [Token(Token = "0x6004514")]
    [Address(RVA = "0x364E9E4", Offset = "0x364E9E4", VA = "0x364E9E4")]
    public void RemoveAllLongPressListener()
    {
    }

    [Token(Token = "0x6004515")]
    [Address(RVA = "0x364EA50", Offset = "0x364EA50", VA = "0x364EA50")]
    public void SetSkill(SkillData skill, int level)
    {
    }

    [Token(Token = "0x6004516")]
    [Address(RVA = "0x364EB84", Offset = "0x364EB84", VA = "0x364EB84")]
    private void SetLevel(int level)
    {
    }

    [Token(Token = "0x6004517")]
    [Address(RVA = "0x364EA78", Offset = "0x364EA78", VA = "0x364EA78")]
    private void LoadImage(SkillData skill)
    {
    }

    [Token(Token = "0x6004518")]
    [Address(RVA = "0x364EC60", Offset = "0x364EC60", VA = "0x364EC60")]
    public SkillIcon()
    {
    }
  }
}
