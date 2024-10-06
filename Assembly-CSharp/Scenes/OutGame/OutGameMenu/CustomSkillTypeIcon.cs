// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.OutGameMenu.CustomSkillTypeIcon
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.OutGameMenu
{
  [Token(Token = "0x20039C8")]
  public class CustomSkillTypeIcon : MonoBehaviour
  {
    [Token(Token = "0x400FCA3")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Image typeIconImage;

    [Token(Token = "0x6016B14")]
    [Address(RVA = "0x3F67AAC", Offset = "0x3F67AAC", VA = "0x3F67AAC")]
    public void SetIcon(SkillTypeEnum skillType)
    {
    }

    [Token(Token = "0x6016B15")]
    [Address(RVA = "0x3F67BA4", Offset = "0x3F67BA4", VA = "0x3F67BA4")]
    public CustomSkillTypeIcon()
    {
    }
  }
}
