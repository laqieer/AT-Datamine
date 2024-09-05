// Decompiled with JetBrains decompiler
// Type: Battle.UI.BattleUnitFierceCount
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Battle.UI
{
  [Token(Token = "0x2002425")]
  public sealed class BattleUnitFierceCount : MonoBehaviour
  {
    [Token(Token = "0x4009AAB")]
    [FieldOffset(Offset = "0x18")]
    public Text fierceCountText;
    [Token(Token = "0x4009AAC")]
    [FieldOffset(Offset = "0x20")]
    private bool isEnabledFierceCount;
    [Token(Token = "0x4009AAD")]
    [FieldOffset(Offset = "0x21")]
    private bool isShowingChildren;

    [Token(Token = "0x17002F8A")]
    public bool Visible
    {
      [Token(Token = "0x600DD74"), Address(RVA = "0x1E2890C", Offset = "0x1E2890C", VA = "0x1E2890C")] get
      {
        return new bool();
      }
      [Token(Token = "0x600DD75"), Address(RVA = "0x1E2892C", Offset = "0x1E2892C", VA = "0x1E2892C")] set
      {
      }
    }

    [Token(Token = "0x600DD76")]
    [Address(RVA = "0x1E28954", Offset = "0x1E28954", VA = "0x1E28954")]
    public static BattleUnitFierceCount Create(
      string assetBundleLabel,
      string assetName,
      Transform parent,
      BattleConfigAsset config)
    {
      return (BattleUnitFierceCount) null;
    }

    [Token(Token = "0x600DD77")]
    [Address(RVA = "0x1E28B70", Offset = "0x1E28B70", VA = "0x1E28B70")]
    private void Start()
    {
    }

    [Token(Token = "0x600DD78")]
    [Address(RVA = "0x1E28C0C", Offset = "0x1E28C0C", VA = "0x1E28C0C")]
    private void Update()
    {
    }

    [Token(Token = "0x600DD79")]
    [Address(RVA = "0x1E28B7C", Offset = "0x1E28B7C", VA = "0x1E28B7C")]
    private void ShowChildren(bool showing)
    {
    }

    [Token(Token = "0x600DD7A")]
    [Address(RVA = "0x1E28A84", Offset = "0x1E28A84", VA = "0x1E28A84")]
    public void Initialize(BattleConfigAsset battleConfig)
    {
    }

    [Token(Token = "0x600DD7B")]
    [Address(RVA = "0x1E28C30", Offset = "0x1E28C30", VA = "0x1E28C30")]
    public void Release()
    {
    }

    [Token(Token = "0x600DD7C")]
    [Address(RVA = "0x1E28C9C", Offset = "0x1E28C9C", VA = "0x1E28C9C")]
    public void EnableFierceCount(bool enabled)
    {
    }

    [Token(Token = "0x600DD7D")]
    [Address(RVA = "0x1E28CA8", Offset = "0x1E28CA8", VA = "0x1E28CA8")]
    public void SetCount(int count)
    {
    }

    [Token(Token = "0x600DD7E")]
    [Address(RVA = "0x1E28CF0", Offset = "0x1E28CF0", VA = "0x1E28CF0")]
    public BattleUnitFierceCount()
    {
    }
  }
}
