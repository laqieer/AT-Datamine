// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.CharacterList.TrainingItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System;
using TMPro;

#nullable disable
namespace Scenes.OutGame.CharacterList
{
  [Token(Token = "0x200373C")]
  [Serializable]
  public class TrainingItem
  {
    [Token(Token = "0x400F141")]
    [FieldOffset(Offset = "0x10")]
    public WeaponTypeEnum type;
    [Token(Token = "0x400F142")]
    [FieldOffset(Offset = "0x18")]
    public TextMeshProUGUI textRank;
    [Token(Token = "0x400F143")]
    [FieldOffset(Offset = "0x20")]
    public TextMeshProUGUI textNextExperience;

    [Token(Token = "0x6015C29")]
    [Address(RVA = "0x1B25268", Offset = "0x1B25268", VA = "0x1B25268")]
    public TrainingItem()
    {
    }
  }
}
