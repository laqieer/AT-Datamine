// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Info.Skill.UI.SkillEffectTagUI
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.Info.Skill.UI
{
  [Token(Token = "0x2003592")]
  [Serializable]
  public class SkillEffectTagUI
  {
    [Token(Token = "0x400E8E1")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Text[] texts;
    [Token(Token = "0x400E8E2")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    [Tooltip("タイプを指定してください（タグを非表示にする際に背景ごとOffにします。Prefabによる構造違いを吸収するための指定です）")]
    private SkillEffectTagUI.Type type;
    [Token(Token = "0x400E8E3")]
    private const string TOOLTIP_EXPLAIN = "タイプを指定してください（タグを非表示にする際に背景ごとOffにします。Prefabによる構造違いを吸収するための指定です）";

    [Token(Token = "0x6015093")]
    [Address(RVA = "0x4AA7734", Offset = "0x4AA7734", VA = "0x4AA7734")]
    public void Deactive()
    {
    }

    [Token(Token = "0x6015094")]
    [Address(RVA = "0x4AA769C", Offset = "0x4AA769C", VA = "0x4AA769C")]
    public void Set(string tag)
    {
    }

    [Token(Token = "0x6015095")]
    [Address(RVA = "0x4AA75D0", Offset = "0x4AA75D0", VA = "0x4AA75D0")]
    public void Set(string tag1, string tag2)
    {
    }

    [Token(Token = "0x6015096")]
    [Address(RVA = "0x4AA8A30", Offset = "0x4AA8A30", VA = "0x4AA8A30")]
    private Transform Target(int index) => (Transform) null;

    [Token(Token = "0x6015097")]
    [Address(RVA = "0x4AA8A8C", Offset = "0x4AA8A8C", VA = "0x4AA8A8C")]
    public SkillEffectTagUI()
    {
    }

    [Token(Token = "0x2003593")]
    [Serializable]
    public enum Type
    {
      [Token(Token = "0x400E8E5")] Self,
      [Token(Token = "0x400E8E6")] Parent,
    }
  }
}
