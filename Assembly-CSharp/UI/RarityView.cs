// Decompiled with JetBrains decompiler
// Type: UI.RarityView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace UI
{
  [Token(Token = "0x2000883")]
  internal abstract class RarityView : MonoBehaviour
  {
    [Token(Token = "0x60030A8")]
    public abstract void SetRarity(RarityTypeEnum rarityType);

    [Token(Token = "0x60030A9")]
    [Address(RVA = "0x3E7A6D8", Offset = "0x3E7A6D8", VA = "0x3E7A6D8")]
    protected RarityView()
    {
    }
  }
}
