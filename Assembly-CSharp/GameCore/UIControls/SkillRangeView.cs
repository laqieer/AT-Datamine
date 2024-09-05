// Decompiled with JetBrains decompiler
// Type: GameCore.UIControls.SkillRangeView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data;
using Battle.Data.Board;
using GameCore.MasterData;
using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace GameCore.UIControls
{
  [Token(Token = "0x2000C11")]
  [RequireComponent(typeof (GridLayoutGroup))]
  public sealed class SkillRangeView : MonoBehaviour
  {
    [Token(Token = "0x40036C6")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    [HideInInspector]
    private GridLayoutGroup gridLayoutGroup;
    [Token(Token = "0x40036C7")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private List<SkillRangeViewCell> cells;
    [Token(Token = "0x40036C8")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private SkillRangeViewCell baseCell;
    [Token(Token = "0x40036C9")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Image effectiveCenterPointImage;
    [Token(Token = "0x40036CA")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Image playerUnitPosImage;
    [Token(Token = "0x40036CB")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private Image enemyUnitPosImage;
    [Token(Token = "0x40036CC")]
    [FieldOffset(Offset = "0x48")]
    private int centerX;
    [Token(Token = "0x40036CD")]
    [FieldOffset(Offset = "0x4C")]
    private int centerY;

    [Token(Token = "0x6004519")]
    [Address(RVA = "0x364EC68", Offset = "0x364EC68", VA = "0x364EC68")]
    public void Initialize()
    {
    }

    [Token(Token = "0x600451A")]
    [Address(RVA = "0x364ED20", Offset = "0x364ED20", VA = "0x364ED20")]
    private void CreateCells()
    {
    }

    [Token(Token = "0x600451B")]
    [Address(RVA = "0x364F1C8", Offset = "0x364F1C8", VA = "0x364F1C8")]
    public void UpdateView(
      IBasicRangeData firingRange,
      EffectData[] effectDatas = null,
      TargettableUnitTypeEnum? targettableUnitType = null)
    {
    }

    [Token(Token = "0x600451C")]
    [Address(RVA = "0x364F478", Offset = "0x364F478", VA = "0x364F478")]
    private void FiringRangeUpdate(
      IBasicRangeData firingRange,
      EffectData[] effectDatas,
      TargettableUnitTypeEnum? targettableUnitType)
    {
    }

    [Token(Token = "0x600451D")]
    [Address(RVA = "0x364FCE0", Offset = "0x364FCE0", VA = "0x364FCE0")]
    public SkillRangeView()
    {
    }
  }
}
