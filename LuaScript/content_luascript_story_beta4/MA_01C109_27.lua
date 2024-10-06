-- このluaスクリプトは、MA_01C109_27.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110011_04","110011_04_h")
Include("content_adv_advsmall_110011_04","Template110011_04_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110011_04_001,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110011_04,CameraPos110011_04_001)
	Camera002 = SetTemplate("Actor002",-70,CharaPos110011_04_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_506_01_StdController","to Std_Loop",CameraAssetBundleName110011_04,CameraPos110011_04_005)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110011_04_008,"content_motion3d_advarea_common_adv_templatecontroller","Npc_001_01_StdController","to Std_Loop",CameraAssetBundleName110011_04,CameraPos110011_04_008)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110011_04_003,"content_motion3d_advarea_common_adv_templatecontroller","Npc_501_01_StdController","to Std_Loop",CameraAssetBundleName110011_04,CameraPos110011_04_003)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110011_04_007,"content_motion3d_advarea_common_adv_templatecontroller","Npc_001_01_StdController","to Std_Loop",CameraAssetBundleName110011_04,CameraPos110011_04_007)
	InitializeTemplateRandomCamera110011_04()
	InitializeTemplate110011_04()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110011)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101023","001","101023001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("401005","001","401005001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("401006","001","401006001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("401007","001","401007001","content_animationpack__common","FacialPack","Actor005")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to Greet_one")
-- ▼直接出力
 --PlayPartVoice("クラリス","喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★クラリス★★:どうも～<br>突撃！隣のシスターですけど～
	Talk(Actor002,"CHRNAME_CLARICE","speech","L","MA_01C109_270002")

	PlayAction(Actor005,"to Greet_one")
-- ▼直接出力
 --PlayPartVoice("男子2","肯定3")
-- ▲直接出力
	change_face(Actor005,"Smile")

	--★★キャメロット騎士学術院（男）②★★:シスター！
	Talk(Actor005,"NPCNAME_0151","speech","N","MA_01C109_270004")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("クラリス","肯定2")
-- ▲直接出力

	--★★クラリス★★:悔い改めよ～
	Talk(Actor002,"CHRNAME_CLARICE","speech","L","MA_01C109_270006")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor003,"to Greet_one")
-- ▼直接出力
 --PlayPartVoice("男子1","笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★キャメロット騎士学術院（男）★★:シスター！
	Talk(Actor003,"NPCNAME_0153","speech","N","MA_01C109_270007")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("クラリス","笑い")
-- ▲直接出力

	--★★クラリス★★:御心のままに～
	Talk(Actor002,"CHRNAME_CLARICE","speech","L","MA_01C109_270009")

-- ▼直接出力
set_enable_auto_lookat(Actor002, false)
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:クラリス？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C109_270010")

	PlayAction(Actor002,"to Greet_one")
-- ▼直接出力
 --PlayPartVoice("クラリス","喜び")
-- ▲直接出力
	open_cutin(1,1)
	on_cutin(1,Actor002,"Smile")

	--★★クラリス★★:突撃！隣のシスターです～
	Talk(Actor002,"CHRNAME_CLARICE","speech","N","MA_01C109_270011")

	close_cutin()
-- ▼直接出力
 --PlayPartVoice("ノワール","驚き")
-- ▲直接出力

	--★★ノワール★★:なんだなんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C109_270012")

	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
 --PlayPartVoice("クラリス","悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★クラリス★★:どれがノワールくんですか～？<br>教室全員ノワールくんに見えてきました～
	Talk(Actor002,"CHRNAME_CLARICE","speech","L","MA_01C109_270014")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール","悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:ど、どうしたんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C109_270016")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor002,"to Wlk")
turn_chara(Actor002,20,1)
wait_time(1.0)
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("クラリス","肯定3")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★クラリス★★:ああ、こちらにいらしたんですね～
	Talk(Actor002,"CHRNAME_CLARICE","speech","L","MA_01C109_270017")

-- ▼直接出力
 --PlayPartVoice("ノワール","肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:なにか用事か？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C109_270018")

-- ▼直接出力
 --PlayPartVoice("クラリス","笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★クラリス★★:お耳を拝借～
	Talk(Actor002,"CHRNAME_CLARICE","speech","L","MA_01C109_270019")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to Bow")
	change_face(Actor002,"Normal")

	--★★クラリス★★:王がお呼びです
	Talk(Actor002,"CHRNAME_CLARICE","speech","L","MA_01C109_270021")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110011)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101023","001","101023001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("401005","001","401005001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("401006","001","401006001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("401007","001","401007001","content_animationpack__common","FacialPack","Actor005")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110011_04)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
