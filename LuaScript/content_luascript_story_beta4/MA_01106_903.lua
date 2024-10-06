-- このluaスクリプトは、MA_01106_903.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110031_01","110031_01_h")
Include("content_adv_advsmall_110031_01","Template110031_01_h")
-- ▼直接出力
MobsNo = 1
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",87,CharaPos110031_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110031_01,CameraPos110031_01_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110031_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_004_01_StdController","to Std_Loop",CameraAssetBundleName110031_01,CameraPos110031_01_004)
	InitializeTemplateRandomCamera110031_01()
	InitializeTemplate110031_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110031)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101014","001","101014001","content_animationpack__common","FacialPack","Actor002")
	template1()
-- ▼直接出力
MobsNo = 1
-- ▲直接出力
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()


	--★★トリスタン★★:もういいの？<br>妹さん、泣いてたけど
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","MA_01106_9030002")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ノワール★★:落ち着かせてきた<br>あいつならもう大丈夫だと思う
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01106_9030003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Worry")

	--★★トリスタン★★:そう。別にどうでもいいけどね<br>ボクには関係ないし
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","MA_01106_9030004")

	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:関係ないヤツが<br>なんで療養所にいるんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01106_9030005")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★トリスタン★★:兄妹喧嘩を見物に
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","MA_01106_9030006")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★トリスタン★★:…なんてね
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","MA_01106_9030007")


	--★★トリスタン★★:ケイが呼んでるよ<br>急いで来いってさ
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","MA_01106_9030008")

	PlayAction(Actor001,"to  Std_Surp")
	change_face(Actor001,"Surprise")

	--★★ノワール★★:ケイが？<br>どこに？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01106_9030009")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★トリスタン★★:円卓の間<br>円卓会議が始まるよ
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","MA_01106_9030010")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110031)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101014","001","101014001","content_animationpack__common","FacialPack","Actor002")
MobsNo = 1
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110031_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
