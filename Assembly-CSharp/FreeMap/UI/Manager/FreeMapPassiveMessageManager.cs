// Decompiled with JetBrains decompiler
// Type: FreeMap.UI.Manager.FreeMapPassiveMessageManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.Instance;
using FreeMap.UI.Entity;
using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace FreeMap.UI.Manager
{
  [Token(Token = "0x200167E")]
  public class FreeMapPassiveMessageManager : FreeMapUIManager<FreeMapPassiveMessageUI>
  {
    [Token(Token = "0x6007EF7")]
    [Address(RVA = "0x21A1C74", Offset = "0x21A1C74", VA = "0x21A1C74")]
    public FreeMapPassiveMessageManager(FreeMapUICanvas uiCanvas)
    {
    }

    [Token(Token = "0x6007EF8")]
    [Address(RVA = "0x21B43C4", Offset = "0x21B43C4", VA = "0x21B43C4", Slot = "16")]
    public override void Update(Camera usingCamera, FreeMapPlayerInstance player)
    {
    }

    [Token(Token = "0x6007EF9")]
    [Address(RVA = "0x21B4764", Offset = "0x21B4764", VA = "0x21B4764", Slot = "23")]
    protected override bool OnVisibleTerms(FreeMapPassiveMessageUI item) => new bool();
  }
}
