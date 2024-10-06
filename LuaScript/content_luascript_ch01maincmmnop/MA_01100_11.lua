-- このluaスクリプトは、MA_01100_11.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_113021_02","113021_02_h")
Include("content_adv_advsmall_113021_02","Template113021_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos113021_02_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName113021_02,CameraPos113021_02_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos113021_02_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName113021_02,CameraPos113021_02_005)
	Camera003 = SetTemplate("Actor003",nil,CharaPos113021_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_005_01_StdController","to Std_Loop",CameraAssetBundleName113021_02,CameraPos113021_02_002)
	Camera004 = SetTemplate("Actor004",nil,CharaPos113021_02_003,"content_motion3d_advarea_common_adv_templatecontroller","Npc_008_01_StdController","to Std_Loop",CameraAssetBundleName113021_02,CameraPos113021_02_003)
	Camera005 = SetTemplate("Actor005",nil,CharaPos113021_02_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_503_01_StdController","to Std_Loop",CameraAssetBundleName113021_02,CameraPos113021_02_006)
	Camera006 = SetTemplate("Actor006",nil,CharaPos113021_02_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop",CameraAssetBundleName113021_02,CameraPos113021_02_004)
	InitializeTemplateRandomCamera113021_02()
	InitializeTemplate113021_02()
-- ▼直接出力
ShowGlobalMenuButton(false)
SetTrackingId(60)
-- ▲直接出力
-- ▼直接出力
Hide(Actor002)
set_pos(Actor002,{-0.164, 0, -2.496})
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor003,false)
set_common_look_at(Actor003,Actor001)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor004,false)
set_common_look_at(Actor004,Actor001)
-- ▲直接出力
-- ▼直接出力
Hide(Actor005)
set_pos(Actor005,{0.463, 0.055, -3.017})
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor006,false)
set_common_look_at(Actor006,Actor001)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(113021)
	Actor001 = InitializeCharacter_3D("101009","003","101009003","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101015","001","101015001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101040","001","101040001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101016","001","101016001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_TextOnly()
	template1()
end

function Play()
	StartPlay()

	PlayAction(Actor003,"to  Std_Talk")

	--★★アーサー★★:さあ。進路相談といこうか
	Talk(Actor003,"CHRNAME_NAMELES","speech","L","MA_01100_110002")


	--★★ノワール★★:──…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01100_110003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ケイ★★:傭兵団『不格好なコート』二代目団長ノワール<br>カレドニア国に雇われ、戦線に参加
	Talk(Actor004,"CHRNAME_NAMELES","speech","L","MA_01100_110005")


	--★★ケイ★★:カレドニアが放ったバルバロイにより団員は全滅<br>手練れ揃いと聞いていたが、所詮は二代目…
	Talk(Actor004,"CHRNAME_NAMELES","speech","L","MA_01100_110007")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:………ぜん、めつ…！？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01100_110008")

-- ▼直接出力
setup_small_camera_start(Camera004)
-- ▲直接出力

	--★★ケイ★★:推薦は確かか？<br>ランスロット
	Talk(Actor004,"CHRNAME_NAMELES","speech","L","MA_01100_110010")

-- ▼直接出力
set_common_look_at(Actor006,Actor004)
-- ▲直接出力

	--★★ランスロット★★:腕は確かだ。ケイ
	Talk(Actor006,"CHRNAME_LANCELOT","speech","L","MA_01100_110011")

-- ▼直接出力
OpenFirstAppearance(Actor004)
lookat_delay_weight_reset(Actor006,0.5)
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:………どこだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01100_110012")

-- ▼直接出力
setup_small_camera_start(Camera003)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")

	--★★アーサー★★:礼をさせてくれ<br>ノワール
	Talk(Actor003,"CHRNAME_NAMELES","speech","L","MA_01100_110014")

-- ▼直接出力
CloseTalkWindow()
se_play("SE_ADV_MA_01100_11_Jail_Door_Punch")
wait_time(0.06)
shake_camera(Camera003,0.8,0.2)
wait_time(1.0)
-- ▲直接出力
	open_cutin(1,2)
	on_cutin(1,Actor001,"Anger")

	--★★ノワール★★:俺の家族は、どこだ──…！！
	Talk(Actor001,"CHRNAME_NOIR","speech","N","MA_01100_110015")

	close_cutin()

	--★★アーサー★★:…俺の家族を救ってくれた、礼を
	Talk(Actor003,"CHRNAME_NAMELES","speech","L","MA_01100_110017")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Surp")
	change_face(Actor001,"Surprise")

	--★★ノワール★★:え…っ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01100_110018")


	--★★ギネヴィア声★★:あのねェッ！！
	Talk(Actor007,"CHRNAME_GUINEVERE","speech","N","MA_01100_110020")

-- ▼直接出力
CloseTalkWindow()
manager.CloseupUpExclusiveCamera(Actor003)
DontChangeRandomCamera(true)  
lookat_delay_weight_reset(Actor003,1.0)
lookat_delay_weight_reset(Actor004,1.0)
lookat_delay_weight_reset(Actor006,1.0)
PlayActionDirect(Actor003,"to Wlk")
turn_lookat(Actor003,Actor002,0.5)
PlayActionDirect(Actor004,"to Wlk")
turn_lookat(Actor004,Actor002,0.5)
PlayActionDirect(Actor006,"to Wlk")
turn_lookat(Actor006,Actor002,0.5)
wait_time(0.5)
PlayActionDirect(Actor003,"to Std_Loop")
PlayActionDirect(Actor004,"to Std_Loop")
PlayActionDirect(Actor006,"to Std_Loop")
wait_time(0.5)
set_enable_auto_lookat(Actor006, false)
set_enable_auto_lookat(Actor004, false)
set_enable_auto_lookat(Actor003, false)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Joy")
	open_cutin(1,1)
	on_cutin(1,Actor003,"Smile")

	--★★アーサー★★:おお、愛しのワイフ！
	Talk(Actor003,"CHRNAME_NAMELES","speech","N","MA_01100_110021")

	close_cutin()
-- ▼直接出力
CloseTalkWindow()
IN_WALK_2P(Actor002,CharaPos113021_02_005,Actor005,CharaPos113021_02_006)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor003,true)
set_enable_auto_lookat(Actor004,true)
set_enable_auto_lookat(Actor006,true)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Angry")
	open_cutin(1,2)
	on_cutin(1,Actor002,"Anger")

	--★★ギネヴィア★★:あんま大きな声で言わないでくれる！？<br>そのつもりこれっぽっちもないし！！
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","N","MA_01100_110022")

	close_cutin()
-- ▼直接出力
set_enable_auto_lookat(Actor005,false)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
	change_face(Actor003,"Normal")

	--★★アーサー★★:これから家族になるであろう<br>俺の婚約者じゃあないか！
	Talk(Actor003,"CHRNAME_NAMELES","speech","L","MA_01100_110023")


	--★★ギネヴィア★★:ばーかばーか！願い下げよ！<br>ままごとでしょ！マネごとでしょ！？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01100_110024")

-- ▼直接出力
--ケイ,CHRNAME_KAY @名前変更
-- ▲直接出力

	--★★ケイ★★:何用で？殿下
	Talk(Actor004,"CHRNAME_KAY","speech","L","MA_01100_110025")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:その傭兵、わたしが買ったの<br>勝手に持ってかないでよ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01100_110026")


	--★★ケイ★★:言い忘れておりました
	Talk(Actor004,"CHRNAME_KAY","speech","L","MA_01100_110027")

	PlayAction(Actor002,"to  Std_Angry")

	--★★ギネヴィア★★:ほざかないでよ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01100_110028")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ギネマウア★★:御言葉にはお気を付けを。殿下
	Talk(Actor005,"NPCNAME_0070","speech","L","MA_01100_110030")

-- ▼直接出力
OpenFirstAppearance(Actor005)
-- ▲直接出力

	--★★ギネヴィア★★:おふざけを仰せにならないでよ<br>ケイ？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01100_110031")

	PlayAction(Actor004,"to  Std_No")
	change_face(Actor004,"Sad")

	--★★ケイ★★:役目すらまっとう出来ませんか<br>居残りを命じたにもかかわらず、よくもまあ
	Talk(Actor004,"CHRNAME_KAY","speech","L","MA_01100_110032")

-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力

	--★★ギネヴィア★★:お飾りなんかに納まってやんないわ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01100_110033")

	change_face(Actor004,"Normal")

	--★★ケイ★★:ちゃんちゃら、可笑しい
	Talk(Actor004,"CHRNAME_KAY","speech","L","MA_01100_110034")


	--★★ギネヴィア★★:わたしの命の恩人に<br>こんな席はあんまりよ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01100_110035")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★アーサー★★:…ははあ
	Talk(Actor003,"CHRNAME_NAMELES","speech","L","MA_01100_110036")

	change_face(Actor004,"Anger")

	--★★ケイ★★:私は、承服しかねるが
	Talk(Actor004,"CHRNAME_KAY","speech","L","MA_01100_110037")


	--★★アーサー★★:空席を遊ばせておくわけにもいかん<br>と言いたげだな。ギネヴィアも？
	Talk(Actor003,"CHRNAME_NAMELES","speech","L","MA_01100_110038")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Joy")
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:にっしっし…♪
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01100_110039")

-- ▼直接出力
CloseTalkWindow()
bgm_play("Stop_BGM_Bus_MidFade")
wait_time(0.3)
-- ▲直接出力
-- ▼直接出力
fadeout(0,0,0, 1.0,BLACK_WHITE_TIME)
se_play("SE_ADV_MA_01100_11_Jail_Door_Open")
wait_time(BLACK_WHITE_TIME)
se_play("SE_ADV_MA_01100_11_Jail_Foot")
wait_time(1.0)
SetTrackingId(61)
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
	load_area_scene_preload(113021)
	InitializeCharacter_3D_Preload("101009","003","101009003","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101015","001","101015001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101040","001","101040001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101016","001","101016001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor006")
	system.PreLoadRequest(CameraAssetBundleName113021_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
