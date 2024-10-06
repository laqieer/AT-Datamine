Include("content_luascript_common","ADVSmallPack")

function Load()
  InitializeLoadActive()
  Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
  Actor002 = InitializeActiveCharacter("Lancelot","101010001","101010001","content_animationpack_101_101lanc","MotionPack_101Lanc","Lancelot_EntakuSit_loop")

	load_sound("BGM_ADV_Lancelot_Theme")
end

function Play()
  StartPlayActive()

	bgm_play("BGM_ADV_Lancelot_Theme")

  Talk(Actor002,"CHRNAME_LANCELOT","speech","L","SQ_BT101010_010001")
  Talk(Actor002,"CHRNAME_LANCELOT","speech","L","SQ_BT101010_010002")
  Talk(Actor002,"CHRNAME_LANCELOT","speech","L","SQ_BT101010_010003")

  CloseTalkWindow()

  EndPlayActive()
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
  InitializeActiveCharacter_Preload("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
  InitializeActiveCharacter_Preload("Lancelot","101010001","101010001","content_animationpack_101_101lanc","MotionPack_101Lanc","Lancelot_EntakuSit_loop")
	preload_sound("BGM_ADV_Lancelot_Theme")
end
