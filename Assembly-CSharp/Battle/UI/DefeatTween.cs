// Decompiled with JetBrains decompiler
// Type: Battle.UI.DefeatTween
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Tween;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Battle.UI
{
  [Token(Token = "0x20023D6")]
  [RequireComponent(typeof (UITweenGroup))]
  public sealed class DefeatTween : TweenWrapper
  {
    [Token(Token = "0x40098E0")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    [HideInInspector]
    private string nameDefeat;
    [Token(Token = "0x40098E1")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private string jingleDefeat;
    [Token(Token = "0x40098E2")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Image charaTexture;
    [Token(Token = "0x40098E3")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Image charaSilhouetteTexture;
    [Token(Token = "0x40098E4")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private Text charaName;
    [Token(Token = "0x40098E5")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private Sprite defaultCharaTexture;

    [Token(Token = "0x600DB98")]
    [Address(RVA = "0x214EC04", Offset = "0x214EC04", VA = "0x214EC04")]
    public void Play(Sprite charaTexture, string charaName)
    {
    }

    [Token(Token = "0x600DB99")]
    [Address(RVA = "0x214ED4C", Offset = "0x214ED4C", VA = "0x214ED4C")]
    public DefeatTween()
    {
    }
  }
}
