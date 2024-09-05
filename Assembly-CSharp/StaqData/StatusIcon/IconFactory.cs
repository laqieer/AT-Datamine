// Decompiled with JetBrains decompiler
// Type: StaqData.StatusIcon.IconFactory
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using Il2CppDummyDll;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace StaqData.StatusIcon
{
  [Token(Token = "0x2002162")]
  public class IconFactory
  {
    [Token(Token = "0x4008D6A")]
    [FieldOffset(Offset = "0x10")]
    private StatusIconConfig iconConfig;

    [Token(Token = "0x600CC9E")]
    [Address(RVA = "0x1BB0BA4", Offset = "0x1BB0BA4", VA = "0x1BB0BA4")]
    public void Initialize()
    {
    }

    [Token(Token = "0x600CC9F")]
    [Address(RVA = "0x1BB0C44", Offset = "0x1BB0C44", VA = "0x1BB0C44")]
    public IEnumerator InitializeAsync(AssetCachedSpawner assetCachedSpawner) => (IEnumerator) null;

    [Token(Token = "0x600CCA0")]
    [Address(RVA = "0x1BB0CE0", Offset = "0x1BB0CE0", VA = "0x1BB0CE0")]
    public HashSet<string> GetAssetBundleLabels() => (HashSet<string>) null;

    [Token(Token = "0x600CCA1")]
    [Address(RVA = "0x1BB0E58", Offset = "0x1BB0E58", VA = "0x1BB0E58")]
    public Sprite GetMainSkillIcon(int masterId) => (Sprite) null;

    [Token(Token = "0x600CCA2")]
    [Address(RVA = "0x1BB113C", Offset = "0x1BB113C", VA = "0x1BB113C")]
    public Sprite GetSubSkillIcon(int masterId) => (Sprite) null;

    [Token(Token = "0x600CCA3")]
    [Address(RVA = "0x1BB12B8", Offset = "0x1BB12B8", VA = "0x1BB12B8")]
    public Sprite GetSubSkillIcon(string iconName) => (Sprite) null;

    [Token(Token = "0x600CCA4")]
    [Address(RVA = "0x1BB1364", Offset = "0x1BB1364", VA = "0x1BB1364")]
    public IconFactory()
    {
    }
  }
}
