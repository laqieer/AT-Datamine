-- このluaスクリプトは、MA_01B112_34.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPosDuelCommonFormation01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_512_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_006)
	Camera002 = SetTemplate("Actor002",nil,CharaPosDuelCommonFormation01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_511_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_001)
	Camera003 = SetTemplate("Actor003",nil,CharaPosDuelCommonFormation01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_510_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_003)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101120011)
	Actor001 = InitializeCharacter_3D("101020","001","101020001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101035","002","101035002","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101034","002","101034002","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Sad")

	--★★マーリン★★:GSを果たしたキラーズは<br>バルバロイの因子への抵抗力を持つ
	Talk(Actor001,"CHRNAME_MERLIN","speech","L","MA_01B112_340002")


	--★★マーリン★★:貴方たちは自らのマスターが<br>侵されていく姿を見続けるしかなかった
	Talk(Actor001,"CHRNAME_MERLIN","speech","L","MA_01B112_340004")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★リリアーナ★★:その義務があります
	Talk(Actor002,"CHRNAME_LILIANA2","speech","R","MA_01B112_340006")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)

	--★★エクセリア★★:彼らの意志を見届ける責任が
	Talk(Actor003,"CHRNAME_EXCELIA2","speech","R","MA_01B112_340007")


	--★★マーリン★★:…ここからは推測になりますが
	Talk(Actor001,"CHRNAME_MERLIN","speech","L","MA_01B112_340008")

	PlayAction(Actor001,"to  Std_Talk")

	--★★マーリン★★:きっと銀卓騎士たちは己を失う前に<br>貴方たちを逃がそうとしたのでは？
	Talk(Actor001,"CHRNAME_MERLIN","speech","L","MA_01B112_340009")


	--★★マーリン★★:生かしたかった<br>でも貴方たちは付き添った
	Talk(Actor001,"CHRNAME_MERLIN","speech","L","MA_01B112_340011")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★マーリン★★:そのうえで学園内で暗躍しようとした<br>例えば、アーサー王の暗殺を画策…とか
	Talk(Actor001,"CHRNAME_MERLIN","speech","L","MA_01B112_340012")

	PlayAction(Actor003,"to  Std_No")

	--★★エクセリア★★:なぜそこまでわかっていて<br>私たちを学園で自由にさせたの
	Talk(Actor003,"CHRNAME_EXCELIA2","speech","R","MA_01B112_340013")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★マーリン★★:…アーサー王が望んだからです
	Talk(Actor001,"CHRNAME_MERLIN","speech","L","MA_01B112_340014")

	PlayAction(Actor002,"to  Std_Surp")
	change_face(Actor002,"Surprise")

	--★★リリアーナ★★:…！？<br>殺されることを、ですか…？
	Talk(Actor002,"CHRNAME_LILIANA2","speech","R","MA_01B112_340015")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Anger")

	--★★マーリン★★:いいえ<br>あの人は学園の長として貴方たちにも──
	Talk(Actor001,"CHRNAME_MERLIN","speech","L","MA_01B112_340016")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★マーリン★★:学び<br>生きて欲しかった
	Talk(Actor001,"CHRNAME_MERLIN","speech","L","MA_01B112_340017")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)

	--★★エクセリア★★:…<br>それが国王としての最適解なの…？
	Talk(Actor003,"CHRNAME_EXCELIA2","speech","R","MA_01B112_340018")

	change_face(Actor001,"Normal")

	--★★マーリン★★:GSを果たし<br>誰かと絆を結べた者たち
	Talk(Actor001,"CHRNAME_MERLIN","speech","L","MA_01B112_340019")

	PlayAction(Actor001,"to  Std_Talk")

	--★★マーリン★★:…銀卓も円卓も関係なく貴方たちと<br>仲良く卓を囲めたら、だそうですよ？
	Talk(Actor001,"CHRNAME_MERLIN","speech","L","MA_01B112_340020")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_duel_scene_preload(101120011)
	InitializeCharacter_3D_Preload("101020","001","101020001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101035","002","101035002","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101034","002","101034002","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
