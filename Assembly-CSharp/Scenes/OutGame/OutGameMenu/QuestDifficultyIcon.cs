// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.OutGameMenu.QuestDifficultyIcon
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Tween;
using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.OutGameMenu
{
  [Token(Token = "0x2003A41")]
  public class QuestDifficultyIcon : MonoBehaviour
  {
    [Token(Token = "0x400FF2F")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    [Header("TweenGroup")]
    private UITweenGroup tween;

    [Token(Token = "0x6016E54")]
    [Address(RVA = "0x2C5F79C", Offset = "0x2C5F79C", VA = "0x2C5F79C")]
    public void CreateLapTimeIcon(int lapTime)
    {
    }

    [Token(Token = "0x6016E55")]
    [Address(RVA = "0x2C5F868", Offset = "0x2C5F868", VA = "0x2C5F868")]
    private void Play(string tweenRankName, string tweenColorName)
    {
    }

    [Token(Token = "0x6016E56")]
    [Address(RVA = "0x2C5F8B0", Offset = "0x2C5F8B0", VA = "0x2C5F8B0")]
    public QuestDifficultyIcon()
    {
    }

    [Token(Token = "0x2003A42")]
    private class QuestDifficultyIconTweenName
    {
      [Token(Token = "0x400FF30")]
      public const string OneStar = "Difficulty_1";
      [Token(Token = "0x400FF31")]
      public const string TwoStar = "Difficulty_2";
      [Token(Token = "0x400FF32")]
      public const string ThreeStar = "Difficulty_3";
      [Token(Token = "0x400FF33")]
      public const string FourStar = "Difficulty_4";
      [Token(Token = "0x400FF34")]
      public const string FiveStar = "Difficulty_5";
      [Token(Token = "0x400FF35")]
      public const string Blue = "Difficulty_Blue";
      [Token(Token = "0x400FF36")]
      public const string Yellow = "Difficulty_Yellow";
      [Token(Token = "0x400FF37")]
      public const string Red = "Difficulty_Red";

      [Token(Token = "0x6016E57")]
      [Address(RVA = "0x2C5F8B8", Offset = "0x2C5F8B8", VA = "0x2C5F8B8")]
      public QuestDifficultyIconTweenName()
      {
      }
    }
  }
}
