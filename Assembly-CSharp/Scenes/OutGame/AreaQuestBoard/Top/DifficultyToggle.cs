// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.AreaQuestBoard.Top.DifficultyToggle
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using GameCore.UIControls;
using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.AreaQuestBoard.Top
{
  [Token(Token = "0x20038F7")]
  [Serializable]
  internal class DifficultyToggle
  {
    [Token(Token = "0x400F911")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private QuestDifficultyTypeEnum difficultyType;
    [Token(Token = "0x400F912")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private ChooseObjectArray chooseObjectArray;
    [Token(Token = "0x400F913")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private CommonButton button;
    [Token(Token = "0x400F914")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private GameObject lockObj;

    [Token(Token = "0x170049A2")]
    public QuestDifficultyTypeEnum DifficultyType
    {
      [Token(Token = "0x601664A"), Address(RVA = "0x2081F9C", Offset = "0x2081F9C", VA = "0x2081F9C")] get
      {
        return new QuestDifficultyTypeEnum();
      }
    }

    [Token(Token = "0x170049A3")]
    public bool IsLock
    {
      [Token(Token = "0x601664B"), Address(RVA = "0x2081FA4", Offset = "0x2081FA4", VA = "0x2081FA4")] get
      {
        return new bool();
      }
      [Token(Token = "0x601664C"), Address(RVA = "0x2081FAC", Offset = "0x2081FAC", VA = "0x2081FAC")] private set
      {
      }
    }

    [Token(Token = "0x601664D")]
    [Address(RVA = "0x2081FB8", Offset = "0x2081FB8", VA = "0x2081FB8")]
    public void SetLock()
    {
    }

    [Token(Token = "0x601664E")]
    [Address(RVA = "0x2082070", Offset = "0x2082070", VA = "0x2082070")]
    public void SetUnlock()
    {
    }

    [Token(Token = "0x601664F")]
    [Address(RVA = "0x2082050", Offset = "0x2082050", VA = "0x2082050")]
    public void Off()
    {
    }

    [Token(Token = "0x6016650")]
    [Address(RVA = "0x2082104", Offset = "0x2082104", VA = "0x2082104")]
    public void On()
    {
    }

    [Token(Token = "0x6016651")]
    [Address(RVA = "0x2080A98", Offset = "0x2080A98", VA = "0x2080A98")]
    public void SetAction(Action action)
    {
    }

    [Token(Token = "0x6016652")]
    [Address(RVA = "0x2082124", Offset = "0x2082124", VA = "0x2082124")]
    public DifficultyToggle()
    {
    }
  }
}
