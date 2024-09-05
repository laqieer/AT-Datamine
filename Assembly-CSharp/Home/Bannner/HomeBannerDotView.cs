// Decompiled with JetBrains decompiler
// Type: Home.Bannner.HomeBannerDotView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Home.Bannner
{
  [Token(Token = "0x2000B7F")]
  internal class HomeBannerDotView : MonoBehaviour
  {
    [Token(Token = "0x4003464")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private HomeBannerDotView.HighLightObject objectHighlight;
    [Token(Token = "0x4003465")]
    [FieldOffset(Offset = "0x28")]
    private bool isHighlight;

    [Token(Token = "0x17000982")]
    public bool IsHighlight
    {
      [Token(Token = "0x600416E"), Address(RVA = "0x2A2FBF0", Offset = "0x2A2FBF0", VA = "0x2A2FBF0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600416F")]
    [Address(RVA = "0x2A2FBF8", Offset = "0x2A2FBF8", VA = "0x2A2FBF8")]
    public void SetHighlight(bool isHighlight)
    {
    }

    [Token(Token = "0x6004170")]
    [Address(RVA = "0x2A2FC44", Offset = "0x2A2FC44", VA = "0x2A2FC44")]
    public HomeBannerDotView()
    {
    }

    [Token(Token = "0x2000B80")]
    [Serializable]
    private struct HighLightObject
    {
      [Token(Token = "0x4003466")]
      [FieldOffset(Offset = "0x0")]
      public GameObject on;
      [Token(Token = "0x4003467")]
      [FieldOffset(Offset = "0x8")]
      public GameObject off;
    }
  }
}
