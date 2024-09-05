// Decompiled with JetBrains decompiler
// Type: Battle.UI.IEquipmentModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Scenes.OutGame.Info.Common;
using Scenes.OutGame.Info.Equipment;
using Scenes.OutGame.Info.Skill;

#nullable disable
namespace Battle.UI
{
  [Token(Token = "0x200238F")]
  public interface IEquipmentModel
  {
    [Token(Token = "0x17002EAD")]
    SkillModelListBase SkillModelList { [Token(Token = "0x600D91B")] get; }

    [Token(Token = "0x17002EAE")]
    ParameterModelBase Parameter { [Token(Token = "0x600D91C")] get; }

    [Token(Token = "0x17002EAF")]
    AdditionalParameterModelBase AdditionalParameter { [Token(Token = "0x600D91D")] get; }

    [Token(Token = "0x17002EB0")]
    EquipmentCommonModelBase Common { [Token(Token = "0x600D91E")] get; }

    [Token(Token = "0x17002EB1")]
    int Id { [Token(Token = "0x600D91F")] get; }

    [Token(Token = "0x17002EB2")]
    bool IsEmpty { [Token(Token = "0x600D920")] get; }

    [Token(Token = "0x17002EB3")]
    int[] ReinforceAttack { [Token(Token = "0x600D921")] get; }

    [Token(Token = "0x17002EB4")]
    int[] ReinforceElement { [Token(Token = "0x600D922")] get; }

    [Token(Token = "0x17002EB5")]
    int[] ReinforceBadStatus { [Token(Token = "0x600D923")] get; }

    [Token(Token = "0x17002EB6")]
    int[] ResistAttack { [Token(Token = "0x600D924")] get; }

    [Token(Token = "0x17002EB7")]
    int[] ResistElement { [Token(Token = "0x600D925")] get; }

    [Token(Token = "0x17002EB8")]
    int[] ResistBadStatus { [Token(Token = "0x600D926")] get; }

    [Token(Token = "0x17002EB9")]
    int[] SlayMove { [Token(Token = "0x600D927")] get; }

    [Token(Token = "0x17002EBA")]
    int[] SlayArmor { [Token(Token = "0x600D928")] get; }

    [Token(Token = "0x17002EBB")]
    int[] SlayRide { [Token(Token = "0x600D929")] get; }

    [Token(Token = "0x17002EBC")]
    int[] SlaySpecies { [Token(Token = "0x600D92A")] get; }

    [Token(Token = "0x17002EBD")]
    int[] ResistSlayMove { [Token(Token = "0x600D92B")] get; }

    [Token(Token = "0x17002EBE")]
    int[] ResistSlayArmor { [Token(Token = "0x600D92C")] get; }

    [Token(Token = "0x17002EBF")]
    int[] ResistSlayRide { [Token(Token = "0x600D92D")] get; }

    [Token(Token = "0x17002EC0")]
    int[] ResistSlaySpecies { [Token(Token = "0x600D92E")] get; }

    [Token(Token = "0x17002EC1")]
    bool ExistReinforce { [Token(Token = "0x600D92F")] get; }

    [Token(Token = "0x17002EC2")]
    bool ExistResist { [Token(Token = "0x600D930")] get; }

    [Token(Token = "0x17002EC3")]
    bool ExistSlay { [Token(Token = "0x600D931")] get; }

    [Token(Token = "0x17002EC4")]
    bool ExistResistSlay { [Token(Token = "0x600D932")] get; }
  }
}
