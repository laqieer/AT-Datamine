-- このluaスクリプトは、EA_004_054.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110901_01","110901_01_h")
Include("content_adv_advsmall_110901_01","Template110901_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110901_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110901_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_016_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_005)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110901_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_510_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_006)
	Camera004 = SetTemplate("Actor004",250,CharaPos110901_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_511_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_006)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110901_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_008_01_SitController","to Sit01_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_001)
	Camera006 = SetTemplate("Actor006",nil,CharaPos110901_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_509_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_007)
	Camera007 = SetTemplate("Actor007",120,CharaPos110901_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Npc_008_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_007)
	Camera008 = SetTemplate("Actor008",112,CharaPos110901_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_007)
	InitializeTemplateRandomCamera110901_01()
	InitializeTemplate110901_01()
-- ▼直接出力
keep_ik_lookat(Actor001,Actor002,"J_Head")
-- ▲直接出力
-- ▼直接出力
set_pos(Actor004,{1.5,0,1.92})
set_enable_auto_lookat(Actor004, false)
-- ▲直接出力
-- ▼直接出力
lookat_weight(Actor005,0.5,0.1,0.85,0.2)
keep_ik_lookat(Actor005,Actor002,"J_Head")
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor006, false)
-- ▲直接出力
-- ▼直接出力
set_pos(Actor007,{-0.7,0,2.12})
set_enable_auto_lookat(Actor007, false)
-- ▲直接出力
-- ▼直接出力
set_pos(Actor008,{-1.25,0,1.67})
set_enable_auto_lookat(Actor008, false)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110901)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101054","005","101054005","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101034","001","101034001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101035","001","101035001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101026","001","101026001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101027","001","101027001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("101040","001","101040001","content_animationpack__common","FacialPack","Actor007")
	Actor008 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor008")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール","肯定")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:お疲れ様でした、アダン先生
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_004_0540004")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("アダン","肯定")
-- ▲直接出力

	--★★アダン★★:そう呼ばれるのも今日までですね<br>なかなか楽しい時間でしたよ
	Talk(Actor002,"CHRNAME_ADAM","speech","L","EA_004_0540005")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("アダン","笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★アダン★★:若者の成長に立ち会えるのはいいものですね<br>特に最後の模擬戦は本当に素晴らしかった
	Talk(Actor002,"CHRNAME_ADAM","speech","L","EA_004_0540006")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("エクセリア","笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★エクセリア★★:勝利を収められたのはノワールのおかげよ<br>ありがとう
	Talk(Actor003,"CHRNAME_EXCELIA","speech","L","EA_004_0540007")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール","照れ")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:いや、そんな――
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_004_0540008")

-- ▼直接出力
set_enable_auto_lookat(Actor006,true)
set_enable_auto_lookat(Actor004,true)
set_enable_auto_lookat(Actor007,true)
set_enable_auto_lookat(Actor008,true)
-- ▲直接出力
	play_head_motion(Actor005, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("パーシヴァル","怒り")
-- ▲直接出力
	change_face(Actor005,"Anger")

	--★★パーシヴァル★★:勘違いするなよ、ノワール<br>ぼくが負けたのは、キミにじゃない
	Talk(Actor005,"CHRNAME_PERCIVAL","speech","L","EA_004_0540010")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("パーシヴァル","0019")
-- ▲直接出力

	--★★パーシヴァル★★:エクセリアの戦術がほんのちょっとだけ<br>ぼくより優れていたというだけさ！
	Talk(Actor005,"CHRNAME_PERCIVAL","speech","L","EA_004_0540011")

-- ▼直接出力
set_enable_auto_lookat(Actor006,false)
set_enable_auto_lookat(Actor004,false)
set_enable_auto_lookat(Actor007,false)
set_enable_auto_lookat(Actor008,false)
-- ▲直接出力

	--★★ノワール★★:素直に認めるんだ。珍しい
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_004_0540013")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("パーシヴァル","肯定")
-- ▲直接出力
	change_face(Actor005,"Smile")

	--★★パーシヴァル★★:当たり前だろう？<br>貴族とは常に公平に物事を見るのさ
	Talk(Actor005,"CHRNAME_PERCIVAL","speech","L","EA_004_0540014")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor005,"Sad")

	--★★パーシヴァル★★:エクセリアの戦術はチームのメンバーに<br>無理を強いるものではなくなっていた
	Talk(Actor005,"CHRNAME_PERCIVAL","speech","L","EA_004_0540015")

-- ▼直接出力
PlayPartVoice("パーシヴァル","悩む")
-- ▲直接出力

	--★★パーシヴァル★★:頭の中の最適解に拘らず、その場の戦力に即した<br>最適解を執ることができていた…
	Talk(Actor005,"CHRNAME_PERCIVAL","speech","L","EA_004_0540016")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
	change_face(Actor005,"Smile")

	--★★パーシヴァル★★:まったく…<br>最初からそういうふうにしてくれればさぁ！
	Talk(Actor005,"CHRNAME_PERCIVAL","speech","L","EA_004_0540017")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor006,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ディンドラン","笑い")
-- ▲直接出力
	change_face(Actor006,"Smile")

	--★★ディンドラン★★:よかったですね、パー坊<br>彼女のこと心配してましたもんね～
	Talk(Actor006,"CHRNAME_DINDRANE","speech","L","EA_004_0540019")

-- ▼直接出力
set_enable_auto_lookat(Actor005,false)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("エクセリア","驚き")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★エクセリア★★:え
	Talk(Actor003,"CHRNAME_EXCELIA","speech","L","EA_004_0540020")

-- ▼直接出力
PlayPartVoice("パーシヴァル","驚き")
-- ▲直接出力
	change_face(Actor005,"Surprise")

	--★★パーシヴァル★★:義姉さん！？
	Talk(Actor005,"CHRNAME_PERCIVAL","speech","L","EA_004_0540021")

	PlayAction(Actor006,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ディンドラン","驚き")
-- ▲直接出力
	change_face(Actor006,"Surprise")

	--★★ディンドラン★★:あ！いけない！！<br>これは絶対ナイショなんでした！！
	Talk(Actor006,"CHRNAME_DINDRANE","speech","L","EA_004_0540022")

	play_head_motion(Actor005, "No", 0.3, 1.0, false)
	change_face(Actor005,"Sad")

	--★★パーシヴァル★★:まったく、義姉さんときたら…
	Talk(Actor005,"CHRNAME_PERCIVAL","speech","L","EA_004_0540025")

-- ▼直接出力
set_enable_auto_lookat(Actor005,true)
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("エクセリア","笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★エクセリア★★:…色々と気にかけてくれていたのね<br>ありがとう、パーシヴァル
	Talk(Actor003,"CHRNAME_EXCELIA","speech","L","EA_004_0540026")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor005,"Surprise")

	--★★パーシヴァル★★:ま、まぁ？<br>ゲストを気遣うのも貴族の役目だから！？
	Talk(Actor005,"CHRNAME_PERCIVAL","speech","L","EA_004_0540027")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール","落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:ほんとに素直じゃない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_004_0540028")

-- ▼直接出力
PlayPartVoice("パーシヴァル","怒り")
-- ▲直接出力
	change_face(Actor005,"Anger")

	--★★パーシヴァル★★:うるさいな！そんなことより…<br>このぼくがここまで協力したんだ
	Talk(Actor005,"CHRNAME_PERCIVAL","speech","L","EA_004_0540029")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("パーシヴァル","笑い")
-- ▲直接出力
	change_face(Actor005,"Smile")

	--★★パーシヴァル★★:キミのクラスの出し物、<br>さぞ面白いものになるんだろうね？
	Talk(Actor005,"CHRNAME_PERCIVAL","speech","L","EA_004_0540030")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール","笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:ああ、もちろん
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_004_0540032")

-- ▼直接出力
bgm_play("Stop_BGM_Bus_MidFade")
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110901)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101054","005","101054005","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101034","001","101034001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101035","001","101035001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101026","001","101026001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101027","001","101027001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("101040","001","101040001","content_animationpack__common","FacialPack","Actor007")
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor008")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110901_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
