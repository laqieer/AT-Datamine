// Decompiled with JetBrains decompiler
// Type: GachaRarityTextController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x20001FE")]
public class GachaRarityTextController : MonoBehaviour
{
  [Token(Token = "0x4000BC4")]
  [FieldOffset(Offset = "0x18")]
  [SerializeField]
  private GameObject rarityN;
  [Token(Token = "0x4000BC5")]
  [FieldOffset(Offset = "0x20")]
  [SerializeField]
  private GameObject rarityR;
  [Token(Token = "0x4000BC6")]
  [FieldOffset(Offset = "0x28")]
  [SerializeField]
  private GameObject raritySR;
  [Token(Token = "0x4000BC7")]
  [FieldOffset(Offset = "0x30")]
  [SerializeField]
  private GameObject raritySSR;
  [Token(Token = "0x4000BC8")]
  [FieldOffset(Offset = "0x38")]
  [SerializeField]
  private GameObject rarityUR;

  [Token(Token = "0x6000CBA")]
  [Address(RVA = "0x4C7A7D0", Offset = "0x4C7A7D0", VA = "0x4C7A7D0")]
  public void SetRarity(GachaAwardData.RarityType rarityType)
  {
  }

  [Token(Token = "0x6000CBB")]
  [Address(RVA = "0x4C7C610", Offset = "0x4C7C610", VA = "0x4C7C610")]
  private void DisableAll()
  {
  }

  [Token(Token = "0x6000CBC")]
  [Address(RVA = "0x4C7C668", Offset = "0x4C7C668", VA = "0x4C7C668")]
  private void SetRarityActive(GachaAwardData.RarityType rarityType, bool enable)
  {
  }

  [Token(Token = "0x6000CBD")]
  [Address(RVA = "0x4C7C750", Offset = "0x4C7C750", VA = "0x4C7C750")]
  public GachaRarityTextController()
  {
  }
}
