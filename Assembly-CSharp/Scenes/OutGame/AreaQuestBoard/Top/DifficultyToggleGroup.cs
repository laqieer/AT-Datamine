// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.AreaQuestBoard.Top.DifficultyToggleGroup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.AreaQuestBoard.Top
{
  [Token(Token = "0x20038F8")]
  internal class DifficultyToggleGroup : MonoBehaviour
  {
    [Token(Token = "0x400F916")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private List<DifficultyToggle> difficultyToggles;
    [Token(Token = "0x400F917")]
    [FieldOffset(Offset = "0x20")]
    private int selectedDifficultyId;

    [Token(Token = "0x170049A4")]
    public List<DifficultyToggle> DifficultySelectToggleButtons
    {
      [Token(Token = "0x6016653"), Address(RVA = "0x208212C", Offset = "0x208212C", VA = "0x208212C")] get
      {
        return (List<DifficultyToggle>) null;
      }
    }

    [Token(Token = "0x6016654")]
    [Address(RVA = "0x20808CC", Offset = "0x20808CC", VA = "0x20808CC")]
    public void Setup(int selectedDifficultyId, int unlockHighestDifficultyId)
    {
    }

    [Token(Token = "0x6016655")]
    [Address(RVA = "0x2080B38", Offset = "0x2080B38", VA = "0x2080B38")]
    public bool TryChange(int nextDifficultyId) => new bool();

    [Token(Token = "0x6016656")]
    [Address(RVA = "0x208213C", Offset = "0x208213C", VA = "0x208213C")]
    public DifficultyToggleGroup()
    {
    }
  }
}
