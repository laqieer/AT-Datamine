// Decompiled with JetBrains decompiler
// Type: GachaAwardData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
[Token(Token = "0x2000203")]
[Serializable]
public class GachaAwardData
{
  [Token(Token = "0x4000BD8")]
  [FieldOffset(Offset = "0x10")]
  public GachaAwardData.AwardType awardType;
  [Token(Token = "0x4000BD9")]
  [FieldOffset(Offset = "0x14")]
  public GachaAwardData.RarityType rarityType;
  [Token(Token = "0x4000BDA")]
  [FieldOffset(Offset = "0x18")]
  public string name;
  [Token(Token = "0x4000BDB")]
  [FieldOffset(Offset = "0x20")]
  public Texture ThumbnailTexture;
  [Token(Token = "0x4000BDC")]
  [FieldOffset(Offset = "0x28")]
  public Texture emblemTexture;
  [Token(Token = "0x4000BDD")]
  [FieldOffset(Offset = "0x30")]
  public string selfIntroduction;
  [Token(Token = "0x4000BDE")]
  [FieldOffset(Offset = "0x38")]
  public bool isNew;
  [Token(Token = "0x4000BDF")]
  [FieldOffset(Offset = "0x3C")]
  public int quantity;
  [Token(Token = "0x4000BE0")]
  [FieldOffset(Offset = "0x40")]
  public Texture characterTexture;
  [Token(Token = "0x4000BE1")]
  [FieldOffset(Offset = "0x48")]
  public string characterName;
  [Token(Token = "0x4000BE2")]
  [FieldOffset(Offset = "0x50")]
  public string characterNameEn;
  [Token(Token = "0x4000BE3")]
  [FieldOffset(Offset = "0x58")]
  public int styleId;
  [Token(Token = "0x4000BE4")]
  [FieldOffset(Offset = "0x5C")]
  public ElementTypeEnum styleElement;
  [Token(Token = "0x4000BE5")]
  [FieldOffset(Offset = "0x60")]
  public string gachaSingleSkillVideoUrl;
  [Token(Token = "0x4000BE6")]
  [FieldOffset(Offset = "0x68")]
  public IllustLayoutInfo styleLayout;
  [Token(Token = "0x4000BE7")]
  [FieldOffset(Offset = "0x70")]
  public IllustLayoutInfo newCharacterLayout;
  [Token(Token = "0x4000BE8")]
  [FieldOffset(Offset = "0x78")]
  public IllustLayoutInfo faceLayout;
  [Token(Token = "0x4000BE9")]
  [FieldOffset(Offset = "0x80")]
  public IllustLayoutInfo mnemnographLayout;
  [Token(Token = "0x4000BEA")]
  [FieldOffset(Offset = "0x88")]
  public GameObject facePrefab;
  [Token(Token = "0x4000BEB")]
  [FieldOffset(Offset = "0x90")]
  public GameObject dotPrefab;

  [Token(Token = "0x6000CC2")]
  [Address(RVA = "0x4C7C800", Offset = "0x4C7C800", VA = "0x4C7C800")]
  public GachaAwardData()
  {
  }

  [Token(Token = "0x2000204")]
  public enum AwardType
  {
    [Token(Token = "0x4000BED")] Style,
    [Token(Token = "0x4000BEE")] Mnemnograph,
    [Token(Token = "0x4000BEF")] Item,
  }

  [Token(Token = "0x2000205")]
  public enum RarityType
  {
    [Token(Token = "0x4000BF1")] N = 1,
    [Token(Token = "0x4000BF2")] R = 2,
    [Token(Token = "0x4000BF3")] SR = 3,
    [Token(Token = "0x4000BF4")] SSR = 4,
    [Token(Token = "0x4000BF5")] UR = 5,
  }
}
