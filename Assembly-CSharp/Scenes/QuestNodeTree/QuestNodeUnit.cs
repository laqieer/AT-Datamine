// Decompiled with JetBrains decompiler
// Type: Scenes.QuestNodeTree.QuestNodeUnit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Scenes.QuestNodeTree
{
  [Token(Token = "0x2002A2C")]
  public class QuestNodeUnit : QuestNodeBase
  {
    [Token(Token = "0x400B36D")]
    [FieldOffset(Offset = "0x18")]
    public GameObject unitModel;
    [Token(Token = "0x400B36E")]
    [FieldOffset(Offset = "0x20")]
    private bool isSetuped;
    [Token(Token = "0x400B36F")]
    [FieldOffset(Offset = "0x28")]
    public Material haveShaderingPrameter;
    [Token(Token = "0x400B370")]
    [FieldOffset(Offset = "0x30")]
    private List<Material> materials;
    [Token(Token = "0x400B371")]
    [FieldOffset(Offset = "0x38")]
    private SpriteRenderer[] spriteRendererTable;
    [Token(Token = "0x400B372")]
    [FieldOffset(Offset = "0x40")]
    private string defaultAnimationKey;
    [Token(Token = "0x400B373")]
    [FieldOffset(Offset = "0x48")]
    private Animator animator;

    [Token(Token = "0x6010836")]
    [Address(RVA = "0x4C23788", Offset = "0x4C23788", VA = "0x4C23788")]
    private void OnEnable()
    {
    }

    [Token(Token = "0x6010837")]
    [Address(RVA = "0x4C23800", Offset = "0x4C23800", VA = "0x4C23800")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x6010838")]
    [Address(RVA = "0x4C239A4", Offset = "0x4C239A4", VA = "0x4C239A4", Slot = "4")]
    public override void SetAlpha(float value)
    {
    }

    [Token(Token = "0x6010839")]
    [Address(RVA = "0x4C23B88", Offset = "0x4C23B88", VA = "0x4C23B88")]
    public void SetDefaultAnimationKey(string key)
    {
    }

    [Token(Token = "0x601083A")]
    [Address(RVA = "0x4C226FC", Offset = "0x4C226FC", VA = "0x4C226FC")]
    public void Play()
    {
    }

    [Token(Token = "0x601083B")]
    [Address(RVA = "0x4C23B90", Offset = "0x4C23B90", VA = "0x4C23B90")]
    public void Setup(GameObject target)
    {
    }

    [Token(Token = "0x601083C")]
    [Address(RVA = "0x4C23804", Offset = "0x4C23804", VA = "0x4C23804")]
    private void ClearSetup()
    {
    }

    [Token(Token = "0x601083D")]
    [Address(RVA = "0x4C23FB8", Offset = "0x4C23FB8", VA = "0x4C23FB8")]
    public QuestNodeUnit()
    {
    }
  }
}
