-- このluaスクリプトは、MA_01C112_901.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110071_01","110071_01_h")
Include("content_adv_advsmall_110071_01","Template110071_01_h")
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110071_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110071_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_006_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_007)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110071_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_020_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_002)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110071_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_506_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_006)
	InitializeTemplateRandomCamera110071_01()
	InitializeTemplate110071_01()
-- ▼直接出力
Hide(Actor002)
Hide(Actor004)
set_enable_auto_lookat_all(false)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110071)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101022","001","101022001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101051","001","101051001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101023","001","101023001","content_animationpack__common","FacialPack","Actor004")
	template1()
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
CloseTalkWindow()
lookat_delay_weight(Actor001, 1.0, 0, 0.3, 0.2,1.0)
PlayActionDirect(Actor001,"to Wlk")
turn_lookat(Actor001,Actor002, 0.5)
wait_time(0.5)
PlayActionDirect(Actor001,"to Std_Loop")
keep_ik_lookat(Actor001,Actor002,"J_Head")
lookat_delay_weight(Actor003, 1.0, 0, 0.3, 0.2,1.0)
keep_ik_lookat(Actor003,Actor002,"J_Head")
EntryWalk_2P(Actor002,Camera002,EntryData110071_01_07,CameraAssetBundleName110071_01,CameraPos110071_01_107,Actor004,CharaPos110071_01_006,CharaPos110071_01_106)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("モルドレッド", "挨拶")
-- ▲直接出力

	--★★モルドレッド★★:オイ、騎士筆頭、出掛けるぜ<br>断ることは許さねえ。これは王命だ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","MA_01C112_9010002")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:出掛けるって…どこへ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C112_9010003")


	--★★モルドレッド★★:てめえが言い出したんだろうが<br>ロンディニウムだ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","MA_01C112_9010004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ルーシャス", "肯定2")
-- ▲直接出力

	--★★ルーシャス★★:国王陛下は<br>聖杯探索を優先されていたのではなかったかな？
	Talk(Actor003,"CHRNAME_LUCIUS","speech","L","MA_01C112_9010005")

	PlayAction(Actor002,"to  Std_Angry")
-- ▼直接出力
 --PlayPartVoice("モルドレッド", "落胆")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★モルドレッド★★:あァ！？
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","MA_01C112_9010006")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ルーシャス", "笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ルーシャス★★:感心感心<br>自らの過ちを認めるのは賢王への第一歩だろう
	Talk(Actor003,"CHRNAME_LUCIUS","speech","L","MA_01C112_9010007")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("クラリス", "肯定")
-- ▲直接出力

	--★★クラリス★★:わたしもそう思います<br>最近のモルくんは頑張っていますよね～
	Talk(Actor004,"CHRNAME_CLARICE","speech","L","MA_01C112_9010008")

-- ▼直接出力
lookat_delay_weight(Actor002, 1.2, 0, 0.5,0.2,1.0)
keep_ik_lookat(Actor002,Actor004,"J_Head")
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("モルドレッド", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★モルドレッド★★:てめえは誰の味方なんだ！？
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","MA_01C112_9010009")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ルーシャス", "挨拶")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ルーシャス★★:なにはともあれ<br>ロンディニウムに行くなら余も同行しよう
	Talk(Actor003,"CHRNAME_LUCIUS","speech","L","MA_01C112_9010010")


	--★★ルーシャス★★:ローマ皇太子として<br>ロンディニウムの状況をこの目で見ておきたい
	Talk(Actor003,"CHRNAME_LUCIUS","speech","L","MA_01C112_9010011")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:わかった<br>ディナタンにも声をかけてくる
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C112_9010012")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110071)
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101022","001","101022001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101051","001","101051001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101023","001","101023001","content_animationpack__common","FacialPack","Actor004")
MobsNo = 0
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110071_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
