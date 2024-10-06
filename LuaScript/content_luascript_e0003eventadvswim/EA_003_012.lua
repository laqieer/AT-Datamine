-- このluaスクリプトは、EA_003_012.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110011_04","110011_04_h")
Include("content_adv_advsmall_110011_04","Template110011_04_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110011_04_001,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110011_04,CameraPos110011_04_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110011_04_005,"content_motion3d_advarea_common_adv_templatecontroller","Npc_001_01_StdController","to Std_Loop",CameraAssetBundleName110011_04,CameraPos110011_04_005)
	Camera003 = SetTemplate("Actor003",52,CharaPos110011_04_003,"content_motion3d_advarea_common_adv_templatecontroller","Npc_501_01_StdController","to Std_Loop",CameraAssetBundleName110011_04,CameraPos110011_04_003)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110011_04_006,"content_motion3d_advarea_common_adv_templatecontroller","Npc_001_01_StdController","to Std_Loop",CameraAssetBundleName110011_04,CameraPos110011_04_006)
	Camera005 = SetTemplate("Actor005",57.52614,CharaPos110011_04_007,"content_motion3d_advarea_common_adv_templatecontroller","Npc_501_01_StdController","to Std_Loop",CameraAssetBundleName110011_04,CameraPos110011_04_007)
	InitializeTemplateRandomCamera110011_04()
	InitializeTemplate110011_04()
-- ▼直接出力
DontChangeRandomCamera(true)
Hide(Actor005)
-- ▲直接出力
-- ▼直接出力
set_pos(Actor005,{-3.357,0,-3.901})
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110011)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("401005","001","401005001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("401006","001","401006001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("401007","001","401007001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("401008","001","401008001","content_animationpack__common","FacialPack","Actor005")
	template1()
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoiceDirect("ノワール","0046")
-- ▲直接出力

	--★★ノワール★★:…で、俺のところに来たって？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_003_0120002")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("女子1", "挨拶")
-- ▲直接出力

	--★★キャメロット騎士学術院（女）★★:そう！お兄さんなら知ってるでしょ！教えて、ふたりのこと！！
	Talk(Actor003,"NPCNAME_0146","speech","N","EA_003_0120003")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("男子1", "肯定3")
-- ▲直接出力

	--★★キャメロット騎士学術院（男）★★:もう俺たち、あのふたりのことを考えるだけでドキドキして夜も眠れないんだ！！！
	Talk(Actor002,"NPCNAME_0151","speech","N","EA_003_0120004")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("男子2", "肯定")
-- ▲直接出力

	--★★キャメロット騎士学術院（男）②★★:人助けと思って、何卒！！！
	Talk(Actor004,"NPCNAME_0153","speech","N","EA_003_0120005")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0034")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:そう言われても…俺も詳しいことはあんまり知らないし
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_003_0120007")

	change_face(Actor001,"Normal")

	--★★ノワール★★:なんかあのふたり、気づいたら仲良くなってたんだよな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_003_0120008")

-- ▼直接出力
SkipDefaultMotion(Actor003)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoice("女子1", "納得")
-- ▲直接出力

	--★★キャメロット騎士学術院（女）★★:ヒソヒソ…兄に隠れて…？
	Talk(Actor003,"NPCNAME_0146","speech","N","EA_003_0120009")

-- ▼直接出力
SkipDefaultMotion(Actor002)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("男子1", "落胆")
-- ▲直接出力

	--★★キャメロット騎士学術院（男）★★:ヒソヒソ…障害が大きいほど燃える…？
	Talk(Actor002,"NPCNAME_0151","speech","N","EA_003_0120010")

	PlayAction(Actor004,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoice("男子2", "照れ")
-- ▲直接出力

	--★★キャメロット騎士学術院（男）②★★:ヒソヒソ…禁断の…？
	Talk(Actor004,"NPCNAME_0153","speech","N","EA_003_0120011")

-- ▼直接出力
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor003,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0040")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:そういうのじゃない！たぶん！あとその手の話を当事者の家族にするな！！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_003_0120012")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
Appear(Actor005)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor005,"to Run")
-- ▲直接出力
-- ▼直接出力
slidemove(Actor005,{0.152,0,-2.024},2.0)
-- ▲直接出力
-- ▼直接出力
wait_time(1.9)
-- ▲直接出力
-- ▼直接出力
turn(Actor005,0,39,0,0.1)
-- ▲直接出力
-- ▼直接出力
wait_time(0.1)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor005,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("女子2", "挨拶")
-- ▲直接出力

	--★★キャメロット騎士学術院（女）②★★:ちょっと、ノワール！大変！あなたの妹さん…
	Talk(Actor005,"NPCNAME_0147","speech","N","EA_003_0120014")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Sad")

	--★★ノワール★★:ああ、もう！今度はなんだよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_003_0120015")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor005,"to  Std_Talk")

	--★★キャメロット騎士学術院（女）②★★:あなたの妹さん、呼び出されたって！
	Talk(Actor005,"NPCNAME_0147","speech","N","EA_003_0120016")

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
	InitializeCharacter_3D_Preload("401005","001","401005001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("401006","001","401006001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("401007","001","401007001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("401008","001","401008001","content_animationpack__common","FacialPack","Actor005")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110011_04)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
