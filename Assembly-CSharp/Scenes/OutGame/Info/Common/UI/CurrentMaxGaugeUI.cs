// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Info.Common.UI.CurrentMaxGaugeUI
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.Info.Common.UI
{
  [Token(Token = "0x20035E7")]
  public abstract class CurrentMaxGaugeUI : MonoBehaviour
  {
    [Token(Token = "0x601539A")]
    public abstract void Set(int current, int max, int remainingStock = 0);

    [Token(Token = "0x601539B")]
    [Address(RVA = "0x4D8C6D8", Offset = "0x4D8C6D8", VA = "0x4D8C6D8")]
    protected CurrentMaxGaugeUI()
    {
    }
  }
}
