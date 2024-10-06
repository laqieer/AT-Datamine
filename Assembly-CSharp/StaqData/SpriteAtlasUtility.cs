// Decompiled with JetBrains decompiler
// Type: StaqData.SpriteAtlasUtility
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x2002088")]
  public class SpriteAtlasUtility
  {
    [Token(Token = "0x4008A74")]
    [FieldOffset(Offset = "0x10")]
    private Dictionary<string, SpriteAtlas> atlasPool;

    [Token(Token = "0x600C4D1")]
    [Address(RVA = "0x19FDC98", Offset = "0x19FDC98", VA = "0x19FDC98")]
    public void Initialize()
    {
    }

    [Token(Token = "0x600C4D2")]
    [Address(RVA = "0x19FDCE8", Offset = "0x19FDCE8", VA = "0x19FDCE8")]
    public void Clear()
    {
    }

    [Token(Token = "0x600C4D3")]
    [Address(RVA = "0x19FDEFC", Offset = "0x19FDEFC", VA = "0x19FDEFC")]
    public IEnumerator Load(string dlcName, string atlasName, Action<bool> callback = null)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x600C4D4")]
    [Address(RVA = "0x19FDFAC", Offset = "0x19FDFAC", VA = "0x19FDFAC")]
    public void Unload(string dlcName)
    {
    }

    [Token(Token = "0x600C4D5")]
    [Address(RVA = "0x19FE094", Offset = "0x19FE094", VA = "0x19FE094")]
    public Sprite Get(string dlcName, string spriteName) => (Sprite) null;

    [Token(Token = "0x600C4D6")]
    [Address(RVA = "0x19F8968", Offset = "0x19F8968", VA = "0x19F8968")]
    public SpriteAtlasUtility()
    {
    }
  }
}
