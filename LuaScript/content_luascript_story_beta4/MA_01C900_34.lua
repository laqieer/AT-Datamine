-- このluaスクリプトは、MA_01C900_34.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_114021_01","114021_01_h")
Include("content_adv_advsmall_114021_01","Template114021_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos114021_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName114021_01,CameraPos114021_01_006)
	Camera002 = SetTemplate("Actor002",nil,CharaPos114021_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_004_01_StdController","to Std_Loop",CameraAssetBundleName114021_01,CameraPos114021_01_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPos114021_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_505_01_StdController","to Std_Loop",CameraAssetBundleName114021_01,CameraPos114021_01_003)
	InitializeTemplateRandomCamera114021_01()
	InitializeTemplate114021_01()
-- ▼直接出力
set_enable_auto_lookat(Actor002,false)
set_common_look_at(Actor002,Actor001)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor003,false)
set_common_look_at(Actor003,Actor001)
-- ▲直接出力
-- ▼直接出力
disp_calendar(false)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(114021)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101014","001","101014001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101019","001","101019001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()


	--★★トリスタン★★:こっちはほとんど被害はないよ<br>あの光は学園だけを焼いたみたいだ
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","MA_01C900_340002")

	PlayAction(Actor002,"to  Std_Sad02")
	change_face(Actor002,"Pain")

	--★★トリスタン★★:アーサーは<ruby=ゲシュタルト・シフト>ＧＳ</ruby>を憎んでいた。だけど<br>世界すべては憎みきれなかったのかもしれない
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","MA_01C900_340003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★トリスタン★★:…落ち着いたら、ボクたちも学園に戻るよ<br>復興の手伝い、しなくちゃね
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","MA_01C900_340005")

	change_face(Actor002,"Sad")

	--★★トリスタン★★:…ディナタンはどこかって？<br>キミが知らないのに、ボクが知ってると思う？
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","MA_01C900_340006")


	--★★イゾルデ★★:ケイやマーリンが避難を進めていたおかげで<br>被害は最小限に抑えられたけれど
	Talk(Actor003,"CHRNAME_ISOLDE","speech","L","MA_01C900_340008")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
	change_face(Actor003,"Sad")

	--★★イゾルデ★★:それでもやはりアーサーが遺した爪痕は深いわ<br>これからが大変よ、ノワール
	Talk(Actor003,"CHRNAME_ISOLDE","speech","L","MA_01C900_340009")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
	change_face(Actor003,"Normal")

	--★★イゾルデ★★:私は療養院に戻って患者を診るわ<br>お前も精々頑張るのね
	Talk(Actor003,"CHRNAME_ISOLDE","speech","L","MA_01C900_340010")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(114021)
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101014","001","101014001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101019","001","101019001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName114021_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
