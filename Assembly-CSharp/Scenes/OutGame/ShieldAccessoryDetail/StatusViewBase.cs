// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.ShieldAccessoryDetail.StatusViewBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Scenes.OutGame.Utility;
using System;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.ShieldAccessoryDetail
{
  [Token(Token = "0x20033B1")]
  public abstract class StatusViewBase : MonoBehaviour, IStatusView
  {
    [Token(Token = "0x400E098")]
    private const string UpdatedColorText = "#00C4FF";

    [Token(Token = "0x6014533")]
    public abstract void SetVisible(bool isVisible);

    [Token(Token = "0x6014534")]
    public abstract void UpdateStatus(
      AccessoryStandardStatus status,
      AccessoryStandardStatus assumption = null);

    [Token(Token = "0x6014535")]
    [Address(RVA = "0x206CBB4", Offset = "0x206CBB4", VA = "0x206CBB4")]
    protected string NormalFmt(int src, int dst) => (string) null;

    [Token(Token = "0x6014536")]
    [Address(RVA = "0x206CC94", Offset = "0x206CC94", VA = "0x206CC94")]
    protected void UpdateText(Text text, int src, int? dst, Func<int, int, string> textFmt)
    {
    }

    [Token(Token = "0x6014537")]
    [Address(RVA = "0x2060AF8", Offset = "0x2060AF8", VA = "0x2060AF8")]
    protected void UpdateText(Text text, int src, int? dst)
    {
    }

    [Token(Token = "0x6014538")]
    [Address(RVA = "0x2060BA4", Offset = "0x2060BA4", VA = "0x2060BA4")]
    protected StatusViewBase()
    {
    }
  }
}
