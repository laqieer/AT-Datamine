-- このluaスクリプトは、MA_01A112_50.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110111_01","110111_01_h")
Include("content_adv_advsmall_110111_01","Template110111_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110111_01_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_008)
	Camera002 = SetTemplate("Actor002",-110,CharaPos110111_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110111_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Npc_023_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_005)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110111_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Npc_023_02_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_006)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110111_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Npc_504_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_007)
	InitializeTemplateRandomCamera110111_01()
	InitializeTemplate110111_01()
-- ▼直接出力
BgProp = setup_prop_object(10102012)
set_pos(BgProp,{0,0,0})
Hide(Actor001)
set_pos(Actor001,{-7.5,0,-4.35})
set_rot(Actor001,{0,50,0})
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor003,false)
set_enable_auto_lookat(Actor004,false)
set_enable_auto_lookat(Actor005,false)
lookat_weight_reset(Actor003)
lookat_weight_reset(Actor004)
lookat_weight_reset(Actor005)
keep_ik_lookat(Actor002,Actor004,"J_Head")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115113)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("401023","001","401023001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("401025","001","401025001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("401012","001","401012001","content_animationpack__common","FacialPack","Actor005")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:ぜぇんぶ丸く収まる<br>なんてことはないでしょうね
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A112_500002")


	--★★ギネヴィア★★:喪ったものは戻らないし<br>キズのなかには癒せないものもある
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A112_500003")

-- ▼直接出力
setup_small_camera_start(RndCamera004)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Sad02")
-- ▼直接出力
 --PlayPartVoice("貴族_男1", "悩む")
-- ▲直接出力

	--★★貴族（男）★★:…ロンディニウムの件は<br>それこそブリテンに深いキズを残した…
	Talk(Actor003,"NPCNAME_0128","speech","N","MA_01A112_500004")

	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("貴族_男2", "肯定")
-- ▲直接出力

	--★★貴族（男）②★★:ですがギネヴィア様<br>たちの勝利がもたらしたものは大きい
	Talk(Actor004,"NPCNAME_0129","speech","N","MA_01A112_500005")


	--★★ギネヴィア★★:取り返しのつかないことも<br>あるけど
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A112_500006")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:取り戻してやったモンもあるからね
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A112_500007")

	PlayAction(Actor004,"to  Std_Worry")
-- ▼直接出力
 --PlayPartVoice("貴族_男2", "肯定3")
-- ▲直接出力

	--★★貴族（男）②★★:…変わられましたな、殿下
	Talk(Actor004,"NPCNAME_0129","speech","N","MA_01A112_500008")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_No")
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "否定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:殿下はヤメて
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A112_500009")


	--★★ギネヴィア★★:婚姻はナシになったの、知ってるでしょ？<br>わたしは王に恥をかかせた面汚し
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A112_500010")

-- ▼直接出力
setup_small_camera_start(RndCamera001)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:だけどその代わりローマのツラもブン殴るから<br>勘弁してよね
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A112_500011")

	PlayAction(Actor005,"to  Std_Surp")
-- ▼直接出力
change_face(Actor002,"Normal")
 --PlayPartVoice("市民_男2", "肯定2")
-- ▲直接出力

	--★★市民（女）★★:ギネヴィア様、どうか<br>亡くなった者たちの無念を…どうか
	Talk(Actor005,"NPCNAME_0182","speech","N","MA_01A112_500012")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:わかってる。見てて<br>わたしにしかできないこと、見つけたから
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A112_500013")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ギネヴィア★★:もう、おままごとじゃないからね
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A112_500014")

-- ▼直接出力
Appear(Actor001)
keep_ik_lookat(Actor001,Actor002,"J_Head")
PlayActionDirect(Actor001,"to Wlk")
slidemove(Actor001,{-5.3,0,-2.5}, 2.2)
CloseTalkWindow()
setup_small_camera_start(RndCamera002)
wait_time(2)
PlayActionDirect(Actor001,"to Std_Loop")
wait_time(0.3)
PlayActionDirect(Actor001,"to Greet_one")
change_face(Actor001,"Smile")
wait_time(2)
setup_small_camera_start(Camera002)
keep_delay_ik_lookat(Actor002,Actor001,"J_Head",0.7)
change_face(Actor002,"Surprise")
wait_time(1.5)
-- ▲直接出力
	PlayAction(Actor002,"to Bow")
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:ごめんあそばせ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A112_500016")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(TIME_ELAPSED + FADE_TIME)
Hide(Actor003)
Hide(Actor004)
Hide(Actor005)
Camera001=setup_small_camera_resetting(Actor001,CharaPos006,CameraPos006)
change_face(Actor001,"Normal")
change_face(Actor002,"Normal")
set_enable_auto_lookat_all(false)
lookat_weight_reset(Actor001)
lookat_weight_reset(Actor002)
setup_small_camera_start(RndCamera001)
fadein(FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力
	PlayAction(Actor001,"to Greet_one")
-- ▼直接出力
 --PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:お邪魔だった？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A112_500018")

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
change_face(Actor002,"Smile")
 --PlayPartVoice("ギネヴィア", "照れ")
-- ▲直接出力

	--★★ギネヴィア★★:にっしっし…♪<br>あなたに会えたらなあって思ってた
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A112_500020")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
SkipDefaultMotion(Actor002)
PlayActionDirect(Actor002,"to Finger")
-- ▲直接出力

	--★★ギネヴィア★★:エスコート、よろしくね？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A112_500021")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
setup_prop_object_preload(10102012)
	InitializeLoad_Preload()
	load_area_scene_preload(115113)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("401023","001","401023001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("401025","001","401025001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("401012","001","401012001","content_animationpack__common","FacialPack","Actor005")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110111_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
