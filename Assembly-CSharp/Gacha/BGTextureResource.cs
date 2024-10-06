// Decompiled with JetBrains decompiler
// Type: Gacha.BGTextureResource
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace Gacha
{
  [Token(Token = "0x2001514")]
  internal class BGTextureResource : IGachaBGResource
  {
    [Token(Token = "0x40060F5")]
    public const float DefaultSwitchingTime = 3f;

    [Token(Token = "0x17001264")]
    public Texture2D Texture
    {
      [Token(Token = "0x600775A"), Address(RVA = "0x44F1944", Offset = "0x44F1944", VA = "0x44F1944")] get
      {
        return (Texture2D) null;
      }
      [Token(Token = "0x600775B"), Address(RVA = "0x44F194C", Offset = "0x44F194C", VA = "0x44F194C")] private set
      {
      }
    }

    [Token(Token = "0x17001265")]
    public float SwitchingTime
    {
      [Token(Token = "0x600775C"), Address(RVA = "0x44F1954", Offset = "0x44F1954", VA = "0x44F1954")] get
      {
        return new float();
      }
      [Token(Token = "0x600775D"), Address(RVA = "0x44F195C", Offset = "0x44F195C", VA = "0x44F195C")] private set
      {
      }
    }

    [Token(Token = "0x600775E")]
    [Address(RVA = "0x44F1964", Offset = "0x44F1964", VA = "0x44F1964")]
    public BGTextureResource(Texture2D texture)
    {
    }
  }
}
