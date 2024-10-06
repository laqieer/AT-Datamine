-- このluaスクリプトは、MA_01108_903.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPosDuelCommonFormation01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_002)
	Camera002 = SetTemplate("Actor002",85.891,CharaPosDuelCommonFormation01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_006)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
-- ▼直接出力
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
DontChangeRandomCamera(true)
set_enable_auto_lookat_all(false)
lookoj_noir = create_object("kara_noir")
set_pos_object(lookoj_noir,-0.36,1.1,0.27)
lookat_weight(Actor001,{1.0,0.03,1.0,0.2})
keep_ik_lookat_object(Actor001,nil,"kara_noir")
change_face(Actor001,"Sad")
-- ▲直接出力
-- ▼直接出力
set_pos(Actor002,{-2.35,0,0.75})
keep_ik_lookat(Actor002,Actor001,"J_Head")
lookoj_gine = create_object("kara_gine")
set_pos_object(lookoj_gine,-0.032,0,2.47)
-- ▲直接出力
-- ▼直接出力
RndCamera001 = RndCamera003
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101120011)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayActionDirect(Actor002,"to Wlk")
-- ▲直接出力
-- ▼直接出力
turn_lookat_position(Actor002,CharaPosDuelCommonFormation01_006[1],CharaPosDuelCommonFormation01_006[2],CharaPosDuelCommonFormation01_006[3],0)
slidemove(Actor002,CharaPosDuelCommonFormation01_006[1],CharaPosDuelCommonFormation01_006[2],CharaPosDuelCommonFormation01_006[3],1.6)
-- ▲直接出力
-- ▼直接出力
wait_time(1.6)
-- ▲直接出力
-- ▼直接出力
turn_lookat(Actor002,Actor001,0.1)
-- ▲直接出力
-- ▼直接出力
wait_time(0.1)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
keep_delay_ik_lookat(Actor001,Actor002,"J_Head",0.15)
-- ▲直接出力
-- ▼直接出力
wait_time(2.6)
-- ▲直接出力
-- ▼直接出力
keep_delay_ik_lookat_object(Actor001,nil,"kara_noir",0.2)
-- ▲直接出力
-- ▼直接出力
wait_time(1.0)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(RndCamera002)
-- ▲直接出力
-- ▼直接出力
wait_time(0.8)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor002,"to  Std_Sad01")
-- ▲直接出力
-- ▼直接出力
wait_time(2.4)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
change_face(Actor002,"Sad")
-- ▲直接出力
-- ▼直接出力
wait_time(2.0)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:…どっか、行っちゃおっか
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01108_9030002")

	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:ふたりで、どっか<br>なんもない…しずかなばしょ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01108_9030003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Laugh")

	--★★ギネヴィア★★:行き当たりばったりで探してもいいし<br>港町から船に乗って無人島へ行くのもいいわね
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01108_9030004")

-- ▼直接出力
SkipDefaultMotion(Actor002)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Worry")
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:こう暑いとさ<br>ほら、のんびりしたくなるじゃない！ 
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01108_9030005")


	--★★ノワール★★:…動物だったら<br>そこにいても気にしないか？ 
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01108_9030006")

-- ▼直接出力
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ギネヴィア★★:え？うん、いいんじゃない？<br>動物ならそんなにうるさくないだろうし
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01108_9030007")


	--★★ノワール★★:…汚されるかも、しれないけどな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01108_9030008")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
-- ▼直接出力
keep_delay_ik_lookat_object(Actor002,nil,"kara_gine",0.9)
-- ▲直接出力
-- ▼直接出力
wait_time(1.0)
-- ▲直接出力
	open_cutin(1,2)
	on_cutin(1,Actor002,"Surprise")

	--★★ギネヴィア★★:あああ～～～っ！？<dot>踏ん</dot>じゃってる～！<br>お気に入りのブーツなのに！！
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","N","MA_01108_9030009")

	close_cutin()
-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
wait_time(0.6)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
-- ▼直接出力
keep_delay_ik_lookat(Actor001,Actor002,"J_Head",0.15)
-- ▲直接出力
-- ▼直接出力
wait_time(0.8)
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:…ありがとう<br>励ましてくれて
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01108_9030010")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
-- ▼直接出力
keep_delay_ik_lookat(Actor002,Actor001,"J_Head",0.8)
-- ▲直接出力
-- ▼直接出力
wait_time(0.8)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:…いつかのお礼
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01108_9030011")

	change_face(Actor002,"Laugh")

	--★★ギネヴィア★★:一緒に…いよう？<br>どこかに行かなくってもいいよ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01108_9030012")

-- ▼直接出力
SkipDefaultMotion(Actor002)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Sad01")

	--★★ギネヴィア★★:そばにいるよ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01108_9030013")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
wait_time(1.5)
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01108_9030014")

-- ▼直接出力
SkipDefaultMotion(Actor001)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_No")

	--★★ノワール★★:あの…近づかないでくれる？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01108_9030015")

	PlayAction(Actor002,"to  Std_Angry")
	change_face(Actor002,"Anger")

	--★★ギネヴィア★★:ば、ばか！ばーか！！<br>近づいてやるわ逆に！！
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01108_9030016")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
wait_time(0.6)
-- ▲直接出力
-- ▼直接出力
show_image("101010140", 0.0, 0.0, 2.0,false,false)
-- ▲直接出力
-- ▼直接出力
set_scale_image(20,20)
-- ▲直接出力
-- ▼直接出力
wait_time(0.5)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor001,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor002,"to Wlk")
-- ▲直接出力
-- ▼直接出力
turn_lookat_position(Actor002,0.1,0,0.11,0.1)
-- ▲直接出力
-- ▼直接出力
slidemove(Actor002,0.1,0,0.11,1.5)
-- ▲直接出力
-- ▼直接出力
wait_time(1.5)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
wait_time(1.6)
-- ▲直接出力
	change_face(Actor002,"Shy")

	--★★ギネヴィア★★:………どこまでだったら、いい？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01108_9030017")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
RndCamera001 = RndCamera003
	InitializeLoad_Preload()
	load_duel_scene_preload(101120011)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
