// Decompiled with JetBrains decompiler
// Type: GameCore.UIControls.SafeAreaExtensions
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace GameCore.UIControls
{
  [Token(Token = "0x2000C0E")]
  public class SafeAreaExtensions : MonoBehaviour
  {
    [Token(Token = "0x40036BB")]
    [FieldOffset(Offset = "0x0")]
    private static readonly float CommonDecreaseRateHeight;
    [Token(Token = "0x40036BC")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private bool isCommonRate;
    [Token(Token = "0x40036BD")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private float decreaseRateHeight;

    [Token(Token = "0x170009FE")]
    public float RateHeight
    {
      [Token(Token = "0x600450B"), Address(RVA = "0x364E6F0", Offset = "0x364E6F0", VA = "0x364E6F0")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x600450C")]
    [Address(RVA = "0x364E6F8", Offset = "0x364E6F8", VA = "0x364E6F8")]
    private void Awake()
    {
    }

    [Token(Token = "0x600450D")]
    [Address(RVA = "0x364E768", Offset = "0x364E768", VA = "0x364E768")]
    public SafeAreaExtensions()
    {
    }

    [Token(Token = "0x600450E")]
    [Address(RVA = "0x364E7D8", Offset = "0x364E7D8", VA = "0x364E7D8")]
    static SafeAreaExtensions()
    {
    }
  }
}
