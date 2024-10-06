-- このluaスクリプトは、MA_01C109_906.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110111_03","110111_03_h")
Include("content_adv_advsmall_110111_03","Template110111_03_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110111_03_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110111_03,CameraPos110111_03_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110111_03_002,"content_motion3d_advarea_common_adv_templatecontroller","Npc_508_01_StdController","to Std_Loop",CameraAssetBundleName110111_03,CameraPos110111_03_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110111_03_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_506_01_StdController","to Std_Loop",CameraAssetBundleName110111_03,CameraPos110111_03_003)
	InitializeTemplateRandomCamera110111_03()
	InitializeTemplate110111_03()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115114)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101065","001","101065001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101023","001","101023001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("キッス","笑い")
-- ▲直接出力

	--★★キッス★★:みんなお疲れ様♪<br>孤児院に被害が出ずに済んで良かったわ
	Talk(Actor002,"CHRNAME_KISS","speech","L","MA_01C109_9060002")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("クラリス","否定")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★クラリス★★:ノワールくんやアーサー様のおかげです～
	Talk(Actor003,"CHRNAME_CLARICE","speech","L","MA_01C109_9060003")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール","笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:モルドレッドのヤツも<br>文句を言いながらだったけど頑張ってくれたな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C109_9060004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("クラリス","落胆")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★クラリス★★:モルくん<br>ずっとアーサー様のことを睨んでました
	Talk(Actor003,"CHRNAME_CLARICE","speech","L","MA_01C109_9060005")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
 --PlayPartVoice("ノワール","肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:モルドレッドは<br>アーサーのことをあまり好きじゃないんだっけ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C109_9060006")

	PlayAction(Actor003,"to  Std_Worry")
-- ▼直接出力
 --PlayPartVoice("クラリス","悩む")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★クラリス★★:それもありますけど
	Talk(Actor003,"CHRNAME_CLARICE","speech","L","MA_01C109_9060007")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.44)
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor001, false)
lookat_delay_weight(Actor001, {1.0, 0.08, 0.5, 0.6} ,1.0)
keep_ik_lookat(Actor001,Actor003,"J_Head")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★クラリス★★:アーサー様の一挙手一投足を見逃さない<br>そんな感じで、なんかいつもより怖かったです
	Talk(Actor003,"CHRNAME_CLARICE","speech","L","MA_01C109_9060008")

	change_face(Actor001,"Sad")

	--★★ノワール★★:…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C109_9060009")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
	change_face(Actor003,"Anger")

	--★★クラリス★★:でもでも<br>誰かをずっと睨んでるなんて良くないですよね
	Talk(Actor003,"CHRNAME_CLARICE","speech","L","MA_01C109_9060010")

-- ▼直接出力
 --PlayPartVoice("クラリス","激怒")
-- ▲直接出力

	--★★クラリス★★:モルくんにはあとでわたしから<br>メッ！ってしておきます
	Talk(Actor003,"CHRNAME_CLARICE","speech","L","MA_01C109_9060011")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor003,"to Bow")
	change_face(Actor003,"Normal")

	--★★クラリス★★:それじゃ、ノワールくんにキッスさん<br>今日はどうもありがとうございました
	Talk(Actor003,"CHRNAME_CLARICE","speech","L","MA_01C109_9060012")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
lookat_delay_weight_reset(Actor001 , 0.6)
 --PlayPartVoice("キッス","笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★キッス★★:またなにかあったら連絡して<br>すぐにラビットちゃんに繋いであげるから♪
	Talk(Actor002,"CHRNAME_KISS","speech","L","MA_01C109_9060013")

-- ▼直接出力
 --PlayPartVoice("ノワール","落胆")
-- ▲直接出力

	--★★ノワール★★:またそうやって安請け合いをして…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C109_9060014")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:まあ、いいけどさ<br>困ったときはいつでも相談してくれ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C109_9060015")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(115114)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101065","001","101065001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101023","001","101023001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110111_03)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
