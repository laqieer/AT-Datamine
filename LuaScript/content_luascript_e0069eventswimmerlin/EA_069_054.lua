-- このluaスクリプトは、EA_069_054.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPosDuelCommonFormation01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_005_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_003)
	Camera002 = SetTemplate("Actor002",115,CharaPosDuelCommonFormation01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_005)
	Camera003 = SetTemplate("Actor003",125,CharaPosDuelCommonFormation01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_503_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_006)
	Camera004 = SetTemplate("Actor004",nil,CharaPosDuelCommonFormation01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_512_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_002)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
-- ▼直接出力
load_image("201010840","content_still_20101084_image","201010840_StillImage")
-- ▲直接出力
-- ▼直接出力
set_pos(Actor001,{0.5,0,-1.1})
set_pos(Actor002,{-0.49,0,-0.58})
set_pos(Actor004,{1.04,0,-0.39})
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101050011)
	Actor001 = InitializeCharacter_3D("101015","001","101015001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101016","004","101016004","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101020","005","101020005","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_TextOnly()
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("アーサー","0009")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★アーサー★★:さて…人も動物たちも平穏を取り戻したところで<br>夏休み再開といこう！
	Talk(Actor001,"CHRNAME_ARTHUR","speech","L","EA_069_0540002")

-- ▼直接出力
wait_time(0.2)
setup_small_camera_start(RndCamera009)
-- ▲直接出力

	--★★ギネヴィア/ギネマウア/マーリン★★:おー！
	Talk(Actor005,"CHRNAME_GUINEVERE_GWENHWYMAWR_MERLIN","speech","L","EA_069_0540003")

-- ▼直接出力
wait_time(0.2)
setup_small_camera_start(Camera002)
wait_time(0.2)
PlayActionDirect(Actor002,"to Wlk")
turn_chara(Actor002,-15,0.4)
wait_time(0.4)
PlayActionDirect(Actor002,"to Std_Loop")
wait_time(0.2)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ギネヴィア","swim_0002")
keep_delay_ik_lookat(Actor003,Actor002,"J_Head",0.4)
lookat_delay_weight(Actor003,0.45,0.5,0.5,0.4,0.4)
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:せっかく海辺に来たんだし<br>わたし、砂遊びとかしたいな～
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","EA_069_0540004")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
voice_play("VO_101011_sp_0003_1")
-- ▲直接出力

	--★★ギネヴィア★★:砂でキャメリアード城を作るんだから！<br>お姉ちゃん、手伝ってくれるよね？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","EA_069_0540005")

-- ▼直接出力
setup_small_camera_start(RndCamera002)
keep_delay_ik_lookat(Actor002,Actor003,"J_Head",1.5)
lookat_delay_weight(Actor002,0.45,0.5,0.5,0.4,1.5)
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ギネマウア","0010")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ギネマウア★★:もちろん
	Talk(Actor003,"CHRNAME_GWENHWYMAWR","speech","L","EA_069_0540006")

	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
wait_time(0.3)
PlayPartVoiceDirect("ギネヴィア","swim_0012")
-- ▲直接出力

	--★★ギネヴィア★★:やったー！
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","EA_069_0540007")

-- ▼直接出力
setup_small_camera_start(RndCamera001)
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("アーサー","0012")
-- ▲直接出力

	--★★アーサー★★:おお、いいなぁ砂遊び！<br>夏って感じだ！
	Talk(Actor001,"CHRNAME_ARTHUR","speech","L","EA_069_0540008")


	--★★アーサー★★:それじゃあ、俺も水着に着替えて<br>夏を満喫しちゃおうかなあ！
	Talk(Actor001,"CHRNAME_ARTHUR","speech","L","EA_069_0540009")

-- ▼直接出力
setup_small_camera_start(Camera003)
change_face(Actor002,"Laugh")
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
voice_play("VO_101016_sp_0003_1")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ギネマウア★★:ギネヴィア、本当にいいの？<br>せっかく海に来てるのに…
	Talk(Actor003,"CHRNAME_GWENHWYMAWR","speech","L","EA_069_0540010")

-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
PlayPartVoiceDirect("ギネヴィア","swim_0007")
-- ▲直接出力
	change_face(Actor002,"Shy")

	--★★ギネヴィア★★:だ、だって…恥ずかしいじゃない<br>アーサーがいるのに…
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","EA_069_0540011")

	PlayAction(Actor002,"to  Std_No")
-- ▼直接出力
PlayPartVoiceDirect("ギネヴィア","0018")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ギネヴィア★★:わたし、まだ王妃（仮）だから！<br>水着見せるとか、まだ早いと思うのよね！！
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","EA_069_0540012")

-- ▼直接出力
setup_small_camera_start(Camera003)
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★ギネマウア★★:ええ～…
	Talk(Actor003,"CHRNAME_GWENHWYMAWR","speech","L","EA_069_0540013")

-- ▼直接出力
setup_small_camera_start(RndCamera001)
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("アーサー","0011")
-- ▲直接出力

	--★★アーサー★★:ハハハ！いいじゃないか！<br>無理強いするものでもないし！
	Talk(Actor001,"CHRNAME_ARTHUR","speech","L","EA_069_0540014")

-- ▼直接出力
PlayActionDirect(Actor001,"to Wlk")
turn_chara(Actor001,-5,0.4)
wait_time(0.4)
PlayActionDirect(Actor001,"to Std_Loop")
keep_delay_ik_lookat(Actor001,Actor004,"J_Head",0.7)
lookat_delay_weight(Actor001,0.45,0.5,0.5,0.4,0.7)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("アーサー","0009")
-- ▲直接出力

	--★★アーサー★★:楽しいのが一番だ！<br>なあ、マーリン
	Talk(Actor001,"CHRNAME_ARTHUR","speech","L","EA_069_0540015")

-- ▼直接出力
setup_small_camera_start(Camera004)
-- ▲直接出力
	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("マーリン","0008")
-- ▲直接出力

	--★★マーリン★★:ええ、そうですね
	Talk(Actor004,"CHRNAME_MERLIN","speech","L","EA_069_0540016")

	change_face(Actor004,"Smile")

	--★★マーリン★★:いつかギネヴィア様が水着を見せてもいいと<br>思えるくらい心を開ける相手に出会えるまで――
	Talk(Actor004,"CHRNAME_MERLIN","speech","L","EA_069_0540017")

	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("マーリン","0010")
wait_time(0.5)
-- ▲直接出力

	--★★マーリン★★:水着のお披露目はとっておく、ということで
	Talk(Actor004,"CHRNAME_MERLIN","speech","L","EA_069_0540018")

-- ▼直接出力
setup_small_camera_start(Camera003)
change_face(Actor003,"Normal")
wait_time(0.5)
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
wait_time(0.1)
PlayPartVoiceDirect("ギネマウア_004","0008")
-- ▲直接出力
	change_face(Actor003,"Laugh")

	--★★ギネマウア★★:…そうですね
	Talk(Actor003,"CHRNAME_GWENHWYMAWR","speech","L","EA_069_0540019")


	--★★ギネマウア★★:そのときまで殿下をしっかりお守りしないと<br>侍女として――姉として
	Talk(Actor003,"CHRNAME_GWENHWYMAWR","speech","L","EA_069_0540020")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN)
show_image("201010840", 0.0, 0.0, STILL_SWITCH_TIME ,true,true)
set_scale_image(0.8,0.8)
wait_time(0.7)
fadein(0.4)
wait_time(0.3)
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ギネマウア★★:大切なものをたくさん失ったけれど<br>故郷にも今はまだ帰れないけれど
	Talk(Actor003,"CHRNAME_GWENHWYMAWR","simple","N","EA_069_0540033")


	--★★ギネマウア★★:それでも、私の傍には守るべきあなたがいる<br>希望はまだここにある
	Talk(Actor003,"CHRNAME_GWENHWYMAWR","simple","N","EA_069_0540034")


	--★★ギネマウア★★:ふたりで結んだ力でいつか<br>故郷を取り戻す日がきっと来る
	Talk(Actor003,"CHRNAME_GWENHWYMAWR","simple","N","EA_069_0540035")


	--★★ギネマウア★★:そのときが来ることを信じて<br>今はただ、あなたの笑顔を守るわ
	Talk(Actor003,"CHRNAME_GWENHWYMAWR","simple","N","EA_069_0540036")

-- ▼直接出力
PlayPartVoiceDirect("ギネマウア","0010")
-- ▲直接出力

	--★★ギネマウア★★:思い出は<br>そのための力になるから
	Talk(Actor003,"CHRNAME_GWENHWYMAWR","simple","N","EA_069_0540037")

-- ▼直接出力
bgm_play("Stop_BGM_Bus_LongFade")
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("201010840","content_still_20101084_image","201010840_StillImage")
	InitializeLoad_Preload()
	load_duel_scene_preload(101050011)
	InitializeCharacter_3D_Preload("101015","001","101015001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101016","004","101016004","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101020","005","101020005","content_animationpack__common","FacialPack","Actor004")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
