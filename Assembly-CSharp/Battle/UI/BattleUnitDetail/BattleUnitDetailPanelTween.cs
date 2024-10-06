// Decompiled with JetBrains decompiler
// Type: Battle.UI.BattleUnitDetail.BattleUnitDetailPanelTween
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Tween;
using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace Battle.UI.BattleUnitDetail
{
  [Token(Token = "0x200243F")]
  public sealed class BattleUnitDetailPanelTween : TweenWrapper
  {
    [Token(Token = "0x4009B2A")]
    [FieldOffset(Offset = "0x20")]
    [HideInInspector]
    [SerializeField]
    private string inName;
    [Token(Token = "0x4009B2B")]
    [FieldOffset(Offset = "0x28")]
    [HideInInspector]
    [SerializeField]
    private string outName;
    [Token(Token = "0x4009B2C")]
    [FieldOffset(Offset = "0x30")]
    [HideInInspector]
    [SerializeField]
    private string statusTabName;
    [Token(Token = "0x4009B2D")]
    [FieldOffset(Offset = "0x38")]
    [HideInInspector]
    [SerializeField]
    private string compatibilityTabName;
    [Token(Token = "0x4009B2E")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    [HideInInspector]
    private string skillDetailInName;
    [Token(Token = "0x4009B2F")]
    [FieldOffset(Offset = "0x48")]
    [HideInInspector]
    [SerializeField]
    private string skillDetailOutName;
    [Token(Token = "0x4009B30")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    [HideInInspector]
    private string equipmentDetailInName;
    [Token(Token = "0x4009B31")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    [HideInInspector]
    private string equipmentDetailOutName;
    [Token(Token = "0x4009B32")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private UITweenGroup skillDetailTweenGroup;
    [Token(Token = "0x4009B33")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private UITweenGroup equipmentDetailTweenGroup;

    [Token(Token = "0x600DE1E")]
    [Address(RVA = "0x1E2E5CC", Offset = "0x1E2E5CC", VA = "0x1E2E5CC")]
    public void PlayIn()
    {
    }

    [Token(Token = "0x600DE1F")]
    [Address(RVA = "0x1E2E674", Offset = "0x1E2E674", VA = "0x1E2E674")]
    public void PlayOut()
    {
    }

    [Token(Token = "0x600DE20")]
    [Address(RVA = "0x1E2E71C", Offset = "0x1E2E71C", VA = "0x1E2E71C")]
    public void PlayStatus()
    {
    }

    [Token(Token = "0x600DE21")]
    [Address(RVA = "0x1E2E7C4", Offset = "0x1E2E7C4", VA = "0x1E2E7C4")]
    public void PlayCompatibility()
    {
    }

    [Token(Token = "0x600DE22")]
    [Address(RVA = "0x1E2E86C", Offset = "0x1E2E86C", VA = "0x1E2E86C")]
    public void PlaySkillDetailIn()
    {
    }

    [Token(Token = "0x600DE23")]
    [Address(RVA = "0x1E2E988", Offset = "0x1E2E988", VA = "0x1E2E988")]
    public void PlaySkillDetailOut()
    {
    }

    [Token(Token = "0x600DE24")]
    [Address(RVA = "0x1E2EA2C", Offset = "0x1E2EA2C", VA = "0x1E2EA2C")]
    public void PlayEquipmentDetailIn()
    {
    }

    [Token(Token = "0x600DE25")]
    [Address(RVA = "0x1E2EAD0", Offset = "0x1E2EAD0", VA = "0x1E2EAD0")]
    public void PlayEquipmentDetailOut()
    {
    }

    [Token(Token = "0x600DE26")]
    [Address(RVA = "0x1E2EB74", Offset = "0x1E2EB74", VA = "0x1E2EB74", Slot = "7")]
    protected override void LateUpdate()
    {
    }

    [Token(Token = "0x600DE27")]
    [Address(RVA = "0x1E2E910", Offset = "0x1E2E910", VA = "0x1E2E910")]
    private void Play(
      UITweenGroup activeTweenGroup,
      bool skipPrev = true,
      bool asap = false,
      params string[] names)
    {
    }

    [Token(Token = "0x600DE28")]
    [Address(RVA = "0x1E2EB78", Offset = "0x1E2EB78", VA = "0x1E2EB78")]
    public BattleUnitDetailPanelTween()
    {
    }
  }
}
