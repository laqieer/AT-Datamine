-- このluaスクリプトは、MA_01A112_27.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPosDuelCommonFormation01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_525_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPosDuelCommonFormation01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_019_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_005)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
-- ▼直接出力
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
-- ▲直接出力
-- ▼直接出力
keep_ik_lookat(Actor001,Actor002,"J_Head")
keep_ik_lookat(Actor002,Actor001,"J_Head")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101060011)
	Actor001 = InitializeCharacter_3D("101037","002","101037002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101052","001","101052001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_No")
	change_face(Actor001,"Anger")

	--★★ラシア★★:キズさえ癒えれば負けない──…！
	Talk(Actor001,"CHRNAME_RASIA2","speech","L","MA_01A112_270002")


	--★★ラシア★★:叔父様は負けてなんかない…！<br>スノードンでのキズが癒えてないだけ
	Talk(Actor001,"CHRNAME_RASIA2","speech","L","MA_01A112_270003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)

	--★★ヴェルナルス大将軍★★:もういいラシア
	Talk(Actor002,"CHRNAME_VERNARTH","speech","L","MA_01A112_270004")


	--★★ヴェルナルス大将軍★★:…弟子に、手心を加えられたか<br>急所は外れている…
	Talk(Actor002,"CHRNAME_VERNARTH","speech","L","MA_01A112_270006")

	PlayAction(Actor002,"to  Std_Sad01")
	change_face(Actor002,"Smile")

	--★★ヴェルナルス大将軍★★:つくづく、甘い
	Talk(Actor002,"CHRNAME_VERNARTH","speech","L","MA_01A112_270008")

	change_face(Actor001,"Sad")

	--★★ラシア★★:…叔父様譲りです
	Talk(Actor001,"CHRNAME_RASIA2","speech","L","MA_01A112_270009")

	PlayAction(Actor002,"to  Std_Sad02")
	change_face(Actor002,"Normal")

	--★★ヴェルナルス大将軍★★:武器はもう…握れそうにない、が…
	Talk(Actor002,"CHRNAME_VERNARTH","speech","L","MA_01A112_270010")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ラシア★★:帰りましょう、叔父様<br>カレドニアに戻れば──
	Talk(Actor001,"CHRNAME_RASIA2","speech","L","MA_01A112_270011")


	--★★ヴェルナルス大将軍★★:キズを負い、戦えぬ者を、傍に…置くほど<br>ルーシャス様は寛大なお方ではないよ
	Talk(Actor002,"CHRNAME_VERNARTH","speech","L","MA_01A112_270012")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ヴェルナルス大将軍★★:ここにいたところで<br>いつか魔女がかぎつけるだろうが…
	Talk(Actor002,"CHRNAME_VERNARTH","speech","L","MA_01A112_270013")

	PlayAction(Actor001,"to  Std_Surp")
	change_face(Actor001,"Sad")

	--★★ラシア★★:だとすれば、だとすれば私たち…！<br>どこへ行けばいいんです…っ、叔父様！
	Talk(Actor001,"CHRNAME_RASIA2","speech","L","MA_01A112_270014")

	PlayAction(Actor002,"to  Std_Sad02")
	change_face(Actor002,"Sad")

	--★★ヴェルナルス大将軍★★:お前の決断を、呪縛にしてしまったな
	Talk(Actor002,"CHRNAME_VERNARTH","speech","L","MA_01A112_270015")

	PlayAction(Actor001,"to  Std_No")

	--★★ラシア★★:いいえ、いいえ…！！
	Talk(Actor001,"CHRNAME_RASIA2","speech","L","MA_01A112_270016")


	--★★ヴェルナルス大将軍★★:私俺のわがままに、付き合わせて、しまった…<br>自らの選択で…好きに生きて欲しかった、ラシア
	Talk(Actor002,"CHRNAME_VERNARTH","speech","L","MA_01A112_270017")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Angry")

	--★★ラシア★★:わがままなんかじゃありません<br>私は、私の選択で…！
	Talk(Actor001,"CHRNAME_RASIA2","speech","L","MA_01A112_270018")


	--★★ヴェルナルス大将軍★★:今より、私俺の命が尽きるまでは、せめて………
	Talk(Actor002,"CHRNAME_VERNARTH","speech","L","MA_01A112_270019")

-- ▼直接出力
CloseTalkWindow()
show_image("101010140", 0.0, 0.0, BLACK_WHITE_TIME,false,false)
set_scale_image(20,20)
wait_time(BLACK_WHITE_TIME + BLACK_WHITE_WAIT_TIME)
se_play("SE_ADV_MA_01A112_27_Hug")
-- ▲直接出力

	--★★ラシア★★:叔父様の、命が、尽きるまで…<br>私の、力が…この手にあるまで…！
	Talk(Actor001,"CHRNAME_RASIA2","simple","N","MA_01A112_270021")

	change_face(Actor001,"Anger")

	--★★ラシア★★:…なにも報われずとも、私は
	Talk(Actor001,"CHRNAME_RASIA2","simple","N","MA_01A112_270023")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
	InitializeLoad_Preload()
	load_duel_scene_preload(101060011)
	InitializeCharacter_3D_Preload("101037","002","101037002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101052","001","101052001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
