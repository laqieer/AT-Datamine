// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Info.Common.UI.AdditionalParameterCategoryUI
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UI;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.Info.Common.UI
{
  [Token(Token = "0x20035E3")]
  public class AdditionalParameterCategoryUI : MonoBehaviour
  {
    [Token(Token = "0x400EA74")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private TextAccessor title;
    [Token(Token = "0x400EA75")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private AdditionalParameterElementUI element;
    [Token(Token = "0x400EA76")]
    [FieldOffset(Offset = "0x28")]
    private List<AdditionalParameterElementUI> instances;

    [Token(Token = "0x170046B2")]
    public bool DisplayZero
    {
      [Token(Token = "0x601538D"), Address(RVA = "0x4D8C3B4", Offset = "0x4D8C3B4", VA = "0x4D8C3B4")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x601538E")]
    [Address(RVA = "0x4D86C68", Offset = "0x4D86C68", VA = "0x4D86C68")]
    public void SetText(string title)
    {
    }

    [Token(Token = "0x601538F")]
    [Address(RVA = "0x4D8C3D0", Offset = "0x4D8C3D0", VA = "0x4D8C3D0")]
    public AdditionalParameterElementUI GetInstance(int index)
    {
      return (AdditionalParameterElementUI) null;
    }

    [Token(Token = "0x6015390")]
    [Address(RVA = "0x4D86C84", Offset = "0x4D86C84", VA = "0x4D86C84")]
    public AdditionalParameterElementUI CreateInstance() => (AdditionalParameterElementUI) null;

    [Token(Token = "0x6015391")]
    [Address(RVA = "0x4D8C47C", Offset = "0x4D8C47C", VA = "0x4D8C47C")]
    public AdditionalParameterCategoryUI()
    {
    }
  }
}
