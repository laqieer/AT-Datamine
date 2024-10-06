-- このluaスクリプトは、MA_01108_05.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPosDuelCommonFormation01_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_007)
	Camera002 = SetTemplate("Actor002",nil,CharaPosDuelCommonFormation01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_004)
	Camera003 = SetTemplate("Actor003",nil,CharaPosDuelCommonFormation01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_004_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_005)
	Camera004 = SetTemplate("Actor004",nil,CharaPosDuelCommonFormation01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_505_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_006)
	Camera005 = SetTemplate("Actor005",nil,CharaPosDuelCommonFormation01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_519_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_002)
	Camera006 = SetTemplate("Actor006",nil,CharaPosDuelCommonFormation01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_508_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_001)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101000011)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101014","001","101014001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101019","001","101019001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101028","002","101028002","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101029","001","101029001","content_animationpack__common","FacialPack","Actor006")
	template1()
	load_head_animation(Actor006,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")

end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:ガラハッドは<br>いつからコルベニック城に？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01108_050002")


	--★★ガラハッド★★:７年ほど前からだ
	Talk(Actor005,"CHRNAME_GALAHAD","speech","L","MA_01108_050003")

	PlayAction(Actor005,"to  Std_Sad01")

	--★★ガラハッド★★:母上と旅をしていたとき<br>コルベニック城の近くの森で魔物に襲われて…
	Talk(Actor005,"CHRNAME_GALAHAD","speech","L","MA_01108_050004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★アステラ★★:１人で泣いていたところを<br>私が助けたの
	Talk(Actor006,"CHRNAME_ASTERA","speech","L","MA_01108_050006")


	--★★アステラ★★:「友達がいなくなっちゃった」って<br>いつも寂しそうにしていたフィエナが…
	Talk(Actor006,"CHRNAME_ASTERA","speech","L","MA_01108_050007")

	play_head_motion(Actor006, "Nod", 0.3, 1.0, false)
	change_face(Actor006,"Smile")

	--★★アステラ★★:ガラハッドが来てからは<br>楽しそうに笑うようになったわ
	Talk(Actor006,"CHRNAME_ASTERA","speech","L","MA_01108_050008")


	--★★トリスタン★★:フィエナって？
	Talk(Actor003,"CHRNAME_TRISTAN","speech","L","MA_01108_050009")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ランスロット★★:コルベニック城の姫だ<br>幼き頃…俺たちも良くしてもらった
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01108_050010")

	change_face(Actor005,"Sad")

	--★★ガラハッド★★:…姉上はガラハッドに優しくしてくれる<br>本当の妹のように優しくしてくれる
	Talk(Actor005,"CHRNAME_GALAHAD","speech","L","MA_01108_050011")


	--★★ガラハッド★★:僕はお前たちの代わりになったつもりはないんだ<br>ガラハッドは姉上に寂しい想いはさせない
	Talk(Actor005,"CHRNAME_GALAHAD","speech","L","MA_01108_050012")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★トリスタン★★:（彼女…<br>自分の呼び方が安定していない）
	Talk(Actor003,"CHRNAME_TRISTAN","mind","L","MA_01108_050014")

	change_face(Actor005,"Normal")

	--★★ガラハッド★★:ノワールもランスロットも<br>姉上に少し顔を見せるだけでいい
	Talk(Actor005,"CHRNAME_GALAHAD","speech","L","MA_01108_050015")


	--★★トリスタン★★:（不安定なのか<br>単に不安なのか…？）
	Talk(Actor003,"CHRNAME_TRISTAN","mind","L","MA_01108_050016")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)

	--★★ガラハッド★★:あとは僕が<br>姉上のそばにいるから
	Talk(Actor005,"CHRNAME_GALAHAD","speech","L","MA_01108_050017")

	EndPlay()
end




function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_duel_scene_preload(101000011)
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101014","001","101014001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101019","001","101019001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101028","002","101028002","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101029","001","101029001","content_animationpack__common","FacialPack","Actor006")
	load_head_animation_preload(Actor006,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
