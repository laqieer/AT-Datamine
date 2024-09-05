// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.AreaQuestBoard.Top.JumpNodeButton
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System;
using TMPro;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.AreaQuestBoard.Top
{
  [Token(Token = "0x20038FC")]
  internal class JumpNodeButton : MonoBehaviour
  {
    [Token(Token = "0x400F91A")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private TextMeshProUGUI textMeshProUGUI;
    [Token(Token = "0x400F91B")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private CommonButton button;
    [Token(Token = "0x400F91C")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private GameObject normalEffect;
    [Token(Token = "0x400F91D")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private GameObject hardEffect;
    [Token(Token = "0x400F91E")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private GameObject veryHardEffect;

    [Token(Token = "0x170049AB")]
    public int AssignAreaNodeShortcutId
    {
      [Token(Token = "0x601666A"), Address(RVA = "0x2082194", Offset = "0x2082194", VA = "0x2082194")] get
      {
        return new int();
      }
      [Token(Token = "0x601666B"), Address(RVA = "0x208219C", Offset = "0x208219C", VA = "0x208219C")] private set
      {
      }
    }

    [Token(Token = "0x170049AC")]
    public bool IsActive
    {
      [Token(Token = "0x601666C"), Address(RVA = "0x20821A4", Offset = "0x20821A4", VA = "0x20821A4")] get
      {
        return new bool();
      }
      [Token(Token = "0x601666D"), Address(RVA = "0x20821AC", Offset = "0x20821AC", VA = "0x20821AC")] private set
      {
      }
    }

    [Token(Token = "0x170049AD")]
    public bool IsOnEffect
    {
      [Token(Token = "0x601666E"), Address(RVA = "0x20821B8", Offset = "0x20821B8", VA = "0x20821B8")] get
      {
        return new bool();
      }
      [Token(Token = "0x601666F"), Address(RVA = "0x20821C0", Offset = "0x20821C0", VA = "0x20821C0")] private set
      {
      }
    }

    [Token(Token = "0x6016670")]
    [Address(RVA = "0x207BB0C", Offset = "0x207BB0C", VA = "0x207BB0C")]
    public void Setup(int assignAreaNodeShortcutId, string text, Action action)
    {
    }

    [Token(Token = "0x6016671")]
    [Address(RVA = "0x2081040", Offset = "0x2081040", VA = "0x2081040")]
    public void SetDisable()
    {
    }

    [Token(Token = "0x6016672")]
    [Address(RVA = "0x207BC68", Offset = "0x207BC68", VA = "0x207BC68")]
    public void EnableEffect(QuestDifficultyTypeEnum difficultyType)
    {
    }

    [Token(Token = "0x6016673")]
    [Address(RVA = "0x2080EF4", Offset = "0x2080EF4", VA = "0x2080EF4")]
    public void DisableEffect()
    {
    }

    [Token(Token = "0x6016674")]
    [Address(RVA = "0x20821CC", Offset = "0x20821CC", VA = "0x20821CC")]
    public JumpNodeButton()
    {
    }
  }
}
